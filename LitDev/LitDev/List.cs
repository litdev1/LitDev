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
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace LitDev
{
    class DecimalComparer : IComparer<Primitive>
    {
        public int Compare(Primitive x, Primitive y)
        {
            return ((Decimal)x).CompareTo((Decimal)y);
        }
    }

    class StringComparer : IComparer<Primitive>
    {
        public int Compare(Primitive x, Primitive y)
        {
            return ((string)x).CompareTo((string)y);
        }
    }

    /// <summary>
    /// This object provides a way of storing values like an array that reorders itself as items are added or removed.
    /// A list is an efficient array store (much faster than SmallBasic arrays) that can be indexed by integers and perform various other operations.
    /// The indexing is automatically updated (indexed from 1) as the list changes.
    /// </summary>
    [SmallBasicType]
    public static class LDList
    {
        public static Dictionary<string, List<Primitive>> _listMap = new Dictionary<string, List<Primitive>>();
        private static int listCount = 0;
        private static bool _exact = true;
        private static string _match = "";
        private static bool FindComparer(Primitive item)
        {
            if (_exact) return ((string)item).ToLower() == _match.ToLower();
            return ((string)item).ToLower().Contains(_match.ToLower());
        }

        /// <summary>
        /// Adds a value to the end of a specified list.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <param name="value">
        /// The value to add.
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive Add(Primitive listName, Primitive value)
        {
            List<Primitive> list;
            if (!_listMap.TryGetValue(listName, out list))
            {
                list = new List<Primitive>();
                _listMap[listName] = list;
            }
            list.Add(value);
            return list.Count;
        }

        /// <summary>
        /// Appends a second list to the end of a first list.
        /// </summary>
        /// <param name="listName1">
        /// The name of the first list.
        /// </param>
        /// <param name="listName2">
        /// The name of the second list to append to listName1.
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive Append(Primitive listName1, Primitive listName2)
        {
            List<Primitive> list1, list2;
            if (!_listMap.TryGetValue(listName1, out list1))
            {
                list1 = new List<Primitive>();
            }
            if (!_listMap.TryGetValue(listName2, out list2))
            {
                list2 = new List<Primitive>();
            }
            list1.AddRange(list2);
            return list1.Count;
        }

        /// <summary>
        /// Gets the count of items in the specified list.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive Count(Primitive listName)
        {
            List<Primitive> list;
            if (!_listMap.TryGetValue(listName, out list))
            {
                list = new List<Primitive>();
                _listMap[listName] = list;
            }
            return list.Count;
        }

        /// <summary>
        /// Remove a value from a specified list by index (starting from 1).
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <param name="index">
        /// The value index to remove.
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive RemoveAt(Primitive listName, Primitive index)
        {
            try
            {
                List<Primitive> list;
                if (_listMap.TryGetValue(listName, out list))
                {
                    list.RemoveAt(index - 1);
                    return list.Count;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return -1;
        }

        /// <summary>
        /// Get a value from a specified list by index (starting from 1).
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <param name="index">
        /// The value index to get.
        /// </param>
        /// <returns>The list value.</returns>
        public static Primitive GetAt(Primitive listName, Primitive index)
        {
            try
            {
                List<Primitive> list;
                if (_listMap.TryGetValue(listName, out list))
                {
                    return list[index - 1];
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Set (replace) a value in a specified list by index (starting from 1).
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <param name="index">
        /// The index to set.
        /// </param>
        /// <param name="value">
        /// The value to set.
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive SetAt(Primitive listName, Primitive index, Primitive value)
        {
            try
            {
                List<Primitive> list;
                if (_listMap.TryGetValue(listName, out list))
                {
                    list[index - 1] = value;
                    return list.Count;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return -1;
        }

        /// <summary>
        /// Insert a value in a specified list by index (starting from 1).
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <param name="index">
        /// The index to insert at.
        /// </param>
        /// <param name="value">
        /// The value to insert.
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive InsertAt(Primitive listName, Primitive index, Primitive value)
        {
            try
            {
                List<Primitive> list;
                if (_listMap.TryGetValue(listName, out list))
                {
                    list.Insert(index - 1, value);
                    return list.Count;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return -1;
        }

        /// <summary>
        /// Get the index (starting from 1) of the first occurance of a value from the specified list.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <param name="value">
        /// The value to get index of (0 for not found).
        /// </param>
        /// <returns>The value index or 0.</returns>
        public static Primitive IndexOf(Primitive listName, Primitive value)
        {
            List<Primitive> list;
            if (_listMap.TryGetValue(listName, out list))
            {
                return list.IndexOf(value) + 1;
            }
            return 0;
        }

        /// <summary>
        /// Check if a value is present within the specified list.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <param name="value">
        /// The value to check.
        /// </param>
        /// <returns>
        /// "True" or "False".
        /// </returns>
        public static Primitive Contains(Primitive listName, Primitive value)
        {
            List<Primitive> list;
            if (_listMap.TryGetValue(listName, out list))
            {
                return list.Contains(value) ? "True" : "False";
            }
            return "False";
        }

        /// <summary>
        /// Reverse the order of values in the specified list.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive Reverse(Primitive listName)
        {
            try
            {
                List<Primitive> list;
                if (_listMap.TryGetValue(listName, out list))
                {
                    list.Reverse(0, list.Count);
                    return list.Count;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return -1;
        }

        /// <summary>
        /// Remove all values from a specified list.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive Clear(Primitive listName)
        {
            List<Primitive> list;
            if (_listMap.TryGetValue(listName, out list))
            {
                list.Clear();
                return list.Count;
            }
            return -1;
        }

        /// <summary>
        /// Sort a specified list with values treated as numbers.
        /// All values must be numbers.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive SortByNumber(Primitive listName)
        {
            try
            {
                List<Primitive> list;
                if (_listMap.TryGetValue(listName, out list))
                {
                    list.Sort(new DecimalComparer());
                    return list.Count;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return -1;
        }

        /// <summary>
        /// Sort a specified list with values treated as text strings (lexical sort).
        /// The sort is case insensitive.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive SortByText(Primitive listName)
        {
            try
            {
                List<Primitive> list;
                if (_listMap.TryGetValue(listName, out list))
                {
                    list.Sort(new StringComparer());
                    return list.Count;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return -1;
        }

        /// <summary>
        /// Get a sub list from the specified list.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <param name="start">
        /// The first index of the sub list.
        /// </param>
        /// <param name="length">
        /// The length of the sub list.
        /// </param>
        /// <returns>The sub list.</returns>
        public static Primitive SubList(Primitive listName, Primitive start, Primitive length)
        {
            try
            {
                List<Primitive> list;
                if (_listMap.TryGetValue(listName, out list))
                {
                    string newListName = "List" + ++listCount;
                    _listMap[newListName] = list.GetRange(start - 1, length);
                    return newListName;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Get a sub list from the specified list where a text match is found.
        /// The text match is case insensitive.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <param name="match">
        /// The match text.
        /// </param>
        /// <param name="exact">
        /// An exact match (case insensitive) "True" or the match text is contained in the list "False".
        /// </param>
        /// <returns>The sub list.</returns>
        public static Primitive Find(Primitive listName, Primitive match, Primitive exact)
        {
            try
            {
                List<Primitive> list;
                if (_listMap.TryGetValue(listName, out list))
                {
                    string newListName = "List" + ++listCount;
                    _exact = exact;
                    _match = match;
                    _listMap[newListName] = list.FindAll(FindComparer);

                    return newListName;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Get a sub list of indices from the specified list where a text match is found.
        /// The text match is case insensitive.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <param name="match">
        /// The match text.
        /// </param>
        /// <param name="exact">
        /// An exact match (case insensitive) "True" or the match text is contained in the list "False".
        /// </param>
        /// <returns>The sub list of indices in the list where a match is found.</returns>
        public static Primitive FindIndices(Primitive listName, Primitive match, Primitive exact)
        {
            try
            {
                List<Primitive> list, newList;
                if (_listMap.TryGetValue(listName, out list))
                {
                    string newListName = "List" + ++listCount;
                    _exact = exact;
                    _match = match;
                    newList = new List<Primitive>();
                    _listMap[newListName] = newList;
                    int[] indices = list.Select((value, index) => FindComparer(value) ? index : -1).Where(index => index != -1).ToArray();
                    foreach (int index in indices)
                    {
                        newList.Add(index + 1);
                    }

                    return newListName;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Remove all occurances from the specified list where a text match is found.
        /// The text match is case insensitive.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <param name="match">
        /// The match text.
        /// </param>
        /// <param name="exact">
        /// An exact match (case insensitive) "True" or the match text is contained in the list "False".
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive Remove(Primitive listName, Primitive match, Primitive exact)
        {
            try
            {
                List<Primitive> list;
                if (_listMap.TryGetValue(listName, out list))
                {
                    _exact = exact;
                    _match = match;
                    list.RemoveAll(FindComparer);
                    return list.Count;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return -1;
        }

        /// <summary>
        /// Get a sub list of unique values from the specified list.
        /// The text comparison is case insensitive.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <returns>The sub list.</returns>
        public static Primitive Distinct(Primitive listName)
        {
            try
            {
                List<Primitive> list, newList;
                if (_listMap.TryGetValue(listName, out list))
                {
                    string newListName = "List" + ++listCount;
                    newList = list.Distinct().ToList();
                    _listMap[newListName] = newList;
                    return newListName;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Get a sub list of shared values between two specified lists.
        /// The text comparison is case insensitive.
        /// </summary>
        /// <param name="listName1">
        /// The name of the first list.
        /// </param>
        /// <param name="listName2">
        /// The name of the second list.
        /// </param>
        /// <returns>The intersection list.</returns>
        public static Primitive Intersect(Primitive listName1, Primitive listName2)
        {
            try
            {
                List<Primitive> list1, list2, newList;
                if (_listMap.TryGetValue(listName1, out list1) && _listMap.TryGetValue(listName2, out list2))
                {
                    string newListName = "List" + ++listCount;
                    newList = list1.Intersect(list2).ToList();
                    _listMap[newListName] = newList;
                    return newListName;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Get a sub list of non-shared values between two specified lists.
        /// The text comparison is case insensitive.
        /// </summary>
        /// <param name="listName1">
        /// The name of the first list.
        /// </param>
        /// <param name="listName2">
        /// The name of the second list.
        /// </param>
        /// <returns>The except list.</returns>
        public static Primitive Except(Primitive listName1, Primitive listName2)
        {
            try
            {
                List<Primitive> list1, list2, newList;
                if (_listMap.TryGetValue(listName1, out list1) && _listMap.TryGetValue(listName2, out list2))
                {
                    string newListName = "List" + ++listCount;
                    newList = list1.Except(list2).ToList();
                    _listMap[newListName] = newList;
                    return newListName;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Get a sub list of combined values (duplicates single counted) between two specified lists.
        /// The text comparison is case insensitive.
        /// </summary>
        /// <param name="listName1">
        /// The name of the first list.
        /// </param>
        /// <param name="listName2">
        /// The name of the second list.
        /// </param>
        /// <returns>The union list.</returns>
        public static Primitive Union(Primitive listName1, Primitive listName2)
        {
            try
            {
                List<Primitive> list1, list2, newList;
                if (_listMap.TryGetValue(listName1, out list1) && _listMap.TryGetValue(listName2, out list2))
                {
                    string newListName = "List" + ++listCount;
                    newList = list1.Union(list2).ToList();
                    _listMap[newListName] = newList;
                    return newListName;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Copy a list.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <returns>A copy of the list.</returns>
        public static Primitive Copy(Primitive listName)
        {
            try
            {
                List<Primitive> list, newList;
                if (_listMap.TryGetValue(listName, out list))
                {
                    string newListName = "List" + ++listCount;
                    newList = new List<Primitive>();
                    foreach (Primitive value in list)
                    {
                        newList.Add(value);
                    }
                    _listMap[newListName] = newList;
                    return newListName;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Save a list to file.
        /// One line per list value is used.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <param name="filePath">
        /// The full path to save the list to.
        /// </param>
        /// <param name="append">
        /// Append to end of existing file "True" or create a new file "False".
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive Write(Primitive listName, Primitive filePath, Primitive append)
        {
            string path = Environment.ExpandEnvironmentVariables(filePath);
            try
            {
                List<Primitive> list;
                if (_listMap.TryGetValue(listName, out list))
                {
                    using (StreamWriter streamWriter = new StreamWriter(path, append))
                    {
                        foreach (Primitive value in list)
                        {
                            streamWriter.WriteLine((string)value);
                        }
                    }
                    return list.Count;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return -1;
        }

        /// <summary>
        /// Read a list from a file.
        /// </summary>
        /// <param name="filePath">
        /// The full path to read the list from.
        /// </param>
        /// <returns>
        /// The list if the operation was successful, otherwise "".
        /// </returns>
        public static Primitive Read(Primitive filePath)
        {
            string path = Environment.ExpandEnvironmentVariables(filePath);
            if (!System.IO.File.Exists(filePath))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), filePath);
                return "";
            }
            try
            {
                List<Primitive> newList = new List<Primitive>();
                string newListName = "List" + ++listCount;
                _listMap[newListName] = newList;

                using (StreamReader streamReader = new StreamReader(path))
                {
                    while (streamReader.Peek() >= 0)
                    {
                        newList.Add(streamReader.ReadLine());
                    }
                }
                return newListName;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Print a list to the TextWindow.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <returns>
        /// The number of items in the list or -1 on failure.
        /// </returns>
        public static Primitive Print(Primitive listName)
        {
            List<Primitive> list;
            if (_listMap.TryGetValue(listName, out list))
            {
                int num = (int)(1 + System.Math.Log10(list.Count));
                int i = 1;
                TextWindow.WriteLine(listName);
                foreach (Primitive value in list)
                {
                    TextWindow.WriteLine(string.Format("{0," + num + ":G} : ", i++) + value);
                }
                return list.Count;
            }
            return -1;
        }

        /// <summary>
        /// Convert a list to a SmallBasic array.
        /// Not advised for large lists.
        /// </summary>
        /// <param name="listName">
        /// The name of the list.
        /// </param>
        /// <returns>
        /// The Small Basic array.
        /// </returns>
        public static Primitive ToArray(Primitive listName)
        {
            Primitive result = "";
            List<Primitive> list;
            if (_listMap.TryGetValue(listName, out list))
            {
                int i = 0;
                foreach (Primitive value in list)
                {
                    result[++i] = value;
                }
            }
            return result;
        }

        /// <summary>
        /// Copy a SmallBasic array to a list.
        /// The array indices are ignored by the list.
        /// </summary>
        /// <param name="arrayName">
        /// The SmallBasic array.
        /// </param>
        /// <returns>The created list.</returns>
        public static Primitive FromArray(Primitive arrayName)
        {
            try
            {
                Type PrimitiveType = typeof(Primitive);
                Dictionary<Primitive, Primitive> _arrayMap;
                arrayName = Utilities.CreateArrayMap(arrayName);
                _arrayMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(arrayName);

                string newListName = "List" + ++listCount;
                List<Primitive> newList = new List<Primitive>();

                foreach (KeyValuePair<Primitive, Primitive> kvp in _arrayMap)
                {
                    newList.Add(kvp.Value);
                }

                _listMap[newListName] = newList;
                return newListName;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Create a new list from the indices of a Small Basic array.
        /// </summary>
        /// <param name="sbArray">The SB array.</param>
        /// <returns>
        /// The new list or "FAILED".
        /// </returns>
        public static Primitive CreateFromIndices(Primitive sbArray)
        {
            try
            {
                Type PrimitiveType = typeof(Primitive);
                Dictionary<Primitive, Primitive> _arrayMap;
                sbArray = Utilities.CreateArrayMap(sbArray);
                _arrayMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(sbArray);

                List<Primitive> list;
                string listName = "List" + ++listCount;
                list = new List<Primitive>();

                foreach (KeyValuePair<Primitive, Primitive> kvp in _arrayMap)
                {
                    list.Add(kvp.Key);
                }

                _listMap[listName] = list;
                return listName;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Create a new list from the values of a Small Basic array.
        /// </summary>
        /// <param name="sbArray">The SB array.</param>
        /// <returns>
        /// The new list or "FAILED".
        /// </returns>
        public static Primitive CreateFromValues(Primitive sbArray)
        {
            try
            {
                Type PrimitiveType = typeof(Primitive);
                Dictionary<Primitive, Primitive> _arrayMap;
                sbArray = Utilities.CreateArrayMap(sbArray);
                _arrayMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(sbArray);

                List<Primitive> list;
                string listName = "List" + ++listCount;
                list = new List<Primitive>();

                foreach (KeyValuePair<Primitive, Primitive> kvp in _arrayMap)
                {
                    list.Add(kvp.Value);
                }

                _listMap[listName] = list;
                return listName;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }
    }
}
