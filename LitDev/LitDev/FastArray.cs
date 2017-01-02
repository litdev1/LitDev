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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace LitDev
{
    public class ListXD
    {
        private class ListGen : List<ListGen>
        {
            public Primitive Value;
        }

        private string name;
        private ListGen listGenMain;
        private ListGen listGen;
        private FieldInfo _fieldInfo = typeof(Primitive).GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance);
        private const int MAXDIM = 100;
        private const int zero = '0';
        private const int nine = '9';

        private static Thread applicationThread = Thread.CurrentThread;
        private static StackTrace stackTrace = new StackTrace(applicationThread, false);
        private static StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
        private static MethodBase method = frame.GetMethod();
        private static Type type = method.DeclaringType;
        private static FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.NonPublic);

        public int numIndex;
        public int[] index = new int[MAXDIM];
        public string indexNames = string.Empty;
        public List<Func<Primitive>> indexSB = new List<Func<Primitive>>();

        public string Name { get { return name; } }

        private void DimensionRecursion(ListGen list, int parentDimension, ref int maxDimension)
        {
            if (list.Count > 0)
            {
                maxDimension = System.Math.Max(maxDimension, parentDimension + 1);
                for (int i = 0; i < list.Count; i++)
                {
                    DimensionRecursion(list[i], parentDimension + 1, ref maxDimension);
                }
            }
        }
        public int Dimension()
        {
            listGen = listGenMain;
            int maxDimension = 0;
            DimensionRecursion(listGenMain, 0, ref maxDimension);
            return maxDimension;
        }

        public ListXD()
        {
            NewName();
            listGenMain = new ListGen();
        }

        private void NewName()
        {
            int i = 1;
            while (LDFastArray.listXMap.ContainsKey("FastArray" + i)) i++;
            name = "FastArray" + i;
        }

        private void SetIndexNames(string indexNames)
        {
            try
            {
                if (this.indexNames == indexNames) return;

                this.indexNames = indexNames;
                indexSB.Clear();
                string[] labels = indexNames.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                numIndex = labels.Length;
                for (int i = 0; i < numIndex; i++)
                {
                    bool bFound = false;
                    foreach (FieldInfo info in fields)
                    {
                        if (String.Compare(info.Name, labels[i], StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            Func<Primitive> func = FastThread.CreateGetter<Primitive>(info);
                            indexSB.Add(func);
                            bFound = true;
                        }
                    }
                    if (!bFound)
                    {
                        Exception ex = new Exception("Variable " + labels[i] + " could not be found");
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        public void SetIndices(string indices)
        {
            try
            {
                //string[] split = indices.Split(new char[] { ' ' });
                //numIndex = split.Length;
                //for (int i = 0; i < numIndex; i++) index[i] = int.Parse(split[i]);
                //return;

                if (indices.Length == 0 || indexNames == indices)
                {
                    numIndex = indexSB.Count;
                    for (int i = 0; i < numIndex; i++)
                    {
                        index[i] = indexSB[i]();
                    }
                }
                else if (indices[0] < zero || indices[0] > nine)
                {
                    SetIndexNames(indices);
                    numIndex = indexSB.Count;
                    for (int i = 0; i < numIndex; i++)
                    {
                        index[i] = indexSB[i]();
                    }
                }
                else
                {
                    numIndex = 0;
                    int ind = 0;
                    for (int i = 0; i < indices.Length; i++)
                    {
                        if (indices[i] < zero || indices[i] > nine)
                        {
                            if (ind > 0) index[numIndex++] = ind;
                            ind = 0;
                        }
                        else
                        {
                            ind = ind * 10 + indices[i] - zero;
                        }
                    }
                    if (ind > 0) index[numIndex++] = ind;
                }
            }
            catch
            {
            }
        }

        public void Set(Primitive value)
        {
            try
            {
                listGen = listGenMain;
                for (int i = 0; i < numIndex; i++)
                {
                    int ind = index[i];
                    for (int j = listGen.Count; j < ind; j++)
                    {
                        listGen.Add(new ListGen());
                    }
                    listGen = listGen[ind - 1];
                }
                listGen.Value = value;
            }
            catch
            {
            }
        }

        public Primitive Get()
        {
            try
            {
                listGen = listGenMain;
                for (int i = 0; i < numIndex; i++)
                {
                    listGen = listGen[index[i] - 1];
                }
                return listGen.Value;
            }
            catch
            {
                return "";
            }
        }

        public int Size()
        {
            try
            {
                listGen = listGenMain;
                for (int i = 0; i < numIndex; i++)
                {
                    listGen = listGen[index[i] - 1];
                }
                return listGen.Count;
            }
            catch
            {
                return 0;
            }
        }

        private void CollapseRecursion(ListGen listFrom)
        {
            for (int i = listFrom.Count - 1; i >= 0; i--)
            {
                if (listFrom[i].Count == 0 && listFrom[i].Value == "")
                {
                    listFrom.RemoveAt(i);
                    continue;
                }
                CollapseRecursion(listFrom[i]);
            }
        }
        public void Collapse()
        {
            Primitive result = "";
            CollapseRecursion(listGenMain);
        }

        private void WriteRecursion(ListGen listFrom, BinaryWriter bw)
        {
            bw.Write(listFrom.Count);
            if (listFrom.Count == 0)
            {
                bw.Write((string)listFrom.Value);
            }
            for (int i = 0; i < listFrom.Count; i++)
            {
                WriteRecursion(listFrom[i], bw);
            }
        }
        private void WriteRecursion(ListGen listFrom, StreamWriter sw, string line)
        {
            for (int i = 0; i < listFrom.Count; i++)
            {
                string newline = line + (i + 1).ToString() + " ";
                if (listFrom[i].Count == 0)
                {
                    newline += ": " + listFrom[i].Value;
                    sw.WriteLine(newline);
                }
                else
                {
                    WriteRecursion(listFrom[i], sw, newline);
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
                            WriteRecursion(listGenMain, bw);
                        }
                    }
                }
                else
                {
                    using (FileStream fs = System.IO.File.Open(fileName, FileMode.Create))
                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                        {
                            string line = "";
                            WriteRecursion(listGenMain, sw, line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void ReadRecursion(ListGen listTo, BinaryReader br)
        {
            int num = br.ReadInt32();
            if (num == 0)
            {
                listTo.Value = br.ReadString();
            }
            for (int i = 0; i < num; i++)
            {
                listTo.Add(new ListGen());
                ReadRecursion(listTo[i], br);
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
                            listGenMain.Clear();
                            ReadRecursion(listGenMain, br);
                        }
                    }
                }
                else
                {
                    using (FileStream fs = System.IO.File.Open(fileName, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                        {
                            listGenMain.Clear();
                            while (sr.Peek() >= 0)
                            {
                                string line = sr.ReadLine();
                                string[] split = line.Split(' ');
                                listGen = listGenMain;
                                for (int i = 0; i < split.Length; i++)
                                {
                                    if (split[i] == ":")
                                    {
                                        for (int j = i+1; j < split.Length; j++) listGen.Value += split[j];
                                        break;
                                    }
                                    else
                                    {
                                        int ind = int.Parse(split[i]);
                                        for (int j = listGen.Count; j < ind; j++)
                                        {
                                            listGen.Add(new ListGen());
                                        }
                                        listGen = listGen[ind - 1];
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

        private void FromSBRecursion(Primitive sbArray, ListGen listTo, bool bValues)
        {
            Dictionary<Primitive, Primitive> _arrayMap = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(sbArray));
            if (_arrayMap.Count > 0)
            {
                foreach (KeyValuePair<Primitive, Primitive> kvp in _arrayMap)
                {
                    Dictionary<Primitive, Primitive> _arrayMap1 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(kvp.Value));
                    listGen = new ListGen();
                    listTo.Add(listGen);
                    if (_arrayMap1.Count > 0)
                    {
                        FromSBRecursion(kvp.Value, listGen, bValues);
                    }
                    else
                    {
                        listGen.Value = bValues ? kvp.Value : kvp.Key;
                    }
                }
            }
            else
            {
                if (bValues) listTo.Value = sbArray;
            }
        }
        public void FromSB(Primitive sbArray, bool bValues)
        {
            try
            {
                listGenMain = new ListGen();
                FromSBRecursion(sbArray, listGenMain, bValues);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private Primitive ToSBRecursion(ListGen listFrom, Primitive result)
        {
            if (listFrom.Count == 0)
            {
                result = listFrom.Value;
            }
            else
            {
                for (int i = 0; i < listFrom.Count; i++)
                {
                    Primitive newResult = "";
                    result[i + 1] = ToSBRecursion(listFrom[i], newResult);
                }
            }
            return result;
        }
        public Primitive ToSB()
        {
            try
            {
                Primitive result = "";
                return Utilities.CreateArrayMap(ToSBRecursion(listGenMain, result));
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        private void CopyRecursion(ListGen listFrom, ListGen listTo)
        {
            for (int i = 0; i < listFrom.Count; i++)
            {
                listTo.Add(new ListGen());
                listTo[i].Value = listFrom[i].Value;
                CopyRecursion(listFrom[i], listTo[i]);
            }
        }
        public ListXD Copy()
        {
            ListXD copy = new ListXD();
            CopyRecursion(listGenMain, copy.listGenMain);
            return copy;
        }

        public void Clear()
        {
            listGenMain.Clear();
        }

        public void WriteCSV(string fileName)
        {
            try
            {
                string[] output = new string[listGenMain.Count];

                for (int iRow = 0; iRow < listGenMain.Count; iRow++)
                {
                    listGen = listGenMain[iRow];
                    for (int iCol = 0; iCol < listGen.Count; iCol++)
                    {
                        output[iRow] += Utilities.CSVParse(listGen[iCol].Value, true) + Utilities.CSV;
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

                listGenMain.Clear();
                ListGen listGen1, listGen2;

                for (int iRow = 0; iRow < numRow; iRow++)
                {
                    listGen1 = new ListGen();
                    listGenMain.Add(listGen1);
                    row = rowOrdered[iRow];
                    for (int iCol = 0; iCol < row.Length; iCol++)
                    {
                        listGen2 = new ListGen();
                        listGen1.Add(listGen2);
                        listGen2.Value = Utilities.CSVParse(row[iCol], false);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
    }

    //public class List3D
    //{
    //    private string name;
    //    private List<List<List<Primitive>>> list3D;
    //    private List<List<Primitive>> list2D;
    //    private List<Primitive> list1D;
    //    private int dimension;

    //    public string Name { get { return name; } }

    //    public int Dimension { get { return dimension; } }

    //    public List3D(int dimension = 3)
    //    {
    //        this.dimension = dimension;
    //        NewName();
    //        list3D = new List<List<List<Primitive>>>();
    //    }

    //    private void NewName()
    //    {
    //        int i = 1;
    //        while (LDFastArray.listMap.ContainsKey("FastArray" + i)) i++;
    //        name = "FastArray" + i;
    //    }

    //    private void Grow(int index1, int index2, int index3)
    //    {
    //        for (int i = list3D.Count; i < index1; i++)
    //        {
    //            list2D = new List<List<Primitive>>();
    //            list3D.Add(list2D);
    //            list1D = new List<Primitive>();
    //            list2D.Add(list1D);
    //            list1D.Add("");
    //        }
    //        if (dimension == 1) return;

    //        list2D = list3D[index1 - 1];
    //        for (int j = list2D.Count; j < index2; j++)
    //        {
    //            list1D = new List<Primitive>();
    //            list2D.Add(list1D);
    //            list1D.Add("");
    //        }
    //        if (dimension == 2) return;

    //        list1D = list2D[index2 - 1];
    //        for (int k = list1D.Count; k < index3; k++)
    //        {
    //            list1D.Add("");
    //        }
    //    }

    //    public void Set(Primitive value, int index1, int index2 = 1, int index3 = 1)
    //    {
    //        try
    //        {
    //            Grow(index1, index2, index3);
    //            list3D[index1 - 1][index2 - 1][index3 - 1] = value;
    //        }
    //        catch
    //        {
    //        }
    //    }

    //    public Primitive Get(int index1, int index2 = 1, int index3 = 1)
    //    {
    //        try
    //        {
    //            return list3D[index1 - 1][index2 - 1][index3 - 1];
    //        }
    //        catch
    //        {
    //            return "";
    //        }
    //    }

    //    public int Dim1()
    //    {
    //        return list3D.Count;
    //    }

    //    public int Dim2(int index1 = 1)
    //    {
    //        if (index1 > list3D.Count) return 0;
    //        list2D = list3D[index1 - 1];
    //        return list2D.Count;
    //    }

    //    public int Dim3(int index1 = 1, int index2 = 1)
    //    {
    //        if (index1 > list3D.Count) return 0;
    //        list2D = list3D[index1 - 1];
    //        if (index2 > list2D.Count) return 0;
    //        list1D = list2D[index2 - 1];
    //        return list1D.Count;
    //    }

    //    public void Clear()
    //    {
    //        list3D.Clear();
    //    }

    //    public void Collapse()
    //    {
    //        for (int i = list3D.Count - 1; i >= 0; i--)
    //        {
    //            list2D = list3D[i];
    //            for (int j = list2D.Count - 1; j >= 0; j--)
    //            {
    //                list1D = list2D[j];
    //                list1D.RemoveAll(item => item == "");
    //                if (list1D.Count == 0)
    //                {
    //                    list2D.RemoveAt(j);
    //                }
    //            }
    //            if (list2D.Count == 0)
    //            {
    //                list3D.RemoveAt(i);
    //            }
    //        }
    //    }

    //    public void Write(string fileName, bool binary)
    //    {
    //        try
    //        {
    //            if (binary)
    //            {
    //                using (FileStream fs = System.IO.File.Open(fileName, FileMode.Create))
    //                {
    //                    using (BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8))
    //                    {
    //                        bw.Write(dimension);

    //                        bw.Write(list3D.Count);
    //                        for (int i = 0; i < list3D.Count; i++)
    //                        {
    //                            list2D = list3D[i];
    //                            bw.Write(list2D.Count);
    //                            for (int j = 0; j < list2D.Count; j++)
    //                            {
    //                                list1D = list2D[j];
    //                                bw.Write(list1D.Count);
    //                                for (int k = 0; k < list1D.Count; k++)
    //                                {
    //                                    bw.Write(0);
    //                                    bw.Write((string)list1D[k]);
    //                                }
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                using (FileStream fs = System.IO.File.Open(fileName, FileMode.Create))
    //                {
    //                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
    //                    {
    //                        string line;
    //                        sw.WriteLine(dimension);
    //                        for (int i = 0; i < list3D.Count; i++)
    //                        {
    //                            list2D = list3D[i];
    //                            for (int j = 0; j < list2D.Count; j++)
    //                            {
    //                                list1D = list2D[j];
    //                                for (int k = 0; k < list1D.Count; k++)
    //                                {
    //                                    switch (dimension)
    //                                    {
    //                                        case 1:
    //                                            line = (i + 1) + " " + list1D[k];
    //                                            sw.WriteLine(line);
    //                                            break;
    //                                        case 2:
    //                                            line = (i + 1) + " " + (j + 1) + " " + list1D[k];
    //                                            sw.WriteLine(line);
    //                                            break;
    //                                        default:
    //                                            line = (i + 1) + " " + (j + 1) + " " + (k + 1) + " " + list1D[k];
    //                                            sw.WriteLine(line);
    //                                            break;
    //                                    }
    //                                }
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
    //        }
    //    }

    //    public void Read(string fileName, bool binary)
    //    {
    //        try
    //        {
    //            if (binary)
    //            {
    //                using (FileStream fs = System.IO.File.Open(fileName, FileMode.Open))
    //                {
    //                    using (BinaryReader br = new BinaryReader(fs, Encoding.UTF8))
    //                    {
    //                        dimension = br.ReadInt32();

    //                        list3D.Clear();
    //                        int num1 = br.ReadInt32();
    //                        for (int i = 0; i < num1; i++)
    //                        {
    //                            list2D = new List<List<Primitive>>();
    //                            list3D.Add(list2D);
    //                            int num2 = br.ReadInt32();
    //                            for (int j = 0; j < num2; j++)
    //                            {
    //                                list1D = new List<Primitive>();
    //                                list2D.Add(list1D);
    //                                int num3 = br.ReadInt32();
    //                                for (int k = 0; k < num3; k++)
    //                                {
    //                                    int num4 = br.ReadInt32();
    //                                    list1D.Add(br.ReadString());
    //                                }
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                using (FileStream fs = System.IO.File.Open(fileName, FileMode.Open))
    //                {
    //                    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
    //                    {
    //                        int i, j, k;
    //                        string value;
    //                        list3D.Clear();
    //                        dimension = int.Parse(sr.ReadLine());
    //                        while (sr.Peek() >= 0)
    //                        {
    //                            string line = sr.ReadLine();
    //                            string[] split = line.Split(' ');
    //                            switch (dimension)
    //                            {
    //                                case 1:
    //                                    {
    //                                        i = int.Parse(split[0]);
    //                                        value = "";
    //                                        for (int l = 1; l < split.Length; l++) value += split[l];
    //                                        Set(value, i);
    //                                    }
    //                                    break;
    //                                case 2:
    //                                    {
    //                                        i = int.Parse(split[0]);
    //                                        j = int.Parse(split[1]);
    //                                        value = "";
    //                                        for (int l = 2; l < split.Length; l++) value += split[l];
    //                                        Set(value, i, j);
    //                                    }
    //                                    break;
    //                                default:
    //                                    {
    //                                        i = int.Parse(split[0]);
    //                                        j = int.Parse(split[1]);
    //                                        k = int.Parse(split[2]);
    //                                        value = "";
    //                                        for (int l = 3; l < split.Length; l++) value += split[l];
    //                                        Set(value, i, j, k);
    //                                    }
    //                                    break;
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
    //        }
    //    }

    //    public void WriteCSV(string fileName)
    //    {
    //        try
    //        {
    //            string[] output = new string[Dim1()];

    //            for (int iRow = 0; iRow < Dim1(); iRow++)
    //            {
    //                for (int iCol = 0; iCol < Dim2(iRow + 1); iCol++)
    //                {
    //                    output[iRow] += Utilities.CSVParse(Get(iRow + 1, iCol + 1), true) + Utilities.CSV;
    //                }
    //                if (output[iRow].Length > 0) output[iRow] = output[iRow].Substring(0, output[iRow].Length - 1);
    //            }

    //            System.IO.File.WriteAllLines(fileName, output);
    //        }
    //        catch (Exception ex)
    //        {
    //            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
    //        }
    //    }

    //    public void ReadCSV(string fileName)
    //    {
    //        try
    //        {
    //            string[] input = System.IO.File.ReadAllLines(fileName);

    //            string[] row;
    //            List<string[]> rowOrdered = new List<string[]>();
    //            int numRow = input.Length;
    //            int numCol = 1;

    //            foreach (string line in input)
    //            {
    //                row = line.Split(new string[] { Utilities.CSV }, StringSplitOptions.None);
    //                numCol = System.Math.Max(numCol, row.Length);
    //                rowOrdered.Add(row);
    //            }

    //            list3D.Clear();
    //            dimension = 2;

    //            for (int iRow = 0; iRow < numRow; iRow++)
    //            {
    //                row = rowOrdered[iRow];
    //                for (int iCol = 0; iCol < row.Length; iCol++)
    //                {
    //                    string value = Utilities.CSVParse(row[iCol], false);
    //                    Set(value, iRow + 1, iCol + 1);
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
    //        }
    //    }

    //    public void FromSB(Primitive sbArray, bool bValues)
    //    {
    //        try
    //        {
    //            FieldInfo _fieldInfo = typeof(Primitive).GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance);
    //            Dictionary<Primitive, Primitive> _arrayMap1, _arrayMap2, _arrayMap3;

    //            list3D.Clear();
    //            dimension = 0;

    //            int i, j, k;
    //            i = 1;
    //            _arrayMap1 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(sbArray));
    //            if (_arrayMap1.Count > 0)
    //            {
    //                dimension = System.Math.Max(dimension, 1);
    //                foreach (KeyValuePair<Primitive, Primitive> kvp1 in _arrayMap1)
    //                {
    //                    j = 1;
    //                    _arrayMap2 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(kvp1.Value));
    //                    if (_arrayMap2.Count > 0)
    //                    {
    //                        dimension = System.Math.Max(dimension, 2);
    //                        foreach (KeyValuePair<Primitive, Primitive> kvp2 in _arrayMap2)
    //                        {
    //                            k = 1;
    //                            _arrayMap3 = (Dictionary<Primitive, Primitive>)_fieldInfo.GetValue(Utilities.CreateArrayMap(kvp2.Value));
    //                            if (_arrayMap3.Count > 0)
    //                            {
    //                                dimension = System.Math.Max(dimension, 3);
    //                                foreach (KeyValuePair<Primitive, Primitive> kvp3 in _arrayMap3)
    //                                {
    //                                    Set(bValues ? kvp3.Value : kvp3.Key, i, j, k);
    //                                    k++;
    //                                }
    //                            }
    //                            else
    //                            {
    //                                Set(bValues ? kvp2.Value : kvp2.Key, i, j, k);
    //                            }
    //                            j++;
    //                        }
    //                    }
    //                    else
    //                    {
    //                        Set(bValues ? kvp1.Value : kvp1.Key, i, j);
    //                    }
    //                    i++;
    //                }
    //            }
    //            else
    //            {
    //                if (bValues) Set(sbArray, i);
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
    //        }
    //    }

    //    public Primitive ToSB()
    //    {
    //        try
    //        {
    //            Primitive result = "";
    //            for (int i = 0; i < Dim1(); i++)
    //            {
    //                if (Dim2(i + 1) == 1 && Dim3(i + 1) == 1)
    //                {
    //                    result[i + 1] = Get(i + 1);
    //                }
    //                else
    //                {
    //                    Primitive result1 = "";
    //                    for (int j = 0; j < Dim2(i + 1); j++)
    //                    {
    //                        if (Dim3(i + 1, j + 1) == 1)
    //                        {
    //                            result1[j + 1] = Get(i + 1, j + 1);
    //                        }
    //                        else
    //                        {
    //                            Primitive result2 = "";
    //                            for (int k = 0; k < Dim3(i + 1, j + 1); k++)
    //                            {
    //                                result2[k + 1] = Get(i + 1, j + 1, k + 1);
    //                            }
    //                            result1[j + 1] = result2;
    //                        }
    //                    }
    //                    result[i + 1] = result1;
    //                }
    //            }
    //            return Utilities.CreateArrayMap(result);
    //        }
    //        catch (Exception ex)
    //        {
    //            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
    //            return "";
    //        }
    //    }

    //    public List3D Copy()
    //    {
    //        List3D copy = new List3D(dimension);
    //        for (int i = 0; i < list3D.Count; i++)
    //        {
    //            list2D = list3D[i];
    //            for (int j = 0; j < list2D.Count; j++)
    //            {
    //                list1D = list2D[j];
    //                for (int k = 0; k < list1D.Count; k++)
    //                {
    //                    copy.Set(list1D[k], i, j, k);
    //                }
    //            }
    //        }
    //        return copy;
    //    }
    //}

    /// <summary>
    /// This object provides another faster way of storing values in an Array.
    /// It can handle 1, 2, 3 and higher dimensional arrays and has methods to read and write arrays to files, including in CSV format.
    /// It is also possible for different rows in an array to have different dimensions or numbers of elements (jagged array), just like Small Basic arrays.
    /// Internally it uses lists that allow the sizes to grow so that the array dimension or size doesn't need to be set at the start.
    /// The indexing is by integer starting from 1.
    /// For 1D arrays it is recommended to use LDList since it has additional sort methods.
    /// Elements in arrays with dimension greater than 3 are indexed by a comma separated list of indices or index variable names.
    /// </summary>
    [SmallBasicType]
    public static class LDFastArray
    {
        public static Dictionary<string, ListXD> listXMap = new Dictionary<string, ListXD>();
        private static ListXD listXD;

        /// <summary>
        /// Create a new array.
        /// This is a general array that can be used as a 1D, 2D, 3D or higher dimension array, depending on the data set.
        /// </summary>
        /// <returns>The array name.</returns>
        public static Primitive Add()
        {
            listXD = new ListXD();
            listXMap[listXD.Name] = listXD;
            return listXD.Name;
        }

        ///// <summary>
        ///// To improve performance, especially for high dimension arrays, the variables used for array indexing in Set and Get can be preset.
        ///// This should be done once, after the array is created.
        ///// The variables (e.g. i, j, k) must be correctly set before a Set or Get.
        ///// </summary>
        ///// <param name="arrayName">The array name.</param>
        ///// <param name="varNames">A comma (or space) separated list of variable names that contain index values.
        ///// e.g. "i,j,k"</param>
        //public static void SetIndexNames(Primitive arrayName, Primitive varNames)
        //{
        //    if (!listXMap.TryGetValue(arrayName, out listXD)) return;
        //    listXD.SetIndexNames(varNames);
        //}

        /// <summary>
        /// Set a value.
        /// Set1D, Set2D or Set3D methods are marginally faster for lower dimension arrays.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="indices">A comma (or space) separated list of index values (slower) or index variable names (faster).
        /// e.g. "3,2,6" or "i,j,k"
        /// If this is set to "", then previously set index variables are used.</param>
        /// <param name="value">The value to set.</param>
        public static void Set(Primitive arrayName, Primitive indices, Primitive value)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return;
            listXD.SetIndices(indices);
            listXD.Set(value);
        }

        /// <summary>
        /// Set a 1D value.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="index1">The first dimension integer index.</param>
        /// <param name="value">The value to set.</param>
        public static void Set1D(Primitive arrayName, Primitive index1, Primitive value)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return;
            listXD.numIndex = 1;
            listXD.index[0] = index1;
            listXD.Set(value);
        }

        /// <summary>
        /// Set a 2D value.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="index1">The first dimension integer index.</param>
        /// <param name="index2">The second dimension integer index.</param>
        /// <param name="value">The value to set.</param>
        public static void Set2D(Primitive arrayName, Primitive index1, Primitive index2, Primitive value)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return;
            listXD.numIndex = 2;
            listXD.index[0] = index1;
            listXD.index[1] = index2;
            listXD.Set(value);
        }

        /// <summary>
        /// Set a 3D value.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="index1">The first dimension integer index.</param>
        /// <param name="index2">The second dimension integer index.</param>
        /// <param name="index3">The third dimension integer index.</param>
        /// <param name="value">The value to set.</param>
        public static void Set3D(Primitive arrayName, Primitive index1, Primitive index2, Primitive index3, Primitive value)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return;
            listXD.numIndex = 3;
            listXD.index[0] = index1;
            listXD.index[1] = index2;
            listXD.index[2] = index3;
            listXD.Set(value);
        }

        /// <summary>
        /// Get a value.
        /// Get1D, Get2D or Get3D methods are marginally faster for lower dimension arrays.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="indices">A comma (or space) separated list of index values (slower) or index variable names (faster).
        /// e.g. "3,2,6" or "i,j,k"
        /// If this is set to "", then previously set index variables are used.</param>
        /// <returns>The array value or "" on failure.</returns>
        public static Primitive Get(Primitive arrayName, Primitive indices)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";
            listXD.SetIndices(indices);
            return listXD.Get();
        }

        /// <summary>
        /// Get a 1D value.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="index1">The first dimension integer index.</param>
        /// <returns>The array value or "" on failure.</returns>
        public static Primitive Get1D(Primitive arrayName, Primitive index1)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";
            listXD.numIndex = 1;
            listXD.index[0] = index1;
            return listXD.Get();
        }

        /// <summary>
        /// Get a 2D value.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="index1">The first dimension integer index.</param>
        /// <param name="index2">The second dimension integer index.</param>
        /// <returns>The array value or "" on failure.</returns>
        public static Primitive Get2D(Primitive arrayName, Primitive index1, Primitive index2)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";
            listXD.numIndex = 2;
            listXD.index[0] = index1;
            listXD.index[1] = index2;
            return listXD.Get();
        }

        /// <summary>
        /// Get a 3D value.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="index1">The first dimension integer index.</param>
        /// <param name="index2">The second dimension integer index.</param>
        /// <param name="index3">The third dimension integer index.</param>
        /// <returns>The array value or "" on failure.</returns>
        public static Primitive Get3D(Primitive arrayName, Primitive index1, Primitive index2, Primitive index3)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";
            listXD.numIndex = 3;
            listXD.index[0] = index1;
            listXD.index[1] = index2;
            listXD.index[2] = index3;
            return listXD.Get();
        }

        /// <summary>
        /// Get the current size of a dimension.
        /// Size1, Size2 or Size3 methods are marginally faster for lower dimension arrays.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="indices">A comma (or space) separated list of indices.
        /// e.g. "" for first dimension or "3" for second dimension of 3rd element in first dimension.</param>
        /// <returns>The dimension size.</returns>
        public static Primitive Size(Primitive arrayName, Primitive indices)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";
            listXD.SetIndices(indices);
            return listXD.Size();
        }

        /// <summary>
        /// Get the current size of the first dimension.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <returns>The dimension size.</returns>
        public static Primitive Size1(Primitive arrayName)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";
            listXD.numIndex = 0;
            return listXD.Size();
        }

        /// <summary>
        /// Get the current size of the second dimension.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="index1">The first index to get the size of, may be 1 if all rows have the same size.</param>
        /// <returns>The dimension size.</returns>
        public static Primitive Size2(Primitive arrayName, Primitive index1)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";
            listXD.numIndex = 1;
            listXD.index[0] = index1;
            return listXD.Size();
        }

        /// <summary>
        /// Get the current size of the third dimension.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="index1">The first index to get the size of, may be 1 if all rows have the same size.</param>
        /// <param name="index2">The second index to get the size of, may be 1 if all rows have the same size.</param>
        /// <returns>The dimension size.</returns>
        public static Primitive Size3(Primitive arrayName, Primitive index1, Primitive index2)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";
            listXD.numIndex = 2;
            listXD.index[0] = index1;
            listXD.index[1] = index2;
            return listXD.Size();
        }

        /// <summary>
        /// Get the dimension of an array.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <returns>The array dimension.</returns>
        public static Primitive Dimension(Primitive arrayName)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return 0;
            return listXD.Dimension();
        }

        /// <summary>
        /// Delete an array.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        public static void Remove(Primitive arrayName)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return;
            listXD.Clear();
            listXMap.Remove(arrayName);
        }

        /// <summary>
        /// Read a CSV (comma separated values) file into a 2D FastArray array.
        /// The deliminator may be changed from a comma using Utilities.CSVdeliminator
        /// </summary>
        /// <param name="fileName">The full path of the CSV file.</param>
        /// <returns>A 2D FastArray with CSV file imported or "".</returns>
        public static Primitive ReadCSV(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }

            string arrayName = Add();
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";

            listXD.ReadCSV(fileName);
            return arrayName;
        }

        /// <summary>
        /// Write a 2D FastArray array to a CSV (comma separated values) file.
        /// The deliminator may be changed from a comma using Utilities.CSVdeliminator
        /// </summary>
        /// <param name="arrayName">The 2D array name.</param>
        /// <param name="fileName">The full path of the CSV file.</param>
        public static void WriteCSV(Primitive arrayName, Primitive fileName)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return;

            listXD.WriteCSV(fileName);
        }

        /// <summary>
        /// Convert a SmallBasic array to a FastArray array.
        /// All indices in the Small Basic array are replaced with consecutive integer indices.
        /// </summary>
        /// <param name="sbArray">The Small Basic array.</param>
        /// <returns>A new FastArray or "".</returns>
        public static Primitive CreateFromValues(Primitive sbArray)
        {
            string arrayName = Add();
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";

            listXD.FromSB(sbArray, true);
            return arrayName;
        }

        /// <summary>
        /// Convert a SmallBasic array (up to 3 dimensions) to a FastArray array.
        /// This method creates an array only containing the Small Basic array indices.
        /// </summary>
        /// <param name="sbArray">The Small Basic array.</param>
        /// <returns>A new FastArray or "".</returns>
        public static Primitive CreateFromIndices(Primitive sbArray)
        {
            string arrayName = Add();
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";

            listXD.FromSB(sbArray, false);
            return arrayName;
        }

        /// <summary>
        /// Convert a FastArray array to a Small Basic array.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <returns>A Small Basic array or "".</returns>
        public static Primitive ToArray(Primitive arrayName)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";

            return listXD.ToSB();
        }

        /// <summary>
        /// Remove all empty "" entries in an array.
        /// Note that indices or even dimensions may change if public entries are removed.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        public static void Collapse(Primitive arrayName)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return;
            listXD.Collapse();
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
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";
            listXD.Read(fileName, binary);
            return arrayName;
        }

        /// <summary>
        /// Save an array to a file.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <param name="fileName">The full path of the file.</param>
        /// <param name="binary">Binary ("True") or text ("False") formatted file.</param>
        public static void Write(Primitive arrayName, Primitive fileName, Primitive binary)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return;
            listXD.Write(fileName, binary);
        }

        /// <summary>
        /// Copy an array.
        /// </summary>
        /// <param name="arrayName">The array name.</param>
        /// <returns>A copy of the array.</returns>
        public static Primitive Copy(Primitive arrayName)
        {
            if (!listXMap.TryGetValue(arrayName, out listXD)) return "";

            ListXD ListXDCopy = listXD.Copy();
            listXMap[ListXDCopy.Name] = ListXDCopy;
            return ListXDCopy.Name;
        }

        #region List3D Methods

        //public static Dictionary<string, List3D> listMap = new Dictionary<string, List3D>();
        //private static List3D list3D;

        ///// <summary>
        ///// Create a new array.
        ///// This is a general array that can be used as a 1D, 2D or 3D array, depending on the data set.
        ///// For most cases this is the best array constructor.
        ///// </summary>
        ///// <returns>The array name.</returns>
        //public static Primitive _Add()
        //{
        //    list3D = new List3D();
        //    listMap[list3D.Name] = list3D;
        //    return list3D.Name;
        //}

        ///// <summary>
        ///// Create a new 1D array.
        ///// 2D or 3D values will not be set for an array created with this method.
        ///// </summary>
        ///// <returns>The 1D array name.</returns>
        //public static Primitive _Add1D()
        //{
        //    list3D = new List3D(1);
        //    listMap[list3D.Name] = list3D;
        //    return list3D.Name;
        //}

        ///// <summary>
        ///// Create a new 2D array.
        ///// 3D values will not be set for an array created with this method.
        ///// </summary>
        ///// <returns>The 2D array name.</returns>
        //public static Primitive _Add2D()
        //{
        //    list3D = new List3D(2);
        //    listMap[list3D.Name] = list3D;
        //    return list3D.Name;
        //}

        ///// <summary>
        ///// Set a value in a 1D array.
        ///// </summary>
        ///// <param name="arrayName">The 1D array name.</param>
        ///// <param name="index1">The first dimension integer index.</param>
        ///// <param name="value">The value to set.</param>
        //public static void _Set1D(Primitive arrayName, Primitive index1, Primitive value)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return;
        //    list3D.Set(value, index1);
        //}

        ///// <summary>
        ///// Set a value in a 2D array.
        ///// </summary>
        ///// <param name="arrayName">The 2D array name.</param>
        ///// <param name="index1">The first dimension integer index.</param>
        ///// <param name="index2">The second dimension integer index.</param>
        ///// <param name="value">The value to set.</param>
        //public static void _Set2D(Primitive arrayName, Primitive index1, Primitive index2, Primitive value)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return;
        //    list3D.Set(value, index1, index2);
        //}

        ///// <summary>
        ///// Set a value in a 3D array.
        ///// </summary>
        ///// <param name="arrayName">The 2D array name.</param>
        ///// <param name="index1">The first dimension integer index.</param>
        ///// <param name="index2">The second dimension integer index.</param>
        ///// <param name="index3">The third dimension integer index.</param>
        ///// <param name="value">The value to set.</param>
        //public static void _Set3D(Primitive arrayName, Primitive index1, Primitive index2, Primitive index3, Primitive value)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return;
        //    list3D.Set(value, index1, index2, index3);
        //}

        ///// <summary>
        ///// Get a value from a 1D array.
        ///// </summary>
        ///// <param name="arrayName">The 1D array name.</param>
        ///// <param name="index1">The first dimension integer index.</param>
        ///// <returns>The array value or "" on failure.</returns>
        //public static Primitive _Get1D(Primitive arrayName, Primitive index1)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return "";
        //    return list3D.Get(index1);
        //}

        ///// <summary>
        ///// Get a value from a 2D array.
        ///// </summary>
        ///// <param name="arrayName">The 2D array name.</param>
        ///// <param name="index1">The first dimension integer index.</param>
        ///// <param name="index2">The second dimension integer index.</param>
        ///// <returns>The array value or "" on failure.</returns>
        //public static Primitive _Get2D(Primitive arrayName, Primitive index1, Primitive index2)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return "";
        //    return list3D.Get(index1, index2);
        //}

        ///// <summary>
        ///// Get a value from a 3D array.
        ///// </summary>
        ///// <param name="arrayName">The 3D array name.</param>
        ///// <param name="index1">The first dimension integer index.</param>
        ///// <param name="index2">The second dimension integer index.</param>
        ///// <param name="index3">The third dimension integer index.</param>
        ///// <returns>The array value or "" on failure.</returns>
        //public static Primitive _Get3D(Primitive arrayName, Primitive index1, Primitive index2, Primitive index3)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return "";
        //    return list3D.Get(index1, index2, index3);
        //}

        ///// <summary>
        ///// Get the current size of the first dimension.
        ///// </summary>
        ///// <param name="arrayName">The array name.</param>
        ///// <returns>The first dimension size.</returns>
        //public static Primitive _Dim1(Primitive arrayName)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return "";
        //    return list3D.Dim1();
        //}

        ///// <summary>
        ///// Get the current size of the second dimension.
        ///// </summary>
        ///// <param name="arrayName">The array name.</param>
        ///// <param name="index1">The first index to get the size of, may be 1 if all rows have the same size.</param>
        ///// <returns>The second dimension size.</returns>
        //public static Primitive _Dim2(Primitive arrayName, Primitive index1)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return "";
        //    if (list3D.Dimension < 2) return 0;
        //    return list3D.Dim2(index1);
        //}

        ///// <summary>
        ///// Get the current size of the third dimension.
        ///// </summary>
        ///// <param name="arrayName">The array name.</param>
        ///// <param name="index1">The first index to get the size of, may be 1 if all rows have the same size.</param>
        ///// <param name="index2">The second index to get the size of, may be 1 if all rows have the same size.</param>
        ///// <returns>The third dimension size.</returns>
        //public static Primitive _Dim3(Primitive arrayName, Primitive index1, Primitive index2)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return "";
        //    if (list3D.Dimension < 3) return 0;
        //    return list3D.Dim3(index1, index2);
        //}

        ///// <summary>
        ///// Delete an array.
        ///// </summary>
        ///// <param name="arrayName">The array name.</param>
        //public static void _Remove(Primitive arrayName)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return;
        //    list3D.Clear();
        //    listMap.Remove(arrayName);
        //}

        ///// <summary>
        ///// Read a CSV (comma separated values) file into a 2D FastArray array.
        ///// The deliminator may be changed from a comma using Utilities.CSVdeliminator
        ///// </summary>
        ///// <param name="fileName">
        ///// The full path of the CSV file.
        ///// </param>
        ///// <returns>
        ///// A 2D FastArray with CSV file imported or "".
        ///// </returns>
        //public static Primitive _ReadCSV(Primitive fileName)
        //{
        //    if (!System.IO.File.Exists(fileName))
        //    {
        //        Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
        //        return "";
        //    }

        //    string arrayName = _Add();
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return "";

        //    list3D.ReadCSV(fileName);
        //    return arrayName;
        //}

        ///// <summary>
        ///// Write a 2D FastArray array to a CSV (comma separated values) file.
        ///// The deliminator may be changed from a comma using Utilities.CSVdeliminator
        ///// </summary>
        ///// <param name="arrayName">
        ///// The 2D array name.
        ///// </param>
        ///// <param name="fileName">
        ///// The full path of the CSV file.
        ///// </param>
        //public static void _WriteCSV(Primitive arrayName, Primitive fileName)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return;

        //    list3D.WriteCSV(fileName);
        //}

        ///// <summary>
        ///// Convert a SmallBasic array (up to 3 dimensions) to a FastArray array.
        ///// All indices in the Small Basic array are replaced with consecutive integer indices.
        ///// </summary>
        ///// <param name="sbArray">The Small Basic array.</param>
        ///// <returns>A new FastArray or "".</returns>
        //public static Primitive _CreateFromValues(Primitive sbArray)
        //{
        //    string arrayName = _Add();
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return "";

        //    list3D.FromSB(sbArray, true);
        //    return arrayName;
        //}

        ///// <summary>
        ///// Convert a SmallBasic array (up to 3 dimensions) to a FastArray array.
        ///// This method creates an array only containing the Small Basic array indices.
        ///// </summary>
        ///// <param name="sbArray">The Small Basic array.</param>
        ///// <returns>A new FastArray or "".</returns>
        //public static Primitive _CreateFromIndices(Primitive sbArray)
        //{
        //    string arrayName = _Add();
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return "";

        //    list3D.FromSB(sbArray, false);
        //    return arrayName;
        //}

        ///// <summary>
        ///// Convert a FastArray array to a Small Basic array.
        ///// </summary>
        ///// <param name="arrayName">The array name.</param>
        ///// <returns>A Small Basic array or "".</returns>
        //public static Primitive _ToArray(Primitive arrayName)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return "";

        //    return list3D.ToSB();
        //}

        ///// <summary>
        ///// Remove all empty "" entries in an array.
        ///// Note that indices or even dimensions may change if public entries are removed.
        ///// </summary>
        ///// <param name="arrayName">The array name.</param>
        //public static void _Collapse(Primitive arrayName)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return;
        //    list3D.Collapse();
        //}

        ///// <summary>
        ///// Create a new array and initialise it from a file.
        ///// </summary>
        ///// <param name="fileName">The full path of the file.</param>
        ///// <param name="binary">Binary ("True") or text ("False") formatted file.</param>
        ///// <returns>The array name.</returns>
        //public static Primitive _Read(Primitive fileName, Primitive binary)
        //{
        //    if (!System.IO.File.Exists(fileName))
        //    {
        //        Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
        //        return "";
        //    }

        //    string arrayName = _Add();
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return "";
        //    list3D.Read(fileName, binary);
        //    return arrayName;
        //}

        ///// <summary>
        ///// Save an array to a file.
        ///// </summary>
        ///// <param name="arrayName">The array name.</param>
        ///// <param name="fileName">The full path of the file.</param>
        ///// <param name="binary">Binary ("True") or text ("False") formatted file.</param>
        //public static void _Write(Primitive arrayName, Primitive fileName, Primitive binary)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return;
        //    list3D.Write(fileName, binary);
        //}

        ///// <summary>
        ///// Copy an array.
        ///// </summary>
        ///// <param name="arrayName">The array name.</param>
        ///// <returns>A copy of the array.</returns>
        //public static Primitive _Copy(Primitive arrayName)
        //{
        //    if (!listMap.TryGetValue(arrayName, out list3D)) return "";

        //    List3D List3DCopy = list3D.Copy();
        //    listMap[List3DCopy.Name] = List3DCopy;
        //    return List3DCopy.Name;
        //}

        #endregion
    }
}
