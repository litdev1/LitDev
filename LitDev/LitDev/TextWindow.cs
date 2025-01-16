//#define SVB
#if SVB
using Microsoft.SmallVisualBasic.Library;
using Microsoft.SmallVisualBasic.Library.Internal;
using SBArray = Microsoft.SmallVisualBasic.Library.Array;
using SBShapes = Microsoft.SmallVisualBasic.Library.Shapes;
using SBFile = Microsoft.SmallVisualBasic.Library.File;
using SBMath = Microsoft.SmallVisualBasic.Library.Math;
using SBProgram = Microsoft.SmallVisualBasic.Library.Program;
using SBControls = Microsoft.SmallVisualBasic.Library.Controls;
using SBImageList = Microsoft.SmallVisualBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallVisualBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallVisualBasic.Library.SmallVisualBasicCallback;
#else
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using SBArray = Microsoft.SmallBasic.Library.Array;
using SBShapes = Microsoft.SmallBasic.Library.Shapes;
using SBFile = Microsoft.SmallBasic.Library.File;
using SBMath = Microsoft.SmallBasic.Library.Math;
using SBProgram = Microsoft.SmallBasic.Library.Program;
using SBControls = Microsoft.SmallBasic.Library.Controls;
using SBImageList = Microsoft.SmallBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallBasic.Library.SmallBasicCallback;
#endif

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
using LitDev.Engines;
using System.Windows;
using System.Windows.Threading;
using System.ComponentModel;
using Microsoft.JScript;

namespace LitDev
{
    /// <summary>
    /// TextWindow utilities.
    /// Includes low level keyboard events.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDTextWindow
    {
        static LDTextWindow()
        {
            Instance.Verify();
        }

        private static KeyConverter kc = new KeyConverter();
        private static Object _lock = new Object();
        private static Keys _LastKey = Keys.None;
        private static SBCallback _KeyDownDelegate = null;
        private static SBCallback _KeyUpDelegate = null;
        private static bool bHooked = false;
        private static User32.LowLevelKeyboardProc _hookDelegate = new User32.LowLevelKeyboardProc(HookCallback);
        private static bool updateShowHide = true;

        private static void Delay(Object delay)
        {
            Thread.Sleep((int)delay);
            IntPtr _hWnd = User32.FindWindow(null, TextWindow.Title);
            User32.PostMessage(_hWnd, User32.WM_KEYDOWN, User32.VK_RETURN, 0);
        }

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

        [DllImport("Kernel32")]
        private static extern bool SetConsoleCtrlHandler(ConsoleExitEventHandler handler, bool add);
        private delegate bool ConsoleExitEventHandler(CtrlType sig);
        static ConsoleExitEventHandler _ConsoleExitEventHandler;
        private static SBCallback _ExitDelegate = null;

        enum CtrlType
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT = 1,
            CTRL_CLOSE_EVENT = 2,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT = 6
        }

        private static bool _ConsoleExitEvent(CtrlType sig)
        {
            if (null != _ExitDelegate) _ExitDelegate();
            return true;
        }

        private static void _ApplicationExitEvent(object sender, ExitEventArgs e)
        {
            if (null != _ExitDelegate) _ExitDelegate();
        }

        private static void _ProcessExitEvent(object sender, EventArgs e)
        {
            if (null != _ExitDelegate) _ExitDelegate();
        }

        private static void _DomainUnloadEvent(object sender, EventArgs e)
        {
            if (null != _ExitDelegate) _ExitDelegate();
        }

        private static void _ApplicationSessionEndingEvent(object sender, SessionEndingCancelEventArgs e)
        {
            if (null != _ExitDelegate) _ExitDelegate();
        }

