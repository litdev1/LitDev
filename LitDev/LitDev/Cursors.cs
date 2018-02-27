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

using LitDev.Engines;
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace LitDev
{
    /// <summary>
    /// Sets the GraphicsWindow Cursor.
    /// </summary>
    [SmallBasicType]
    public static class LDCursors
    {
        private static Dictionary<string, Cursor> cursors = new Dictionary<string, Cursor>();

        private static Cursor createCursor(Bitmap bmp, int xHotSpot, int yHotSpot)
        {
            User32.IconInfo iconInfo = new User32.IconInfo();
            User32.GetIconInfo(bmp.GetHicon(), ref iconInfo);
            iconInfo.xHotspot = xHotSpot;
            iconInfo.yHotspot = yHotSpot;
            iconInfo.fIcon = false;
            SafeIconHandle cursorHandle = User32.CreateIconIndirect(ref iconInfo);
            return CursorInteropHelper.Create(cursorHandle);
        }

        private static void setCursor(Cursor cursor)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("SetCursor", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { cursor });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static void setCursor(string shapeName, Cursor cursor)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        ((FrameworkElement)obj).Cursor = cursor;
                    });
                    FastThread.Invoke(ret);
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static Cursor getCursor(string cursor)
        {
            Cursor _cursor = null;
            try
            {
                if (!cursors.TryGetValue(cursor, out _cursor))
                {
                    switch (((string)cursor).ToLower())
                    {
                        case "none":
                            _cursor = Cursors.None;
                            break;
                        case "arrow":
                            _cursor = Cursors.Arrow;
                            break;
                        case "cross":
                            _cursor = Cursors.Cross;
                            break;
                        case "hand":
                            _cursor = Cursors.Hand;
                            break;
                        case "help":
                            _cursor = Cursors.Help;
                            break;
                        case "ibeam":
                            _cursor = Cursors.IBeam;
                            break;
                        case "wait":
                            _cursor = Cursors.Wait;
                            break;
                        case "pen":
                            _cursor = Cursors.Pen;
                            break;
                        case "invalid":
                            _cursor = Cursors.No;
                            break;
                        case "starting":
                            _cursor = Cursors.AppStarting;
                            break;
                        case "scroll":
                            _cursor = Cursors.ScrollAll;
                            break;
                        case "arrowcd":
                            _cursor = Cursors.ArrowCD;
                            break;
                        case "uparrow":
                            _cursor = Cursors.UpArrow;
                            break;
                        case "sizeall":
                            _cursor = Cursors.SizeAll;
                            break;
                        case "sizenesw":
                            _cursor = Cursors.SizeNESW;
                            break;
                        case "sizenwse":
                            _cursor = Cursors.SizeNWSE;
                            break;
                        case "sizens":
                            _cursor = Cursors.SizeNS;
                            break;
                        case "sizewe":
                            _cursor = Cursors.SizeWE;
                            break;
                        default:
                            _cursor = new Cursor(cursor);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return _cursor;
        }

        /// <summary>
        /// Create a cursor that can be set using SetUserCursor or SetShapeCursor.
        /// An ImageList image can be resized with LDImage.Resize.
        /// </summary>
        /// <param name="imageName">The file path or ImageList image.</param>
        /// <param name="xHotSpot">The x pixel to use as the hot spot, indexed from 0.</param>
        /// <param name="yHotSpot">The y pixel to use as the hot spot, indexed from 0.</param>
        /// <returns>A cursor.</returns>
        public static Primitive CreateCursor(Primitive imageName, Primitive xHotSpot, Primitive yHotSpot)
        {
            Type ShapesType = typeof(Shapes);
            Type ImageListType = typeof(ImageList);
            Dictionary<string, BitmapSource> _savedImages;
            BitmapSource img;
            string cursorName = "";

            try
            {
                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_savedImages.TryGetValue((string)imageName, out img))
                {
                    imageName = ImageList.LoadImage(imageName);
                    if (!_savedImages.TryGetValue((string)imageName, out img))
                    {
                        return cursorName;
                    }
                }

                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                cursorName = method.Invoke(null, new object[] { "Cursor" }).ToString();

                Bitmap bmp = FastPixel.GetBitmap(img);
                Cursor cursor = createCursor(bmp, xHotSpot, yHotSpot);
                cursors[cursorName] = cursor;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return cursorName;
        }

        /// <summary>
        /// Sets a custom cursor as a pointer in the Graphics Window.
        /// </summary>
        /// <param name="cursor">A cursor created with CreateCursor or
        /// a standard cursor in this object (e.g. "ArrowCD") or 
        /// the full path to a *.cur or *.ani file to use as a cursor.</param>
        public static void SetUserCursor(Primitive cursor)
        {
            try
            {
                Cursor _cursor = getCursor(cursor);
                if (null != _cursor) setCursor(_cursor);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set the cursor for a shape or control when the mouse is over the shape.
        /// </summary>
        /// <param name="shapeName">The shape or control name.</param>
        /// <param name="cursor">A cursor created with CreateCursor or
        /// a standard cursor in this object (e.g. "ArrowCD") or 
        /// the full path to a *.cur or *.ani file to use as a cursor.</param>
        public static void SetShapeCursor(Primitive shapeName, Primitive cursor)
        {
            try
            {

                Cursor _cursor = getCursor(cursor);
                if (null != _cursor) setCursor(shapeName, _cursor);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// No Cursor.
        /// </summary>
        public static void None()
        {
            setCursor(Cursors.None);
        }

        /// <summary>
        /// Arrow Cursor (default).
        /// </summary>
        public static void Arrow()
        {
            setCursor(Cursors.Arrow);
        }

        /// <summary>
        /// Cross Cursor.
        /// </summary>
        public static void Cross()
        {
            setCursor(Cursors.Cross);
        }

        /// <summary>
        /// Hand Cursor.
        /// </summary>
        public static void Hand()
        {
            setCursor(Cursors.Hand);
        }

        /// <summary>
        /// Help Cursor.
        /// </summary>
        public static void Help()
        {
            setCursor(Cursors.Help);
        }

        /// <summary>
        /// IBeam Cursor.
        /// </summary>
        public static void IBeam()
        {
            setCursor(Cursors.IBeam);
        }

        /// <summary>
        /// Wait Cursor.
        /// </summary>
        public static void Wait()
        {
            setCursor(Cursors.Wait);
        }

        /// <summary>
        /// Pen Cursor.
        /// </summary>
        public static void Pen()
        {
            setCursor(Cursors.Pen);
        }

        /// <summary>
        /// Invalid Cursor.
        /// </summary>
        public static void Invalid()
        {
            setCursor(Cursors.No);
        }

        /// <summary>
        /// Starting Cursor.
        /// </summary>
        public static void Starting()
        {
            setCursor(Cursors.AppStarting);
        }

        /// <summary>
        /// Scroll Cursor.
        /// </summary>
        public static void Scroll()
        {
            setCursor(Cursors.ScrollAll);
        }

        /// <summary>Arrow with CD Cursor.</summary>
        public static void ArrowCD()
        {
            setCursor(Cursors.ArrowCD);
        }

        /// <summary>Up Arrow Cursor (Insertion).</summary>
        public static void UpArrow()
        {
            setCursor(Cursors.UpArrow);
        }

        /// <summary>Size All Cursor (Resizing).</summary>
        public static void SizeAll()
        {
            setCursor(Cursors.SizeAll);
        }

        /// <summary>NESW DoubleArrow Cursor (Resizing).</summary>
        public static void SizeNESW()
        {
            setCursor(Cursors.SizeNESW);
        }

        /// <summary>NWSE DoubleArrow Cursor (Resizing).</summary>
        public static void SizeNWSE()
        {
            setCursor(Cursors.SizeNWSE);
        }

        /// <summary>NS DoubleArrow (Resizing).</summary>
        public static void SizeNS()
        {
            setCursor(Cursors.SizeNS);
        }

        /// <summary>WE DoubleArrow (Resizing).</summary>
        public static void SizeWE()
        {
            setCursor(Cursors.SizeWE);
        }
    }
}
