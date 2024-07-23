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
    public partial class FormCalendar : Form
    {
        public DateTime result;
        public DateTime lastClick;

        public FormCalendar(DateTime start)
        {
            InitializeComponent();

            Application.EnableVisualStyles();
            monthCalendar1.SelectionStart = start;
            result = monthCalendar1.SelectionStart;
            lastClick = DateTime.FromOADate(0);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            result = e.Start;
            if ((DateTime.Now - lastClick) < TimeSpan.FromMilliseconds(500)) Close();
            lastClick = DateTime.Now;
        }

        private void monthCalendar1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Close();
        }
    }
}
