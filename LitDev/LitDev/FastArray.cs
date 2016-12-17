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
        public string name;
        public List<List<List<Primitive>>> list3D;
        public List<List<Primitive>> list2D;
        public List<Primitive> list;
        public int dim1;
        public int dim2;
        public int dim3;

        public List3D(int dim1, int dim2 = 1, int dim3 = 1)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
            this.dim3 = dim3;
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

        private void Grow(int index1, int index2, int index3)
        {
            for (int i = list3D.Count; i < index1; i++)
            {
                list2D = new List<List<Primitive>>();
                list3D.Add(list2D);
                for (int j = list2D.Count; j < dim2; j++)
                {
                    list = new List<Primitive>();
                    list2D.Add(list);
                    for (int k = 0; k < dim3; k++)
                    {
                        list.Add("");
                    }
                }
            }
            list2D = list3D[index1 - 1];
            for (int j = list2D.Count; j < index2; j++)
            {
                list = new List<Primitive>();
                list2D.Add(list);
                for (int k = 0; k < dim3; k++)
                {
                    list.Add("");
                }
            }
            list = list2D[index2 - 1];
            for (int k = list.Count; k < index3; k++)
            {
                list.Add("");
            }
        }

        public void Set(Primitive value, int index1, int index2 = 1, int index3 = 1)
        {
            Grow(index1, index2, index3);
            list3D[index1 - 1][index2 - 1][index3 - 1] = value;
        }

        public Primitive Get(int index1, int index2 = 1, int index3 = 1)
        {
            if (index1 > list3D.Count) return "";
            list2D = list3D[index1 - 1];
            if (index2 > list2D.Count) return "";
            list = list2D[index2 - 1];
            if (index3 > list.Count) return "";
            return list[index3 - 1];
        }

        public int Dim1()
        {
            return list3D.Count;
        }

        public int Dim2(int index1)
        {
            if (index1 > list3D.Count) return 0;
            list2D = list3D[index1 - 1];
            return list2D.Count;
        }

        public int Dim3(int index1, int index2)
        {
            if (index1 > list3D.Count) return 0;
            list2D = list3D[index1 - 1];
            if (index2 > list2D.Count) return 0;
            list = list2D[index2 - 1];
            return list.Count;
        }
    }

    /// <summary>
    /// This object provides another faster way of storing values in a Arrays.
    /// It can handle 1, 2 and 3 dimensional arrays and has methods to read and write 2D arrays to files in CSV format.
    /// It is also possible for different rows to have different numbers of elements.
    /// Internally it uses lists that allow the original dimensions to be exceeded, but it is most efficient to set the size that you will need at the start.
    /// The indexing is by integer starting from 1.
    /// </summary>
    [SmallBasicType]
    public static class LDFastArray
    {
        public static Dictionary<string, List3D> _listMap = new Dictionary<string, List3D>();
        private static List3D _list3D;
        private static FieldInfo _fieldInfo = typeof(Primitive).GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance);

        /// <summary>
        /// Create a new 1D array.
        /// It is efficient to initially size the array to a maximum size that will be used, but it will grow as required.
        /// </summary>
        /// <param name="dim1">The initial first dimension size.</param>
        /// <returns>The 1D array name.</returns>
        public static Primitive Add1D(Primitive dim1)
        {
            _list3D = new List3D(dim1);
            _listMap[_list3D.name] = _list3D;
            return _list3D.name;
        }

        /// <summary>
        /// Create a new 2D array.
        /// It is efficient to initially size the array to a maximum size that will be used, but it will grow as required.
        /// </summary>
        /// <param name="dim1">The initial first dimension size.</param>
        /// <param name="dim2">The initial second dimension size.</param>
        /// <returns>The 2D array name.</returns>
        public static Primitive Add2D(Primitive dim1, Primitive dim2)
        {
            _list3D = new List3D(dim1, dim2);
            _listMap[_list3D.name] = _list3D;
            return _list3D.name;
        }

        /// <summary>
        /// Create a new 3D array.
        /// It is efficient to initially size the array to a maximum size that will be used, but it will grow as required.
        /// </summary>
        /// <param name="dim1">The initial first dimension size.</param>
        /// <param name="dim2">The initial second dimension size.</param>
        /// <param name="dim3">The initial third dimension size.</param>
        /// <returns>The 3D array name.</returns>
        public static Primitive Add3D(Primitive dim1, Primitive dim2, Primitive dim3)
        {
            _list3D = new List3D(dim1, dim2, dim3);
            _listMap[_list3D.name] = _list3D;
            return _list3D.name;
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
        /// <param name="index1">The first index to get the size of.</param>
        /// <returns>The second dimension size.</returns>
        public static Primitive Dim2(Primitive arrayName, Primitive index1)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";
            return _list3D.Dim2(index1);
        }

        /// <summary>
        /// Get the current size of the third dimension.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="index1">The first index to get the size of.</param>
        /// <param name="index2">The second index to get the size of.</param>
        /// <returns>The third dimension size.</returns>
        public static Primitive Dim3(Primitive arrayName, Primitive index1, Primitive index2)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";
            return _list3D.Dim3(index1, index2);
        }

        /// <summary>
        /// Read a CSV (comma separated values) file into an array.
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

        //[HideFromIntellisense]
        //public static Primitive FromSB(Primitive sbArray)
        //{
        //    Dictionary<Primitive, Primitive> _arrayMap1, _arrayMap2, _arrayMap3;
        //    int dim1 = 1, dim2 = 1, dim3 = 1;
        //    _arrayMap1 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(sbArray));
        //    dim1 = System.Math.Max(dim1, _arrayMap1.Count);
        //    foreach (KeyValuePair<Primitive, Primitive> kvp1 in _arrayMap1)
        //    {
        //        _arrayMap2 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(kvp1.Value));
        //        dim2 = System.Math.Max(dim2, _arrayMap2.Count);
        //        foreach (KeyValuePair<Primitive, Primitive> kvp2 in _arrayMap2)
        //        {
        //            dim3 = System.Math.Max(dim3, _arrayMap2.Count);
        //        }
        //    }

        //    _list3D = new List3D(dim1, dim2, dim3);
        //    _listMap[_list3D.name] = _list3D;

        //    int i = 1, j = 1, k = 1;
        //    if (dim1 > 1)
        //    {
        //        foreach (KeyValuePair<Primitive, Primitive> kvp1 in _arrayMap1)
        //        {
        //            if (dim2 > 1)
        //            {
        //                _arrayMap2 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(kvp1.Value));
        //                foreach (KeyValuePair<Primitive, Primitive> kvp2 in _arrayMap2)
        //                {
        //                    if (dim3 > 1)
        //                    {
        //                        _arrayMap3 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(kvp2.Value));
        //                        foreach (KeyValuePair<Primitive, Primitive> kvp3 in _arrayMap3)
        //                        {
        //                            _list3D.Set(kvp3.Value, i, j, k);
        //                            k++;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        _list3D.Set(kvp2.Value, i, j, k);
        //                    }
        //                    j++;
        //                }
        //            }
        //            else
        //            {
        //                _list3D.Set(kvp1.Value, i, j, k);
        //            }
        //            i++;
        //        }
        //    }
        //    else
        //    {
        //        _list3D.Set(sbArray, i, j, k);
        //    }

        //    return _list3D.name;
        //}
    }
}
