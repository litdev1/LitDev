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
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace LitDev
{
    class IncludeFile
    {
        public int index; 
        public string name;
        Assembly assembly;
        public Type type = null;
        public FieldInfo[] fieldInfos;
        public IncludeFile(string path, int index)
        {
            this.index = index;
            name = "Include" + index;
            assembly = Assembly.LoadFrom(path);
            if (null == assembly) return;
            type = assembly.GetType("_SmallBasicProgram", false, true);
            if (null == type) return;
            fieldInfos = type.GetFields(BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
        }
    }

    /// <summary>
    /// Call Functions with arguments, asyncronously from any extension or from a pre-compiled SmallBasic exe.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDCall
    {
        static LDCall()
        {
            Instance.Verify();
        }

        private static Assembly entryAssembly = Assembly.GetEntryAssembly();
        private static Type mainModule = entryAssembly.EntryPoint.DeclaringType;
        private static string compiler = "";

        private static string Func(string funcName, Primitive args)
        {
            try
            {
                MethodInfo methodInfo = mainModule.GetMethod(funcName, BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                if (null == methodInfo) return "Subroutine " + funcName + " not found";
                FieldInfo argsInfo = mainModule.GetField("args", BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                if (null == argsInfo) return "Variable 'args' not found";
                FieldInfo returnInfo = mainModule.GetField("return", BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                if (args != "") argsInfo.SetValue(argsInfo, args);
                methodInfo.Invoke(null, null);
                string result = (null == returnInfo) ? "" : returnInfo.GetValue("result").ToString();
                argsInfo.SetValue(argsInfo, (Primitive)"");
                if (null != returnInfo) returnInfo.SetValue(returnInfo, (Primitive)"");
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return (Utilities.GetCurrentMethod()+" "+ex.Message);
            }
        }

        private static string lastCall = "";
        private static string lastResult = "";
        private static Object lockCall = new Object();
        private static SBCallback _CallCompleteDelegate = null;
        private static void DoCall(Object obj)
        {
            MethodInfo methodInfo = (MethodInfo)((Object[])obj)[0];
            Object[] args = (Object[])((Object[])obj)[1];
            string callName = (string)((Object[])obj)[2];
            Primitive result = "";

            try
            {
                if (methodInfo.ReturnType == typeof(Primitive)) result = (Primitive)methodInfo.Invoke(null, args);
                else methodInfo.Invoke(null, args);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }

            lock (lockCall)
            {
                lastResult = result;
                lastCall = callName;
                if (null != _CallCompleteDelegate) _CallCompleteDelegate();
            }
        }

        private static List<IncludeFile> includeFiles = new List<IncludeFile>();
        private static int GetNextInclude()
        {
            int i = 1;
            foreach (IncludeFile include in includeFiles)
            {
                if (include.index == i) i = include.index + 1;
            }
            return i;
        }
        private static IncludeFile GetInclude(string name)
        {
            foreach (IncludeFile include in includeFiles)
            {
                if (include.name == name) return include;
            }
            return null;
        }

        /// <summary>
        /// Call a Small Basic Sub as a function with one input argument.
        /// 
        /// The input arguments(s) will be copied to an array called "args".
        /// The result should be put in a variable (may be an array) called "return".
        /// The variable "args" should be set to "" at the start of the program.
        /// The input parameter(s) are unchanged, while "args" and "return" are set to "" on return.
        /// </summary>
        /// <param name="funcName">The Small Basic Sub name.</param>
        /// <param name="arg1">An input value (may be an array).</param>
        /// <returns>The result of the function held in optional variable "return" or an error message.</returns>
        public static Primitive Function(Primitive funcName, Primitive arg1)
        {
            Primitive args = "";
            args[1] = arg1;
            return Func(funcName, args);
        }

        /// <summary>
        /// Call a Small Basic Sub as a function with two input arguments.
        /// 
        /// See Function for more details.
        /// </summary>
        /// <param name="funcName">The Small Basic Sub name.</param>
        /// <param name="arg1">1st input value (may be an array).</param>
        /// <param name="arg2">2nd input value (may be an array).</param>
        /// <returns>The result of the function held in variable "return" or an error message.</returns>
        public static Primitive Function2(Primitive funcName, Primitive arg1, Primitive arg2)
        {
            Primitive args = "";
            args[1] = arg1;
            args[2] = arg2;
            return Func(funcName, args);
        }

        /// <summary>
        /// Call a Small Basic Sub as a function with three input arguments.
        /// 
        /// See Function for more details.
        /// </summary>
        /// <param name="funcName">The Small Basic Sub name.</param>
        /// <param name="arg1">1st input value (may be an array).</param>
        /// <param name="arg2">2nd input value (may be an array).</param>
        /// <param name="arg3">3rd input value (may be an array).</param>
        /// <returns>The result of the function held in variable "return" or an error message.</returns>
        public static Primitive Function3(Primitive funcName, Primitive arg1, Primitive arg2, Primitive arg3)
        {
            Primitive args = "";
            args[1] = arg1;
            args[2] = arg2;
            args[3] = arg3;
            return Func(funcName, args);
        }

        /// <summary>
        /// Call a Small Basic Sub as a function with four input arguments.
        /// 
        /// See Function for more details.
        /// </summary>
        /// <param name="funcName">The Small Basic Sub name.</param>
        /// <param name="arg1">1st input value (may be an array).</param>
        /// <param name="arg2">2nd input value (may be an array).</param>
        /// <param name="arg3">3rd input value (may be an array).</param>
        /// <param name="arg4">4th input value (may be an array).</param>
        /// <returns>The result of the function held in variable "return" or an error message.</returns>
        public static Primitive Function4(Primitive funcName, Primitive arg1, Primitive arg2, Primitive arg3, Primitive arg4)
        {
            Primitive args = "";
            args[1] = arg1;
            args[2] = arg2;
            args[3] = arg3;
            args[4] = arg4;
            return Func(funcName, args);
        }

        /// <summary>
        /// Call a Small Basic Sub as a function with five input arguments.
        /// 
        /// See Function for more details.
        /// </summary>
        /// <param name="funcName">The Small Basic Sub name.</param>
        /// <param name="arg1">1st input value (may be an array).</param>
        /// <param name="arg2">2nd input value (may be an array).</param>
        /// <param name="arg3">3rd input value (may be an array).</param>
        /// <param name="arg4">4th input value (may be an array).</param>
        /// <param name="arg5">5th input value (may be an array).</param>
        /// <returns>The result of the function held in variable "return" or an error message.</returns>
        public static Primitive Function5(Primitive funcName, Primitive arg1, Primitive arg2, Primitive arg3, Primitive arg4, Primitive arg5)
        {
            Primitive args = "";
            args[1] = arg1;
            args[2] = arg2;
            args[3] = arg3;
            args[4] = arg4;
            args[5] = arg5;
            return Func(funcName, args);
        }

        /// <summary>
        /// Event when an asynchronous subroutine method call completes.
        /// </summary>
        public static event SBCallback CallComplete
        {
            add
            {
                _CallCompleteDelegate = value;
            }
            remove
            {
                _CallCompleteDelegate = null;
            }
        }

        /// <summary>
        /// The last asynchronous call name.
        /// </summary>
        public static Primitive LastCall
        {
            get { return lastCall; }
        }

        /// <summary>
        /// The last asynchronous call return value.
        /// </summary>
        public static Primitive LastResult
        {
            get { return lastResult; }
        }

        /// <summary>
        /// Call any extension method asynchronously.
        /// See example LDCallAsync.
        /// If dll, extension, obj and arguments are all "", then method may be a subroutine in your SmallBasic program.
        /// </summary>
        /// <param name="dll">The extension dll (e.g. "LitDev.dll" or "SmallBasicLibrary.dll").</param>
        /// <param name="extension">The extension namespace (usually the same as the dll name, e.g. "LitDev" or "MicroSoft.SmallBasic.Library" for SmallBasicLibrary.dll).</param>
        /// <param name="obj">The extension object name.</param>
        /// <param name="method">The extension method name.</param>
        /// <param name="arguments">An array of arguments or "" for none.  A single argument doesn't have to be in an array.</param>
        /// <returns>"PENDING" or an error message on failure.</returns>
        public static Primitive CallAsync(Primitive dll, Primitive extension, Primitive obj, Primitive method, Primitive arguments)
        {
            try
            {
                Type type;
                string callName = "";
                if (dll == "" && extension == "" && obj == "" && arguments == "")
                {
                    type = mainModule;
                }
                else
                {
                    string path = Path.GetDirectoryName(entryAssembly.Location) + "\\" + dll;
                    if (!System.IO.File.Exists(path)) return dll + " dll not found";
                    Assembly assembly = Assembly.LoadFrom(path);
                    type = assembly.GetType(extension + "." + obj, false, true);
                    if (null == type) return extension + "." + obj + " extension not found";
                    callName += extension + "." + obj + ".";
                }
                MethodInfo methodInfo = type.GetMethod((string)method, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                if (null == methodInfo) return method + " method not found";

                int numArgs = 0;
                Object[] args = null;
                callName += method + "(";
                if (SBArray.IsArray(arguments))
                {
                    numArgs = SBArray.GetItemCount(arguments);
                    args = new Object[numArgs];
                    Primitive indices = SBArray.GetAllIndices(arguments);
                    for (int i = 1; i <= numArgs; i++)
                    {
                        args[i - 1] = arguments[indices[i]];
                        callName += arguments[indices[i]];
                        if (i < numArgs) callName += ",";
                    }
                }
                else if (arguments != "")
                {
                    args = new Object[1] { arguments };
                    callName += arguments;
                }
                callName += ")";

                Thread thread = new Thread(new ParameterizedThreadStart(DoCall));
                thread.Start(new Object[] { methodInfo, args, callName });
                //while (!thread.IsAlive) Thread.Sleep(1); //delay to let async call get started
                return "PENDING";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return ex.Message;
            }
        }

        /// <summary>
        /// Reference a previously compiled program to use a subroutine method from.
        /// </summary>
        /// <param name="path">The full path to a secondary compiled Small Basic program to use (.exe)</param>
        /// <returns>A name for the include file or "" on failure.</returns>
        public static Primitive Include(Primitive path)
        {
            try
            {
                IncludeFile includeFile = new IncludeFile(path, GetNextInclude());
                if (null == includeFile.type) return "";
                includeFiles.Add(includeFile);
                return includeFile.name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Call a method in an included pre-compiled file.
        /// All main program variables are shared with the called subroutine.
        /// </summary>
        /// <param name="include">The include file name returned by Include method.</param>
        /// <param name="method">The subroutine name to call in the included exe.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive CallInclude(Primitive include, Primitive method)
        {
            try
            {
                IncludeFile includeFile = GetInclude(include);
                if (null == includeFile) return "FAILED";
                MethodInfo methodInfo = includeFile.type.GetMethod(method, BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                if (null == methodInfo) return "FAILED";

                foreach (FieldInfo fieldInfo in includeFile.fieldInfos)
                {
                    FieldInfo fieldInfoMain = mainModule.GetField(fieldInfo.Name, BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                    if (null != fieldInfoMain) fieldInfo.SetValue(null, fieldInfoMain.GetValue(null));
                }
                methodInfo.Invoke(null, null);
                foreach (FieldInfo fieldInfo in includeFile.fieldInfos)
                {
                    FieldInfo fieldInfoMain = mainModule.GetField(fieldInfo.Name, BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                    if (null != fieldInfoMain) fieldInfoMain.SetValue(null, fieldInfo.GetValue(null));
                }
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Call a method in an included pre-compiled file, specifying dynamic input and output parameters.
        /// If both of these are "", then all variables will be copied in and back from this call, which is equivalent to the CallInclude method.
        /// Unset variable values in the included subroutine persist between calls.
        /// </summary>
        /// <param name="include">The include file name returned by Include method.</param>
        /// <param name="method">The subroutine name to call in the included exe.</param>
        /// <param name="input">An array of variable names that will be copied to the subroutine.
        /// If this is "", then all variables will be copied to the subroutine.</param>
        /// <param name="output">An array of variable names that will be copied back from the subroutine.
        /// If this is "", then the same input variables will be copied back from the subroutine.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive CallIncludeWithVars(Primitive include, Primitive method, Primitive input, Primitive output)
        {
            try
            {
                List<string> _input = new List<string>();
                if (input != "")
                {
                    if (SBArray.IsArray(input))
                    {
                        Primitive indices = SBArray.GetAllIndices(input);
                        for (int i = 1; i <= SBArray.GetItemCount(indices); i++)
                        {
                            int index = indices[i];
                            _input.Add(((string)input[index]).ToLower());
                        }
                    }
                    else
                    {
                        _input.Add(((string)input).ToLower());
                    }
                }
                List<string> _output = new List<string>();
                if (output == "")
                {
                    output = input;
                }
                if (output != "")
                {
                    if (SBArray.IsArray(output))
                    {
                        Primitive indices = SBArray.GetAllIndices(output);
                        for (int i = 1; i <= SBArray.GetItemCount(indices); i++)
                        {
                            int index = indices[i];
                            _output.Add(((string)output[index]).ToLower());
                        }
                    }
                    else
                    {
                        _output.Add(((string)output).ToLower());
                    }
                }

                IncludeFile includeFile = GetInclude(include);
                if (null == includeFile) return "FAILED";
                MethodInfo methodInfo = includeFile.type.GetMethod(method, BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                if (null == methodInfo) return "FAILED";

                foreach (FieldInfo fieldInfo in includeFile.fieldInfos)
                {
                    if (_input.Count == 0 || _input.Contains(fieldInfo.Name.ToLower()))
                    {
                        FieldInfo fieldInfoMain = mainModule.GetField(fieldInfo.Name, BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                        if (null != fieldInfoMain) fieldInfo.SetValue(null, fieldInfoMain.GetValue(null));
                    }
                }
                methodInfo.Invoke(null, null);
                foreach (FieldInfo fieldInfo in includeFile.fieldInfos)
                {
                    if (_output.Count == 0 || _output.Contains(fieldInfo.Name.ToLower()))
                    {
                        FieldInfo fieldInfoMain = mainModule.GetField(fieldInfo.Name, BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                        if (null != fieldInfoMain) fieldInfoMain.SetValue(null, fieldInfo.GetValue(null));
                    }
                }
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Set or get the path to the Small Basic compiler for use with Compile method.  If unset the default location will be used.
        /// </summary>
        public static Primitive Compiler
        {
            get
            {
                if (compiler == "")
                {
                    if (IntPtr.Size == 8)
                    {
                        compiler = "C:\\Program Files (x86)\\Microsoft\\Small Basic\\SmallBasicCompiler.exe";
                    }
                    else
                    {
                        compiler = "C:\\Program Files\\Microsoft\\Small Basic\\SmallBasicCompiler.exe";
                    }
                }

                return compiler;
            }
            set
            {
                compiler = value;
                if (!System.IO.File.Exists(compiler))
                {
                    compiler = "";
                }
            }
        }
        /// <summary>
        /// Compile a secondary Small Basic file.
        /// Assumes that Small Basic is installed in the default location for your OS.
        /// </summary>
        /// <param name="path">A Small Basic file to compile (.sb).</param>
        /// <returns>The path of the compiled file (.exe) or "" on failure.</returns>
        public static Primitive Compile(Primitive path)
        {
            try
            {
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Compiler;
                psi.Arguments = "\"" + Path.GetFileName(path) + "\"";
                psi.WorkingDirectory = Path.GetDirectoryName(path);
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                p.StartInfo = psi;
                p.Start();
                if (!p.StandardOutput.ReadToEnd().Contains("0 errors")) return "";

                string result = Path.GetDirectoryName(path) + "\\" + Path.GetFileNameWithoutExtension(path) + ".exe";
                if (System.IO.File.Exists(result) && DateTime.Now - System.IO.File.GetLastWriteTime(result) < TimeSpan.FromMilliseconds(1000)) return result;
                return "";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }
    }
}
