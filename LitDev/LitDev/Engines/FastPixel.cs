﻿//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
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

//Based on http://www.codeproject.com/Articles/15192/FastPixel-A-much-faster-alternative-to-Bitmap-SetP
//With corrections for stride

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace LitDev.Engines
{
    public class FastPixel
    {
        private byte[] rgbValues;
        private BitmapData bmpData;
        private IntPtr bmpPtr;
        private int stride;
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
            if ((bitmap.PixelFormat & PixelFormat.Indexed) == PixelFormat.Indexed)
            {
                throw new Exception("Cannot lock an Indexed image.");
            }

            _bitmap = bitmap;
            _isAlpha = (bitmap.PixelFormat & PixelFormat.Alpha) == PixelFormat.Alpha;
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
            stride = bmpData.Stride;
            bmpPtr = bmpData.Scan0;

            System.Array.Resize(ref rgbValues, stride * _height);
            Marshal.Copy(bmpPtr, rgbValues, 0, rgbValues.Length);

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
    }
}