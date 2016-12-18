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
    public class List3D
    {
        private string name;
        private List<List<List<Primitive>>> list3D;
        private List<List<Primitive>> list2D;
        private List<Primitive> list1D;
        private int dim1;
        private int dim2;
        private int dim3;
        private int iDimension = 0; //Undefined
        private bool exact = true;
        private string match = "";

        public string Name { get { return name; } }

        public int Dimension { get { return iDimension; } }

        public List3D(int dim1 = 0, int dim2 = 0, int dim3 = 0)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
            this.dim3 = dim3;
            if (dim1 > 0) iDimension = 1;
            if (dim2 > 0) iDimension = 2;
            if (dim3 > 0) iDimension = 3;
            NewName();
            list3D = new List<List<List<Primitive>>>();
            Grow(dim1, dim2, dim3);
        }

        private void NewName()
        {
            int i = 1;
            while (LDFastArray._listMap.ContainsKey("Array" + i)) i++;
            name = "Array" + i;
        }

        private bool FindComparer(Primitive item)
        {
            if (exact) return ((string)item).ToLower() == match.ToLower();
            return ((string)item).ToLower().Contains(match.ToLower());
        }

        private void Grow(int index1, int index2, int index3)
        {
            for (int i = list3D.Count; i < index1; i++)
            {
                list2D = new List<List<Primitive>>();
                list3D.Add(list2D);
                for (int j = list2D.Count; j < dim2; j++)
                {
                    list1D = new List<Primitive>();
                    list2D.Add(list1D);
                    for (int k = 0; k < dim3; k++)
                    {
                        list1D.Add("");
                    }
                }
            }
            if (list3D.Count == 0) return;

            list2D = list3D[index1 - 1];
            for (int j = list2D.Count; j < index2; j++)
            {
                list1D = new List<Primitive>();
                list2D.Add(list1D);
                for (int k = 0; k < dim3; k++)
                {
                    list1D.Add("");
                }
            }
            if (list2D.Count == 0) return;

            list1D = list2D[index2 - 1];
            for (int k = list1D.Count; k < index3; k++)
            {
                list1D.Add("");
            }
        }

        private bool CheckDimension(int index1, int index2, int index3)
        {
            if (iDimension == 0 || iDimension == 3) return true;
            if (iDimension < 3 && index3 > 1) return false;
            if (iDimension < 2 && index2 > 1) return false;
            return true;
        }

        public void Set(Primitive value, int index1, int index2 = 1, int index3 = 1)
        {
            if (!CheckDimension(index1, index2, index3)) return;
            Grow(index1, index2, index3);
            list3D[index1 - 1][index2 - 1][index3 - 1] = value;
        }

        public Primitive Get(int index1, int index2 = 1, int index3 = 1)
        {
            if (index1 > list3D.Count) return "";
            list2D = list3D[index1 - 1];
            if (index2 > list2D.Count) return "";
            list1D = list2D[index2 - 1];
            if (index3 > list1D.Count) return "";
            return list1D[index3 - 1];
        }

        public int Dim1()
        {
            return list3D.Count;
        }

        public int Dim2(int index1 = 1)
        {
            if (index1 > list3D.Count) return 0;
            list2D = list3D[index1 - 1];
            return list2D.Count;
        }

        public int Dim3(int index1 = 1, int index2 = 1)
        {
            if (index1 > list3D.Count) return 0;
            list2D = list3D[index1 - 1];
            if (index2 > list2D.Count) return 0;
            list1D = list2D[index2 - 1];
            return list1D.Count;
        }

        public void Clear()
        {
            list3D.Clear();
        }

        public void Collapse()
        {
            for (int i = list3D.Count - 1; i >= 0; i--)
            {
                list2D = list3D[i];
                for (int j = list2D.Count - 1; j >= 0; j--)
                {
                    list1D = list2D[j];
                    list1D.RemoveAll(FindComparer);
                    if (list1D.Count == 0)
                    {
                        list2D.RemoveAt(j);
                    }
                }
                if (list2D.Count == 0)
                {
                    list3D.RemoveAt(i);
                }
            }
        }
    }

    /// <summary>
    /// This object provides another faster way of storing values in a Arrays.
    /// It can handle 1, 2 and 3 dimensional arrays and has methods to read and write 2D arrays to files in CSV format.
    /// It is also possible for different rows in an array to have different numbers of elements.
    /// Internally it uses lists that allow the original dimensions to be exceeded, so it is possible to intialise dimension size to 1.
    /// The indexing is by integer starting from 1.
    /// </summary>
    [SmallBasicType]
    public static class LDFastArray
    {
        public static Dictionary<string, List3D> _listMap = new Dictionary<string, List3D>();
        private static List3D _list3D;

        private static string ConnvertFromSB(Primitive sbArray, bool bValues)
        {
            try
            {
                FieldInfo _fieldInfo = typeof(Primitive).GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance);
                Dictionary<Primitive, Primitive> _arrayMap1, _arrayMap2, _arrayMap3;
                int dim1 = 0, dim2 = 0, dim3 = 0;
                _arrayMap1 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(sbArray));
                dim1 = System.Math.Max(dim1, _arrayMap1.Count);
                foreach (KeyValuePair<Primitive, Primitive> kvp1 in _arrayMap1)
                {
                    _arrayMap2 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(kvp1.Value));
                    dim2 = System.Math.Max(dim2, _arrayMap2.Count);
                    foreach (KeyValuePair<Primitive, Primitive> kvp2 in _arrayMap2)
                    {
                        _arrayMap3 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(kvp2.Value));
                        dim3 = System.Math.Max(dim3, _arrayMap3.Count);
                    }
                }

                _list3D = new List3D(dim1, dim2, dim3);
                _listMap[_list3D.Name] = _list3D;

                int i, j, k;
                i = 1;
                if (dim1 > 0)
                {
                    foreach (KeyValuePair<Primitive, Primitive> kvp1 in _arrayMap1)
                    {
                        j = 1;
                        if (dim2 > 0)
                        {
                            _arrayMap2 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(kvp1.Value));
                            foreach (KeyValuePair<Primitive, Primitive> kvp2 in _arrayMap2)
                            {
                                k = 1;
                                if (dim3 > 0)
                                {
                                    _arrayMap3 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(kvp2.Value));
                                    foreach (KeyValuePair<Primitive, Primitive> kvp3 in _arrayMap3)
                                    {
                                        _list3D.Set(bValues ? kvp3.Value : kvp3.Key, i, j, k);
                                        k++;
                                    }
                                }
                                else
                                {
                                    _list3D.Set(bValues ? kvp2.Value : kvp2.Key, i, j, k);
                                }
                                j++;
                            }
                        }
                        else
                        {
                            _list3D.Set(bValues ? kvp1.Value : kvp1.Key, i, j);
                        }
                        i++;
                    }
                }
                else
                {
                    if (bValues) _list3D.Set(sbArray, i);
                }

                return _list3D.Name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Create a new array.
        /// This is a general array that can be used as a 1D, 2D or 3D array, depending on the data set.
        /// For most cases this is the best array constructor.
        /// </summary>
        /// <returns>The array name.</returns>
        public static Primitive Add()
        {
            _list3D = new List3D();
            _listMap[_list3D.Name] = _list3D;
            return _list3D.Name;
        }

        /// <summary>
        /// Create a new 1D array.
        /// It is possible to initially size the array that will be used, but it will grow as required.
        /// 2D and 3D values will not be set.
        /// </summary>
        /// <param name="dim1">The initial first dimension size.</param>
        /// <returns>The 1D array name.</returns>
        public static Primitive Add1D(Primitive dim1)
        {
            _list3D = new List3D(dim1);
            _listMap[_list3D.Name] = _list3D;
            return _list3D.Name;
        }

        /// <summary>
        /// Create a new 2D array.
        /// It is possible to initially size the array that will be used, but it will grow as required.
        /// 3D values will not be set.
        /// </summary>
        /// <param name="dim1">The initial first dimension size.</param>
        /// <param name="dim2">The initial second dimension size.</param>
        /// <returns>The 2D array name.</returns>
        public static Primitive Add2D(Primitive dim1, Primitive dim2)
        {
            _list3D = new List3D(dim1, dim2);
            _listMap[_list3D.Name] = _list3D;
            return _list3D.Name;
        }

        /// <summary>
        /// Create a new 3D array.
        /// It is possible to initially size the array that will be used, but it will grow as required.
        /// </summary>
        /// <param name="dim1">The initial first dimension size.</param>
        /// <param name="dim2">The initial second dimension size.</param>
        /// <param name="dim3">The initial third dimension size.</param>
        /// <returns>The 3D array name.</returns>
        public static Primitive Add3D(Primitive dim1, Primitive dim2, Primitive dim3)
        {
            _list3D = new List3D(dim1, dim2, dim3);
            _listMap[_list3D.Name] = _list3D;
            return _list3D.Name;
        }

        /// <summary>
        /// Set a value in a 1D array.
        /// </summary>
        /// <param name="arrayName">The 1D array name.</param>
        /// <param name="index1">The first dimension integer index.</param>
        /// <param name="value">The value to set.</param>
        public static void Set1D(Primitive arrayName, Primitive index1, Primitive value)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return;
            _list3D.Set(value, index1);
        }

        /// <summary>
        /// Set a value in a 2D array.
        /// </summary>
        /// <param name="arrayName">The 2D array name.</param>
        /// <param name="index1">The first dimension integer index.</param>
        /// <param name="index2">The second dimension integer index.</param>
        /// <param name="value">The value to set.</param>
        public static void Set2D(Primitive arrayName, Primitive index1, Primitive index2, Primitive value)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return;
            _list3D.Set(value, index1, index2);
        }

        /// <summary>
        /// Set a value in a 3D array.
        /// </summary>
        /// <param name="arrayName">The 2D array name.</param>
        /// <param name="index1">The first dimension integer index.</param>
        /// <param name="index2">The second dimension integer index.</param>
        /// <param name="index3">The third dimension integer index.</param>
        /// <param name="value">The value to set.</param>
        public static void Set3D(Primitive arrayName, Primitive index1, Primitive index2, Primitive index3, Primitive value)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return;
            _list3D.Set(value, index1, index2, index3);
        }

        /// <summary>
        /// Get a value from a 1D array.
        /// </summary>
        /// <param name="arrayName">The 1D array name.</param>
        /// <param name="index1">The first dimension integer index.</param>
        /// <returns>The array value or "" on failure.</returns>
        public static Primitive Get1D(Primitive arrayName, Primitive index1)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";
            return _list3D.Get(index1);
        }

        /// <summary>
        /// Get a value from a 2D array.
        /// </summary>
        /// <param name="arrayName">The 2D array name.</param>
        /// <param name="index1">The first dimension integer index.</param>
        /// <param name="index2">The second dimension integer index.</param>
        /// <returns>The array value or "" on failure.</returns>
        public static Primitive Get2D(Primitive arrayName, Primitive index1, Primitive index2)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";
            return _list3D.Get(index1, index2);
        }

        /// <summary>
        /// Get a value from a 3D array.
        /// </summary>
        /// <param name="arrayName">The 3D array name.</param>
        /// <param name="index1">The first dimension integer index.</param>
        /// <param name="index2">The second dimension integer index.</param>
        /// <param name="index3">The third dimension integer index.</param>
        /// <returns>The array value or "" on failure.</returns>
        public static Primitive Get3D(Primitive arrayName, Primitive index1, Primitive index2, Primitive index3)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";
            return _list3D.Get(index1, index2, index3);
        }

        /// <summary>
        /// Get the current size of the first dimension.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <returns>The first dimension size.</returns>
        public static Primitive Dim1(Primitive arrayName)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";
            return _list3D.Dim1();
        }

        /// <summary>
        /// Get the current size of the second dimension.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="index1">The first index to get the size of, may be 1 if all rows have the same size.</param>
        /// <returns>The second dimension size.</returns>
        public static Primitive Dim2(Primitive arrayName, Primitive index1)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";
            if (_list3D.Dimension > 0 && _list3D.Dimension < 2) return 0;
            return _list3D.Dim2(index1);
        }

        /// <summary>
        /// Get the current size of the third dimension.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="index1">The first index to get the size of, may be 1 if all rows have the same size.</param>
        /// <param name="index2">The second index to get the size of, may be 1 if all rows have the same size.</param>
        /// <returns>The third dimension size.</returns>
        public static Primitive Dim3(Primitive arrayName, Primitive index1, Primitive index2)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";
            if (_list3D.Dimension > 0 && _list3D.Dimension < 3) return 0;
            return _list3D.Dim3(index1, index2);
        }

        /// <summary>
        /// Delete an array.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        public static void Remove(Primitive arrayName)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return;
            _list3D.Clear();
            _listMap.Remove(arrayName);
        }

        /// <summary>
        /// Read a CSV (comma separated values) file into a 2D FastArray  array.
        /// The deliminator may be changed from a comma using Utilities.CSVdeliminator
        /// </summary>
        /// <param name="fileName">
        /// The full path of the CSV file.
        /// </param>
        /// <returns>
        /// A 2D FastArray with CSV file imported or "".
        /// </returns>
        public static Primitive ReadCSV(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }

            string arrayName = "";

            try
            {
                string[] input = System.IO.File.ReadAllLines(fileName);

                string[] row;
                List<string[]> rowOrdered = new List<string[]>();
                int numRow = input.Length;
                int numCol = 0;

                foreach (string line in input)
                {
                    row = line.Split(new string[] { Utilities.CSV }, StringSplitOptions.None);
                    numCol = System.Math.Max(numCol, row.Length);
                    rowOrdered.Add(row);
                }

                arrayName = Add2D(numRow, numCol);
                for (int iRow = 0; iRow < numRow; iRow++)
                {
                    row = rowOrdered[iRow];
                    for (int iCol = 0; iCol < row.Length; iCol++)
                    {
                        string value = Utilities.CSVParse(row[iCol], false);
                        Set2D(arrayName, iRow + 1, iCol + 1, value);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }

            return arrayName;
        }

        /// <summary>
        /// Write a 2D FastArray array to a CSV (comma separated values) file.
        /// The deliminator may be changed from a comma using Utilities.CSVdeliminator
        /// </summary>
        /// <param name="fileName">
        /// The full path of the CSV file.
        /// </param>
        /// <param name="arrayName">
        /// The 2D array name.
        /// </param>
        public static void WriteCSV(Primitive fileName, Primitive arrayName)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return;

            try
            {
                string[] output = new string[_list3D.Dim1()];

                for (int iRow = 0; iRow < _list3D.Dim1(); iRow++)
                {
                    for (int iCol = 0; iCol < _list3D.Dim2(iRow+1); iCol++)
                    {
                        output[iRow] += Utilities.CSVParse(_list3D.Get(iRow + 1, iCol + 1), true) + Utilities.CSV;
                    }
                    if (output[iRow].Length > 0) output[iRow] = output[iRow].Substring(0, output[iRow].Length - 1);
                }

                System.IO.File.WriteAllLines(fileName, output);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Convert a SmallBasic array (up to 3 dimensions) to a FastArray array.
        /// All indices in the Small Basic array are replaced with consecutive integer indices.
        /// </summary>
        /// <param name="sbArray">The Small Basic array.</param>
        /// <returns>A new FastArray or "".</returns>
        public static Primitive FromSB(Primitive sbArray)
        {
            return ConnvertFromSB(sbArray, true);
        }

        /// <summary>
        /// Convert a SmallBasic array (up to 3 dimensions) to a FastArray array.
        /// This method creates an array only containing the Small Basic array indices.
        /// </summary>
        /// <param name="sbArray">The Small Basic array.</param>
        /// <returns>A new FastArray or "".</returns>
        public static Primitive FromSBIndices(Primitive sbArray)
        {
            return ConnvertFromSB(sbArray, false);
        }

        /// <summary>
        /// Convert a FastArray array to a Small Basic array.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <returns>A Small Basic array or "".</returns>
        public static Primitive ToSB(Primitive arrayName)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";

            try
            {
                Primitive result = "";
                for (int i = 0; i < _list3D.Dim1(); i++)
                {
                    if (_list3D.Dim2(i + 1) == 1 && _list3D.Dim3(i + 1) == 1)
                    {
                        result[i + 1] = _list3D.Get(i + 1);
                    }
                    else
                    {
                        Primitive result1 = "";
                        for (int j = 0; j < _list3D.Dim2(i + 1); j++)
                        {
                            if (_list3D.Dim3(i + 1, j + 1) == 1)
                            {
                                result1[j + 1] = _list3D.Get(i + 1, j + 1);
                            }
                            else
                            {
                                Primitive result2 = "";
                                for (int k = 0; k < _list3D.Dim3(i + 1, j + 1); k++)
                                {
                                    result2[k + 1] = _list3D.Get(i + 1, j + 1, k + 1);
                                }
                                result1[j + 1] = result2;
                            }
                        }
                        result[i + 1] = result1;
                    }
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Remove all empty "" entries in an array.
        /// Note that indices or even dimensions may change if internal entries are removed.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        public static void Collapse(Primitive arrayName)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return;
            _list3D.Collapse();
        }
    }
}
