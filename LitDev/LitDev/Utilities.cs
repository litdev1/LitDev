//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2020> litdev@hotmail.co.uk
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
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DrawingImage = System.Drawing.Image;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32.SafeHandles;
using System.Threading;
using LitDev.Engines;
using System.Windows.Threading;
using System.Collections.Specialized;
using System.Drawing;
using Size = System.Drawing.Size;

namespace LitDev
{
    public static class Utilities
    {
        public static string URL = "http://litdev.co.uk";
        public static bool bShowErrors = true;
        public static bool bShowFileErrors = true;
        public static bool bShowNoShapeErrors = true;
        public static bool bBorder;
        public static bool bTextWindow;
        public static bool bScreenCapture = false;
        public static string CSVplaceHolder = "";
        public static string CSV = ",";

        private static int numPages;
        private static int pageNumber;
        public static int NumPages
        {
            set { numPages = value; pageNumber = 0; }
        }

        public static FormEvents formEvents = new FormEvents();
        public static Thread formEventsThread = new Thread(ShowFormEvents);
        public static void ShowFormEvents()
        {
            formEvents.ShowDialog();
        }

        private static Canvas _mainCanvas;
        private static MethodInfo methodClearDispatcherQueue = typeof(SmallBasicApplication).GetMethod("ClearDispatcherQueue", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
        private static void doUpdates_Delegate()
        {
            try
            {
                _mainCanvas.InvalidateVisual();
            }
            catch (Exception ex)
            {
                OnError(GetCurrentMethod(), ex);
            }
        }
        public static void doUpdates()
        {
            try
            {
                _mainCanvas = (Canvas)typeof(GraphicsWindow).GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                FastThread.Invoke(doUpdates_Delegate);
                FastThread.Action(methodClearDispatcherQueue);
            }
            catch (Exception ex)
            {
                OnError(GetCurrentMethod(), ex);
            }
        }

        public static BitmapFrame getBitmapFrame(Canvas controlToConvert)
        {
            // get size of control
            System.Windows.Size sizeOfControl = new System.Windows.Size(controlToConvert.ActualWidth, controlToConvert.ActualHeight);
            // measure and arrange the control
            controlToConvert.Measure(sizeOfControl);
            // arrange the surface
            controlToConvert.Arrange(new Rect(sizeOfControl));

            // create and render surface and push bitmap to it
            RenderTargetBitmap renderBitmap = new RenderTargetBitmap((Int32)sizeOfControl.Width, (Int32)sizeOfControl.Height, 96d, 96d, PixelFormats.Pbgra32);
            // now render surface to bitmap
            renderBitmap.Render(controlToConvert);

            BitmapFrame bitmapFrame = BitmapFrame.Create(renderBitmap);

            //ImageSource imageSource = bitmapFrame;
            //Image image = new Image();
            //image.Source = imageSource;

            return bitmapFrame;
        }

        public static void saveImage(DrawingImage img, string fileName)
        {
            string _fileName = fileName.ToLower();
			//Could a Switch be used here instead of else if statements ?
            if (_fileName.EndsWith(".png"))
            {
                img.Save(fileName, ImageFormat.Png);
            }
            else if (_fileName.EndsWith(".jpg") || _fileName.EndsWith(".jpeg"))
            {
                img.Save(fileName, ImageFormat.Jpeg);
            }
            else if (_fileName.EndsWith(".bmp"))
            {
                img.Save(fileName, ImageFormat.Bmp);
            }
            else if (_fileName.EndsWith(".gif"))
            {
                img.Save(fileName, ImageFormat.Gif);
            }
            else if (_fileName.EndsWith(".tiff"))
            {
                img.Save(fileName, ImageFormat.Tiff);
            }
            else if (_fileName.EndsWith(".ico"))
            {
                img.Save(fileName, ImageFormat.Icon);
            }
        }

        public static void saveImage(BitmapFrame bitmapFrame, string fileName)
        {
            FileStream outStream = new FileStream(fileName, FileMode.Create);
            string _fileName = fileName.ToLower();

            if (_fileName.EndsWith(".png"))
            {
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(bitmapFrame);
                encoder.Save(outStream);
                outStream.Close();
            }
            else if (_fileName.EndsWith(".jpg") || _fileName.EndsWith(".jpeg"))
            {
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(bitmapFrame);
                encoder.Save(outStream);
                outStream.Close();
            }
            else if (_fileName.EndsWith(".bmp"))
            {
                BmpBitmapEncoder encoder = new BmpBitmapEncoder();
                encoder.Frames.Add(bitmapFrame);
                encoder.Save(outStream);
                outStream.Close();
            }
            else if (_fileName.EndsWith(".gif"))
            {
                GifBitmapEncoder encoder = new GifBitmapEncoder();
                encoder.Frames.Add(bitmapFrame);
                encoder.Save(outStream);
                outStream.Close();
            }
            else if (_fileName.EndsWith(".tiff"))
            {
                TiffBitmapEncoder encoder = new TiffBitmapEncoder();
                encoder.Frames.Add(bitmapFrame);
                encoder.Save(outStream);
                outStream.Close();
            }
        }

        public static DrawingImage captureWindow(IntPtr handle)
        {
            //Try a direct capture
            DrawingImage img;
            if (!bScreenCapture && !bTextWindow && !bBorder)
            {
                img = captureGW();
                if (null != img) return img;
            }

            // get te hDC of the target window
            IntPtr hdcSrc = User32.GetWindowDC(handle);
            // get the size
            User32.RECT windowRect = new User32.RECT();
            User32.GetWindowRect(handle, ref windowRect);
            int left = 0;
            int top = 0;
            int width = windowRect.right - windowRect.left;
            int height = windowRect.bottom - windowRect.top;
            if (!bBorder)
            {
                // Windows borders depend on OS and theme etc so type to guestimate here taking account of TW scrollbar
                User32.RECT clientRect = new User32.RECT();
                User32.GetClientRect(handle, ref clientRect);
                int CaptionH = User32.GetSystemMetrics(User32.SM_CYCAPTION);
                int ScrollW = bTextWindow ? User32.GetSystemMetrics(User32.SM_CXVSCROLL) : 0;

                left = (width - clientRect.right - clientRect.left - ScrollW) / 2;
                top = (height - clientRect.bottom - clientRect.top + CaptionH) / 2;
                width = clientRect.right - clientRect.left;
                height = clientRect.bottom - clientRect.top;
            }
            // create a device context we can copy to
            IntPtr hdcDest = GDI32.CreateCompatibleDC(hdcSrc);
            // create a bitmap we can copy it to,
            // using GetDeviceCaps to get the width/height
            IntPtr hBitmap = GDI32.CreateCompatibleBitmap(hdcSrc, width, height);
            // select the bitmap object
            IntPtr hOld = GDI32.SelectObject(hdcDest, hBitmap);
            // bitblt over
            GDI32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, left, top, GDI32.SRCCOPY);
            // restore selection
            GDI32.SelectObject(hdcDest, hOld);
            // clean up
            GDI32.DeleteDC(hdcDest);
            User32.ReleaseDC(handle, hdcSrc);
            // get a .NET image object for it
            img = DrawingImage.FromHbitmap(hBitmap);
            // free up the Bitmap object
            GDI32.DeleteObject(hBitmap);
            return img;
        }

