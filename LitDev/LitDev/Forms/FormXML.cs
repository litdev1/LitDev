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

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace LitDev
{
    public partial class FormXML : Form
    {
        private string xmlStore;
        private XmlDoc xmlDocStore = null;
        private List<NodeStore> nodeHistories = new List<NodeStore>();
        private List<NodeStore> nodeStores = new List<NodeStore>();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int WM_SETREDRAW = 0x0b;

        private void BeginUpdate()
        {
            SendMessage(richTextBox1.Handle, WM_SETREDRAW, (IntPtr)0, IntPtr.Zero);
        }
        private void EndUpdate()
        {
            SendMessage(richTextBox1.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
            richTextBox1.Invalidate();
        }

        public FormXML()
        {
            InitializeComponent();

            richTextBox1.Font = new Font("Consolas", 12);
        }

        public void Update(XmlDoc xmlDoc)
        {
            if (null == xmlDoc || !Visible) return;
            BeginUpdate();

            string xml = xmlDoc.doc.OuterXml.Replace("><", ">\n<")+"\n";
            if (xmlStore != xml || xmlDoc != xmlDocStore)
            {
                xmlStore = xml;
                xmlDocStore = xmlDoc;
                richTextBox1.Text = xml;
                richTextBox1.SelectionStart = 0;
                richTextBox1.SelectionLength = richTextBox1.TextLength;
                richTextBox1.SelectionColor = Color.Black;
                nodeStores.Clear();
                nodeHistories.Clear();
                ParseXML(xmlDoc.doc, 0);
                Text = "LDxml";
            }

            if (!nodeHistories.Any(item => item.Node == xmlDoc.node))
            {
                foreach (NodeStore nodeHistory in nodeHistories)
                {
                    richTextBox1.SelectionStart = nodeHistory.Start;
                    richTextBox1.SelectionLength = nodeHistory.Length;
                    richTextBox1.SelectionColor = Color.Black;
                }
                nodeHistories.Clear();
                Highlight(xmlDoc.node, Color.Red);
            }

            EndUpdate();
        }

        private int ParseXML(XmlNode node, int start)
        {
            Text = "Parsing ... " + (100.0 * start / richTextBox1.TextLength).ToString("F2") + "%";
            int length = 0;
            if (node.NodeType == XmlNodeType.Text)
            {
                int tryStart = richTextBox1.Find(node.InnerText.Trim(), 0, RichTextBoxFinds.NoHighlight);
                if (tryStart >= 0)
                {
                    start = tryStart;
                    length = node.InnerText.Trim().Length;
                    nodeStores.Add(new NodeStore(node, start, length));
                }
            }
            else
            {
                length = node.OuterXml.IndexOf('>')+1;
                if (length > 0)
                {
                    int tryStart = richTextBox1.Find(node.OuterXml.Substring(0, length), start, RichTextBoxFinds.NoHighlight);
                    if (tryStart >= 0)
                    {
                        start = tryStart;
                        nodeStores.Add(new NodeStore(node, start, length));
                    }
                }
            }
            foreach (XmlNode child in node.ChildNodes)
            {
                start = ParseXML(child, start);
            }
            return start;
        }

        private void Highlight(XmlNode node, Color color)
        {
            try
            {
                NodeStore nodeStore = nodeStores.First(item => item.Node == node);
                richTextBox1.SelectionStart = nodeStore.Start;
                richTextBox1.SelectionLength = nodeStore.Length;
                richTextBox1.SelectionColor = color;
                richTextBox1.ScrollToCaret();
                nodeHistories.Add(nodeStore);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
    }

    class NodeStore
    {
        public XmlNode Node;
        public int Start;
        public int Length;

        public NodeStore(XmlNode node, int start, int length)
        {
            Node = node;
            Start = start;
            Length = length;
        }
    }
}
