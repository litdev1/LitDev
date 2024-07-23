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
using System.Collections.Generic;
using System.Reflection;

namespace LitDev
{
    /// <summary>
    /// Sort arrays (the sorting of character strings may be case sensitive or insensitive).
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDSort
    {
        private static bool bNumber = true;
        public static bool bCaseSensitive = true;

        class pair : IComparable
        {
            public string key;
            public string value;
            public pair(string _key, string _value)
            {
                key = _key;
                value = _value;
                if (bNumber)
                {
                    try
                    {
                        Utilities.getDouble(_value);
                    }
                    catch
                    {
                        bNumber = false;
                    }
                }
            }

            int IComparable.CompareTo(object obj)
            {
                if (bNumber)
                {
                    return Utilities.getDouble(value).CompareTo(Utilities.getDouble(((pair)obj).value));
                }
                else
                {
                    return string.Compare(value, ((pair)obj).value, !bCaseSensitive);
                }
            }
        }

        private static List<pair> sort(Primitive array)
        {
            bNumber = true;
            List<pair> values = new List<pair>();
            Type PrimitiveType = typeof(Primitive);
            Dictionary<Primitive, Primitive> _arrayMap;
            array = Utilities.CreateArrayMap(array);
            _arrayMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(array);
            foreach (KeyValuePair<Primitive, Primitive> kvp in _arrayMap)
            {
                pair _pair = new pair(kvp.Key, kvp.Value);
                values.Add(_pair);
            }
            values.Sort();
            return values;
        }

        /// <summary>
        /// String comparisons are case sensitive "True" or "False".
        /// </summary>
        public static Primitive CaseSensitive
        {
            get { return bCaseSensitive.ToString(); }
            set { bCaseSensitive = value; }
        }

        /// <summary>
        /// Sort an array of any dimension by the index (key).
        /// </summary>
        /// <param name="array">
        /// The array to sort.
        /// </param>
        /// <returns>
        /// A sorted array.
        /// </returns>
        public static Primitive ByIndex(Primitive array)
        {
            try
            {
                List<pair> _keys = sort(SBArray.GetAllIndices(array));

                Dictionary<Primitive, Primitive> dictionary = new Dictionary<Primitive, Primitive>();
                foreach (pair _pair in _keys)
                {
                    dictionary.Add(_pair.value, array[_pair.value]);
                }

                _keys.Clear();
                return Primitive.ConvertFromMap(dictionary);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Sort a 1D array by the value (the indices are re-numbered from 1).
        /// </summary>
        /// <param name="array">
        /// The array to sort.
        /// </param>
        /// <returns>
        /// A sorted array.
        /// </returns>
        public static Primitive ByValue(Primitive array)
        {
            try
            {
                List<pair> _keys = sort(array);

                Dictionary<Primitive, Primitive> dictionary = new Dictionary<Primitive, Primitive>();
                int i = 1;
                foreach (pair _pair in _keys)
                {
                    dictionary.Add(i++, _pair.value);
                }

                _keys.Clear();
                return Primitive.ConvertFromMap(dictionary);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Sort a 1D array by the value (the indices are unchanged, but sorted).
        /// </summary>
        /// <param name="array">
        /// The array to sort.
        /// </param>
        /// <returns>
        /// A sorted array.
        /// </returns>
        public static Primitive ByValueWithIndex(Primitive array)
        {
            try
            {
                List<pair> _keys = sort(array);

                Dictionary<Primitive, Primitive> dictionary = new Dictionary<Primitive, Primitive>();
                foreach (pair _pair in _keys)
                {
                    dictionary.Add(_pair.key, _pair.value);
                }

                _keys.Clear();
                return Primitive.ConvertFromMap(dictionary);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }
    }
}
