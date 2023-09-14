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
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using Microsoft.JScript;

namespace LitDev
{
    class AssemblyComparer : IComparer<Assembly>
    {
        public int Compare(Assembly x, Assembly y)
        {
            return x.GetName().Name.CompareTo(y.GetName().Name);
        }
    }
    class TypeComparer : IComparer<Type>
    {
        public int Compare(Type x, Type y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    class AssemblyNameComparer : IComparer<AssemblyName>
    {
        public int Compare(AssemblyName x, AssemblyName y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    class MethodComparer : IComparer<MethodInfo>
    {
        public int Compare(MethodInfo x, MethodInfo y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    class PropertyComparer : IComparer<PropertyInfo>
    {
        public int Compare(PropertyInfo x, PropertyInfo y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    class EventComparer : IComparer<EventInfo>
    {
        public int Compare(EventInfo x, EventInfo y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    /// <summary>
    /// Include C#, VB or JScript code to use at runtime.  
    /// If multiple namespaces or classes are used, then all method, property or event names should be unique.
    /// Alternatively a fully qualified namespace.type.name may be used.
    /// Can be used to compile extensions.
    /// May also be used with other .Net dlls compiled externally.
    /// Method, property, event, class and used references can be obtained (public static only).
    /// 
    /// The current application assemblies are auto referenced.
    /// Depending on .Net methods used additional assemblies may be required.
    /// Additional assemblies are referenced by full dll path.
    /// Assembly dlls are often found in the following or similar locations:
    /// C:\Windows\Microsoft.NET\Framework\v2.0.50727
    /// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.0
    /// 
    /// The TextWindow should be visible prior to using these methods if later use of the TextWindow is required.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDInline
    {
        private static Assembly entryAssembly = Assembly.GetEntryAssembly();
        private static Type mainModule = entryAssembly.EntryPoint.DeclaringType;

        private static MethodInfo GetMethod(Type typeFrom, string methodName, Type typeTo, BindingFlags bindingFlags)
        {
            foreach (MethodInfo method in typeFrom.GetMethods(bindingFlags))
            {
                if (method.Name == methodName && method.ReturnType == typeTo) return method;
            }
            return null;
        }
        private static Object ObjectCast(Object obj, Type typeTo)
        {
            Type typeFrom = obj.GetType();
            if (typeFrom == typeTo) return obj;
            MethodInfo method = GetMethod(typeFrom, "op_Implicit", typeTo, BindingFlags.Static | BindingFlags.Public);
            if (null == method)
            {
                method = GetMethod(typeFrom, "op_Explicit", typeTo, BindingFlags.Static | BindingFlags.Public);
            }
            if (null == method) throw new InvalidCastException("Invalid Variable Type");
            return method.Invoke(null, new object[] { obj });
        }

        private static List<Assembly> _assemblies = new List<Assembly>();
        private static List<Assembly> _references = new List<Assembly>();
        private static List<Type> _types = new List<Type>();
        private static List<MethodInfo> _methods = new List<MethodInfo>();
        private static List<PropertyInfo> _properties = new List<PropertyInfo>();
        private static List<EventInfo> _events = new List<EventInfo>();

        private static List<string> loadedAssemblies = new List<string>();
        private static CompilerParameters SetReferences(Primitive assemblies, string dllName, bool bJS = false)
        {
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.TreatWarningsAsErrors = false;
            compilerParams.GenerateExecutable = false;
            if (!bJS) compilerParams.CompilerOptions = "/optimize";
            if (dllName.Length == 0)
            {
                compilerParams.GenerateInMemory = true;
            }
            else
            {
                compilerParams.GenerateInMemory = false;
                if (!dllName.EndsWith(".dll")) dllName += ".dll";
                compilerParams.OutputAssembly = dllName;
                if (!bJS) compilerParams.CompilerOptions += " /doc:" + '"'+Path.ChangeExtension(dllName, ".xml") + '"';
            }

            loadedAssemblies.Clear();

            AddReferences(Assembly.GetExecutingAssembly(), compilerParams);
            if (!bJS)
            {
                foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    AddReferences(assembly, compilerParams);
                }
            }
            if (SBArray.IsArray(assemblies))
            {
                Primitive indices = SBArray.GetAllIndices(assemblies);
                for (int i = 1; i <= SBArray.GetItemCount(indices); i++)
                {
                    try
                    {
                        AddReference(Assembly.ReflectionOnlyLoadFrom(assemblies[indices[i]]), compilerParams);
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                }
            }
            else if (assemblies != "")
            {
                try
                {
                    AddReference(Assembly.ReflectionOnlyLoadFrom(assemblies), compilerParams);
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory+"\\Resources"))
            {
                string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\Resources");
                foreach (string file in files)
                {
                    compilerParams.EmbeddedResources.Add(file);
                }
            }

            return compilerParams;
        }
        private static void AddReferences(Assembly assembly, CompilerParameters compilerParams)
        {
            AddReference(assembly, compilerParams);
            foreach (AssemblyName assemblyName in assembly.GetReferencedAssemblies())
            {
                try
                {
                    AddReference(Assembly.ReflectionOnlyLoad(assemblyName.FullName), compilerParams);
                }
                catch
                {
                }
            }
        }
        private static void AddReference(Assembly assembly, CompilerParameters compilerParams)
        {
            if (!loadedAssemblies.Contains(assembly.GetName().Name))
            {
                //TextWindow.WriteLine(assembly.GetName().Name);
                loadedAssemblies.Add(assembly.GetName().Name);
                _references.Add(assembly);
                compilerParams.ReferencedAssemblies.Add(assembly.Location);
            }
        }
        private static Object[] GetArguments(Primitive args, MethodInfo methodInfo)
        {
            Object[] arguments = new Object[] { };
            if (SBArray.IsArray(args))
            {
                Primitive indices = SBArray.GetAllIndices(args);
                int count = SBArray.GetItemCount(indices);
                arguments = new Object[count];
                for (int i = 1; i <= count; i++)
                {
                    arguments[i - 1] = ObjectCast(args[indices[i]], methodInfo.GetParameters()[i - 1].ParameterType);
                }
            }
            else if (args != "")
            {
                arguments = new Object[1];
                arguments[0] = ObjectCast(args, methodInfo.GetParameters()[0].ParameterType);
            }
            return arguments;
        }
        private static string PostCompile(CompilerResults compile)
        {
            if (compile.Errors.HasErrors)
            {
                if (Utilities.bShowErrors)
                {
                    foreach (CompilerError ce in compile.Errors)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), new Exception(ce.ToString()));
                    }
                }
                return "FAILED";
            }

            SetTypes(compile.CompiledAssembly);

            return "SUCCESS";
        }
        private static void SetTypes(Assembly assembly)
        {
            _assemblies.Add(assembly);
            Module[] modules = assembly.GetModules();
            BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Static;
            foreach (Module module in modules)
            {
                Type[] types = module.GetTypes();
                foreach (Type type in types)
                {
                    bool hasContent = false;
                    MethodInfo[] methodInfos = type.GetMethods(bindingFlags);
                    hasContent |= (methodInfos.Length > 0);
                    foreach (MethodInfo methodInfo in methodInfos)
                    {
                        _methods.Add(methodInfo);
                    }
                    PropertyInfo[] propertyInfos = type.GetProperties(bindingFlags);
                    hasContent |= (propertyInfos.Length > 0);
                    foreach (PropertyInfo propertyInfo in propertyInfos)
                    {
                        _properties.Add(propertyInfo);
                    }
                    EventInfo[] eventInfos = type.GetEvents(bindingFlags);
                    hasContent |= (eventInfos.Length > 0);
                    foreach (EventInfo eventInfo in eventInfos)
                    {
                        _events.Add(eventInfo);
                    }
                    if (hasContent) _types.Add(type);
                }
            }
            _assemblies.Sort(new AssemblyComparer());
            _references.Sort(new AssemblyComparer());
            _types.Sort(new TypeComparer());
            _methods.Sort(new MethodComparer());
            _properties.Sort(new PropertyComparer());
            _events.Sort(new EventComparer());
        }

        /// <summary>
        /// Include and compile a C# Class(es).  Can be the contents of a file read with File.ReadContents().
        /// </summary>
        /// <param name="source">The C# source.</param>
        /// <param name="assemblies">An array of any additional assemblies required.</param>
        /// <param name="dllName">An optional path to create a dll (+xml) output, use "" to perform in-memory.</param>
        /// <returns>"FAILED" or "SUCCESS"</returns>
        public static Primitive IncludeCS(Primitive source, Primitive assemblies, Primitive dllName)
        {
            try
            {
                CompilerParameters compilerParams = SetReferences(assemblies, dllName);
                CSharpCodeProvider provider = new CSharpCodeProvider();
                CompilerResults compile = provider.CompileAssemblyFromSource(compilerParams, source);
                return PostCompile(compile);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Include and compile a VB Module(s).  Can be the contents of a file read with File.ReadContents().
        /// </summary>
        /// <param name="source">The VB source.</param>
        /// <param name="assemblies">An array of any additional assemblies required.</param>
        /// <param name="dllName">An optional path to create a dll (+xml) output, use "" to perform in-memory.</param>
        /// <returns>"FAILED" or "SUCCESS"</returns>
        public static Primitive IncludeVB(Primitive source, Primitive assemblies, Primitive dllName)
        {
            try
            {
                CompilerParameters compilerParams = SetReferences(assemblies, dllName);
                VBCodeProvider provider = new VBCodeProvider();
                CompilerResults compile = provider.CompileAssemblyFromSource(compilerParams, source);
                return PostCompile(compile);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Include and compile a JScript Module(s).  Can be the contents of a file read with File.ReadContents().
        /// </summary>
        /// <param name="source">The JScript source.</param>
        /// <param name="assemblies">An array of any additional assemblies required.</param>
        /// <param name="dllName">An optional path to create a dll output, use "" to perform in-memory.</param>
        /// <returns>"FAILED" or "SUCCESS"</returns>
        public static Primitive IncludeJScript(Primitive source, Primitive assemblies, Primitive dllName)
        {
            try
            {
                CompilerParameters compilerParams = SetReferences(assemblies, dllName, true);
                JScriptCodeProvider provider = new JScriptCodeProvider();
                CompilerResults compile = provider.CompileAssemblyFromSource(compilerParams, source);
                return PostCompile(compile);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Use a previously compiled and saved dll.
        /// </summary>
        /// <param name="dllName">The dll path.</param>
        public static void LoadDLL(Primitive dllName)
        {
            try
            {
                if (!((string)dllName).EndsWith(".dll")) dllName += ".dll";
                Assembly assembly = Assembly.LoadFrom(dllName);
                SetTypes(assembly);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Call a previously included method.
        /// </summary>
        /// <param name="method">The method name.</param>
        /// <param name="args">The method arguments, "" for none, a single value or an array for more than 1 value.</param>
        /// <returns>Any results from the call or "FAILED".</returns>
        public static Primitive Call(Primitive method, Primitive args)
        {
            try
            {
                foreach (MethodInfo methodInfo in _methods)
                {
                    if (methodInfo.Name == method || methodInfo.ReflectedType + "." + methodInfo.Name == method)
                    {
                        Object[] arguments = GetArguments(args, methodInfo);
                        Object result = methodInfo.Invoke(null, arguments);
                        if (null != result) return result.ToString();
                        return "";
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Get a previously included property.
        /// </summary>
        /// <param name="property">The property name.</param>
        /// <returns>The property value or "FAILED".</returns>
        public static Primitive Get(Primitive property)
        {
            try
            {
                foreach (PropertyInfo propertyInfo in _properties)
                {
                    if (propertyInfo.Name == property || propertyInfo.ReflectedType + "." + propertyInfo.Name == property)
                    {
                        return propertyInfo.GetValue(null, null).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Set a previously included property.
        /// </summary>
        /// <param name="property">The property name.</param>
        /// <param name="value">The property value.</param>
        public static void Set(Primitive property, Primitive value)
        {
            try
            {
                foreach (PropertyInfo propertyInfo in _properties)
                {
                    if (propertyInfo.Name == property || propertyInfo.ReflectedType + "." + propertyInfo.Name == property)
                    {
                        Object obj = ObjectCast(value, propertyInfo.PropertyType);
                        propertyInfo.SetValue(null, obj, null);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set a callback subroutine for a previously included event.
        /// </summary>
        /// <param name="Event">The event name.</param>
        /// <param name="callBack">The callback subroutine.</param>
        public static void Event(Primitive Event, Primitive callBack)
        {
            try
            {
                foreach (EventInfo eventInfo in _events)
                {
                    if (eventInfo.Name == Event || eventInfo.ReflectedType + "." + eventInfo.Name == Event)
                    {
                        MethodInfo methodInfo = mainModule.GetMethod(callBack, BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                        SBCallback _callBack = (SBCallback)Delegate.CreateDelegate(typeof(SBCallback), methodInfo);
                        eventInfo.GetAddMethod().Invoke(null, new Object[] { _callBack });
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Get an array of inline methods loaded.
        /// </summary>
        /// <param name="fullName">Get the full name (namespace.type.method) "True" or just the method name "False".</param>
        /// <returns>Array of method names and return type.</returns>
        public static Primitive GetMethods(Primitive fullName)
        {
            string result = "";
            foreach (MethodInfo methodInfo in _methods)
            {
                result += Utilities.ArrayParse(fullName ? methodInfo.ReflectedType + "." + methodInfo.Name : methodInfo.Name) + "=" + Utilities.ArrayParse(methodInfo.ReturnParameter.ParameterType.ToString()) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get an array of inline method loaded parameters (arguments).
        /// </summary>
        /// <param name="method">The method name.</param>
        /// <returns>Array of parameter names and type.</returns>
        public static Primitive GetMethodParameters(Primitive method)
        {
            string result = "";
            foreach (MethodInfo methodInfo in _methods)
            {
                if (methodInfo.Name == method || methodInfo.ReflectedType + "." + methodInfo.Name == method)
                {
                    foreach (ParameterInfo parameterInfo in methodInfo.GetParameters())
                    {
                        result += Utilities.ArrayParse(parameterInfo.Name) + "=" + Utilities.ArrayParse(parameterInfo.ParameterType.ToString()) + ";";
                    }
                    break;
                }
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get an array of inline properties loaded.
        /// </summary>
        /// <returns>Array of property names and type.</returns>
        public static Primitive GetProperties()
        {
            string result = "";
            foreach (PropertyInfo propertyInfo in _properties)
            {
                result += Utilities.ArrayParse(propertyInfo.Name) + "=" + Utilities.ArrayParse(propertyInfo.PropertyType.ToString()) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get an array of inline events loaded.
        /// </summary>
        /// <returns>Array of event names and handler type.</returns>
        public static Primitive GetEvents()
        {
            string result = "";
            foreach (EventInfo eventInfo in _events)
            {
                result += Utilities.ArrayParse(eventInfo.Name) + "=" + Utilities.ArrayParse(eventInfo.EventHandlerType.ToString()) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get an array of inline references added.
        /// These are the referenced added, they may or may not be used.
        /// </summary>
        /// <param name="fullName">Get the fully qualified name (with version, culture and PublicKeyToken) "True" or the basic name "False".</param>
        /// <returns>Array of reference names and dll locations.</returns>
        public static Primitive GetReferences(Primitive fullName)
        {
            string result = "";
            foreach (Assembly assembly in _references)
            {
                result += Utilities.ArrayParse(fullName ? assembly.FullName : assembly.GetName().Name) + "=" + Utilities.ArrayParse(assembly.Location) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get an array of inline assemblies used.
        /// These are the referenced assemblies that are actually used.
        /// </summary>
        /// <param name="fullName">Get the fully qualified name (with version, culture and PublicKeyToken) "True" or the basic name "False".</param>
        /// <returns>Array of assembly names and dll locations.</returns>
        public static Primitive GetAssemblies(Primitive fullName)
        {
            string result = "";
            List<Assembly> assemblies = new List<Assembly>();
            foreach (Assembly assembly in _assemblies)
            {
                assemblies.Add(assembly);
                foreach (AssemblyName assemblyName in assembly.GetReferencedAssemblies())
                {
                    try
                    {
                        assemblies.Add(Assembly.ReflectionOnlyLoad(assemblyName.FullName));
                    }
                    catch
                    {
                    }
                }
            }

            assemblies.Sort(new AssemblyComparer());
            foreach (Assembly assembly in assemblies)
            {
                result += Utilities.ArrayParse(fullName ? assembly.FullName : assembly.GetName().Name) + "=" + Utilities.ArrayParse(assembly.Location) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get an array of inline class types loaded.
        /// </summary>
        /// <returns>Array of class types and namespace.</returns>
        public static Primitive GetTypes()
        {
            string result = "";
            foreach (Type type in _types)
            {
                result += Utilities.ArrayParse(type.Name) + "=" + Utilities.ArrayParse(null == type.Namespace ? "" : type.Namespace) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }
    }
}
