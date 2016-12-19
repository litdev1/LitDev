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
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

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
        private int iDimension = 3; //Undefined
        private bool exactMatch = true;
        private bool caseSensitive = false;
        private string match = "";

        public string Name { get { return name; } }

        public int Dimension { get { return iDimension; } }

        public List3D(int Dim1 = 0, int Dim2 = 0, int Dim3 = 0)
        {
            dim1 = System.Math.Max(Dim1, 1);
            dim2 = System.Math.Max(Dim2, 1);
            dim3 = System.Math.Max(Dim3, 1);
            if (Dim1 > 0) iDimension = 1;
            if (Dim2 > 0) iDimension = 2;
            if (Dim3 > 0) iDimension = 3;
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
            if (caseSensitive)
            {
                if (exactMatch) return item == match;
                return ((string)item).Contains(match);
            }
            else
            {
                if (exactMatch) return ((string)item).ToLower() == match.ToLower();
                return ((string)item).ToLower().Contains(match.ToLower());
            }
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
            if (iDimension == 1 || list3D.Count == 0) return;

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
            if (iDimension == 2 || list2D.Count == 0) return;

            list1D = list2D[index2 - 1];
            for (int k = list1D.Count; k < index3; k++)
            {
                list1D.Add("");
            }
        }

        private bool CheckDimension(int index1, int index2, int index3)
        {
            if (iDimension == 3) return true;
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

        public void Write(string fileName, bool binary)
        {
            try
            {
                if (binary)
                {
                    using (FileStream fs = System.IO.File.Open(fileName, FileMode.Create))
                    {
                        using (BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8))
                        {
                            bw.Write(dim1);
                            bw.Write(dim2);
                            bw.Write(dim3);
                            bw.Write(iDimension);

                            bw.Write(list3D.Count);
                            for (int i = 0; i < list3D.Count; i++)
                            {
                                list2D = list3D[i];
                                bw.Write(list2D.Count);
                                for (int j = 0; j < list2D.Count; j++)
                                {
                                    list1D = list2D[j];
                                    bw.Write(list1D.Count);
                                    for (int k = 0; k < list1D.Count; k++)
                                    {
                                        bw.Write((string)list1D[k]);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    using (FileStream fs = System.IO.File.Open(fileName, FileMode.Create))
                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                        {
                            string line;
                            sw.WriteLine(iDimension);
                            for (int i = 0; i < list3D.Count; i++)
                            {
                                list2D = list3D[i];
                                for (int j = 0; j < list2D.Count; j++)
                                {
                                    list1D = list2D[j];
                                    for (int k = 0; k < list1D.Count; k++)
                                    {
                                        switch (iDimension)
                                        {
                                            case 1:
                                                line = (i + 1) + " " + list1D[k];
                                                sw.WriteLine(line);
                                                break;
                                            case 2:
                                                line = (i + 1) + " " + (j + 1) + " " + list1D[k];
                                                sw.WriteLine(line);
                                                break;
                                            default:
                                                line = (i + 1) + " " + (j + 1) + " " + (k + 1) + " " + list1D[k];
                                                sw.WriteLine(line);
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        public void Read(string fileName, bool binary)
        {
            try
            {
                if (binary)
                {
                    using (FileStream fs = System.IO.File.Open(fileName, FileMode.Open))
                    {
                        using (BinaryReader br = new BinaryReader(fs, Encoding.UTF8))
                        {
                            dim1 = br.ReadInt32();
                            dim2 = br.ReadInt32();
                            dim3 = br.ReadInt32();
                            iDimension = br.ReadInt32();

                            list3D.Clear();
                            int num1 = br.ReadInt32();
                            for (int i = 0; i < num1; i++)
                            {
                                list2D = new List<List<Primitive>>();
                                list3D.Add(list2D);
                                int num2 = br.ReadInt32();
                                for (int j = 0; j < num2; j++)
                                {
                                    list1D = new List<Primitive>();
                                    list2D.Add(list1D);
                                    int num3 = br.ReadInt32();
                                    for (int k = 0; k < num3; k++)
                                    {
                                        list1D.Add(br.ReadString());
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    using (FileStream fs = System.IO.File.Open(fileName, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                        {
                            int i, j, k;
                            string value;
                            list3D.Clear();
                            iDimension = int.Parse(sr.ReadLine());
                            while (sr.Peek() >= 0)
                            {
                                string line = sr.ReadLine();
                                string[] split = line.Split(new char[] { ' ' });
                                switch (iDimension)
                                {
                                    case 1:
                                        {
                                            i = int.Parse(split[0]);
                                            value = "";
                                            for (int l = 1; l < split.Length; l++) value += split[l];
                                            Set(value, i);
                                        }
                                        break;
                                    case 2:
                                        {
                                            i = int.Parse(split[0]);
                                            j = int.Parse(split[1]);
                                            value = "";
                                            for (int l = 2; l < split.Length; l++) value += split[l];
                                            Set(value, i, j);
                                        }
                                        break;
                                    default:
                                        {
                                            i = int.Parse(split[0]);
                                            j = int.Parse(split[1]);
                                            k = int.Parse(split[2]);
                                            value = "";
                                            for (int l = 3; l < split.Length; l++) value += split[l];
                                            Set(value, i, j, k);
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        public void WriteCSV(string fileName)
        {
            try
            {
                string[] output = new string[Dim1()];

                for (int iRow = 0; iRow < Dim1(); iRow++)
                {
                    for (int iCol = 0; iCol < Dim2(iRow + 1); iCol++)
                    {
                        output[iRow] += Utilities.CSVParse(Get(iRow + 1, iCol + 1), true) + Utilities.CSV;
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

        public void ReadCSV(string fileName)
        {
            try
            {
                string[] input = System.IO.File.ReadAllLines(fileName);

                string[] row;
                List<string[]> rowOrdered = new List<string[]>();
                int numRow = input.Length;
                int numCol = 1;

                foreach (string line in input)
                {
                    row = line.Split(new string[] { Utilities.CSV }, StringSplitOptions.None);
                    numCol = System.Math.Max(numCol, row.Length);
                    rowOrdered.Add(row);
                }

                list3D.Clear();
                dim1 = numRow;
                dim2 = numCol;
                dim3 = 1;
                iDimension = 2;
                Grow(dim1, dim2, dim3);

                for (int iRow = 0; iRow < numRow; iRow++)
                {
                    row = rowOrdered[iRow];
                    for (int iCol = 0; iCol < row.Length; iCol++)
                    {
                        string value = Utilities.CSVParse(row[iCol], false);
                        Set(value, iRow + 1, iCol + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        public void FromSB(Primitive sbArray, bool bValues)
        {
            try
            {
                FieldInfo _fieldInfo = typeof(Primitive).GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance);
                Dictionary<Primitive, Primitive> _arrayMap1, _arrayMap2, _arrayMap3;

                list3D.Clear();
                dim1 = 1;
                dim2 = 1;
                dim3 = 1;
                iDimension = 0;

                int i, j, k;
                i = 1;
                _arrayMap1 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(sbArray));
                if (_arrayMap1.Count > 0)
                {
                    iDimension = System.Math.Max(iDimension, 1);
                    foreach (KeyValuePair<Primitive, Primitive> kvp1 in _arrayMap1)
                    {
                        j = 1;
                        _arrayMap2 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(kvp1.Value));
                        if (_arrayMap2.Count > 0)
                        {
                            iDimension = System.Math.Max(iDimension, 2);
                            foreach (KeyValuePair<Primitive, Primitive> kvp2 in _arrayMap2)
                            {
                                k = 1;
                                _arrayMap3 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(kvp2.Value));
                                if (_arrayMap3.Count > 0)
                                {
                                    iDimension = System.Math.Max(iDimension, 3);
                                    foreach (KeyValuePair<Primitive, Primitive> kvp3 in _arrayMap3)
                                    {
                                        Set(bValues ? kvp3.Value : kvp3.Key, i, j, k);
                                        k++;
                                    }
                                }
                                else
                                {
                                    Set(bValues ? kvp2.Value : kvp2.Key, i, j, k);
                                }
                                j++;
                            }
                        }
                        else
                        {
                            Set(bValues ? kvp1.Value : kvp1.Key, i, j);
                        }
                        i++;
                    }
                }
                else
                {
                    if (bValues) Set(sbArray, i);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        public Primitive ToSB()
        {
            try
            {
                Primitive result = "";
                for (int i = 0; i < Dim1(); i++)
                {
                    if (Dim2(i + 1) == 1 && Dim3(i + 1) == 1)
                    {
                        result[i + 1] = Get(i + 1);
                    }
                    else
                    {
                        Primitive result1 = "";
                        for (int j = 0; j < Dim2(i + 1); j++)
                        {
                            if (Dim3(i + 1, j + 1) == 1)
                            {
                                result1[j + 1] = Get(i + 1, j + 1);
                            }
                            else
                            {
                                Primitive result2 = "";
                                for (int k = 0; k < Dim3(i + 1, j + 1); k++)
                                {
                                    result2[k + 1] = Get(i + 1, j + 1, k + 1);
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
    }

    /// <summary>
    /// This object provides another faster way of storing values in an Array.
    /// It can handle 1, 2 and 3 dimensional arrays and has methods to read and write 2D arrays to files in CSV format.
    /// It is also possible for different rows in an array to have different numbers of elements.
    /// Internally it uses lists that allow the original dimension sizes to be exceeded.
    /// The indexing is by integer starting from 1.
    /// </summary>
    [SmallBasicType]
    public static class LDFastArray
    {
        public static Dictionary<string, List3D> _listMap = new Dictionary<string, List3D>();
        private static List3D _list3D;

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
        /// 2D and 3D values will not be set for an array created with this method.
        /// </summary>
        /// <param name="dim1">The initial first dimension size, may be 1 allowing the array grow as data is added.</param>
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
        /// 3D values will not be set for an array created with this method.
        /// </summary>
        /// <param name="dim1">The initial first dimension size, may be 1 allowing the array grow as data is added.</param>
        /// <param name="dim2">The initial second dimension size, may be 1 allowing the array grow as data is added.</param>
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
        /// <param name="dim1">The initial first dimension size, may be 1 allowing the array grow as data is added.</param>
        /// <param name="dim2">The initial second dimension size, may be 1 allowing the array grow as data is added.</param>
        /// <param name="dim3">The initial third dimension size, may be 1 allowing the array grow as data is added.</param>
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
            if (_list3D.Dimension < 2) return 0;
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
            if (_list3D.Dimension < 3) return 0;
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
        /// Read a CSV (comma separated values) file into a 2D FastArray array.
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

            string arrayName = Add();
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";

            _list3D.ReadCSV(fileName);
            return arrayName;
        }

        /// <summary>
        /// Write a 2D FastArray array to a CSV (comma separated values) file.
        /// The deliminator may be changed from a comma using Utilities.CSVdeliminator
        /// </summary>
        /// <param name="arrayName">
        /// The 2D array name.
        /// </param>
        /// <param name="fileName">
        /// The full path of the CSV file.
        /// </param>
        public static void WriteCSV(Primitive arrayName, Primitive fileName)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return;

            _list3D.WriteCSV(fileName);
        }

        /// <summary>
        /// Convert a SmallBasic array (up to 3 dimensions) to a FastArray array.
        /// All indices in the Small Basic array are replaced with consecutive integer indices.
        /// </summary>
        /// <param name="sbArray">The Small Basic array.</param>
        /// <returns>A new FastArray or "".</returns>
        public static Primitive FromSB(Primitive sbArray)
        {
            string arrayName = Add();
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";

            _list3D.FromSB(sbArray, true);
            return arrayName;
        }

        /// <summary>
        /// Convert a SmallBasic array (up to 3 dimensions) to a FastArray array.
        /// This method creates an array only containing the Small Basic array indices.
        /// </summary>
        /// <param name="sbArray">The Small Basic array.</param>
        /// <returns>A new FastArray or "".</returns>
        public static Primitive FromSBIndices(Primitive sbArray)
        {
            string arrayName = Add();
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";

            _list3D.FromSB(sbArray, false);
            return arrayName;
        }

        /// <summary>
        /// Convert a FastArray array to a Small Basic array.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <returns>A Small Basic array or "".</returns>
        public static Primitive ToSB(Primitive arrayName)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";

            return _list3D.ToSB();
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

        /// <summary>
        /// Save an array to a file.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="fileName">The full path of the file.</param>
        /// <param name="binary">Binary ("True") or text ("False") formatted file.</param>
        public static void Write(Primitive arrayName, Primitive fileName, Primitive binary)
        {
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return;
            _list3D.Write(fileName, binary);
        }

        /// <summary>
        /// Create a new array and initialise it from a file.
        /// </summary>
        /// <param name="fileName">The full path of the file.</param>
        /// <param name="binary">Binary ("True") or text ("False") formatted file.</param>
        /// <returns>The array name.</returns>
        public static Primitive Read(Primitive fileName, Primitive binary)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }

            string arrayName = Add();
            if (!_listMap.TryGetValue(arrayName, out _list3D)) return "";
            _list3D.Read(fileName, binary);
            return arrayName;
        }
    }
}
