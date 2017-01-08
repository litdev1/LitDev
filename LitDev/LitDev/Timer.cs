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
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace LitDev
{
    /// <summary>
    /// Additional timers.
    /// </summary>
    [SmallBasicType]
    public static class LDTimer
    {
        class ObjTimer
        {
            private const int _maxInterval = 100000000;
            private const int _minInterval = 10;

            private string _name;
            private int _interval;
            private System.Threading.Timer _threadTimer;
            private SmallBasicCallback _tick = null;

            public event SmallBasicCallback Tick
            {
                add
                {
                    _tick += value;
                }
                remove
                {
                    _tick = null;
                }
            }

            public string Name
            {
                get { return _name; }
            }

            public int Interval
            {
                get
                {
                    return _interval;
                }
                set
                {
                    _interval = System.Math.Max(_minInterval, System.Math.Min(value, _maxInterval));
                    _threadTimer.Change(_interval, _interval);
                }
            }

            public ObjTimer(string name)
            {
                _name = name;
                _interval = _maxInterval;
                _threadTimer = new System.Threading.Timer(new TimerCallback(ThreadTimerCallback));
            }

            public void Pause()
            {
                _threadTimer.Change(-1, -1);
            }

            public void Resume()
            {
                _threadTimer.Change(_interval, _interval);
            }

            private void ThreadTimerCallback(object state)
            {
                if (null != _tick)
                {
                    _tick();
                }
                else if (null != timerTick)
                {
                    lastTimer = _name;
                    timerTick();
                }
            }
        }

        private static Dictionary<string, ObjTimer> timers = new Dictionary<string, ObjTimer>();
        private static SmallBasicCallback timerTick = null;
        private static string lastTimer = "";
        private static Assembly entryAssembly = Assembly.GetEntryAssembly();
        private static Type mainModule = entryAssembly.EntryPoint.DeclaringType;

        private static ObjTimer GetNewTimer()
        {
            int i = 1;
            ObjTimer objTimer;
            while (timers.TryGetValue("Timer" + i, out objTimer)) i++;
            string name = "Timer" + i;
            objTimer = new ObjTimer(name);
            timers[name] = objTimer;
            return objTimer;
        }

        /// <summary>
        /// Raises an event when a timer created with Add ticks.
        /// </summary>
        public static event SmallBasicCallback Tick
        {
            add
            {
                timerTick += value;
            }
            remove
            {
                timerTick = null;
            }
        }

        /// <summary>
        /// The last timer created with Add that raised an event.
        /// </summary>
        public static Primitive LastTimer
        {
            get { return lastTimer; }
        }

        /// <summary>
        /// Create a new timer.  All timers created with this method call the event subroutine defined by Tick.
        /// </summary>
        /// <returns>The timer name.</returns>
        public static Primitive Add()
        {
            ObjTimer objTimer = GetNewTimer();
            return objTimer.Name;
        }

        /// <summary>
        /// Create a new timer.  This timer only calls its own event subroutine.
        /// </summary>
        /// <param name="tick">The event subroutine for this timer.</param>
        /// <returns>The timer name.</returns>
        public static Primitive AddTick(Primitive tick)
        {
            ObjTimer objTimer = GetNewTimer();

            MethodInfo methodInfo = mainModule.GetMethod(tick, BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
            if (null != methodInfo) objTimer.Tick += (SmallBasicCallback)Delegate.CreateDelegate(typeof(SmallBasicCallback), methodInfo);

            return objTimer.Name;
        }

        /// <summary>
        /// Starts or resumes a timer.
        /// </summary>
        /// <param name="timer">The timer name.</param>
        /// <param name="interval">Sets the interval (in milliseconds) specifying how often the timer should raise the Tick event.  This value can range from 10 to 100000000.</param>
        public static void Interval(Primitive timer, Primitive interval)
        {
            ObjTimer objTimer;
            if (!timers.TryGetValue(timer, out objTimer)) return;
            objTimer.Interval = interval;
        }

        /// <summary>
        /// Pauses a timer.  Tick events will not be raised.
        /// </summary>
        /// <param name="timer">The timer name.</param>
        public static void Pause(Primitive timer)
        {
            ObjTimer objTimer;
            if (!timers.TryGetValue(timer, out objTimer)) return;
            objTimer.Pause();
        }

        /// <summary>
        /// Resumes a timer from a paused state.  Tick events will now be raised.
        /// </summary>
        /// <param name="timer">The timer name.</param>
        public static void Resume(Primitive timer)
        {
            ObjTimer objTimer;
            if (!timers.TryGetValue(timer, out objTimer)) return;
            objTimer.Resume();
        }
    }
}

