using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LitDev
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.linkLabel.Text);
        }

        private void buttonChanges_Click(object sender, EventArgs e)
        {
            FormChangeLog changeLog = new FormChangeLog();
            changeLog.TopMost = true;
            changeLog.ShowDialog(this);
        }
    }
}
