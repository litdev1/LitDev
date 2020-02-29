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
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

using LitDev.Engines;
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;

namespace LitDev
{
    /// <summary>
    /// Create additional GraphicsWindows.
    /// 
    /// All variables are shared between windows (global scope).
    /// GraphicsWindow events must be registered for each window, but the event subroutine can be shared.
    /// All other events can be registered once as normal.
    /// All commands or methods apply to the current active window, set using CurrentID.
    /// The original or default GraphicsWindow has id 0.
    /// </summary>
    [SmallBasicType]
    public static class LDWindows
    {
        private static object _lock = new object();
        private static double lastActivatedTime = 0.0;
        private static int currentWin = 0;
        private static int focusWin = 0;
        private static Type GraphicsWindowType = typeof(GraphicsWindow);
        private static MethodInfo mCreateWindow = GraphicsWindowType.GetMethod("CreateWindow", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
        private static SmallBasicCallback ActivatedDelegate = null;
        private static void ActivatedHandler(Object sender, EventArgs e)
        {
            //Try to reduce multi events by taking the first of quick repeats
            if (null == ActivatedDelegate || Clock.ElapsedMilliseconds - lastActivatedTime < 100) return;
            lastActivatedTime = Clock.ElapsedMilliseconds;
            foreach (Win i in Wins)
            {
                if (i.window == (Window)(sender))
                {
                    focusWin = i.id;
                    ActivatedDelegate();
                    return;
                }
            }
        }

        private class Win
        {
            public int id;
            public Window window;
            List<object> obj = new List<object>();

            public Win(int _id)
            {
                id = _id;
                if (id > 0)
                {
                    mCreateWindow.Invoke(null, new object[] { });
                    GraphicsWindow.Show();
                }
                else
                {
                    bool _windowCreated = (bool)GraphicsWindowType.GetField("_windowCreated", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                    if (!_windowCreated)
                    {
                        GraphicsWindow.Show();
                        GraphicsWindow.Hide();
                    }
                }
                InvokeHelper ret = delegate
                {
                    try
                    {
                        window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                        window.Activated += new EventHandler(ActivatedHandler);
                        FieldInfo[] fields = GraphicsWindowType.GetFields(BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
                        foreach (FieldInfo i in fields)
                        {
                            obj.Add(GraphicsWindowType.GetField(i.Name, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null));
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                };
                FastThread.Invoke(ret);
            }

            public void Save()
            {
                lock (_lock)
                {
                    obj.Clear();
                    InvokeHelper ret = delegate
                    {
                        try
                        {
                            FieldInfo[] fields = GraphicsWindowType.GetFields(BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
                            foreach (FieldInfo i in fields)
                            {
                                obj.Add(GraphicsWindowType.GetField(i.Name, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null));
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    };
                    FastThread.Invoke(ret);
                }
            }

            public void Load()
            {
                lock (_lock)
                {
                    InvokeHelper ret = delegate
                    {
                        FieldInfo[] fields = GraphicsWindowType.GetFields(BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
                        int ii = 0;
                        foreach (FieldInfo i in fields)
                        {
                            try //Cannot set the constants
                            {
                                object _value = GraphicsWindowType.GetField(i.Name, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                                if (!i.IsLiteral) GraphicsWindowType.GetField(i.Name, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_value, obj[ii]);
                                ii++;
                            }
                            catch (Exception ex)
                            {
                                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            }
                        }
                    };
                    FastThread.Invoke(ret);
                }
            }

            public void setActive()
            {
                InvokeHelper ret = delegate
                {
                    try
                    {
                        GraphicsWindow.Show();
                        window.Activate();
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                };
                FastThread.Invoke(ret);
            }
        }

        private static List<Win> Wins = new List<Win>();

        private static int newID()
        {
            int nextID = 0;
            foreach (Win win in Wins)
            {
                nextID = System.Math.Max(nextID, win.id + 1);
            }
            return nextID;
        }

        private static Win getWin(int id)
        {
            foreach (Win win in Wins)
            {
                if (win.id == id) return win;
            }
            return null;
        }

        private static void switchWin(int id)
        {
            if (id == currentWin) return;

            Win win;

            win = getWin(currentWin);
            if (null != win)
            {
                win.Save();
            }

            win = getWin(id);
            if (null != win)
            {
                currentWin = id;
                win.Load();
            }
        }

        /// <summary>
        /// Create a new GraphicsWindow.
        /// </summary>
        /// <returns>An id for the created window.</returns>
        public static Primitive Create()
        {
            Win win;

            if (Wins.Count == 0)
            {
                win = new Win(newID());
                Wins.Add(win);
            }
            else
            {
                win = getWin(currentWin);
            }
            if (null != win)
            {
                win.Save();
            }

            win = new Win(newID());
            currentWin = win.id;
            Wins.Add(win);
            return currentWin;
        }

        /// <summary>
        /// Get or set the current window id.
        /// </summary>
        public static Primitive CurrentID
        {
            get { return currentWin; }
            set { switchWin(value); }
        }

        /// <summary>
        /// Event when a window is activated.
        /// Use this event with care - not recommended for most cases.
        /// </summary>
        public static event SmallBasicCallback Activated
        {
            add
            {
                ActivatedDelegate = value;
            }
            remove
            {
                ActivatedDelegate = null;
            }
        }

        /// <summary>
        /// Last window activated.
        /// </summary>
        public static Primitive LastActivated
        {
            get { return focusWin; }
        }

        /// <summary>
        /// Get or set the id of a window active state (top most).
        /// -1 if no active windows.
        /// </summary>
        public static Primitive Active
        {
            get
            {
                foreach (Win i in Wins)
                {
                    if (i.window.IsActive) return i.id;
                }
                return -1;
            }
            set
            {
                Win win;

                win = getWin(value);
                if (null != win)
                {
                    win.setActive();
                }
            }
        }
    }
}
