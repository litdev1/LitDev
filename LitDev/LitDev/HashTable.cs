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
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Text;

namespace LitDev
{
    /// <summary>
    /// The hashtable provides a fast and efficient way of storing key-value pairs.
    /// Dictionaries have a O(1) scaling and as data size increases the efficiency.
    /// Code by Abhishek Sathiabalan.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDHashTable
    {
        static LDHashTable()
        {
            Instance.Verify();
        }

        public static Dictionary<string, Dictionary<Primitive, Primitive>> map 
            = new Dictionary<string, Dictionary<Primitive, Primitive>>();

        /// <summary>
        /// Adds a key-value pair to a specified dictionary
        /// </summary>
        /// <param name="dictionary">The name of the dictionary</param>
        /// <param name="key">The key to add</param>
        /// <param name="value">The value to add</param>
        /// <returns>The number of items in the dictionary or -1 on failure.</returns>
        public static Primitive Add(Primitive dictionary, Primitive key, Primitive value)
        {
            Dictionary<Primitive, Primitive> data;

            if (!map.TryGetValue(dictionary, out data))
            {
                data = new Dictionary<Primitive, Primitive>();
                map[dictionary] = data;
            }

            data.Add(key, value);
            return data.Count;
        }

        /// <summary>
        /// Removes a key-value pair from a specified dictionary
        /// </summary>
        /// <param name="dictionary">The name of the dictionary</param>
        /// <param name="key">They key to remove</param>
        /// <returns>The number of items in the dictionary or -1 on failure.</returns>
        public static Primitive Remove(Primitive dictionary, Primitive key)
        {
            try
            {
                Dictionary<Primitive, Primitive> data;
                if (map.TryGetValue(dictionary, out data))
                {
                    if (data.ContainsKey(key)) data.Remove(key);
                    return data.Count;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }

            return -1;
        }

        /// <summary>
        /// Removes all key-value pairs from a dictionary
        /// </summary>
        /// <param name="dictionary">The name of the dictionary</param>
        /// <returns>The number of items in the dictionary or -1 on failure.</returns>
        public static Primitive Clear(Primitive dictionary)
        {
            Dictionary<Primitive, Primitive> data;
            if (map.TryGetValue(dictionary, out data))
            {
                data.Clear();
                return data.Count;
            }

            return -1;
        }

        /// <summary>
        /// Tells you if the specified dictionary
        /// contains a given key.
        /// </summary>
        /// <param name="dictionary">The name of the dictionary</param>
        /// <param name="key">They key to lookup</param>
        /// <returns>"True" or "False"</returns>
        public static Primitive ContainsKey(Primitive dictionary, Primitive key)
        {
            Dictionary<Primitive, Primitive> data;
            if (map.TryGetValue(dictionary, out data))
            {
                return data.ContainsKey(key) ? "True" : "False";
            }

            return "False";
        }

        /// <summary>
        /// Tells you if the specified dictionary
        /// contains a given key.
        /// </summary>
        /// <param name="dictionary">The name of the dictionary</param>
        /// <param name="value">They value to lookup</param>
        /// <returns>"True" or "False"</returns>
        public static Primitive ContainsValue(Primitive dictionary, Primitive value)
        {
            Dictionary<Primitive, Primitive> data;
            if (map.TryGetValue(dictionary, out data))
            {
                return data.ContainsValue(value) ? "True" : "False";
            }

            return "False";
        }

        /// <summary>
        /// Retrieves a value given a specified key from the
        /// specified dictionary
        /// </summary>
        /// <param name="dictionary">The name of the dictionary</param>
        /// <param name="key">The key to lookup</param>
        /// <returns>The value in the key-value pair or "" on failure.</returns>
        public static Primitive GetValue(Primitive dictionary, Primitive key)
        {
            Dictionary<Primitive, Primitive> data;
            if (map.TryGetValue(dictionary, out data))
            {
                if (data.ContainsKey(key)) return data[key];
            }

            return "";
        }

        /// <summary>
        /// Converts a specified dictionary into an smallbasic array
        /// </summary>
        /// <param name="dictionary">The name of a dictionary</param>
        /// <returns>"" on failure or an array</returns>
        public static Primitive ToArray(Primitive dictionary)
        {
            Dictionary<Primitive, Primitive> data;
            StringBuilder results = new StringBuilder();
            if (!map.TryGetValue(dictionary, out data))
            {
                return "";
            }

            foreach (var kv in data)
            {
                results.AppendFormat($"{kv.Key}={kv.Value};");
            }

            return Utilities.CreateArrayMap( results.ToString()  );
        }
    }
}
