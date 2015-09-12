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
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Controls = System.Windows.Controls;
using SBArray = Microsoft.SmallBasic.Library.Array;
using Shapes = System.Windows.Shapes;

namespace LitDev
{
    /// <summary>
    /// Dialogs and popups.
    /// </summary>
    [SmallBasicType]
    public static class LDDialogs
    {
        public static bool _Waiting = false;
        private static Thread _ThreadWait;
        private static string _TextWait;
        private static FormWait _FormWait;
        private static System.Drawing.Color _Colour;
        private static string LastFolder = null;

        private static void ShowWait()
        {
            _FormWait = new FormWait();
            _FormWait.setText(_TextWait);
            _FormWait.setColour(_Colour);
            _FormWait.TopMost = true;
            _FormWait.ShowDialog(Utilities.ForegroundHandle());
        }

        private static string _LastMenuClickItem = "";
        private static SmallBasicCallback _MenuClickDelegate = null;
        private static void _MenuClickEvent(Object sender, EventArgs e)
        {
            MenuItem _item = (MenuItem)sender;
            _LastMenuClickItem = (string)_item.Tag;
            if (null == _MenuClickDelegate) return;
            _MenuClickDelegate();
        }

        private static string getFilter(Primitive extension)
        {
            string filter = "";
            if (((string)extension).Contains("|"))
            {
                filter = extension;
            }
            else if (SBArray.IsArray(extension))
            {
                Primitive indices = SBArray.GetAllIndices(extension);
                int count = SBArray.GetItemCount(indices);
                string types = "";
                for (int i = 1; i <= count; i++)
                {
                    types += "*." + extension[indices[i]];
                    if (i < count) types += ";";
                }
                filter = "File Type (" + types + ") |" + types;
            }
            else
            {
                filter = "File Type (*." + extension + ") |*." + extension;
            }
            return filter;
        }

        public static ContextMenu getMenu(Dictionary<string, BitmapSource> _savedImages, Primitive items, Primitive images, int iconSize)
        {
            BitmapSource img;
            ContextMenu menu = new ContextMenu();
            int itemCount = SBArray.GetItemCount(items);
            Primitive itemIndices = SBArray.GetAllIndices(items);

            for (int i = 1; i <= itemCount; i++)
            {
                string itemText = items[itemIndices[i]];
                string imageName = images[itemIndices[i]];
                // Add the item
                MenuItem menuItem = new MenuItem();
                menuItem.Header = itemText;
                menuItem.Click += new RoutedEventHandler(_MenuClickEvent);
                menuItem.Tag = (string)(itemIndices[i]);
                // Creates the item image.
                if (imageName != "")
                {
                    if (!_savedImages.TryGetValue(imageName, out img))
                    {
                        imageName = ImageList.LoadImage(imageName);
                        _savedImages.TryGetValue(imageName, out img);
                    }
                    if (null != img)
                    {
                        System.Windows.Controls.Image image = new System.Windows.Controls.Image();
                        image.Source = img;
                        if (iconSize > 0)
                        {
                            System.Drawing.Bitmap dImg = LDImage.getBitmap(img);
                            System.Drawing.Image.GetThumbnailImageAbort dummyCallback = new System.Drawing.Image.GetThumbnailImageAbort(LDWebCam.ResizeAbort);
                            dImg = (System.Drawing.Bitmap)dImg.GetThumbnailImage(iconSize, iconSize, dummyCallback, IntPtr.Zero);
                            image.Source = LDImage.getBitmapImage(dImg);
                        }
                        menuItem.Icon = image;
                    }
                }
                menu.Items.Add(menuItem);
            }
            if (menu.Items.Count == 0) return null;
            return menu;
        }