        public static void setWindowState(int iState)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            WindowState state = WindowState.Normal;
            switch (iState)
            {
                case 0:
                    state = WindowState.Normal;
                    break;
                case 1:
                    state = WindowState.Minimized;
                    break;
                case 2:
                    state = WindowState.Maximized;
                    break;
            }

            try
            {
                Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                InvokeHelper ret = delegate
                {
                    try
                    {
                        _window.WindowState = state;
                    }
                    catch (Exception ex)
                    {
                        OnError(GetCurrentMethod(), ex);
                    }
                };
                FastThread.Invoke(ret);
            }
            catch (Exception ex)
            {
                OnError(GetCurrentMethod(), ex);
            }
        }

        public static int getWindowState()
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            WindowState state = WindowState.Normal;

            try
            {
                Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                InvokeHelper ret = delegate
                {
                    try
                    {
                        state = _window.WindowState;
                    }
                    catch (Exception ex)
                    {
                        OnError(GetCurrentMethod(), ex);
                    }
                };
                FastThread.Invoke(ret);
            }
            catch (Exception ex)
            {
                OnError(GetCurrentMethod(), ex);
            }
            int iState = 0;
            switch (state)
            {
                case WindowState.Normal:
                    iState = 0;
                    break;
                case WindowState.Minimized:
                    iState = 1;
                    break;
                case WindowState.Maximized:
                    iState = 2;
                    break;
            }
            return iState;
        }

        public static void setWindowResize(int iState)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            ResizeMode state = ResizeMode.CanResize;
            switch (iState)
            {
                case 0:
                    state = ResizeMode.CanMinimize;
                    break;
                case 1:
                    state = ResizeMode.CanResize;
                    break;
                case 2:
                    state = ResizeMode.CanResizeWithGrip;
                    break;
                case 3:
                    state = ResizeMode.NoResize;
                    break;
            }

            try
            {
                Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                InvokeHelper ret = delegate
                {
                    try
                    {
                        _window.ResizeMode = state;
                    }
                    catch (Exception ex)
                    {
                        OnError(GetCurrentMethod(), ex);
                    }
                };
                FastThread.Invoke(ret);
            }
            catch (Exception ex)
            {
                OnError(GetCurrentMethod(), ex);
            }
        }

        public static int getWindowResize()
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            ResizeMode state = ResizeMode.CanResize;

            try
            {
                Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                InvokeHelper ret = delegate
                {
                    try
                    {
                        state = _window.ResizeMode;
                    }
                    catch (Exception ex)
                    {
                        OnError(GetCurrentMethod(), ex);
                    }
                };
                FastThread.Invoke(ret);
            }
            catch (Exception ex)
            {
                OnError(GetCurrentMethod(), ex);
            }
            int iState = 0;
            switch (state)
            {
                case ResizeMode.CanMinimize:
                    iState = 0;
                    break;
                case ResizeMode.CanResize:
                    iState = 1;
                    break;
                case ResizeMode.CanResizeWithGrip:
                    iState = 2;
                    break;
                case ResizeMode.NoResize:
                    iState = 2;
                    break;
            }
            return iState;
        }

        public static void setWindowStyle(int iStyle)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            WindowStyle style = WindowStyle.SingleBorderWindow;
            switch (iStyle)
            {
                case 0:
                    style = WindowStyle.None;
                    break;
                case 1:
                    style = WindowStyle.SingleBorderWindow;
                    break;
                case 2:
                    style = WindowStyle.ThreeDBorderWindow;
                    break;
                case 3:
                    style = WindowStyle.ToolWindow;
                    break;
            }

            try
            {
                Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                InvokeHelper ret = delegate
                {
                    try
                    {
                        _window.WindowStyle = style;
                    }
                    catch (Exception ex)
                    {
                        OnError(GetCurrentMethod(), ex);
                    }
                };
                FastThread.Invoke(ret);
            }
            catch (Exception ex)
            {
                OnError(GetCurrentMethod(), ex);
            }
        }

        public static int getWindowStyle()
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            WindowStyle style = WindowStyle.SingleBorderWindow;

            try
            {
                Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                InvokeHelper ret = delegate
                {
                    try
                    {
                        style = _window.WindowStyle;
                    }
                    catch (Exception ex)
                    {
                        OnError(GetCurrentMethod(), ex);
                    }
                };
                FastThread.Invoke(ret);
            }
            catch (Exception ex)
            {
                OnError(GetCurrentMethod(), ex);
            }
            int iStyle = 1;
            switch (style)
            {
                case WindowStyle.None:
                    iStyle = 0;
                    break;
                case WindowStyle.SingleBorderWindow:
                    iStyle = 1;
                    break;
                case WindowStyle.ThreeDBorderWindow:
                    iStyle = 2;
                    break;
                case WindowStyle.ToolWindow:
                    iStyle = 3;
                    break;
            }
            return iStyle;
        }

        public static void printWindow(object sender, PrintPageEventArgs e)
        {
            IntPtr _hWnd = User32.FindWindow(null, bTextWindow ? TextWindow.Title : GraphicsWindow.Title);
            DrawingImage img = captureWindow(_hWnd);
            double width = img.Width;
            double height = img.Height;
            double border = 50;
            double maxWidth = e.PageBounds.Width - 2 * border;
            double maxHeight = e.PageBounds.Height - 2 * border;
            if (width / height > maxWidth / maxHeight)
            {
                height = height * maxWidth / width;
                width = maxWidth;
            }
            else
            {
                width = width * maxHeight / height;
                height = maxHeight;
            }
            e.Graphics.DrawImage(img, (int)(border + (maxWidth - width) / 2), (int)(border + (maxHeight - height) / 2), (int)width, (int)height);

            pageNumber++;
            e.HasMorePages = pageNumber < numPages;
        }

        public static string ReadCSV(string fileName, bool bTranspose)
        {
            try
            {
                List<string[]> input = new List<string[]>();
                int numCol = 0;

                //Reads the file and performs all the split operations as needed
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (sr.Peek() >= 0)
                    {
                        var data = sr.ReadLine().Split(new string[] {CSV}, StringSplitOptions.None);
                        input.Add(data);
                        if (data.Length > numCol)
                        {
                            numCol = data.Length;
                        }
                    }
                }
                int numRow = input.Count;

                //string output = "";
                StringBuilder output = new StringBuilder();
                string[] row;
               
                if (bTranspose)
                {
                    for (int iCol = 0; iCol < numCol; iCol++)
                    {
                        output.Append( (iCol + 1) + "=");
                        for (int iRow = 0; iRow < numRow; iRow++)
                        {
                            row = input[iRow];
                            if (iCol < row.Length)
                            {
                                string value = CSVParse(row[iCol], false);
                                if (value == "" && CSVplaceHolder != "")
                                {
                                    value = CSVplaceHolder;
                                }
                                
                                output.Append( (iRow + 1) + "\\=" + ArrayParse(ArrayParse(value)) + "\\;" );
                            }
                        }
                        output.Append(";");
                    }
                }
                else
                {
                    for (int iRow = 0; iRow < numRow; iRow++)
                    {
                        output.Append( (iRow + 1) + "=");
                        row = input[iRow];
                        for (int iCol = 0; iCol < row.Length; iCol++)
                        {
                            string value = CSVParse(row[iCol], false);
                            if (value == "" && CSVplaceHolder != "")
                            {
                                value = CSVplaceHolder;
                            }
                            
                            output.Append( (iCol + 1) + "\\=" + ArrayParse(ArrayParse(value)) + "\\;" );
                            
                        }
                        output.Append(";");
                    }
                }

                return CreateArrayMap(output.ToString());
            }
            catch (Exception ex)
            {
                OnError(GetCurrentMethod(), ex);
                return "";
            }
        }

        public static void WriteCSV(string fileName, string array)
        {
            try
            {
                string[] stringSeparators = new string[] { ";;" };
                string[] rows = array.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

                using (StreamWriter sw = new StreamWriter(fileName) )
                {
                    int counter = 0;
                    foreach (string row in rows)
                    {
                        string rowCut = row.Replace("\\", ""); //Remove slashes
                        rowCut = rowCut.Substring(rowCut.IndexOf('=') + 1); //Remove first row=
                        string[] values = rowCut.Split(';');
                        string output = string.Empty;
                        foreach (string value in values)
                        {
                            output += CSVParse(value.Substring(value.IndexOf('=') + 1), true) + CSV;
                        }

                        if (output.Length > 0)
                        {
                            output = output.Substring(0, output.Length - 1);
                        }

                        sw.WriteLine(output);
                        if (counter % 2 == 0 )
                        {
                            sw.Flush();
                        }

                        counter++;
                    }
                    sw.Flush();
                }
            }
            catch (Exception ex)
            {
                OnError(GetCurrentMethod(), ex);
            }
        }

        public static string CSVParse(string item, bool bToCSV)
        {
            if (bToCSV)
            {
                double result;
                item = item.Replace("\"", "\"\"");
                if (!double.TryParse(item, out result))
                {
                    item = "\"" + item + "\"";
                }
            }
            else
            {
                if (item.Length >= 2 && item.StartsWith("\"") && item.EndsWith("\""))
                {
                    item = item.Substring(1, item.Length - 2);
                }
                item = item.Replace("\"\"", "\"");
            }
            return item;
        }

        public static string ArrayParse(string item)
        {
            if (item.Length == 0) return " ";
            item = item.Replace("\\", "\\\\");
            item = item.Replace("=", "\\=");
            item = item.Replace(";", "\\;");
            return item;
        }

        public static Primitive CreateArrayMap(Primitive array)
        {
            array[0] = array[0];
            return array;
        }

        public static bool isBulitin(Object obj)
        {
            var type = obj.GetType();
            return (type.IsPrimitive && type != typeof(IntPtr) && type != typeof(UIntPtr))
                  || type == typeof(string)
                  || type == typeof(object)
                  || type == typeof(Decimal);
        }

        public static DrawingImage captureGW()
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);

            try
            {
                Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Object content = _window.Content;
                        Grid grid;
                        if (content.GetType() == typeof(ScrollViewer))
                        {
                            ScrollViewer scrollViewer = (ScrollViewer)content;
                            grid = (Grid)(scrollViewer.Content);
                        }
                        else
                        {
                            grid = (Grid)content;
                        }
                        Transform transform = grid.LayoutTransform;
                        System.Windows.Media.Brush background = grid.Background;
                        grid.LayoutTransform = null;
                        grid.Background = _window.Background;

                        int width = (int)grid.ActualWidth;
                        int height = (int)grid.ActualHeight;
                        System.Windows.Size size = new System.Windows.Size(width, height);
                        grid.Measure(size);
                        grid.Arrange(new Rect(size));
                        RenderTargetBitmap renderBitmap = new RenderTargetBitmap(
                            width,
                            height,
                            96d,
                            96d,
                            PixelFormats.Default);
                        renderBitmap.Render(grid);

                        grid.LayoutTransform = transform;
                        grid.Background = background;

                        BitmapEncoder encoder = new BmpBitmapEncoder();
                        MemoryStream ms = new MemoryStream();
                        encoder.Frames.Add(BitmapFrame.Create(renderBitmap));
                        encoder.Save(ms);
                        DrawingImage bitmap = new System.Drawing.Bitmap(ms);
                        ms.Close();

                        return new System.Drawing.Bitmap(bitmap); //Bug in .Net seems to need a copy here
                    }
                    catch (Exception ex)
                    {
                        OnError(GetCurrentMethod(), ex);
                    }
                    return null;
                });
                return (DrawingImage)FastThread.InvokeWithReturn(ret);
            }
            catch (Exception ex)
            {
                OnError(GetCurrentMethod(), ex);
            }
            return null;
        }

        public static string GetCurrentMethod()
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);

            return sf.GetMethod().DeclaringType.Name + "." + sf.GetMethod().Name;
        }

        public static string ToPrimitiveArray<T>(this T[] array)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append($"{i + 1}={Utilities.ArrayParse( array[i].ToString() )};");
            }

            return sb.ToString();
        }

        // This method is much slower than the ToPrimitiveArray method but
        // will generate valid Primitives for more complex types of data
        // structures.
        public static string ToPrimitiveArrayNative<T>(this T[] array)
        {
            Primitive result = new Primitive();
            if (array.Length == 0 )
            {
                return result;
            }

            try
            {

                for (int i = 0; i < array.Length; i++)
                {
                    result[i + 1] = array[i].ToString();
                }

               
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(array.ToPrimitiveArray());
            }
        }

        public static string ToPrimitiveArray<T>(this List<T> list)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append($"{i + 1}={Utilities.ArrayParse( list[i].ToString() )};");
            }

            return sb.ToString();
        }

        // This method is much slower than the ToPrimitiveArray method but
        // will generate valid Primitives for more complex types of data
        // structures.
        public static Primitive ToPrimitiveArrayNative<T>(this List<T> list)
        {
            Primitive result = new Primitive();

            if (list.Count == 0)
            {
                return result;
            }

            for (int i = 0; i < list.Count; i++)
            {
                result[i + 1] = list[i].ToString();
            }

            return result;
        }

        public static double getDouble(string value)
        {
            return Convert.ToDouble(value);
        }

        public static int getInt(string value)
        {
            return Convert.ToInt32(value);
        }

        public static Decimal getDecimal(string value)
        {
            return Convert.ToDecimal(value);
        }

        public static byte getByte(int value)
        {
            return Convert.ToByte(value);
        }

        public static string getString(Primitive value)
        {
            return (string)typeof(Primitive).GetField("_primitive", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(value);
        }

        public static void ClearMediaPlayer(string wavFile)
        {
            Type SoundType = typeof(Sound);
            Dictionary<Uri, MediaPlayer> _mediaPlayerMap;
            MediaPlayer mediaPlayer;
            Uri uri;

            try
            {
                _mediaPlayerMap = (Dictionary<Uri, MediaPlayer>)SoundType.GetField("_mediaPlayerMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                uri = new Uri(wavFile);
                if (_mediaPlayerMap.TryGetValue(uri, out mediaPlayer))
                {
                    mediaPlayer.Close();
                    _mediaPlayerMap.Remove(uri);
                    SoundType.GetField("_mediaPlayerMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).SetValue(null, _mediaPlayerMap);
                }
            }
            catch (Exception ex)
            {
                OnError(GetCurrentMethod(), ex);
            }
        }

        public static WinHandle ForegroundHandle()
        {
            return new WinHandle(User32.GetForegroundWindow());
        }

        public static WinHandle GWHandle()
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            bool _windowVisible = (bool)GraphicsWindowType.GetField("_windowVisible", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (_windowVisible) return new WinHandle(User32.FindWindow(null, GraphicsWindow.Title));
            return null;
        }

        public static WinHandle TWHandle()
        {
            Type TextWindowType = typeof(TextWindow);
            bool _windowVisible = (bool)TextWindowType.GetField("_windowVisible", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (_windowVisible) return new WinHandle(User32.FindWindow(null, TextWindow.Title));
            return null;
        }

        public static void OnError(string method, Exception ex)
        {
            string message = method + " : " + ex.Message;
            if (bShowErrors) TextWindow.WriteLine(message);
            LDEvents._Error(null, new ErrorEventArgs(message));
        }

        public static void OnFileError(string method, string fileName)
        {
            string message = method + " : " + "File not found : " + fileName;
            if (bShowFileErrors) TextWindow.WriteLine(message);
            LDEvents._Error(null, new ErrorEventArgs(message));
        }

        public static void OnShapeError(string method, string shapeName)
        {
            string message = method + " : " + "Shape not found : " + shapeName;
            if (bShowNoShapeErrors) TextWindow.WriteLine(message);
            LDEvents._Error(null, new ErrorEventArgs(message));
        }
    }

    public class WinHandle : IWin32Window
    {
        private readonly IntPtr _handle;
        public WinHandle(IntPtr handle)
        {
            _handle = handle;
        }

        IntPtr IWin32Window.Handle
        {
            get { return _handle; }
        }
    }

    class GDI32
    {
        public const int LOGPIXELSX = 88;
        public const int LOGPIXELSY = 90;
        public const int SRCCOPY = 0x00CC0020; // BitBlt dwRop parameter
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjectSource, int nXSrc, int nYSrc, int dwRop);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern bool DeleteDC(IntPtr hDC);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern bool DeleteObject(IntPtr hObject);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern int GetDeviceCaps(IntPtr hDC, int nIndex);
    }

    [SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
    class SafeIconHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public SafeIconHandle()
            : base(true)
        {
        }

        override protected bool ReleaseHandle()
        {
            return User32.DestroyIcon(handle);
        }
    }

    class User32
    {
        public enum ShowWindowCommands
        {
            /// <summary>
            /// Hides the window and activates another window.
            /// </summary>
            Hide = 0,
            /// <summary>
            /// Activates and displays a window. If the window is minimized or
            /// maximized, the system restores it to its original size and position.
            /// An application should specify this flag when displaying the window
            /// for the first time.
            /// </summary>
            Normal = 1,
            /// <summary>
            /// Activates the window and displays it as a minimized window.
            /// </summary>
            ShowMinimized = 2,
            /// <summary>
            /// Maximizes the specified window.
            /// </summary>
            Maximize = 3, // is this the right value?
            /// <summary>
            /// Activates the window and displays it as a maximized window.
            /// </summary>      
            ShowMaximized = 3,
            /// <summary>
            /// Displays a window in its most recent size and position. This value
            /// is similar to Win32.ShowWindowCommand.Normal, except
            /// the window is not activated.
            /// </summary>
            ShowNoActivate = 4,
            /// <summary>
            /// Activates the window and displays it in its current size and position.
            /// </summary>
            Show = 5,
            /// <summary>
            /// Minimizes the specified window and activates the next top-level
            /// window in the Z order.
            /// </summary>
            Minimize = 6,
            /// <summary>
            /// Displays the window as a minimized window. This value is similar to
            /// Win32.ShowWindowCommand.ShowMinimized, except the
            /// window is not activated.
            /// </summary>
            ShowMinNoActive = 7,
            /// <summary>
            /// Displays the window in its current size and position. This value is
            /// similar to Win32.ShowWindowCommand.Show"/>, except the
            /// window is not activated.
            /// </summary>
            ShowNA = 8,
            /// <summary>
            /// Activates and displays the window. If the window is minimized or
            /// maximized, the system restores it to its original size and position.
            /// An application should specify this flag when restoring a minimized window.
            /// </summary>
            Restore = 9,
            /// <summary>
            /// Sets the show state based on the SW_* value specified in the
            /// STARTUPINFO structure passed to the CreateProcess function by the
            /// program that started the application.
            /// </summary>
            ShowDefault = 10,
            /// <summary>
            ///  <b>Windows 2000/XP:</b> Minimizes a window, even if the thread
            /// that owns the window is not responding. This flag should only be
            /// used when minimizing windows from a different thread.
            /// </summary>
            ForceMinimize = 11
        }

        public const int WM_SETREDRAW = 0x000B;
        public const int SM_CYCAPTION = 4;
        public const int SM_CXVSCROLL = 2;
        public const int VK_RETURN = 0x0D;
        public const int WM_KEYDOWN = 0x0100;
        public const int WM_KEYUP = 0x0101;
        public const int WM_LBUTTONDOWN = 0x201;
        public const int WM_LBUTTONUP = 0x202;
        public const int WM_RBUTTONDOWN = 0x0204;
        public const int WM_RBUTTONUP = 0x205;
        public const int WH_KEYBOARD_LL = 13;
        public const int WH_MOUSE_LL = 14;
        public const int SWP_NOSIZE = 0x0001;
        public const UInt32 SC_CLOSE = 0xF060;
        public const UInt32 SC_MAXIMIZE = 0xF030;
        public const UInt32 SC_MINIMIZE = 0xF020;
        public const UInt32 MF_DISABLED = 0x00000002;
        public const UInt32 MF_ENABLED = 0x00000000;
        public const UInt32 MF_GRAYED = 0x00000001;
        public const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        public const int APPCOMMAND_VOLUME_UP = 0xA0000;
        public const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        public const int WM_APPCOMMAND = 0x319;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowRect(IntPtr hWnd, ref RECT rect);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetClientRect(IntPtr hWnd, ref RECT rect);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetSystemMetrics(int nIndex);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr DestroyWindow(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, bool wParam, Int32 lParam);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int EndDialog(IntPtr hWnd, IntPtr nResult);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern short GetKeyState(int nVirtKey);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);
        [DllImport("user32.dll", EntryPoint = "PostMessageA", SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, int dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool AllocConsole();
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool FreeConsole();
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetActiveWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetActiveWindow(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);
        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }
        [DllImport("user32.dll", SetLastError = true)]
        public static extern SafeIconHandle CreateIconIndirect(ref IconInfo icon);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool DestroyIcon(IntPtr hIcon);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool LockWindowUpdate(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        public const int MOUSEEVENTF_MIDDLEUP = 0x40;
    }

    /// <summary>
    /// General 
    /// </summary>
    [SmallBasicType]
    public static class LDUtilities
    {
        private static KeyConverter kc = new KeyConverter();
        public static bool showPreview = true;

        [HideFromIntellisense]
        public static void GWCapture(Primitive fileName, Primitive border)
        {
            LDGraphicsWindow.Capture(fileName, border);
        }

        [HideFromIntellisense]
        public static void TWCapture(Primitive fileName, Primitive border)
        {
            LDTextWindow.Capture(fileName, border);
        }

        [HideFromIntellisense]
        public static void GWPrint(Primitive border)
        {
            LDGraphicsWindow.Print(border);
        }

        [HideFromIntellisense]
        public static void TWPrint(Primitive border)
        {
            LDTextWindow.Print(border);
        }

        [HideFromIntellisense]
        public static Primitive GWStyle
        {
            get
            {
                return LDGraphicsWindow.Style;
            }
            set
            {
                LDGraphicsWindow.Style = value;
            }
        }

        [HideFromIntellisense]
        public static Primitive GWState
        {
            get
            {
                return LDGraphicsWindow.State;
            }
            set
            {
                LDGraphicsWindow.State = value;
            }
        }

        [HideFromIntellisense]
        public static void PauseUpdates()
        {
            LDGraphicsWindow.PauseUpdates();
        }

        [HideFromIntellisense]
        public static void ResumeUpdates()
        {
            LDGraphicsWindow.ResumeUpdates();
        }

        [HideFromIntellisense]
        public static Primitive Icon
        {
            set
            {
                LDGraphicsWindow.Icon = value;
            }
        }

        [HideFromIntellisense]
        public static Primitive GWWidth
        {
            get
            {
                return LDGraphicsWindow.Width;
            }

            set
            {
                LDGraphicsWindow.Width = value;
            }
        }

        [HideFromIntellisense]
        public static Primitive GWHeight
        {
            get
            {
                return LDGraphicsWindow.Height;
            }

            set
            {
                LDGraphicsWindow.Height = value;
            }
        }

        [HideFromIntellisense]
        public static Primitive ScreenCapture
        {
            get
            {
                return LDGraphicsWindow.ScreenCapture;
            }
            set
            {
                LDGraphicsWindow.ScreenCapture = value;
            }
        }

        [HideFromIntellisense]
        public static Primitive ExitOnClose
        {
            get
            {
                return LDGraphicsWindow.ExitOnClose;
            }

            set
            {
                LDGraphicsWindow.ExitOnClose = value;
            }
        }

        [HideFromIntellisense]
        public static event SmallBasicCallback GWClosing
        {
            add
            {
                LDGraphicsWindow._ClosingDelegate = value;
            }
            remove
            {
                LDGraphicsWindow._ClosingDelegate = null;
            }
        }

        [HideFromIntellisense]
        public static Primitive CancelClose
        {
            get { return LDGraphicsWindow.CancelClose; }
            set { LDGraphicsWindow.CancelClose = value; }
        }

        [HideFromIntellisense]
        public static void ExitButtonMode(Primitive window, Primitive mode)
        {
            LDGraphicsWindow.ExitButtonMode(window, mode);
        }

        [HideFromIntellisense]
        public static void TransparentGW()
        {
            LDGraphicsWindow.TransparentGW();
        }

        [HideFromIntellisense]
        public static void TopMostGW(Primitive top)
        {
            LDGraphicsWindow.TopMost = top;
        }

        [HideFromIntellisense]
        public static Primitive Zip(Primitive zipFile, Primitive files)
        {
            return LDZip.Zip(zipFile, files);
        }

        [HideFromIntellisense]
        public static Primitive UnZip(Primitive zipFile, Primitive directory)
        {
            return LDZip.UnZip(zipFile, directory);
        }

        [HideFromIntellisense]
        public static Primitive ZipList(Primitive zipFile)
        {
            return LDZip.ZipList(zipFile);
        }

        [HideFromIntellisense]
        public static Primitive RegexMatch(Primitive input, Primitive pattern, Primitive caseSensitive)
        {
            return LDRegex.Match(input, pattern, caseSensitive);
        }

        [HideFromIntellisense]
        public static Primitive RegexReplace(Primitive input, Primitive pattern, Primitive replacement, Primitive caseSensitive)
        {
            return LDRegex.Replace(input, pattern, replacement, caseSensitive);
        }

        [HideFromIntellisense]
        public static Primitive Command
        {
            set
            {
                try
                {
                    //string[] commands = ((string)value).Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    //Type typeClass = Type.GetType(commands[0]);
                    //Type typeField = Type.GetType(commands[1]);
                    //Convert.ChangeType(commands[2], typeField);
                    //FieldInfo fieldinfo = typeClass.GetField(commands[2], BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    //fieldinfo.SetValue(null, Convert.ChangeType(commands[2], typeField));

                    string[] commands = ((string)value).ToLower().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    switch (commands[0])
                    {
                        case "ldgraphicswindow":
                            {
                                switch (commands[1])
                                {
                                    case "pauseupdates":
                                        LDGraphicsWindow.bNewPause = commands[2] == "new";
                                        break;
                                }
                            }
                            break;
                        case "ld3dview":
                            {
                                switch (commands[1])
                                {
                                    case "swapdirection":
                                        LD3DView.swapDirection.X = double.Parse(commands[2]);
                                        LD3DView.swapDirection.Y = double.Parse(commands[3]);
                                        LD3DView.swapDirection.Z = double.Parse(commands[4]);
                                        break;
                                    case "swapangle":
                                        LD3DView.swapAngle = double.Parse(commands[2]);
                                        break;
                                }
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Show the print preview window when printing with LDGraphicsWindow.Print and LDTextWindow.Print ("True" or "False")
        /// Default "True"
        /// </summary>
        public static Primitive ShowPrintPreview
        {
            get
            {
                return showPreview;
            }
            set
            {
                showPreview = value;
            }
        }

        /// <summary>
        /// Gets the current version of the extension and displays a window with this information and a changelog.
        /// </summary>
        /// <returns>
        /// The current version.
        /// </returns>
        public static Primitive Version()
        {
            string info = "This version is " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\r\n";
            try
            {
                WebRequest webRequest = WebRequest.Create(Utilities.URL + "/LitDev-version.html");
                WebResponse webResponse = webRequest.GetResponse();
                StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
                info += "The current version is " + streamReader.ReadLine();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            FormAbout aboutBox = new FormAbout();
            aboutBox.ProductVersionLabel = info;
            aboutBox.TopMost = true;
            aboutBox.ShowDialog(Utilities.ForegroundHandle());
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        /// <summary>
        /// Get if a key is down.
        /// Useful for simplified keyboard game control.
        /// </summary>
        /// <param name="key">The key to get down state, eg "Space".</param>
        /// <returns>The key down state ("True" or "False")</returns>
        public static Primitive KeyDown(Primitive key)
        {
            try
            {
                Key _key = (Key)kc.ConvertFromString(key);
                int _keycode = KeyInterop.VirtualKeyFromKey(_key);
                short result = User32.GetKeyState(_keycode);
                return (result & 0x8000) == 0x8000 ? "True" : "False";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get an array of available font names.
        /// </summary>
        /// <returns>An array of font names.</returns>
        public static Primitive FontList()
        {
            string fonts = "";
            int i = 1;
            foreach (System.Drawing.FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts += (i++).ToString() + "=" + Utilities.ArrayParse(font.Name) + ";";
            }
            return Utilities.CreateArrayMap(fonts);
        }

        /// <summary>
        /// Get an array of available colour names.
        /// </summary>
        /// <returns>An array of colour names.</returns>
        public static Primitive ColourList()
        {
            PropertyInfo[] propertyInfos = typeof(System.Drawing.Color).GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
            string colours = "";
            int i = 1;
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Object value = propertyInfo.GetValue(null, null);
                if (value.GetType() == typeof(System.Drawing.Color))
                {
                    System.Drawing.Color colour = (System.Drawing.Color)value;
                    colours += (i++).ToString() + "=" + Utilities.ArrayParse(colour.Name) + ";";
                }
            }
            return Utilities.CreateArrayMap(colours);
        }

        /// <summary>
        /// Report any detected errors to TextWindow "True" (default) or "False"
        /// </summary>
        public static Primitive ShowErrors
        {
            get
            {
                return Utilities.bShowErrors;
            }
            set
            {
                Utilities.bShowErrors = value;
            }
        }

        /// <summary>
        /// Report any detected file not found errors to TextWindow "True" (default) or "False"
        /// </summary>
        public static Primitive ShowFileErrors
        {
            get
            {
                return Utilities.bShowFileErrors;
            }
            set
            {
                Utilities.bShowFileErrors = value;
            }
        }

        /// <summary>
        /// Report any detected shapeName not found in method "True" (default) or "False"
        /// </summary>
        public static Primitive ShowNoShapeErrors
        {
            get
            {
                return Utilities.bShowNoShapeErrors;
            }
            set
            {
                Utilities.bShowNoShapeErrors = value;
            }
        }

        /// <summary>
        /// A single character deliminator for reading and writing CSV files
        /// Default ","
        /// </summary>
        public static Primitive CSVDeliminator
        {
            get
            {
                return Utilities.CSV;
            }
            set
            {
                Utilities.CSV = ((string)value).Substring(0, 1);
            }
        }

        /// <summary>
        /// Test if the input will be treated by SmallBasic as a number.
        /// This is a culture invariant number, e.g. "3.14", but not "3,14" or "24x".
        /// </summary>
        /// <param name="input">The input to test.</param>
        /// <returns>"True" or "False"</returns>
        public static Primitive IsNumber(Primitive input)
        {
            if (input == "-") return "True";
            decimal value;
            return decimal.TryParse((string)input, NumberStyles.Float, CultureInfo.InvariantCulture, out value) ? "True" : "False";
        }

        /// <summary>
        /// Get a number expressed in the current culture.
        /// A number must be culture invariant in order to be treated as a number in calculations.
        /// A current culture number is how it is input or output.
        /// For example "3.14" is culture invariant, while "3,14" is French culture.
        /// </summary>
        /// <param name="input">A culture invariant number.</param>
        /// <returns>The number expressed in the current culture or input on failure.</returns>
        public static Primitive GetCurrentCultureNumber(Primitive input)
        {
            decimal value = 0m;
            bool conversion = decimal.TryParse((string)input, NumberStyles.Float, CultureInfo.InvariantCulture, out value);
            if (!conversion) conversion = decimal.TryParse((string)input, NumberStyles.Float, CultureInfo.CurrentCulture, out value);
            if (conversion)
            {
                return value.ToString(CultureInfo.CurrentCulture);
            }
            else
            {
                return input;
            }
        }

        /// <summary>
        /// Get a number expressed in the culture invariant form.
        /// A number must be culture invariant in order to be treated as a number in calculations.
        /// A current culture number is how it is input or output.
        /// For example "3.14" is culture invariant, while "3,14" is French culture.
        /// </summary>
        /// <param name="input">A number expressed in the current culture.</param>
        /// <returns>The number expressed in culture invariant form or input on failure.</returns>
        public static Primitive GetCultureInvariantNumber(Primitive input)
        {
            decimal value = 0m;
            bool conversion = decimal.TryParse((string)input, NumberStyles.Float, CultureInfo.CurrentCulture, out value);
            if (!conversion) conversion = decimal.TryParse((string)input, NumberStyles.Float, CultureInfo.InvariantCulture, out value);
            if (conversion)
            {
                return value.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                return input;
            }
        }

        /// <summary>
        /// Delete all Small Basic related files from the temp folder.
        /// These are files with extensions tmp, pdb and dll.
        /// Other applications may also use these, so best to use with no other apps running.
        /// </summary>
        /// <returns>The number of files deleted.</returns>
        public static Primitive CleanTemp()
        {
            string[] files = Directory.GetFiles(Path.GetTempPath());
            int fileCount = 0;
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                if (fileName.EndsWith(".dll") || fileName.EndsWith(".pdb") || fileName.EndsWith(".tmp"))
                {
                    try
                    {
                        System.IO.File.Delete(file);
                        fileCount++;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                }
            }
            return fileCount;
        }

        /// <summary>
        /// Get the next integer for object names.
        /// For example Buttons are labeled "Button1", "Button2" etc.
        /// This method returns the integer index that would be used for the next object added.
        /// </summary>
        /// <param name="listName">
        /// The map (list) type, valid listNames (Case sensitive) are:
        /// "Button"
        /// "TextBox"
        /// "ImageList"
        /// "Ellipse"
        /// "Image"
        /// "Line"
        /// "Rectangle"
        /// "Text"
        /// "Triangle"
        /// "Polygon"
        /// "Control"
        /// </param>
        /// <returns>The next object index to be used (0 on failure).</returns>
        public static Primitive GetNextMapIndex(Primitive listName)
        {
            Type ShapesType = typeof(Shapes);
            Dictionary<string, int> _nameGenerationMap;

            try
            {
                _nameGenerationMap = (Dictionary<string, int>)ShapesType.GetField("_nameGenerationMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                int num = 0;
                _nameGenerationMap.TryGetValue(listName, out num);
                return ++num;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Fix the Flickr object
        /// </summary>
        public static Primitive FixFlickr()
        {
            Type FlickrType = typeof(Flickr);
            FieldInfo fieldInfo = FlickrType.GetField("_urlTemplate", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
            string _urlTemplate = (string)fieldInfo.GetValue(null);
            _urlTemplate = _urlTemplate.Replace("http://", "https://");
            _urlTemplate = _urlTemplate.Replace("api.flickr.com", "www.flickr.com");
            fieldInfo.SetValue(null, _urlTemplate);

            fieldInfo = FlickrType.GetField("_picUrlTemplate", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
            string _picUrlTemplate = (string)fieldInfo.GetValue(null);
            _picUrlTemplate = _picUrlTemplate.Replace("http://", "https://");
            _picUrlTemplate = _picUrlTemplate.Replace("static.flickr.com", "staticflickr.com");
            fieldInfo.SetValue(null, _picUrlTemplate);

            Primitive result = new Primitive();
            result["_urlTemplate"] = _urlTemplate;
            result["_picUrlTemplate"] = _picUrlTemplate;
            return result;
        }

        /// <summary>
        /// Set the web address for use with LDNetwork if gamedata and highscore methods are handled on another server.
        /// </summary>
        public static Primitive NetworkURL
        {
            get
            {
                return Utilities.URL;
            }
            set
            {
                Utilities.URL = value;
            }
        }

        [HideFromIntellisense]
        public static Primitive FlikrKey
        {
            get
            {
                Type FlickrType = typeof(Flickr);
                return (string)FlickrType.GetField("_urlTemplate", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            }
            set
            {
                Type FlickrType = typeof(Flickr);
                FlickrType.GetField("_urlTemplate", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).SetValue(null, (string)value);
            }
        }

        /// <summary>
        /// Get the display device X DPI (dots per inch) resolution.
        /// </summary>
        public static Primitive DPIX
        {
            get
            {
                System.Drawing.Graphics g = System.Drawing.Graphics.FromHwnd(IntPtr.Zero);
                IntPtr desktop = g.GetHdc();

                return GDI32.GetDeviceCaps(desktop, GDI32.LOGPIXELSX);
            }
        }

        /// <summary>
        /// Get the display device Y DPI (dots per inch) resolution.
        /// </summary>
        public static Primitive DPIY
        {
            get
            {
                System.Drawing.Graphics g = System.Drawing.Graphics.FromHwnd(IntPtr.Zero);
                IntPtr desktop = g.GetHdc();

                return GDI32.GetDeviceCaps(desktop, GDI32.LOGPIXELSY);
            }
        }

        /// <summary>
        /// Get or set the current culture.
        /// </summary>
        public static Primitive CurrentCulture
        {
            get { return Thread.CurrentThread.CurrentCulture.Name; }
            set
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(value);
                Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
                CultureInfo.DefaultThreadCurrentCulture = Thread.CurrentThread.CurrentCulture;
                CultureInfo.DefaultThreadCurrentUICulture = Thread.CurrentThread.CurrentCulture;
            }
        }

        /// <summary>
        /// Get an array of available cultures.
        /// </summary>
        /// <returns>An array indexed by culture names, with the value set to a description.</returns>
        public static Primitive AvailableCultures()
        {
            // get culture names
            SortedDictionary<string, string> list = new SortedDictionary<string, string>();
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                list[ci.Name] = ci.EnglishName;
            }
            StringBuilder result = new StringBuilder();
            foreach (KeyValuePair<string, string> kvp in list)
            {
                result.Append($"{Utilities.ArrayParse(kvp.Key)}={Utilities.ArrayParse(kvp.Value)};");
            }
            return Utilities.CreateArrayMap(result.ToString());
        }

        /// <summary>
        /// Experimental option to speed some interactions with SmallBasicLibrary objects.
        /// "True" (default) or "False"
        /// </summary>
        public static Primitive UseExpression
        {
            get { return FastThread.UseExpression; }
            set { FastThread.UseExpression = value; }
        }

        /// <summary>
        /// Experimental option to speed some interactions with SmallBasicLibrary objects.
        /// "True" (default) or "False"
        /// </summary>
        public static Primitive UseDispatcher
        {
            get { return FastThread.UseDispatcher; }
            set { FastThread.UseDispatcher = value; }
        }

        /// <summary>
        /// Experimental option to speed some interactions with SmallBasicLibrary objects.
        /// 0 no force (default), 1 force Invoke (serial), 2 force BeginInvoke (async)
        /// </summary>
        public static Primitive ForceInvoke
        {
            get { return (int)FastThread.force; }
            set { FastThread.force = (FastThread.eForce)(int)value; }
        }

        /// <summary>
        /// Experimental option to speed some dispatcher interactions with SmallBasicLibrary objects.
        /// 1 to 10, (default 7, Render)
        /// </summary>
        public static Primitive Priority
        {
            get { return (int)FastThread.priority; }
            set { FastThread.priority = (DispatcherPriority)(int)value; }
        }

        /// <summary>
        /// Send a mouse click at the specified screen location.  Note this is Mouse.MouseX/Y, not GraphicsWindow.MouseX/Y.
        /// </summary>
        /// <param name="x">The screen x position to click, -1 uses current mouse position.</param>
        /// <param name="y">The screen y position to click, -1 uses current mouse position.</param>
        /// <param name="button">The button to press ("Left", "Right" or "Middle")</param>
        public static void SendClick(Primitive x, Primitive y, Primitive button)
        {
            int xCur = System.Windows.Forms.Cursor.Position.X;
            int yCur = System.Windows.Forms.Cursor.Position.Y;
            if (x >= 0 && y >= 0)
            {
                System.Windows.Forms.Cursor.Position = new System.Drawing.Point(x, y);
            }
            switch (((string)button).ToLower())
            {
                case "left":
                    User32.mouse_event(User32.MOUSEEVENTF_LEFTDOWN | User32.MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
                    break;
                case "right":
                    User32.mouse_event(User32.MOUSEEVENTF_RIGHTDOWN | User32.MOUSEEVENTF_RIGHTUP, (uint)x, (uint)y, 0, 0);
                    break;
                case "middle":
                    User32.mouse_event(User32.MOUSEEVENTF_MIDDLEDOWN | User32.MOUSEEVENTF_MIDDLEUP, (uint)x, (uint)y, 0, 0);
                    break;
            }
            if (x >= 0 && y >= 0)
            {
                System.Windows.Forms.Cursor.Position = new System.Drawing.Point(xCur, yCur);
            }
        }

        /// <summary>
        /// Save the entire visible screen as an image file (png, jpg, bmp, gif, tiff or ico).
        /// A short delay may be required after updating the window before calling.
        /// </summary>
        /// <param name="fileName">
        /// The file to save the image to (*.png, *.jpg, *.bmp, *.gif, *.tiff or *.ico).
        /// If this is set to "", then the image is created internally as an ImageList.
        /// </param>
        /// <returns>
        /// The ImageList image if fileName is "", otherwise if output to a file, then "" is returned.
        /// </returns>
        public static Primitive CaptureScreen(Primitive fileName)
        {
            Type ShapesType = typeof(Shapes);
            Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
            Dictionary<string, BitmapSource> _savedImages;
            try
            {
                Bitmap img = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(img);
                graphics.CopyFromScreen(0, 0, 0, 0, img.Size);

                string _fileName = ((string)fileName).ToLower();

                if (fileName == "")
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                            string shapeName = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { "ImageList" }).ToString();
                            _savedImages[shapeName] = FastPixel.GetBitmapImage((Bitmap)img);
                            return shapeName;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
                }
                else if (_fileName.EndsWith(".png"))
                {
                    img.Save(fileName, ImageFormat.Png);
                }
                else if (_fileName.EndsWith(".jpg") || _fileName.EndsWith(".jpeg"))
                {
                    img.Save(fileName, ImageFormat.Jpeg);
                }
                else if (_fileName.EndsWith(".bmp"))
                {
                    img.Save(fileName, ImageFormat.Bmp);
                }
                else if (_fileName.EndsWith(".gif"))
                {
                    img.Save(fileName, ImageFormat.Gif);
                }
                else if (_fileName.EndsWith(".tiff"))
                {
                    img.Save(fileName, ImageFormat.Tiff);
                }
                else if (_fileName.EndsWith(".ico"))
                {
                    img.Save(fileName, ImageFormat.Icon);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }
    }
}