        /// <summary>
        /// Event when TextWindow is closing.
        /// You can perform any final actions here.
        /// </summary>
        public static event SBCallback Exit
        {
            add
            {
                _ExitDelegate = value;
                _ConsoleExitEventHandler += new ConsoleExitEventHandler(_ConsoleExitEvent);
                SetConsoleCtrlHandler(_ConsoleExitEventHandler, true);

                if (false)
                {
                    // Application or domain events don't seem to work here - I think because SB kills process rather than letting application close normally
                    AppDomain.CurrentDomain.ProcessExit += new EventHandler(_ProcessExitEvent);
                    AppDomain.CurrentDomain.DomainUnload += new EventHandler(_DomainUnloadEvent);
                    Type SmallBasicApplicationType = typeof(SmallBasicApplication);
                    try
                    {
                        System.Windows.Application _application = (System.Windows.Application)SmallBasicApplicationType.GetField("_application", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                        MethodInfo methodInvoke = typeof(SmallBasicApplication).GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                        InvokeHelper ret = delegate
                        {
                            InvokeHelper ret1 = delegate
                            {
                                _application.ShutdownMode = ShutdownMode.OnLastWindowClose;
                                _application.Exit += new ExitEventHandler(_ApplicationExitEvent);
                                _application.SessionEnding += new SessionEndingCancelEventHandler(_ApplicationSessionEndingEvent);
                            };
                            methodInvoke.Invoke(null, new object[] { ret1 });
                        };
                        methodInvoke.Invoke(null, new object[] { ret });
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                }
            }
            remove
            {
                _ExitDelegate = null;
            }
        }

        /// <summary>
        /// Low level event when a key is pressed down.
        /// This event is independent of any window focus, i.e. not just for TextWindow or GraphicsWindow.
        /// </summary>
        public static event SBCallback KeyDown
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
        /// This event is independent of any window focus, i.e. not just for TextWindow or GraphicsWindow.
        /// </summary>
        public static event SBCallback KeyUp
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
        /// Reset the LastKey to None.
        /// </summary>
        public static void LastKeyReset()
        {
            _LastKey = Keys.None;
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
        /// Also update internal state when using Hide and Minimise methods, "True" (default) or "False".
        /// If the internal state is updated as hidden or minimised, then methods like Read will automatically bring the window into focus.
        /// </summary>
        public static Primitive UpdateShowHide
        {
            get { return updateShowHide; }
            set { updateShowHide = value; }
        }

        /// <summary>
        /// Completely hide the TextWindow.
        /// Replacement for standard method that may fail if window manually changed by the user.
        /// </summary>
        public static void Hide()
        {
            User32.ShowWindow(User32.FindWindow(null, TextWindow.Title), User32.ShowWindowCommands.Hide);
            Type TextWindowType = typeof(TextWindow);
            TextWindowType.GetField("_windowVisible", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).SetValue(null, updateShowHide ? false : true);
        }

        /// <summary>
        /// Minimise the TextWindow.
        /// </summary>
        public static void Minimise()
        {
            User32.ShowWindow(User32.FindWindow(null, TextWindow.Title), User32.ShowWindowCommands.Minimize);
            Type TextWindowType = typeof(TextWindow);
            TextWindowType.GetField("_windowVisible", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).SetValue(null, updateShowHide ? false : true);
        }

        /// <summary>
        /// Show the TextWindow and give it focus.
        /// Replacement for standard method that may fail  if window manually changed by the user.
        /// </summary>
        public static void Show()
        {
            IntPtr hWnd = User32.FindWindow(null, TextWindow.Title);
            User32.ShowWindow(hWnd, User32.ShowWindowCommands.Normal);
            User32.SetForegroundWindow(hWnd);
            Type TextWindowType = typeof(TextWindow);
            TextWindowType.GetField("_windowVisible", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).SetValue(null, true);
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
            Type ShapesType = typeof(Shapes);
            Type ImageListType = typeof(SBImageList);
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
#if SVB
                            string shapeName = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { "ImageList", false }).ToString();
#else
                            string shapeName = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { "ImageList" }).ToString();
#endif
                            _savedImages[shapeName] = FastPixel.GetBitmapImage((Bitmap)img);
                            return shapeName;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
            Utilities.NumPages = 1;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Utilities.printWindow);

            if (LDUtilities.showPreview)
            {
                //var dlg1 = new PrintDialog();
                //TextWindow.WriteLine(dlg1.ShowDialog().ToString());
                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = pd;
                dlg.Width = 600;
                dlg.Height = 600;
                dlg.ShowIcon = false;
                dlg.TopMost = true;
                dlg.ShowDialog(Utilities.ForegroundHandle());
            }
            else
            {
                pd.Print();
            }
        }

