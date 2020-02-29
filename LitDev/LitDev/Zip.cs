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

using Microsoft.SmallBasic.Library;
using System;
using System.IO;
using System.IO.Packaging;
using SBArray = Microsoft.SmallBasic.Library.Array;
using Ionic.Zip;
using System.Collections.Generic;

namespace LitDev
{
    /// <summary>
    /// Zip file compression utilities.
    /// </summary>
    [SmallBasicType]
    public static class LDZip
    {
        private static void AddToArchive(Package zip, string fileToAdd, string root)
        {
            try
            {
                string uriFileName = fileToAdd.Replace(" ", "_").Replace('\\', '/');
                FileAttributes attr = System.IO.File.GetAttributes(fileToAdd);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    root = root + "/" + Path.GetFileName(uriFileName);
                    string[] subfolders = Directory.GetDirectories(fileToAdd);
                    for (int i = 0; i < subfolders.Length; i++)
                    {
                        AddToArchive(zip, subfolders[i], root);
                    }
                    string[] subfiles = Directory.GetFiles(fileToAdd);
                    for (int i = 0; i < subfiles.Length; i++)
                    {
                        AddToArchive(zip, subfiles[i], root);
                    }
                }
                else
                {
                    string zipUri = string.Concat(root + "/", Path.GetFileName(uriFileName));
                    Uri partUri = new Uri(zipUri, UriKind.Relative);
                    string contentType = System.Net.Mime.MediaTypeNames.Application.Zip;
                    if (zip.PartExists(partUri)) zip.DeletePart(partUri);
                    PackagePart pkgPart = zip.CreatePart(partUri, contentType, CompressionOption.Normal);
                    Byte[] bytes = System.IO.File.ReadAllBytes(fileToAdd);
                    pkgPart.GetStream().Write(bytes, 0, bytes.Length);
                }
            }
            catch (Exception ex)
            {
                TextWindow.WriteLine(fileToAdd);
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static void RemoveFromArchive(ZipFile zip, string fileToRemove)
        {
            try
            {
                fileToRemove = fileToRemove.Replace('\\', '/');
                if (zip.ContainsEntry(fileToRemove))
                {
                    zip.RemoveEntry(fileToRemove);
                }
                else
                {
                    List<string> toRemove = new List<string>();
                    foreach (ZipEntry e in zip)
                    {
                        if (e.FileName.StartsWith(fileToRemove + "/")) toRemove.Add(e.FileName);
                    }
                    foreach (string element in toRemove)
                    {
                        zip.RemoveEntry(element);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static void ExtractFile(string rootFolder, ZipPackagePart contentFile)
        {
            try
            {
                string contentFilePath = contentFile.Uri.OriginalString.Replace('/', Path.DirectorySeparatorChar);
                if (contentFilePath.StartsWith(Path.DirectorySeparatorChar.ToString()))
                {
                    contentFilePath = contentFilePath.TrimStart(Path.DirectorySeparatorChar);
                }
                contentFilePath = Path.Combine(rootFolder, contentFilePath);
                if (Directory.Exists(Path.GetDirectoryName(contentFilePath)) != true)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(contentFilePath));
                }
                FileStream newFileStream = System.IO.File.Create(contentFilePath);
                newFileStream.Close();
                byte[] content = new byte[contentFile.GetStream().Length];
                contentFile.GetStream().Read(content, 0, content.Length);
                System.IO.File.WriteAllBytes(contentFilePath, content);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Compress files to a zip archive.
        /// </summary>
        /// <param name="zipFile">The zip archive file to create.</param>
        /// <param name="files">
        /// An array of files to append to the zip archive.
        /// A single file or directory may also be set.
        /// Any directories will be recursively added to the zip.
        /// Any white space in files or directories will be replaced with "_".
        /// </param>
        /// <returns>An error message or "".</returns>
        public static Primitive Zip(Primitive zipFile, Primitive files)
        {
            try
            {
                using (Package zip = ZipPackage.Open(zipFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    if (SBArray.IsArray(files))
                    {
                        Primitive indices = SBArray.GetAllIndices(files);
                        int count = SBArray.GetItemCount(indices);
                        for (int i = 1; i <= count; i++)
                        {
                            AddToArchive(zip, files[indices[i]], "");
                        }
                    }
                    else
                    {
                        AddToArchive(zip, files, "");
                    }
                    zip.Close();
                }
                return "";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return Utilities.GetCurrentMethod() + " " + ex.Message;
            }
        }

        /// <summary>
        /// Remove a file (or directory with all sub files) from an existing zip archive.
        /// </summary>
        /// <param name="zipFile">The zip archive to remove a file from.</param>
        /// <param name="files">
        /// An array of files to remove from the zip archive.
        /// A single file or directory may also be deleted.
        /// Any directories will be recursively removed from the zip.
        /// </param>
        /// <returns>An error message or "".</returns>
        public static Primitive Remove(Primitive zipFile, Primitive files)
        {
            try
            {
                using (ZipFile zip = ZipFile.Read(zipFile))
                {
                    if (SBArray.IsArray(files))
                    {
                        Primitive indices = SBArray.GetAllIndices(files);
                        int count = SBArray.GetItemCount(indices);
                        for (int i = 1; i <= count; i++)
                        {
                            RemoveFromArchive(zip, files[indices[i]]);
                        }
                    }
                    else
                    {
                        RemoveFromArchive(zip, files);
                    }
                    zip.Save();
                }
                return "";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return Utilities.GetCurrentMethod() + " " + ex.Message;
            }
        }

        /// <summary>
        /// Uncompress a zip archive.
        /// </summary>
        /// <param name="zipFile">The zip archive to uncompress.</param>
        /// <param name="directory">A directory to uncompress the files to (existing files will be overwritten).</param>
        /// <returns>An error message or "".</returns>
        public static Primitive UnZip(Primitive zipFile, Primitive directory)
        {
            try
            {
                using (ZipFile zip = ZipFile.Read(zipFile))
                {
                    zip.ExtractAll(directory, ExtractExistingFileAction.OverwriteSilently);
                }
                return "";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return Utilities.GetCurrentMethod() + " " + ex.Message;
            }
        }

        /// <summary>
        /// List the files in a zip archive.
        /// </summary>
        /// <param name="zipFile">The zip archive.</param>
        /// <returns>An array of file names in the zip or an error message.</returns>
        public static Primitive ZipList(Primitive zipFile)
        {
            try
            {
                string result = "";
                using (ZipFile zip = ZipFile.Read(zipFile))
                {
                    int i = 1;

                    foreach (ZipEntry entry in zip)
                    {
                        result += (i++).ToString() + "=" + Utilities.ArrayParse(entry.FileName) + ";";
                    }
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return Utilities.GetCurrentMethod() + " " + ex.Message;
            }
        }
    }
}

