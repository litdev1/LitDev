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
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//LitDev Extension is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with menu.  If not, see <http://www.gnu.org/licenses/>.

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
using LitDev.Engines;
using System.Windows.Media.Animation;

namespace LitDev
{
    /// <summary>
    /// GraphicsWindow utilities.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDGraphicsWindow
    {
        static LDGraphicsWindow()
        {
            Instance.Verify();
        }

        private static object[] data;

        private static bool exitOnClose = true;
        private static bool cancelClose = false;
        private static double floodFillTolerance = 0;
        public static bool bNewPause = true;

        public static SBCallback _ClosingDelegate = null;
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
            Type ImageListType = typeof(SBImageList);
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
#if SVB
                            string shapeName = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { "ImageList", false }).ToString();
#else
                            string shapeName = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { "ImageList" }).ToString();
#endif
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
            Utilities.NumPages = 1;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Utilities.printWindow);
            if (LDUtilities.showPreview)
            {
                System.Windows.Forms.PrintPreviewDialog dlg = new System.Windows.Forms.PrintPreviewDialog();
                dlg.Document = pd;
                dlg.Width = 600;
                dlg.Height = 600;
                dlg.ShowIcon = false;
                dlg.TopMost = true;
                dlg.ShowDialog(Utilities.ForegroundHandle());
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
            if (bNewPause)
                User32.LockWindowUpdate(_hWnd);
            else
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
            if (bNewPause)
                User32.LockWindowUpdate(IntPtr.Zero);
            else
                User32.SendMessage(_hWnd, User32.WM_SETREDRAW, true, 0);
            User32.InvalidateRect(_hWnd, IntPtr.Zero, false); //Forces a redraw
        }

        /// <summary>
        /// Set the GraphicsWindow Icon, "SB" sets to Small Basic icon.
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
                            if (value == "SB")
                            {
                                _window.Icon = FastPixel.GetBitmapImage(global::LitDev.Properties.Resources.SBIcon);
                            }
                            else
                            {
                                _window.Icon = BitmapFrame.Create(new Uri(value), BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    };
                    FastThread.Invoke(ret);
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
                    return FastThread.InvokeWithReturn(ret).ToString();
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
                    FastThread.Invoke(ret);
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
                    return FastThread.InvokeWithReturn(ret).ToString();
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
                    FastThread.Invoke(ret);
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
                    FastThread.Invoke(ret);
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
        public static event SBCallback Closing
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
                FastThread.Invoke(ret);
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
                    return FastThread.InvokeWithReturn(ret).ToString();
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
                    FastThread.Invoke(ret);
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
                FastThread.Invoke(ret);
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
                FastThread.Invoke(ret);
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

        /// <summary>
        /// A tolerance for FloodFill method (0 to 100).
        /// 0 is default and only pixels of exactly the same colour are changed, 100 changes all pixels apart from new fill colour.
        /// </summary>
        public static Primitive FloodFillTolerance
        {
            get { return floodFillTolerance; }
            set { floodFillTolerance = value; }
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
            double tolerance = (floodFillTolerance * 255.0 / 100.0);
            tolerance *= tolerance;

            try
            {
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        //Prepare bitmap
                        GraphicsWindowType.GetMethod("Rasterize", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).Invoke(null, new object[] { });
                        RenderTargetBitmap _renderBitmap = (RenderTargetBitmap)GraphicsWindowType.GetField("_renderBitmap", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                        FastPixel fp = new FastPixel(_renderBitmap);
                        System.Drawing.Color colNew = ColorTranslator.FromHtml(colour);
                        System.Drawing.Color colOld = fp.GetPixel(x, y);
                        if (colNew == colOld) return;
                        int nx = fp.Width;
                        int ny = fp.Height;

                        Stack<int> points = new Stack<int>();
                        int point, _x, _y;
                        points.Push(y * nx + x);
                        while (points.Count > 0)
                        {
                            point = points.Pop();
                            _x = point % nx;
                            _y = point / nx;
                            fp.SetPixel(_x, _y, colNew);
                            if (_x > 0 && fp.GetVariance(_x - 1, _y, colOld, colNew) <= tolerance) points.Push(_y * nx + _x - 1);
                            if (_x < nx - 1 && fp.GetVariance(_x + 1, _y, colOld, colNew) <= tolerance) points.Push(_y * nx + _x + 1);
                            if (_y > 0 && fp.GetVariance(_x, _y - 1, colOld, colNew) <= tolerance) points.Push((_y - 1) * nx + _x);
                            if (_y < ny - 1 && fp.GetVariance(_x, _y + 1, colOld, colNew) <= tolerance) points.Push((_y + 1) * nx + _x);
                        }
                        fp.Unlock(true);

                        //Display bitmap
                        BitmapImage bitmapImage = fp.BitmapImage;
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
                FastThread.Invoke(ret);
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
                    FastThread.Invoke(ret);
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
                    FastThread.Invoke(ret);
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
                            return _mainCanvas.PointToScreen(new System.Windows.Point(0, 0)).X.ToString(CultureInfo.InvariantCulture);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return 1;
                        }
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
                            return _mainCanvas.PointToScreen(new System.Windows.Point(0, 0)).Y.ToString(CultureInfo.InvariantCulture);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return 1;
                        }
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
                            return ((_mainCanvas.PointToScreen(new System.Windows.Point(100, 0)).X - _mainCanvas.PointToScreen(new System.Windows.Point(0, 0)).X) / 100.0).ToString(CultureInfo.InvariantCulture);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return 1;
                        }
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
                            return ((_mainCanvas.PointToScreen(new System.Windows.Point(0, 100)).Y - _mainCanvas.PointToScreen(new System.Windows.Point(0, 0)).Y) / 100.0).ToString(CultureInfo.InvariantCulture);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return 1;
                        }
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        public static Primitive SetActive()
        {
            GraphicsWindow.Show();
            IntPtr hWnd = User32.FindWindow(null, GraphicsWindow.Title);
            if (hWnd == IntPtr.Zero) return "GraphicsWindow not found";
            if (!User32.SetForegroundWindow(hWnd)) return "Cannot set GraphicsWindow as active";
            return "SUCCESS";
        }

        private static ScaleTransform scaleTransform;
        private static RotateTransform rotateTransform;
        private static TranslateTransform translateTransform;
        private static void GetTransforms(Canvas canvas)
        {
            if (!(canvas.RenderTransform is TransformGroup))
            {
                canvas.RenderTransform = new TransformGroup();

                translateTransform = new TranslateTransform();
                ((TransformGroup)canvas.RenderTransform).Children.Add(translateTransform);

                scaleTransform = new ScaleTransform();
                scaleTransform.CenterX = canvas.ActualWidth / 2.0;
                scaleTransform.CenterY = canvas.ActualWidth / 2.0;
                ((TransformGroup)canvas.RenderTransform).Children.Add(scaleTransform);

                rotateTransform = new RotateTransform();
                rotateTransform.CenterX = canvas.ActualWidth / 2.0;
                rotateTransform.CenterY = canvas.ActualHeight / 2.0;
                ((TransformGroup)canvas.RenderTransform).Children.Add(rotateTransform);
            }
            else
            {
                translateTransform = (TranslateTransform)((TransformGroup)canvas.RenderTransform).Children[0];
                scaleTransform = (ScaleTransform)((TransformGroup)canvas.RenderTransform).Children[1];
                rotateTransform = (RotateTransform)((TransformGroup)canvas.RenderTransform).Children[2];
            }
        }

        private static void Reposition_Delegate()
        {
            int i = 0;
            Canvas _mainCanvas = (Canvas)data[i++];
            double scaleX = (double)data[i++];
            double scaleY = (double)data[i++];
            double panX = (double)data[i++];
            double panY = (double)data[i++];
            double angle = (double)data[i++];

            GetTransforms(_mainCanvas);

            translateTransform.X = panX;
            translateTransform.Y = panY;

            scaleTransform.ScaleX = scaleX;
            scaleTransform.ScaleY = scaleY;

            rotateTransform.Angle = angle;

            //Grid grid = (Grid)_mainCanvas.Parent;
            //System.Windows.Point pointView = new System.Windows.Point(GraphicsWindow.Width / 2, GraphicsWindow.Height / 2);
            //System.Windows.Point pointGW = grid.PointFromScreen(_mainCanvas.PointToScreen(pointView));
            //TextWindow.WriteLine(rotateTransform.CenterX + " , " + pointGW.X);
            //rotateTransform.CenterX = pointGW.X;
            //rotateTransform.CenterY = pointGW.Y;

            _mainCanvas.InvalidateVisual();
        }
        /// <summary>
        /// Scale and move all Shapes and Controls within the GraphicsWindow.
        /// This method resizes and moves the view rather than the shapes, so their positions and other properties remain unchanged but appear scaled within the repositioned region.
        /// For example Shapes.GetLeft remains unchanged although the view has been repositioned and GraphicsWindow.MouseX reports the coordinates relative to the repositioned view.
        /// Imagine the entire view is repositioned as if it were a shape inside the GrapicsWindow.
        /// The transformation between view coordinates (vX,vY) and GraphicsWindow coordinates (gwX,gwY) is:
        /// gwX = (vX+panX)*scaleX + gw*(1-scaleX)/2
        /// gwY = (vY+panY)*scaleY + gh*(1-scaleY)/2
        /// All drawing remains within the original GraphicsWindow.
        /// </summary>
        /// <param name="scaleX">The X direction scaling of the view.</param>
        /// <param name="scaleY">The Y direction scaling of the view.</param>
        /// <param name="panX">Pan the view in the X direction in the view scaling, 0 is centered in the GraphicsWindow.</param>
        /// <param name="panY">Pan the view in the Y direction in the view scaling, 0 is centered in the GraphicsWindow.</param>
        /// <param name="angle">An angle to rotate the view.</param>
        public static void Reposition(Primitive scaleX, Primitive scaleY, Primitive panX, Primitive panY, Primitive angle)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Canvas _mainCanvas;

            try
            {
                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                data = new object[] { _mainCanvas, (double)scaleX, (double)scaleY, (double)panX, (double)panY, (double)angle };
                FastThread.Invoke(Reposition_Delegate);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static void Animate_Delegate()
        {
            int i = 0;
            Canvas _mainCanvas = (Canvas)data[i++];
            double scaleX = (double)data[i++];
            double scaleY = (double)data[i++];
            double panX = (double)data[i++];
            double panY = (double)data[i++];
            double angle = (double)data[i++];
            double duration = (double)data[i++];

            Duration _duration = new Duration(TimeSpan.FromMilliseconds(duration));
            GetTransforms(_mainCanvas);

            if (translateTransform.X != panX)
            {
                DoubleAnimation animatePosX = new DoubleAnimation(translateTransform.X, panX, _duration)
                {
                    FillBehavior = FillBehavior.HoldEnd,
                    DecelerationRatio = 0.0
                };
                translateTransform.BeginAnimation(TranslateTransform.XProperty, animatePosX);
            }

            if (translateTransform.Y != panY)
            {
                DoubleAnimation animatePosY = new DoubleAnimation(translateTransform.Y, panY, _duration)
                {
                    FillBehavior = FillBehavior.HoldEnd,
                    DecelerationRatio = 0.0
                };
                translateTransform.BeginAnimation(TranslateTransform.YProperty, animatePosY);
            }

            if (scaleTransform.ScaleX != scaleX)
            {
                DoubleAnimation animateScaleX = new DoubleAnimation(scaleTransform.ScaleX, scaleX, _duration)
                {
                    FillBehavior = FillBehavior.HoldEnd,
                    DecelerationRatio = 0.0
                };
                scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, animateScaleX);
            }

            if (scaleTransform.ScaleY != scaleY)
            {
                DoubleAnimation animateScaleY = new DoubleAnimation(scaleTransform.ScaleY, scaleY, _duration)
                {
                    FillBehavior = FillBehavior.HoldEnd,
                    DecelerationRatio = 0.0
                };
                scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, animateScaleY);
            }

            if (rotateTransform.Angle != angle)
            {
                DoubleAnimation animateRotate = new DoubleAnimation(rotateTransform.Angle, angle, _duration)
                {
                    FillBehavior = FillBehavior.HoldEnd,
                    DecelerationRatio = 0.0
                };
                rotateTransform.BeginAnimation(RotateTransform.AngleProperty, animateRotate);
            }
        }
        /// <summary>
        /// Scale and move all Shapes and Controls within the GraphicsWindow, by smooth animation.
        /// This is the same as the Reposition method except that the movement is animated.
        /// </summary>
        /// <param name="scaleX">The X direction scaling of the view.</param>
        /// <param name="scaleY">The Y direction scaling of the view.</param>
        /// <param name="panX">Pan the view in the X direction in the view scaling, 0 is centered in the GraphicsWindow.</param>
        /// <param name="panY">Pan the view in the Y direction in the view scaling, 0 is centered in the GraphicsWindow.</param>
        /// <param name="angle">An angle to rotate the view.</param>
        /// <param name="duration">The time for the animation, in milliseconds.</param>
        public static void Animate(Primitive scaleX, Primitive scaleY, Primitive panX, Primitive panY, Primitive angle, Primitive duration)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Canvas _mainCanvas;

            try
            {
                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                data = new object[] { _mainCanvas, (double)scaleX, (double)scaleY, (double)panX, (double)panY, (double)angle, (double)duration };
                FastThread.Invoke(Animate_Delegate);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Get coordinates transformed between GraphicsWindow and a repositioned View (See Reposition).
        /// </summary>
        /// <param name="x">The x coordinate to transform.</param>
        /// <param name="y">The x coordinate to transform.</param>
        /// <param name="toGW">Transfer from View to GraphicsWindow ("True") or from GraphicsWindow to View ("False").</param>
        /// <returns>A 2D array of transformed coordinates indexed by 1 and 2.</returns>
        public static Primitive RepositionPoint(Primitive x, Primitive y, Primitive toGW)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Canvas _mainCanvas;
            Primitive result = "";

            try
            {
                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        Grid grid = (Grid)_mainCanvas.Parent;
                        if (toGW)
                        {
                            System.Windows.Point pointView = new System.Windows.Point(x, y);
                            //System.Windows.Point pointGW = grid.PointFromScreen(_mainCanvas.PointToScreen(pointView));
                            GeneralTransform transform = _mainCanvas.TransformToVisual(grid);
                            System.Windows.Point pointGW = transform.Transform(pointView);
                            result[1] = pointGW.X;
                            result[2] = pointGW.Y;
                        }
                        else
                        {
                            System.Windows.Point pointGW = new System.Windows.Point(x, y);
                            //System.Windows.Point pointView = _mainCanvas.PointFromScreen(grid.PointToScreen(pointGW));
                            GeneralTransform transform = grid.TransformToVisual(_mainCanvas);
                            System.Windows.Point pointView = transform.Transform(pointGW);
                            result[1] = pointView.X;
                            result[2] = pointView.Y;
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                });
                FastThread.Invoke(ret);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return result;
        }

        /// <summary>
        /// The mouse X GraphicsWindow coordinate in a repositioned view (see Reposition).
        /// </summary>
        public static Primitive RepositionedMouseX
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
                        System.Drawing.Point position = System.Windows.Forms.Cursor.Position;
                        Grid grid = (Grid)_mainCanvas.Parent;
                        GeneralTransform transform = _mainCanvas.TransformToVisual(grid);
                        return transform.Transform(_mainCanvas.PointFromScreen(new System.Windows.Point(position.X, position.Y))).X.ToString(CultureInfo.InvariantCulture);
                        //return grid.PointFromScreen(new System.Windows.Point(position.X, position.Y)).X;
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return "";
                }
            }
        }

        /// <summary>
        /// The mouse GraphicsWindow Y coordinate in a repositioned view (see Reposition).
        /// </summary>
        public static Primitive RepositionedMouseY
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
                        System.Drawing.Point position = System.Windows.Forms.Cursor.Position;
                        Grid grid = (Grid)_mainCanvas.Parent;
                        GeneralTransform transform = _mainCanvas.TransformToVisual(grid);
                        return transform.Transform(_mainCanvas.PointFromScreen(new System.Windows.Point(position.X, position.Y))).Y.ToString(CultureInfo.InvariantCulture);
                        //return grid.PointFromScreen(new System.Windows.Point(position.X, position.Y)).Y;
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return "";
                }
            }
        }

        /// <summary>
        /// The GraphicsWindow resize mode (CanMinimize 0, CanResize 1, CanResizeWithGrip 2, NoResize 3).
        /// </summary>
        public static Primitive Resize
        {
            get
            {
                GraphicsWindow.Show();
                return Utilities.getWindowResize();
            }
            set
            {
                GraphicsWindow.Show();
                Utilities.setWindowResize(value);
            }
        }

        /// <summary>
        /// Show or hide GraphicsWindow in taskbar ("True" or "False")
        /// </summary>
        public static Primitive ShowInTaskbar
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
                            _window.ShowInTaskbar = value;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    };
                    FastThread.Invoke(ret);
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
            get
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                try
                {
                    Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                    InvokeHelperWithReturn ret = delegate
                    {
                        return _window.ShowInTaskbar ? "True" : "False";
                    };
                    return FastThread.InvokeWithReturn(ret).ToString();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return "True";
                }
            }
        }

        /// <summary>
        /// Reset the LastKey to None.
        /// </summary>
        public static void LastKeyReset()
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            try
            {
                GraphicsWindowType.GetField("_lastKey", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).SetValue(null, System.Windows.Input.Key.None);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Draws a line of text on the screen at the specified location.
        /// </summary>
        /// <param name="x">
        /// The x co-ordinate of the text start point.
        /// </param>
        /// <param name="y">
        /// The y co-ordinate of the text start point.
        /// </param>
        /// <param name="width">
        /// The maximum available width.  This parameter helps define when the text should wrap.
        /// </param>
        /// <param name="text">
        /// The text to draw.
        /// </param>
        //public static void DrawBoundText(Primitive x, Primitive y, Primitive width, Primitive text)
        //{
        //    if (text == "") return;
        //    Type GraphicsWindowType = typeof(GraphicsWindow);
        //    InvokeHelper ret = delegate
        //    {
        //        try
        //        {
        //            GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { });
        //            DrawingGroup _mainDrawing = (DrawingGroup)GraphicsWindowType.GetField("_mainDrawing", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
        //            DrawingContext drawingContext = _mainDrawing.Append();

        //            Media.FontFamily _fontFamily = (Media.FontFamily)GraphicsWindowType.GetField("_fontFamily", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
        //            double _fontSize = (double)GraphicsWindowType.GetField("_fontSize", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
        //            FontWeight _fontWeight = (FontWeight)GraphicsWindowType.GetField("_fontWeight", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
        //            System.Windows.FontStyle _fontStyle = (System.Windows.FontStyle)GraphicsWindowType.GetField("_fontStyle", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
        //            Media.Brush _fillBrush = (Media.Brush)GraphicsWindowType.GetField("_fillBrush", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

        //            drawingContext.DrawText(new FormattedText(text, CultureInfo.CurrentUICulture, FlowDirection.LeftToRight, new Typeface(_fontFamily, _fontStyle, _fontWeight, FontStretches.Normal), _fontSize, _fillBrush)
        //            {
        //                MaxTextWidth = width
        //            }, new System.Windows.Point((double)x, (double)y));
        //            drawingContext.Close();
        //            GraphicsWindowType.GetMethod("AddRasterizeOperationToQueue", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { });
        //        }
        //        catch (Exception ex)
        //        {
        //            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
        //        }
        //    };
        //    FastThread.Invoke(ret);
        //}
    }

