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
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using DrawingImage = System.Drawing.Image;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Media;
using Media = System.Windows.Media;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace LitDev
{
    /// <summary>
    /// GraphicsWindow utilities.
    /// </summary>
    [SmallBasicType]
    public static class LDGraphicsWindow
    {
        private static bool exitOnClose = true;
        private static bool cancelClose = false;

        public static SmallBasicCallback _ClosingDelegate = null;
        private static void _ClosingEvent(Object sender, CancelEventArgs e)
        {
            if (null != _ClosingDelegate) _ClosingDelegate();
            e.Cancel = cancelClose;
            cancelClose = false;
        }

        [HideFromIntellisense]
        public static void BackgroundBrushGradient(Primitive brush)
        {
            BackgroundBrush(brush);
        }

        /// <summary>
        /// Save the GraphicsWindow as an image file (png, jpg, bmp, gif, tiff or ico).
        /// 
        /// The window must be visible and a short delay may be required after updating the window before calling.
        /// </summary>
        /// <param name="fileName">
        /// The file to save the image to (*.png, *.jpg, *.bmp, *.gif, *.tiff or *.ico).
        /// If this is set to "", then the image is created internally as an ImageList.
        /// </param>
        /// <param name="border">
        /// Include the window border ("True" or "False").
        /// </param>
        /// <returns>
        /// The ImageList image if fileName is "", otherwise if output to a file, then "" is returned.
        /// </returns>
        public static Primitive Capture(Primitive fileName, Primitive border)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
            Dictionary<string, BitmapSource> _savedImages;
            GraphicsWindow.Show();
            Utilities.bTextWindow = false;
            Utilities.bBorder = border;
            try
            {
                IntPtr _hWnd = User32.FindWindow(null, GraphicsWindow.Title);
                DrawingImage img = Utilities.captureWindow(_hWnd);

                string _fileName = ((string)fileName).ToLower();

                if (fileName == "")
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                            string shapeName = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { "ImageList" }).ToString();
                            _savedImages[shapeName] = LDImage.getBitmapImage((Bitmap)img);
                            return shapeName;
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

        /// <summary>
        /// Print the GraphicsWindow contents.
        /// 
        /// The window must be visible and a short delay may be required after updating the window before calling.
        /// </summary>
        /// <param name="border">
        /// Include the window border ("True" or "False").
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void Print(Primitive border)
        {
            GraphicsWindow.Show();
            Utilities.bTextWindow = false;
            Utilities.bBorder = border;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Utilities.printWindow);
            System.Windows.Forms.PrintPreviewDialog dlg = new System.Windows.Forms.PrintPreviewDialog();
            dlg.Document = pd;
            dlg.Width = 600;
            dlg.Height = 600;
            dlg.ShowIcon = false;
            dlg.TopMost = true;
            if (LDUtilities.showPreview)
            {
                if (dlg.ShowDialog(Utilities.ForegroundHandle()) == System.Windows.Forms.DialogResult.OK)
                {
                    pd.Print();
                }
            }
            else
            {
                pd.Print();
            }
        }

        /// <summary>
        /// The GraphicsWindow style (None 0, SingleBorder 1, 3DBorder 2, ToolWindow 3).
        /// </summary>
        public static Primitive Style
        {
            get
            {
                GraphicsWindow.Show();
                return Utilities.getWindowStyle();
            }
            set
            {
                GraphicsWindow.Show();
                Utilities.setWindowStyle(value);
            }
        }

        /// <summary>
        /// The GraphicsWindow state (Normal 0, Minimised 1, Maximised 2).
        /// </summary>
        public static Primitive State
        {
            get
            {
                GraphicsWindow.Show();
                return Utilities.getWindowState();
            }
            set
            {
                GraphicsWindow.Show();
                Utilities.setWindowState(value);
            }
        }

        /// <summary>
        /// Pause GraphicsWindow Updates.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void PauseUpdates()
        {
            Utilities.doUpdates();
            IntPtr _hWnd = User32.FindWindow(null, GraphicsWindow.Title);
            User32.InvalidateRect(_hWnd, IntPtr.Zero, false); //Forces a redraw
            User32.SendMessage(_hWnd, User32.WM_SETREDRAW, false, 0);
        }

        /// <summary>
        /// Resume GraphicsWindow Updates.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void ResumeUpdates()
        {
            Utilities.doUpdates();
            IntPtr _hWnd = User32.FindWindow(null, GraphicsWindow.Title);
            User32.SendMessage(_hWnd, User32.WM_SETREDRAW, true, 0);
            User32.InvalidateRect(_hWnd, IntPtr.Zero, false); //Forces a redraw
        }

        /// <summary>
        /// Set the GraphicsWindow Icon
        /// </summary>
        public static Primitive Icon
        {
            set
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                try
                {
                    Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                    InvokeHelper ret = delegate
                    {
                        try
                        {
                            _window.Icon = BitmapFrame.Create(new Uri(value), BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    };
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Set or get the GraphicsWindow width if using LDScrollBars
        /// </summary>
        public static Primitive Width
        {
            get
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
                            ScrollViewer scrollViewer;
                            if (content.GetType() == typeof(ScrollViewer))
                            {
                                scrollViewer = (ScrollViewer)content;
                                return scrollViewer.ActualWidth.ToString(CultureInfo.InvariantCulture);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return GraphicsWindow.Width;
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return GraphicsWindow.Width;
            }

            set
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);

                try
                {
                    Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            Object content = _window.Content;
                            ScrollViewer scrollViewer;
                            if (content.GetType() == typeof(ScrollViewer))
                            {
                                scrollViewer = (ScrollViewer)content;
                                _window.Width = value + (_window.ActualWidth - scrollViewer.ActualWidth);
                            }
                            else
                            {
                                GraphicsWindow.Width = value;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Set or get the GraphicsWindow height if using LDScrollBars
        /// </summary>
        public static Primitive Height
        {
            get
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
                            ScrollViewer scrollViewer;
                            if (content.GetType() == typeof(ScrollViewer))
                            {
                                scrollViewer = (ScrollViewer)content;
                                return scrollViewer.ActualHeight.ToString(CultureInfo.InvariantCulture);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return GraphicsWindow.Height;
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return GraphicsWindow.Height;
            }

            set
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);

                try
                {
                    Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            Object content = _window.Content;
                            ScrollViewer scrollViewer;
                            if (content.GetType() == typeof(ScrollViewer))
                            {
                                scrollViewer = (ScrollViewer)content;
                                _window.Height = value + (_window.ActualHeight - scrollViewer.ActualHeight);
                            }
                            else
                            {
                                GraphicsWindow.Height = value;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Use screen capture for GraphicsWindow image creation.
        /// This only applies to Print and Capture methods when the border option is set to "False"
        /// If this option is set to "True" then the current visable GraphicsWindow is used to create a bitmap.
        /// If this option is set to "False" then the visuals in the GraphicsWindow will be re-rendered to a bitmap.
        /// Default "False"
        /// </summary>
        public static Primitive ScreenCapture
        {
            get
            {
                return Utilities.bScreenCapture;
            }
            set
            {
                Utilities.bScreenCapture = value;
            }
        }

        /// <summary>
        /// Set whether the SmallBasic program is ended when a GraphicsWindow is closed "True" (default) or "False".
        /// If set to false, the program must still have something running to continue.
        /// </summary>
        public static Primitive ExitOnClose
        {
            get
            {
                return exitOnClose;
            }

            set
            {
                //if (exitOnClose == value) return;
                exitOnClose = value;
                Type GraphicsWindowType = typeof(GraphicsWindow);

                try
                {
                    Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            EventInfo eventInfo = _window.GetType().GetEvent("Closing", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                            Delegate methodDelegate = Delegate.CreateDelegate(eventInfo.EventHandlerType, GraphicsWindowType, "WindowClosing");
                            if (exitOnClose)
                            {
                                _window.Closing -= new CancelEventHandler(_ClosingEvent);
                                eventInfo.AddEventHandler(_window, methodDelegate);
                            }
                            else
                            {
                                eventInfo.RemoveEventHandler(_window, methodDelegate);
                                _window.Closing += new CancelEventHandler(_ClosingEvent);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
                    method.Invoke(null, new object[] { ret });
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Event when a GraphicsWindow is closed.
        /// ExitOnClose must be set to "False" to use this event.
        /// If CancelClose is set to true, then the closure will be cancelled.
        /// </summary>
        public static event SmallBasicCallback Closing
        {
            add
            {
                _ClosingDelegate = value;
            }
            remove
            {
                _ClosingDelegate = null;
            }
        }

        /// <summary>
        /// Cancel the next GraphicsWindow Close operation "True" or "False" (default).
        /// Requires ExitOnClose to be set to "False".
        /// This should usually be set inside Closing event, possibly using LDDialogs.Confirm.
        /// It will be reset to "False" after a closure is prevented.
        /// </summary>
        public static Primitive CancelClose
        {
            get { return cancelClose; }
            set { cancelClose = value; }
        }

        /// <summary>
        /// Set the mode of the close button for a window.
        /// </summary>
        /// <param name="window">The window title, e.g. TextWindow.Title or GraphicsWindow.Title.</param>
        /// <param name="mode">The mode "Enabled", "Disabled")</param>
        public static void ExitButtonMode(Primitive window, Primitive mode)
        {
            try
            {
                IntPtr _hWnd = User32.FindWindow(null, window);
                IntPtr hSystemMenu = User32.GetSystemMenu(_hWnd, false);
                switch (((string)mode).ToLower())
                {
                    case "enabled":
                        User32.EnableMenuItem(hSystemMenu, User32.SC_CLOSE, User32.MF_ENABLED);
                        break;
                    case "grayed":
                        User32.EnableMenuItem(hSystemMenu, User32.SC_CLOSE, User32.MF_GRAYED);
                        break;
                    case "disabled":
                        User32.EnableMenuItem(hSystemMenu, User32.SC_CLOSE, User32.MF_DISABLED);
                        break;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Create a transparent GraphicsWindow.
        /// This must be the called before any other GraphicsWindow, Controls or Shapes methods that create a window.
        /// To see anything you must add something to the transparent GraphicsWindow.
        /// For example, create a non-rectangular window using a transparent border png with LDShapes.BackgroundImage.
        /// The transparency can be altered with GraphicsWindow.BackgroundColor.
        /// Sometimes less than 100% transparency can be required (e.g. to register mouse movements).
        /// </summary>
        public static void TransparentGW()
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Window _window;

            try
            {
                GraphicsWindowType.GetField("_isHidden", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).SetValue(null, true);
                GraphicsWindowType.GetMethod("CreateWindow", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).Invoke(null, new object[] { });
                _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        _window.AllowsTransparency = true;
                        _window.WindowStyle = WindowStyle.None;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { ret });
                GraphicsWindow.BackgroundColor = LDColours.Transparent;
                GraphicsWindow.Show();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set the GraphicsWindow as the top most window.
        /// The window will remain above other windows even when other windows are in focus.
        /// "True" or "False".
        /// </summary>
        public static Primitive TopMost
        {
            get
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Window _window;

                try
                {
                    _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            return _window.Topmost ? "True" : "False";
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "False";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return "False";
            }

            set
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Window _window;

                try
                {
                    _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            _window.Topmost = value;
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
        /// Set the background as an image.
        /// The backgound is auto rescaled to fill whatever size the GraphicsWindow is.
        /// </summary>
        /// <param name="imageName">
        /// The image to load as the background.
        /// Value returned from ImageList.LoadImage or local or network image file.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void BackgroundImage(Primitive imageName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Window _window;
            Type ImageListType = typeof(ImageList);
            Dictionary<string, BitmapSource> _savedImages;
            BitmapSource img;

            try
            {
                _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_savedImages.TryGetValue((string)imageName, out img))
                {
                    imageName = ImageList.LoadImage(imageName);
                    if (!_savedImages.TryGetValue((string)imageName, out img))
                    {
                        return;
                    }
                }
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        _window.Background = new ImageBrush(img);
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

        /// <summary>
        /// Set the background as a gradient of colours.
        /// </summary>
        /// <param name="brush">
        /// A previously created gradient or image brush (LDShapes.BrushGradient LDShapes.BrushImage).
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void BackgroundBrush(Primitive brush)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Window _window;

            try
            {
                _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        foreach (GradientBrush i in LDShapes.brushes)
                        {
                            if (i.name == brush)
                            {
                                _window.Background = i.getBrush();
                            }
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

        /// <summary>Set font in GraphicsWindow from a local TTF font file.</summary>
        /// <param name="fontFile">Full path to font file to set.</param>
        /// <returns>The font name on success, else "FAILED".</returns>
        public static Primitive SetFontFromFile(Primitive fontFile)
        {
            try
            {
                //Path and Folder
                string fntPath = Environment.ExpandEnvironmentVariables(fontFile);
                string fntFolder = System.IO.Path.GetDirectoryName(fntPath);
                if (!System.IO.File.Exists(fntPath)) return "FAILED";

                //Font Name
                PrivateFontCollection fntColl = new PrivateFontCollection();
                fntColl.AddFontFile(fntPath);
                string fntName = "file:///" + fntFolder + "/#" + fntColl.Families[0].Name;

                //Load Font
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Media.FontFamily fontFamily = new Media.FontFamily(fntName);
                GraphicsWindowType.GetField("_fontFamily", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).SetValue(null, fontFamily);
                return fntName;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Gets the color of the pixel at the specified x and y co-ordinates.
        /// This method works for background, drawing and shape layers.
        /// </summary>
        /// <param name="x">
        /// The x co-ordinate of the pixel.
        /// </param>
        /// <param name="y">
        /// The y co-ordinate of the pixel.
        /// </param>
        /// <returns>
        /// The color of the pixel.
        /// </returns>
        public static Primitive GetPixel(Primitive x, Primitive y)
        {
            try
            {
                x = (int)x;
                y = (int)y;
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(Utilities.captureGW());
                if (x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height)
                {
                    System.Drawing.Color color = bmp.GetPixel(x, y);
                    return string.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "#000000";
        }

        private static bool IsPixel(int x, int y, System.Drawing.Color color, byte[] data, int bytesPerPixel, int stride)
        {
            if (data[stride * y + bytesPerPixel * x] != color.B) return false;
            if (data[stride * y + bytesPerPixel * x + 1] != color.G) return false;
            if (data[stride * y + bytesPerPixel * x + 2] != color.R) return false;
            if (data[stride * y + bytesPerPixel * x + 3] != color.A) return false;
            return true;
        }
        private static void SetPixel(int x, int y, System.Drawing.Color color, byte[] data, int bytesPerPixel, int stride)
        {
            data[stride * y + bytesPerPixel * x] = color.B;
            data[stride * y + bytesPerPixel * x + 1] = color.G;
            data[stride * y + bytesPerPixel * x + 2] = color.R;
            data[stride * y + bytesPerPixel * x + 3] = color.A;
        }

        /// <summary>
        /// Fill a region surrounding a specified pixel.
        /// All neighbour pixels of the same colour are changed.
        /// This only applies to the drawing layer of the GraphicsWindow.
        /// </summary>
        /// <param name="x">
        /// The x co-ordinate of the pixel to start the fill.
        /// </param>
        /// <param name="y">
        /// The y co-ordinate of the pixel to start the fill.
        /// </param>
        /// <param name="colour">
        /// The colour to fill with.
        /// </param>
        public static void FloodFill(Primitive x, Primitive y, Primitive colour)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            x = (int)x;
            y = (int)y;

            try
            {
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        //Prepare bitmap
                        GraphicsWindowType.GetMethod("Rasterize", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).Invoke(null, new object[] { });
                        RenderTargetBitmap _renderBitmap = (RenderTargetBitmap)GraphicsWindowType.GetField("_renderBitmap", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                        System.Drawing.Bitmap bitmap = LDImage.getBitmap(_renderBitmap);
                        int bytesPerPixel = _renderBitmap.Format.BitsPerPixel / 8;
                        int stride = _renderBitmap.PixelWidth * bytesPerPixel;
                        System.Drawing.Color colNew = System.Drawing.ColorTranslator.FromHtml(colour);
                        System.Drawing.Color colOld = bitmap.GetPixel(x, y);
                        if (colNew == colOld) return;
                        int nx = bitmap.Width;
                        int ny = bitmap.Height;

                        byte[] data = new byte[stride * _renderBitmap.PixelHeight];
                        _renderBitmap.CopyPixels(data, stride, 0);

                        Stack<int> points = new Stack<int>();
                        int point, _x, _y;
                        points.Push(y * nx + x);
                        while (points.Count > 0)
                        {
                            point = points.Pop();
                            _x = point % nx;
                            _y = point / nx;
                            bitmap.SetPixel(_x, _y, colNew);
                            SetPixel(_x, _y, colNew, data, bytesPerPixel, stride);
                            if (_x > 0 && IsPixel(_x - 1, _y, colOld, data, bytesPerPixel, stride)) points.Push(_y * nx + _x - 1);
                            if (_x < nx - 1 && IsPixel(_x + 1, _y, colOld, data, bytesPerPixel, stride)) points.Push(_y * nx + _x + 1);
                            if (_y > 0 && IsPixel(_x, _y - 1, colOld, data, bytesPerPixel, stride)) points.Push((_y - 1) * nx + _x);
                            if (_y < ny - 1 && IsPixel(_x, _y + 1, colOld, data, bytesPerPixel, stride)) points.Push((_y + 1) * nx + _x);
                        }

                        //bitmap = new Bitmap(nx, ny, bitmap.PixelFormat);
                        //BitmapData bmData = bitmap.LockBits(new System.Drawing.Rectangle(0, 0, nx, ny), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                        //IntPtr pNative = bmData.Scan0;
                        //Marshal.Copy(data, 0, pNative, nx * ny * bytesPerPixel);
                        //bitmap.UnlockBits(bmData); 

                        //Display bitmap
                        BitmapImage bitmapImage = LDImage.getBitmapImage(bitmap);
                        DrawingGroup _mainDrawing = (DrawingGroup)GraphicsWindowType.GetField("_mainDrawing", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                        DrawingContext drawingContext = _mainDrawing.Append();
                        drawingContext.DrawImage(bitmapImage, new Rect(0, 0, nx, ny));
                        drawingContext.Close();
                        _renderBitmap.Clear();
                        GraphicsWindowType.GetMethod("AddRasterizeOperationToQueue", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { });
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

        /// <summary>
        /// Move the mouse to GraphicsWindow X coordinate.
        /// Set as well as get.
        /// </summary>
        public static Primitive MouseX
        {
            get
            {
                return GraphicsWindow.MouseX;
            }
            set
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Canvas _mainCanvas;

                try
                {
                    _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Point position = System.Windows.Forms.Cursor.Position;
                            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)_mainCanvas.PointToScreen(new System.Windows.Point(value, 0)).X, position.Y);
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
        /// Move the mouse to GraphicsWindow Y coordinate.
        /// Set as well as get.
        /// </summary>
        public static Primitive MouseY
        {
            get
            {
                return GraphicsWindow.MouseY;
            }
            set
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Canvas _mainCanvas;

                try
                {
                    _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Drawing.Point position = System.Windows.Forms.Cursor.Position;
                            System.Windows.Forms.Cursor.Position = new System.Drawing.Point(position.X, (int)_mainCanvas.PointToScreen(new System.Windows.Point(0, value)).Y);
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
        /// Scaling of GraphicsWindow to Desktop coordinates.
        /// Mouse.X = MouseXOffset + MouseXScale * GraphicsWindow.MouseX.
        /// </summary>
        public static Primitive MouseXOffset
        {
            get
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Canvas _mainCanvas;

                try
                {
                    _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            return _mainCanvas.PointToScreen(new System.Windows.Point(0, 0)).X;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return 1;
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return 1;
                }
            }
        }

        /// <summary>
        /// Scaling of GraphicsWindow to Desktop coordinates.
        /// Mouse.Y = MouseYOffset + MouseYScale * GraphicsWindow.MouseY.
        /// </summary>
        public static Primitive MouseYOffset
        {
            get
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Canvas _mainCanvas;

                try
                {
                    _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            return _mainCanvas.PointToScreen(new System.Windows.Point(0, 0)).Y;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return 1;
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return 1;
                }
            }
        }

        /// <summary>
        /// Scaling of GraphicsWindow to Desktop coordinates.
        /// Mouse.X = MouseXOffset + MouseXScale * GraphicsWindow.MouseX.
        /// </summary>
        public static Primitive MouseXScale
        {
            get
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Canvas _mainCanvas;

                try
                {
                    _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            return (_mainCanvas.PointToScreen(new System.Windows.Point(100, 0)).X - _mainCanvas.PointToScreen(new System.Windows.Point(0, 0)).X) / 100.0;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return 1;
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return 1;
                }
            }
        }

        /// <summary>
        /// Scaling of GraphicsWindow to Desktop coordinates.
        /// Mouse.Y = MouseYOffset + MouseYScale * GraphicsWindow.MouseY.
        /// </summary>
        public static Primitive MouseYScale
        {
            get
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Canvas _mainCanvas;

                try
                {
                    _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            return (_mainCanvas.PointToScreen(new System.Windows.Point(0, 100)).Y - _mainCanvas.PointToScreen(new System.Windows.Point(0, 0)).Y) / 100.0;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return 1;
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return 1;
                }
            }
        }

        /// <summary>
        /// Set the GraphicsWindow as active (has focus).
        /// </summary>
        public static void SetActive()
        {
            GraphicsWindow.Show();
            IntPtr hWnd = User32.FindWindow(null, GraphicsWindow.Title);
            User32.SetForegroundWindow(hWnd);
        }

        /// <summary>
        /// Scale and move all Shapes and Contols within the GraphicsWindow.
        /// This method resizes and moves the view rather than the shapes, so their positions and other properties remain unchanged but appear scaled within the repositioned region.
        /// For example Shapes.GetLeft remains unchanged although the view has been repositioned and GraphicsWindow.MouseX reports the coordinates relative to the repositioned view.
        /// All drawing remains within the original GraphicsWindow.
        /// </summary>
        /// <param name="scaleX">The X direction scaling of the view.</param>
        /// <param name="scaleY">The Y direction scaling of the view.</param>
        /// <param name="scaleCenterX">The X position of the center of scaling within the scaled view.</param>
        /// <param name="scaleCenterY">The Y position of the center of scaling within the scaled view.</param>
        /// <param name="viewX">The X position of scaleCenterX within the unscaled GraphicsWindow.</param>
        /// <param name="viewY">The Y position of scaleCenterY within the unscaled GraphicsWindow.</param>
        public static void Reposition(Primitive scaleX, Primitive scaleY, Primitive scaleCenterX, Primitive scaleCenterY, Primitive viewX, Primitive viewY)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Canvas _mainCanvas;
            ScaleTransform scaleTransform;
            TranslateTransform translateTransform;

            try
            {
                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        FrameworkElement frameworkElement = _mainCanvas as FrameworkElement;
                        if (!(_mainCanvas.RenderTransform is TransformGroup))
                        {
                            _mainCanvas.RenderTransform = new TransformGroup();
                            scaleTransform = new ScaleTransform();
                            translateTransform = new TranslateTransform();
                            ((TransformGroup)_mainCanvas.RenderTransform).Children.Add(scaleTransform);
                            ((TransformGroup)_mainCanvas.RenderTransform).Children.Add(translateTransform);
                        }
                        else
                        {
                            scaleTransform = (ScaleTransform)((TransformGroup)_mainCanvas.RenderTransform).Children[0];
                            translateTransform = (TranslateTransform)((TransformGroup)_mainCanvas.RenderTransform).Children[1];
                        }
                        scaleTransform.CenterX = scaleCenterX;
                        scaleTransform.CenterY = scaleCenterY;
                        scaleTransform.ScaleX = scaleX;
                        scaleTransform.ScaleY = scaleY;
                        translateTransform.X = viewX - scaleCenterX;
                        translateTransform.Y = viewY - scaleCenterY;
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
}