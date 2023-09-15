//#define SVB   
#if SVB
using Microsoft.SmallVisualBasic.Library;
using Microsoft.SmallVisualBasic.Library.Internal;
using SBArray = Microsoft.SmallVisualBasic.Library.Array;
using SBShapes = Microsoft.SmallVisualBasic.Library.Shapes;
using SBFile = Microsoft.SmallVisualBasic.Library.File;
using SBMath = Microsoft.SmallVisualBasic.Library.Math;
using SBProgram = Microsoft.SmallVisualBasic.Library.Program;
using SBControls = Microsoft.SmallVisualBasic.Library.Controls;
using SBImageList = Microsoft.SmallVisualBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallVisualBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallVisualBasic.Library.SmallVisualBasicCallback;
#else
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using SBArray = Microsoft.SmallBasic.Library.Array;
using SBShapes = Microsoft.SmallBasic.Library.Shapes;
using SBFile = Microsoft.SmallBasic.Library.File;
using SBMath = Microsoft.SmallBasic.Library.Math;
using SBProgram = Microsoft.SmallBasic.Library.Program;
using SBControls = Microsoft.SmallBasic.Library.Controls;
using SBImageList = Microsoft.SmallBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallBasic.Library.SmallBasicCallback;
#endif

//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2020> litdev@hotmail.co.uk
//This file is part of the LitDev Extension for Small Basic.

//LitDev Extension is free software: you can redistribute it and/or modify
//it under the terms of the GNU General public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//LitDev Extension is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General public License for more details.

//You should have received a copy of the GNU General public License
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

//Based on http://www.codeproject.com/Articles/15192/FastPixel-A-much-faster-alternative-to-Bitmap-SetP
//With corrections for stride

using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

namespace LitDev.Engines
{
    public class FastPixel
    {
        private byte[] rgbValues;
        private BitmapData bmpData;
        private IntPtr bmpPtr;
        private int stride;
        private bool locked = false;
        private bool indexed = false;

        private bool _isAlpha;
        private Bitmap _bitmap;
        private int _width;
        private int _height;

        public int Width { get { return _width; } }
        public int Height { get { return _height; } }
        public bool IsAlpha { get { return _isAlpha; } }
        public Bitmap Bitmap { get { return _bitmap; } }
        public BitmapImage BitmapImage { get { return GetBitmapImage(_bitmap); } }

        public static bool UseFastPixel = true;

        public FastPixel(Bitmap bitmap)
        {
            _bitmap = bitmap;
            Setup();
        }

        public FastPixel(BitmapSource bitmap)
        {
            _bitmap = GetBitmap(bitmap);
            Setup();
        }

        private void Setup()
        {
            indexed = !UseFastPixel || (_bitmap.PixelFormat & PixelFormat.Indexed) == PixelFormat.Indexed;
            _isAlpha = (_bitmap.PixelFormat & PixelFormat.Alpha) == PixelFormat.Alpha;
            _width = _bitmap.Width;
            _height = _bitmap.Height;

            if (!indexed) Lock();
        }

        private void Lock()
        {
            Rectangle rect = new Rectangle(0, 0, _width, _height);
            bmpData = _bitmap.LockBits(rect, ImageLockMode.ReadWrite, _bitmap.PixelFormat);
            stride = bmpData.Stride;
            bmpPtr = bmpData.Scan0;

            System.Array.Resize(ref rgbValues, stride * _height);
            Marshal.Copy(bmpPtr, rgbValues, 0, rgbValues.Length);

            locked = true;
        }

        public void Unlock(bool setPixels)
        {
            if (indexed || !locked) return;

            if (setPixels) Update();

            _bitmap.UnlockBits(bmpData);
            locked = false;
        }

        public void Update()
        {
            if (indexed || !locked) return;

            Marshal.Copy(rgbValues, 0, bmpPtr, rgbValues.Length);
        }

        public void Clear(Color colour)
        {
            if (indexed)
            {
                for (int x = 0; x < _width; x++)
                {
                    for (int y = 0; y < _height; y++)
                    {
                        _bitmap.SetPixel(x, y,  colour);
                    }
                }
                return;
            }

            if (!locked) return;

            if (_isAlpha)
            {
                for (int y = 0; y < _height; y++)
                {
                    int index = y * stride;
                    for (int x = 0; x < _width; x++)
                    {
                        rgbValues[index++] = colour.B;
                        rgbValues[index++] = colour.G;
                        rgbValues[index++] = colour.R;
                        rgbValues[index++] = colour.A;
                    }
                }
            }
            else
            {
                for (int y = 0; y < _height; y++)
                {
                    int index = y * stride;
                    for (int x = 0; x < _width; x++)
                    {
                        rgbValues[index++] = colour.B;
                        rgbValues[index++] = colour.G;
                        rgbValues[index++] = colour.R;
                    }
                }
            }
        }