#if SVB
#else
    /// <summary>
    /// Alias for GraphicsWindow.
    /// 
    /// The GraphicsWindow provides graphics related input and output functionality.  For example, using this class, it is possible to draw and fill circles and rectangles.
    /// </summary>
    [SmallBasicType]
    public static class GW
    {
        /// <summary>
        /// Shows the Graphics window to enable interactions with it.
        /// </summary>
        public static void Show()
        {
            GraphicsWindow.Show();
        }

        /// <summary>Hides the Graphics window.</summary>
        public static void Hide()
        {
            GraphicsWindow.Hide();
        }

        /// <summary>
        /// Draws a rectangle on the screen using the selected Pen.
        /// </summary>
        /// <param name="x">The x co-ordinate of the rectangle.</param>
        /// <param name="y">The y co-ordinate of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public static void DrawRectangle(Primitive x, Primitive y, Primitive width, Primitive height)
        {
            GraphicsWindow.DrawRectangle(x, y, width, height);
        }

        /// <summary>
        /// Fills a rectangle on the screen using the selected Brush.
        /// </summary>
        /// <param name="x">The x co-ordinate of the rectangle.</param>
        /// <param name="y">The y co-ordinate of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public static void FillRectangle(Primitive x, Primitive y, Primitive width, Primitive height)
        {
            GraphicsWindow.FillRectangle(x, y, width, height);
        }

        /// <summary>
        /// Draws an ellipse on the screen using the selected Pen.
        /// </summary>
        /// <param name="x">The x co-ordinate of the ellipse.</param>
        /// <param name="y">The y co-ordinate of the ellipse.</param>
        /// <param name="width">The width of the ellipse.</param>
        /// <param name="height">The height of the ellipse.</param>
        public static void DrawEllipse(Primitive x, Primitive y, Primitive width, Primitive height)
        {
            GraphicsWindow.DrawEllipse(x, y, width, height);
        }

        /// <summary>
        /// Fills an ellipse on the screen using the selected Brush.
        /// </summary>
        /// <param name="x">The x co-ordinate of the ellipse.</param>
        /// <param name="y">The y co-ordinate of the ellipse.</param>
        /// <param name="width">The width of the ellipse.</param>
        /// <param name="height">The height of the ellipse.</param>
        public static void FillEllipse(Primitive x, Primitive y, Primitive width, Primitive height)
        {
            GraphicsWindow.FillEllipse(x, y, width, height);
        }

        /// <summary>
        /// Draws a triangle on the screen using the selected pen.
        /// </summary>
        /// <param name="x1">The x co-ordinate of the first point.</param>
        /// <param name="y1">The y co-ordinate of the first point.</param>
        /// <param name="x2">The x co-ordinate of the second point.</param>
        /// <param name="y2">The y co-ordinate of the second point.</param>
        /// <param name="x3">The x co-ordinate of the third point.</param>
        /// <param name="y3">The y co-ordinate of the third point.</param>
        public static void DrawTriangle(
          Primitive x1,
          Primitive y1,
          Primitive x2,
          Primitive y2,
          Primitive x3,
          Primitive y3)
        {
            GraphicsWindow.DrawTriangle(x1, y1, x2, y2, x3, y3);
        }

        /// <summary>
        /// Draws and fills a triangle on the screen using the selected brush.
        /// </summary>
        /// <param name="x1">The x co-ordinate of the first point.</param>
        /// <param name="y1">The y co-ordinate of the first point.</param>
        /// <param name="x2">The x co-ordinate of the second point.</param>
        /// <param name="y2">The y co-ordinate of the second point.</param>
        /// <param name="x3">The x co-ordinate of the third point.</param>
        /// <param name="y3">The y co-ordinate of the third point.</param>
        public static void FillTriangle(
          Primitive x1,
          Primitive y1,
          Primitive x2,
          Primitive y2,
          Primitive x3,
          Primitive y3)
        {
            GraphicsWindow.FillTriangle(x1, y1, x2, y2, x3, y3);
        }

        /// <summary>Draws a line from one point to another.</summary>
        /// <param name="x1">The x co-ordinate of the first point.</param>
        /// <param name="y1">The y co-ordinate of the first point.</param>
        /// <param name="x2">The x co-ordinate of the second point.</param>
        /// <param name="y2">The y co-ordinate of the second point.</param>
        public static void DrawLine(Primitive x1, Primitive y1, Primitive x2, Primitive y2)
        {
            GraphicsWindow.DrawLine(x1, y1, x2, y2);
        }

        /// <summary>
        /// Draws a line of text on the screen at the specified location.
        /// </summary>
        /// <param name="x">The x co-ordinate of the text start point.</param>
        /// <param name="y">The y co-ordinate of the text start point.</param>
        /// <param name="text">The text to draw</param>
        public static void DrawText(Primitive x, Primitive y, Primitive text)
        {
            GraphicsWindow.DrawText(x, y, text);
        }

        /// <summary>
        /// Draws a line of text on the screen at the specified location.
        /// </summary>
        /// <param name="x">The x co-ordinate of the text start point.</param>
        /// <param name="y">The y co-ordinate of the text start point.</param>
        /// <param name="width">
        /// The maximum available width.  This parameter helps define when the text should wrap.
        /// </param>
        /// <param name="text">The text to draw.</param>
        public static void DrawBoundText(Primitive x, Primitive y, Primitive width, Primitive text)
        {
            GraphicsWindow.DrawBoundText(x, y, width, text);
        }

        /// <summary>
        /// Draws the specified image from memory on to the screen, in the specified size.
        /// </summary>
        /// <param name="imageName">The name of the image to draw</param>
        /// <param name="x">
        /// The x co-ordinate of the point to draw the image at.
        /// </param>
        /// <param name="y">
        /// The y co-ordinate of the point to draw the image at.
        /// </param>
        /// <param name="width">The width to draw the image.</param>
        /// <param name="height">The height to draw the image.</param>
        public static void DrawResizedImage(
          Primitive imageName,
          Primitive x,
          Primitive y,
          Primitive width,
          Primitive height)
        {
            GraphicsWindow.DrawResizedImage(imageName, x, y, width, height);
        }

        /// <summary>
        /// Draws the specified image from memory on to the screen.
        /// </summary>
        /// <param name="imageName">The name of the image to draw.</param>
        /// <param name="x">
        /// The x co-ordinate of the point to draw the image at.
        /// </param>
        /// <param name="y">
        /// The y co-ordinate of the point to draw the image at.
        /// </param>
        public static void DrawImage(Primitive imageName, Primitive x, Primitive y)
        {
            GraphicsWindow.DrawImage(imageName, x, y);
        }

        /// <summary>
        /// Draws the pixel specified by the x and y co-ordinates using the specified color.
        /// </summary>
        /// <param name="x">The x co-ordinate of the pixel.</param>
        /// <param name="y">The y co-ordinate of the pixel.</param>
        /// <param name="color">The color of the pixel to set.</param>
        public static void SetPixel(Primitive x, Primitive y, Primitive color)
        {
            GraphicsWindow.SetPixel(x, y, color);
        }

        /// <summary>
        /// Gets the color of the pixel at the specified x and y co-ordinates.
        /// </summary>
        /// <param name="x">The x co-ordinate of the pixel.</param>
        /// <param name="y">The y co-ordinate of the pixel.</param>
        /// <returns>The color of the pixel.</returns>
        public static Primitive GetPixel(Primitive x, Primitive y)
        {
            return GraphicsWindow.GetPixel(x, y);
        }

        /// <summary>Gets a valid random color.</summary>
        /// <returns>A valid random color.</returns>
        public static Primitive GetRandomColor()
        {
            return GraphicsWindow.GetRandomColor();
        }

        /// <summary>
        /// Constructs a color given the Red, Green and Blue values.
        /// </summary>
        /// <param name="red">The red component of the Color (0-255).</param>
        /// <param name="green">The green component of the color (0-255).</param>
        /// <param name="blue">The blue component of the color (0-255).</param>
        /// <returns>
        /// Returns a color that can be used to set the brush or pen color.
        /// </returns>
        public static Primitive GetColorFromRGB(Primitive red, Primitive green, Primitive blue)
        {
            return GraphicsWindow.GetColorFromRGB(red, green, blue);
        }

        /// <summary>Clears the window.</summary>
        public static void Clear()
        {
            GraphicsWindow.Clear();
        }

        /// <summary>Displays a message box to the user.</summary>
        /// <param name="text">The text to be displayed on the message box.</param>
        /// <param name="title">The title for the message box.</param>
        public static void ShowMessage(Primitive text, Primitive title)
        {
            GraphicsWindow.ShowMessage(text, title);
        }

        /// <summary>
        /// Gets or sets the Background color of the Graphics Window.
        /// </summary>
        public static Primitive BackgroundColor
        {
            get
            {
                return GraphicsWindow.BackgroundColor;
            }
            set
            {
                GraphicsWindow.BackgroundColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the brush color to be used to fill shapes drawn on the Graphics Window.
        /// </summary>
        public static Primitive BrushColor
        {
            get
            {
                return GraphicsWindow.BrushColor;
            }
            set
            {
                GraphicsWindow.BrushColor = value;
            }
        }

        /// <summary>
        /// Specifies whether or not the Graphics Window can be resized by the user.
        /// </summary>
        public static Primitive CanResize
        {
            get
            {
                return GraphicsWindow.CanResize;
            }
            set
            {
                GraphicsWindow.CanResize = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the pen used to draw shapes on the Graphics Window.
        /// </summary>
        public static Primitive PenWidth
        {
            get
            {
                return GraphicsWindow.PenWidth;
            }
            set
            {
                GraphicsWindow.PenWidth = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the pen used to draw shapes on the Graphics Window.
        /// </summary>
        public static Primitive PenColor
        {
            get
            {
                return GraphicsWindow.PenColor;
            }
            set
            {
                GraphicsWindow.PenColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the Font Name to be used when drawing text on the Graphics Window.
        /// </summary>
        public static Primitive FontName
        {
            get
            {
                return GraphicsWindow.FontName;
            }
            set
            {
                GraphicsWindow.FontName = value;
            }
        }

        /// <summary>
        /// Gets or sets the Font Size to be used when drawing text on the Graphics Window.
        /// </summary>
        public static Primitive FontSize
        {
            get
            {
                return GraphicsWindow.FontSize;
            }
            set
            {
                GraphicsWindow.FontSize = value;
            }
        }

        /// <summary>
        /// Gets or sets whether or not the font to be used when drawing text on the Graphics Window, is bold.
        /// </summary>
        public static Primitive FontBold
        {
            get
            {
                return GraphicsWindow.FontBold;
            }
            set
            {
                GraphicsWindow.FontBold = value;
            }
        }

        /// <summary>
        /// Gets or sets whether or not the font to be used when drawing text on the Graphics Window, is italic.
        /// </summary>
        public static Primitive FontItalic
        {
            get
            {
                return GraphicsWindow.FontItalic;
            }
            set
            {
                GraphicsWindow.FontItalic = value;
            }
        }

        /// <summary>Gets or sets the title for the graphics window.</summary>
        public static Primitive Title
        {
            get
            {
                return GraphicsWindow.Title;
            }
            set
            {
                GraphicsWindow.Title = value;
            }
        }

        /// <summary>Gets or sets the Height of the graphics window.</summary>
        public static Primitive Height
        {
            get
            {
                return GraphicsWindow.Height;
            }
            set
            {
                GraphicsWindow.Height = value;
            }
        }

        /// <summary>Gets or sets the Width of the graphics window.</summary>
        public static Primitive Width
        {
            get
            {
                return GraphicsWindow.Width;
            }
            set
            {
                GraphicsWindow.Width = value;
            }
        }

        /// <summary>
        /// Gets or sets the Left Position of the graphics window.
        /// </summary>
        public static Primitive Left
        {
            get
            {
                return GraphicsWindow.Left;
            }
            set
            {
                GraphicsWindow.Left = value;
            }
        }

        /// <summary>Gets or sets the Top Position of the graphics window.</summary>
        public static Primitive Top
        {
            get
            {
                return GraphicsWindow.Top;
            }
            set
            {
                GraphicsWindow.Top = value;
            }
        }

        /// <summary>Gets the last key that was pressed or released.</summary>
        public static Primitive LastKey
        {
            get
            {
                return GraphicsWindow.LastKey;
            }
        }

        /// <summary>
        /// Gets the last text that was entered on the Graphics Window.
        /// </summary>
        public static Primitive LastText
        {
            get
            {
                return GraphicsWindow.LastText;
            }
        }

        /// <summary>
        /// Gets the x-position of the mouse relative to the Graphics Window.
        /// </summary>
        public static Primitive MouseX
        {
            get
            {
                return GraphicsWindow.MouseX;
            }
        }

        /// <summary>
        /// Gets the y-position of the mouse relative to the Graphics Window.
        /// </summary>
        public static Primitive MouseY
        {
            get
            {
                return GraphicsWindow.MouseY;
            }
        }

        /// <summary>
        /// Raises an event when a key is pressed down on the keyboard.
        /// </summary>
        public static event SBCallback KeyDown
        {
            add
            {
                GraphicsWindow.KeyDown += value;
            }
            remove
            {
                GraphicsWindow.KeyDown -= value;
            }
        }

        /// <summary>
        /// Raises an event when a key is released on the keyboard.
        /// </summary>
        public static event SBCallback KeyUp
        {
            add
            {
                GraphicsWindow.KeyUp += value;
            }
            remove
            {
                GraphicsWindow.KeyUp -= value;
            }
        }

        /// <summary>
        /// Raises an event when the mouse button is clicked down.
        /// </summary>
        public static event SBCallback MouseDown
        {
            add
            {
                GraphicsWindow.MouseDown += value;
            }
            remove
            {
                GraphicsWindow.MouseDown -= value;
            }
        }

        /// <summary>Raises an event when the mouse button is released.</summary>
        public static event SBCallback MouseUp
        {
            add
            {
                GraphicsWindow.MouseUp += value;
            }
            remove
            {
                GraphicsWindow.MouseUp -= value;
            }
        }

        /// <summary>Raises an event when the mouse is moved around.</summary>
        public static event SBCallback MouseMove
        {
            add
            {
                GraphicsWindow.MouseMove += value;
            }
            remove
            {
                GraphicsWindow.MouseMove -= value;
            }
        }

        /// <summary>
        /// Raises an event when text is entered on the GraphicsWindow.
        /// </summary>
        public static event SBCallback TextInput
        {
            add
            {
                GraphicsWindow.TextInput += value;
            }
            remove
            {
                GraphicsWindow.TextInput -= value;
            }
        }
    }
#endif
}