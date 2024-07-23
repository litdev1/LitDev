﻿//#define SVB
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

using LitDev.Engines;
using System;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LitDev
{
    /// <summary>
    /// GraphicsWindow ScrollBars - can be used for a scrolling game.
    /// 
    /// Warning - Do not alter the GraphicsWindow size using GraphicsWindow.Width or GraphicsWindow.Height AFTER scrollbars have been added.
    /// In this case use LDGraphicsWindow.Width and LDGraphicsWindow.Height.
    /// 
    /// For large scrolling regions see Rasterize property.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDScrollBars
    {
        private static bool rasterize = true;
        private static bool bKeyScroll = true;
        private static bool bMouseScroll = true;

        private static SBCallback _ScrollChangedDelegate = null;
        private static void _ScrollChangedEvent(Object sender, ScrollChangedEventArgs e)
        {
            if (null != _ScrollChangedDelegate) _ScrollChangedDelegate();
        }

        private static void _WindowSizeChanged(Object sender, SizeChangedEventArgs e)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);

            try
            {
                RenderTargetBitmap _renderBitmap = (RenderTargetBitmap)GraphicsWindowType.GetField("_renderBitmap", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                if (e.NewSize.Width > _renderBitmap.Width || e.NewSize.Height > _renderBitmap.Height)
                {
                    Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                    Image _bitmapContainer = (Image)GraphicsWindowType.GetField("_bitmapContainer", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                    InvokeHelper ret = delegate
                    {
                        try
                        {
                            Object content = _window.Content;
                            ScrollViewer scrollViewer = (ScrollViewer)content;
                            Grid grid = (Grid)(scrollViewer.Content);

                            double width = System.Math.Max(e.NewSize.Width, grid.Width);
                            double height = System.Math.Max(e.NewSize.Height, grid.Height);

                            DrawingVisual drawingVisual = new DrawingVisual();
                            DrawingContext drawingContext = drawingVisual.RenderOpen();
                            drawingContext.DrawImage(_renderBitmap, new Rect(0.0, 0.0, _renderBitmap.Width, _renderBitmap.Height));
                            drawingContext.Close();

                            RenderTargetBitmap _renderBitmapNew = new RenderTargetBitmap((int)width + 120, (int)height + 120, 96.0, 96.0, PixelFormats.Default);
                            _renderBitmapNew.Render(drawingVisual);

                            GraphicsWindowType.GetField("_renderBitmap", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, _renderBitmapNew);
                            _bitmapContainer.Width = _renderBitmapNew.Width;
                            _bitmapContainer.Height = _renderBitmapNew.Height;
                            _bitmapContainer.Source = _renderBitmapNew;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    };
                    FastThread.Invoke(ret);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        // We need to call this delegate since MouseDown is not propagated to Window
        private static void _MouseDownEvent(object sender, MouseButtonEventArgs e)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            SBCallback callback = (SBCallback)GraphicsWindowType.GetField("_mouseDown", BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static).GetValue(null);
            if (null != callback) callback();
            e.Handled = true;
        }

        private static void _MouseUpEvent(object sender, MouseButtonEventArgs e)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            SBCallback callback = (SBCallback)GraphicsWindowType.GetField("_mouseUp", BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static).GetValue(null);
            if (null != callback) callback();
            e.Handled = true;
        }

        private static void _MouseMoveEvent(object sender, MouseEventArgs e)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            SBCallback callback = (SBCallback)GraphicsWindowType.GetField("_mouseMove", BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static).GetValue(null);
            if (null != callback) callback();
            e.Handled = true;
        }

        private static void _KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up || e.Key == Key.Down || e.Key == Key.Left || e.Key == Key.Right)
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                GraphicsWindowType.GetField("_lastKey", BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static).SetValue(null, e.Key);
                SBCallback callback = (SBCallback)GraphicsWindowType.GetField("_keyDown", BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static).GetValue(null);
                if (null != callback) callback();
                e.Handled = !bKeyScroll;
            }
        }

        private static void _KeyUpEvent(object sender, KeyEventArgs e)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            SBCallback callback = (SBCallback)GraphicsWindowType.GetField("_keyUp", BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static).GetValue(null);
            if (null != callback) callback();
            e.Handled = true;
        }

        private static void _TextInputEvent(object sender, TextCompositionEventArgs e)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            SBCallback callback = (SBCallback)GraphicsWindowType.GetField("_textInput", BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static).GetValue(null);
            if (null != callback) callback();
            e.Handled = true;
        }

        private static void _MouseWheelEvent(object sender, MouseWheelEventArgs e)
        {
            LDEvents._MouseWheelEvent(sender, e);
            if (bMouseScroll && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
            {
                //ScrollViewer scrollviewer = (ScrollViewer)((Grid)sender).Parent;
                HorizontalScroll += e.Delta;
                e.Handled = true;
            }
            else e.Handled = !bMouseScroll;
        }

        private static void setScrollBars(double width, double height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);

            try
            {
                Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                Canvas _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                RenderTargetBitmap _renderBitmap = (RenderTargetBitmap)GraphicsWindowType.GetField("_renderBitmap", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                DrawingGroup _mainDrawing = (DrawingGroup)GraphicsWindowType.GetField("_mainDrawing", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                InvokeHelper ret = delegate
                {
                    try
                    {
                        Object content = _window.Content;
                        ScrollViewer scrollViewer;
                        if (content.GetType() == typeof(ScrollViewer))
                        {
                            scrollViewer = (ScrollViewer)content;
                        }
                        else
                        {
                            scrollViewer = new ScrollViewer();
                            _window.Content = null;
                            scrollViewer.Content = content;
                            scrollViewer.ScrollChanged += new ScrollChangedEventHandler(_ScrollChangedEvent);
                            _window.Content = scrollViewer;

                            //Replace SB Window SizeChanged event
                            EventInfo eventInfo = _window.GetType().GetEvent("SizeChanged", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                            Delegate methodDelegate = Delegate.CreateDelegate(eventInfo.EventHandlerType, GraphicsWindowType, "WindowSizeChanged");
                            eventInfo.RemoveEventHandler(_window, methodDelegate);
                            _window.SizeChanged += new SizeChangedEventHandler(_WindowSizeChanged);
                        }
                        scrollViewer.HorizontalScrollBarVisibility = width > 0 ? ScrollBarVisibility.Auto : ScrollBarVisibility.Hidden;
                        scrollViewer.VerticalScrollBarVisibility = height > 0 ? ScrollBarVisibility.Auto : ScrollBarVisibility.Hidden;
                        width = System.Math.Max(width, _mainCanvas.ActualWidth);
                        height = System.Math.Max(height, _mainCanvas.ActualHeight);

                        Grid grid = (Grid)(scrollViewer.Content);
                        grid.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                        grid.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                        grid.Width = width;
                        grid.Height = height;

                        //These GraphicsWindow events fail with scrollbars so have to add new ones
                        grid.MouseDown += new System.Windows.Input.MouseButtonEventHandler(_MouseDownEvent);
                        //grid.MouseUp += new System.Windows.Input.MouseButtonEventHandler(_MouseUpEvent);
                        //grid.MouseMove += new System.Windows.Input.MouseEventHandler(_MouseMoveEvent);
                        grid.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(_MouseWheelEvent);
                        scrollViewer.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(_KeyDownEvent);
                        //grid.KeyUp += new System.Windows.Input.KeyEventHandler(_KeyUpEvent);
                        //grid.TextInput += new System.Windows.Input.TextCompositionEventHandler(_TextInputEvent);

                        Image _bitmapContainer = (Image)grid.Children[0];
                        _bitmapContainer.HorizontalAlignment = HorizontalAlignment.Left;
                        _bitmapContainer.VerticalAlignment = VerticalAlignment.Top;
                        _bitmapContainer.Width = width;
                        _bitmapContainer.Height = height;

                        FrameworkElement _visualContainer = (FrameworkElement)grid.Children[1];
                        _visualContainer.HorizontalAlignment = HorizontalAlignment.Left;
                        _visualContainer.VerticalAlignment = VerticalAlignment.Top;
                        _visualContainer.Width = width;
                        _visualContainer.Height = height;

                        if (rasterize)
                        {
                            //GraphicsWindowType.GetMethod("Rasterize", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).Invoke(null, new object[] { });

                            DrawingVisual drawingVisual = new DrawingVisual();
                            DrawingContext drawingContext = drawingVisual.RenderOpen();
                            drawingContext.DrawImage(_renderBitmap, new Rect(0.0, 0.0, _renderBitmap.Width, _renderBitmap.Height));
                            drawingContext.Close();

                            RenderTargetBitmap _renderBitmapNew = new RenderTargetBitmap((int)width + 120, (int)height + 120, 96.0, 96.0, PixelFormats.Default);
                            _renderBitmapNew.Render(drawingVisual);

                            GraphicsWindowType.GetField("_renderBitmap", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, _renderBitmapNew);
                            _bitmapContainer.Source = _renderBitmapNew;
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

        private static void modifyScrollBars(string action)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);

            try
            {
                Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                InvokeHelper ret = delegate
                {
                    try
                    {
                        Object content = _window.Content;
                        if (content.GetType() != typeof(ScrollViewer)) return;
                        ScrollViewer scrollViewer = (ScrollViewer)content;

                        switch (action.ToLower())
                        {
                            case "pagedown":
                                scrollViewer.PageDown();
                                break;
                            case "pageup":
                                scrollViewer.PageUp();
                                break;
                            case "pageleft":
                                scrollViewer.PageLeft();
                                break;
                            case "pageright":
                                scrollViewer.PageRight();
                                break;
                            case "scrolltotop":
                                scrollViewer.ScrollToTop();
                                break;
                            case "scrolltobottom":
                                scrollViewer.ScrollToBottom();
                                break;
                            case "scrolltoleftend":
                                scrollViewer.ScrollToLeftEnd();
                                break;
                            case "scrolltorightend":
                                scrollViewer.ScrollToRightEnd();
                                break;
                            case "scrolltohome":
                                scrollViewer.ScrollToHome();
                                break;
                            case "scrolltoend":
                                scrollViewer.ScrollToEnd();
                                break;
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

        private static Primitive propertyScrollBars(string action, Primitive value)
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
                        if (content.GetType() != typeof(ScrollViewer)) return "";
                        ScrollViewer scrollViewer = (ScrollViewer)content;

                        switch (action.ToLower())
                        {
                            case "gethorizontaloffset":
                                return scrollViewer.HorizontalOffset.ToString(CultureInfo.InvariantCulture);
                            case "sethorizontaloffset":
                                scrollViewer.ScrollToHorizontalOffset(value);
                                break;
                            case "getverticaloffset":
                                return scrollViewer.VerticalOffset.ToString(CultureInfo.InvariantCulture);
                            case "setverticaloffset":
                                scrollViewer.ScrollToVerticalOffset(value);
                                break;
                            case "getvisibility":
                                return scrollViewer.VerticalScrollBarVisibility == ScrollBarVisibility.Auto;
                            case "setvisibility":
                                scrollViewer.VerticalScrollBarVisibility = value ? ScrollBarVisibility.Auto : ScrollBarVisibility.Hidden;
                                scrollViewer.HorizontalScrollBarVisibility = scrollViewer.VerticalScrollBarVisibility;
                                break;
                            case "getpanningratio":
                                return scrollViewer.PanningRatio.ToString(CultureInfo.InvariantCulture);
                            case "setpanningratio":
                                scrollViewer.PanningRatio = value;
                                break;
                        }

                        return "";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                return FastThread.InvokeWithReturn(ret).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set if scrollbars will move with arrow keys "True" (default) or "False".
        /// </summary>
        public static Primitive KeyScroll
        {
            get { return bKeyScroll ? "True" : "False"; }
            set { bKeyScroll = value; }
        }

        /// <summary>
        /// Set if scrollbars will move with mouse wheel "True" (default) or "False".
        /// Hold the shift key down to scroll horizontally with mouse wheel.
        /// </summary>
        public static Primitive MouseScroll
        {
            get { return bMouseScroll ? "True" : "False"; }
            set { bMouseScroll = value; }
        }

        /// <summary>
        /// Add Scroll Bars to the GraphicsWindow.
        /// The input width and height are those that can be scrolled to.
        /// A value of 0 prevents a scrollbar appearing.
        /// </summary>
        /// <param name="width">The width of the scrollable region.</param>
        /// <param name="height">The height of the scrollable region.</param>
        public static void Add(Primitive width, Primitive height)
        {
            setScrollBars(width, height);
        }

        /// <summary>
        /// Move scrollbars.
        /// </summary>
        /// <param name="action">Allowed actions include the following.
        /// "PageDown", "PageUp", "PageLeft" and "PageRight"
        /// "ScrollToTop", "ScrollToBottom", "ScrollToLeftEnd" and "ScrollToRightEnd"
        /// "ScrollToHome", "ScrollToEnd"
        /// </param>
        public static void Modify(Primitive action)
        {
            modifyScrollBars(action);
        }

        /// <summary>
        /// Get or Set the horizontal ScrollBar position.
        /// </summary>
        public static Primitive HorizontalScroll
        {
            get { return propertyScrollBars("GetHorizontalOffset", 0); }
            set { propertyScrollBars("SetHorizontalOffset", value); }
        }

        /// <summary>
        /// Get or Set the vertical ScrollBar position.
        /// </summary>
        public static Primitive VerticalScroll
        {
            get { return propertyScrollBars("GetVerticalOffset", 0); }
            set { propertyScrollBars("SetVerticalOffset", value); }
        }

        /// <summary>
        /// Event when a scroll operation occurs
        /// </summary>
        public static event SBCallback ScrollBarChanged
        {
            add
            {
                _ScrollChangedDelegate = value;
            }
            remove
            {
                _ScrollChangedDelegate = null;
            }
        }

        /// <summary>
        /// Get or Set the ScrollBars' visibility.
        /// "True" or "False".
        /// </summary>
        public static Primitive Visibility
        {
            get { return propertyScrollBars("GetVisibility", 0); }
            set { propertyScrollBars("SetVisibility", value); }
        }

        // Get or Set the ScrollBars' panning ratio (default 1).
        // This is the ratio of scolling to view movement.
        public static Primitive PanningRatio
        {
            get { return propertyScrollBars("GetPanningRatio", 1); }
            set { propertyScrollBars("SetPanningRatio", value); }
        }

        /// <summary>
        /// Rasterize drawables "True" (default) or "False".
        /// When more than 100 objects are drawn (not Shapes) SmallBasic will rasterise these to an image for performance reasons.
        /// For a very large scrollable region this will run out of memory and can be disabled here.
        /// If it is disabled, then don't use more than 100 drawable objects.
        /// This property should be set before LDScrollBars.Add is called.
        /// </summary>
        public static Primitive Rasterize
        {
            get { return rasterize; }
            set { rasterize = value; }
        }
    }
}
