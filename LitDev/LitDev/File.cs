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
using Microsoft.SmallBasic.Library;
using System.Windows;
using System.Windows.Media;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using SBArray = Microsoft.SmallBasic.Library.Array;

namespace LitDev
{
    /// <summary>
    /// File utilities.
    /// </summary>
    [SmallBasicType]
    public static class LDFile
    {
        private static Encoding GetFileEncoding(string fileName)
        {
            // *** Use Default of Encoding.Default (Ansi CodePage)

            Encoding enc = Encoding.Default;

            // *** Detect byte order mark if any - otherwise assume default

            byte[] buffer = new byte[5];
            FileStream file = new FileStream(fileName, FileMode.Open);
            file.Read(buffer, 0, 5);
            file.Close();

            if (buffer[0] == 0xef && buffer[1] == 0xbb && buffer[2] == 0xbf)
                enc = Encoding.UTF8;
            else if (buffer[0] == 0xfe && buffer[1] == 0xff)
                enc = Encoding.Unicode;
            else if (buffer[0] == 0 && buffer[1] == 0 && buffer[2] == 0xfe && buffer[3] == 0xff)
                enc = Encoding.UTF32;
            else if (buffer[0] == 0x2b && buffer[1] == 0x2f && buffer[2] == 0x76)
                enc = Encoding.UTF7;

            return enc;
        }

        private static string ReadEncodedFile(string fileName)
        {
            Encoding encoding = GetFileEncoding(fileName);
            byte[] ansiBytes = System.IO.File.ReadAllBytes(fileName);
            string content = "";
            if (encoding == Encoding.Default)
            {
                content = Encoding.UTF8.GetString(ansiBytes);
                if (content.Contains(replaced)) content = Encoding.Default.GetString(ansiBytes);
            }
            else
            {
                content = encoding.GetString(ansiBytes);
            }
            if (content.Contains(replaced)) return "";
            if (content[0] == 65279) content = content.Substring(1);
            return content;
        }

        private static string replaced = String.Format("{0}", (char)65533);

        private static void CopyFilesRecursively(String SourcePath, String DestinationPath)
        {
            // First create all of the directories
            foreach (string dirPath in Directory.GetDirectories(SourcePath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            // Copy all the files
            foreach (string newPath in Directory.GetFiles(SourcePath, "*.*", SearchOption.AllDirectories))
                System.IO.File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath));
        }

