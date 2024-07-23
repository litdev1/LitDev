using System.IO;
using System.Resources;
using System.Reflection;
using System.Windows.Forms;

namespace LitDev
{
    public partial class FormDebugHelp : Form
    {
        public FormDebugHelp()
        {
            InitializeComponent();

            richTextBox1.Rtf = global::LitDev.Properties.Resources.DebugHelp;
        }
    }
}