        public void SetPixel(int x, int y, Color colour)
        {
            if (indexed)
            {
                _bitmap.SetPixel(x, y, colour);
                return;
            }

            if (!locked) return;

            if (_isAlpha)
            {
                int index = y * stride + x * 4;
                rgbValues[index] = colour.B;
                rgbValues[index + 1] = colour.G;
                rgbValues[index + 2] = colour.R;
                rgbValues[index + 3] = colour.A;
            }
            else
            {
                int index = y * stride + x * 3;
                rgbValues[index] = colour.B;
                rgbValues[index + 1] = colour.G;
                rgbValues[index + 2] = colour.R;
            }
        }

        public Color GetPixel(int x, int y)
        {
            if (indexed)
            {
                return _bitmap.GetPixel(x, y);
            }

            if (!locked) return Color.Black;

            if (_isAlpha)
            {
                int index = y * stride + x * 4;
                int b = rgbValues[index];
                int g = rgbValues[index + 1];
                int r = rgbValues[index + 2];
                int a = rgbValues[index + 3];
                return Color.FromArgb(a, r, g, b);
            }
            else
            {
                int index = y * stride + x * 3;
                int b = rgbValues[index];
                int g = rgbValues[index + 1];
                int r = rgbValues[index + 2];
                return Color.FromArgb(r, g, b);
            }
        }

        public double GetVariance(int x, int y, Color colOld, Color colNew)
        {
            double dA = 0, dR = 0, dG = 0, dB = 0;
            if (indexed)
            {
                Color c = _bitmap.GetPixel(x, y);
                if (c == colNew) return double.MaxValue;
                dA = c.A - colOld.A;
                dR = c.R - colOld.R;
                dG = c.G - colOld.G;
                dB = c.B - colOld.B;
            }
            else if (locked)
            {
                if (_isAlpha)
                {
                    int index = y * stride + x * 4;
                    if (rgbValues[index] == colNew.B && rgbValues[index + 1] == colNew.G && rgbValues[index + 2] == colNew.R && rgbValues[index + 3] == colNew.A) return double.MaxValue;
                    dB = rgbValues[index] - colOld.B;
                    dG = rgbValues[index + 1] - colOld.G;
                    dR = rgbValues[index + 2] - colOld.R;
                    dA = rgbValues[index + 3] - colOld.A;
                }
                else
                {
                    int index = y * stride + x * 3;
                    if (rgbValues[index] == colNew.B && rgbValues[index + 1] == colNew.G && rgbValues[index + 2] == colNew.R) return double.MaxValue;
                    dB = rgbValues[index] - colOld.B;
                    dG = rgbValues[index + 1] - colOld.G;
                    dR = rgbValues[index + 2] - colOld.R;
                }
            }
            if (dA == 0) return (dR * dR + dG * dG + dB * dB) / 3.0;
            else return (dA * dA + dR * dR + dG * dG + dB * dB) / 4.0;
        }

        public static Stopwatch swGetBitmap = new Stopwatch();
        public static Stopwatch swGetBitmapImage = new Stopwatch();

        public static Bitmap GetBitmap(BitmapSource bmSource)
        {
            //InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
            //{
                swGetBitmap.Start();
                MemoryStream ms = new MemoryStream();
                BitmapEncoder enc = new PngBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bmSource));
                enc.Save(ms);
                Bitmap bm = new Bitmap(ms);
                swGetBitmap.Stop();
                return bm;
            //});
            //return (Bitmap)FastThread.InvokeWithReturn(ret);
        }

        public static BitmapImage GetBitmapImage(Bitmap bm)
        {
            //InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
            //{
                swGetBitmapImage.Start();
                MemoryStream ms = new MemoryStream();
                bm.Save(ms, ImageFormat.Png);
                BitmapImage bmImage = new BitmapImage();
                bmImage.BeginInit();
                bmImage.StreamSource = ms;
                bmImage.EndInit();
                swGetBitmapImage.Stop();
                return bmImage;
            //});
            //return (BitmapImage)FastThread.InvokeWithReturn(ret);
        }
    }
}
