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

namespace LitDev
{
    /// <summary>
    /// Control an external application.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDProcess
    {
        class proc : IComparable
        {
            public int ID;
            public string name;

            public proc(int _ID, string _name)
            {
                ID = _ID;
                name = _name;
            }

            int IComparable.CompareTo(object obj)
            {
                return name.CompareTo(((proc)obj).name);
            }
        }
        private static List<proc> procs = new List<proc>();

        /// <summary>
        /// Start an external application.
        /// </summary>
        /// <param name="application">
        /// The full path of the application to start e.g. "C:\Program Files (x86)\Microsoft\Small Basic\SB.exe".
        /// </param>
        /// <param name="arguments">
        /// Arguments to give to the command or "" if none.
        /// </param>
        /// <returns>
        /// Process ID of started application, -1 if failed or -2 if attached to existing process.
        /// </returns>
        public static Primitive Start(Primitive application, Primitive arguments)
        {
            try
            {
                System.Diagnostics.Process process = System.Diagnostics.Process.Start(application, arguments);
                return (null != process) ? process.Id : -2;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return -1;
            }
        }

        /// <summary>
        /// Stop an external process.
        /// </summary>
        /// <param name="ID">
        /// The process ID to stop.
        /// </param>
        /// <returns>
        /// "True" or "False" for success or failure.
        /// </returns>
        public static Primitive Stop(Primitive ID)
        {
            try
            {
                System.Diagnostics.Process.GetProcessById(ID).Kill();
                return "True";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "False";
            }
        }

        /// <summary>
        /// Get a list of system processes.
        /// </summary>
        /// <returns>
        /// An array of all the system process names, indexed by the process ID.
        /// </returns>
        public static Primitive GetProcesses()
        {
            try
            {
                System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcesses();
                int count = process.GetLength(0);

                //Get name and ID, sort on name
                procs.Clear();
                for (int i = 0; i < count; i++)
                {
                    proc _proc = new proc(process[i].Id, process[i].ProcessName);
                    procs.Add(_proc);
                }
                procs.Sort();

                //Convert to SB array
                Primitive processes = "";
                foreach (proc _proc in procs)
                {
                    processes[_proc.ID] = _proc.name;
                }

                return processes;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }
    }
}
