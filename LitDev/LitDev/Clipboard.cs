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
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Media.Imaging;
using SBArray = Microsoft.SmallBasic.Library.Array;

namespace LitDev
{
    /// <summary>
    /// Clipboard methods.
    /// </summary>
    [SmallBasicType]
    public static class LDClipboard
    {
        private static BitmapSource CB_image;
        private static StringCollection CB_files;
        private static String CB_text;
        private static String CB_imageName;
        private static bool CB_imageAlpha = true;

        private static void CB_Clear()
        {
            try
            {
                Clipboard.Clear();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static void CB_GetImage()
        {
            Type ImageListType = typeof(ImageList);
            Type ShapesType = typeof(Shapes);
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, BitmapSource> _savedImages;

            InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
            {
                try
                {
                    BitmapImage image = new BitmapImage();
                    try
                    {
                        _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                        MethodInfo methodInfo = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                        string imageName = methodInfo.Invoke(null, new object[] { "ImageList" }).ToString();

                        if (Clipboard.ContainsImage())
                        {
                            _savedImages[imageName] = Clipboard.GetImage();
                            return imageName;
                        }
                        else
                        {
                            IDataObject dataObject = Clipboard.GetDataObject();
                            MemoryStream ms = (MemoryStream)dataObject.GetData("PNG");
                            image.BeginInit();
                            image.StreamSource = ms;
                            image.EndInit();

                            _savedImages[imageName] = image;
                            return imageName;
                        }
                    }
                    catch
                    {
                        return "FAILED";
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return "FAILED";
            });

            MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
            CB_imageName = method.Invoke(null, new object[] { ret }).ToString();
        }

        private static void CB_SetImage()
        {
            try
            {
                if (CB_imageAlpha)
                {
                    PngBitmapEncoder encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(CB_image));
                    using (MemoryStream ms = new MemoryStream())
                    {
                        encoder.Save(ms);
                        IDataObject dataObject = new DataObject();
                        dataObject.SetData("PNG", ms, true);
                        Clipboard.SetDataObject(dataObject, true);
                    }
                }
                else
                {
                    Clipboard.SetImage(CB_image);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static void CB_GetFileList()
        {
            try
            {
                if (!Clipboard.ContainsFileDropList())
                {
                    CB_files = null;
                    return;
                }
                CB_files = Clipboard.GetFileDropList();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static void CB_SetFileList()
        {
            try
            {
                Clipboard.SetFileDropList(CB_files);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static void CB_GetText()
        {
            try
            {
                if (!Clipboard.ContainsText())
                {
                    CB_text = null;
                    return;
                }
                CB_text = Clipboard.GetText();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static void CB_SetText()
        {
            try
            {
                Clipboard.SetText(CB_text);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Clear the clipboard;
        /// </summary>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive Clear()
        {
            try
            {
                Thread thread = new Thread(CB_Clear);
                thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
                thread.Start();
                thread.Join(); //Wait for the thread to end
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Load an image from the clipboard into ImageList.
        /// </summary>
        /// <returns>The ImageList name or "FAILED".</returns>
        public static Primitive GetImage()
        {
            try
            {               
                Thread thread = new Thread(CB_GetImage);
                thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
                thread.Start();
                thread.Join(); //Wait for the thread to end
                return CB_imageName;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Set an ImageList image to the clipboard.
        /// </summary>
        /// <param name="imageName">The ImageList image.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive SetImage(Primitive imageName)
        {
            try
            {
                Type ImageListType = typeof(ImageList);
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, BitmapSource> _savedImages;
                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_savedImages.TryGetValue((string)imageName, out CB_image)) return "FAILED";
                if (null == CB_image) return "FAILED";

                Thread thread = new Thread(CB_SetImage);
                thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
                thread.Start();
                thread.Join(); //Wait for the thread to end
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get an array of file names from the clipboard.
        /// </summary>
        /// <returns>An array of files or "FAILED".</returns>
        public static Primitive GetFileList()
        {
            try
            {
                Thread thread = new Thread(CB_GetFileList);
                thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
                thread.Start();
                thread.Join(); //Wait for the thread to end
                if (null == CB_files) return "FAILED";

                string result = "";
                int i = 1;
                foreach (String file in CB_files)
                {
                    result += (i++).ToString() + "=" + Utilities.ArrayParse(file) + ";";
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Set a list of files to the clipboard.
        /// </summary>
        /// <param name="fileList">An array (or single file) of file names (full path).</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive SetFileList(Primitive fileList)
        {
            try
            {
                CB_files = new StringCollection();
                if (SBArray.IsArray(fileList))
                {
                    Primitive indices = SBArray.GetAllIndices(fileList);
                    for (int i = 1; i <= SBArray.GetItemCount(indices); i++)
                    {
                        CB_files.Add(fileList[indices[i]]);
                    }
                }
                else
                {
                    CB_files.Add(fileList);
                }
                Thread thread = new Thread(CB_SetFileList);
                thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
                thread.Start();
                thread.Join(); //Wait for the thread to end
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get text from the clipboard.
        /// </summary>
        /// <returns>The clipboard text or "FAILED".</returns>
        public static Primitive GetText()
        {
            try
            {
                Thread thread = new Thread(CB_GetText);
                thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
                thread.Start();
                thread.Join(); //Wait for the thread to end
                if (null == CB_text) return "FAILED";
                return CB_text;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Set text to the clipboard.
        /// </summary>
        /// <param name="text">The text to add to the clipboard.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive SetText(Primitive text)
        {
            try
            {
                CB_text = text;
                Thread thread = new Thread(CB_SetText);
                thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
                thread.Start();
                thread.Join(); //Wait for the thread to end
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Event when the clipboard status changes.
        /// </summary>
        public static event SmallBasicCallback ClipboardChanged
        {
            add
            {
                if (!Utilities.formEventsThread.IsAlive) Utilities.formEventsThread.Start();
                Utilities.formEvents.ClipBoardChangedDelegate = value;
            }
            remove
            {
                Utilities.formEvents.ClipBoardChangedDelegate = null;
            }
        }

        /// <summary>
        /// Use an extended format for SetImage that includes transparency ("True" default or "False").
        /// This extended format may not be recognised by some applications when pasted.
        /// </summary>
        public static Primitive ImageTransparency
        {
            get { return CB_imageAlpha; }
            set { CB_imageAlpha = value; }
        }
    }
}
