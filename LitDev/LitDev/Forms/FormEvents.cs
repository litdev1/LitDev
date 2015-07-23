using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LitDev
{
    public partial class FormEvents : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AddClipboardFormatListener(IntPtr hwnd);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool RemoveClipboardFormatListener(IntPtr hwnd);
        private const int WM_CLIPBOARDUPDATE = 0x031D;
        private SmallBasicCallback clipBoardChangedDelegate = null;

        public FormEvents()
        {
            InitializeComponent();
        }

        public SmallBasicCallback ClipBoardChangedDelegate
        {
            get { return clipBoardChangedDelegate; }
            set { clipBoardChangedDelegate = value; }
        }

        private void FormEvents_Load(object sender, EventArgs e)
        {
            AddClipboardFormatListener(this.Handle);
        }

        private void FormEvents_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemoveClipboardFormatListener(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_CLIPBOARDUPDATE && null != clipBoardChangedDelegate) clipBoardChangedDelegate();
        }
    }
}
