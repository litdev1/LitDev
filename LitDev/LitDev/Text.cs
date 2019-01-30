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
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using SBArray = Microsoft.SmallBasic.Library.Array;

namespace LitDev
{
    /// <summary>
    /// Text manipulations.
    /// </summary>
    [SmallBasicType]
    public static class LDText
    {
        /// <summary>
        /// Split a variable into an array delimiated by a separator.
        /// </summary>
        /// <param name="text">A text string to split.</param>
        /// <param name="separator">A separator string (e.g. " "), or an array of separator strings.</param>
        /// <returns>A result array of deliminated texts.</returns>
        public static Primitive Split(Primitive text, Primitive separator)
        {
            try
            {
                string[] separators;
                if (SBArray.IsArray(separator))
                {
                    int count = SBArray.GetItemCount(separator);
                    separators = new string[count];
                    Primitive indices = SBArray.GetAllIndices(separator);
                    for (int i = 0; i < count; i++)
                    {
                        separators[i] = separator[indices[i + 1]];
                    }
                }
                else
                {
                    separators = new string[] {separator};
                }
                string[] splitText = ((string)text).Split(separators, System.StringSplitOptions.RemoveEmptyEntries);
                return Utilities.CreateArrayMap(splitText.ToPrimitiveArray());
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Lexically compare 2 text strings, the comparison is case insensitive and culture invariant.
        /// </summary>
        /// <param name="text1">The first string to compare.</param>
        /// <param name="text2">The second string to compare.</param>
        /// <returns>An integer:
        /// less than zero (text1 is less than text2)
        /// zero (strings are equal)
        /// greater than zero (text1 is greater than text2)</returns>
        public static Primitive Compare(Primitive text1, Primitive text2)
        {
            try
            {
                return string.Compare(text1, text2, true, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Return a string with all leading and trailing 'white space' removed.
        /// </summary>
        /// <param name="text">A string to trim.</param>
        /// <returns>A trimmed copy of the input string.</returns>
        public static Primitive Trim(Primitive text)
        {
            try
            {
                return ((string)text).Trim();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Find and Replace all occurances of one text with another.
        /// </summary>
        /// <param name="text">A text to modify.</param>
        /// <param name="find">The text to find and replace.</param>
        /// <param name="replace">The text to replace the found text.</param>
        /// <returns>A modified copy of the input text.</returns>
        public static Primitive Replace(Primitive text, Primitive find, Primitive replace)
        {
            try
            {
                return ((string)text).Replace(find, replace);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get all occurances of a subtext in some text.
        /// </summary>
        /// <param name="text">The text to search.</param>
        /// <param name="find">The subtext to search for.</param>
        /// <returns>An array with the positions of the start of each subtext or 0 for none.</returns>
        public static Primitive FindAll(Primitive text, Primitive find)
        {
            try
            {
                string input = (string)text;
                string result = "";
                int pos = input.IndexOf(find, 0);
                if (pos < 0) return 0;
                int i = 0;
                while (pos >= 0)
                {
                    result += (++i).ToString() + "=" + (pos + 1) + ";";
                    pos = input.IndexOf(find, pos + 1);
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Get the width in pixels that text will be displayed in the GraphicsWindow with the current font.
        /// The GraphicsWindow must be open to use this method.
        /// </summary>
        /// <param name="text">The text to get the width.</param>
        /// <returns>The width in pixels.</returns>
        public static Primitive GetWidth(Primitive text)
        {
            try
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                FontFamily _fontFamily = (FontFamily)GraphicsWindowType.GetField("_fontFamily", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                double _fontSize = (double)GraphicsWindowType.GetField("_fontSize", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                FontWeight _fontWeight = (FontWeight)GraphicsWindowType.GetField("_fontWeight", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                FontStyle _fontStyle = (FontStyle)GraphicsWindowType.GetField("_fontStyle", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        TextBlock textblock = new TextBlock
                        {
                            Text = text,
                            FontFamily = _fontFamily,
                            FontSize = _fontSize,
                            FontWeight = _fontWeight,
                            FontStyle = _fontStyle
                        };
                        Size size = new Size(double.MaxValue, double.MaxValue);
                        textblock.Measure(size);
                        return textblock.DesiredSize.Width.ToString(CultureInfo.InvariantCulture);
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return "";
                });
                return FastThread.InvokeWithReturn(ret).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Get the height in pixels that text will be displayed in the GraphicsWindow with the current font.
        /// The GraphicsWindow must be open to use this method.
        /// </summary>
        /// <param name="text">The text to get the height.</param>
        /// <returns>The width in pixels.</returns>
        public static Primitive GetHeight(Primitive text)
        {
            try
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                FontFamily _fontFamily = (FontFamily)GraphicsWindowType.GetField("_fontFamily", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                double _fontSize = (double)GraphicsWindowType.GetField("_fontSize", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                FontWeight _fontWeight = (FontWeight)GraphicsWindowType.GetField("_fontWeight", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                FontStyle _fontStyle = (FontStyle)GraphicsWindowType.GetField("_fontStyle", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        TextBlock textblock = new TextBlock
                        {
                            Text = text,
                            FontFamily = _fontFamily,
                            FontSize = _fontSize,
                            FontWeight = _fontWeight,
                            FontStyle = _fontStyle
                        };
                        Size size = new Size(double.MaxValue, double.MaxValue);
                        textblock.Measure(size);
                        return textblock.DesiredSize.Height.ToString(CultureInfo.InvariantCulture);
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return "";
                });
                return FastThread.InvokeWithReturn(ret).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        private static int iFastString = 0;
        private static StringBuilder sb;
        private static Dictionary<string, StringBuilder> FastStrings = new Dictionary<string, StringBuilder>();

        /// <summary>
        /// Create a new fast string appending object.
        /// </summary>
        /// <returns>The fast string append object.</returns>
        public static Primitive FastStringNew()
        {
            string fastString = "FastString" + (++iFastString).ToString();
            FastStrings.Add(fastString, new StringBuilder());
            return fastString;
        }

        /// <summary>
        /// Reset a fast string object to "".
        /// </summary>
        /// <param name="fastString">A fast string object.</param>
        public static void FastStringClear(Primitive fastString)
        {
            if (FastStrings.TryGetValue(fastString, out sb)) sb.Clear();
        }

        /// <summary>
        /// Append a string value to a fast string object.
        /// </summary>
        /// <param name="fastString">A fast string object.</param>
        /// <param name="text">The test to append.</param>
        public static void FastStringAppend(Primitive fastString, Primitive text)
        {
            if (FastStrings.TryGetValue(fastString, out sb)) sb.Append(text.ToString());
        }

        /// <summary>
        /// Get the current text in a fast string.
        /// </summary>
        /// <param name="fastString">A fast string object.</param>
        /// <returns>The current fast string text.</returns>
        public static Primitive FastStringGet(Primitive fastString)
        {
            if (FastStrings.TryGetValue(fastString, out sb)) return sb.ToString();
            return "";
        }
    }
}
