using System;
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Reflection;
using System.Runtime.InteropServices;

/// <summary>
/// Example for use with LDInline - deliberately not the simplest possible
/// Designed to show and test all the main functionality
/// Note that some type conversions work (string,int,float,double,bool) - not all parameters have to be Primitive
/// </summary>
public class TestOperationsCS
{    
    /// <summary>
    /// Get a file path using File Open dialog
    /// Asynchronous thread to display a Forms dialog
    /// </summary>
    /// <param name="folder">initial folder</param>
    /// <param name="extension">extension</param>
    /// <returns>file seleceted</returns>
    public static string GetFile(string folder, string extension)
    {
        string result = "";
        ThreadStart start = delegate
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "File Type (*." + extension + ") |*." + extension;
            dlg.InitialDirectory = folder;
            if (dlg.ShowDialog() == DialogResult.OK) result = dlg.FileName;
        };
        Thread thread = new Thread(start);
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();
        return result;
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool Beep(uint dwFreq, uint dwDuration);
    /// <summary>
    /// A simple test beep
    /// Method with no return or arguments - using native pInvoke
    /// </summary>
    public static void TestBeep()
    {
        Beep(256, 1000);
    }

    /// <summary>
    /// Get the current date and time
    /// </summary>
    public static DateTime Date
    {
        get { return DateTime.Now; }
    }
    private static double store = 0;
    /// <summary>
    /// Get or set a double store
    /// </summary>
    public static double Store
    {
        get { return store; }
        set { store = value; }
    }

    private static int delta = 0;
    private static SmallBasicCallback _MouseWheelDelegate = null;
    private static void _MouseWheelEvent(Object sender, MouseWheelEventArgs e)
    {
        delta = e.Delta / 120;
        if (null != _MouseWheelDelegate) _MouseWheelDelegate();
    }
    /// <summary>
    /// MouseWheel CallBack
    /// An event callback - including reflection to SmallBasicLibrary window
    /// </summary>
    public static event SmallBasicCallback MouseWheel
    {
        add
        {
            _MouseWheelDelegate = value;
            try
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Window _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                InvokeHelper invokeHelper = delegate
                {
                    _window.MouseWheel += new MouseWheelEventHandler(_MouseWheelEvent);
                };
                MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
                method.Invoke(null, new object[]{invokeHelper});
            }
            catch (Exception ex)
            {
            }
        }
        remove
        {
            _MouseWheelDelegate = null;
        }
    }
    /// <summary>
    /// MouseWheel Delta
    /// </summary>
    public static int Delta
    {
        get { return delta; }
    }
}

/// <summary>
/// A test creating an extension
/// The resulting dll and xml can be used in the lib folder as an extension
/// 
/// All methods are public static
/// All parameters are Primitive
/// Class attribute is SmallBasicType
/// </summary>
[SmallBasicType]
public static class TestExtensionCS
{
    /// <summary>
    /// Test subtractor
    /// </summary>
    /// <param name="x">First value</param>
    /// <param name="y">Second value to subtract from the first</param>
    /// <returns>The result</returns>
    public static Primitive Subtract(Primitive x, Primitive y)
    {
        return x - y;
    }
}
