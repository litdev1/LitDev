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
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace LitDev
{
    /// <summary>
    /// Accurate system stopwatches.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDStopwatch
    {
        static LDStopwatch()
        {
            Instance.Verify();
        }

        private static Dictionary<string, Stopwatch> watches = new Dictionary<string, Stopwatch>();
        private static Stopwatch watch;
        private static object lockWatch = new object();
        private static Stopwatch delayWatch = null;

        private static string GetNewWatch()
        {
            int i = 1;
            while (watches.TryGetValue("Stopwatch" + i, out watch)) i++;
            string name = "Stopwatch" + i;
            watches[name] = new Stopwatch();
            return name;
        }

        /// <summary>
        /// Create a new stopwatch.
        /// </summary>
        /// <returns>The stopwatch name.</returns>
        public static Primitive Add()
        {
            lock (lockWatch)
            {
                return GetNewWatch();
            }
        }

        /// <summary>
        /// Starts or resumes the current stopwatch.
        /// </summary>
        /// <param name="stopwatch">The stopwatch name.</param>
        public static void Start(Primitive stopwatch)
        {
            lock (lockWatch)
            {
                if (!watches.TryGetValue(stopwatch, out watch)) return;
                watch.Start();
            }
        }

        /// <summary>
        /// Stops the current stopwatch and resets the elapsed time to 0.
        /// </summary>
        /// <param name="stopwatch">The stopwatch name.</param>
        public static void Reset(Primitive stopwatch)
        {
            lock (lockWatch)
            {
                if (!watches.TryGetValue(stopwatch, out watch)) return;
                watch.Reset();
            }
        }

        /// <summary>
        /// Stops the current stopwatch, resets the elapsed time to 0 and restarts the stopwatch.
        /// </summary>
        /// <param name="stopwatch">The stopwatch name.</param>
        public static void Restart(Primitive stopwatch)
        {
            lock (lockWatch)
            {
                if (!watches.TryGetValue(stopwatch, out watch)) return;
                watch.Restart();
            }
        }

        /// <summary>
        /// Stops the current stopwatch.
        /// </summary>
        /// <param name="stopwatch">The stopwatch name.</param>
        public static void Stop(Primitive stopwatch)
        {
            lock (lockWatch)
            {
                if (!watches.TryGetValue(stopwatch, out watch)) return;
                watch.Stop();
            }
        }

        /// <summary>
        /// Gets the total elapsed time measured in milliseconds.
        /// </summary>
        /// <param name="stopwatch">The stopwatch name.</param>
        /// <returns>Elapsed milliseconds.</returns>
        public static Primitive ElapsedMilliseconds(Primitive stopwatch)
        {
            lock (lockWatch)
            {
                if (!watches.TryGetValue(stopwatch, out watch)) return -1;
                return (decimal)watch.ElapsedMilliseconds;
            }
        }

        /// <summary>
        /// Gets the total elapsed time measured in timer ticks for very short intervals.
        /// </summary>
        /// <param name="stopwatch">The stopwatch name.</param>
        /// <returns>Elapsed ticks.</returns>
        public static Primitive ElapsedTicks(Primitive stopwatch)
        {
            lock (lockWatch)
            {
                if (!watches.TryGetValue(stopwatch, out watch)) return -1;
                return (decimal)watch.ElapsedTicks;
            }
        }

        /// <summary>
        /// Get the frequency of the stopwatch timer in ticks per second.
        /// This represents the finest resolution of time your hardware can measure with ElapsedTicks.
        /// </summary>
        public static Primitive Frequency
        {
            get { return (decimal)Stopwatch.Frequency; }
        }

        /// <summary>
        /// Delay up to a maximum interval since the last time this is called.
        /// Useful in a game loop to maintain an even play speed.
        /// </summary>
        /// <param name="delay">The maximum delay in ms.</param>
        public static void DelayUpTo(Primitive delay)
        {
            if (null == delayWatch)
            {
                delayWatch = new Stopwatch();
                delayWatch.Start();
            }
            TimeSpan interval = TimeSpan.FromMilliseconds(delay) - delayWatch.Elapsed;
            if (interval > TimeSpan.Zero) Thread.Sleep(interval);
            delayWatch.Restart();
        }
    }
}

