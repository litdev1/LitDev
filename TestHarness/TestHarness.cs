using Microsoft.SmallBasic.Library;
using System;
using System.Windows.Forms;

namespace TestHarness
{
    static class TestHarness
    {
        static Primitive test = "Hi";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTestHarness());
        }

        static void Test(Primitive txt)
        {
            TextWindow.WriteLine(txt);
        }
    }
}
