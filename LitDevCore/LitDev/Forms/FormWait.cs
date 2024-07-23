using System;
using System.Windows.Forms;

namespace LitDev
{
    public partial class FormWait : Form
    {
        public FormWait()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!LDDialogs._Waiting) Close();
        }
    }
}
