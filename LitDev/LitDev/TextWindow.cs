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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;
using System.Reflection;
using System.Drawing.Printing;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using Microsoft.SmallBasic.Library.Internal;

namespace LitDev
{
    /// <summary>
    /// TextWindow utilities.
    /// Includes low level keyboard events.
    /// </summary>
    [SmallBasicType]
    public static class LDTextWindow
    {
        private static KeyConverter kc = new KeyConverter();
        private static void Delay(Object delay)
        {
            Thread.Sleep((int)delay);
            IntPtr _hWnd = User32.FindWindow(null, TextWindow.Title);
            User32.PostMessage(_hWnd, User32.WM_KEYDOWN, User32.VK_RETURN, 0);
        }

        private static Object _lock = new Object();
        private static Keys _LastKey = Keys.None;
        private static SmallBasicCallback _KeyDownDelegate = null;
        private static SmallBasicCallback _KeyUpDelegate = null;
        private static bool bHooked = false;
        private static User32.LowLevelKeyboardProc _hookDelegate = new User32.LowLevelKeyboardProc(HookCallback);
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                if (wParam == (IntPtr)User32.WM_KEYDOWN)
                {
                    _LastKey = (Keys)Marshal.ReadInt32(lParam);
                    if (null != _KeyDownDelegate) _KeyDownDelegate();
                }
                else if (wParam == (IntPtr)User32.WM_KEYUP)
                {
                    _LastKey = (Keys)Marshal.ReadInt32(lParam);
                    if (null != _KeyUpDelegate) _KeyUpDelegate();
                }
            }
            return User32.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }
        private static void HookThread()
        {
            try
            {
                IntPtr _handle, _hookID;
                lock (_lock)
                {
                    if (bHooked) return;
                    bHooked = true;
                    using (Process process = Process.GetCurrentProcess())
                    using (ProcessModule module = process.MainModule)
                    {
                        _handle = User32.GetModuleHandle(module.ModuleName);
                        _hookID = User32.SetWindowsHookEx(User32.WH_KEYBOARD_LL, _hookDelegate, _handle, 0);
                    }
                }
                System.Windows.Forms.Application.Run();
                User32.UnhookWindowsHookEx(_hookID);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
        private static void SetHook()
        {
            Thread thread = new Thread(HookThread);
            thread.Start();
        }

        /// <summary>
        /// Low level event when a key is pressed down.
        /// This event is independent of any window focus, i.e. not just for GraphicsWindow.
        /// </summary>
        public static event SmallBasicCallback KeyDown
        {
            add
            {
                SetHook();
                _KeyDownDelegate = value;
            }
            remove
            {
                _KeyDownDelegate = null;
            }
        }

        /// <summary>
        /// Low level event when a key is released.
        /// This event is independent of any window focus, i.e. not just for GraphicsWindow.
        /// </summary>
        public static event SmallBasicCallback KeyUp
        {
            add
            {
                SetHook();
                _KeyUpDelegate = value;
            }
            remove
            {
                _KeyUpDelegate = null;
            }
        }

        /// <summary>
        /// Last key pressed or released.
        /// </summary>
        public static Primitive LastKey
        {
            get { return _LastKey.ToString(); }
        }

        /// <summary>
        /// Read from a TextWindow with a maximum delay.
        /// This sends a Return (ENTER) to the TextWindow after the delay.
        /// If the user presses Return before the delay is completed, then no further action is taken.
        /// </summary>
        /// <param name="delay">A maximum delay in ms before the Read is terminated.</param>
        /// <returns>The text that was read from the TextWindow.</returns>
        public static Primitive Read(Primitive delay)
        {
            try
            {
                Thread thread = new Thread(Delay);
                thread.Start((int)delay);
                Primitive result = TextWindow.Read();
                thread.Abort();
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Read a number from a TextWindow with a maximum delay.
        /// This sends a Return (ENTER) to the TextWindow after the delay.
        /// If the user presses Return before the delay is completed, then no further action is taken.
        /// </summary>
        /// <param name="delay">A maximum delay in ms before the Read is terminated.</param>
        /// <returns>The number that was read from the TextWindow.</returns>
        public static Primitive ReadNumber(Primitive delay)
        {
            try
            {
                Thread thread = new Thread(Delay);
                thread.Start((int)delay);
                Primitive result = TextWindow.ReadNumber();
                thread.Abort();
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Send a key to a window.  This is the same a typing the key into a window.
        /// </summary>
        /// <param name="window">The window title e.g. TextWindow.Title or GraphicsWindow.Title.</param>
        /// <param name="key">The key to send e.g. "Return"</param>
        public static void SendKey(Primitive window, Primitive key)
        {
            try
            {
                Key _key = (Key)kc.ConvertFromString(key);
                int _keycode = KeyInterop.VirtualKeyFromKey(_key);
                IntPtr _hWnd = User32.FindWindow(null, window);
                User32.PostMessage(_hWnd, User32.WM_KEYDOWN, _keycode, 0);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Hide the TextWindow.
        /// Replacement for standard method that may fail (do not mix these methods).
        /// </summary>
        public static void Hide()
        {
            Type TextWindowType = typeof(TextWindow);
            bool _windowVisible = (bool)TextWindowType.GetField("_windowVisible", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (_windowVisible)
            {
                User32.ShowWindow(User32.FindWindow(null, TextWindow.Title), User32.ShowWindowCommands.Hide);
                TextWindowType.GetField("_windowVisible", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).SetValue(null, false);
            }
        }

        /// <summary>
        /// Show the TextWindow and give it focus.
        /// Replacement for standard method that may fail (do not mix these methods).
        /// </summary>
        public static void Show()
        {
            Type TextWindowType = typeof(TextWindow);
            bool _windowVisible = (bool)TextWindowType.GetField("_windowVisible", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (!_windowVisible)
            {
                IntPtr hWnd = User32.FindWindow(null, TextWindow.Title);
                User32.ShowWindow(hWnd, User32.ShowWindowCommands.Normal);
                User32.SetForegroundWindow(hWnd);
                TextWindowType.GetField("_windowVisible", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).SetValue(null, true);
            }
        }

        /// <summary>
        /// Save the TextWindow as an image file (png, jpg, bmp, gif, tiff or ico).
        /// 
        /// The window must be visible and a short delay may be required after updating the window before calling.
        /// </summary>
        /// <param name="fileName">
        /// The file to save the image to (*.png, *.jpg, *.bmp, *.gif, *.tiff or *.ico).
        /// If this is set to "", then the image is created internally as an ImageList.
        /// </param>
        /// <param name="border">
        /// Include the window border ("True" or "False").
        /// </param>
        /// <returns>
        /// The ImageList image if fileName is "", otherwise if output to a file, then "" is returned.
        /// </returns>
        public static Primitive Capture(Primitive fileName, Primitive border)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Type ImageListType = typeof(Microsoft.SmallBasic.Library.ImageList);
            Dictionary<string, BitmapSource> _savedImages;
            TextWindow.Show();
            Utilities.bTextWindow = true;
            Utilities.bBorder = border;
            try
            {
                IntPtr _hWnd = User32.FindWindow(null, TextWindow.Title);
                Image img = Utilities.captureWindow(_hWnd);
                if (fileName == "")
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                            string shapeName = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { "ImageList" }).ToString();
                            _savedImages[shapeName] = LDImage.getBitmapImage((Bitmap)img);
                            return shapeName;
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
                else
                {
                    Utilities.saveImage(img, fileName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Print the TextWindow contents.
        /// 
        /// The window must be visible and a short delay may be required after updating the window before calling.
        /// </summary>
        /// <param name="border">
        /// Include the window border ("True" or "False").
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void Print(Primitive border)
        {
            TextWindow.Show();
            Utilities.bTextWindow = true;
            Utilities.bBorder = border;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Utilities.printWindow);

            System.Windows.Forms.PrintPreviewDialog dlg = new System.Windows.Forms.PrintPreviewDialog();
            dlg.Document = pd;
            dlg.Width = 600;
            dlg.Height = 600;
            dlg.ShowIcon = false;
            dlg.TopMost = true;
            if (LDUtilities.showPreview)
            {
                if (dlg.ShowDialog(Utilities.ForegroundHandle()) == System.Windows.Forms.DialogResult.OK)
                {
                    pd.Print();
                }
            }
            else
            {
                pd.Print();
            }
        }
    }
}