        /// <summary>
        /// Set extended encoding for the TextWindow.
        /// Allowed values are:
        /// "ASCII" (default), "Unicode", "UTF7", "UTF8"
        /// </summary>
        public static Primitive Encoding
        {
            get
            {
                return Console.OutputEncoding.EncodingName;
            }
            set
            {
                switch (((string)value).ToLower())
                {
                    case "ascii":
                        Console.OutputEncoding = System.Text.Encoding.ASCII;
                        break;
                    case "unicode":
                        Console.OutputEncoding = System.Text.Encoding.Unicode;
                        break;
                    //case "bigendianunicode":
                    //    Console.OutputEncoding = System.Text.Encoding.BigEndianUnicode;
                    //    break;
                    //case "utf32":
                    //    Console.OutputEncoding = System.Text.Encoding.UTF32;
                    //    break;
                    case "utf7":
                        Console.OutputEncoding = System.Text.Encoding.UTF7;
                        break;
                    case "utf8":
                        Console.OutputEncoding = System.Text.Encoding.UTF8;
                        break;
                }
            }
        }

        /// <summary>
        /// Replace one of the standard TextWindow colours.
        /// There are 16 available colours, by default they are indexed 0 to 15:
        /// Black (0), DarkBlue (1), DarkGreen (2), DarkCyan (3), DarkRed (4), DarkMagenta (5), DarkYellow (6), Gray (7),
        /// DarkGray (8), Blue (9), Green (10), Cyan (11), Red (12), Magenta (13), Yellow (14), White (15).
        /// Note that you can still use TextWindow.BackgroundColor and TextWindow.ForegroundColor to use the new colours (with the original colour names), alternatively the colours can be selected using LDTextWindow.SetColours from the indices.
        /// The colours must be set using either method before they are applied.
        /// </summary>
        /// <param name="index">The stanadard colour index colour to replace.</param>
        /// <param name="colour">Any colour to replace a standard colour with.</param>
        public static void SetColour(Primitive index, Primitive colour)
        {
            try
            {
                TextWindow.Show();
                ColorConverter colConvert = new ColorConverter();
                Color col = (Color)colConvert.ConvertFromString((string)colour);
                ScreenColors.SetColor(index, col);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set the current foreground and background colour indices.
        /// </summary>
        /// <param name="fgIndex">The foreground colour index (0 to 15).</param>
        /// <param name="bgIndex">The background colour index (0 to 15).</param>
        public static void SetColours(Primitive fgIndex, Primitive bgIndex)
        {
            try
            {
                TextWindow.Show();
                ScreenColors.SetColours(fgIndex, bgIndex);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
    }

    class ScreenColors
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct COORD
        {
            internal short X;
            internal short Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct SMALL_RECT
        {
            internal short Left;
            internal short Top;
            internal short Right;
            internal short Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct COLORREF
        {
            internal uint ColorDWORD;

            internal COLORREF(Color color)
            {
                ColorDWORD = (uint)color.R + (((uint)color.G) << 8) + (((uint)color.B) << 16);
            }

            internal COLORREF(uint r, uint g, uint b)
            {
                ColorDWORD = r + (g << 8) + (b << 16);
            }

            internal Color GetColor()
            {
                return Color.FromArgb((int)(0x000000FFU & ColorDWORD), (int)(0x0000FF00U & ColorDWORD) >> 8, (int)(0x00FF0000U & ColorDWORD) >> 16);
            }

            internal void SetColor(Color color)
            {
                ColorDWORD = (uint)color.R + (((uint)color.G) << 8) + (((uint)color.B) << 16);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct CONSOLE_SCREEN_BUFFER_INFO_EX
        {
            internal int cbSize;
            internal COORD dwSize;
            internal COORD dwCursorPosition;
            internal ushort wAttributes;
            internal SMALL_RECT srWindow;
            internal COORD dwMaximumWindowSize;
            internal ushort wPopupAttributes;
            internal bool bFullscreenSupported;
            internal COLORREF black;
            internal COLORREF darkBlue;
            internal COLORREF darkGreen;
            internal COLORREF darkCyan;
            internal COLORREF darkRed;
            internal COLORREF darkMagenta;
            internal COLORREF darkYellow;
            internal COLORREF gray;
            internal COLORREF darkGray;
            internal COLORREF blue;
            internal COLORREF green;
            internal COLORREF cyan;
            internal COLORREF red;
            internal COLORREF magenta;
            internal COLORREF yellow;
            internal COLORREF white;
        }

        const int STD_OUTPUT_HANDLE = -11;                                        // per WinBase.h
        internal static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);    // per WinBase.h

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleScreenBufferInfoEx(IntPtr hConsoleOutput, ref CONSOLE_SCREEN_BUFFER_INFO_EX csbe);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleScreenBufferInfoEx(IntPtr hConsoleOutput, ref CONSOLE_SCREEN_BUFFER_INFO_EX csbe);

        [DllImport("kernel32", SetLastError = true)]
        private static extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput, ushort wAttributes);

        public static int SetColor(int index, Color colour)
        {
            byte r = colour.R;
            byte g = colour.G;
            byte b = colour.B;

            CONSOLE_SCREEN_BUFFER_INFO_EX csbe = new CONSOLE_SCREEN_BUFFER_INFO_EX();
            csbe.cbSize = (int)Marshal.SizeOf(csbe);                    // 96 = 0x60
            IntPtr hConsoleOutput = GetStdHandle(STD_OUTPUT_HANDLE);    // 7
            if (hConsoleOutput == INVALID_HANDLE_VALUE)
            {
                return Marshal.GetLastWin32Error();
            }
            bool brc = GetConsoleScreenBufferInfoEx(hConsoleOutput, ref csbe);
            if (!brc)
            {
                return Marshal.GetLastWin32Error();
            }

            switch ((ConsoleColor)index)
            {
                case ConsoleColor.Black:
                    csbe.black = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkBlue:
                    csbe.darkBlue = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkGreen:
                    csbe.darkGreen = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkCyan:
                    csbe.darkCyan = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkRed:
                    csbe.darkRed = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkMagenta:
                    csbe.darkMagenta = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkYellow:
                    csbe.darkYellow = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Gray:
                    csbe.gray = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkGray:
                    csbe.darkGray = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Blue:
                    csbe.blue = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Green:
                    csbe.green = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Cyan:
                    csbe.cyan = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Red:
                    csbe.red = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Magenta:
                    csbe.magenta = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Yellow:
                    csbe.yellow = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.White:
                    csbe.white = new COLORREF(r, g, b);
                    break;
            }
            ++csbe.srWindow.Bottom;
            ++csbe.srWindow.Right;

            brc = SetConsoleScreenBufferInfoEx(hConsoleOutput, ref csbe);
            if (!brc)
            {
                return Marshal.GetLastWin32Error();
            }

            return 0;
        }

        public static void SetColours(int fgIndex, int bgIndex)
        {
            IntPtr hConsoleOutput = GetStdHandle(STD_OUTPUT_HANDLE);
            SetConsoleTextAttribute(hConsoleOutput, (ushort)(16 * bgIndex + fgIndex));
        }
    }

#if SVB
#else
    /// <summary>
    /// Alias for TextWindow.
    /// 
    /// The TextWindow provides text-related input and output functionalities.  For example using this class, it is possible to write or read some text or number to and from the text-based text window.
    /// </summary>
    [SmallBasicType]
    public static class TW
    {
        /// <summary>Shows the Text window to enable interactions with it.</summary>
        public static void Show()
        {
            TextWindow.Show();
        }

        /// <summary>
        /// Hides the text window.  Content is perserved when the window is shown again.
        /// </summary>
        public static void Hide()
        {
            TextWindow.Hide();
        }

        /// <summary>Clears the TextWindow.</summary>
        public static void Clear()
        {
            TextWindow.Clear();
        }

        /// <summary>Waits for user input before returning.</summary>
        public static void Pause()
        {
            TextWindow.Pause();
        }

        /// <summary>
        /// Waits for user input only when the TextWindow is already open.
        /// </summary>
        public static void PauseIfVisible()
        {
            TextWindow.PauseIfVisible();
        }

        /// <summary>Waits for user input before returning.</summary>
        public static void PauseWithoutMessage()
        {
            TextWindow.PauseWithoutMessage();
        }

        /// <summary>
        /// Reads a line of text from the text window.  This function will not return until the user hits ENTER.
        /// </summary>
        /// <returns>The text that was read from the text window</returns>
        public static Primitive Read()
        {
            return TextWindow.Read();
        }

        /// <summary>Reads a single character from the text window.</summary>
        /// <returns>The character that was read from the text window.</returns>
        [HideFromIntellisense]
        public static Primitive ReadKey()
        {
            return TextWindow.ReadKey();
        }

        /// <summary>
        /// Reads a number from the text window.  This function will not return until the user hits ENTER.
        /// </summary>
        /// <returns>The number that was read from the text window</returns>
        public static Primitive ReadNumber()
        {
            return TextWindow.ReadNumber();
        }

        /// <summary>
        /// Writes text or number to the text window.  A new line character will be appended to the output, so that the next time something is written to the text window, it will go in a new line.
        /// </summary>
        /// <param name="data">
        /// The text or number to write to the text window.
        /// </param>
        public static void WriteLine(Primitive data)
        {
            TextWindow.WriteLine(data);
        }

        /// <summary>
        /// Writes text or number to the text window.  Unlike WriteLine, this will not append a new line character, which means, anything written to the text window after this call will be on the same line.
        /// </summary>
        /// <param name="data">
        /// The text or number to write to the text window
        /// </param>
        public static void Write(Primitive data)
        {
            TextWindow.Write(data);
        }

        /// <summary>
        /// Gets or sets the foreground color of the text to be output in the text window.
        /// </summary>
        public static Primitive ForegroundColor
        {
            get
            {
                return TextWindow.ForegroundColor;
            }
            set
            {
                TextWindow.ForegroundColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the background color of the text to be output in the text window.
        /// </summary>
        public static Primitive BackgroundColor
        {
            get
            {
                return TextWindow.BackgroundColor;
            }
            set
            {
                TextWindow.BackgroundColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the cursor's column position on the text window.
        /// </summary>
        public static Primitive CursorLeft
        {
            get
            {
                return TextWindow.CursorLeft;
            }
            set
            {
                TextWindow.CursorLeft = value;
            }
        }

        /// <summary>
        /// Gets or sets the cursor's row position on the text window.
        /// </summary>
        public static Primitive CursorTop
        {
            get
            {
                return TextWindow.CursorTop;
            }
            set
            {
                TextWindow.CursorTop = value;
            }
        }

        /// <summary>Gets or sets the Left position of the Text Window.</summary>
        public static Primitive Left
        {
            get
            {
                return TextWindow.Left;
            }
            set
            {
                TextWindow.Left = value;
            }
        }

        /// <summary>Gets or sets the Title for the text window.</summary>
        public static Primitive Title
        {
            get
            {
                return TextWindow.Title;
            }
            set
            {
                TextWindow.Title = value;
            }
        }

        /// <summary>Gets or sets the Top position of the Text Window.</summary>
        public static Primitive Top
        {
            get
            {
                return TextWindow.Top;
            }
            set
            {
                TextWindow.Top = value;
            }
        }
    }
#endif
}
