﻿//#define SVB 
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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

namespace LitDev
{
    public class XmlDoc
    {
        public XmlDocument doc;
        public XmlNode node;
        public XmlDoc(XmlDocument doc)
        {
            this.doc = doc;
            node = doc.DocumentElement;
        }
    }

    /// <summary>
    /// xml file parsing methods.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDxml
    {
        private static Dictionary<string, XmlDoc> documents = new Dictionary<string, XmlDoc>();
        private static XmlDoc xmlDoc = null;
        private static FormXML formXML = new FormXML();

        private static Primitive toArray(XmlNode node)
        {
            Primitive result = "";
            Primitive combined = "";

            if (null != node.Attributes)
            {
                Primitive temp = "";
                foreach (XmlAttribute attrib in node.Attributes)
                {
                    temp[attrib.Name] = attrib.InnerText;
                }
                combined["Attributes"] = temp;
            }

            if (node.HasChildNodes)
            {
                if (node.ChildNodes.Count == 1 && node.ChildNodes[0].NodeType == XmlNodeType.Text)
                {
                    combined["Data"] = node.ChildNodes[0].InnerText;
                }
                else
                {
                    int i = 1;
                    Primitive temp = "";
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        temp[i++] = toArray(child);
                    }
                    combined["Children"] = temp;
                }
            }
            else
            {
                combined["Data"] = node.InnerText;
            }

            result[node.Name] = combined;
            return result;
        }

        private static void fromArray(Primitive array)
        {
            if (SBArray.GetItemCount(array) != 1)
            {
                throw new Exception("Array node should have 1 array element");
            }

            Primitive indices = SBArray.GetAllIndices(array);
            Primitive content = array[indices[1]];

            XmlElement newNode = xmlDoc.doc.CreateElement(indices[1]);
            if (null == xmlDoc.node)
            {
                xmlDoc.node = xmlDoc.doc.AppendChild(newNode);

                XmlDeclaration xmldecl = xmlDoc.doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDoc.doc.InsertBefore(xmldecl, xmlDoc.doc.DocumentElement);
            }
            else
            {
                xmlDoc.node = xmlDoc.node.AppendChild(newNode);
            }

            Primitive attributes = content["Attributes"];
            indices = SBArray.GetAllIndices(attributes);
            for (int i = 1; i <= SBArray.GetItemCount(indices); i++)
            {
                string index = indices[i];
                XmlAttribute attrib = xmlDoc.doc.CreateAttribute(index);
                attrib.Value = attributes[index];
                xmlDoc.node.Attributes.Append(attrib);
            }

            Primitive data = content["Data"];
            xmlDoc.node.InnerText = data;

            Primitive children = content["Children"];
            for (int i = 1; i <= SBArray.GetItemCount(children); i++)
            {
                fromArray(children[i]);
                xmlDoc.node = xmlDoc.node.ParentNode;
            }
        }

