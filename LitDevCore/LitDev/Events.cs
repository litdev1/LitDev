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

using LitDev.Engines;
using System;
using System.IO;
using System.Reflection;
using System.Security.Permissions;
using System.Windows;
using System.Windows.Input;

namespace LitDev
{
    public class ErrorEventArgs : EventArgs
    {
        private string message;

        public ErrorEventArgs(string message)
        {
            this.message = message;
        }

        public string Message()
        {
            return message;
        }
    }

    /// <summary>
    /// Additional Events.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDEvents
    {
        // Local variables set or used by events
        private static int Delta = 0;
        private static WatcherChangeTypes watchertype;
        private static string watcherfile = "";
        private static string watchpath = "C:\\";
        private static string watchfilter = "*.*";
        private static DateTime lastTime = DateTime.Now;
        private static FileSystemWatcher watcher = new FileSystemWatcher();

        // This is the SmallBasic delegate
        private static SBCallback _MouseWheelDelegate = null;
        private static SBCallback _MouseDoubleClickDelegate = null;
        private static SBCallback _ResizedDelegate = null;
        private static SBCallback _FileSystemWatcherDelegate = null;

        // Event subroutine calls the SmallBasic delegate 
        public static void _MouseWheelEvent(Object sender, MouseWheelEventArgs e) //public for LDScrollbars use
        {
            Delta = e.Delta / 120;
            if (null != _MouseWheelDelegate) _MouseWheelDelegate();
        }
        private static void _MouseDoubleClickEvent(Object sender, MouseButtonEventArgs e)
        {
            if (null != _MouseDoubleClickDelegate) _MouseDoubleClickDelegate();
        }
        private static void _ResizedEvent(Object sender, SizeChangedEventArgs e)
        {
            if (null != _ResizedDelegate) _ResizedDelegate();
        }
        private static void _FileSystemWatcherEvent(Object sender, FileSystemEventArgs e)
        {
            if (watcherfile != e.FullPath || (DateTime.Now - lastTime) > TimeSpan.FromMilliseconds(10))
            {
                watchertype = e.ChangeType;
                watcherfile = e.FullPath;
                if (null != _FileSystemWatcherDelegate) _FileSystemWatcherDelegate();
            }
            lastTime = DateTime.Now;
        }

        // Start event and set SmallBasic callback delegate
        private static SBCallback _MouseWheel
        {
            get
            {
                return _MouseWheelDelegate;
            }
            set
            {
                _MouseWheelDelegate = value;
                Type GraphicsWindowType = typeof(GraphicsWindow);
                try
                {
                    Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                    InvokeHelper ret = delegate
                    {
                        try
                        {
                            _window.MouseWheel += new MouseWheelEventHandler(_MouseWheelEvent);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    };
                    FastThread.Invoke(ret);
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }
        private static SBCallback _MouseDoubleClick
        {
            get
            {
                return _MouseDoubleClickDelegate;
            }
            set
            {
                _MouseDoubleClickDelegate = value;
                Type GraphicsWindowType = typeof(GraphicsWindow);
                try
                {
                    Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                    InvokeHelper ret = delegate
                    {
                        try
                        {
                            _window.MouseDoubleClick += new MouseButtonEventHandler(_MouseDoubleClickEvent);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    };
                    FastThread.Invoke(ret);
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }
        private static SBCallback _Resized
        {
            get
            {
                return _ResizedDelegate;
            }
            set
            {
                _ResizedDelegate = value;
                Type GraphicsWindowType = typeof(GraphicsWindow);
                try
                {
                    Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                    InvokeHelper ret = delegate
                    {
                        try
                        {
                            _window.SizeChanged += new SizeChangedEventHandler(_ResizedEvent);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    };
                    FastThread.Invoke(ret);
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }
        private static SBCallback _FileSystemWatcher
        {
            get
            {
                return _FileSystemWatcherDelegate;
            }
            set
            {
                _FileSystemWatcherDelegate = value;
                watcher.Changed += new FileSystemEventHandler(_FileSystemWatcherEvent);
                watcher.Created += new FileSystemEventHandler(_FileSystemWatcherEvent);
                watcher.Deleted += new FileSystemEventHandler(_FileSystemWatcherEvent);
            }
        }

        // Error handling event
        private static string lastError = "";
        private static SBCallback _ErrorDelegate = null;
        public static void _Error(Object sender, ErrorEventArgs e)
        {
            lastError = e.Message();
            if (null != _ErrorDelegate) _ErrorDelegate();
        }

        /// <summary>
        /// Event when the mouse wheel is rotated.
        /// </summary>
        public static event SBCallback MouseWheel
        {
            add
            {
                _MouseWheel = value;
            }
            remove
            {
                _MouseWheel = null;
            }
        }

        /// <summary>
        /// The last mouse wheel Delta (rotation direction).
        /// </summary>
        public static Primitive LastMouseWheelDelta
        {
            get { return Delta; }
        }

        /// <summary>
        /// Event when the mouse is double clicked.
        /// </summary>
        public static event SBCallback MouseDoubleClick
        {
            add
            {
                _MouseDoubleClick = value;
            }
            remove
            {
                _MouseDoubleClick = null;
            }
        }

        /// <summary>
        /// Event when the GraphicsWindow is resized.
        /// </summary>
        public static event SBCallback Resized
        {
            add
            {
                _Resized = value;
            }
            remove
            {
                _Resized = null;
            }
        }

        /// <summary>
        /// Event when a file is created, changed or deleted.
        /// 
        /// The FilePath and FileFilter should be set before registering this event.
        /// </summary>
        public static event SBCallback FileChange
        {
            add
            {
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                watcher.Path = watchpath;
                watcher.Filter = watchfilter;
                watcher.EnableRaisingEvents = true;
                watcher.IncludeSubdirectories = true; 
                _FileSystemWatcher = value;
            }
            remove
            {
                watcher.EnableRaisingEvents = false;
                _FileSystemWatcher = null;
            }
        }

        /// <summary>
        /// The root path to watch for FileSystem file change event (default is "C:").
        /// </summary>
        public static Primitive FilePath
        {
            get { return watchpath; }
            set { watchpath = value; }
        }

        /// <summary>
        /// A file filter for FileSystem file change event (default is "*.*").
        /// </summary>
        public static Primitive FileFilter
        {
            get { return watchfilter; }
            set { watchfilter = value; }
        }

        /// <summary>
        /// The full path to the last file changed.
        /// </summary>
        public static Primitive LastFileChanged
        {
            get{ return watcherfile;}
        }

        /// <summary>
        /// The last file change type ("Created", "Changed" or "Deleted").
        /// </summary>
        public static Primitive LastFileChangeType
        {
            get { return watchertype.ToString(); }
        }

        /// <summary>
        /// Event when a LitDev extension error occurs.
        /// This is in addition to TextWindow warnings, which can be turned off using LDUtilties.ShowErrors, LDUtilties.ShowFileErrors and LDUtilties.ShowNoShapeErrors.
        /// </summary>
        public static event SBCallback Error
        {
            add
            {
                _ErrorDelegate = value;
            }
            remove
            {
                _ErrorDelegate = null;
            }
        }

        /// <summary>
        /// The last error message.
        /// </summary>
        public static Primitive LastError
        {
            get { return lastError; }
        }
    }
}
