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
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Xps.Packaging;
using SBArray = Microsoft.SmallBasic.Library.Array;
using SBShapes = Microsoft.SmallBasic.Library.Shapes;

namespace LitDev
{
    /// <summary>
    /// Controls for the GraphicsWindow.
    /// </summary>
    [SmallBasicType]
    public static class LDControls
    {
        private static void AddControl(string name, Control control)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("AddControl", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { name, control });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }            
        }

        private static T DeepCopy<T>(this T theSource)
        {
            T theCopy;
            DataContractSerializer theDataContactSerializer = new DataContractSerializer(typeof(T));

            using (MemoryStream memStream = new MemoryStream())
            {
                theDataContactSerializer.WriteObject(memStream, theSource);
                memStream.Position = 0;
                theCopy = (T)theDataContactSerializer.ReadObject(memStream);
            }
            return theCopy;
        }

        private static int iconSize = -1;
        [HideFromIntellisense]
        public static Primitive IconSize
        {
            get { return iconSize; }
            set { iconSize = value; }
        }
        [HideFromIntellisense]
        public static event SmallBasicCallback ContextMenu
        {
            add
            {
                _ContextClickDelegate = value;
            }
            remove
            {
                _ContextClickDelegate = null;
            }
        }
        [HideFromIntellisense]
        public static event SmallBasicCallback Menu
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

        private static string _LastTreeView;
        private static string _LastTreeViewIndex;
        private static SmallBasicCallback _TreeViewItemChangedDelegate = null;
        private static void _TreeViewItemChangedEvent(Object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            _LastTreeView = ((TreeView)sender).Name;
            _LastTreeViewIndex = ((TreeViewItem)(((TreeView)sender).SelectedItem)).Name.Substring(5);
            if (null == _TreeViewItemChangedDelegate) return;
            _TreeViewItemChangedDelegate();
        }
        private static void _TreeViewItemChangedEvent(Object sender, MouseButtonEventArgs e)
        {
            TreeViewItem treeViewItem = ((TreeViewItem)sender);
            if (!treeViewItem.IsSelected) return;
            FrameworkElement element = treeViewItem;
            while (null != VisualTreeHelper.GetParent(element))
            {
                element = (FrameworkElement)(VisualTreeHelper.GetParent(element));
                _LastTreeView = element.Name;
                if (_LastTreeView.Contains("Control")) break;
            }
            _LastTreeViewIndex = treeViewItem.Name.Substring(5);
            if (null == _TreeViewItemChangedDelegate) return;
            _TreeViewItemChangedDelegate();
        }
        private static SmallBasicCallback _TreeViewItemChanged
        {
            get
            {
                return _TreeViewItemChangedDelegate;
            }
            set
            {
                _TreeViewItemChangedDelegate = value;
            }
        }
        private static TreeViewItem findTreeItem(ItemCollection items, string name)
        {
            foreach (TreeViewItem i in items)
            {
                TreeViewItem children = findTreeItem(i.Items, name);
                if (null != children) return children;
                if (i.Name == name) return i;
            }
            return null;
        }
        private static void expandNode(ItemCollection items, bool state)
        {
            foreach (TreeViewItem i in items)
            {
                expandNode(i.Items, state);
                i.IsExpanded = state;
            }
        }
        private static void copyNodes(ItemCollection items, ItemCollection itemsCopy)
        {
            foreach (TreeViewItem item in items)
            {
                TreeViewItem itemCopy = new TreeViewItem();
                itemCopy.Header = item.Header.ToString();
                itemCopy.Name = item.Name.ToString();
                itemCopy.IsExpanded = item.IsExpanded;
                if (item.HasItems) copyNodes(item.Items, itemCopy.Items);
                itemsCopy.Add(itemCopy);
            }
        }
        private static void getNodes(ItemCollection items, int level, ref Primitive result)
        {
            foreach (TreeViewItem item in items)
            {
                int index = SBArray.GetItemCount(result) + 1;
                Primitive node = new Primitive();
                node[level] = item.Header.GetType() == typeof(TextBox) ? ((TextBox)item.Header).Text : item.Header.ToString();
                result[index] = node;
                getNodes(item.Items, index, ref result);
            }
        }

        private static bool fontBold = false;
        private static bool fontItalic = false;
        private static bool fontUnderline = false;
        private static double fontSize = 12;
        private static string fontFamily = "Segoe UI";
        private static string fontForeground = "Black";
        private static string fontBackground = "White";
        private static TextAlignment textAlignment = TextAlignment.Left;
        private static bool readOnly = false;
        private static bool caseSensitive = false;
        private static Thickness thickness = new Thickness(0);
        private static TextRange FindWordFromPosition(TextPointer position, string word)
        {
            while (position != null)
            {
                if (position.GetPointerContext(LogicalDirection.Forward) == TextPointerContext.Text)
                {
                    string textRun = position.GetTextInRun(LogicalDirection.Forward);
                    if (!caseSensitive)
                    {
                        textRun = textRun.ToLower();
                        word = word.ToLower();
                    }

                    // Find the starting index of any substring that matches "word".
                    int indexInRun = textRun.IndexOf(word);
                    if (indexInRun >= 0)
                    {
                        TextPointer start = position.GetPositionAtOffset(indexInRun);
                        TextPointer end = start.GetPositionAtOffset(word.Length);
                        return new TextRange(start, end);
                    }
                }

                position = position.GetNextContextPosition(LogicalDirection.Forward);
            }

            // position will be null if "word" is not found.
            return null;
        }
        private static void ApplySelection(TextRange textSelection)
        {
            textSelection.ApplyPropertyValue(Run.FontWeightProperty, fontBold ? FontWeights.Bold : FontWeights.Normal);
            textSelection.ApplyPropertyValue(Run.FontStyleProperty, fontItalic ? FontStyles.Italic : FontStyles.Normal);
            textSelection.ApplyPropertyValue(Run.TextDecorationsProperty, fontUnderline ? TextDecorations.Underline : null);
            textSelection.ApplyPropertyValue(Run.FontSizeProperty, fontSize);
            textSelection.ApplyPropertyValue(Run.FontFamilyProperty, fontFamily);
            System.Windows.Media.Brush brush = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(fontForeground));
            textSelection.ApplyPropertyValue(Run.ForegroundProperty, brush);
            brush = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(fontBackground));
            textSelection.ApplyPropertyValue(Run.BackgroundProperty, brush);
        }

        private static string _LastBrowser;
        private static string _LastBrowserPage;
        private static SmallBasicCallback _LoadCompletedDelegate = null;
        private static void _LoadCompletedEvent(Object sender, NavigationEventArgs e)
        {
            _LastBrowser = ((WebBrowser)sender).Name;
            _LastBrowserPage = ((WebBrowser)sender).Source.AbsoluteUri;
            if (!browserHistory.Contains(_LastBrowserPage)) browserHistory.Add(_LastBrowserPage);
            if (null == _LoadCompletedDelegate) return;
            _LoadCompletedDelegate();
        }
        private static SmallBasicCallback _LoadCompleted
        {
            get
            {
                return _LoadCompletedDelegate;
            }
            set
            {
                _LoadCompletedDelegate = value;
            }
        }
        private static Uri getUri(string url)
        {
            if (url.ToString().Contains("://"))
            {
                return new Uri(url, UriKind.RelativeOrAbsolute);
            }
            else
            {
                return new Uri("http://" + url, UriKind.RelativeOrAbsolute);
            }
        }
        private static List<string> browserHistory = new List<string>();

        private static string _LastListBox;
        private static string _LastListBoxIndex;
        private static SmallBasicCallback _ListBoxItemChangedDelegate = null;
        private static void _ListBoxItemChangedEvent(Object sender, SelectionChangedEventArgs e)
        {
            _LastListBox = ((ListBox)sender).Name;
            Object selectedItem = ((ListBox)sender).SelectedItem;
            if (null != selectedItem)
            {
                foreach (ListBoxItem item in ((ListBox)sender).SelectedItems)
                {
                    _LastListBoxIndex = item.Name.Substring(5);
                }
                if (null == _ListBoxItemChangedDelegate) return;
                _ListBoxItemChangedDelegate();
            }
        }
        private static void _ListBoxItemChangedEvent(Object sender, MouseButtonEventArgs e) //click an already selected item
        {
            ListBoxItem listBoxItem = ((ListBoxItem)sender);
            if (!listBoxItem.IsSelected) return;
            _LastListBox = ((ListBox)listBoxItem.Parent).Name;
            _LastListBoxIndex = listBoxItem.Name.Substring(5);
            if (null == _ListBoxItemChangedDelegate) return;
            _ListBoxItemChangedDelegate();
        }
        private static SmallBasicCallback _ListBoxItemChanged
        {
            get
            {
                return _ListBoxItemChangedDelegate;
            }
            set
            {
                _ListBoxItemChangedDelegate = value;
            }
        }

        private static string _LastComboBox;
        private static string _LastComboBoxIndex;
        private static SmallBasicCallback _ComboBoxItemChangedDelegate = null;
        private static void _ComboBoxItemChangedEvent(Object sender, SelectionChangedEventArgs e)
        {
            _LastComboBox = ((ComboBox)sender).Name;
            _LastComboBoxIndex = ((ComboBoxItem)(((ComboBox)sender).SelectedItem)).Name.Substring(5);
            if (null == _ComboBoxItemChangedDelegate) return;
            _ComboBoxItemChangedDelegate();
        }
        private static void _ComboBoxItemChangedEvent(Object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem comboBoxItem = ((ComboBoxItem)sender);
            if (!comboBoxItem.IsSelected) return;
            _LastComboBox = ((ComboBox)comboBoxItem.Parent).Name;
            _LastComboBoxIndex = comboBoxItem.Name.Substring(5);
            if (null == _ComboBoxItemChangedDelegate) return;
            _ComboBoxItemChangedDelegate();
        }
        private static SmallBasicCallback _ComboBoxItemChanged
        {
            get
            {
                return _ComboBoxItemChangedDelegate;
            }
            set
            {
                _ComboBoxItemChangedDelegate = value;
            }
        }

        private static string _LastCheckBox;
        private static string _LastCheckBoxState;
        private static SmallBasicCallback _CheckBoxChangedDelegate = null;
        private static void _CheckBoxChangedEvent(Object sender, RoutedEventArgs e)
        {
            _LastCheckBox = ((CheckBox)sender).Name;
            _LastCheckBoxState = (((CheckBox)sender).IsChecked) == true ? "True" : "False";
            if (null == _CheckBoxChangedDelegate) return;
            _CheckBoxChangedDelegate();
        }
        private static SmallBasicCallback _CheckBoxChanged
        {
            get
            {
                return _CheckBoxChangedDelegate;
            }
            set
            {
                _CheckBoxChangedDelegate = value;
            }
        }

        private static string _LastContextItem = "";
        private static string _LastContextContol = "";
        private static SmallBasicCallback _ContextClickDelegate = null;
        private static void _ContextClickEvent(Object sender, RoutedEventArgs e)
        {
            MenuItem _item = (MenuItem)sender;
            string tag = (string)_item.Tag;
            int div = tag.IndexOf(':');
            _LastContextContol = tag.Substring(0, div);
            _LastContextItem = tag.Substring(div + 1);
            if (null == _ContextClickDelegate) return;
            _ContextClickDelegate();
        }

        private static string _LastRadioButton;
        private static string _LastRadioButtonGroup;
        private static SmallBasicCallback _RadioButtonClickedDelegate = null;
        private static void _RadioButtonClickedEvent(Object sender, RoutedEventArgs e)
        {
            _LastRadioButton = ((RadioButton)sender).Name;
            _LastRadioButtonGroup = ((RadioButton)sender).GroupName;
            if (null == _RadioButtonClickedDelegate) return;
            _RadioButtonClickedDelegate();
        }

        private static SmallBasicCallback _DragDropDelegate = null;
        private static Primitive _LastDropFiles = "";
        private static string _LastDropShape = "";
        private static void _DragOver(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }
        private static void _DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (sender.GetType() == typeof(TextBox) || sender.GetType() == typeof(RichTextBox) || sender.GetType() == typeof(DocumentViewer) || sender.GetType() == typeof(Image) || sender.GetType() == typeof(Window) || sender.GetType() == typeof(MediaElement))
                {
                    e.Effects = DragDropEffects.Copy;
                }
            }
        }
        private static void _DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                try
                {
                    string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (sender.GetType() == typeof(TextBox))
                    {
                        TextBox textBox = (TextBox)sender;
                        if (textBox.AcceptsReturn)
                        {
                            textBox.Text = "";
                            for (int i = 0; i < fileNames.Length; i++)
                            {
                                textBox.Text += fileNames[i];
                                if (i < fileNames.Length - 1) textBox.Text += "\n";
                            }
                        }
                        else
                        {
                            textBox.Text = fileNames[0];
                        }
                    }
                    else if (sender.GetType() == typeof(RichTextBox))
                    {
                        RichTextBox richTextBox = (RichTextBox)sender;
                        if (System.IO.File.Exists(fileNames[0]))
                        {
                            FileStream fStream = new FileStream(fileNames[0], FileMode.OpenOrCreate);
                            TextRange range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                            range.Load(fStream, DataFormats.Rtf);
                            fStream.Close();
                        }
                    }
                    else if (sender.GetType() == typeof(DocumentViewer))
                    {
                        DocumentViewer documentViewer = (DocumentViewer)sender;
                        if (System.IO.File.Exists(fileNames[0]))
                        {
                            XpsDocument doc = new XpsDocument(fileNames[0], FileAccess.Read);
                            documentViewer.Document = doc.GetFixedDocumentSequence();
                        }
                    }
                    else if (sender.GetType() == typeof(Image))
                    {
                        Image image = (Image)sender;
                        BitmapSource img = new BitmapImage(new Uri(fileNames[0]));
                        if (null != img) image.Source = img;
                    }
                    else if (sender.GetType() == typeof(Window))
                    {
                        Window window = (Window)sender;
                        BitmapSource img = new BitmapImage(new Uri(fileNames[0]));
                        if (null != img) window.Background = new ImageBrush(img);
                    }
                    else if (sender.GetType() == typeof(MediaElement))
                    {
                        MediaElement mediaElement = (MediaElement)sender;
                        MediaPlayerLoad(mediaElement.Name, fileNames[0]);
                    }
                    _LastDropFiles = "";
                    for (int i = 0; i < fileNames.Length; i++)
                    {
                        _LastDropFiles[i + 1] = fileNames[i];
                    }
                    _LastDropShape = sender.GetType() == typeof(Window) ? ((Window)sender).Tag.ToString() : ((FrameworkElement)sender).Name;
                    if (null != _DragDropDelegate) _DragDropDelegate();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                e.Handled = true;
            }
        }

        private static string _LastMediaPlayer = "";
        private static SmallBasicCallback _MediaPlayerEndedDelegate = null;
        private static SmallBasicCallback _MediaPlayerOpenedDelegate = null;
        private static void _MediaPlayerEndedEvent(Object sender, RoutedEventArgs e)
        {
            _LastMediaPlayer = ((MediaElement)sender).Name;
            if (null == _MediaPlayerEndedDelegate) return;
            _MediaPlayerEndedDelegate();
        }
        private static void _MediaPlayerOpenedEvent(Object sender, RoutedEventArgs e)
        {
            _LastMediaPlayer = ((MediaElement)sender).Name;
            if (null == _MediaPlayerOpenedDelegate) return;
            _MediaPlayerOpenedDelegate();
        }

        private static double sliderMaximum = 100;
        private static string _LastSlider = "";
        private static double _LastSliderValue = 0;
        private static SmallBasicCallback _SliderChangedDelegate = null;
        private static void _SliderChangedEvent(Object sender, RoutedEventArgs e)
        {
            _LastSlider = ((Slider)sender).Name;
            _LastSliderValue = ((Slider)sender).Value;
            if (null == _SliderChangedDelegate) return;
            _SliderChangedDelegate();
        }

        private static string _LastPasswordBox = "";
        private static string _LastPassword = "";
        private static SmallBasicCallback _PasswordEnteredDelegate = null;
        private static void _PasswordBoxKeyEvent(Object sender, KeyEventArgs e)
        {
            _LastPasswordBox = ((PasswordBox)sender).Name;
            if (null == _PasswordEnteredDelegate || e.Key != Key.Return) return;
            _PasswordEnteredDelegate();
        }
        private static void _PasswordBoxEvent(Object sender, RoutedEventArgs e)
        {
            _LastPassword = ((PasswordBox)sender).Password;
        }

        private static string _LastMenuItem = "";
        private static string _LastMenuContol = "";
        private static SmallBasicCallback _MenuClickDelegate = null;
        private static void _MenuClickEvent(Object sender, RoutedEventArgs e)
        {
            MenuItem _item = (MenuItem)sender;
            _LastMenuContol = (string)_item.Tag;
            _LastMenuItem = (string)_item.Header;
            e.Handled = true;
            if (null == _MenuClickDelegate) return;
            _MenuClickDelegate();
        }
        private static MenuItem findMenuItem(ItemCollection items, string parent)
        {
            foreach (Object i in items)
            {
                if (i.GetType() == typeof(MenuItem))
                {
                    MenuItem item = (MenuItem)i;
                    MenuItem children = findMenuItem(item.Items, parent);
                    if (null != children) return children;
                    if (((string)item.Header).ToLower() == parent) return item;
                }
            }
            return null;
        }
        private static Boolean isSeparator(string labelName)
        {
            for (int i = 0; i < labelName.Length; i++)
            {
                if (labelName[i] != '-') return false;
            }
            return true;
        }
        private static void addMenuItems(string shapeName, ItemCollection items, Primitive menuList, Primitive imageList, Primitive checkList)
        {
            Type ImageListType = typeof(ImageList);
            Dictionary<string, BitmapSource> _savedImages;
            BitmapSource img;

            try
            {
                Primitive indices = SBArray.GetAllIndices(menuList);
                for (int i = 1; i <= SBArray.GetItemCount(indices); i++)
                {
                    string labelName = indices[i];
                    string parentName = menuList[indices[i]];
                    parentName = parentName.ToLower();
                    MenuItem menuItem = new MenuItem();
                    menuItem.Tag = shapeName;
                    menuItem.Header = labelName;
                    menuItem.Name = "Index" + i.ToString();
                    menuItem.Click += new RoutedEventHandler(_MenuClickEvent);
                    // Checked
                    string checkState = checkList[labelName];
                    if (checkState != "")
                    {
                        menuItem.IsCheckable = true;
                        menuItem.IsChecked = checkState.ToLower() == "true";
                    }
                    // Creates the item image.
                    string imageName = imageList[labelName];
                    _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    if (null != _savedImages && imageName != "")
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
                    if (parentName == "main")
                    {
                        items.Add(menuItem);
                    }
                    else
                    {
                        MenuItem parent = findMenuItem(items, parentName);
                        if (null != parent)
                        {
                            if (isSeparator(labelName))
                            {
                                parent.Items.Add(new Separator());
                            }
                            else
                            {
                                parent.Items.Add(menuItem);
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
        private static void menuBrush(ItemCollection items, Brush brush)
        {
            foreach (Object item in items)
            {
                if (item.GetType() == typeof(MenuItem))
                {
                    MenuItem menuItem = (MenuItem)item;
                    menuItem.Background = brush;
                    menuBrush(menuItem.Items, brush);
                }
            }

        }

        private struct DataGridRow
        {
            public string[] col { get; set; }
        }
        private static string _LastListView = "";
        private static string _LastListViewRow = "";
        private static SmallBasicCallback _ListViewSelectionChangedDelegate = null;
        private static void _ListViewSelectionChangedEvent(Object sender, SelectionChangedEventArgs e)
        {
            _LastListView = ((ListView)sender).Name;
            _LastListViewRow = (1 + ((ListView)sender).SelectedIndex).ToString();
            if (null == _ListViewSelectionChangedDelegate) return;
            _ListViewSelectionChangedDelegate();
        }

        private static SmallBasicCallback _DataViewSelectionChangedDelegate = null;
        private static SmallBasicCallback _DataViewButtonClickedDelegate = null;
        private static SmallBasicCallback _DataViewCellValueChangedDelegate = null;
        private static string lastDataView = "";
        private static Primitive lastChanged = "";
        private static Primitive lastButton = "";
        private static string lastTable = "";
        private static void _DataViewSelectionChanged(Object sender, System.EventArgs e)
        {
            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)sender;
            System.Windows.Forms.DataGridViewSelectedCellCollection cells = dataView.SelectedCells;
            if (cells.Count == 0) return;
            DataTable dataTable = (DataTable)dataView.Tag;
            if (null != dataTable) lastTable = dataTable.TableName;
            foreach (System.Windows.Forms.DataGridViewCell cell in cells)
            {
                if (cell.RowIndex >= 0 && cell.RowIndex < dataView.Rows.Count - 1)
                {
                    lastDataView = dataView.Name;
                    if (null != _DataViewSelectionChangedDelegate && dataView.Columns[cell.ColumnIndex].GetType() == typeof(System.Windows.Forms.DataGridViewTextBoxColumn)) _DataViewSelectionChangedDelegate();
                    break;
                }
            }
        }
        private static void _DataViewSelectionSort(Object sender, System.Windows.Forms.DataGridViewSortCompareEventArgs e)
        {
            double d1, d2;
            if (double.TryParse(e.CellValue1.ToString(), out d1) && double.TryParse(e.CellValue2.ToString(), out d2))
            {
                if (d1 > d2) e.SortResult = 1;
                else if (d1 < d2) e.SortResult = -1;
                else e.SortResult = 0;
            }
            else
            {
                e.SortResult = System.String.Compare(e.CellValue1.ToString(), e.CellValue2.ToString());
            }
            e.Handled = true;
        }
        private static void _DataViewDataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
        {
            //TextWindow.WriteLine("DataView Error " + e.Context.ToString() + e.Exception.ToString());

            //if (e.Context == System.Windows.Forms.DataGridViewDataErrorContexts.Commit)
            //{
            //    MessageBox.Show("Commit error");
            //}
            //if (e.Context == System.Windows.Forms.DataGridViewDataErrorContexts.CurrentCellChange)
            //{
            //    MessageBox.Show("Cell change");
            //}
            //if (e.Context == System.Windows.Forms.DataGridViewDataErrorContexts.Parsing)
            //{
            //    MessageBox.Show("parsing error");
            //}
            //if (e.Context == System.Windows.Forms.DataGridViewDataErrorContexts.LeaveControl)
            //{
            //    MessageBox.Show("leave control error");
            //}

            if ((e.Exception) is ConstraintException)
            {
                System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)sender;
                dataView.Rows[e.RowIndex].ErrorText = "Error";
                dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Error";
                e.ThrowException = false;
            }
        }
        private static void _DataViewCellContentClick(Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)sender;
            if (e.RowIndex >= 0 && e.RowIndex < dataView.Rows.Count - 1 && e.ColumnIndex >= 0)
            {
                lastDataView = dataView.Name;
                if (dataView.Columns[e.ColumnIndex].GetType() == typeof(System.Windows.Forms.DataGridViewButtonColumn))
                {
                    lastButton[1] = e.RowIndex + 1;
                    lastButton[2] = e.ColumnIndex + 1;
                    lastButton[3] = (null == dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) ? "" : dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    if (null != _DataViewButtonClickedDelegate) _DataViewButtonClickedDelegate();
                }
                else if (dataView.Columns[e.ColumnIndex].GetType() == typeof(System.Windows.Forms.DataGridViewCheckBoxColumn))
                {
                    dataView.EndEdit();
                }
                else if (dataView.Columns[e.ColumnIndex].GetType() == typeof(System.Windows.Forms.DataGridViewComboBoxColumn))
                {
                    dataView.EndEdit();
                }
            }
        }
        private static void _DataViewEditingControl(Object sender, System.Windows.Forms.DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control.GetType() == typeof(System.Windows.Forms.DataGridViewComboBoxEditingControl))
            {
                System.Windows.Forms.DataGridViewComboBoxEditingControl cb = (System.Windows.Forms.DataGridViewComboBoxEditingControl)e.Control;
                System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)sender;
                if (dataView.CurrentCell.RowIndex >= 0 && dataView.CurrentCell.RowIndex < dataView.Rows.Count - 1 && dataView.CurrentCell.ColumnIndex >= 0)
                {
                    lastDataView = dataView.Name;
                    lastChanged[1] = dataView.CurrentCell.RowIndex + 1;
                    lastChanged[2] = dataView.CurrentCell.ColumnIndex + 1;
                    cb.SelectedIndexChanged += new EventHandler(_DataViewSelectedIndexChanged);
                }
            }
        }
        private static void _DataViewSelectedIndexChanged(Object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewComboBoxEditingControl cb = (System.Windows.Forms.DataGridViewComboBoxEditingControl)sender;
            cb.SelectedIndexChanged -= new EventHandler(_DataViewSelectedIndexChanged);
            lastChanged[3] = cb.SelectedItem.ToString();
            if (null != _DataViewCellValueChangedDelegate) _DataViewCellValueChangedDelegate();
        }
        private static void _DataViewCellValueChanged(Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)sender;
            dataView.AutoResizeColumns(System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells);
            //dataView.AutoResizeRows(System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells);
            if (e.RowIndex >= 0 && e.RowIndex < dataView.Rows.Count - 1 && e.ColumnIndex >= 0)
            {
                lastDataView = dataView.Name;
                lastChanged[1] = e.RowIndex + 1;
                lastChanged[2] = e.ColumnIndex + 1;
                lastChanged[3] = (null == dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) ? "" : dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (dataView.Columns[e.ColumnIndex].GetType() != typeof(System.Windows.Forms.DataGridViewComboBoxColumn) && null != _DataViewCellValueChangedDelegate) _DataViewCellValueChangedDelegate();
            }
        }
        private static void _DataViewBindingComplete(Object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            //System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)sender;
            //dataView.AutoResizeColumns(System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells);
            //dataView.AutoResizeRows(System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells);
        }
        private static void _DataViewRowPrePaint(Object sender, System.Windows.Forms.DataGridViewRowPrePaintEventArgs e)
        {
            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)sender;
            if (e.RowIndex >= 0 && e.RowIndex < dataView.Rows.Count - 1)
            {
                String hdrNum = String.Format("{0}", e.RowIndex + 1);
                if (dataView.Rows[e.RowIndex].HeaderCell.Value == null || hdrNum != dataView.Rows[e.RowIndex].HeaderCell.Value.ToString())
                {
                    dataView.Rows[e.RowIndex].HeaderCell.Value = hdrNum;
                }
            }
        }
        private static void _DataViewMouseUp(Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Right) return;
            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)sender;
            dataView.ContextMenu.Show(dataView, new System.Drawing.Point(e.X, e.Y));
        }
        private static void _DataViewCopyRows(Object sender, System.EventArgs e)
        {
            System.Windows.Forms.MenuItem menuItem = (System.Windows.Forms.MenuItem)sender;
            System.Windows.Forms.ContextMenu contextMenu = (System.Windows.Forms.ContextMenu)menuItem.Parent;
            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)contextMenu.SourceControl;
            System.Windows.Forms.DataGridViewSelectedRowCollection rows = dataView.SelectedRows;
            if (rows.Count == 0) return;

            foreach (System.Windows.Forms.DataGridViewRow row in rows)
            {
                DataViewSetRow(dataView.Name, dataView.Rows.Count, DataViewGetRow(dataView.Name, row.Index + 1));
            }
            dataView.Refresh();
        }
        private static void _DataViewDeleteRows(Object sender, System.EventArgs e)
        {
            System.Windows.Forms.MenuItem menuItem = (System.Windows.Forms.MenuItem)sender;
            System.Windows.Forms.ContextMenu contextMenu = (System.Windows.Forms.ContextMenu)menuItem.Parent;
            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)contextMenu.SourceControl;
            System.Windows.Forms.DataGridViewSelectedRowCollection rows = dataView.SelectedRows;
            if (rows.Count == 0) return;

            foreach (System.Windows.Forms.DataGridViewRow row in rows)
            {
                DataViewDeleteRow(dataView.Name, row.Index + 1);
            }
            dataView.Refresh();
        }
        private static void _DataViewAll(Object sender, System.EventArgs e)
        {
            System.Windows.Forms.MenuItem menuItem = (System.Windows.Forms.MenuItem)sender;
            System.Windows.Forms.ContextMenu contextMenu = (System.Windows.Forms.ContextMenu)menuItem.Parent;
            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)contextMenu.SourceControl;
            dataView.SelectAll();
            dataView.Rows[dataView.Rows.Count - 1].Selected = false;
        }
        private static void _DataViewCopy(Object sender, System.EventArgs e)
        {
            System.Windows.Forms.MenuItem menuItem = (System.Windows.Forms.MenuItem)sender;
            System.Windows.Forms.ContextMenu contextMenu = (System.Windows.Forms.ContextMenu)menuItem.Parent;
            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)contextMenu.SourceControl;
            System.Windows.Forms.DataObject data = dataView.GetClipboardContent();
            Clipboard.SetDataObject(data);
        }
        private static void _DataViewPaste(Object sender, System.EventArgs e)
        {
            System.Windows.Forms.MenuItem menuItem = (System.Windows.Forms.MenuItem)sender;
            System.Windows.Forms.ContextMenu contextMenu = (System.Windows.Forms.ContextMenu)menuItem.Parent;
            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)contextMenu.SourceControl;
            _DataViewPasteClipboard(dataView);
        }
        private static void _DataViewKeyDown(Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)sender;
            if (e.Control && e.KeyCode == System.Windows.Forms.Keys.A)
            {
                dataView.SelectAll();
                dataView.Rows[dataView.Rows.Count - 1].Selected = false;
            }
            else if (e.Control && e.KeyCode == System.Windows.Forms.Keys.C)
            {
                System.Windows.Forms.DataObject data = dataView.GetClipboardContent();
                Clipboard.SetDataObject(data);
            }
            else if (e.Control && e.KeyCode == System.Windows.Forms.Keys.V)
            {
                _DataViewPasteClipboard(dataView);
            }
            e.Handled = true;
        }
        private static void _DataViewPasteClipboard(System.Windows.Forms.DataGridView dataView)
        {
            try
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int iRow = dataView.CurrentCell.RowIndex;
                int iCol = dataView.CurrentCell.ColumnIndex;
                DataTable dataTable = (DataTable)dataView.Tag;
                int maxId = 0, Id;
                bool indexed = false;
                if (null != dataTable)
                {
                    indexed = dataTable.Columns[0].ColumnName.ToLower() == "id" && (dataTable.Columns[0].DataType == typeof(Int64) || dataTable.Columns[0].DataType == typeof(Int32));
                    if (indexed)
                    {
                        foreach (DataRow dataRow in dataTable.Rows)
                        {
                            if (int.TryParse(dataRow.ItemArray[0].ToString(), out Id)) maxId = System.Math.Max(maxId, Id);
                        }
                    }
                }
                bool addRow = false;
                foreach (string line in lines)
                {
                    TextWindow.WriteLine(line);
                    if (line.Length == 0) continue;
                    if (addRow || iRow >= dataView.RowCount - 1)
                    {
                        addRow = true;
                        if (null == dataTable)
                        {
                            System.Windows.Forms.DataGridViewRow newRow = (System.Windows.Forms.DataGridViewRow)dataView.RowTemplate.Clone();
                            newRow.CreateCells(dataView);
                            dataView.Rows.Add(newRow);
                        }
                        else
                        {
                            DataRow newDataRow = dataTable.NewRow();
                            newDataRow.ItemArray = new Object[newDataRow.ItemArray.Length];
                            dataTable.Rows.Add(newDataRow);
                        }
                    }
                    string[] sCells = line.Split('\t');
                    int insertCol = iCol;
                    bool hasHeader = sCells.GetLength(0) == dataView.Columns.Count + 1;
                    if (hasHeader) insertCol--;
                    for (int i = 0; i < sCells.GetLength(0); ++i)
                    {
                        if (insertCol + i >= 0 && insertCol + i < dataView.ColumnCount)
                        {
                            if (indexed && insertCol + i == 0) continue;
                            DataViewSetValue(dataView.Name, iRow + 1, insertCol + i + 1, sCells[i]);
                        }
                    }
                    if (addRow && indexed) DataViewSetValue(dataView.Name, iRow + 1, 1, ++maxId);
                    iRow++;
                }
                dataView.EndEdit();
                //Delete strange extra row?
                if (addRow && null != dataTable && dataView.Rows.Count == iRow + 2)
                {
                    dataView.Rows.RemoveAt(dataView.Rows.Count - 2);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Add a treeview dialog control.
        /// </summary>
        /// <param name="tree">
        /// A 2D array containing the treeview data.
        /// 
        /// The first index is the row or node number and the second index is the parent node of the current node (0 for top level).
        /// The value of the array is the display text at the current node.
        /// 
        /// tree[1][0] = "Level 1"
        /// tree[2][1] = "Level 1 1"
        /// tree[3][1] = "Level 1 2"
        /// tree[4][0] = "Level 2"
        /// </param>
        /// <param name="width">The width of the control.</param>
        /// <param name="height">The height of the control.</param>
        /// <returns>The treeview shape name.</returns>
        public static Primitive AddTreeView(Primitive tree, Primitive width, Primitive height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        TreeView treeView = new TreeView();
                        treeView.Width = width;
                        treeView.Height = height;

                        Primitive index, parent, value;
                        Primitive treeIndex = SBArray.GetAllIndices(tree);
                        for (int i = 1; i <= SBArray.GetItemCount(treeIndex); i++)
                        {
                            index = treeIndex[i];
                            parent = SBArray.GetAllIndices(tree[index])[1];
                            value = tree[index][parent];

                            TreeViewItem item = new TreeViewItem();
                            item.Header = value;
                            item.Name = "Index" + index;
                            item.PreviewMouseDown += new MouseButtonEventHandler(_TreeViewItemChangedEvent);

                            if (parent == 0)
                            {
                                treeView.Items.Add(item);
                            }
                            else
                            {
                                TreeViewItem itemParent = findTreeItem(treeView.Items, "Index" + parent);
                                if (null != itemParent) itemParent.Items.Add(item);
                            }
                        }

                        treeView.SelectedItemChanged += new RoutedPropertyChangedEventHandler<object>(_TreeViewItemChangedEvent);

                        AddControl(shapeName, treeView);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Event when a treeview selection changes or selected item is clicked.
        /// </summary>
        public static event SmallBasicCallback TreeViewItemChanged
        {
            add
            {
                _TreeViewItemChanged = value;
            }
            remove
            {
                _TreeViewItemChanged = null;
            }
        }

        /// <summary>
        /// The last treeview where a selection changed.
        /// </summary>
        public static Primitive LastTreeView
        {
            get { return _LastTreeView; }
        }

        /// <summary>
        /// The last treeview selection changed index (row number).
        /// </summary>
        public static Primitive LastTreeViewIndex
        {
            get { return _LastTreeViewIndex; }
        }

        /// <summary>
        /// Expand/collapse nodes in a treeview below input node.
        /// </summary>
        /// <param name="shapeName">The treeview shape name.</param>
        /// <param name="node">Node number to expand/collapse, 0 recusively expands/collapses all nodes.</param>
        /// <param name="expand">Expand or collapse "True" or "False"</param>
        /// <param name="recursive">Recursively expand/collapse nodes (all children nodes) "True" or "False"</param>
        public static void TreeViewExpand(Primitive shapeName, Primitive node, Primitive expand, Primitive recursive)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(TreeView))
                        {
                            TreeView treeView = (TreeView)obj;
                            if (node == 0)
                            {
                                expandNode(treeView.Items, expand);
                            }
                            else
                            {
                                TreeViewItem item = findTreeItem(treeView.Items, "Index" + node);
                                if (null != item)
                                {
                                    item.IsExpanded = expand;
                                    if (recursive) expandNode(item.Items, expand);
                                }
                            }
                        }
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
        /// Select a node in a treeview.
        /// </summary>
        /// <param name="shapeName">The treeview shape name.</param>
        /// <param name="node">The node to select.</param>       
        public static void TreeViewSelect(Primitive shapeName, Primitive node)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(TreeView))
                        {
                            TreeView treeView = (TreeView)obj;
                            TreeViewItem item = findTreeItem(treeView.Items, "Index" + node);
                            if (null != item)
                            {
                                item.BringIntoView();
                                item.Focus();
                                //item.IsSelected = true;
                            }
                        }
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
        /// Get a treeview selected node.
        /// </summary>
        /// <param name="shapeName">The treeview to get node.</param>
        /// <returns>The treeview selected node.</returns>
        public static Primitive TreeViewGetSelected(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "";
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(TreeView))
                        {
                            TreeView treeView = (TreeView)obj;
                            if (null == treeView.SelectedItem) return "";
                            return ((TreeViewItem)(treeView.SelectedItem)).Name.Substring(5);
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return "";
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Replace a treeview tree.
        /// </summary>
        /// <param name="shapeName">The treeview shape name.</param>
        /// <param name="tree">
        /// A 2D array containing the treeview data.
        /// 
        /// The first index is the row or node number and the second index is the parent node of the current node (0 for top level).
        /// The value of the array is the display text at the current node.
        /// 
        /// tree[1][0] = "Level 1"
        /// tree[2][1] = "Level 1 1"
        /// tree[3][1] = "Level 1 2"
        /// tree[4][0] = "Level 2"
        /// </param>
        public static void TreeViewContent(Primitive shapeName, Primitive tree)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(TreeView))
                        {
                            TreeView treeView = (TreeView)obj;
                            treeView.SelectedItemChanged -= new RoutedPropertyChangedEventHandler<object>(_TreeViewItemChangedEvent);
                            treeView.Items.Clear();

                            Primitive index, parent, value;
                            Primitive treeIndex = SBArray.GetAllIndices(tree);
                            for (int i = 1; i <= SBArray.GetItemCount(treeIndex); i++)
                            {
                                index = treeIndex[i];
                                parent = SBArray.GetAllIndices(tree[index])[1];
                                value = tree[index][parent];

                                TreeViewItem item = new TreeViewItem();
                                item.Header = value;
                                item.Name = "Index" + index;
                                item.PreviewMouseDown += new MouseButtonEventHandler(_TreeViewItemChangedEvent);

                                if (parent == 0)
                                {
                                    treeView.Items.Add(item);
                                }
                                else
                                {
                                    TreeViewItem itemParent = findTreeItem(treeView.Items, "Index" + parent);
                                    if (null != itemParent) itemParent.Items.Add(item);
                                }
                            }

                            treeView.SelectedItemChanged += new RoutedPropertyChangedEventHandler<object>(_TreeViewItemChangedEvent);
                        }
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
        /// Get the data from a treeview tree.
        /// </summary>
        /// <param name="shapeName">The treeview shape name.</param>
        /// <returns>
        /// A 2D array containing the treeview data.
        /// 
        /// The first index is the row or node number and the second index is the parent node of the current node (0 for top level).
        /// The value of the array is the display text at the current node.
        /// 
        /// tree[1][0] = "Level 1"
        /// tree[2][1] = "Level 1 1"
        /// tree[3][1] = "Level 1 2"
        /// tree[4][0] = "Level 2"
        /// </returns>
        public static Primitive TreeViewGetData(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "";
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(TreeView))
                        {
                            TreeView treeView = (TreeView)obj;
                            Primitive result = "";
                            getNodes(treeView.Items, 0, ref result);
                            return result;
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return "";
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Change a treeview node editable status.
        /// </summary>
        /// <param name="shapeName">The treeview shape name.</param>
        /// <param name="node">The node to select.</param>       
        /// <param name="editable">"True" an editable TextBox or "False" uneditable.</param>
        public static void TreeViewEdit(Primitive shapeName, Primitive node, Primitive editable)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(TreeView))
                        {
                            TreeView treeView = (TreeView)obj;
                            TreeViewItem item = findTreeItem(treeView.Items, "Index" + node);
                            if (null != item)
                            {
                                if (editable && item.Header.GetType() == typeof(Primitive))
                                {
                                    TextBox tb = new TextBox();
                                    tb.Text = (Primitive)item.Header;
                                    tb.SelectAll();
                                    item.Header = tb;
                                    treeView.UpdateLayout();
                                    tb.Focus();
                                }
                                else if (!editable && item.Header.GetType() == typeof(TextBox))
                                {
                                    TextBox tb = (TextBox)item.Header;
                                    item.Header = (Primitive)tb.Text;
                                }
                            }
                        }
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
        /// Add a RichTextBox.
        /// Drag and drop is auto set for this control.
        /// </summary>
        /// <param name="width">The width of the RichTextBox.</param>
        /// <param name="height">The height of the RichTextBox.</param>
        /// <returns>The RichTextBox name.</returns>
        public static Primitive AddRichTextBox(Primitive width, Primitive height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        RichTextBox richTextBox = new RichTextBox();
                        richTextBox.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
                        richTextBox.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
                        //richTextBox.Document.PageWidth = 1000;
                        richTextBox.Document.TextAlignment = textAlignment;
                        richTextBox.AllowDrop = true;
                        richTextBox.PreviewDragOver += new DragEventHandler(_DragOver);
                        richTextBox.DragEnter += new DragEventHandler(_DragEnter);
                        richTextBox.Drop += new DragEventHandler(_DragDrop);
                        richTextBox.Name = shapeName;
                        richTextBox.IsReadOnly = readOnly;
                        richTextBox.Width = width;
                        richTextBox.Height = height;

                        richTextBox.Document.Blocks.Clear();

                        ContextMenu menu = new ContextMenu();
                        richTextBox.ContextMenu = menu;

                        MenuItem item = new MenuItem();
                        item.Command = ApplicationCommands.Cut;
                        menu.Items.Add(item);

                        item = new MenuItem();
                        item.Command = ApplicationCommands.Copy;
                        menu.Items.Add(item);

                        item = new MenuItem();
                        item.Command = ApplicationCommands.Paste;
                        menu.Items.Add(item);

                        item = new MenuItem();
                        item.Command = ApplicationCommands.SelectAll;
                        menu.Items.Add(item);

                        AddControl(shapeName, richTextBox);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Add a right click context menu for a control or shape that supports context menus.
        /// </summary>
        /// <param name="shapeName">The control or shape name.</param>
        /// <param name="items">An array of context menu item selection texts.</param>
        /// <param name="images">Optional array of image icons, any or all may be "".
        /// They may be the result of ImageList.LoadImage or local or network image file.</param>
        public static void AddContextMenu(Primitive shapeName, Primitive items, Primitive images)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Type ImageListType = typeof(ImageList);
            Dictionary<string, UIElement> _objectsMap;
            Dictionary<string, BitmapSource> _savedImages;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        ContextMenu menu = (ContextMenu)obj.GetType().GetProperty("ContextMenu").GetValue(obj, null);

                        ContextMenu menu2 = LDDialogs.getMenu(_savedImages, items, images, iconSize);
                        //Add top level options
                        if (null != menu2)
                        {
                            if (null == menu)
                            {
                                menu = new ContextMenu();
                            }
                            else
                            {
                                menu.Items.Add(new Separator());
                            }
                            foreach (MenuItem menuItem in menu2.Items)
                            {
                                MenuItem item = new MenuItem();
                                item.Header = menuItem.Header;
                                item.Tag = shapeName + ":" + menuItem.Tag;
                                item.Icon = menuItem.Icon;
                                item.Click += new RoutedEventHandler(_ContextClickEvent);
                                menu.Items.Add(item);
                            }
                        }

                        obj.GetType().GetProperty("ContextMenu").SetValue(obj, menu, null);
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
        /// Event when a shape or control right click context menu item is selected.
        /// </summary>
        public static event SmallBasicCallback ContextMenuClicked
        {
            add
            {
                _ContextClickDelegate = value;
            }
            remove
            {
                _ContextClickDelegate = null;
            }
        }

        /// <summary>
        /// The contol or shape of the last right click context menu item selected.
        /// </summary>
        public static Primitive LastContextControl
        {
            get { return _LastContextContol; }
        }

        /// <summary>
        /// The index of the last shape or control right click context menu item selected.
        /// </summary>
        public static Primitive LastContextItem
        {
            get { return _LastContextItem; }
        }

        /// <summary>
        /// Save RichTextBox text and formatting to a file in rtf format.
        /// </summary>
        /// <param name="shapeName">The RichTextBox control.</param>
        /// <param name="fileName">File to save the text and formatting to.</param>    
        /// <returns>None.</returns>
        public static void RichTextBoxSave(Primitive shapeName, Primitive fileName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(RichTextBox))
                        {
                            RichTextBox richTextBox = (RichTextBox)obj;
                            TextRange range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                            FileStream fStream = new FileStream(fileName, FileMode.Create);
                            range.Save(fStream, DataFormats.Rtf);
                            fStream.Close();
                        }
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
        /// Load text and formatting from a file in rtf format to a RichTextBox.
        /// </summary>
        /// <param name="shapeName">The RichTextBox control.</param>
        /// <param name="fileName">File to load the text and formatting from.</param>    
        /// <param name="append">Append to existing text "True" or "False".</param>    
        /// <returns>None.</returns>
        public static void RichTextBoxLoad(Primitive shapeName, Primitive fileName, Primitive append)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return;
            }
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(RichTextBox))
                        {
                            RichTextBox richTextBox = (RichTextBox)obj;
                            FileStream fStream = new FileStream(fileName, FileMode.OpenOrCreate);
                            TextRange range = new TextRange(append ? richTextBox.Document.ContentEnd : richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                            range.Load(fStream, DataFormats.Rtf);
                            fStream.Close();
                        }
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
        /// Set margins (in pixels) for RichTextBox paragraphs.
        /// A new paragraph is created for each text appended (or created) using RichTextBoxSetText.
        /// </summary>
        /// <param name="left">Left margin (default 0).</param>
        /// <param name="right">Right margin (default 0).</param>
        /// <param name="top">Top margin (default 0).</param>
        /// <param name="bottom">Bottom margin (default 0).</param>
        public static void RichTextBoxMargins(Primitive left, Primitive right, Primitive top, Primitive bottom)
        {
            thickness.Left = left;
            thickness.Right = right;
            thickness.Top = top;
            thickness.Bottom = bottom;
        }

        /// <summary>
        /// Set text (unformatted) in a RichTextBox.
        /// </summary>
        /// <param name="shapeName">The RichTextBox control.</param>
        /// <param name="text">Text to load.</param>    
        /// <param name="append">Append to existing text "True" or "False".
        /// A new paragraph is created if text is appended.  See RichTextBoxMargins to set margins for the paragraph.</param>    
        /// <returns>None.</returns>
        public static void RichTextBoxSetText(Primitive shapeName, Primitive text, Primitive append)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(RichTextBox))
                        {
                            RichTextBox richTextBox = (RichTextBox)obj;
                            TextRange range = new TextRange(append ? richTextBox.Document.ContentEnd : richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                            if (!append) richTextBox.Document.Blocks.Clear();
                            Paragraph paragraph = new Paragraph(new Run(text));
                            paragraph.Margin = thickness;
                            richTextBox.Document.Blocks.Add(paragraph);
                        }
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
        /// Get text (unformatted) in a RichTextBox.
        /// </summary>
        /// <param name="shapeName">The RichTextBox control.</param>
        /// <returns>The text.</returns>
        public static Primitive RichTextBoxGetText(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "";
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(RichTextBox))
                        {
                            RichTextBox richTextBox = (RichTextBox)obj;
                            TextRange range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                            return range.Text;
                        }
                        return "";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set a font style of selected RichTextBox text using the current RichTextBox Properties.
        /// </summary>
        /// <param name="shapeName">The RichTextBox control.</param>
        /// <returns>None.</returns>
        public static void RichTextBoxSelection(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(RichTextBox))
                        {
                            RichTextBox richTextBox = (RichTextBox)obj;
                            TextSelection textSelection = richTextBox.Selection;
                            ApplySelection(textSelection);
                        }
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
        /// Set a font style of a word or phrase using the current RichTextBox Properties.
        /// </summary>
        /// <param name="shapeName">The RichTextBox control.</param>
        /// <param name="text">The text to change (Case sensitive set by RichTextBoxCaseSensitive parameter).</param>
        /// <param name="mode">Contol over which instances of the word or phrase to set.
        /// 0 - All instances
        /// 1 - First instance
        /// 2 - Last instance</param>
        /// <returns>None.</returns>
        public static void RichTextBoxWord(Primitive shapeName, Primitive text, Primitive mode)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(RichTextBox))
                        {
                            RichTextBox richTextBox = (RichTextBox)obj;
                            TextPointer start = richTextBox.Document.ContentStart;
                            TextRange textSelection = FindWordFromPosition(start, text);
                            while (null != textSelection)
                            {
                                if (mode == 0)
                                {
                                    ApplySelection(textSelection);
                                    start = textSelection.End;
                                    textSelection = FindWordFromPosition(start, text);
                                }
                                else if (mode == 1)
                                {
                                    ApplySelection(textSelection);
                                    textSelection = null;
                                }
                                else if (mode == 2)
                                {
                                    TextRange textSelectionNext = FindWordFromPosition(start, text);
                                    if (null == textSelectionNext)
                                    {
                                        ApplySelection(textSelection);
                                        textSelection = null;
                                    }
                                    else
                                    {
                                        textSelection = textSelectionNext;
                                        start = textSelection.End;
                                    }
                                }
                            }
                        }
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
        /// Set a default font style using the current RichTextBox Properties.
        /// Note RichTextBoxFontDecoration not available for this option.
        /// </summary>
        /// <param name="shapeName">The RichTextBox control.</param>
        /// <returns>None.</returns>
        public static void RichTextBoxDefault(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(RichTextBox))
                        {
                            RichTextBox richTextBox = (RichTextBox)obj;
                            FlowDocument flowDocument = richTextBox.Document;
                            flowDocument.FontWeight = fontBold ? FontWeights.Bold : FontWeights.Normal;
                            flowDocument.FontStyle = fontItalic ? FontStyles.Italic : FontStyles.Normal;
                            flowDocument.FontSize = fontSize;
                            //TextDecoration
                            flowDocument.FontFamily = new System.Windows.Media.FontFamily(fontFamily);
                            System.Windows.Media.Brush brush = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(fontForeground));
                            flowDocument.Foreground = brush;
                            brush = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(fontBackground));
                            flowDocument.Background = brush;
                        }
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
        /// Clear all text from the RichTextBox.
        /// </summary>
        /// <param name="shapeName">The RichTextBox control.</param>
        /// <returns>None.</returns>
        public static void RichTextBoxClear(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(RichTextBox))
                        {
                            RichTextBox richTextBox = (RichTextBox)obj;
                            richTextBox.Document.Blocks.Clear();
                        }
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
        /// The font bold style "True" or "False".
        /// Set this before RichTextBoxSelection, RichTextBoxWord or RichTextBoxDefault is called.
        /// </summary>
        public static Primitive RichTextBoxFontBold
        {
            get { return fontBold; }
            set { fontBold = value; }
        }

        /// <summary>
        /// The font italic style "True" or "False".
        /// Set this before RichTextBoxSelection, RichTextBoxWord or RichTextBoxDefault is called.
        /// </summary>
        public static Primitive RichTextBoxFontItalic
        {
            get { return fontItalic; }
            set { fontItalic = value; }
        }

        /// <summary>
        /// The font underline style "True" or "False".
        /// Set this before RichTextBoxSelection, RichTextBoxWord or RichTextBoxDefault is called.
        /// </summary>
        public static Primitive RichTextBoxFontUnderline
        {
            get { return fontUnderline; }
            set { fontUnderline = value; }
        }

        /// <summary>
        /// The font point size.
        /// Set this before RichTextBoxSelection, RichTextBoxWord or RichTextBoxDefault is called.
        /// </summary>
        public static Primitive RichTextBoxFontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }

        /// <summary>
        /// The font family e.g. "Century Gothic".
        /// Set this before RichTextBoxSelection, RichTextBoxWord or RichTextBoxDefault is called.
        /// </summary>
        public static Primitive RichTextBoxFontFamily
        {
            get { return fontFamily; }
            set { fontFamily = value; }
        }

        /// <summary>
        /// The font foreground colour.
        /// Set this before RichTextBoxSelection, RichTextBoxWord or RichTextBoxDefault is called.
        /// </summary>
        public static Primitive RichTextBoxFontForeground
        {
            get { return fontForeground; }
            set { fontForeground = value; }
        }

        /// <summary>
        /// The font background colour.
        /// Set this before RichTextBoxSelection, RichTextBoxWord or RichTextBoxDefault is called.
        /// </summary>
        public static Primitive RichTextBoxFontBackground
        {
            get { return fontBackground; }
            set { fontBackground = value; }
        }

        /// <summary>
        /// The text alignment "Center" "Left" "Right" or "Justify".
        /// Set this before AddRichTextBox is called.
        /// </summary>
        public static Primitive RichTextBoxTextAlignment
        {
            get { return textAlignment.ToString(); }
            set
            {
                switch (((string)value).ToLower())
                {
                    case "center":
                        textAlignment = TextAlignment.Center;
                        break;
                    case "left":
                        textAlignment = TextAlignment.Left;
                        break;
                    case "right":
                        textAlignment = TextAlignment.Right;
                        break;
                    case "justify":
                        textAlignment = TextAlignment.Justify;
                        break;
                }
            }
        }

        /// <summary>
        /// The read only state for the RichTextBox "True" or "False.
        /// Set this before AddRichTextBox is called.
        /// </summary>
        public static Primitive RichTextBoxReadOnly
        {
            get { return readOnly ? "True" : "False"; }
            set { readOnly = value; }
        }

        /// <summary>
        /// Whether word or phrase highlighting is case sensitive "True" or "False" (default).
        /// Set this before RichTextBoxWord is called.
        /// </summary>
        public static Primitive RichTextBoxCaseSensitive
        {
            get { return caseSensitive ? "True" : "False"; }
            set { caseSensitive = value; }
        }

        /// <summary>
        /// Add a web browser.
        /// </summary>
        /// <param name="width">The browser width.</param>
        /// <param name="height">The browser height.</param>
        /// <param name="url">The html pane to load (e.g. http://smallbasic.com or www.google.com)</param>
        /// <returns>The browser control name.</returns>
        public static Primitive AddBrowser(Primitive width, Primitive height, Primitive url)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            Canvas _mainCanvas;
            string shapeName;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        WebBrowser webBrowser = new WebBrowser();
                        webBrowser.Navigate(getUri(url));
                        webBrowser.Width = width;
                        webBrowser.Height = height;
                        webBrowser.Name = shapeName;
                        webBrowser.LoadCompleted += new System.Windows.Navigation.LoadCompletedEventHandler(_LoadCompletedEvent);

                        _objectsMap[shapeName] = webBrowser;
                        _mainCanvas.Children.Add(webBrowser);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set a web browser page.
        /// </summary>
        /// <param name="shapeName">The browser name.</param>
        /// <param name="url">The html pane to load (e.g. http://smallbasic.com or www.google.com)</param>
        public static void BrowserSetURL(Primitive shapeName, Primitive url)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(WebBrowser))
                        {
                            WebBrowser webBrowser = (WebBrowser)obj;
                            webBrowser.Navigate(getUri(url));
                        }
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
        /// Move browser page forward or backwards.
        /// </summary>
        /// <param name="shapeName">The browser name.</param>
        /// <param name="direction">"F" or "B" for forwards or backwards.</param>
        public static void BrowserNavigate(Primitive shapeName, Primitive direction)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(WebBrowser))
                        {
                            WebBrowser webBrowser = (WebBrowser)obj;
                            switch (direction.ToString().ToLower())
                            {
                                case "f":
                                    webBrowser.GoForward();
                                    break;
                                case "b":
                                    webBrowser.GoBack();
                                    break;
                            }
                        }
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
        /// Event when a browser page is loaded.
        /// </summary>
        public static event SmallBasicCallback BrowserPageLoaded
        {
            add
            {
                _LoadCompleted = value;
            }
            remove
            {
                _LoadCompleted = null;
            }
        }

        /// <summary>
        /// The last browser where a page was loaded.
        /// </summary>
        public static Primitive LastBrowser
        {
            get { return _LastBrowser; }
        }

        /// <summary>
        /// The last browser page loaded (the url).
        /// </summary>
        public static Primitive LastBrowserPage
        {
            get { return _LastBrowserPage; }
        }

        /// <summary>
        /// Get an array of the browser history (pages loaded).
        /// </summary>
        /// <param name="shapeName">The browser name.</param>
        /// <returns>The array of urls in the history.</returns>
        public static Primitive BrowserHistory(Primitive shapeName)
        {
            string history = "";
            int i = 1;
            foreach (string url in browserHistory)
            {
                history += (i++).ToString() + "=" + Utilities.ArrayParse(url) + ";";
            }
            return Utilities.CreateArrayMap(history);
        }

        /// <summary>
        /// Add a listbox dialog control.
        /// </summary>
        /// <param name="list">
        /// An array containing the listbox data.
        /// 
        /// The first index is the row or node number and the value of the array is the display text at the current node.
        /// 
        /// list[1] = "Option 1"
        /// list[2] = "Option 2"
        /// list[3] = "Option 3"
        /// list[4] = "Option 4"
        /// </param>
        /// <param name="width">The width of the control.</param>
        /// <param name="height">The height of the control.</param>
        /// <returns>The listbox shape name.</returns>
        public static Primitive AddListBox(Primitive list, Primitive width, Primitive height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        ListBox listBox = new ListBox();
                        listBox.Width = width;
                        listBox.Height = height;

                        Primitive index, value;
                        Primitive listIndex = SBArray.GetAllIndices(list);
                        for (int i = 1; i <= SBArray.GetItemCount(listIndex); i++)
                        {
                            index = listIndex[i];
                            value = list[index];

                            ListBoxItem item = new ListBoxItem();
                            item.Content = value;
                            item.Name = "Index" + index;
                            item.PreviewMouseDown += new MouseButtonEventHandler(_ListBoxItemChangedEvent);
                            listBox.Items.Add(item);
                        }

                        listBox.SelectionChanged += new SelectionChangedEventHandler(_ListBoxItemChangedEvent);

                        AddControl(shapeName, listBox);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Event when a listbox selection changes or selected item is clicked.
        /// </summary>
        public static event SmallBasicCallback ListBoxItemChanged
        {
            add
            {
                _ListBoxItemChanged = value;
            }
            remove
            {
                _ListBoxItemChanged = null;
            }
        }

        /// <summary>
        /// The last listbox where a selection changed.
        /// </summary>
        public static Primitive LastListBox
        {
            get { return _LastListBox; }
        }

        /// <summary>
        /// The last listbox selection changed index (row number).
        /// </summary>
        public static Primitive LastListBoxIndex
        {
            get { return _LastListBoxIndex; }
        }

        /// <summary>
        /// Select a node or nodes in a listbox.
        /// </summary>
        /// <param name="shapeName">The listbox shape name.</param>
        /// <param name="node">The node number to select.
        /// This can be an array of nodes if the selection mode is not single (see ListBoxSelectionMode).</param>       
        public static void ListBoxSelect(Primitive shapeName, Primitive node)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(ListBox))
                        {
                            ListBox listBox = (ListBox)obj;
                            if (!SBArray.IsArray(node))
                            {
                                foreach (ListBoxItem item in listBox.Items)
                                {
                                    if (item.Name == "Index" + node)
                                    {
                                        listBox.SelectedItem = item;
                                        break;
                                    }
                                }
                            }
                            else if (SBArray.IsArray(node) && listBox.SelectionMode != SelectionMode.Single)
                            {
                                listBox.SelectedItems.Clear();
                                foreach (ListBoxItem item in listBox.Items)
                                {
                                    Primitive nodeItems = SBArray.GetAllIndices(node);
                                    for (int i = 1; i <= SBArray.GetItemCount(node); i++)
                                    {
                                        if (item.Name == "Index" + node[nodeItems[i]])
                                        {
                                            listBox.SelectedItems.Add(item);
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
        /// Get a listbox selected node.
        /// </summary>
        /// <param name="shapeName">The listbox to get node.</param>
        /// <returns>The listbox selected node number.
        /// If the selection mode is not single (see ListBoxSelectionMode) then an array of nodes is returned.
        /// The return is "" for no selected nodes.</returns>
        public static Primitive ListBoxGetSelected(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "";
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(ListBox))
                        {
                            ListBox listBox = (ListBox)obj;
                            if (null == listBox.SelectedItem) return "";
                            if (listBox.SelectionMode == SelectionMode.Single) return ((ListBoxItem)(listBox.SelectedItem)).Name.Substring(5);
                            string result = "";
                            int i = 1;
                            foreach (ListBoxItem item in listBox.SelectedItems)
                            {
                                result += (i++).ToString() + "=" + Utilities.ArrayParse(item.Name.Substring(5)) + ";";
                            }
                            return Utilities.CreateArrayMap(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return "";
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Add a combobox dialog control.
        /// </summary>
        /// <param name="list">
        /// An array containing the combobox data.
        /// 
        /// The first index is the row or node number and the value of the array is the display text at the current node.
        /// 
        /// list[1] = "Option 1"
        /// list[2] = "Option 2"
        /// list[3] = "Option 3"
        /// list[4] = "Option 4"
        /// </param>
        /// <param name="width">The width of the control.</param>
        /// <param name="height">The drop down height of the control.</param>
        /// <returns>The combobox shape name.</returns>
        public static Primitive AddComboBox(Primitive list, Primitive width, Primitive height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        ComboBox comboBox = new ComboBox();
                        comboBox.Width = width;
                        comboBox.MaxDropDownHeight = height;
                        comboBox.SelectedIndex = 0;

                        Primitive index, value;
                        Primitive listIndex = SBArray.GetAllIndices(list);
                        for (int i = 1; i <= SBArray.GetItemCount(listIndex); i++)
                        {
                            index = listIndex[i];
                            value = list[index];

                            ComboBoxItem item = new ComboBoxItem();
                            item.Content = value;
                            item.Name = "Index" + index;
                            item.PreviewMouseDown += new MouseButtonEventHandler(_ComboBoxItemChangedEvent);
                            comboBox.Items.Add(item);
                        }

                        comboBox.SelectionChanged += new SelectionChangedEventHandler(_ComboBoxItemChangedEvent);

                        AddControl(shapeName, comboBox);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Event when a combobox selection changes or selected item is clicked.
        /// </summary>
        public static event SmallBasicCallback ComboBoxItemChanged
        {
            add
            {
                _ComboBoxItemChanged = value;
            }
            remove
            {
                _ComboBoxItemChanged = null;
            }
        }

        /// <summary>
        /// The last combobox where a selection changed.
        /// </summary>
        public static Primitive LastComboBox
        {
            get { return _LastComboBox; }
        }

        /// <summary>
        /// The last combobox selection changed index (row number).
        /// </summary>
        public static Primitive LastComboBoxIndex
        {
            get { return _LastComboBoxIndex; }
        }

        /// <summary>
        /// Select a node in a combobox.
        /// </summary>
        /// <param name="shapeName">The combobox shape name.</param>
        /// <param name="node">The node to select.</param>       
        public static void ComboBoxSelect(Primitive shapeName, Primitive node)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(ComboBox))
                        {
                            ComboBox comboBox = (ComboBox)obj;
                            foreach (ComboBoxItem item in comboBox.Items)
                            {
                                if (item.Name == "Index" + node)
                                {
                                    comboBox.SelectedItem = item;
                                    break;
                                }
                            }
                        }
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
        /// Get a combobox selected node.
        /// </summary>
        /// <param name="shapeName">The combobox to get node.</param>
        /// <returns>The combobox selected node.</returns>
        public static Primitive ComboBoxGetSelected(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "";
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(ComboBox))
                        {
                            ComboBox comboBox = (ComboBox)obj;
                            if (null == comboBox.SelectedItem) return "";
                            return ((ComboBoxItem)(comboBox.SelectedItem)).Name.Substring(5);
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return "";
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Set the selection mode for listbox control.
        /// </summary>
        /// <param name="shapeName">The listbox control name.</param>
        /// <param name="mode">One of the following:
        /// "Single" - single selection (default).
        /// "Multiple" - multiple selections using control key.
        /// "Extended" - extended selections using control and shift keys.
        /// </param>
        public static void ListBoxSelectionMode(Primitive shapeName, Primitive mode)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(ListBox))
                        {
                            ListBox listBox = (ListBox)obj;
                            switch (((string)mode).ToLower())
                            {
                                case "single":
                                    listBox.SelectionMode = System.Windows.Controls.SelectionMode.Single;
                                    break;
                                case "multiple":
                                    listBox.SelectionMode = System.Windows.Controls.SelectionMode.Multiple;
                                    break;
                                case "extended":
                                    listBox.SelectionMode = System.Windows.Controls.SelectionMode.Extended;
                                    break;
                            }
                        }
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
            return;
        }

        /// <summary>
        /// Add a checkbox dialog control.
        /// </summary>
        /// <param name="title">The title of the control.</param>
        /// <returns>The checkbox shape name.</returns>
        public static Primitive AddCheckBox(Primitive title)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Content = title;

                        checkBox.Checked += new RoutedEventHandler(_CheckBoxChangedEvent);
                        checkBox.Unchecked += new RoutedEventHandler(_CheckBoxChangedEvent);

                        AddControl(shapeName, checkBox);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Event when a checkbox is clicked.
        /// </summary>
        public static event SmallBasicCallback CheckBoxChanged
        {
            add
            {
                _CheckBoxChanged = value;
            }
            remove
            {
                _CheckBoxChanged = null;
            }
        }

        /// <summary>
        /// The last checkbox that was clicked.
        /// </summary>
        public static Primitive LastCheckBox
        {
            get { return _LastCheckBox; }
        }

        /// <summary>
        /// The last checkbox checked state ("True" or "False").
        /// </summary>
        public static Primitive LastCheckBoxState
        {
            get { return _LastCheckBoxState; }
        }

        /// <summary>
        /// Set a checkbox checked state.
        /// </summary>
        /// <param name="shapeName">The checkbox shape name.</param>
        /// <param name="state">The checkbox check state ("True" or "False").</param>       
        public static void CheckBoxState(Primitive shapeName, Primitive state)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(CheckBox))
                        {
                            CheckBox checkBox = (CheckBox)obj;
                            checkBox.IsChecked = state;
                        }
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
        /// Get a checkbox checked state.
        /// </summary>
        /// <param name="shapeName">The checkbox to get state.</param>
        /// <returns>The checkbox checked state.</returns>
        public static Primitive CheckBoxGetState(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "";
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(CheckBox))
                        {
                            CheckBox checkBox = (CheckBox)obj;
                            return (checkBox.IsChecked == true) ? "True" : "False";
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return "";
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }
        
        /// <summary>
        /// Scroll the cursor caret to the end of a textbox or richtextbox.
        /// This is for multi-line textboxes or richtextboxes.
        /// </summary>
        /// <param name="shapeName">The textbox shape name.</param>
        public static void SetCursorToEnd(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    if (obj.GetType() == typeof(TextBox))
                    {
                        TextBox textbox = (TextBox)obj;
                        textbox.ScrollToEnd();
                    }
                    if (obj.GetType() == typeof(RichTextBox))
                    {
                        RichTextBox textbox = (RichTextBox)obj;
                        textbox.ScrollToEnd();
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
        /// Set the cursor caret to specified position within a textbox.
        /// </summary>
        /// <param name="shapeName">The textbox shape name.</param>
        /// <param name="position">The cursor character position (0 is before first character or a large value e.g. 1000 will set the cursor to the end).</param>
        public static void SetCursorPosition(Primitive shapeName, Primitive position)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    if (obj.GetType() == typeof(TextBox))
                    {
                        TextBox textbox = (TextBox)obj;
                        int pos = System.Math.Min(textbox.Text.Length, System.Math.Max(0, position));
                        textbox.Select(pos, 0);
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
        /// Set the spell checking for a textbox or richtextbox.
        /// </summary>
        /// <param name="shapeName">The textbox or richtextbox shape name.</param>
        /// <param name="state">"True" or "False"</param>
        public static void SetSpellCheck(Primitive shapeName, Primitive state)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    if (obj.GetType() == typeof(TextBox))
                    {
                        TextBox textbox = (TextBox)obj;
                        textbox.SpellCheck.IsEnabled = state;
                    }
                    else if (obj.GetType() == typeof(RichTextBox))
                    {
                        RichTextBox textbox = (RichTextBox)obj;
                        textbox.SpellCheck.IsEnabled = state;
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
        /// Add a radio button control.
        /// Only one radio button in a group can be set (they are exclusive).
        /// </summary>
        /// <param name="title">A text description for the radio button.</param>
        /// <param name="group">A name to group radio buttons.</param>
        /// <returns>The radio button shape name.</returns>
        public static Primitive AddRadioButton(Primitive title, Primitive group)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        RadioButton radioButton = new RadioButton();
                        radioButton.Content = title;
                        radioButton.GroupName = group;

                        radioButton.Checked += new RoutedEventHandler(_RadioButtonClickedEvent);

                        AddControl(shapeName, radioButton);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Event when a radio button selection changes (it is clicked).
        /// </summary>
        public static event SmallBasicCallback RadioButtonClicked
        {
            add
            {
                _RadioButtonClickedDelegate = value;
            }
            remove
            {
                _RadioButtonClickedDelegate = null;
            }
        }

        /// <summary>
        /// The last radio button that was selected.
        /// </summary>
        public static Primitive LastRadioButton
        {
            get { return _LastRadioButton; }
        }

        /// <summary>
        /// The group name for the last radio button selected.
        /// </summary>
        public static Primitive LastRadioButtonGroup
        {
            get { return _LastRadioButtonGroup; }
        }

        /// <summary>
        /// Set a radio button to selected.
        /// </summary>
        /// <param name="shapeName">The radio button to set.</param>
        public static void RadioButtonSet(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(RadioButton))
                        {
                            RadioButton radioButton = (RadioButton)obj;
                            radioButton.IsChecked = true;
                        }
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
        /// Get a radio button state.
        /// </summary>
        /// <param name="shapeName">The radio button to get state.</param>
        /// <returns>The radio button state.</returns>
        public static Primitive RadioButtonGet(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "";
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(RadioButton))
                        {
                            RadioButton radioButton = (RadioButton)obj;
                            return (radioButton.IsChecked == true) ? "True" : "False";
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return "";
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Set shape to allow drag and drop.
        /// Currently only the following are implemented without using FileDropped event to process the dropped file(s):
        /// File path to TextBox (or file paths to MultiLineTextBox).
        /// File opened in RichTextBox.
        /// XPS file opened in DocumentViewer.
        /// Image set in Image or Background.
        /// Media for MediaPlayer (only works if valid media is already loaded).
        /// </summary>
        /// <param name="shapeName">The shape to allow drop or "Background".</param>
        public static void AllowDrop(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            Window _window;

            try
            {
                _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            obj.AllowDrop = true;
                            obj.PreviewDragOver += new DragEventHandler(_DragOver);
                            obj.DragEnter += new DragEventHandler(_DragEnter);
                            obj.Drop += new DragEventHandler(_DragDrop);
                            ((FrameworkElement)obj).Name = shapeName;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else if (((string)shapeName).ToLower() == "background")
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            _window.AllowDrop = true;
                            _window.PreviewDragOver += new DragEventHandler(_DragOver);
                            _window.DragEnter += new DragEventHandler(_DragEnter);
                            _window.Drop += new DragEventHandler(_DragDrop);
                            _window.Tag = shapeName;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Event when a file is dropped on an object set with AllowDrop.
        /// </summary>
        public static event SmallBasicCallback FileDropped
        {
            add
            {
                _DragDropDelegate = value;
            }
            remove
            {
                _DragDropDelegate = null;
            }
        }

        /// <summary>
        /// The last object a file was dropped on.
        /// </summary>
        public static Primitive LastDropShape
        {
            get { return _LastDropShape; }
        }

        /// <summary>
        /// An array with the last file(s) that were dropped.
        /// </summary>
        public static Primitive LastDropFiles
        {
            get { return _LastDropFiles; }
        }

        /// <summary>
        /// Add a media player (to play videos etc).
        /// Drag and drop is auto set for this control.
        /// </summary>
        /// <param name="width">The media player width.</param>
        /// <param name="height">The media player height.</param>
        /// <returns>The media player control name.</returns>
        public static Primitive AddMediaPlayer(Primitive width, Primitive height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            Canvas _mainCanvas;
            string shapeName;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        MediaElement mediaElement = new MediaElement();
                        mediaElement.Width = width;
                        mediaElement.Height = height;
                        mediaElement.AllowDrop = true;
                        mediaElement.PreviewDragOver += new DragEventHandler(_DragOver);
                        mediaElement.DragEnter += new DragEventHandler(_DragEnter);
                        mediaElement.Drop += new DragEventHandler(_DragDrop);
                        mediaElement.Name = shapeName;
                        mediaElement.LoadedBehavior = MediaState.Manual;
                        mediaElement.UnloadedBehavior = MediaState.Stop;
                        mediaElement.MediaEnded += new RoutedEventHandler(_MediaPlayerEndedEvent);
                        mediaElement.MediaOpened += new RoutedEventHandler(_MediaPlayerOpenedEvent);

                        _objectsMap[shapeName] = mediaElement;
                        _mainCanvas.Children.Add(mediaElement);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Event when a media player ends playing current media.
        /// </summary>
        public static event SmallBasicCallback MediaPlayerEnded
        {
            add
            {
                _MediaPlayerEndedDelegate = value;
            }
            remove
            {
                _MediaPlayerEndedDelegate = null;
            }
        }

        /// <summary>
        /// Event when a media player opens new media.
        /// </summary>
        public static event SmallBasicCallback MediaPlayerOpened
        {
            add
            {
                _MediaPlayerOpenedDelegate = value;
            }
            remove
            {
                _MediaPlayerOpenedDelegate = null;
            }
        }

        /// <summary>
        /// The last media player for which an event occurred.
        /// </summary>
        public static Primitive LastMediaPlayer
        {
            get { return _LastMediaPlayer; }
        }

        /// <summary>
        /// Set the volume for a media player.
        /// </summary>
        /// <param name="shapeName">The media player name.</param>
        /// <param name="volume">The volume (0 to 1) default 0.5.</param>
        public static void MediaPlayerVolume(Primitive shapeName, Primitive volume)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(MediaElement))
                        {
                            MediaElement mediaElement = (MediaElement)obj;
                            if (volume >= 0 && volume <= 1) mediaElement.Volume = volume;
                        }
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
        /// Set the playback speed for a media player.
        /// </summary>
        /// <param name="shapeName">The media player name.</param>
        /// <param name="speed">The speed (0 to 100) default 1 (normal playback).</param>
        public static void MediaPlayerSpeed(Primitive shapeName, Primitive speed)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(MediaElement))
                        {
                            MediaElement mediaElement = (MediaElement)obj;
                            if (speed >= 0) mediaElement.SpeedRatio = speed;
                        }
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
        /// Set the media for a media player.
        /// </summary>
        /// <param name="shapeName">The media player name.</param>
        /// <param name="media">The media to load, e.g. an image, music or video file, jp, mp3, mpg, avi, wmv etc.</param>
        public static void MediaPlayerLoad(Primitive shapeName, Primitive media)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(MediaElement))
                        {
                            MediaElement mediaElement = (MediaElement)obj;
                            mediaElement.Source = new Uri(media);
                        }
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
        /// Stop a media player playback (using current loaded media).
        /// </summary>
        /// <param name="shapeName">The media player name.</param>
        public static void MediaPlayerStop(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(MediaElement))
                        {
                            MediaElement mediaElement = (MediaElement)obj;
                            mediaElement.Stop();
                        }
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
        /// Start a media player playback (using current loaded media).
        /// </summary>
        /// <param name="shapeName">The media player name.</param>
        public static void MediaPlayerPlay(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(MediaElement))
                        {
                            MediaElement mediaElement = (MediaElement)obj;
                            mediaElement.Play();
                        }
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
        /// Pause a media player playback (using current loaded media).
        /// </summary>
        /// <param name="shapeName">The media player name.</param>
        public static void MediaPlayerPause(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(MediaElement))
                        {
                            MediaElement mediaElement = (MediaElement)obj;
                            mediaElement.Pause();
                        }
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
        /// Position a media player position (using current loaded media).
        /// </summary>
        /// <param name="shapeName">The media player name.</param>
        /// <param name="seek">The new play position in ms.</param>
        public static void MediaPlayerSeek(Primitive shapeName, Primitive seek)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(MediaElement))
                        {
                            MediaElement mediaElement = (MediaElement)obj;
                            if (seek >= 0 && seek <= mediaElement.NaturalDuration.TimeSpan.TotalMilliseconds) mediaElement.Position = new TimeSpan(0, 0, 0, 0, seek);
                        }
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
        /// Get a media play time (using current loaded media).
        /// </summary>
        /// <param name="shapeName">The media player name.</param>
        /// <returns>The media play time in ms.</returns>
        public static Primitive MediaPlayerPlayTime(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return 0;
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(MediaElement))
                        {
                            MediaElement mediaElement = (MediaElement)obj;
                            return mediaElement.NaturalDuration.HasTimeSpan ? mediaElement.NaturalDuration.TimeSpan.TotalMilliseconds : 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return 0;
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }
 
        /// <summary>
        /// Get a media current position (using current loaded media).
        /// </summary>
        /// <param name="shapeName">The media player name.</param>
        /// <returns>The media current position in ms.</returns>
        public static Primitive MediaPlayerPosition(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return 0;
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(MediaElement))
                        {
                            MediaElement mediaElement = (MediaElement)obj;
                            return mediaElement.NaturalDuration.HasTimeSpan ? mediaElement.Position.TotalMilliseconds : 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return 0;
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Set a visual media stretch - how the visual fills its area.
        /// </summary>
        /// <param name="shapeName">The media player name.</param>
        /// <param name="stretch">The stretch method.  Available stretch options are:
        /// "None" (The content preserves its original size).
        /// "Uniform" (The content is resized to fit in the destination dimensions while it preserves its native aspect ratio - Default).
        /// "Fill" (The content is resized to fill the destination dimensions. The aspect ratio is not preserved).
        /// "UniformToFill" (The content is resized to fill the destination dimensions while it preserves its native aspect ratio, clipping as required).
        /// </param>
        public static void MediaPlayerStretch(Primitive shapeName, Primitive stretch)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(MediaElement))
                        {
                            MediaElement mediaElement = (MediaElement)obj;
                            switch (((string)stretch).ToLower())
                            {
                                case "none":
                                    mediaElement.Stretch = Stretch.None;
                                    break;
                                case "fill":
                                    mediaElement.Stretch = Stretch.Fill;
                                    break;
                                case "uniform":
                                    mediaElement.Stretch = Stretch.Uniform;
                                    break;
                                case "uniformtofill":
                                    mediaElement.Stretch = Stretch.UniformToFill;
                                    break;
                            }
                        }
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
        /// Replace a listbox list.
        /// </summary>
        /// <param name="shapeName">The listbox shape name.</param>
        /// <param name="list">
        /// An array containing the listbox data.
        /// 
        /// The first index is the row or node number and the value of the array is the display text at the current node.
        /// 
        /// list[1] = "Option 1"
        /// list[2] = "Option 2"
        /// list[3] = "Option 3"
        /// list[4] = "Option 4"
        /// </param>
        public static void ListBoxContent(Primitive shapeName, Primitive list)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(ListBox))
                        {
                            ListBox listBox = (ListBox)obj;
                            listBox.SelectionChanged -= new SelectionChangedEventHandler(_ListBoxItemChangedEvent);
                            listBox.Items.Clear();

                            Primitive index, value;
                            Primitive listIndex = SBArray.GetAllIndices(list);
                            for (int i = 1; i <= SBArray.GetItemCount(listIndex); i++)
                            {
                                index = listIndex[i];
                                value = list[index];

                                ListBoxItem item = new ListBoxItem();
                                item.Content = value;
                                item.Name = "Index" + index;
                                item.PreviewMouseDown += new MouseButtonEventHandler(_ListBoxItemChangedEvent);
                                listBox.Items.Add(item);
                            }

                            listBox.SelectionChanged += new SelectionChangedEventHandler(_ListBoxItemChangedEvent);
                        }
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
        /// Replace a combobox list.
        /// </summary>
        /// <param name="shapeName">The combobox shape name.</param>
        /// <param name="list">
        /// An array containing the combobox data.
        /// 
        /// The first index is the row or node number and the value of the array is the display text at the current node.
        /// 
        /// list[1] = "Option 1"
        /// list[2] = "Option 2"
        /// list[3] = "Option 3"
        /// list[4] = "Option 4"
        /// </param>
        public static void ComboBoxContent(Primitive shapeName, Primitive list)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(ComboBox))
                        {
                            ComboBox comboBox = (ComboBox)obj;
                            comboBox.SelectionChanged -= new SelectionChangedEventHandler(_ComboBoxItemChangedEvent);
                            comboBox.Items.Clear();
                            comboBox.SelectedIndex = 0;

                            Primitive index, value;
                            Primitive listIndex = SBArray.GetAllIndices(list);
                            for (int i = 1; i <= SBArray.GetItemCount(listIndex); i++)
                            {
                                index = listIndex[i];
                                value = list[index];

                                ComboBoxItem item = new ComboBoxItem();
                                item.Content = value;
                                item.Name = "Index" + index;
                                item.PreviewMouseDown += new MouseButtonEventHandler(_ComboBoxItemChangedEvent);
                                comboBox.Items.Add(item);
                            }

                            comboBox.SelectionChanged += new SelectionChangedEventHandler(_ComboBoxItemChangedEvent);
                        }
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
        /// Add a progress bar control.
        /// </summary>
        /// <param name="width">The width of the control.</param>
        /// <param name="height">The height of the control.</param>
        /// <param name="orientation">Horizontal or vertical ("H" or "V").</param>
        /// <returns>The progress bar shape name.</returns>
        public static Primitive AddProgressBar(Primitive width, Primitive height, Primitive orientation)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        ProgressBar progressBar = new ProgressBar();
                        progressBar.Width = width;
                        progressBar.Height = height;
                        progressBar.Orientation = ((string)orientation).ToLower() == "v" ? Orientation.Vertical : Orientation.Horizontal;

                        AddControl(shapeName, progressBar);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set progress bar value (progress).
        /// </summary>
        /// <param name="shapeName">The progress bar shape name.</param>
        /// <param name="value">The progress value (0 to 100).</param>
        public static void ProgressBarValue(Primitive shapeName, Primitive value)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(ProgressBar))
                        {
                            ProgressBar progressBar = (ProgressBar)obj;
                            progressBar.Value = System.Math.Min(100, System.Math.Max(0, value));
                        }
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
        /// Add a slider control.
        /// </summary>
        /// <param name="width">The width of the control.</param>
        /// <param name="height">The height of the control.</param>
        /// <param name="orientation">Horizontal or vertical ("H" or "V").</param>
        /// <returns>The slider shape name.</returns>
        public static Primitive AddSlider(Primitive width, Primitive height, Primitive orientation)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Slider slider = new Slider();
                        slider.Width = width;
                        slider.Height = height;
                        slider.Maximum = sliderMaximum;
                        slider.Orientation = ((string)orientation).ToLower() == "v" ? Orientation.Vertical : Orientation.Horizontal;
                        slider.ValueChanged += new RoutedPropertyChangedEventHandler<double>(_SliderChangedEvent);

                        AddControl(shapeName, slider);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// The maximum slider value, default is 100, the minimum is always 0.
        /// Set this before calling AddSlider.
        /// </summary>
        public static Primitive SliderMaximum
        {
            get { return sliderMaximum; }
            set { sliderMaximum = value; }
        }

        /// <summary>
        /// Set slider value (position).
        /// </summary>
        /// <param name="shapeName">The slider shape name.</param>
        /// <param name="value">The slider value (0 to 100).</param>
        public static void SliderValue(Primitive shapeName, Primitive value)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(Slider))
                        {
                            Slider slider = (Slider)obj;
                            slider.Value = System.Math.Min(100, System.Math.Max(0, value));
                        }
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
        /// Get slider value (position).
        /// </summary>
        /// <param name="shapeName">The slider shape name.</param>
        /// <returns>The slider value (0 to 100).</returns>
        public static Primitive SliderGetValue(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return 0;
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(Slider))
                        {
                            Slider slider = (Slider)obj;
                            return slider.Value;
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return 0;
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Event when a slider is changed.
        /// </summary>
        public static event SmallBasicCallback SliderChanged
        {
            add
            {
                _SliderChangedDelegate = value;
            }
            remove
            {
                _SliderChangedDelegate = null;
            }
        }

        /// <summary>
        /// The last slider for which an event occurred.
        /// </summary>
        public static Primitive LastSlider
        {
            get { return _LastSlider; }
        }

        /// <summary>
        /// The last slider value.
        /// </summary>
        public static Primitive LastSliderValue
        {
            get { return _LastSliderValue; }
        }

        /// <summary>
        /// Add a password box control (texbox with characters not displayed and PasswordEntered event only when return is pressed).
        /// </summary>
        /// <param name="width">The width of the control.</param>
        /// <param name="height">The height of the control.</param>
        /// <param name="length">The maximum number of characters in the password.</param>
        /// <returns>The password box shape name.</returns>
        public static Primitive AddPasswordBox(Primitive width, Primitive height, Primitive length)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        PasswordBox passwordBox = new PasswordBox();
                        passwordBox.Width = width;
                        passwordBox.Height = height;
                        passwordBox.MaxLength = length;
                        passwordBox.KeyDown += new KeyEventHandler(_PasswordBoxKeyEvent);
                        passwordBox.PasswordChanged += new RoutedEventHandler(_PasswordBoxEvent);

                        AddControl(shapeName, passwordBox);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Event when a password is entered (Return key pressed).
        /// </summary>
        public static event SmallBasicCallback PasswordEntered
        {
            add
            {
                _PasswordEnteredDelegate = value;
            }
            remove
            {
                _PasswordEnteredDelegate = null;
            }
        }

        /// <summary>
        /// The password box for which an event occurred.
        /// </summary>
        public static Primitive LastPasswordBox
        {
            get { return _LastPasswordBox; }
        }

        /// <summary>
        /// The last password entered.
        /// </summary>
        public static Primitive LastPassword
        {
            get { return _LastPassword; }
        }

        /// <summary>
        /// Add a document viewer dialog control.
        /// You can view XPS documents (MS version of PDF) with this.
        /// Drag and drop is auto set for this control.
        /// </summary>
        /// <param name="width">The width of the control.</param>
        /// <param name="height">The height of the control.</param>
        /// <returns>The document viewer shape name.</returns>
        public static Primitive AddDocumentViewer(Primitive width, Primitive height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        DocumentViewer documentViewer = new DocumentViewer();
                        documentViewer.Width = width;
                        documentViewer.Height = height;
                        documentViewer.AllowDrop = true;
                        documentViewer.PreviewDragOver += new DragEventHandler(_DragOver);
                        documentViewer.DragEnter += new DragEventHandler(_DragEnter);
                        documentViewer.Drop += new DragEventHandler(_DragDrop);
                        documentViewer.Name = shapeName;

                        AddControl(shapeName, documentViewer);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Load an XPS file to a document viewer dialog control.
        /// </summary>
        /// <param name="shapeName">The document viewer control.</param>
        /// <param name="fileName">The XPS file to load and view.</param>
        public static void DocumentViewerLoadXPS(Primitive shapeName, Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return;
            }
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(DocumentViewer))
                        {
                            DocumentViewer documentViewer = (DocumentViewer)obj;
                            XpsDocument doc = new XpsDocument(fileName, FileAccess.Read);
                            documentViewer.Document = doc.GetFixedDocumentSequence();
                        }
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
        /// The last menu control selected.
        /// </summary>
        public static Primitive LastMenuControl
        {
            get { return _LastMenuContol; }
        }

        /// <summary>
        /// The last menu item selected.
        /// </summary>
        public static Primitive LastMenuItem
        {
            get { return _LastMenuItem; }
        }

        /// <summary>
        /// Get the check state of a menu item.
        /// </summary>
        /// <param name="shapeName">The menu shape name.</param>
        /// <param name="itemName">The menu item name.</param>
        /// <returns>"True" or "False".</returns>
        public static Primitive MenuChecked(Primitive shapeName, Primitive itemName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            Menu shape = (Menu)obj;
                            MenuItem item = findMenuItem(shape.Items, ((string)itemName).ToLower());
                            if (null != item && item.IsCheckable && item.IsChecked) return "True";
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "False";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "False";
        }

        /// <summary>
        /// Event when a menu item is selected.
        /// </summary>
        public static event SmallBasicCallback MenuClicked
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
        /// Add a menu control.
        /// </summary>
        /// <param name="width">The width of the control.</param>
        /// <param name="height">The height of the control.</param>
        /// <param name="menuList">
        /// An array of menu items.  The index is the menu display name and the value is the parent display name.
        /// The top level display name should be "Main".  The names should be unique since they will be returned on click event.
        /// A separator is "-", "--", "---" etc since they have to be unique and cannot be selected.
        /// 
        /// menuList["File"] = "Main"
        /// menuList["Open"] = "File"
        /// menuList["-"] = "File"
        /// menuList["Exit"] = "File"
        /// menuList["Help"] = "Main"
        /// menuList["Show Help"] = "Help"
        /// </param>
        /// <param name="iconList">
        /// An optional array of icon images (URL or ImageList) or "" for none.
        /// 
        /// iconList["File"] = Program.Directory+"/file.png"
        /// </param>
        /// <param name="checkList">
        /// An optional array to identify items as checkable or "" for none.
        /// The value is the initial checked state "True" or "False".
        /// 
        /// checkList["Show Help"] = "True"
        /// </param>
        /// <returns>The menu shape name.</returns>
        public static Primitive AddMenu(Primitive width, Primitive height, Primitive menuList, Primitive iconList, Primitive checkList)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            string shapeName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Menu menu = new Menu();
                        menu.Width = width;
                        menu.Height = height;
                        menu.Name = shapeName;

                        addMenuItems(shapeName, menu.Items, menuList, iconList, checkList);

                        AddControl(shapeName, menu);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set the background colour for sub menus.  
        /// The main top menu can be coloured separately with LDShapes.BrushColour.
        /// Note that separators are not coloured and it is often best to just colour the top menu.
        /// </summary>
        /// <param name="shapeName">The menu shape name.</param>
        /// <param name="colour">The background colour.</param>
        public static void MenuBackground(Primitive shapeName, Primitive colour)
        {

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            Menu shape = (Menu)obj;
                            Brush brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            foreach (MenuItem item in shape.Items)
                            {
                                menuBrush(item.Items, brush);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set whether a TextBox accepts a tab or uses it to locate the next control.
        /// </summary>
        /// <param name="shapeName">The TextBox or RichTextBox name.</param>
        /// <param name="acceptsTab">"True" or "False" (default).</param>
        public static void TextBoxTab(Primitive shapeName, Primitive acceptsTab)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        if (obj.GetType() == typeof(TextBox))
                        {
                            ((TextBox)obj).AcceptsTab = acceptsTab;
                        }
                        else if (obj.GetType() == typeof(RichTextBox))
                        {
                            ((RichTextBox)obj).AcceptsTab = acceptsTab;
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Add a ListView control.
        /// </summary>
        /// <param name="width">The width of the control.</param>
        /// <param name="height">The height of the control.</param>
        /// <param name="headings">An array of headings for the listview.</param>
        /// <returns>The listview shape name.</returns>
        public static Primitive AddListView(Primitive width, Primitive height, Primitive headings)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(SBShapes);
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        ListView listView = new ListView();
                        listView.Width = width;
                        listView.Height = height;
                        listView.SelectionChanged += new SelectionChangedEventHandler(_ListViewSelectionChangedEvent);

                        GridView gridView = new GridView();
                        listView.View = gridView;

                        Style style = new Style(typeof(ListViewItem));
                        style.Setters.Add(new Setter(ListViewItem.HorizontalContentAlignmentProperty, HorizontalAlignment.Stretch));
                        listView.ItemContainerStyle = style;

                        listView.Items.Clear();

                        Primitive indices = SBArray.GetAllIndices(headings);
                        for (int i = 1; i <= SBArray.GetItemCount(indices); i++)
                        {
                            GridViewColumn Col = new GridViewColumn();
                            Col.Header = headings[indices[i]];
                            Col.Width = Double.NaN;
                            //Col.DisplayMemberBinding = new Binding("col[" + (i-1).ToString() + "]");
                            DataTemplate dt = new DataTemplate();
                            dt.DataType = typeof(string);
                            FrameworkElementFactory fef = new FrameworkElementFactory(typeof(TextBlock));
                            fef.SetBinding(TextBlock.TextProperty, new Binding("col[" + (i - 1).ToString() + "]"));
                            fef.SetValue(TextBlock.HorizontalAlignmentProperty, HorizontalAlignment.Left);
                            dt.VisualTree = fef;
                            Col.CellTemplate = dt;
                            Col.CellTemplate.Seal();
                            gridView.Columns.Add(Col);
                        }

                        AddControl(shapeName, listView);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set the alignment for a listview column.
        /// </summary>
        /// <param name="shapeName">The listview control.</param>
        /// <param name="col">The column number (indexed from 1).</param>
        /// <param name="alignment">"Left", "Center" or "Right"</param>
        public static void ListViewColAlignment(Primitive shapeName, Primitive col, Primitive alignment)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            ListView shape = (ListView)obj;

                            int colCount = ((GridView)shape.View).Columns.Count;
                            for (int i = 0; i < colCount; i++)
                            {
                                if (Double.IsNaN(((GridView)shape.View).Columns[i].Width))
                                {
                                    ((GridView)shape.View).Columns[i].Width = ((GridView)shape.View).Columns[i].ActualWidth;
                                }
                                ((GridView)shape.View).Columns[i].Width = Double.NaN;
                                if (i + 1 == col)
                                {
                                    FrameworkElementFactory fef = new FrameworkElementFactory(typeof(TextBlock));
                                    fef.SetBinding(TextBlock.TextProperty, new Binding("col[" + i.ToString() + "]"));
                                    switch (((string)alignment).ToLower())
                                    {
                                        case "left":
                                            fef.SetValue(TextBlock.HorizontalAlignmentProperty, HorizontalAlignment.Left);
                                            break;
                                        case "right":
                                            fef.SetValue(TextBlock.HorizontalAlignmentProperty, HorizontalAlignment.Right);
                                            break;
                                        case "center":
                                            fef.SetValue(TextBlock.HorizontalAlignmentProperty, HorizontalAlignment.Center);
                                            break;
                                    }
                                    DataTemplate dt = new DataTemplate();
                                    dt.DataType = typeof(string);
                                    dt.VisualTree = fef;
                                    ((GridView)shape.View).Columns[i].CellTemplate = dt;
                                    ((GridView)shape.View).Columns[i].CellTemplate.Seal();

                                }
                            }
                            shape.UpdateLayout();
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Add a row of data to a listview control.
        /// </summary>
        /// <param name="shapeName">The listview control.</param>
        /// <param name="row">The row number (indexed from 1).
        /// If the row number is larger than the current number of rows a new row is added, otherwise the row data is over-written.</param>
        /// <param name="values">An array of values (one for each column).</param>
        public static void ListViewSetRow(Primitive shapeName, Primitive row, Primitive values)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            ListView shape = (ListView)obj;

                            int colCount = ((GridView)shape.View).Columns.Count;
                            DataGridRow dataGridRow = new DataGridRow();
                            dataGridRow.col = new string[colCount];

                            Primitive indices = SBArray.GetAllIndices(values);
                            if (colCount == SBArray.GetItemCount(indices))
                            {
                                for (int i = 1; i <= colCount; i++)
                                {
                                    dataGridRow.col[i-1] = values[indices[i]];
                                }
                            }
                            if (row <= shape.Items.Count)
                            {
                                shape.Items[row - 1] = dataGridRow;
                            }
                            else
                            {
                                shape.Items.Add(dataGridRow);
                            }

                            for (int i = 0; i < colCount; i++)
                            {
                                if (Double.IsNaN(((GridView)shape.View).Columns[i].Width))
                                {
                                    ((GridView)shape.View).Columns[i].Width = ((GridView)shape.View).Columns[i].ActualWidth;
                                }
                                ((GridView)shape.View).Columns[i].Width = Double.NaN;
                            }
                            shape.UpdateLayout();
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Get a row of data from a listview control.
        /// </summary>
        /// <param name="shapeName">The listview control.</param>
        /// <param name="row">The row number (indexed from 1).</param>
        /// <returns>An array of values (one for each column) or "" on failure.</returns>
        public static Primitive ListViewGetRow(Primitive shapeName, Primitive row)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            ListView shape = (ListView)obj;

                            Primitive result = "";
                            if (row <= shape.Items.Count)
                            {
                                DataGridRow dataGridRow = (DataGridRow)shape.Items[row - 1];
                                for (int i = 1; i <= dataGridRow.col.Length; i++)
                                {
                                    result[i] = dataGridRow.col[i-1];
                                }
                            }

                            return result;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "";
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get the number of rows in a listview control.
        /// </summary>
        /// <param name="shapeName">The listview control.</param>
        /// <returns>The number of rows in the listview.</returns>
        public static Primitive ListViewRowCount(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            ListView shape = (ListView)obj;
                            return shape.Items.Count;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return 0;
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Delete a row of data from a listview control.
        /// </summary>
        /// <param name="shapeName">The listview control.</param>
        /// <param name="row">The row number (indexed from 1).
        /// If the row number is larger than the current number of rows then no action is taken.</param>
        public static void ListViewDeleteRow(Primitive shapeName, Primitive row)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            ListView shape = (ListView)obj;

                            if (row <= shape.Items.Count)
                            {
                                shape.Items.RemoveAt(row - 1);
                            }

                            int colCount = ((GridView)shape.View).Columns.Count;
                            for (int i = 0; i < colCount; i++)
                            {
                                ((GridView)shape.View).Columns[i].Width = Double.NaN;
                            }
                            shape.UpdateLayout();
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Remove all rows from a listview control.
        /// </summary>
        /// <param name="shapeName">The listview control.</param>
        public static void ListViewClear(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            ListView shape = (ListView)obj;

                            shape.Items.Clear();

                            int colCount = ((GridView)shape.View).Columns.Count;
                            for (int i = 0; i < colCount; i++)
                            {
                                ((GridView)shape.View).Columns[i].Width = Double.NaN;
                            }
                            shape.UpdateLayout();
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Event when a listview selection changes.
        /// </summary>
        public static event SmallBasicCallback ListViewSelectionChanged
        {
            add
            {
                _ListViewSelectionChangedDelegate = value;
            }
            remove
            {
                _ListViewSelectionChangedDelegate = null;
            }
        }

        /// <summary>
        /// The last listview where a selection changed.
        /// </summary>
        public static Primitive LastListView
        {
            get { return _LastListView; }
        }

        /// <summary>
        /// The last listview selected row number.
        /// </summary>
        public static Primitive LastListViewRow
        {
            get { return _LastListViewRow; }
        }

        /// <summary>
        /// Change a listview to editable status.
        /// </summary>
        /// <param name="shapeName">The listview shape name.</param>
        /// <param name="editable">"True" with editable TextBoxes or "False" uneditable TextBlocks.</param>
        public static void ListViewEdit(Primitive shapeName, Primitive editable)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(ListView))
                        {
                            ListView shape = (ListView)obj;
                            int colCount = ((GridView)shape.View).Columns.Count;
                            for (int i = 0; i < colCount; i++)
                            {
                                GridViewColumn Col = ((GridView)shape.View).Columns[i];
                                if (editable && Col.CellTemplate.LoadContent().GetType() == typeof(TextBlock))
                                {
                                    HorizontalAlignment align = ((TextBlock)Col.CellTemplate.LoadContent()).HorizontalAlignment;
                                    FrameworkElementFactory fef = new FrameworkElementFactory(typeof(TextBox));
                                    fef.SetBinding(TextBox.TextProperty, new Binding("col[" + i.ToString() + "]"));
                                    fef.SetValue(TextBox.HorizontalAlignmentProperty, align);
                                    DataTemplate dt = new DataTemplate();
                                    dt.DataType = typeof(string);
                                    dt.VisualTree = fef;
                                    Col.CellTemplate = dt;
                                    Col.CellTemplate.Seal();
                                }
                                else if (!editable && Col.CellTemplate.LoadContent().GetType() == typeof(TextBox))
                                {
                                    HorizontalAlignment align = ((TextBox)Col.CellTemplate.LoadContent()).HorizontalAlignment;
                                    FrameworkElementFactory fef = new FrameworkElementFactory(typeof(TextBlock));
                                    fef.SetBinding(TextBlock.TextProperty, new Binding("col[" + i.ToString() + "]"));
                                    fef.SetValue(TextBlock.HorizontalAlignmentProperty, align);
                                    DataTemplate dt = new DataTemplate();
                                    dt.DataType = typeof(string);
                                    dt.VisualTree = fef;
                                    Col.CellTemplate = dt;
                                    Col.CellTemplate.Seal();
                                }
                            }

                            for (int i = 0; i < colCount; i++)
                            {
                                if (Double.IsNaN(((GridView)shape.View).Columns[i].Width))
                                {
                                    ((GridView)shape.View).Columns[i].Width = ((GridView)shape.View).Columns[i].ActualWidth;
                                }
                                ((GridView)shape.View).Columns[i].Width = Double.NaN;
                            }
                            shape.UpdateLayout();
                        }
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
        /// Set a textbox readonly state.
        /// </summary>
        /// <param name="shapeName">The textbox control.</param>
        /// <param name="readOnly">"True" or "False" (default).</param>
        public static void TextBoxReadOnly(Primitive shapeName, Primitive readOnly)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(TextBox))
                        {
                            TextBox textBox = (TextBox)obj;
                            textBox.IsReadOnly = readOnly;
                        }
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
        /// Event when a dataview selection changes.
        /// This event is not called for dataview button clicks, use DataViewButtonClicked.
        /// This event is not called for dataview checkbox or combobox clicks, use DataViewCellValueChanged.
        /// </summary>
        public static event SmallBasicCallback DataViewSelectionChanged
        {
            add
            {
                _DataViewSelectionChangedDelegate = value;
            }
            remove
            {
                _DataViewSelectionChangedDelegate = null;
            }
        }

        /// <summary>
        /// Event when a dataview button is clicked.
        /// </summary>
        public static event SmallBasicCallback DataViewButtonClicked
        {
            add
            {
                _DataViewButtonClickedDelegate = value;
            }
            remove
            {
                _DataViewButtonClickedDelegate = null;
            }
        }

        /// <summary>
        /// Event when a dataview cell value changes after it is commited, for example by selecting away from the cell.
        /// </summary>
        public static event SmallBasicCallback DataViewCellValueChanged
        {
            add
            {
                _DataViewCellValueChangedDelegate = value;
            }
            remove
            {
                _DataViewCellValueChangedDelegate = null;
            }
        }

        /// <summary>
        /// The last dataview where a selection changed.
        /// </summary>
        public static Primitive LastDataView
        {
            get { return lastDataView; }
        }

        /// <summary>
        /// Get the cell row, column and value of a dataview cell whose value has changed.
        /// This is a 3 element array.
        /// </summary>
        public static Primitive LastDataViewCellValueChanged
        {
            get { return lastChanged; }
        }

        /// <summary>
        /// Get the cell row, column and value of the last dataview button clicked.
        /// This is a 3 element array.
        /// </summary>
        public static Primitive LastDataViewButtonClicked
        {
            get { return lastButton; }
        }

        /// <summary>
        /// The last database table for which a dataview selection changed.
        /// </summary>
        public static Primitive LastDataBaseTable
        {
            get { return lastTable; }
        }

        /// <summary>
        /// Add a dataview control.
        /// All rows and columns are indexed from 1.
        /// This control always appears on top of all other objects in the GraphicsWindow.
        /// </summary>
        /// <param name="width">The width of the control.</param>
        /// <param name="height">The height of the control.</param>
        /// <param name="headings">An array of headings for the dataview.</param>
        /// <returns>The dataview shape name.</returns>
        public static Primitive AddDataView(Primitive width, Primitive height, Primitive headings)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Canvas _mainCanvas;
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Control" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        WindowsFormsHost shape = new WindowsFormsHost();
                        System.Windows.Forms.DataGridView dataView = new System.Windows.Forms.DataGridView();
                        dataView.AutoResizeColumns(System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells);
                        //dataView.AutoResizeRows(System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells);
                        dataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
                        dataView.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dataView, true, null);
                        //dataView.Dock = System.Windows.Forms.DockStyle.Fill;

                        dataView.SelectionChanged += new EventHandler(_DataViewSelectionChanged);
                        dataView.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(_DataViewSelectionSort);
                        dataView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(_DataViewDataError);
                        dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(_DataViewCellContentClick);
                        dataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(_DataViewCellValueChanged);
                        dataView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(_DataViewEditingControl);
                        dataView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(_DataViewRowPrePaint);
                        dataView.KeyDown += new System.Windows.Forms.KeyEventHandler(_DataViewKeyDown);
                        dataView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(_DataViewBindingComplete);

                        dataView.Name = shapeName;
                        shape.Child = dataView;
                        shape.Name = shapeName;
                        shape.Width = width;
                        shape.Height = height;

                        Primitive indices = SBArray.GetAllIndices(headings);
                        for (int i = 1; i <= SBArray.GetItemCount(indices); i++)
                        {                          
                            dataView.Columns.Add("col" + i.ToString(), headings[indices[i]]);
                            dataView.Columns[i - 1].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                        }

                        dataView.MouseUp += new System.Windows.Forms.MouseEventHandler(_DataViewMouseUp);
                        System.Windows.Forms.ContextMenu menu = new System.Windows.Forms.ContextMenu();
                        dataView.ContextMenu = menu;
                        menu.MenuItems.Add(new System.Windows.Forms.MenuItem("&Copy Selected Rows", _DataViewCopyRows));
                        menu.MenuItems.Add(new System.Windows.Forms.MenuItem("&Delete Selected Rows", _DataViewDeleteRows));
                        menu.MenuItems.Add(new System.Windows.Forms.MenuItem("&Select All Ctrl A", _DataViewAll));
                        menu.MenuItems.Add(new System.Windows.Forms.MenuItem("&Copy Ctrl C", _DataViewCopy));
                        menu.MenuItems.Add(new System.Windows.Forms.MenuItem("&Paste Ctrl V", _DataViewPaste));

                        _objectsMap[shapeName] = shape;
                        _mainCanvas.Children.Add(shape);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get a list of all selected cells in a dataview.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <returns>A 2D array of rows and columns selected.
        /// cells[1][1] = row, cells[1][2] = column.</returns>
        public static Primitive DataViewGetSelected(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (!_objectsMap.TryGetValue((string)shapeName, out obj)) return "";

            try
            {
                WindowsFormsHost shape = (WindowsFormsHost)obj;
                System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                Primitive result = "";
                int i = 1;
                foreach (System.Windows.Forms.DataGridViewCell cell in dataView.SelectedCells)
                {
                    if (cell.RowIndex >= 0 && cell.RowIndex < dataView.Rows.Count - 1)
                    {
                        Primitive _cell = "";
                        _cell[1] = cell.RowIndex + 1;
                        _cell[2] = cell.ColumnIndex + 1;
                        result[i++] = _cell;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set the focus to a dataview cell.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="row">The row number.</param>
        /// <param name="col">The column number.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewSetFocus(Primitive shapeName, Primitive row, Primitive col)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (_objectsMap.TryGetValue((string)shapeName, out obj))
            {
                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        WindowsFormsHost shape = (WindowsFormsHost)obj;
                        System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                        dataView.CurrentCell = dataView.Rows[(int)(row - 1)].Cells[(int)(col - 1)];
                        dataView.BeginEdit(true);
                        return "SUCCESS";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "FAILED";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            return "FAILED";
        }

        /// <summary>
        /// Get the current dataview cell with focus.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <returns>A 1D array with the row and column number with focus, or "".</returns>
        public static Primitive DataViewGetFocus(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (!_objectsMap.TryGetValue((string)shapeName, out obj)) return "";

            try
            {
                WindowsFormsHost shape = (WindowsFormsHost)obj;
                System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                Primitive result = "";

                result[1] = dataView.CurrentCell.RowIndex + 1;
                result[2] = dataView.CurrentCell.ColumnIndex + 1;
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set a dataview cell value.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="row">The row number.</param>
        /// <param name="col">The column number.</param>
        /// <param name="value">The value to set.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewSetValue(Primitive shapeName, Primitive row, Primitive col, Primitive value)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (_objectsMap.TryGetValue((string)shapeName, out obj))
            {
                try
                {
                    WindowsFormsHost shape = (WindowsFormsHost)obj;
                    System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;
                    DataTable dataTable = (DataTable)dataView.Tag;
                    if (row <= 0 || row > dataView.Rows.Count - 1 || col > dataView.Columns.Count) return "FAILED";

                    if (null == dataTable)
                    {
                        dataView.CurrentCell = dataView.Rows[(int)(row - 1)].Cells[(int)(col - 1)];
                        dataView.CurrentCell.Value = (string)value;
                    }
                    else
                    {
                        dataTable.Rows[(int)(row - 1)][(int)(col - 1)] = Convert.ChangeType((string)value, dataTable.Columns[(int)(col - 1)].DataType);
                        dataView.Refresh();                        
                    }
                    return "SUCCESS";
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return "FAILED";
                }
            }
            else
            {
                Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get a dataview cell value.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="row">The row number.</param>
        /// <param name="col">The column number.</param>
        /// <returns>The cell value or "".</returns>
        public static Primitive DataViewGetValue(Primitive shapeName, Primitive row, Primitive col)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (_objectsMap.TryGetValue((string)shapeName, out obj))
            {

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        WindowsFormsHost shape = (WindowsFormsHost)obj;
                        System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                        return (null == dataView.Rows[(int)(row - 1)].Cells[(int)(col - 1)].Value) ? "" : dataView.Rows[(int)(row - 1)].Cells[(int)(col - 1)].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "FAILED";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            return "FAILED";
        }

        /// <summary>
        /// Clear all rows in a dataview.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewClear(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (_objectsMap.TryGetValue((string)shapeName, out obj))
            {

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        WindowsFormsHost shape = (WindowsFormsHost)obj;
                        System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;
                        DataTable dataTable = (DataTable)dataView.Tag;

                        if (null == dataTable)
                        {
                            dataView.Rows.Clear();
                        }
                        else
                        {
                            dataTable.Rows.Clear();
                            dataView.Refresh();
                        }
                        return "SUCCESS";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "FAILED";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            return "FAILED";
        }

        /// <summary>
        /// Add a row of data to a dataview control.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="row">The row number.
        /// If the row number is larger than the current number of rows a new row is added, otherwise the row data is over-written.</param>
        /// <param name="values">An array of values (one for each column).</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewSetRow(Primitive shapeName, Primitive row, Primitive values)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (_objectsMap.TryGetValue((string)shapeName, out obj))
            {
                try
                {
                    WindowsFormsHost shape = (WindowsFormsHost)obj;
                    System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                    int colCount = dataView.Columns.Count;
                    Primitive indices = SBArray.GetAllIndices(values);
                    if (colCount == SBArray.GetItemCount(indices))
                    {
                        DataTable dataTable = (DataTable)dataView.Tag;
                        if (null == dataTable)
                        {
                            if (row >= dataView.Rows.Count)
                            {
                                System.Windows.Forms.DataGridViewRow newRow = (System.Windows.Forms.DataGridViewRow)dataView.RowTemplate.Clone();
                                newRow.CreateCells(dataView);
                                for (int i = 1; i <= colCount; i++)
                                {
                                    newRow.Cells[i - 1].Value = (string)values[indices[i]];
                                }
                                dataView.Rows.Add(newRow);
                            }
                            else
                            {
                                for (int i = 1; i <= colCount; i++)
                                {
                                    dataView.Rows[row - 1].Cells[i - 1].Value = (string)values[indices[i]];
                                }
                            }
                        }
                        else
                        {
                            int maxId = 0, Id;
                            bool indexed = dataTable.Columns[0].ColumnName.ToLower() == "id" && (dataTable.Columns[0].DataType == typeof(Int64) || dataTable.Columns[0].DataType == typeof(Int32));
                            if (indexed)
                            {
                                foreach (DataRow dataRow in dataTable.Rows)
                                {
                                    if (int.TryParse(dataRow.ItemArray[0].ToString(), out Id)) maxId = System.Math.Max(maxId, Id);
                                }
                            }
                            DataRow newDataRow = dataTable.NewRow();
                            if (colCount != newDataRow.ItemArray.Length) return "FAILED";
                            Object[] array = new Object[colCount];
                            System.Array.Copy(newDataRow.ItemArray, 0, array, 0, colCount);
                            for (int i = 1; i <= colCount; i++)
                            {
                                array[i - 1] = Convert.ChangeType((string)values[indices[i]], dataTable.Columns[i - 1].DataType);
                            }
                            if (row >= dataView.Rows.Count)
                            {
                                if (indexed) array[0] = ++maxId;
                                newDataRow.ItemArray = array;
                                dataTable.Rows.Add(newDataRow);
                            }
                            else
                            {
                                if (indexed) array[0] = dataTable.Rows[row - 1][0];
                                dataTable.Rows[row - 1].ItemArray = array;
                            }
                            dataView.Refresh();
                        }
                        return "SUCCESS";
                    }
                    return "FAILED";
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    return "FAILED";
                }
            }
            else
            {
                Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                return "FAILED";
            }
        }

        /// <summary>
        /// Delete a row from a dataview control.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="row">The row number.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewDeleteRow(Primitive shapeName, Primitive row)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (_objectsMap.TryGetValue((string)shapeName, out obj))
            {
                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        WindowsFormsHost shape = (WindowsFormsHost)obj;
                        System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;
                        DataTable dataTable = (DataTable)dataView.Tag;

                        if (row < dataView.Rows.Count)
                        {
                            if (null == dataTable)
                            {
                                dataView.Rows.RemoveAt(row - 1);
                            }
                            else
                            {
                                dataTable.Rows.RemoveAt(row - 1);
                            }
                            return "SUCCESS";
                        }
                        return "FAILED";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "FAILED";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            else
            {
                Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get a row of data from a dataview control.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="row">The row number.</param>
        /// <returns>An array of values (one for each column) or "" on failure.</returns>
        public static Primitive DataViewGetRow(Primitive shapeName, Primitive row)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            WindowsFormsHost shape = (WindowsFormsHost)obj;
                            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                            Primitive result = "";
                            if (row < dataView.Rows.Count)
                            {
                                for (int i = 0; i < dataView.Columns.Count; i++)
                                {
                                    result[i + 1] = (null == dataView.Rows[(int)(row - 1)].Cells[i].Value) ? "" : dataView.Rows[(int)(row - 1)].Cells[i].Value.ToString();
                                }
                            }

                            return result;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "";
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get the number of rows in a dataview control.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <returns>The number of rows in the dataview.</returns>
        public static Primitive DataViewRowCount(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            WindowsFormsHost shape = (WindowsFormsHost)obj;
                            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                            return dataView.Rows.Count - 1;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return 0;
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Allow a dataview control to be column sorted by user clicking header.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="allow">Allow "True" (default) or disallow "False".</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewAllowSort(Primitive shapeName, Primitive allow)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (_objectsMap.TryGetValue((string)shapeName, out obj))
            {
                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        WindowsFormsHost shape = (WindowsFormsHost)obj;
                        System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                        for (int i = 0; i < dataView.Columns.Count; i++)
                        {
                            dataView.Columns[i].SortMode = allow ? System.Windows.Forms.DataGridViewColumnSortMode.Automatic: System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
                        }
                        return "SUCCESS";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "FAILED";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            else
            {
                Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                return "FAILED";
            }
        }

        /// <summary>
        /// Write an entire dataview to a csv (comma separated values) text file.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="fileName">The full path for the csv file.</param>
        /// <param name="append">Append to the csv file "True" or "False".</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewSaveAsCSV(Primitive shapeName, Primitive fileName, Primitive append)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    WindowsFormsHost shape = (WindowsFormsHost)obj;
                    System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;
                    dataView.EndEdit();

                    using (StreamWriter file = new StreamWriter(fileName, append))
                    {
                        string line;
                        int colCount = dataView.Columns.Count;
                        for (int i = 0; i < dataView.Rows.Count - 1; i++)
                        {
                            line = "";
                            for (int j = 0; j < colCount; j++)
                            {
                                line += (null == dataView.Rows[i].Cells[j].Value) ? "" : dataView.Rows[i].Cells[j].Value.ToString();
                                if (j < colCount - 1) line += ",";
                            }
                            file.WriteLine(line);
                        }
                        return "SUCCESS";
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";            
        }

        /// <summary>
        /// Add data from a csv (comma separated values) text file into a dataview control.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="fileName">The full path for the csv file.</param>
        /// <param name="append">Append to the dataview "True" or "False".</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewReadFromCSV(Primitive shapeName, Primitive fileName, Primitive append)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    WindowsFormsHost shape = (WindowsFormsHost)obj;
                    System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;
                    DataTable dataTable = (DataTable)dataView.Tag;

                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            using (StreamReader file = new StreamReader(fileName))
                            {
                                if (!append)
                                {
                                    if (null == dataTable)
                                    {
                                        dataView.Rows.Clear();
                                    }
                                    else
                                    {
                                        dataTable.Rows.Clear();
                                    }
                                }
                                int colCount = dataView.Columns.Count;
                                string[] values;
                                while (!file.EndOfStream)
                                {
                                    values = file.ReadLine().Split(',');
                                    if (values.Length >= colCount)
                                    {
                                        if (null == dataTable)
                                        {
                                            System.Windows.Forms.DataGridViewRow newRow = (System.Windows.Forms.DataGridViewRow)dataView.RowTemplate.Clone();
                                            newRow.CreateCells(dataView);
                                            for (int i = 0; i < colCount; i++)
                                            {
                                                newRow.Cells[i].Value = values[i];
                                            }
                                            dataView.Rows.Add(newRow);
                                        }
                                        else
                                        {
                                            DataRow newDataRow = dataTable.NewRow();
                                            Object[] array = new Object[colCount];
                                            System.Array.Copy(newDataRow.ItemArray, 0, array, 0, colCount);
                                            for (int i = 0; i < colCount; i++)
                                            {
                                                array[i] = Convert.ChangeType((string)values[i], dataTable.Columns[i].DataType);
                                            }
                                            newDataRow.ItemArray = array;
                                            dataTable.Rows.Add(newDataRow);
                                            dataView.Refresh();
                                        }
                                    }
                                }
                                return "SUCCESS";
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "FAILED";
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Change a dataview column control to be ComboBoxes with selectable values.
        /// This should be set before data is added, after the dataview is created.
        /// If the dataview is bound to a database, then set this after LDDataBase.EditTable is set.
        /// The values to get and set for the cells are the labels set with the data parameter.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="col">The column number.</param>
        /// <param name="data">An array of data selections for the combo boxes.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewSetColumnComboBox(Primitive shapeName, Primitive col, Primitive data)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    WindowsFormsHost shape = (WindowsFormsHost)obj;
                    System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            System.Windows.Forms.DataGridViewComboBoxColumn control = new System.Windows.Forms.DataGridViewComboBoxColumn();
                            Primitive indices = SBArray.GetAllIndices(data);
                            for (int i = 1; i <= SBArray.GetItemCount(data); i++)
                            {
                                control.Items.Add((string)data[indices[i]]);
                            }
                            control.HeaderText = dataView.Columns[(int)(col - 1)].HeaderText;
                            control.Name = dataView.Columns[(int)(col - 1)].Name;
                            DataTable dataTable = (DataTable)dataView.Tag;
                            if (null != dataTable) control.DataPropertyName = dataTable.Columns[(int)(col - 1)].ColumnName;
                            dataView.Columns.RemoveAt((int)(col - 1));
                            dataView.Columns.Insert((int)(col - 1), control);
                            dataView.Columns[(int)(col - 1)].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                            dataView.Refresh();
                            return "SUCCESS";
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "FAILED";
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Change a dataview column control to be Buttons.
        /// This should be set before data is added, after the dataview is created.
        /// If the dataview is bound to a database, then set this after LDDataBase.EditTable is set.
        /// The data for these cells will be the button title.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="col">The column number.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewSetColumnButton(Primitive shapeName, Primitive col)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    WindowsFormsHost shape = (WindowsFormsHost)obj;
                    System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            System.Windows.Forms.DataGridViewButtonColumn control = new System.Windows.Forms.DataGridViewButtonColumn();
                            control.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
                            control.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
                            control.HeaderText = dataView.Columns[(int)(col - 1)].HeaderText;
                            control.Name = dataView.Columns[(int)(col - 1)].Name;
                            DataTable dataTable = (DataTable)dataView.Tag;
                            if (null != dataTable) control.DataPropertyName = dataTable.Columns[(int)(col - 1)].ColumnName;
                            dataView.Columns.RemoveAt((int)(col - 1));
                            dataView.Columns.Insert((int)(col - 1), control);
                            dataView.Columns[(int)(col - 1)].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                            dataView.Refresh();
                            return "SUCCESS";
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "FAILED";
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Change a dataview column control to be CheckBoxes.
        /// This should be set before data is added, after the dataview is created.
        /// If the dataview is bound to a database, then set this after LDDataBase.EditTable is set.
        /// The data for these cells should be "True" or "False".
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="col">The column number.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewSetColumnCheckBox(Primitive shapeName, Primitive col)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    WindowsFormsHost shape = (WindowsFormsHost)obj;
                    System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            System.Windows.Forms.DataGridViewCheckBoxColumn control = new System.Windows.Forms.DataGridViewCheckBoxColumn();
                            control.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
                            control.HeaderText = dataView.Columns[(int)(col - 1)].HeaderText;
                            control.Name = dataView.Columns[(int)(col - 1)].Name;
                            DataTable dataTable = (DataTable)dataView.Tag;
                            if (null != dataTable) control.DataPropertyName = dataTable.Columns[(int)(col - 1)].ColumnName;
                            control.TrueValue = true;
                            control.FalseValue = false;
                            dataView.Columns.RemoveAt((int)(col - 1));
                            dataView.Columns.Insert((int)(col - 1), control);
                            dataView.Columns[(int)(col - 1)].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                            dataView.Refresh();
                            return "SUCCESS";
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "FAILED";
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Sort dataview entries by a column.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="col">The column number to sort by.</param>
        /// <param name="ascending">Sort ascending ("True") or descending ("False").</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewColumnSort(Primitive shapeName, Primitive col, Primitive ascending)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (_objectsMap.TryGetValue((string)shapeName, out obj))
            {
                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        WindowsFormsHost shape = (WindowsFormsHost)obj;
                        System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;
                        dataView.EndEdit();

                        dataView.Sort(dataView.Columns[(int)(col - 1)], ascending ? System.ComponentModel.ListSortDirection.Ascending : System.ComponentModel.ListSortDirection.Descending);
                        return "SUCCESS";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "FAILED";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            else
            {
                Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                return "FAILED";
            }
        }

        /// <summary>
        /// Set a dataview column to be read only.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="col">The column number.</param>
        /// <param name="readOnly">Set as read only "True" or "False" (default).</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewColumnReadOnly(Primitive shapeName, Primitive col, Primitive readOnly)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            WindowsFormsHost shape = (WindowsFormsHost)obj;
                            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                            dataView.Columns[(int)(col - 1)].ReadOnly = readOnly;
                            return "SUCCESS";
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "FAILED";
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Set a dataview column to be visible or not.
        /// This may be used for example to hide an id column of a database.
        /// </summary>
        /// <param name="shapeName">The dataview control.</param>
        /// <param name="col">The column number.</param>
        /// <param name="visible">Set as visible "True" (default) or "False".</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive DataViewColumnVisible(Primitive shapeName, Primitive col, Primitive visible)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            WindowsFormsHost shape = (WindowsFormsHost)obj;
                            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;

                            dataView.Columns[(int)(col - 1)].Visible = visible;
                            return "SUCCESS";
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "FAILED";
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }
    }
}
