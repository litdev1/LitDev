//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2015> litdev@hotmail.co.uk
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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LitDev.Engines
{
    class FastPixel
    {
        private byte[] rgbValues;
        private BitmapData bmpData;
        private IntPtr bmpPtr;
        private bool locked = false;

        private bool _isAlpha = false;
        private Bitmap _bitmap;
        private int _width;
        private int _height;

        public int Width { get { return _width; } }
        public int Height { get { return _height; } }
        public bool IsAlphaBitmap { get { return _isAlpha; } }
        public Bitmap Bitmap { get { return _bitmap; } }

        public FastPixel(Bitmap bitmap)
        {
            if (bitmap.PixelFormat == (bitmap.PixelFormat | PixelFormat.Indexed))
            {
                throw new Exception("Cannot lock an Indexed image.");
            }

            _bitmap = bitmap;
            _isAlpha = bitmap.PixelFormat == (bitmap.PixelFormat | PixelFormat.Alpha);
            _width = bitmap.Width;
            _height = bitmap.Height;
        }

        public void Lock()
        {
            if (locked)
            {
                throw new Exception("Bitmap already locked.");
            }

            Rectangle rect = new Rectangle(0, 0, _width, _height);
            bmpData = _bitmap.LockBits(rect, ImageLockMode.ReadWrite, _bitmap.PixelFormat);
            bmpPtr = bmpData.Scan0;

            if (_isAlpha)
            {
                int[] bytes = new int[_width * _height * 4];
                System.Array.Resize(ref rgbValues, _width * _height * 4);
                Marshal.Copy(bmpPtr, rgbValues, 0, rgbValues.Length);
            }
            else
            {
                int[] bytes = new int[_width * _height * 3];
                System.Array.Resize(ref rgbValues, _width * _height * 4);
                Marshal.Copy(bmpPtr, rgbValues, 0, rgbValues.Length);
            }

            locked = true;
        }

        public void Unlock(bool setPixels)
        {
            if (!locked)
            {
                throw new Exception("Bitmap not locked.");
            }

            if (setPixels)
            {
                Marshal.Copy(rgbValues, 0, bmpPtr, rgbValues.Length);
            }

            _bitmap.UnlockBits(bmpData);
            locked = false;
        }

        public void Clear(Color colour)
        {
            if (!locked)
            {
                throw new Exception("Bitmap not locked.");
            }

            if (_isAlpha)
            {
                for (int index = 0; index < rgbValues.Length; index += 4)
                {
                    rgbValues[index] = colour.B;
                    rgbValues[index + 1] = colour.G;
                    rgbValues[index + 2] = colour.R;
                    rgbValues[index + 3] = colour.A;
                }
            }
            else
            {
                for (int index = 0; index < rgbValues.Length; index += 3)
                {
                    rgbValues[index] = colour.B;
                    rgbValues[index + 1] = colour.G;
                    rgbValues[index + 2] = colour.R;
                }
            }
        }

        public void SetPixel(Point location, Color colour)
        {
            SetPixel(location.X, location.Y, colour);
        }

        public void SetPixel(int x, int y, Color colour)
        {
            if (!locked)
            {
                throw new Exception("Bitmap not locked.");
            }

            if (_isAlpha)
            {
                int index = (y * _width + x) * 4;
                rgbValues[index] = colour.B;
                rgbValues[index + 1] = colour.G;
                rgbValues[index + 2] = colour.R;
                rgbValues[index + 3] = colour.A;
            }
            else
            {
                int index = (y * _width + x) * 3;
                rgbValues[index] = colour.B;
                rgbValues[index + 1] = colour.G;
                rgbValues[index + 2] = colour.R;
            }
        }

        public Color GetPixel(Point location)
        {
            return GetPixel(location.X, location.Y);
        }

        public Color GetPixel(int x, int y)
        {
            if (!locked)
            {
                throw new Exception("Bitmap not locked.");
            }

            if (_isAlpha)
            {
                int index = (y * _width + x) * 4;
                int b = rgbValues[index];
                int g = rgbValues[index + 1];
                int r = rgbValues[index + 2];
                int a = rgbValues[index + 3];
                return Color.FromArgb(a, r, g, b);
            }
            else
            {
                int index = (y * _width + x) * 3;
                int b = rgbValues[index];
                int g = rgbValues[index + 1];
                int r = rgbValues[index + 2];
                return Color.FromArgb(r, g, b);
            }
        }
    }
}
