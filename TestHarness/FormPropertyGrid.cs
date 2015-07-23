using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Collections;
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using SBArray = Microsoft.SmallBasic.Library.Array;

namespace LitDev
{
    public partial class FormPropertyGrid : Form
    {
        private static Type GraphicsWindowType = typeof(GraphicsWindow);
        private static MethodInfo mInvoke = GraphicsWindowType.GetMethod("Invoke", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
        private static MethodInfo mInvokeWithReturn = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
        private static List<Property> Properties = new List<Property>();
        private static List<Type> typeList = new List<Type>();

        public FormPropertyGrid()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.PropertyGrid PropertyGrid
        {
            get { return propertyGrid; }
            set { propertyGrid = value; }
        }

        private static void GetTypes()
        {
            typeList.Clear();
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type type in assembly.GetTypes())
                {
                    if (Attribute.IsDefined(type, typeof(SmallBasicTypeAttribute))) typeList.Add(type);
                }
            }

            Assembly entryAssembly = Assembly.GetEntryAssembly();
            Type mainModule = entryAssembly.EntryPoint.DeclaringType;
            foreach (FieldInfo info in mainModule.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
            {
                TextWindow.WriteLine(info.Name);
            }
            foreach (PropertyInfo info in mainModule.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
            {
                TextWindow.WriteLine(info.Name);
            }
            foreach (MethodInfo info in mainModule.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
            {
                TextWindow.WriteLine(info.Name);
                if (info.Name != "Main")
                {
                    //Delegate funcCall = Delegate.CreateDelegate(typeof(SmallBasicCallback), info);
                    mainModule.GetMethod("Test", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { (Primitive)"Hi There" });
                    //info.Invoke(null,new object[] {(Primitive)"Hi There"});
                }
            }
        }

        private static Type GetType(string typeName)
        {
            if (typeList.Count == 0) GetTypes();
            foreach (Type type in typeList)
            {
                if (type.Name == typeName) return type;
            }
            return null;
        }

        private void getProperties(Object obj, Property parent)
        {
            foreach (PropertyInfo propertyInfo in obj.GetType().GetProperties())
            {
                Object value = propertyInfo.GetValue(obj, null);
                if (null == value) continue;
                if (propertyInfo.CanWrite)
                {
                    Properties.Add(new Property(parent.key + "." + propertyInfo.Name, value.ToString(), obj, parent));
                }
                else if (value is IEnumerable && !Utilities.isBulitin(value))
                {
                    Properties.Add(new Property(parent.key + "." + propertyInfo.Name, value.ToString(), obj, parent));
                    parent = Properties.Last();
                    foreach (Object objChild in (value as IEnumerable))
                    {
                        Properties.Add(new Property(parent.key + "." + objChild.GetType().GetProperty("Name").GetValue(objChild, null).ToString(), "", objChild, parent));
                        getProperties(objChild, Properties.Last());
                    }
                }
            }
        }

        public void Display(Primitive rootObject)
        {
            if (typeList.Count == 0) GetTypes();
            try
            {
                foreach (Type type in typeList)
                {
                    //if (type.Name == "GraphicsWindow")
                    {
                        TextWindow.WriteLine(type.Namespace + " : " + type.Name);
                        BindingFlags bf = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public;
                        //foreach (MemberInfo info in type.GetMembers(bf))
                        //{
                        //    TextWindow.WriteLine("    Member : " + info.Name);
                        //}
                        foreach (MethodInfo info in type.GetMethods(bf))
                        {
                            TextWindow.WriteLine("    Method : " + info.Name);
                        }
                        foreach (PropertyInfo info in type.GetProperties(bf))
                        {
                            TextWindow.WriteLine("    Property : " + info.Name);
                        }
                        foreach (FieldInfo info in type.GetFields(bf))
                        {
                            TextWindow.WriteLine("    Field : " + info.Name);
                        }
                        foreach (EventInfo info in type.GetEvents(bf))
                        {
                            TextWindow.WriteLine("    Event : " + info.Name);
                        }
                    }
                }
                Object obj = (Object)GetType("GraphicsWindow").GetField(rootObject, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);

                if (null == obj) return;

                InvokeHelper invokeHelper = delegate
                {
                    PropertyGrid.SelectedObject = obj;
                    ShowDialog();
                };

                mInvoke.Invoke(null, new object[] { invokeHelper });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        public Primitive GetProperties(Primitive rootObject)
        {
            string properties = "";
            try
            {
                Object obj = (Object)GetType("GraphicsWindow").GetField(rootObject, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                if (null == obj) return "";

                InvokeHelper invokeHelper = delegate
                {
                    Properties.Add(new Property(rootObject, "", obj, null));
                    getProperties(obj, Properties.Last());
                };

                mInvoke.Invoke(null, new object[] { invokeHelper });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }

            int i = 1;
            foreach (Property property in Properties)
            {
                properties += (i++).ToString() + "=" + Utilities.ArrayParse(property.key) + " , " + Utilities.ArrayParse(property.value) + ";";
            }

            return Utilities.CreateArrayMap(properties);
        }

        public void SetProperty(Primitive objectPath, Primitive value)
        {
            string[] objectList = objectPath.ToString().Split(new char[] { '.' });
            string objectValue = value;

            try
            {
                InvokeHelper invokeHelper = delegate
                {
                    try
                    {
                        Object obj = null;
                        foreach (string key in objectList)
                        {
                            if (key == objectList.First())
                            {
                                obj = (Object)GetType("GraphicsWindow").GetField(key, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                                continue;
                            }
                            if (null == obj || key == objectList.Last()) break;
                            if (obj is IEnumerable && !Utilities.isBulitin(obj))
                            {
                                bool bFound = false;
                                foreach (Object objChild in (obj as IEnumerable))
                                {
                                    if (objChild.GetType().GetProperty("Name").GetValue(objChild, null).ToString() == key)
                                    {
                                        obj = objChild;
                                        bFound = true;
                                        break;
                                    }
                                }
                                if (!bFound) return;
                            }
                            else
                            {
                                obj = obj.GetType().GetProperty(key).GetValue(obj, null);
                            }
                        }

                        if (null == obj) return;

                        Object propObject = obj.GetType().GetProperty(objectList.Last()).GetValue(obj, null);
                        Type propType = propObject.GetType();
                        TypeConverter typeConverter = TypeDescriptor.GetConverter(propType);
                        Object propValue = typeConverter.ConvertFromString(objectValue);
                        obj.GetType().GetProperty(objectList.Last()).SetValue(obj, propValue, null);
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                };

                mInvoke.Invoke(null, new object[] { invokeHelper });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        public string GetProperty(Primitive objectPath)
        {
            string[] objectList = objectPath.ToString().Split(new char[] { '.' });

            try
            {
                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Object obj = null;
                        foreach (string key in objectList)
                        {
                            if (key == objectList.First())
                            {
                                obj = (Object)GetType("GraphicsWindow").GetField(key, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                                continue;
                            }
                            if (null == obj || key == objectList.Last()) break;
                            if (obj is IEnumerable && !Utilities.isBulitin(obj))
                            {
                                bool bFound = false;
                                foreach (Object objChild in (obj as IEnumerable))
                                {
                                    if (objChild.GetType().GetProperty("Name").GetValue(objChild, null).ToString() == key)
                                    {
                                        obj = objChild;
                                        bFound = true;
                                        break;
                                    }
                                }
                                if (!bFound) return "";
                            }
                            else
                            {
                                obj = obj.GetType().GetProperty(key).GetValue(obj, null);
                            }
                        }

                        if (null == obj) return "";

                        Object propObject = obj.GetType().GetProperty(objectList.Last()).GetValue(obj, null);
                        return propObject.ToString();
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return "";
                });

                return mInvokeWithReturn.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }
    }

    class Property
    {
        public string key;
        public string value;
        public Object obj;
        public Property parent;

        public Property(string _key, string _value, Object _obj, Property _parent)
        {
            key = _key;
            value = _value;
            obj = _obj;
            parent = _parent;
        }
    }
}