        /// <summary>
        /// Create a waiting popup window with a text message.
        /// </summary>
        /// <param name="text">The text to display in the popup window.</param>
        /// <param name="colour">The colour of the popup window border, may be "" for default.</param>
        /// <returns>
        /// None.
        /// </returns>
        public static void Wait(Primitive text, Primitive colour)
        {
            if (!_Waiting)
            {
                _ThreadWait = new Thread(new ThreadStart(ShowWait));
                _TextWait = text;
                _Colour = System.Drawing.Color.Red;
                try
                {
                    if (colour != "") _Colour = System.Drawing.ColorTranslator.FromHtml(colour);
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                _Waiting = true;
                _ThreadWait.Start();
            }
        }

        /// <summary>
        /// Close the waiting popup window.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void EndWait()
        {
            _Waiting = false;
        }

        /// <summary>
        /// Set a tooltip popup for common shapes and controls.
        /// </summary>
        /// <param name="shapeName">The shape or control.</param>
        /// <param name="tip">The text content of the tooltip.</param>
        /// <returns>
        /// None.
        /// </returns>
        public static void ToolTip(Primitive shapeName, Primitive tip)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue(shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    ToolTip toolTip = new ToolTip();
                    toolTip.Content = tip;

                    try
                    {
                        ((FrameworkElement)obj).ToolTip = toolTip;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { ret });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// A popup calendar date chooser - double click a date or press return to select a date.
        /// </summary>
        /// <param name="start">The initial date in the control, may be "" for today.</param>
        /// <returns>The selected date.</returns>
        public static Primitive Calendar(Primitive start)
        {
            DateTime Start = DateTime.Today;
            try
            {
                if (start != "") Start = DateTime.Parse(start);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            FormCalendar _FormCalendar = new FormCalendar(Start);
            _FormCalendar.TopMost = true;
            _FormCalendar.ShowDialog(Utilities.ForegroundHandle());
            return _FormCalendar.result;
        }

        /// <summary>
        /// Open File Dialogue (get an existing file).
        /// </summary>
        /// <param name="extension">
        /// The file type extension, e.g. "sb".
        /// This may also be an array of extension types such as "1=png;2=jpg;".
        /// If the extension contains a "|" character then it will be used directly such as "Images|*.bmp;*.jpg;*.gif;*.png|All files (*.*)|*.*".
        /// </param>
        /// <param name="folder">
        /// The initial folder to open dialog with, can be "".
        /// </param>
        /// <returns>The full path of the file.</returns>
        public static Primitive OpenFile(Primitive extension, Primitive folder)
        {
            Primitive result = "";
            try
            {
                ThreadStart start = delegate
                {
                    System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
                    dlg.Filter = getFilter(extension);
                    dlg.InitialDirectory = folder;
                    if (dlg.ShowDialog(Utilities.ForegroundHandle()) == System.Windows.Forms.DialogResult.OK) result = dlg.FileName;
                };
                Thread thread = new Thread(start);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                thread.Join();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return result;
        }

        /// <summary>
        /// Save File Dialogue (get a new file).
        /// </summary>
        /// <param name="extension">
        /// The file type extension, e.g. "sb".
        /// This may also be an array of extension types such as "1=png;2=jpg;".
        /// If the extension contains a "|" character then it will be used directly such as "Images|*.bmp;*.jpg;*.gif;*.png|All files (*.*)|*.*".
        /// </param>
        /// <param name="folder">
        /// The initial folder to open dialog with, can be "".
        /// </param>
        /// <returns>The full path of the file.</returns>
        public static Primitive SaveFile(Primitive extension, Primitive folder)
        {
            Primitive result = "";
            try
            {
                ThreadStart start = delegate
                {
                    System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
                    dlg.Filter = getFilter(extension);
                    dlg.InitialDirectory = folder;
                    if (dlg.ShowDialog(Utilities.ForegroundHandle()) == System.Windows.Forms.DialogResult.OK) result = dlg.FileName;
                };
                Thread thread = new Thread(start);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                thread.Join();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return result;
        }

        /// <summary>
        /// A Dialog to get a folder (directory).
        /// </summary>
        /// <param name="InitialFolder">The initial folder or "" for the last folder selected.</param>
        /// <returns>The full path to the selected folder or "" if none is selected.</returns>
        public static Primitive GetFolder(Primitive InitialFolder)
        {
            Primitive result = "";
            try
            {
                ThreadStart start = delegate
                {
                    System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
                    dlg.RootFolder = Environment.SpecialFolder.MyComputer;
                    dlg.SelectedPath = LastFolder;
                    if (InitialFolder != "") dlg.SelectedPath = InitialFolder;
                    if (dlg.ShowDialog(Utilities.ForegroundHandle()) == System.Windows.Forms.DialogResult.OK)
                    {
                        result = dlg.SelectedPath;
                        LastFolder = result;
                    }
                };
                Thread thread = new Thread(start);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                thread.Join();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return result;
        }

        /// <summary>
        /// Use the font dialog to select a font.
        /// </summary>
        /// <param name="font">
        /// An array with the initial font selected.
        /// It has the same format as the return array, and can be an empty array "".
        /// </param>
        /// <returns>An array with the font properties.
        /// result[1] is Font name
        /// result[2] is Font size
        /// result[3] is Font bold ("True" or "False")
        /// result[4] is Font italic ("True" or "False")
        /// </returns>
        public static Primitive Font(Primitive font)
        {
            string result = "";
            try
            {
                ThreadStart start = delegate
                {
                    System.Windows.Forms.FontDialog dlg = new System.Windows.Forms.FontDialog();
                    if (Microsoft.SmallBasic.Library.Array.GetItemCount(font) == 4)
                    {
                        System.Drawing.FontStyle fontStyle = new System.Drawing.FontStyle();
                        if (font[3]) fontStyle |= System.Drawing.FontStyle.Bold;
                        if (font[4]) fontStyle |= System.Drawing.FontStyle.Italic;
                        System.Drawing.Font _Font = new System.Drawing.Font(font[1], font[2], fontStyle);
                        dlg.Font = _Font;
                    }
                    if (dlg.ShowDialog(Utilities.ForegroundHandle()) == System.Windows.Forms.DialogResult.OK)
                    {
                        result += "1=" + Utilities.ArrayParse(dlg.Font.Name) + ";";
                        result += "2=" + Utilities.ArrayParse(dlg.Font.Size.ToString(CultureInfo.InvariantCulture)) + ";";
                        result += "3=" + (dlg.Font.Bold ? "True" : "False") + ";";
                        result += "4=" + (dlg.Font.Italic ? "True" : "False") + ";";
                    }
                };
                Thread thread = new Thread(start);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                thread.Join();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Choose a colour from a dialog.
        /// </summary>
        /// <returns>
        /// The chosen colour.
        /// </returns>
        public static Primitive Colour()
        {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.AnyColor = true;
            colorDialog.FullOpen = true;
            colorDialog.SolidColorOnly = false;

            if (colorDialog.ShowDialog(Utilities.ForegroundHandle()) == System.Windows.Forms.DialogResult.OK)
            {
                return ColorTranslator.ToHtml(colorDialog.Color).ToString();
            }
            return "";
        }

        /// <summary>
        /// Add a right click context menu for the GraphicsWindow.
        /// </summary>
        /// <param name="items">An array of context menu item selection texts.</param>
        /// <param name="images">Optional array of image icons, any or all may be "".
        /// They may be the result of ImageList.LoadImage or local or network image file.</param>
        public static void AddRightClickMenu(Primitive items, Primitive images)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ImageListType = typeof(ImageList);
            Dictionary<string, BitmapSource> _savedImages;
            Window _window;

            try
            {
                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null); InvokeHelper ret = new InvokeHelper(delegate
                {
                    //Right click popup menu
                    ContextMenu menu = getMenu(_savedImages, items, images, LDControls.IconSize);
                    _window.ContextMenu = menu;
                });
                MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { ret });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Event when a right click context menu item is selected.
        /// </summary>
        public static event SmallBasicCallback RightClickMenu
        {
            add
            {
                _MenuClickDelegate = value;
            }
            remove
            {
                _MenuClickDelegate = null;
            }
        }

        /// <summary>
        /// The index of the last right click context menu item selected.
        /// </summary>
        public static Primitive LastRightClickMenuItem
        {
            get { return _LastMenuClickItem; }
        }

        /// <summary>
        /// A message dialog with Yes, No and Cancel options.
        /// </summary>
        /// <param name="text">Text question for the dialog.</param>
        /// <param name="title">Title for the dialog.</param>
        /// <returns>"Yes", "No" or "Cancel"</returns>
        public static Primitive Confirm(Primitive text, Primitive title)
        {
            return MessageBox.Show(text, title, MessageBoxButton.YesNoCancel, MessageBoxImage.Question).ToString();
        }
    }
}
