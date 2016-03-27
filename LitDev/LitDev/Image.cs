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
using Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using SBArray = Microsoft.SmallBasic.Library.Array;

namespace LitDev
{
    /// <summary>
    /// Provides methods to modify and image process images stored in ImageList.
    /// Any effect parameter can be defaulted to "".
    /// </summary>
    [SmallBasicType]
    public static class LDImage
    {
        public static System.Drawing.Bitmap getBitmap(BitmapSource img)
        {
            MemoryStream ms = new MemoryStream();
            BitmapEncoder enc = new PngBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(img));
            enc.Save(ms);
            return new System.Drawing.Bitmap(ms);
        }

        public static BitmapImage getBitmapImage(System.Drawing.Bitmap dImg)
        {
            MemoryStream ms = new MemoryStream();
            dImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            BitmapImage bImg = new BitmapImage();
            bImg.BeginInit();
            bImg.StreamSource = ms;
            bImg.EndInit();
            return bImg;
        }

        private static object LockingVar = new object();

        private static byte range(double value)
        {
            return (byte)(System.Math.Min(255, System.Math.Max(0, value)));
        }

        private static void DoEffect(string image, eEffect effect, Primitive parameter)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);

                            dImg = (System.Drawing.Bitmap)LDWebCam.DoEffect(dImg, effect, parameter);

                            _savedImages[image] = getBitmapImage(dImg);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        private static Dictionary<string, Bitmap> _workingImages = new Dictionary<string, Bitmap>();

        private static Primitive statistics(string image)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;
                Primitive stats = new Primitive("");

                double[] min, max, mean, std;
                min = new double[3] { 255.0, 255.0, 255.0 };
                max = new double[3] { 0.0, 0.0, 0.0 };
                mean = new double[3] { 0.0, 0.0, 0.0 };
                std = new double[3] { 0.0, 0.0, 0.0 };

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return stats;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);

                            System.Drawing.Color c;
                            for (int i = 0; i < dImg.Width; i++)
                            {
                                for (int j = 0; j < dImg.Height; j++)
                                {
                                    c = dImg.GetPixel(i, j);
                                    min[0] = System.Math.Min(min[0], (double)c.R);
                                    min[1] = System.Math.Min(min[1], (double)c.G);
                                    min[2] = System.Math.Min(min[2], (double)c.B);
                                    max[0] = System.Math.Max(max[0], (double)c.R);
                                    max[1] = System.Math.Max(max[1], (double)c.G);
                                    max[2] = System.Math.Max(max[2], (double)c.B);
                                    mean[0] += (double)c.R;
                                    mean[1] += (double)c.G;
                                    mean[2] += (double)c.B;
                                    std[0] += (double)(c.R * c.R);
                                    std[1] += (double)(c.G * c.G);
                                    std[2] += (double)(c.B * c.B);
                                }
                            }
                            double size = dImg.Width * dImg.Height;
                            for (int i = 0; i < 3; i++)
                            {
                                mean[i] /= size;
                                std[i] /= size;
                                std[i] -= mean[i] * mean[i];
                                std[i] = System.Math.Sqrt(std[i]);
                                stats["Min"] += (i + 1).ToString() + "=" + min[i].ToString(CultureInfo.InvariantCulture) + ";";
                                stats["Max"] += (i + 1).ToString() + "=" + max[i].ToString(CultureInfo.InvariantCulture) + ";";
                                stats["Mean"] += (i + 1).ToString() + "=" + mean[i].ToString(CultureInfo.InvariantCulture) + ";";
                                stats["STD"] += (i + 1).ToString() + "=" + std[i].ToString(CultureInfo.InvariantCulture) + ";";
                            }
                            stats["Min"] = Utilities.CreateArrayMap(stats["Min"]);
                            stats["Max"] = Utilities.CreateArrayMap(stats["Max"]);
                            stats["Mean"] = Utilities.CreateArrayMap(stats["Mean"]);
                            stats["STD"] = Utilities.CreateArrayMap(stats["STD"]);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return stats;
            }
        }

        private static Primitive histogram(string image)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;
                Primitive stats = new Primitive("");

                int[] red, green, blue;
                red = new int[256];
                green = new int[256];
                blue = new int[256];
                for (int i = 0; i < 256; i++)
                {
                    red[i] = 0;
                    green[i] = 0;
                    blue[i] = 0;
                }

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return stats;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);

                            System.Drawing.Color c;
                            for (int i = 0; i < dImg.Width; i++)
                            {
                                for (int j = 0; j < dImg.Height; j++)
                                {
                                    c = dImg.GetPixel(i, j);
                                    red[c.R]++;
                                    green[c.G]++;
                                    blue[c.B]++;
                                }
                            }
                            for (int i = 0; i < 256; i++)
                            {
                                stats[1] += i.ToString() + "=" + red[i].ToString() + ";";
                                stats[2] += i.ToString() + "=" + green[i].ToString() + ";";
                                stats[3] += i.ToString() + "=" + blue[i].ToString() + ";";
                            }
                            stats[1] = Utilities.CreateArrayMap(stats[1]);
                            stats[2] = Utilities.CreateArrayMap(stats[2]);
                            stats[3] = Utilities.CreateArrayMap(stats[3]);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return stats;
            }
        }

        private static System.Drawing.ColorConverter colConvert = new System.Drawing.ColorConverter();

        private static string Color2ARGB(System.Drawing.Color c)
        {
            return "#" + c.A.ToString("X2") + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        /// <summary>
        /// Set a pixel colour.
        /// </summary>
        /// <param name="image">The ImageList image.</param>
        /// <param name="x">The x pixel.</param>
        /// <param name="y">The y pixel.</param>
        /// <param name="colour">The colour to set the pixel.</param>
        public static void SetPixel(Primitive image, Primitive x, Primitive y, Primitive colour)
        {
            x = (int)x;
            y = (int)y;
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);
                            if (x >= 0 && x < dImg.Width && y >= 0 && y < dImg.Height)
                            {
                                System.Drawing.Color c = (System.Drawing.Color)colConvert.ConvertFromString(colour);

                                dImg.SetPixel(x, y, c);
                                _savedImages[image] = getBitmapImage(dImg);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Get a pixel colour.
        /// </summary>
        /// <param name="image">The ImageList image.</param>
        /// <param name="x">The x pixel.</param>
        /// <param name="y">The y pixel.</param>
        /// <returns>The pixel colour.</returns>
        public static Primitive GetPixel(Primitive image, Primitive x, Primitive y)
        {
            x = (int)x;
            y = (int)y;
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;
                string colour = "";

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return colour;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);
                            if (x >= 0 && x < dImg.Width && y >= 0 && y < dImg.Height)
                            {
                                System.Drawing.Color c = dImg.GetPixel(x, y);
                                colour = Color2ARGB(c);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return colour;
            }
        }

        /// <summary>
        /// Save an image from the ImageList as a jpg.
        /// </summary>
        /// <param name="image">The ImageList image to save.</param>
        /// <param name="fileName">The file to save the image as.</param>
        public static void Save(Primitive image, Primitive fileName)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);
                            dImg.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Save an image from the ImageList in different formats set by the file extension.
        /// </summary>
        /// <param name="image">The ImageList image to save.</param>
        /// <param name="fileName">The file to save the image as.
        /// Accepted file type extensions include *.bmp, *.gif, *.jpg, *.png, *.tiff or *.ico.</param>
        public static void SaveAs(Primitive image, Primitive fileName)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);
                            string ext = Path.GetExtension(fileName).ToLower();
                            switch (ext)
                            {
                                case ".bmp":
                                    dImg.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                                    break;
                                case ".gif":
                                    dImg.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                                    break;
                                case ".jpg":
                                    dImg.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    break;
                                case ".jpeg":
                                    dImg.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    break;
                                case ".png":
                                    dImg.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                                    break;
                                case ".tiff":
                                    dImg.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                                    break;
                                case ".ico":
                                    dImg.Save(fileName, System.Drawing.Imaging.ImageFormat.Icon);
                                    break;
                            }                            
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Remove an image from the ImageList.
        /// </summary>
        /// <param name="image">The ImageList image to delete.</param>
        public static void Remove(Primitive image)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            _savedImages.Remove(image);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Copy an image from the ImageList.
        /// </summary>
        /// <param name="image">The ImageList image to copy.</param>
        /// <returns>A new ImageList image or "" on failure.</returns>
        public static Primitive Copy(Primitive image)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Type ShapesType = typeof(Shapes);
                Dictionary<string, BitmapSource> _savedImages;
                string imageCopy = "";
                BitmapSource img;

                try
                {
                    MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    imageCopy = method.Invoke(null, new object[] { "ImageList" }).ToString();
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return imageCopy;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            _savedImages[imageCopy] = img;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return imageCopy;
            }
        }

        /// <summary>
        /// Resize an image from the ImageList.
        /// </summary>
        /// <param name="image">The ImageList image to resize.</param>
        /// <param name="width">The width in pixels.</param>
        /// <param name="height">The height in pixels.</param>
        public static void Resize(Primitive image, Primitive width, Primitive height)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);

                            System.Drawing.Image.GetThumbnailImageAbort dummyCallback = new System.Drawing.Image.GetThumbnailImageAbort(LDWebCam.ResizeAbort);
                            dImg = (System.Drawing.Bitmap)dImg.GetThumbnailImage(width, height, dummyCallback, IntPtr.Zero);

                            _savedImages[image] = getBitmapImage(dImg); 
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Add colour values to image.
        /// An image has pixels with R,G,B in the range 0 to 255.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="red">Red value to add.</param>
        /// <param name="green">Geen value to add.</param>
        /// <param name="blue">Blue value to add.</param>
        public static void Add(Primitive image, Primitive red, Primitive green, Primitive blue)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);

                            System.Drawing.Color c;
                            for (int i = 0; i < dImg.Width; i++)
                            {
                                for (int j = 0; j < dImg.Height; j++)
                                {
                                    c = dImg.GetPixel(i, j);
                                    dImg.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, range(c.R + red), range(c.G + green), range(c.B + blue)));
                                }
                            }

                            _savedImages[image] = getBitmapImage(dImg);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Multiply colour values of image.
        /// An image has pixels with R,G,B in the range 0 to 255.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="red">Red value to multiply by.</param>
        /// <param name="green">Geen value to multiply by.</param>
        /// <param name="blue">Blue value to multiply by.</param>
        public static void Multiply(Primitive image, Primitive red, Primitive green, Primitive blue)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);

                            System.Drawing.Color c;
                            for (int i = 0; i < dImg.Width; i++)
                            {
                                for (int j = 0; j < dImg.Height; j++)
                                {
                                    c = dImg.GetPixel(i, j);
                                    dImg.SetPixel(i, j, System.Drawing.Color.FromArgb(c.A, range(c.R * red), range(c.G * green), range(c.B * blue)));
                                }
                            }

                            _savedImages[image] = getBitmapImage(dImg);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Get the minimum, maximum, mean and STD for colour pixel values.
        /// </summary>
        /// <param name="image">The ImageList image.</param>
        /// <returns>An array of statistics values (0 to 255), indexed by "Min", "Max", "Mean", "STD" and 1,2,3 for R,G,B.</returns>
        public static Primitive Statistics(Primitive image)
        {
            return statistics(image);
        }

        /// <summary>
        /// Get histograms of colour pixel values.
        /// </summary>
        /// <param name="image">The ImageList image.</param>
        /// <returns>An array of colour histograms, indexed by 1,2,3 for R,G,B and 0 to 255.</returns>
        public static Primitive Histogram(Primitive image)
        {
            return histogram(image);
        }

        /// <summary>
        /// Add 2 images together.
        /// An image has pixels with R,G,B in the range 0 to 255.
        /// Both images must be the same dimension.
        /// </summary>
        /// <param name="image1">The first ImageList image to add.</param>
        /// <param name="image2">The second ImageList image to add.</param>
        /// <returns>A new ImageList image with the result or "" on failure.</returns>
        public static Primitive AddImages(Primitive image1, Primitive image2)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Type ShapesType = typeof(Shapes);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img1, img2;
                string imageNew = "";

                try
                {
                    MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    imageNew = method.Invoke(null, new object[] { "ImageList" }).ToString();
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image1, out img1)) return imageNew;
                    if (!_savedImages.TryGetValue((string)image2, out img2)) return imageNew;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg1 = getBitmap(img1);
                            System.Drawing.Bitmap dImg2 = getBitmap(img2);

                            if (dImg1.Width == dImg2.Width && dImg1.Height == dImg2.Height)
                            {
                                System.Drawing.Color c1, c2;
                                for (int i = 0; i < dImg1.Width; i++)
                                {
                                    for (int j = 0; j < dImg1.Height; j++)
                                    {
                                        c1 = dImg1.GetPixel(i, j);
                                        c2 = dImg2.GetPixel(i, j);
                                        dImg1.SetPixel(i, j, System.Drawing.Color.FromArgb(range(c1.R + c2.R), range(c1.G + c2.G), range(c1.B + c2.B)));
                                    }
                                }

                                _savedImages[imageNew] = getBitmapImage(dImg1);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return imageNew;
            }
        }

        /// <summary>
        /// Difference 2 images.
        /// An image has pixels with R,G,B in the range 0 to 255.
        /// Both images must be the same dimension.
        /// </summary>
        /// <param name="image1">The first ImageList image to difference.</param>
        /// <param name="image2">The second ImageList image to difference.</param>
        /// <returns>A new ImageList image with the result or "" on failure.</returns>
        public static Primitive DifferenceImages(Primitive image1, Primitive image2)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Type ShapesType = typeof(Shapes);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img1, img2;
                string imageNew = "";

                try
                {
                    MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    imageNew = method.Invoke(null, new object[] { "ImageList" }).ToString();
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image1, out img1)) return imageNew;
                    if (!_savedImages.TryGetValue((string)image2, out img2)) return imageNew;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg1 = getBitmap(img1);
                            System.Drawing.Bitmap dImg2 = getBitmap(img2);

                            if (dImg1.Width == dImg2.Width && dImg1.Height == dImg2.Height)
                            {
                                System.Drawing.Color c1, c2;
                                for (int i = 0; i < dImg1.Width; i++)
                                {
                                    for (int j = 0; j < dImg1.Height; j++)
                                    {
                                        c1 = dImg1.GetPixel(i, j);
                                        c2 = dImg2.GetPixel(i, j);
                                        dImg1.SetPixel(i, j, System.Drawing.Color.FromArgb(range(System.Math.Abs(c1.R - c2.R)), range(System.Math.Abs(c1.G - c2.G)), range(System.Math.Abs(c1.B - c2.B))));
                                    }
                                }

                                _savedImages[imageNew] = getBitmapImage(dImg1);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return imageNew;
            }
        }

        /// <summary>
        /// Crop an image from the ImageList.
        /// The crop region must be entirely within the target image.
        /// </summary>
        /// <param name="image">The ImageList image to crop.</param>
        /// <param name="x">The left position of the cropped image in pixels (indexed from 0).</param>
        /// <param name="y">The top position of the cropped image in pixels (indexed from 0).</param>
        /// <param name="width">The width of the cropped image in pixels.</param>
        /// <param name="height">The height of the cropped image in pixels.</param>
        public static void Crop(Primitive image, Primitive x, Primitive y, Primitive width, Primitive height)
        {
            x = (int)x;
            y = (int)y;
            width = (int)width;
            height = (int)height;
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);

                            System.Drawing.Rectangle cropArea = new System.Drawing.Rectangle(x, y, width, height);
                            dImg = dImg.Clone(cropArea, dImg.PixelFormat);

                            _savedImages[image] = getBitmapImage(dImg);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Performs a colour matrix transformation on an image.
        /// This can be used for all sorts of colour transformations.
        /// See http://msdn.microsoft.com/en-us/library/a7xw19wh%28v=vs.110%29.aspx.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="matrix">A 5*5 2D matrix.
        /// Sepia Example:
        /// matrix[1] = "1=0.393;2=0.349;3=0.272;4=0;5=0"
        /// matrix[2] = "1=0.769;2=0.686;3=0.534;4=0;5=0"
        /// matrix[3] = "1=0.189;2=0.168;3=0.131;4=0;5=0"
        /// matrix[4] = "1=0;2=0;3=0;4=1;5=0"
        /// matrix[5] = "1=0;2=0;3=0;4=0;5=1"
        /// </param>
        public static void ColorMatrix(Primitive image, Primitive matrix)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return;

                    double [,]data = new double[5,5];
                    Primitive rows = SBArray.GetAllIndices(matrix);
                    if (SBArray.GetItemCount(rows) != 5)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), new Exception("Incorrectly dimensioned matrix")); 
                        return;
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        Primitive cols = SBArray.GetAllIndices(rows);
                        if (SBArray.GetItemCount(cols) != 5)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), new Exception("Incorrectly dimensioned matrix"));
                            return;
                        }
                        for (int j = 1; j <= 5;j++)
                        {
                            data[i - 1, j - 1] = matrix[rows[i]][cols[j]];
                        }
                    }

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);

                            System.Drawing.Color c;
                            byte A, R, G, B;
                            for (int i = 0; i < dImg.Width; i++)
                            {
                                for (int j = 0; j < dImg.Height; j++)
                                {
                                    c = dImg.GetPixel(i, j);
                                    R = range(c.R * data[0, 0] + c.G * data[1, 0] + c.B * data[2, 0] + c.A * data[3, 0] + 255 * data[4, 0] * data[4, 4]);
                                    G = range(c.R * data[0, 1] + c.G * data[1, 1] + c.B * data[2, 1] + c.A * data[3, 1] + 255 * data[4, 1] * data[4, 4]);
                                    B = range(c.R * data[0, 2] + c.G * data[1, 2] + c.B * data[2, 2] + c.A * data[3, 2] + 255 * data[4, 2] * data[4, 4]);
                                    A = range(c.R * data[0, 3] + c.G * data[1, 3] + c.B * data[2, 3] + c.A * data[3, 3] + 255 * data[4, 3] * data[4, 4]);
                                    dImg.SetPixel(i, j, System.Drawing.Color.FromArgb(A, R, G, B));
                                }
                            }

                            _savedImages[image] = getBitmapImage(dImg);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Rotate an image.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="angle">The angle to rotate the image clockwise by in degrees.</param>
        public static void Rotate(Primitive image, Primitive angle)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);
                            System.Drawing.Bitmap copy = (System.Drawing.Bitmap)dImg.Clone();

                            double dx, dy, rad, theta;
                            int x, y;
                            for (int i = 0; i < dImg.Width; i++)
                            {
                                for (int j = 0; j < dImg.Height; j++)
                                {
                                    dx = (i - dImg.Width / 2);
                                    dy = (j - dImg.Height / 2);
                                    rad = System.Math.Sqrt(dx * dx + dy * dy);
                                    if (dx == 0) theta = dy > 0 ? System.Math.PI / 2.0 : 3.0 * System.Math.PI / 2.0;
                                    else theta = System.Math.Atan(dy / dx);
                                    if (dx < 0) theta += System.Math.PI;
                                    theta -= angle * System.Math.PI / 180.0;
                                    x = (int)(dImg.Width / 2 + rad * System.Math.Cos(theta));
                                    y = (int)(dImg.Height / 2 + rad * System.Math.Sin(theta));
                                    x = System.Math.Min(dImg.Width-1, System.Math.Max(0, x));
                                    y = System.Math.Min(dImg.Height-1, System.Math.Max(0, y));
                                    dImg.SetPixel(i, j, copy.GetPixel(x, y));
                                }
                            }

                            _savedImages[image] = getBitmapImage(dImg);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Get an array of the available image and webcam effects.
        /// </summary>
        /// <returns>An array of effects, indexed by the effect number.</returns>
        public static Primitive GetEffects()
        {
            Primitive result = "";
            int i = 0;
            result[i++] = "None";
            result[i++] = "Red";
            result[i++] = "Green";
            result[i++] = "Blue";
            result[i++] = "Gray";
            result[i++] = "Inverse";
            result[i++] = "Yellow";
            result[i++] = "Cyan";
            result[i++] = "Magenta";
            result[i++] = "Snow";
            result[i++] = "Fuzzy";
            result[i++] = "Contrast";
            result[i++] = "Blocks";
            result[i++] = "Reflect";
            result[i++] = "Jagged";
            result[i++] = "Rotate";
            result[i++] = "Pixelate";
            result[i++] = "Gamma";
            result[i++] = "Fisheye";
            result[i++] = "Bulge";
            result[i++] = "Swirl";
            result[i++] = "Posterise";
            return result;
        }

        /// <summary>
        /// Get or set an array of default effect parameters.
        /// </summary>
        public static Primitive EffectDefaults
        {
            get
            {
                Primitive result = new Primitive();
                for (int i = 0; i < LDWebCam.pEffect.Length; i++) result[i] = LDWebCam.pEffect[i];
                return result;
            }
            set
            {
                for (int i = 0; i < LDWebCam.pEffect.Length; i++) LDWebCam.pEffect[i] = value[i];
            }
        }

        /// <summary>
        /// Converts to red colour.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        public static void EffectRed(Primitive image)
        {
            DoEffect(image, eEffect.RED, "");
        }

        /// <summary>
        /// Converts to green colour.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        public static void EffectGreen(Primitive image)
        {
            DoEffect(image, eEffect.GREEN, "");
        }

        /// <summary>
        /// Converts to blue colour.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        public static void EffectBlue(Primitive image)
        {
            DoEffect(image, eEffect.BLUE, "");
        }

        /// <summary>
        /// Converts to gray scale.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        public static void EffectGray(Primitive image)
        {
            DoEffect(image, eEffect.GRAY, "");
        }

        /// <summary>
        /// Converts to inverse colour.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        public static void EffectInverse(Primitive image)
        {
            DoEffect(image, eEffect.INVERSE, "");
        }

        /// <summary>
        /// Converts to yellow colour.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        public static void EffectYellow(Primitive image)
        {
            DoEffect(image, eEffect.YELLOW, "");
        }

        /// <summary>
        /// Converts to cyan colour.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        public static void EffectCyan(Primitive image)
        {
            DoEffect(image, eEffect.CYAN, "");
        }

        /// <summary>
        /// Converts to magenta colour.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        public static void EffectMagenta(Primitive image)
        {
            DoEffect(image, eEffect.MAGENTA, "");
        }

        /// <summary>
        /// Converts to snow effect.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">1 in parameter pixels are randomly snow (default 25).</param>
        public static void EffectSnow(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.SNOW, parameter);
        }

        /// <summary>
        /// Converts to fuzzy effect.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">Pixel region to make fuzzy (default 4).</param>
        public static void EffectFuzzy(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.FUZZY, parameter);
        }

        /// <summary>
        /// Converts to high contrast effect.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">Contrast factor (default 2), less than 1 reduces contrast.</param>
        public static void EffectContrast(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.CONTRAST, parameter);
        }

        /// <summary>
        /// Converts to block effect.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">Blocking factor (default 5).</param>
        public static void EffectBlocks(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.BLOCKS, parameter);
        }

        /// <summary>
        /// Converts to X or Y reflection effect.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">0 to flip X and 1 to flip Y (default 0).</param>
        public static void EffectReflect(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.REFLECT, parameter);
        }

        /// <summary>
        /// Converts to jagged effect.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">Pixel region to make jagged (default 4).</param>
        public static void EffectJagged(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.JAGGED, parameter);
        }

        /// <summary>
        /// Converts to 90 degree rotation effect.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">0 for +90, 1 for 180 and 2 for 270(-90) degree rotation (default 0).</param>
        public static void EffectRotate(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.ROTATE, parameter);
        }

        /// <summary>
        /// Converts to pixelate effect.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">Pixelating factor (default 16).</param>
        public static void EffectPixelate(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.PIXELATE, parameter);
        }

        /// <summary>
        /// Converts to gamma effect.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">Gamma factor, values less than 1 lighten and greater than 1 darken (default 2).</param>
        public static void EffectGamma(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.GAMMA, parameter);
        }

        /// <summary>
        /// Converts to fisheye effect.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">FishEye factor, should be greater than 1 (default 2).</param>
        public static void EffectFishEye(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.FISHEYE, parameter);
        }

        /// <summary>
        /// Converts to bulge effect (similar to FishEye).
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">Bulge factor, may be less than 1 for pinch effect (default 2).</param>
        public static void EffectBulge(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.BULGE, parameter);
        }

        /// <summary>
        /// Converts to swirl effect.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">Swirl factor (default 1).</param>
        public static void EffectSwirl(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.SWIRL, parameter);
        }

        /// <summary>
        /// Converts to posterise effect.
        /// </summary>
        /// <param name="image">The ImageList image to modify.</param>
        /// <param name="parameter">Posterise level (default 50).</param>
        public static void EffectPosterise(Primitive image, Primitive parameter)
        {
            DoEffect(image, eEffect.POSTERISE, parameter);
        }

        /// <summary>
        /// Load an SVG file as an ImageList image.
        /// </summary>
        /// <param name="fileName">The SVG file.</param>
        /// <returns>The ImageList image.</returns>
        public static Primitive LoadSVG(Primitive fileName)
        {
            Type ShapesType = typeof(Shapes);
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ImageListType = typeof(ImageList);
            Dictionary<string, BitmapSource> _savedImages;

            try
            {
                SvgDocument svgDocument = SvgDocument.Open(fileName);
                
                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                        string imageName = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { "ImageList" }).ToString();
                        _savedImages[imageName] = LDImage.getBitmapImage(svgDocument.Draw());
                        return imageName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return "";
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Creates an array of subdivided images from an input image.
        /// </summary>
        /// <param name="imageName">
        /// The image file (local or network) to load.
        /// Can also be an ImageList image.
        /// </param>
        /// <param name="countX">
        /// The number of sub-images in the X direction.
        /// </param>
        /// <param name="countY">
        /// The number of sub-images in the Y direction.
        /// </param>
        /// <returns>
        /// A 2D array of resulting images saved in ImageList.
        /// </returns>
        public static Primitive SplitImage(Primitive imageName, Primitive countX, Primitive countY)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Type ImageListType = typeof(ImageList);
            Dictionary<string, BitmapSource> _savedImages;
            BitmapSource img;
            Primitive result = "";

            try
            {
                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_savedImages.TryGetValue((string)imageName, out img))
                {
                    imageName = ImageList.LoadImage(imageName);
                    if (!_savedImages.TryGetValue((string)imageName, out img))
                    {
                        return "";
                    }
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        System.Drawing.Bitmap bitmap;
                        using (MemoryStream outStream = new MemoryStream())
                        {
                            BitmapEncoder enc = new PngBitmapEncoder();
                            enc.Frames.Add(BitmapFrame.Create(img));
                            enc.Save(outStream);
                            bitmap = new System.Drawing.Bitmap(outStream);
                        }

                        int frameCount = countX * countY;
                        int w = bitmap.Width / countX;
                        int h = bitmap.Height / countY;

                        MethodInfo method1 = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);

                        if (frameCount > 1)
                        {
                            for (int i = 0; i < countX; i++)
                            {
                                Primitive resultRow = "";
                                for (int j = 0; j < countY; j++)
                                {
                                    System.Drawing.RectangleF cloneRect = new System.Drawing.RectangleF(w * i, h * j, w, h);
                                    System.Drawing.Bitmap crop = bitmap.Clone(cloneRect, bitmap.PixelFormat);

                                    MemoryStream stream = new MemoryStream();
                                    new System.Drawing.Bitmap(crop).Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                                    BitmapImage bi = new BitmapImage();
                                    bi.BeginInit();
                                    bi.StreamSource = stream;
                                    bi.EndInit();

                                    string cropName = method1.Invoke(null, new object[] { "ImageList" }).ToString();
                                    _savedImages[cropName] = bi;
                                    resultRow[j + 1] = cropName;
                                }
                                result[i + 1] = resultRow;
                            }
                            return result;
                        }
                        return "";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Create a new single colored 32bitARGB image in ImageList.
        /// </summary>
        /// <param name="width">The width of the new image.</param>
        /// <param name="height">The height of the new image.</param>
        /// <param name="colour">The colour of the new image.</param>
        /// <returns>The Name of the new created ImageList image on success, else "".</returns>
        public static Primitive NewImage(Primitive width, Primitive height, Primitive colour)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Type ShapesType = typeof(Shapes);
                Dictionary<string, BitmapSource> _savedImages;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            MethodInfo methodInfo = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                            string imageName = methodInfo.Invoke(null, new object[] { "ImageList" }).ToString();

                            Bitmap img = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                            Graphics.FromImage(img).FillRectangle(new SolidBrush((System.Drawing.Color)colConvert.ConvertFromString(colour)), 0, 0, width, height);

                            _savedImages[imageName] = getBitmapImage(img);
                            return imageName;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "";
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return "";
                }
            }
        }

        /// <summary>
        /// Get a 2D array filled with all the pixels in an image.
        /// </summary>
        /// <param name="image">The ImageList image.</param>
        /// <returns>An array of hex based image pixel colours indexed by [x][y].</returns>
        public static Primitive GetImagePixels(Primitive image)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;
                Primitive result = "";

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return result;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Bitmap dImg = getBitmap(img);
                            for (int i = 0; i < dImg.Width; i++)
                            {
                                string row = "";
                                for (int j = 0; j < dImg.Height; j++)
                                {
                                    System.Drawing.Color c = dImg.GetPixel(i, j);
                                    row += (j + 1).ToString() + "=" + Utilities.ArrayParse(Color2ARGB(c)) + ";";
                                }
                                result[i + 1] = Utilities.CreateArrayMap(row);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return result;
            }
        }

        /// <summary>
        /// Create a new image from a 2D array of pixel colour values - see GetImagePixels for format of pixels.
        /// </summary>
        /// <param name="pixels">An array of hex based image pixel colours indexed by [x][y].</param>
        /// <returns>An ImageList image created from the pixels.</returns>
        public static Primitive SetImagePixels(Primitive pixels)
        {
            Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Dictionary<string, BitmapSource> _savedImages;
            string imageNew = "";

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                imageNew = method.Invoke(null, new object[] { "ImageList" }).ToString();
                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        int width = SBArray.GetItemCount(pixels);
                        int height = SBArray.GetItemCount(pixels[1]);
                        Bitmap dImg = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        for (int i = 0; i < width; i++)
                        {
                            Primitive row = pixels[i + 1];
                            for (int j = 0; j < height; j++)
                            {
                                dImg.SetPixel(i, j, (System.Drawing.Color)colConvert.ConvertFromString(row[j+1]));
                            }
                        }
                        _savedImages[imageNew] = getBitmapImage(dImg);
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                });
                method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { ret });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return imageNew;
        }

        /// <summary>
        /// Open a temporary working image for fast pixel level manipulation.
        /// After the temporary working image is finished with it should be set to the image using CloseWorkingImage.
        /// </summary>
        /// <param name="image">The ImageList image to open as a temporary working image.</param>
        public static void OpenWorkingImage(Primitive image)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type GraphicsWindowType = typeof(Microsoft.SmallBasic.Library.GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return;
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            _workingImages[image] = getBitmap(img);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });

                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Close and reset the image from a temporary working image.
        /// </summary>
        /// <param name="image">The working image, previously opened with OpenWorkingImage.</param>
        public static void CloseWorkingImage(Primitive image)
        {
            lock (LockingVar)
            {
                Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
                Type ShapesType = typeof(Microsoft.SmallBasic.Library.Shapes);
                Type GraphicsWindowType = typeof(Microsoft.SmallBasic.Library.GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;
                Bitmap workingImg;

                try
                {
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (!_savedImages.TryGetValue((string)image, out img)) return;
                    if (!_workingImages.TryGetValue((string)image, out workingImg)) return;
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            _savedImages[image] = getBitmapImage(workingImg);
                            _workingImages.Remove(image);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });

                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Get the colour of a pixel from a temporary working image.
        /// </summary>
        /// <param name="image">The working image, previously opened with OpenWorkingImage.</param>
        /// <param name="x">The x pixel coordinate.</param>
        /// <param name="y">The y pixel coordinate.</param>
        /// <returns>The pixel colour or "" on failure.</returns>
        public static Primitive GetWorkingImagePixel(Primitive image, Primitive x, Primitive y)
        {
            lock (LockingVar)
            {
                Bitmap workingImg;
                if (!_workingImages.TryGetValue((string)image, out workingImg)) return "";
                try
                {
                    return Color2ARGB(workingImg.GetPixel(x - 1, y - 1));
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return "";
                }
            }
        }

        /// <summary>
        /// Set the colour of a pixel in a temporary working image.
        /// </summary>
        /// <param name="image">The working image, previously opened with OpenWorkingImage.</param>
        /// <param name="x">The x pixel coordinate.</param>
        /// <param name="y">The y pixel coordinate.</param>
        /// <param name="colour">The colour to set the pixel to.</param>
        public static void SetWorkingImagePixel(Primitive image, Primitive x, Primitive y, Primitive colour)
        {
            lock (LockingVar)
            {
                Bitmap workingImg;
                if (!_workingImages.TryGetValue((string)image, out workingImg)) return;
                try
                {
                    workingImg.SetPixel(x - 1, y - 1, (System.Drawing.Color)colConvert.ConvertFromString(colour));
                }
                    catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Get an array of image metadata.
        /// </summary>
        /// <param name="imageFile">The image file (not an ImageList image).</param>
        /// <returns>An array of metadata values indexed by hex id (Use quotes for indices with a to f in the hex values).
        /// See https://msdn.microsoft.com/en-us/library/system.drawing.imaging.propertyitem.id%28v=vs.110%29.aspx for a list of ids.</returns>
        public static Primitive MetaData(Primitive imageFile)
        {
            lock (LockingVar)
            {
                try
                {
                    Image image = new Bitmap(imageFile);
                    PropertyItem[] propItems = image.PropertyItems;
                    Primitive result = "";
                    foreach (PropertyItem item in propItems)
                    {
                        switch (item.Type)
                        {
                            case 1:
                                result[item.Id.ToString("x")] = item.Value[0];
                                break;
                            case 2:
                                result[item.Id.ToString("x")] = new ASCIIEncoding().GetString(item.Value);
                                break;
                            case 3:
                                result[item.Id.ToString("x")] = BitConverter.ToInt16(item.Value, 0);
                                break;
                            case 4:
                                result[item.Id.ToString("x")] = BitConverter.ToInt32(item.Value, 0);
                                break;
                            case 5:
                                result[item.Id.ToString("x")] = BitConverter.ToDouble(item.Value, 0);
                                break;
                        }
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return "";
                }
            }
        }
    }
}
