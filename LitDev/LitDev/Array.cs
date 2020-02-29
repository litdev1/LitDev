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

using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace LitDev
{
    class stringPair : IComparable
    {
        public string value;
        public int index;

        public stringPair(int _index, string _value)
        {
            index = _index;
            value = _value;
        }

        int IComparable.CompareTo(object obj)
        {
            return value.CompareTo(((stringPair)obj).value);
        }
    }

    class doublePair : IComparable
    {
        public double value;
        public int index;

        public doublePair(int _index, double _value)
        {
            index = _index;
            value = _value;
        }

        int IComparable.CompareTo(object obj)
        {
            return value.CompareTo(((doublePair)obj).value);
        }
    }

    public class Array
    {
        public int maxNumber;
        public int number;
        public string name;
        public string[] array;

        public Array(int _maxNumber, int _number)
        {
            maxNumber = _maxNumber;
            number = _number;
            name = "Array" + _number.ToString();
            array = new string[_maxNumber];
            for (int i = 0; i < _maxNumber; i++) array[i] = "";
        }

        public void Reset()
        {
            name = "";
            array = null;
        }

        public string Copy(Array array2)
        {
            if (maxNumber != array2.maxNumber) return "FAILED";
            for (int i = 0; i < maxNumber; i++)
            {
                array2.array[i] = array[i];
            }
            return "";
        }

        public string Sort()
        {
            //Ignore "" in sort (place at end)
            int numSort = 0;
            for (int i = 0; i < maxNumber; i++)
            {
                if (array[i] != "")
                {
                    array[numSort++] = array[i];
                }
            }
            for (int i = numSort; i < maxNumber; i++)
            {
                array[i] = "";
            }

            try
            {
                List<double> _listDouble = new List<double>();
                for (int i = 0; i < numSort; i++)
                {
                    _listDouble.Add(Utilities.getDouble(array[i]));
                }
                _listDouble.Sort();
                for (int i = 0; i < numSort; i++)
                {
                    array[i] = _listDouble[i].ToString(CultureInfo.InvariantCulture);
                }
            }
            catch
            {
                List<string> _listString = new List<string>();
                for (int i = 0; i < numSort; i++)
                {
                    _listString.Add(array[i]);
                }
                _listString.Sort();
                for (int i = 0; i < numSort; i++)
                {
                    array[i] = _listString[i];
                }
            }

            return "";
        }

        public string SortIndex(Array index)
        {
            List<stringPair> _stringPair = new List<stringPair>();
            List<doublePair> _doublePair = new List<doublePair>();
            List<int> _null = new List<int>();

            //Ignore "" in sort (place at end)
            int numSort = 0;
            bool isDouble = true;
            for (int i = 0; i < maxNumber; i++)
            {
                if (array[i] == "")
                {
                    _null.Add(i);
                }
                else
                {
                    _stringPair.Add(new stringPair(i, array[i]));
                    if (isDouble)
                    {
                        try
                        {
                            _doublePair.Add(new doublePair(i, Utilities.getDouble(array[i])));
                        }
                        catch
                        {
                            isDouble = false;
                        }
                    }
                    numSort++;
                }
            }
            for (int i = numSort, j = 0; i < maxNumber; i++, j++)
            {
                index.array[i] = (_null[j] + 1).ToString();
            }

            if (isDouble)
            {
                _doublePair.Sort();
                for (int i = 0; i < numSort; i++)
                {
                    index.array[i] = (_doublePair[i].index + 1).ToString();
                }
            }
            else
            {
                _stringPair.Sort();
                for (int i = 0; i < numSort; i++)
                {
                    index.array[i] = (_stringPair[i].index + 1).ToString();
                }
            }

            return "";
        }
    }

    /// <summary>
    /// A 1-Dimensional array method that is much faster than the standard SmallBasic arrays.
    /// 
    /// Useful for arrays with greater than 100 to 1000 elements.
    /// An error will result in a return value "FAILED";
    /// </summary>
    [SmallBasicType]
    public static class LDArray
    {
        private static List<Array> Arrays = new List<Array>();

        public static Array getArray(string name)
        {
            foreach (Array _array in Arrays)
            {
                if (_array.name == name) return _array;
            }
            return null;
        }

        private static int getNewNumber()
        {
            int i = 1;
            foreach (Array _array in Arrays)
            {
                if (i <= _array.number) i = _array.number + 1;
            }
            return i;
        }

        /// <summary>
        /// Create a new array (can be used for numbers or character strings).
        /// </summary>
        /// <param name="maxSize">
        /// The maximum number of elements in the array.
        /// </param>
        /// <returns>
        /// The array name or "FAILED".
        /// </returns>
        public static Primitive Create(Primitive maxSize)
        {
            // We could handle doubles and strings separately, but the hassle and checks required don't warrant it given we have to convert to Primitives anyway.
            try
            {
                if (maxSize >= 1)
                {
                    Array _array = new Array(maxSize, getNewNumber());
                    Arrays.Add(_array);
                    return _array.name;
                }
                else
                {
                    return "FAILED";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Delete an existing array (not generally required, but can save memory if lots of arrays are created).
        /// </summary>
        /// <param name="array">
        /// The array name.
        /// </param>
        /// <returns>
        /// "FAILED" or "" for success.
        /// </returns>
        public static Primitive Delete(Primitive array)
        {
            try
            {
                Array _array = getArray(array);
                if (null == _array) return "FAILED";
                _array.Reset();
                Arrays.Remove(_array);
                return "";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Set value in array.
        /// </summary>
        /// <param name="array">
        /// The array name.
        /// </param>
        /// <param name="index">
        /// The index at which to add the value (indexed starting from 1).
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// "FAILED" or "" for success.
        /// </returns>
        public static Primitive SetValue(Primitive array, Primitive index, Primitive value)
        {
            try
            {
                Array _array = getArray(array);
                if (null != _array && index > 0 && index <= _array.maxNumber)
                {
                    _array.array[index - 1] = value;
                    return "";
                }
                else
                {
                    return "FAILED";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get value in array.
        /// </summary>
        /// <param name="array">
        /// The array name.
        /// </param>
        /// <param name="index">
        /// The index at which to get the value (indexed starting from 1).
        /// </param>
        /// <returns>
        /// The value or "FAILED".
        /// </returns>
        public static Primitive GetValue(Primitive array, Primitive index)
        {
            try
            {
                Array _array = getArray(array);
                if (null != _array && index > 0 && index <= _array.maxNumber)
                {
                    return _array.array[index - 1];
                }
                return "FAILED";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Copy one array to a new array.
        /// </summary>
        /// <param name="array">
        /// The array to copy.
        /// </param>
        /// <returns>
        /// A copy of the array or "FAILED".
        /// </returns>
        public static Primitive CopyNew(Primitive array)
        {
            try
            {
                Array _array1 = getArray(array);
                if (null == _array1) return "FAILED";
                Array _array2 = new Array(_array1.maxNumber, getNewNumber());
                Arrays.Add(_array2);

                return _array1.Copy(_array2) == "" ? _array2.name : "FAILED";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Copy one array to another array.
        /// The dimensions of the 2 arrays must be the same.
        /// </summary>
        /// <param name="array1">
        /// The array to copy from.
        /// </param>
        /// <param name="array2">
        /// The array to copy to.
        /// </param>
        /// <returns>
        /// "FAILED" or "" for success.
        /// </returns>
        public static Primitive Copy(Primitive array1, Primitive array2)
        {
            try
            {
                Array _array1 = getArray(array1);
                Array _array2 = getArray(array2);
                if (null == _array1 || null == _array2) return "FAILED";

                return _array1.Copy(_array2);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Copy LDArray type to SmallBasic array type.
        /// 
        /// The reverse operation (SmallBasic to LDArray) isn't possible becuase the SmallBasic indexes are not necessarily contiguous integers.
        /// Note also that a SmallBasic array cannot hold an empty string value, so these will not be copied.
        /// </summary>
        /// <param name="array">
        /// The array name.
        /// </param>
        /// <returns>
        /// The SmallBasic array or "FAILED".
        /// </returns>
        public static Primitive CopyToSBArray(Primitive array)
        {
            try
            {
                Array _array = getArray(array);
                if (null == _array) return "FAILED";
                StringBuilder _SBarray = new StringBuilder();
                for (int i = 0; i < _array.maxNumber; i++)
                {
                    _SBarray.AppendFormat("{0}={1};", (i + 1), Utilities.ArrayParse(_array.array[i]));// Faster than Primitive _SBarray[i] = _array.array[i]
                }
                return Utilities.CreateArrayMap(_SBarray.ToString());
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Perform a sort on an LDArray.  
        /// 
        /// By default the sort is by string value, therefore 10 comes before 2.
        /// To sort by number value, all values must be a number (or empty).
        /// 
        /// Empty values are placed at the end of the sort.
        /// The input array is replaced by the sorted array.
        /// </summary>
        /// <param name="array">The array to sort.</param>
        /// <returns>
        /// "FAILED" or "" for success.
        /// </returns>
        public static Primitive Sort(Primitive array)
        {
            try
            {
                Array _array = getArray(array);
                if (null == _array) return "FAILED";
                return _array.Sort();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get the number of non-empty "" elements in the array.
        /// </summary>
        /// <param name="array">The array name.</param>
        /// <returns>The number of non-empty values in the array.</returns>
        public static Primitive Count(Primitive array)
        {
            int count = 0;
            try
            {
                Array _array = getArray(array);
                if (null != _array)
                {
                    for (int i = 0; i < _array.maxNumber; i++)
                    {
                        if (_array.array[i] != "") count++;
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return count;
        }

        /// <summary>
        /// Obtain an array of the indices in sort order of an array.
        /// 
        /// By default the sort is by string value, therefore 10 comes before 2.
        /// To sort by number value, all values must be a number (or empty).
        /// 
        /// Empty values are placed at the end of the sort.
        /// The input array is unchanged and the index array must be previously created with the same size as the array to sort.
        /// </summary>
        /// <param name="array">The array to obtain an index order sort.</param>
        /// <param name="index">An array to hold the index order of the sorted array.</param>
        /// <returns>
        /// "FAILED" or "" for success.
        /// </returns>
        public static Primitive SortIndex(Primitive array, Primitive index)
        {
            try
            {
                Array _array = getArray(array);
                Array _index = getArray(index);
                if (null == _array || null == _index) return "FAILED";
                if (_array.maxNumber != _index.maxNumber) return "FAILED";
                return _array.SortIndex(_index);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Obtain an array of the indices that have values that contain searchstring.
        /// The search is case in-sensitive.
        /// The input array is unchanged and the match array must be previously created with the same size as the array to check.
        /// </summary>
        /// <param name="array">The array to check for matches.</param>
        /// <param name="searchstring">The string to search for.</param>
        /// <param name="match">An array to hold the index of matched values.</param>
        /// <returns>The number of matches found.
        /// </returns>
        public static Primitive Search(Primitive array, Primitive searchstring, Primitive match)
        {
            try
            {
                Array _array = getArray(array);
                Array _match = getArray(match);
                if (null == _array || null == _match) return 0;
                if (_array.maxNumber != _match.maxNumber) return 0;
                int i, count = 0;
                string searchLower = searchstring.ToString().ToLower();
                for (i = 0; i < _array.maxNumber; i++)
                {
                    if (_array.array[i].ToLower().Contains(searchLower))
                    {
                        _match.array[count++] = (i + 1).ToString();
                    }
                }
                for (i = count; i < _array.maxNumber; i++)
                {
                    _match.array[i] = "";
                }
                return count;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Save an array to a file.
        /// </summary>
        /// <param name="array">The array to save.</param>
        /// <param name="fileName">The file path to save the file to.</param>
        /// <returns>
        /// The number of elements saved.
        /// </returns>
        public static Primitive Save(Primitive array, Primitive fileName)
        {
            try
            {
                Array _array = getArray(array);
                if (null == _array) return 0;
                int i, count = 0;

                for (i = 0; i < _array.maxNumber; i++)
                {
                    if (_array.array[i] != "") count++;
                }
                string[] output = new string[count];
                count = 0;
                for (i = 0; i < _array.maxNumber; i++)
                {
                    if (_array.array[i] != "") output[count++] = _array.array[i];
                }

                System.IO.File.WriteAllLines(fileName, output);
                return count;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Load an array from a file.
        /// </summary>
        /// <param name="array">The array to load the data into.
        /// The array must already exist.</param>
        /// <param name="fileName">The file path to load the array from.</param>
        /// <returns>
        /// The number of elements loaded.
        /// </returns>
        public static Primitive Load(Primitive array, Primitive fileName)
        {
            try
            {
                Array _array = getArray(array);
                if (null == _array) return 0;
                if (!System.IO.File.Exists(fileName))
                {
                    Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                    return 0;
                }

                StreamReader streamReader = new StreamReader(fileName);
                int i, count = 0;

                while (!streamReader.EndOfStream && count < _array.maxNumber)
                {
                    _array.array[count++] = streamReader.ReadLine();
                }
                for (i = count; i < _array.maxNumber; i++)
                {
                }

                streamReader.Close();
                return count;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Create a new array from the indices of a Small Basic array.
        /// </summary>
        /// <param name="sbArray">The SB array.</param>
        /// <returns>
        /// The new array or "FAILED".
        /// </returns>
        public static Primitive CreateFromIndices(Primitive sbArray)
        {
            try
            {
                Type PrimitiveType = typeof(Primitive);
                Dictionary<Primitive, Primitive> _arrayMap;
                sbArray = Utilities.CreateArrayMap(sbArray);
                _arrayMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(sbArray);

                Array _array = new Array(_arrayMap.Count, getNewNumber());
                int i = 0;
                foreach (KeyValuePair<Primitive, Primitive> kvp in _arrayMap)
                {
                    _array.array[i++] = kvp.Key;
                }

                Arrays.Add(_array);
                return _array.name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Create a new array from the values of a Small Basic array.
        /// </summary>
        /// <param name="sbArray">The SB array.</param>
        /// <returns>
        /// The new array or "FAILED".
        /// </returns>
        public static Primitive CreateFromValues(Primitive sbArray)
        {
            try
            {
                Type PrimitiveType = typeof(Primitive);
                Dictionary<Primitive, Primitive> _arrayMap;
                sbArray = Utilities.CreateArrayMap(sbArray);
                _arrayMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(sbArray);

                Array _array = new Array(_arrayMap.Count, getNewNumber());
                int i = 0;
                foreach (KeyValuePair<Primitive, Primitive> kvp in _arrayMap)
                {
                    _array.array[i++] = kvp.Value;
                }

                Arrays.Add(_array);
                return _array.name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get the index of the first occurance of a value in an SB array.
        /// </summary>
        /// <param name="sbArray">The SB array.</param>
        /// <param name="value">The value to find.</param>
        /// <returns>The index of value in the array, "" if not present or "FAILED".</returns>
        public static Primitive GetIndex(Primitive sbArray, Primitive value)
        {
            try
            {
                Type PrimitiveType = typeof(Primitive);
                Dictionary<Primitive, Primitive> _arrayMap;
                sbArray = Utilities.CreateArrayMap(sbArray);
                _arrayMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(sbArray);

                foreach (KeyValuePair<Primitive, Primitive> kvp in _arrayMap)
                {
                    if (kvp.Value == value) return kvp.Key;
                }

                return "";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }
    }
}
