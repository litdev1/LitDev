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

using System.Collections.Generic;

namespace LitDev
{
    /// <summary>
    /// This object provides a way of storing values.
    /// It is similar to a stack, except that is is fist-in first-out, like a queue.  
    /// You can enqueue (add) a value to the end of the queue and dequeue (remove) the first value at the front of the queue.
    /// You can only enqueue and dequeue the values one by one.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDQueue
    {
        static LDQueue()
        {
            Instance.Verify();
        }

        private static Dictionary<Primitive, Queue<Primitive>> _queueMap = new Dictionary<Primitive, Queue<Primitive>>();
        private static object lockQ = new object();

        /// <summary>
        /// Adds a value to the end of the specified queue.
        /// </summary>
        /// <param name="queueName">
        /// The name of the queue.
        /// </param>
        /// <param name="value">
        /// The value to enqueue.
        /// </param>
        public static void Enqueue(Primitive queueName, Primitive value)
        {
            lock (lockQ)
            {
                Queue<Primitive> queue;
                if (!_queueMap.TryGetValue(queueName, out queue))
                {
                    queue = new Queue<Primitive>();
                    _queueMap[queueName] = queue;
                }
                queue.Enqueue(value);
            }
        }

        /// <summary>
        /// Gets the count of items in the specified queue.
        /// </summary>
        /// <param name="queueName">
        /// The name of the queue.
        /// </param>
        /// <returns>
        /// The number of items in the specified queue.
        /// </returns>
        public static Primitive GetCount(Primitive queueName)
        {
            lock (lockQ)
            {
                Queue<Primitive> queue;
                if (!_queueMap.TryGetValue(queueName, out queue))
                {
                    queue = new Queue<Primitive>();
                    _queueMap[queueName] = queue;
                }
                return queue.Count;
            }
        }

        /// <summary>
        /// Remove (and get) the value from the front of the specified queue.
        /// </summary>
        /// <param name="queueName">
        /// The name of the queue.
        /// </param>
        /// <returns>
        /// The value from the queue.
        /// </returns>
        public static Primitive Dequeue(Primitive queueName)
        {
            lock (lockQ)
            {
                Queue<Primitive> queue;
                if (_queueMap.TryGetValue(queueName, out queue))
                {
                    return queue.Dequeue();
                }
                return "";
            }
        }
    }
}