        /// <summary>
        /// Open an existing xml file.  This must be called before any other methods can be used.
        /// </summary>
        /// <param name="fileName">The full path to the xml file to open.
        /// If this is "", then a new empty xml document is created.</param>
        /// <returns>A name for the document or "FAILED".</returns>
        public static Primitive Open(Primitive fileName)
        {
            try
            {
                Type ShapesType = typeof(Shapes);
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
#if SVB
                string docName = method.Invoke(null, new object[] { "XMLDoc", false }).ToString();
#else
                string docName = method.Invoke(null, new object[] { "XMLDoc" }).ToString();
#endif

                if (System.IO.File.Exists(fileName))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(fileName);
                    xmlDoc = new XmlDoc(doc);
                    documents[docName] = xmlDoc;
                    return docName;
                }
                else if (fileName == "")
                {
                    XmlDocument doc = new XmlDocument();
                    doc.AppendChild(doc.CreateElement("root"));
                    xmlDoc = new XmlDoc(doc);
                    documents[docName] = xmlDoc;
                    XmlDeclaration xmldecl = xmlDoc.doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    xmlDoc.doc.InsertBefore(xmldecl, xmlDoc.doc.DocumentElement);
                    return docName;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Switch to another open xml document.  The current node for all documents are preserved.
        /// </summary>
        /// <param name="docName">The name returned by Open method.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive Switch(Primitive docName)
        {
            try
            {
                if (documents.TryGetValue(docName, out xmlDoc)) return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Set the current node to the first document node.
        /// </summary>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive FirstNode()
        {
            try
            {
                if (null == xmlDoc) return "FAILED";
                xmlDoc.node = xmlDoc.doc.DocumentElement;
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Move the current node to the next sibling node if there is one.
        /// </summary>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive NextSibling()
        {
            try
            {
                if (null == xmlDoc || null == xmlDoc.node.NextSibling) return "FAILED";
                xmlDoc.node = xmlDoc.node.NextSibling;
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Move the current node to the previous sibling node if there is one.
        /// </summary>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive PreviousSibling()
        {
            try
            {
                if (null == xmlDoc || null == xmlDoc.node.PreviousSibling) return "FAILED";
                xmlDoc.node = xmlDoc.node.PreviousSibling;
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Move the current node to the first child node if there is one.
        /// </summary>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive FirstChild()
        {
            try
            {
                if (null == xmlDoc || null == xmlDoc.node.FirstChild) return "FAILED";
                xmlDoc.node = xmlDoc.node.FirstChild;
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Move the current node to the last child node if there is one.
        /// </summary>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive LastChild()
        {
            try
            {
                if (null == xmlDoc || null == xmlDoc.node.LastChild) return "FAILED";
                xmlDoc.node = xmlDoc.node.LastChild;
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Move the current node to the parent node if there is one.
        /// </summary>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive Parent()
        {
            try
            {
                if (null == xmlDoc || null == xmlDoc.node.ParentNode) return "FAILED";
                xmlDoc.node = xmlDoc.node.ParentNode;
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Get the type of the current node.
        /// May be one of many types, but commonly "Element" or "Text".
        /// </summary>
        public static Primitive NodeType
        {
            get
            {
                try
                {
                    if (null == xmlDoc) return XmlNodeType.None.ToString();
                    return xmlDoc.node.NodeType.ToString();
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return XmlNodeType.None.ToString();
            }
        }

        /// <summary>
        /// Get the name of the current node or "" on failure.
        /// </summary>
        public static Primitive NodeName
        {
            get
            {
                try
                {
                    if (null == xmlDoc) return "";
                    return xmlDoc.node.Name;
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return "";
            }
        }

        /// <summary>
        /// Get the inner text of the current node and all children or "" on failure.
        /// </summary>
        public static Primitive NodeInnerText
        {
            get
            {
                try
                {
                    if (null == xmlDoc) return "";
                    return xmlDoc.node.InnerText;
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return "";
            }
        }

        /// <summary>
        /// Get the number of children of the current node.
        /// </summary>
        public static Primitive ChildrenCount
        {
            get
            {
                try
                {
                    if (null == xmlDoc) return 0;
                    return xmlDoc.node.ChildNodes.Count;
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return 0;
            }
        }

        /// <summary>
        /// Get the number of attributes of the current node.
        /// </summary>
        public static Primitive AttributesCount
        {
            get
            {
                try
                {
                    if (null == xmlDoc) return 0;
                    return null == xmlDoc.node.Attributes ? 0 : xmlDoc.node.Attributes.Count;
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return 0;
            }
        }

        /// <summary>
        /// Get an array of attribute text values indexed by attribute name or "" on failure.
        /// </summary>
        public static Primitive Attributes
        {
            get
            {
                try
                {
                    if (null == xmlDoc) return "";
                    string result = "";
                    if (null != xmlDoc.node.Attributes)
                    {
                        foreach (XmlAttribute atribute in xmlDoc.node.Attributes)
                        {
                            result += Utilities.ArrayParse(atribute.Name) + "=" + Utilities.ArrayParse(atribute.InnerText) + ";";
                        }
                        return Utilities.CreateArrayMap(result);
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
                return "";
            }
        }

        /// <summary>
        /// Add a new node.
        /// The current node is unchanged, it is not updated to be the new node.
        /// </summary>
        /// <param name="name">The new node element name.</param>
        /// <param name="attributes">An array of attributes (values indexed by attribute name) for the new node or "".</param>
        /// <param name="text">Inner text for the new node or "".</param>
        /// <param name="location">Where the node is inserted.
        /// "Append" - insert at the end of current node's child nodes.
        /// "Prepend" - insert at the start of current node's child nodes.
        /// "Before" - insert before the current node.
        /// "After" - insert after the current node.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive AddNode(Primitive name, Primitive attributes, Primitive text, Primitive location)
        {
            try
            {
                if (null == xmlDoc) return "FAILED";
                XmlElement newNode = xmlDoc.doc.CreateElement(name);
                Primitive indices = SBArray.GetAllIndices(attributes);
                for (int i = 1; i <= SBArray.GetItemCount(indices); i++)
                {
                    string index = indices[i];
                    XmlAttribute attrib = xmlDoc.doc.CreateAttribute(index);
                    attrib.Value = attributes[index];
                    newNode.Attributes.Append(attrib);
                }
                if (text != "") newNode.InnerText = text;
                switch (((string)location).ToLower())
                {
                    case "append":
                        xmlDoc.node.AppendChild(newNode);
                        break;
                    case "prepend":
                        xmlDoc.node.PrependChild(newNode);
                        break;
                    case "after":
                        xmlDoc.node.ParentNode.InsertAfter(newNode, xmlDoc.node);
                        break;
                    case "before":
                        xmlDoc.node.ParentNode.InsertBefore(newNode, xmlDoc.node);
                        break;
                }
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Rename the root element (default is "root").
        /// </summary>
        /// <param name="name">
        /// The name of the root element.
        /// </param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive RenameRoot(Primitive name)
        {
            try
            {
                if (null == xmlDoc) return "FAILED";
                string docName = documents.FirstOrDefault(x => x.Value == xmlDoc).Key;
                string innerXml = xmlDoc.doc.DocumentElement.InnerXml;

                XmlDocument docNew = new XmlDocument();
                XmlElement newRoot = docNew.CreateElement(name);
                newRoot.InnerXml = innerXml;
                docNew.AppendChild(newRoot);
                XmlDeclaration xmldecl = docNew.CreateXmlDeclaration("1.0", "UTF-8", null);
                docNew.InsertBefore(xmldecl, docNew.DocumentElement);
                xmlDoc = new XmlDoc(docNew);
                documents[docName] = xmlDoc;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Remove the current node and all child nodes.
        /// The current node is reset to the previous sibling or parent node if no previous sibling exists.
        /// </summary>
        /// <returns>The new current node "SIBLING", "PARENT" or "FAILED".</returns>
        public static Primitive RemoveNode()
        {
            try
            {
                string result = "SIBLING";
                if (null == xmlDoc) return "FAILED";
                XmlNode parentNode = xmlDoc.node.ParentNode;
                if (null == parentNode) return "FAILED";
                XmlNode newNode = xmlDoc.node.PreviousSibling;
                if (null == newNode)
                {
                    newNode = parentNode;
                    result = "PARENT";
                }
                parentNode.RemoveChild(xmlDoc.node);
                xmlDoc.node = newNode;
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Save the current xml document to a file.
        /// </summary>
        /// <param name="fileName">The full path to the file to write the xml.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive Save(Primitive fileName)
        {
            try
            {
                if (null == xmlDoc) return "FAILED";
                xmlDoc.doc.Save(fileName);
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Convert the current xml document to a Small Basic array.
        /// The structure and depth of the array may be quite complex.
        /// Each node has optional arrays "Attributes", and "Children" or "Data".
        /// If there are are child nodes then they are indexed first by number to deliminate multiple children with the same name.
        /// </summary>
        /// <returns>A Small Basic array or "FAILED".</returns>
        public static Primitive ToArray()
        {
            try
            {
                if (null == xmlDoc) return "FAILED";
                return toArray(xmlDoc.doc.DocumentElement);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// Performs the inverse function of ToArray method, create an xml document from an array definition.
        /// </summary>
        /// <param name="array">A Small Basic array with the correct format.</param>
        /// <returns>A name for the document or "FAILED".</returns>
        public static Primitive FromArray(Primitive array)
        {
            Type ShapesType = typeof(Shapes);
            MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
#if SVB
            string docName = method.Invoke(null, new object[] { "XMLDoc", false }).ToString();
#else
            string docName = method.Invoke(null, new object[] { "XMLDoc" }).ToString();
#endif

            try
            {
                XmlDocument doc = new XmlDocument();
                xmlDoc = new XmlDoc(doc);
                xmlDoc.node = xmlDoc.doc.DocumentElement;
                fromArray(array);
                documents[docName] = xmlDoc;
                return docName;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "FAILED";
        }

        /// <summary>
        /// View XML for dubugging purposes.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void View()
        {
            try
            {
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (formXML.IsDisposed) formXML = new FormXML();
                        formXML.TopMost = true;
                        formXML.Show();
                        formXML.Update(xmlDoc);
                        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                        timer.Enabled = true;
                        timer.Interval = 100;
                        timer.Tick += new EventHandler(timer_Tick);
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                });
                FastThread.Invoke(ret);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static void timer_Tick(object sender, EventArgs e)
        {
            formXML.Update(xmlDoc);
        }
    }
}
