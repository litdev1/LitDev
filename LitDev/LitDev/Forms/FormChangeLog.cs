using Microsoft.SmallBasic.Library;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LitDev
{
    public partial class FormChangeLog : Form
    {
        public FormChangeLog()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            treeView1.Nodes[0].ExpandAll();
            treeView1.StateImageList = new System.Windows.Forms.ImageList();
            treeView1.StateImageList.Images.Add(Properties.Resources.SBIcon);
            treeView1.StateImageList.Images.Add(Properties.Resources.zoom);
            treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(_ClickEvent);
            foreach (TreeNode node1 in treeView1.Nodes)
            {
                node1.StateImageIndex = 0;
                foreach (TreeNode node2 in node1.Nodes)
                {
                    node2.StateImageIndex = 1;
                    node2.ExpandAll();
                    foreach (TreeNode node3 in node2.Nodes)
                    {
                        if (node3.Text.StartsWith("http"))
                        {
                            node3.ForeColor = SystemColors.HotTrack;
                        }
                    }
                }
            }
            treeView1.SelectedNode = treeView1.Nodes[0];
        }

        private void _ClickEvent(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.ForeColor == SystemColors.HotTrack) Process.Start(e.Node.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            setup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
            setup();
        }
    }
}
