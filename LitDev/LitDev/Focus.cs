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
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LitDev
{
    /// <summary>
    /// TextBoxFocus utility to control focus (textbox currently active for input).
    /// </summary>
    [SmallBasicType]
    public static class LDFocus
    {
        /// <summary>
        /// Checks if the named shape has the focus.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name (usually a textbox).
        /// </param>
        /// <returns>
        /// "True" or "False".
        /// </returns>
        public static Primitive IsFocus(Primitive shapeName)
        {

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "False";
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate { return obj.IsFocused; });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "False";
            }
        }

        /// <summary>
        /// Sets the named shape to have focus.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name (usually a textbox).
        /// </param>
        /// <returns>
        /// "True" or "False" depending on success or failure.
        /// </returns>
        public static Primitive SetFocus(Primitive shapeName)
        {

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "False";
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate { return obj.Focus(); });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "False";
            }
        }

        /// <summary>
        /// Gets the shape that has current focus.
        /// </summary>
        /// <returns>
        /// The shape name (usually a textbox) or "False".
        /// </returns>
        public static Primitive GetFocus()
        {

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            Canvas _mainCanvas;
            string shapeName;

            try
            {
                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                foreach (KeyValuePair<String, UIElement> entry in _objectsMap)
                {
                    shapeName = entry.Key;
                    if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                    {
                        Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                        return "False";
                    }

                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        return _mainCanvas.Children.Contains(obj) && obj.IsFocused;
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    if (method.Invoke(null, new object[] { ret }).ToString() == "True")
                    {
                        return shapeName;
                    }
                }
                return "False";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "False";
            }
        }
    }
}