        private static void getDirectories(string dirPath, ref StringBuilder result, ref int i)
        {
            try
            {
                dirPath = Environment.ExpandEnvironmentVariables(dirPath);
                result.Append((i++).ToString() + "=" + Utilities.ArrayParse(dirPath) + ";");

                if ((System.IO.File.GetAttributes(dirPath) & FileAttributes.ReparsePoint) != FileAttributes.ReparsePoint)
                {
                    foreach (string path in Directory.GetDirectories(dirPath))
                    {
                        getDirectories(path, ref result, ref i);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
        }

        [HideFromIntellisense]
        public static Primitive MusicPlayTime(Primitive fileName)
        {
            return LDSound.MusicPlayTime(fileName);
        }

        /// <summary>
        /// Reads a text file into an array with one element for each line in the file.
        /// 
        /// Blank lines are included as an element in the array with one blank space.
        /// </summary>
        /// <param name="fileName">
        /// The full path of the file.
        /// </param>
        /// <returns>
        /// An array with one element for each line in the file.
        /// </returns>
        public static Primitive ReadToArray(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            try
            {
                StreamReader streamReader = new StreamReader(fileName);
                StringBuilder file = new StringBuilder();
                string line;
                int iLine = 1;

                while (!streamReader.EndOfStream)
                {
                    line = streamReader.ReadLine();
                    if (line == "") line = " ";
                    file.AppendFormat("{0}={1};", iLine, Utilities.ArrayParse(line));
                    iLine++;
                }

                streamReader.Close();
                return Utilities.CreateArrayMap(file.ToString());
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Writes a text file from an array with one line in the file for each value in the array.
        /// </summary>
        /// <param name="fileName">
        /// The full path of the file.
        /// </param>
        /// <param name="array">
        /// An array to output to the file.
        /// </param>
        /// <param name="append">
        /// Append to an existing file "True" or over-write "False".
        /// </param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive WriteFromArray(Primitive fileName, Primitive array, Primitive append)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(fileName, append);
                Primitive indices = SBArray.GetAllIndices(array);
                for (int i = 1; i <= SBArray.GetItemCount(indices); i++)
                {
                    streamWriter.WriteLine((string)array[indices[i]]);
                }
                streamWriter.Close();
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Gets the number of lines in a text file.
        /// </summary>
        /// <param name="fileName">
        /// The full path of the file.
        /// </param>
        /// <returns>
        /// The number of lines in the file (-1 on failure).
        /// </returns>
        public static Primitive Length(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return -1;
            }
            try
            {
                return System.IO.File.ReadAllLines(fileName).Length;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return -1;
        }

        /// <summary>
        /// Gets the creation time of a file.
        /// </summary>
        /// <param name="fileName">
        /// The full path of the file.
        /// </param>
        /// <returns>
        /// The creation time of the file or directory ("" on failure).
        /// </returns>
        public static Primitive CreationTime(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            try
            {
                return System.IO.File.GetCreationTime(fileName).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Gets the last time a file was accessed.
        /// </summary>
        /// <param name="fileName">
        /// The full path of the file.
        /// </param>
        /// <returns>
        /// The last access time of the file or directory ("" on failure).
        /// </returns>
        public static Primitive AccessTime(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            try
            {
                return System.IO.File.GetLastAccessTime(fileName).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Gets the last time a file was modified.
        /// </summary>
        /// <param name="fileName">
        /// The full path of the file.
        /// </param>
        /// <returns>
        /// The last modified time of the file or directory ("" on failure).
        /// </returns>
        public static Primitive ModifiedTime(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            try
            {
                return System.IO.File.GetLastWriteTime(fileName).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Read a CSV (comma separated values) file into an array.
        /// The deliminator may be changed from a comma using Utilities.CSVDeliminator
        /// </summary>
        /// <param name="fileName">
        /// The full path of the CSV file.
        /// </param>
        /// <returns>
        /// A 2D array with CSV file imported.
        /// </returns>
        public static Primitive ReadCSV(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            return Utilities.ReadCSV(fileName, false);
        }

        /// <summary>
        /// Read a CSV (comma separated values) file into an array. and transpose (swap rows and columns).
        /// The deliminator may be changed from a comma using Utilities.CSVDeliminator
        /// </summary>
        /// <param name="fileName">
        /// The full path of the CSV file.
        /// </param>
        /// <returns>
        /// 2D array with transposed CSV file imported.
        /// </returns>
        public static Primitive ReadCSVTransposed(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            return Utilities.ReadCSV(fileName, true);
        }

        /// <summary>
        /// Write a 2D array to a CSV (comma separated values) file.
        /// The deliminator may be changed from a comma using Utilities.CSVDeliminator
        /// </summary>
        /// <param name="fileName">
        /// The full path of the CSV file.
        /// </param>
        /// <param name="array">
        /// The array to export.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void WriteCSV(Primitive fileName, Primitive array)
        {
            Utilities.WriteCSV(fileName, array);
        }

        /// <summary>
        /// Character to use in place of empty values in the imported array when reading CSV files.
        /// A SmallBasic array cannot hold an empty value i.e. "".
        /// 
        /// Default is the empty string "" (no array entries created for empty values in the CSV file).
        /// </summary>
        public static Primitive CSVplaceholder
        {
            get { return Utilities.CSVplaceHolder; }
            set { Utilities.CSVplaceHolder = value; }
        }

        /// <summary>
        /// Print a file.
        /// </summary>
        /// <param name="fileName">The full path of the file to print.</param>
        public static void PrintFile(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return;
            }
            Process process = new Process();
            process.StartInfo.FileName = fileName;
            process.StartInfo.Verb = "Print";
            process.Start();
        }

        /// <summary>
        /// Gets the Temp folder path.
        /// </summary>
        public static Primitive TempFolder
        {
            get
            {
                return Environment.GetEnvironmentVariable("TEMP");
            }
        }

        /// <summary>
        /// Gets the current user name.
        /// </summary>
        public static Primitive UserName
        {
            get
            {
                return Environment.UserName;
            }
        }

        /// <summary>
        /// Gets the ApplicationData folder path.
        /// </summary>
        public static Primitive AppDataFolder
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            }
        }

        /// <summary>
        /// Gets the Public folder path.
        /// </summary>
        public static Primitive PublicFolder
        {
            get
            {
                return Environment.GetEnvironmentVariable("PUBLIC");
            }
        }

        /// <summary>
        /// Gets the Documents folder path.
        /// </summary>
        public static Primitive DocumentsFolder
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }

        /// <summary>
        /// Gets the Music folder path.
        /// </summary>
        public static Primitive MusicFolder
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            }
        }

        /// <summary>
        /// Gets the Pictures folder path.
        /// </summary>
        public static Primitive PicturesFolder
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            }
        }

        /// <summary>
        /// Get the folder for a full file path.
        /// </summary>
        /// <param name="fileName">The full path of a file.</param>
        /// <returns>The folder part of the file path.</returns>
        public static Primitive GetFolder(Primitive fileName)
        {
            try
            {
                return Path.GetDirectoryName(fileName);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get the file for a full file path.
        /// </summary>
        /// <param name="fileName">The full path of a file.</param>
        /// <returns>The file name part of the file path (without the folder or the extension).</returns>
        public static Primitive GetFile(Primitive fileName)
        {
            try
            {
                return Path.GetFileNameWithoutExtension(fileName);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get the file extension for a file.
        /// </summary>
        /// <param name="fileName">The file name with extension (may include folder path or not).</param>
        /// <returns>The extension of the file (without the '.') or "" if no extension.</returns>
        public static Primitive GetExtension(Primitive fileName)
        {
            try
            {
                string ext = Path.GetExtension(fileName);
                return ext.Length > 1 ? Path.GetExtension(fileName).Substring(1) : "";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Convert an ANSI encoded text file to UTF8.
        /// It should also work for any other encoding.
        /// UTF8 is the default text file encoding used by Small Basic.
        /// </summary>
        /// <param name="fileName">The file path to convert.</param>
        /// <param name="BOM">Include Byte Order Mark (BOM) in UTF8 file ("True" or "False", no BOM is usual).</param>
        /// <returns>The converted file path (-UTF8.txt) or "" for failure (the encoding may not have been detected correctly).</returns>
        public static Primitive ANSItoUTF8(Primitive fileName, Primitive BOM)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            try
            {
                string content = ReadEncodedFile(fileName);
                if (content == "") return "";
                string resultFile = Path.GetDirectoryName(fileName) + "\\" + Path.GetFileNameWithoutExtension(fileName) + "-UTF8" + Path.GetExtension(fileName);
                if (BOM)
                {
                    using (StreamWriter sw = new StreamWriter(resultFile, false, Encoding.UTF8))
                    {
                        sw.Write(content);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(resultFile, false))
                    {
                        sw.Write(content);
                        sw.Close();
                    }
                }
                return resultFile;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Read an ANSI encoded text file.
        /// It should also work for any other encoding including UTF8.
        /// UTF8 is the default text file encoding used by Small Basic.
        /// </summary>
        /// <param name="fileName">The file path to read.</param>
        /// <returns>The contents of the file or "" for failure (the encoding may not have been detected correctly).</returns>
        public static Primitive ReadANSI(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            try
            {
                return ReadEncodedFile(fileName);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Reads a text file with ANSI encoding into an array with one element for each line in the file.
        /// It should also work for any other encoding including UTF8.
        /// Blank lines are included as an element in the array with one blank space.
        /// </summary>
        /// <param name="fileName">
        /// The full path of the file.
        /// </param>
        /// <returns>
        /// An array with one element for each line in the file or "" for failure (the encoding may not have been detected correctly).
        /// </returns>
        public static Primitive ReadANSIToArray(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            try
            {
                string content = ReadEncodedFile(fileName);
                string[] lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int iLine = 1;
                StringBuilder result = new StringBuilder();

                foreach (string line in lines)
                {
                    result.AppendFormat("{0}={1};", iLine++, Utilities.ArrayParse(line == "" ? " " : line));
                }

                return Utilities.CreateArrayMap(result.ToString());
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Check if a file path is an existing file or directory.
        /// </summary>
        /// <param name="fileName">
        /// The full path of the file or directory.
        /// </param>
        /// <returns>"True" or "False".</returns>
        public static Primitive Exists(Primitive fileName)
        {
            if (System.IO.File.Exists(fileName)) return "True";
            if (Directory.Exists(fileName)) return "True";
            return "False";
        }

        /// <summary>
        /// Save all of the current variables to a file.
        /// This is the complete current state of your program.
        /// May be useful to store a game state, or for debugging.
        /// </summary>
        /// <param name="fileName">The full path to store the variables and their values.
        /// This file will be over-written.</param>
        public static void SaveAllVariables(Primitive fileName)
        {
            try
            {
                StackTrace stackTrace = new StackTrace(Thread.CurrentThread, false);
                StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
                MethodBase method = frame.GetMethod();
                Type type = method.DeclaringType;
                FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
                string path = Environment.ExpandEnvironmentVariables(fileName);
                if (System.IO.File.Exists(path)) System.IO.File.Delete(path);
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    foreach (FieldInfo field in fields)
                    {
                        streamWriter.WriteLine(field.Name + " " + field.GetValue(null));
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Restore the values of all variables that were previously stored using SaveAllVariables.
        /// </summary>
        /// <param name="fileName">The full path to a file with stored variable values.</param>
        public static void LoadAllVariables(Primitive fileName)
        {
            try
            {
                if (!System.IO.File.Exists(fileName))
                {
                    Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                    return;
                }
                StackTrace stackTrace = new StackTrace(Thread.CurrentThread, false);
                StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
                MethodBase method = frame.GetMethod();
                Type type = method.DeclaringType;
                FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
                string path = Environment.ExpandEnvironmentVariables(fileName);
                using (StreamReader streamReader = new StreamReader(path))
                {
                    while (streamReader.Peek() >= 0)
                    {
                        string line = streamReader.ReadLine();
                        int pos = line.IndexOf(" ");
                        string name = line.Substring(0, pos);
                        Primitive var = line.Substring(pos + 1);
                        foreach (FieldInfo field in fields)
                        {
                            if (field.Name == name)
                            {
                                field.SetValue(null, var);
                                break;
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

        /// <summary>
        /// Get the size of a file in bytes.
        /// </summary>
        /// <param name="fileName">The full path to the file to get the size of.</param>
        /// <returns>The number of bytes in the file or -1 on error.</returns>
        public static Primitive Size(Primitive fileName)
        {
            try
            {
                return (decimal)new FileInfo(fileName).Length;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>
        /// Rename or move a file.
        /// </summary>
        /// <param name="fileFrom">The full path to the file to rename.</param>
        /// <param name="fileTo">The full path to the new name for the file.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive RenameFile(Primitive fileFrom, Primitive fileTo)
        {
            try
            {
                if (!System.IO.File.Exists(fileFrom)) return "FAILED";
                if (!Directory.Exists(Path.GetDirectoryName(fileTo))) return "FAILED";
                System.IO.File.Move(fileFrom, fileTo);
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Rename or move a directory.
        /// </summary>
        /// <param name="directoryFrom">The full path to the directory to rename.</param>
        /// <param name="directoryTo">The full path to the new name for the directory.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive RenameDirectory(Primitive directoryFrom, Primitive directoryTo)
        {
            try
            {
                if (!Directory.Exists(directoryFrom)) return "FAILED";
                Directory.Move(directoryFrom, directoryTo);
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Recursively copy a directory and all contents including sub-directories.
        /// </summary>
        /// <param name="directoryFrom">The full path to the directory to copy from.</param>
        /// <param name="directoryTo">The full path to the directory to copy to.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive CopyDirectory(Primitive directoryFrom, Primitive directoryTo)
        {
            try
            {
                if (!Directory.Exists(directoryFrom)) return "FAILED";
                CopyFilesRecursively(directoryFrom, directoryTo);
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Recursively get all sub-directories in directory.
        /// </summary>
        /// <param name="path">The full path to the root dircetory.</param>
        /// <returns>An array of all sub-directories or "FAILED".</returns>
        public static Primitive GetAllDirectories(Primitive path)
        {
            try
            {
                path = Environment.ExpandEnvironmentVariables(path);
                if (!Directory.Exists(path)) return "FAILED";
                StringBuilder result = new StringBuilder();
                int i = 1;
                foreach (string dirPath in Directory.GetDirectories(path, "*", SearchOption.AllDirectories))
                {
                    result.AppendFormat("{0}={1};", i++, Utilities.ArrayParse(dirPath));
                }
                return Utilities.CreateArrayMap(result.ToString());
            }
            catch (UnauthorizedAccessException)
            {
                //Try to do it recursively
                try
                {
                    StringBuilder result = new StringBuilder();
                    int i = 1;
                    getDirectories(path, ref result, ref i);
                    return Utilities.CreateArrayMap(result.ToString());
                }
                catch (Exception ex)
                {

                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return "FAILED";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>Writes an Array of bytes to an (existing) file.</summary>
        /// <param name="filePath">The full path of the file. A non existing file will be created.</param>
        /// <param name="byteArray">The 1D Array (from 1, continously) with byte values [0,255].
        /// A single comma or sapce separated variable may also be used using hex notation, eg 3D,1F,00.</param>
        /// <param name="startPos">The byte position (incl., from 1) in an existing file to start writing (ignored for non existing file, will be written from beginning).
        /// &lt;=1, from file start
        /// &gt;file length, append after file end</param>
        /// <returns>The number of written bytes on success, else "FAILED".</returns>
        /// <example>'(over)writes from file start
        /// WriteByteArray(path, arr, 1)
        /// 'SB&#169; after 4th byte
        /// WriteByteArray(path, "1=83;2=66;3=169;",5)</example>
        public static Primitive WriteByteArray(Primitive filePath, Primitive byteArray, Primitive startPos)
        {
            try
            {
                int len = byteArray.GetItemCount();
                byte[] bytes;
                if (len > 0)
                {
                    Primitive indices = byteArray.GetAllIndices();
                    bytes = new byte[len];
                    for (int i = 0; i < len; i++)
                    {
                        bytes[i] = (byte)byteArray[indices[i + 1]];
                    }
                }
                else
                {
                    bytes = ((string)byteArray).Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToByte(s, 16)).ToArray();
                    len = bytes.Length;
                }
                if (len < 1) return "FAILED";

                string path = Environment.ExpandEnvironmentVariables(filePath);

                if (!System.IO.File.Exists(path))
                {
                    System.IO.File.WriteAllBytes(path, bytes);
                    return len;
                }
                else
                {
                    long pos = startPos-1;
                    if (pos < 0) pos = 0;
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write))
                    {
                        long fsLen = fs.Length;
                        if (pos > fsLen) pos = fsLen;

                        fs.Seek(pos, SeekOrigin.Begin);
                        for (int i = 0; i < len; i++)
                        {
                            fs.WriteByte(bytes[i]);
                        }
                        fs.Close();
                        return len;
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Read a file into an array of bytes [0,255].
        /// </summary>
        /// <param name="filePath">The full path of the file.</param>
        /// <param name="hexMode">If this varaible is set to "True", then a single comma deliminated variable of hex values is returned in place of an anrray..</param>
        /// <returns>An array of byte values indexed from 1, or single string variable of hex values, or "FAILED".</returns>
        public static Primitive ReadByteArray(Primitive filePath, Primitive hexMode)
        {
            try
            {
                string path = Environment.ExpandEnvironmentVariables(filePath);

                byte[] bytes = System.IO.File.ReadAllBytes(path);

                string result = "";
                if (hexMode)
                {
                    result = BitConverter.ToString(bytes).Replace("-", ",");
                    return result;
                }
                else
                {
                    return Utilities.CreateArrayMap(bytes.ToPrimitiveArray());
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }
    }
}