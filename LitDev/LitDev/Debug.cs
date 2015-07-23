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
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows;
using SBArray = Microsoft.SmallBasic.Library.Array;

namespace LitDev
{
    /// <summary>
    /// Debugging utilities.
    /// </summary>
    [SmallBasicType]
    public static class LDDebug
    {
        public static bool running = false;
        public static bool ignoreAllBreaks = false;
        public static bool includeAllBreaks = true;
        public static Thread applicationThread;
        public static Thread currentThread;
        public static List<string> breakLabels = new List<string>();
        public static List<string> breakText = new List<string>();
        public static List<bool> ignoreBreaks = new List<bool>();
        public static int stepOut = 0;

        private static FormDebug formDebug = null;
        private static Thread worker = null;

        private static void RunDebug()
        {
            formDebug = new FormDebug();
            formDebug.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            formDebug.Location = new System.Drawing.Point(((int)SystemParameters.PrimaryScreenWidth * LDUtilities.DPIX / 96 - formDebug.Width - 4), ((int)SystemParameters.PrimaryScreenHeight * LDUtilities.DPIY / 96 - formDebug.Height) / 2);
            formDebug.TopMost = true;
            formDebug.ShowDialog();
        }

        private static void setLabels()
        {
            breakLabels.Clear();
            breakText.Clear();
            ignoreBreaks.Clear();
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            string fileName = System.IO.Path.GetFullPath(entryAssembly.Location);
            fileName = fileName.Replace(".exe", ".sb");
            try
            {
                if (System.IO.File.Exists(fileName))
                {
                    string[] lines = System.IO.File.ReadAllLines(fileName);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        if (line.ToLower().Contains("lddebug.break"))
                        {
                            string label = "";
                            if (line.ToLower().Contains("\""))
                            {
                                label = line.Substring(line.IndexOf('\"') + 1);
                                label = label.Substring(0, label.IndexOf('\"'));
                                if (label.Length > 0)
                                {
                                    breakLabels.Add(label);
                                    breakText.Add(label);
                                    ignoreBreaks.Add(true);
                                }
                            }
                            else if (fileName.ToLower().Contains("_debug.sb") && line.ToLower().Contains("("))
                            {
                                label = line.Substring(line.IndexOf('(') + 1);
                                label = label.Substring(0, label.IndexOf(')'));
                                if (label.Length > 0)
                                {
                                    breakLabels.Add(label);
                                    if (i < lines.Length - 1) breakText.Add(label + " : " + lines[i + 1]);
                                    ignoreBreaks.Add(true);
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
        }

        private static bool checkCondition(string value1, string value2)
        {
            double dValue1, dValue2;
            if (double.TryParse(value1, out dValue1) && double.TryParse(value2, out dValue2))
            {
                switch (FormDebug.conditionType)
                {
                    case 0:
                        return dValue1 == dValue2;
                    case 1:
                        return dValue1 < dValue2;
                    case 2:
                        return dValue1 > dValue2;
                }
            }
            else
            {
                switch (FormDebug.conditionType)
                {
                    case 0:
                        return string.Compare(value1, value2, true, CultureInfo.InvariantCulture) == 0;
                    case 1:
                        return string.Compare(value1, value2, true, CultureInfo.InvariantCulture) < 0;
                    case 2:
                        return string.Compare(value1, value2, true, CultureInfo.InvariantCulture) > 0;
                }
            }
            return false;
        }

        private static bool isCondition()
        {
            string varName = FormDebug.conditionName.ToLower();
            Primitive varValue = FormDebug.conditionValue;
            varValue = Text.ConvertToLowerCase(varValue);
            if (varName == "" || varValue == "") return false;

            try
            {
                if (applicationThread.ThreadState != System.Threading.ThreadState.Running) applicationThread.Suspend();
                StackTrace stackTrace = new StackTrace(applicationThread, false);
                StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
                MethodBase method = frame.GetMethod();
                Type type = method.DeclaringType;
                FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
                for (int i = 0; i < fields.Length; i++)
                {
                    Primitive var = (Primitive)(fields[i].GetValue(null));
                    var = Text.ConvertToLowerCase(var);
                    int pos = varName.IndexOf("[");
                    string variable = pos < 0 ? varName : varName.Substring(0, pos);
                    if (fields[i].Name.ToLower() == variable)
                    {
                        string arrayName = fields[i].Name.ToLower();
                        if (SBArray.IsArray(var))
                        {
                            Primitive Indices1 = SBArray.GetAllIndices(var);
                            for (int j = 1; j <= SBArray.GetItemCount(Indices1); j++)
                            {
                                Primitive var1 = var[Indices1[j]];
                                arrayName = ((string)(fields[i].Name + "[" + Indices1[j] + "]")).ToLower();
                                if (SBArray.IsArray(var1))
                                {
                                    Primitive Indices2 = SBArray.GetAllIndices(var1);
                                    for (int k = 1; k <= SBArray.GetItemCount(Indices2); k++)
                                    {
                                        Primitive var2 = var1[Indices2[k]];
                                        arrayName = ((string)(fields[i].Name + "[" + Indices1[j] + "]" +"[" + Indices2[k] + "]")).ToLower();
                                        if (SBArray.IsArray(var2))
                                        {
                                            Primitive Indices3 = SBArray.GetAllIndices(var2);
                                            for (int l = 1; l <= SBArray.GetItemCount(Indices3); l++)
                                            {
                                                Primitive var3 = var2[Indices3[l]];
                                                arrayName = ((string)(fields[i].Name + "[" + Indices1[j] + "]" + "[" + Indices2[k] + "]" +"[" + Indices3[l] + "]")).ToLower();
                                                if (arrayName.StartsWith(varName) && checkCondition(var3,varValue)) return true;
                                            }
                                        }
                                        else
                                        {
                                            if (arrayName.StartsWith(varName) && checkCondition(var2,varValue)) return true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (arrayName.StartsWith(varName) && checkCondition(var1, varValue)) return true;
                                }
                            }
                        }
                        else
                        {
                            if (checkCondition(var, varValue)) return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                if (Utilities.bShowErrors) TextWindow.WriteLine("ThreadState " + applicationThread.ThreadState.ToString());
                return false;
            }
        }

        /// <summary>
        /// Start a debugging session, usually do this as the first line of your program.
        /// 
        /// Usually you would either set break points manually in your code before running (LDDebug.Break) or auto add breakpoints (LDDebug.Instrument).
        /// </summary>
        public static void Start()
        {
            if (!running)
            {
                applicationThread = Thread.CurrentThread;
                currentThread = Thread.CurrentThread;
                setLabels();
                worker = new Thread(new ThreadStart(RunDebug));
                worker.Start();
                running = true;
                Program.Delay(1000); // Give time for FormDebug timer to catch the pause before continuing - we will be paused anyway so no delay
            }
        }

        /// <summary>
        /// Create a SmallBasic file (_debug.sb) with break points auto added for each line.
        /// 
        /// Just open and run the new instrumented file to debug it.  
        /// When a problem is found, correct it in your original and re-instrument to debug the corrected file.
        /// </summary>
        /// <param name="fileName">The Smallbasic file (*.sb) to instrument.</param>
        public static void Instrument(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return;
            }
            try
            {
                string[] lines = System.IO.File.ReadAllLines(fileName);
                List<string> output = new List<string>();
                output.Add("LDDebug.Start()");
                //output.Add("Program.Delay(1000)"); //To ensure start at the beginning
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Trim().Length > 0 && !lines[i].Trim().StartsWith("'"))
                    {
                        output.Add("LDDebug.Break(" + (i + 1).ToString() + ")");
                    }
                    output.Add(lines[i]);
                }
                string fileOutput = fileName;
                fileOutput = fileOutput.Replace(".sb", "_debug.sb");
                System.IO.File.WriteAllLines(fileOutput, output);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set a break point, where the program will pause and variable values can be viewed.
        /// </summary>
        /// <param name="label">An identification label for the breakpoint.
        /// A unique label should be chosen for each breakpoint defined.
        /// There are some known limitations with breakpoints inside event subroutines.</param>
        public static void Break(Primitive label)
        {
            if ((ignoreAllBreaks && stepOut == 0) || !running) return;
            //if (applicationThread.ThreadState != System.Threading.ThreadState.Running) return;
            //TextWindow.WriteLine("Break App " + applicationThread.ThreadState.ToString());
            currentThread = Thread.CurrentThread;
            bool ignoreBreak = breakLabels.Contains(label) ? ignoreBreaks[breakLabels.IndexOf(label)] : false;
            bool bBreak = false;
            if (!ignoreAllBreaks)
            {
                if (FormDebug.conditionBPOnly)
                {
                    bBreak = includeAllBreaks || (!ignoreBreak && isCondition());
                }
                else
                {
                    bBreak = includeAllBreaks || !ignoreBreak || isCondition();
                }
            }
            // Process step out
            if (stepOut == 2)
            {
                bBreak = true;
                stepOut = 0;
            }
            else if (stepOut == 1)
            {
                if (breakLabels.Contains(label) && breakText[breakLabels.IndexOf(label)].ToLower().EndsWith("endsub")) stepOut = 2;
            }

            if (bBreak)
            {
                FormDebug.label = label;
                FormDebug.onBreak = true;
                Program.Delay(200); // Give time for FormDebug timer to catch the pause before continuing - we will be paused anyway so no delay
            }
        }
    }
}
