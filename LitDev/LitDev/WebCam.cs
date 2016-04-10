//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2015> litdev@hotmail.co.uk
//This file is part of the LitDev Extension for Small Basic.

//LitDev Extension is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//LitDev Extension is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with menu.  If not, see <http://www.gnu.org/licenses/>.

using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace LitDev
{
    public enum eEffect
    {
        NONE,
        RED,
        GREEN,
        BLUE,
        GRAY,
        INVERSE,
        YELLOW,
        CYAN,
        MAGENTA,
        SNOW,
        FUZZY,
        CONTRAST,
        BLOCKS,
        REFLECT,
        JAGGED,
        ROTATE,
        PIXELATE,
        GAMMA,
        FISHEYE,
        BULGE,
        SWIRL,
        POSTERISE,
        HUE,
        SATURATION,
        LIGHTNESS,
        OILPAINT,
        CHARCOAL,
        SKETCH,
        CARTOON,
        EDGE,
    }

    /// <summary>
    /// Provides access to a webcam.
    /// </summary>
    [SmallBasicType]
    public static class LDWebCam
    {
        [DllImport("user32", EntryPoint = "SendMessage")]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);

        [DllImport("avicap32.dll", EntryPoint = "capCreateCaptureWindowA")]
        private static extern IntPtr capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, IntPtr hwndParent, int nID);

        private const int WM_USER = 1024;
        private const int WM_CAP_CONNECT = 1034;
        private const int WM_CAP_DISCONNECT = 1035;
        private const int WM_CAP_GET_FRAME = 1084;
        private const int WM_CAP_COPY = 1054;

        private const int WS_CHILD = 0x40000000;
        private const int WS_VISIBLE = 0x10000000;

        private const int WM_CAP_START = WM_USER;
        private const int WM_CAP_SET_SCALE = WM_CAP_START + 53;
        private const int WM_CAP_SET_PREVIEWRATE = WM_CAP_START + 52;
        private const int WM_CAP_SET_PREVIEW = WM_CAP_START + 50;

        private static Type GraphicsWindowType = typeof(GraphicsWindow);
        private static Type ShapesType = typeof(Shapes);
        private static IntPtr hWnd = IntPtr.Zero;
        private static int _width, _height;
        private static bool connected = false;
        private static string shapeName;
        private static PictureBox pictureBox = new PictureBox();
        private static List<Image> images = new List<Image>();
        private static System.Windows.Forms.Timer timer;
        private static int interval = 20;
        private static MethodInfo method1 = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
        private static MethodInfo method2 = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
        private static MethodInfo method3 = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
        private static eEffect effect = eEffect.NONE;
        private static Primitive _parameter = "";
        private static Boolean useAvicap = false;
        private static Object lockUpdate = new Object();

        public static Primitive[] pEffect = new Primitive[] { "", "", "", "", "", "", "", "", "", 25, 4, 2, 5, "", 4, "", 16, 2, 2, 2, 1, 50, 180, 2, 2, "1=7;2=20;", "", "", "1=7;2=20;3=40;", "" };
        private static FIP fip = new FIP();

        //public static bits to be threadsafe
        public static System.Drawing.Bitmap bitmap = null;
        public static System.Drawing.Image dImg = null;
        public static Capture cam = null;

        private static double xscale, yscale;
        private static double xshift, yshift;
        private static double thresh = 1;
        private static double getRadialX(double x, double y, double cx, double cy, double k)
        {
            x = (x * xscale + xshift);
            y = (y * yscale + yshift);
            double res = x + ((x - cx) * k * ((x - cx) * (x - cx) + (y - cy) * (y - cy)));
            return res;
        }
        private static double getRadialY(double x, double y, double cx, double cy, double k)
        {
            x = (x * xscale + xshift);
            y = (y * yscale + yshift);
            double res = y + ((y - cy) * k * ((x - cx) * (x - cx) + (y - cy) * (y - cy)));
            return res;
        }
        private static double calc_shift(double x1, double x2, double cx, double k)
        {
            double x3 = (x1 + (x2 - x1) * 0.5);
            double res1 = x1 + ((x1 - cx) * k * ((x1 - cx) * (x1 - cx)));
            double res3 = x3 + ((x3 - cx) * k * ((x3 - cx) * (x3 - cx)));

            if (res1 > -thresh && res1 < thresh) return x1;
            if (res3 < 0)
            {
                return calc_shift(x3, x2, cx, k);
            }
            else
            {
                return calc_shift(x1, x3, cx, k);
            }
        }

        public static System.Drawing.Image DoEffect(System.Drawing.Image _dImg, eEffect _effect, Primitive parameter)
        {
            if (_effect == eEffect.NONE || null == _dImg) return _dImg;

            System.Drawing.Bitmap bmap = new System.Drawing.Bitmap(_dImg);

            switch (_effect)
            {
                case eEffect.NONE: //None
                    break;
                case eEffect.RED: //Red
                    {
                        System.Drawing.Color c;
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);
                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, c.R, 0, 0));
                            }
                        }
                    }
                    break;
                case eEffect.GREEN: //Green
                    {
                        System.Drawing.Color c;
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);
                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, 0, c.G, 0));
                            }
                        }
                    }
                    break;
                case eEffect.BLUE: //Blue
                    {
                        System.Drawing.Color c;
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);
                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, 0, 0, c.B));
                            }
                        }
                    }
                    break;
                case eEffect.GRAY: //Gray
                    {
                        System.Drawing.Color c;
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);
                                byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, gray, gray, gray));
                            }
                        }
                    }
                    break;
                case eEffect.INVERSE: //Inverse
                    {
                        System.Drawing.Color c;
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);
                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, 255 - c.R, 255 - c.G, 255 - c.B));
                            }
                        }
                    }
                    break;
                case eEffect.YELLOW: //Yellow
                    {
                        System.Drawing.Color c;
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);
                                byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, gray, gray, 0));
                            }
                        }
                    }
                    break;
                case eEffect.CYAN: //Cyan
                    {
                        System.Drawing.Color c;
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);
                                byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, 0, gray, gray));
                            }
                        }
                    }
                    break;
                case eEffect.MAGENTA: //Magenta
                    {
                        System.Drawing.Color c;
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);
                                byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, gray, 0, gray));
                            }
                        }
                    }
                    break;
                case eEffect.SNOW: //Snow
                    {
                        double density = parameter;
                        if (density <= 0) density = pEffect[(int)_effect];
                        Random rand = new Random();
                        System.Drawing.Color c;
                        int i, j;
                        for (int ii = 0; ii < bmap.Width * bmap.Height / density; ii++)
                        {
                            i = rand.Next(bmap.Width);
                            j = rand.Next(bmap.Height);
                            c = bmap.GetPixel(i, j);
                            bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, 255, 255, 255));
                        }
                    }
                    break;
                case eEffect.FUZZY: //Fuzzy
                    {
                        Random rand = new Random();
                        System.Drawing.Color c;
                        System.Drawing.Bitmap copy = (System.Drawing.Bitmap)bmap.Clone();
                        int ii, jj;
                        int x = parameter;
                        if (x <= 0) x = pEffect[(int)_effect];
                        int y = 2 * x + 1;
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                ii = System.Math.Max(0, System.Math.Min(bmap.Width - 1, i + rand.Next(y) - x));
                                jj = System.Math.Max(0, System.Math.Min(bmap.Height - 1, j + rand.Next(y) - x));
                                c = copy.GetPixel(ii, jj);
                                bmap.SetPixel(i, j, c);
                            }
                        }
                    }
                    break;
                case eEffect.CONTRAST: //Contrast
                    {
                        double contrast = parameter;
                        if (contrast <= 0) contrast = pEffect[(int)_effect];
                        System.Drawing.Color c;
                        double R, G, B;

                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);

                                R = c.R / 255.0 - 0.5;
                                R = R >= 0 ? System.Math.Pow(R, 1.0 / contrast) : -System.Math.Pow(-R, 1.0 / contrast);
                                R = 255 * (R + 0.5);
                                R = System.Math.Max(0, System.Math.Min(255, R));

                                G = c.G / 255.0 - 0.5;
                                G = G >= 0 ? System.Math.Pow(G, 1.0 / contrast) : -System.Math.Pow(-G, 1.0 / contrast);
                                G = 255 * (G + 0.5);
                                G = System.Math.Max(0, System.Math.Min(255, G));

                                B = c.B / 255.0 - 0.5;
                                B = B >= 0 ? System.Math.Pow(B, 1.0 / contrast) : -System.Math.Pow(-B, 1.0 / contrast);
                                B = 255 * (B + 0.5);
                                B = System.Math.Max(0, System.Math.Min(255, B));

                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, (int)R, (int)G, (int)B));
                            }
                        }
                    }
                    break;
                case eEffect.BLOCKS: //Blocks
                    {
                        System.Drawing.Image.GetThumbnailImageAbort dummyCallback = new System.Drawing.Image.GetThumbnailImageAbort(ResizeAbort);
                        int size = parameter;
                        if (size <= 0) size = pEffect[(int)_effect];
                        _dImg = _dImg.GetThumbnailImage(bmap.Width / size, bmap.Height / size, dummyCallback, IntPtr.Zero);
                        _dImg = _dImg.GetThumbnailImage(bmap.Width, bmap.Height, dummyCallback, IntPtr.Zero);
                        bmap = new System.Drawing.Bitmap(_dImg);
                    }
                    break;
                case eEffect.REFLECT: //Reflect
                    {
                        int mode = parameter;
                        if (mode <= 0) mode = pEffect[(int)_effect];
                        bmap.RotateFlip(mode == 1 ? System.Drawing.RotateFlipType.RotateNoneFlipY : System.Drawing.RotateFlipType.RotateNoneFlipX);
                    }
                    break;
                case eEffect.JAGGED: //Jagged
                    {
                        System.Drawing.Color c;
                        System.Drawing.Bitmap copy = (System.Drawing.Bitmap)bmap.Clone();
                        int amount = parameter;
                        if (amount <= 0) amount = pEffect[(int)_effect];
                        bool up = true, left = false;
                        int ii, jj;
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            if (i % amount == 0) up = !up;
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                if (j % amount == 0) left = !left;
                                ii = left ? System.Math.Max(0, i - amount) : System.Math.Min(bmap.Width - 1, i + amount);
                                jj = up ? System.Math.Max(0, j - amount) : System.Math.Min(bmap.Height - 1, j + amount);
                                c = copy.GetPixel(ii, jj);
                                bmap.SetPixel(i, j, c);
                            }
                        }
                    }
                    break;
                case eEffect.ROTATE: //Rotate
                    {
                        int mode = parameter;
                        if (mode <= 0) mode = pEffect[(int)_effect];
                        bmap.RotateFlip(mode == 1 ? System.Drawing.RotateFlipType.Rotate180FlipNone : mode == 2 ? System.Drawing.RotateFlipType.Rotate270FlipNone : System.Drawing.RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case eEffect.PIXELATE: //Pixelate
                    {
                        System.Drawing.Color c;
                        System.Drawing.Bitmap copy = (System.Drawing.Bitmap)bmap.Clone();
                        int amount = parameter;
                        if (amount <= 0) amount = pEffect[(int)_effect];
                        int nx = bmap.Width / amount + 1;
                        int ny = bmap.Height / amount + 1;
                        int ii, jj;
                        int[,] A = new int[nx, ny];
                        int[,] R = new int[nx, ny];
                        int[,] G = new int[nx, ny];
                        int[,] B = new int[nx, ny];
                        int[,] N = new int[nx, ny];
                        System.Drawing.Color[,] C = new System.Drawing.Color[nx, ny];
                        for (int i = 0; i < nx; i++)
                        {
                            for (int j = 0; j < ny; j++)
                            {
                                A[i, j] = 0;
                                R[i, j] = 0;
                                G[i, j] = 0;
                                B[i, j] = 0;
                                N[i, j] = 0;
                            }
                        }
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            ii = i / amount;
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                jj = j / amount;
                                c = copy.GetPixel(i, j);
                                A[ii, jj] += c.A;
                                R[ii, jj] += c.R;
                                G[ii, jj] += c.G;
                                B[ii, jj] += c.B;
                                N[ii, jj] += 1;
                                bmap.SetPixel(i, j, c);
                            }
                        }
                        for (int i = 0; i < nx; i++)
                        {
                            for (int j = 0; j < ny; j++)
                            {
                                if (N[i,j] > 0) C[i, j] = System.Drawing.Color.FromArgb(A[i, j] / N[i, j], R[i, j] / N[i, j], G[i, j] / N[i, j], B[i, j] / N[i, j]);
                            }
                        }
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            ii = i / amount;
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                jj = j / amount;
                                bmap.SetPixel(i, j, C[ii, jj]);
                            }
                        }
                    }
                    break;
                case eEffect.GAMMA: //Gamma
                    {
                        double gamma = parameter;
                        if (gamma <= 0) gamma = pEffect[(int)_effect];
                        System.Drawing.Color c;
                        double R, G, B;

                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);

                                R = 255.0 * System.Math.Pow(c.R / 255.0, gamma);
                                R = System.Math.Max(0, System.Math.Min(255, R));

                                G = 255.0 * System.Math.Pow(c.G / 255.0, gamma);
                                G = System.Math.Max(0, System.Math.Min(255, G));

                                B = 255.0 * System.Math.Pow(c.B / 255.0, gamma);
                                B = System.Math.Max(0, System.Math.Min(255, B));

                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, (int)R, (int)G, (int)B));
                            }
                        }
                    }
                    break;
                case eEffect.FISHEYE: //FishEye
                    {
                        System.Drawing.Bitmap copy = (System.Drawing.Bitmap)bmap.Clone();
                        double factor = parameter;
                        if (factor < 1) factor = pEffect[(int)_effect];
                        factor -= 1;

                        double centerX = bmap.Width / 2; //center of distortion
                        double centerY = bmap.Height / 2;

                        int width = bmap.Width; //image bounds
                        int height = bmap.Height;

                        xshift = calc_shift(0, centerX - 1, centerX, factor);
                        double newcenterX = width - centerX;
                        double xshift_2 = calc_shift(0, newcenterX - 1, newcenterX, factor);

                        yshift = calc_shift(0, centerY - 1, centerY, factor);
                        double newcenterY = height - centerY;
                        double yshift_2 = calc_shift(0, newcenterY - 1, newcenterY, factor);

                        xscale = (width - xshift - xshift_2) / width;
                        yscale = (height - yshift - yshift_2) / height;

                        for (int j = 0; j < height; j++)
                        {
                            for (int i = 0; i < width; i++)
                            {
                                double x = getRadialX((double)i, (double)j, centerX, centerY, factor);
                                double y = getRadialY((double)i, (double)j, centerX, centerY, factor);
                                int ii = System.Math.Min(width - 1, System.Math.Max(0, (int)x));
                                int jj = System.Math.Min(height - 1, System.Math.Max(0, (int)y));
                                bmap.SetPixel(i, j, copy.GetPixel(ii, jj));
                            }
                        }
                    }
                    break;
                case eEffect.BULGE: //Bulge
                    {
                        System.Drawing.Bitmap copy = (System.Drawing.Bitmap)bmap.Clone();
                        double factor = parameter;
                        if (factor <= 0) factor = pEffect[(int)_effect];

                        double rad = System.Math.Min(bmap.Width, bmap.Height) / 2.0;
                        double dx, dy, dist, scale;
                        int ii, jj;
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                dx = i - bmap.Width / 2.0;
                                dy = j - bmap.Height / 2.0;
                                dist = System.Math.Sqrt(dx * dx + dy * dy);
                                scale = System.Math.Pow(dist / rad, factor) / (dist / rad);
                                ii = (int)(bmap.Width / 2.0 + scale * dx);
                                ii = System.Math.Min(bmap.Width - 1, System.Math.Max(0, ii));
                                jj = (int)(bmap.Height / 2.0 + scale * dy);
                                jj = System.Math.Min(bmap.Height - 1, System.Math.Max(0, jj));
                                bmap.SetPixel(i, j, copy.GetPixel(ii, jj));
                            }
                        }
                    }
                    break;
                case eEffect.SWIRL: //Swirl
                    {
                        System.Drawing.Bitmap copy = (System.Drawing.Bitmap)bmap.Clone();
                        double factor = parameter;
                        if (factor == 0) factor = pEffect[(int)_effect];

                        double dx, dy, dist, theta;
                        int ii, jj;
                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                dx = i - bmap.Width / 2.0;
                                dy = j - bmap.Height / 2.0;
                                dist = System.Math.Sqrt(dx * dx + dy * dy);
                                if (dx == 0) theta = dy > 0 ? System.Math.PI / 2.0 : 3.0 * System.Math.PI / 2.0;
                                else theta = System.Math.Atan(dy/dx);
                                if (dx < 0) theta += System.Math.PI;
                                theta += dist / bmap.Width * factor * 2 * System.Math.PI;
                                ii = (int)(bmap.Width / 2.0 + dist * System.Math.Cos(theta));
                                ii = System.Math.Min(bmap.Width - 1, System.Math.Max(0, ii));
                                jj = (int)(bmap.Height / 2.0 + dist * System.Math.Sin(theta));
                                jj = System.Math.Min(bmap.Height - 1, System.Math.Max(0, jj));
                                bmap.SetPixel(i, j, copy.GetPixel(ii, jj));
                            }
                        }
                    }
                    break;
                case eEffect.POSTERISE: //Posterise
                    {
                        int level = parameter;
                        if (level <= 0) level = pEffect[(int)_effect];
                        System.Drawing.Color c;
                        double R, G, B;

                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);

                                R = ((int)(c.R / level)) * level;
                                G = ((int)(c.G / level)) * level;
                                B = ((int)(c.B / level)) * level;

                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, (int)R, (int)G, (int)B));
                            }
                        }
                    }
                    break;
                case eEffect.HUE: //Hue
                    {
                        double hue = parameter;
                        if (hue <= 0) hue = pEffect[(int)_effect];
                        System.Drawing.Color c;
                        double[] HSL;
                        double[] RGB;

                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);

                                HSL = LDColours.RGB2HSL(c.R, c.G, c.B);
                                RGB = LDColours.HSL2RGB(HSL[0] + hue, HSL[1], HSL[2]);

                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, (int)(255*RGB[0]+0.5), (int)(255 * RGB[1] + 0.5), (int)(255 * RGB[2] + 0.5)));
                            }
                        }
                    }
                    break;
                case eEffect.SATURATION: //Saturation
                    {
                        double saturation = parameter;
                        if (saturation <= 0) saturation = pEffect[(int)_effect];
                        System.Drawing.Color c;
                        double[] HSL;
                        double[] RGB;

                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);

                                HSL = LDColours.RGB2HSL(c.R, c.G, c.B);
                                RGB = LDColours.HSL2RGB(HSL[0], HSL[1] * saturation, HSL[2]);

                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, (int)(255 * RGB[0] + 0.5), (int)(255 * RGB[1] + 0.5), (int)(255 * RGB[2] + 0.5)));
                            }
                        }
                    }
                    break;
                case eEffect.LIGHTNESS: //Lightness
                    {
                        double lightness = parameter;
                        if (lightness <= 0) lightness = pEffect[(int)_effect];
                        System.Drawing.Color c;
                        double[] HSL;
                        double[] RGB;

                        for (int i = 0; i < bmap.Width; i++)
                        {
                            for (int j = 0; j < bmap.Height; j++)
                            {
                                c = bmap.GetPixel(i, j);

                                HSL = LDColours.RGB2HSL(c.R, c.G, c.B);
                                RGB = LDColours.HSL2RGB(HSL[0], HSL[1], HSL[2] * lightness);

                                bmap.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, (int)(255 * RGB[0] + 0.5), (int)(255 * RGB[1] + 0.5), (int)(255 * RGB[2] + 0.5)));
                            }
                        }
                    }
                    break;
                case eEffect.OILPAINT: //Oil Paint
                    {
                        int radius = parameter[1];
                        int levels = parameter[2];
                        if (radius <= 0) radius = pEffect[(int)_effect][1];
                        if (levels <= 0) levels = pEffect[(int)_effect][2];
                        if (radius % 2 == 0) radius++;
                        bmap = fip.OilPaint(bmap, radius, levels);
                    }
                    break;
                case eEffect.CHARCOAL: //Charcoal
                    {
                        bmap = fip.SketchCharcoal(bmap);
                    }
                    break;
                case eEffect.SKETCH: //Pen sketch
                    {
                        bmap = fip.Sketch(bmap);
                    }
                    break;
                case eEffect.CARTOON: //Cartool
                    {
                        int radius = parameter[1];
                        int levels = parameter[2];
                        int inverse = parameter[3];
                        if (radius <= 0) radius = pEffect[(int)_effect][1];
                        if (levels <= 0) levels = pEffect[(int)_effect][2];
                        if (inverse <= 0) inverse = pEffect[(int)_effect][3];
                        if (radius % 2 == 0) radius++;
                        bmap = fip.Cartoon(bmap, radius, levels, inverse, fip.LaplaceF1());
                    }
                    break;
                case eEffect.EDGE: //Edge
                    {
                        bmap = fip.ImagePrewittFilterColor(bmap);
                        //bmap = fip.ImagePrewittFilterGS(bmap);
                    }
                    break;
                default:
                    break;
            }

            return (System.Drawing.Image)bmap;
        }

        private static void Connect()
        {
            pictureBox.Visible = false;
            Disconnect();

            if (useAvicap)
            {
                hWnd = capCreateCaptureWindowA("WebCap", WS_VISIBLE | WS_CHILD, 0, 0, _width, _height, pictureBox.Handle, 0);
                //Connection can take a few tries?
                for (int i = 0; i < 10; i++)
                {
                    if (SendMessage(hWnd, WM_CAP_CONNECT, 0, 0) != IntPtr.Zero)
                    {
                        SendMessage(hWnd, WM_CAP_SET_PREVIEWRATE, interval, 0);
                        SendMessage(hWnd, WM_CAP_SET_PREVIEW, -1, 0);
                        SendMessage(hWnd, WM_CAP_SET_SCALE, -1, 0);
                        connected = true;
                        break;
                    }
                }
            }
            else
            {
                Thread camThread = new Thread(CamThread);
                camThread.Start();
                while (!camThread.IsAlive);
                Thread.Sleep(1);
                connected = true;
            }

            timer = new System.Windows.Forms.Timer();
            timer.Enabled = true;
            timer.Interval = interval;
            timer.Tick += new System.EventHandler(timer_Tick);
        }

        private static void CamThread()
        {
            cam = new Capture();
            while (connected)
            {
                if (timer.Enabled) bitmap = new System.Drawing.Bitmap(cam.Width, cam.Height, cam.Stride, System.Drawing.Imaging.PixelFormat.Format24bppRgb, cam.GetBitMap());
                Thread.Sleep(1);
            }
        }

        private static void timer_Tick(object sender, EventArgs e)
        {
            UpdateImage();
        }

        public static bool ResizeAbort()
        {
            return false;
        }

        private static void UpdateImage()
        {
            if (connected)
            {
                lock (lockUpdate)
                {
                    try
                    {
                        if (useAvicap)
                        {
                            SendMessage(hWnd, WM_CAP_GET_FRAME, 0, 0);
                            SendMessage(hWnd, WM_CAP_COPY, 0, 0);
                            dImg = System.Windows.Forms.Clipboard.GetImage();
                        }
                        else
                        {
                            if (null == bitmap) return;
                            dImg = (System.Drawing.Bitmap)bitmap.Clone();
                            dImg.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipY);
                        }
                        System.Drawing.Image.GetThumbnailImageAbort dummyCallback = new System.Drawing.Image.GetThumbnailImageAbort(ResizeAbort);
                        if (_width < dImg.Width && _height < dImg.Height) dImg = dImg.GetThumbnailImage(_width, _height, dummyCallback, IntPtr.Zero);
                        dImg = DoEffect(dImg, effect, _parameter);

                        InvokeHelper ret = new InvokeHelper(delegate
                        {
                            MemoryStream ms = new MemoryStream();
                            dImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            BitmapImage bImg = new BitmapImage();
                            bImg.BeginInit();
                            bImg.StreamSource = ms;
                            bImg.EndInit();
                            foreach (Image image in images)
                            {
                                image.Source = bImg;
                            }
                        });
                        method1.Invoke(null, new object[] { ret });
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                }
            }
        }

        private static string TakeSnapshot(string fileName)
        {
            string imageName = "";
            if (connected && null != dImg)
            {
                try
                {
                    if (null == fileName)
                    {
                        try
                        {
                            Type ShapesType = typeof(Shapes);
                            Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                            Dictionary<string, BitmapSource> _savedImages;

                            imageName = method3.Invoke(null, new object[] { "ImageList" }).ToString();
                            _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                            InvokeHelper ret = new InvokeHelper(delegate
                            {
                                try
                                {
                                    MemoryStream ms = new MemoryStream();
                                    dImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                    BitmapImage bImg = new BitmapImage();
                                    bImg.BeginInit();
                                    bImg.StreamSource = ms;
                                    bImg.EndInit();
                                    _savedImages[imageName] = bImg;
                                }
                                catch (Exception ex)
                                {
                                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                                }
                            });
                            method1.Invoke(null, new object[] { ret });
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    }
                    else if (fileName.Length == 0)
                    {
                        System.Drawing.Image image = (System.Drawing.Image)dImg.Clone();
                        SaveFileDialog dlg = new SaveFileDialog();
                        dlg.Filter = "JPG Images|*.jpg";
                        dlg.OverwritePrompt = true;
                        dlg.ValidateNames = true;
                        dlg.DefaultExt = "jpg";
                        if (dlg.ShowDialog(Utilities.ForegroundHandle()) == DialogResult.OK)
                        {
                            image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                    }
                    else
                    {
                        dImg.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
            return imageName;
        }
        
        private static void Disconnect()
        {
            if (useAvicap)
            {
                if (hWnd != IntPtr.Zero) SendMessage(hWnd, WM_CAP_DISCONNECT, hWnd.ToInt32(), 0);
                hWnd = IntPtr.Zero;
            }
            else
            {
                if (null != cam) cam.Dispose();
                cam = null;
            }
            connected = false;
        }

        /// <summary>
        /// Use pre-Windows 8 method.
        /// "True" or "False" (default).
        /// </summary>
        public static Primitive PreWin8Mode
        {
            get { return useAvicap ? "True" : "False"; }
            set { useAvicap = value; }
        }

        /// <summary>
        /// Start a webcam display object (SmallBasic shape).  If this is called more than once, multiple copies af the same webcam image are be generated.
        /// 
        /// This object can be moved, zommed, rotated etc using the standard Shapes methods.
        /// 
        /// Maximum resolution usually at 640 x 480 pixels, smaller may be faster.
        /// </summary>
        /// <param name="width">The width of the webcam display object.</param>
        /// <param name="height">The height of the webcam display object.</param>
        /// <returns>The name of the webcam display object.</returns>
        public static Primitive Start(Primitive width, Primitive height)
        {
            _width = width;
            _height = height;
            GraphicsWindow.Show();

            Canvas _mainCanvas;
            Dictionary<string, UIElement> _objectsMap;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                shapeName = method3.Invoke(null, new object[] { "Image" }).ToString();

                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Image image = new Image();
                        images.Add(image);
                        image.Name = shapeName;
                        image.Width = _width;
                        image.Height = _height;
                        image.Stretch = System.Windows.Media.Stretch.Fill;

                        _objectsMap[shapeName] = (UIElement)image;
                        _mainCanvas.Children.Add(image);

                        if (!connected) Connect();

                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                return method2.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// End the webcam display, call this before removing the webcam shape.
        /// </summary>
        public static void End()
        {
            Disconnect();
        }

        /// <summary>
        /// Take a snapshot and save it as a jpg with a SaveAs dialog.
        /// </summary>
        public static void Snapshot()
        {
            TakeSnapshot("");
        }

        /// <summary>
        /// Take a snapshot and save it to a file.
        /// </summary>
        /// <param name="fileName">File to save jpg snapshot to.</param>
        public static void SnapshotToFile(Primitive fileName)
        {
            TakeSnapshot(fileName);
        }

        /// <summary>
        /// Take a snapshot and save it to the ImageList (memory loaded image).
        /// </summary>
        /// <returns>Returns the name of the image that was loaded.</returns>
        public static Primitive SnapshotToImageList()
        {
            return TakeSnapshot(null);
        }

        /// <summary>
        /// Pause the webcam updates.
        /// </summary>
        public static void Pause()
        {
            if (null != cam) cam.Pause();
            timer.Enabled = false;
        }

        /// <summary>
        /// Resume the webcam updates.
        /// </summary>
        public static void Resume()
        {
            if (null != cam) cam.Start();
            timer.Enabled = true;
        }

        /// <summary>
        /// The webcam update minimim delay between updates in ms (default 20).
        /// It will in practice be larger in many cases, especialyy with effects set.
        /// </summary>
        public static Primitive Interval
        {
            get { return interval; }
            set { interval = value; }
        }

        /// <summary>
        /// The current effect.
        /// Can be set using the Effect properties.
        /// (e.g. LDWebCam.Effect = LDWebCam.EffectGray).
        /// </summary>
        public static Primitive Effect
        {
            get { return (int)effect;}
            set { effect = (eEffect)(int)value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectNone { get { return (int)eEffect.NONE; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectRed { get { return (int)eEffect.RED; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectGreen { get { return (int)eEffect.GREEN; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectBlue { get { return (int)eEffect.BLUE; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectGray { get { return (int)eEffect.GRAY; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectInverse { get { return (int)eEffect.INVERSE; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectYellow { get { return (int)eEffect.YELLOW; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectCyan { get { return (int)eEffect.CYAN; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectMagenta { get { return (int)eEffect.MAGENTA; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectSnow { get { return (int)eEffect.SNOW; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectFuzzy { get { return (int)eEffect.FUZZY; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectContrast { get { return (int)eEffect.CONTRAST; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectBlocks { get { return (int)eEffect.BLOCKS; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectReflect { get { return (int)eEffect.REFLECT; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectJagged { get { return (int)eEffect.JAGGED; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectRotate { get { return (int)eEffect.ROTATE; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectPixelate { get { return (int)eEffect.PIXELATE; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectGamma { get { return (int)eEffect.GAMMA; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectFishEye { get { return (int)eEffect.FISHEYE; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectBulge { get { return (int)eEffect.BULGE; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectSwirl { get { return (int)eEffect.SWIRL; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectPosterise { get { return (int)eEffect.POSTERISE; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectHue { get { return (int)eEffect.HUE; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectSaturation { get { return (int)eEffect.SATURATION; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectLightness { get { return (int)eEffect.LIGHTNESS; } }
        /// <summary>
        /// 
        /// </summary>
        public static Primitive EffectOilPaint { get { return (int)eEffect.OILPAINT; } }

        /// <summary>
        /// Effect parameter - see LDImage effects for the parameter values for effects.
        /// </summary>
        public static Primitive EffectParameter
        {
            get { return _parameter; }
            set { _parameter = value; }
        }
    }
}
