using System;
using System.Windows.Forms;
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
using SBArray = Microsoft.SmallBasic.Library.Array;

namespace LitDev
{
    public partial class FormDebug : Form
    {
        private enum runState
        {
            running = 1,
            paused = 2,
        }
        private static runState state = runState.running;
        private static TreeNode nodeSelected = null;
        public static StackTrace stackTrace = null;
        public static bool onBreak = false;
        public static string label = "";
        private static bool showArray = false;

        public static string conditionName = "";
        public static Primitive conditionValue = "";
        public static bool conditionBPOnly = false;
        public static int conditionType = 0;

        public FormDebug()
        {
            InitializeComponent();
            setIcon();
            checkedListBoxLabels.Items.Clear();
            for (int i = 0; i < LDDebug.breakText.Count; i++)
            {
                checkedListBoxLabels.Items.Add(LDDebug.breakText[i], !LDDebug.ignoreBreaks[i]);
            }
            checkBoxBPOnly.Checked = false;
            comboBoxCondition.SelectedIndex = 0;
        }

        private void setIcon()
        {
            Bitmap selectedBMP = global::LitDev.Properties.Resources.bug;
            IntPtr iconHandle = selectedBMP.GetHicon();
            this.Icon = Icon.FromHandle(iconHandle);
        }

        private void onPause()
        {
            toolStripButtonPause.Checked = true;
            toolStripButtonRun.Checked = false;
            if (state == runState.running)
            {
                state = runState.paused;
                Thread _ThreadPause = new Thread(new ThreadStart(Pause));
                _ThreadPause.Start();

                UpdateProperties();
                if (LDDebug.breakLabels.Contains(label))
                {
                    string labelText = LDDebug.breakText[LDDebug.breakLabels.IndexOf(label)];
                    if (checkedListBoxLabels.Items.Contains(labelText)) checkedListBoxLabels.SelectedIndex = checkedListBoxLabels.Items.IndexOf(labelText);
                    //toolStripStatusLabelBP.Text = labelText.Length > 30 ? labelText.Substring(0, System.Math.Min(labelText.Length, 30)) + "..." : labelText;
                    toolStripStatusLabelBP.Text = labelText;
                }
                else
                {
                    //toolStripStatusLabelBP.Text = label.Length > 30 ? label.Substring(0, System.Math.Min(label.Length, 30)) + "..." : label;
                    toolStripStatusLabelBP.Text = label;
                }
                while (toolStripStatusLabelBP.Text.Contains("  ")) toolStripStatusLabelBP.Text = toolStripStatusLabelBP.Text.Replace("  ", " ");
            }
        }

        private void onResume()
        {
            updateBreakpoints();
            toolStripButtonPause.Checked = false;
            toolStripButtonRun.Checked = true;
            if (state == runState.paused)
            {
                nodeSelected = null;
                textBoxValue.Text = "";
                state = runState.running;
            }
        }

        public void Pause()
        {
            Type SmallBasicApplicationType = typeof(SmallBasicApplication);
            try
            {
                InvokeHelper invokeHelper = delegate
                {
                    try
                    {
                        //TextWindow.WriteLine("Pause App " + LDDebug.applicationThread.ThreadState.ToString());
                        if (LDDebug.applicationThread.ThreadState != System.Threading.ThreadState.Running) LDDebug.applicationThread.Suspend();
                        //if (LDDebug.currentThread != LDDebug.applicationThread) LDDebug.currentThread.Suspend();
                        while (state == runState.paused) Thread.Sleep(100);
                        LDDebug.applicationThread.Resume();
                        //if (LDDebug.currentThread != LDDebug.applicationThread) LDDebug.currentThread.Resume();
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                };
                MethodInfo method = SmallBasicApplicationType.GetMethod("Invoke", BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic);
                method.Invoke(null, new object[] { invokeHelper });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void UpdateProperties()
        {
            try
            {
                //TextWindow.WriteLine("Update App " + LDDebug.applicationThread.ThreadState.ToString());
                //if (LDDebug.applicationThread.ThreadState != System.Threading.ThreadState.Running) return;
                if (LDDebug.applicationThread.ThreadState != System.Threading.ThreadState.Running) LDDebug.applicationThread.Suspend();
                stackTrace = new StackTrace(LDDebug.applicationThread, false);

                treeView1.Nodes.Clear();
                treeView1.SelectedNode = null;
                treeView1.Nodes.Add("Variables");
                treeView1.Nodes.Add("Arrays");
                treeView1.Nodes.Add("Call Stack");
                AddVariables(stackTrace);
                AddStack(stackTrace);
                for (int i = 0; i < 3; i++)
                {
                    treeView1.Nodes[i].Expand();
                    treeView1.Nodes[i].ForeColor = Color.Red;
                }
                if (showArray) treeView1.Nodes[1].ExpandAll();
                //LDDebug.applicationThread.Resume();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void AddVariables(StackTrace stackTrace)
        {
            StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
            MethodBase method = frame.GetMethod();
            Type type = method.DeclaringType;
            FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            List<varSort> fieldsSort = new List<varSort>();
            for (int i = 0; i < fields.Length; i++)
            {
                fieldsSort.Add(new varSort(i, fields[i].Name));
            }
            fieldsSort.Sort();

            // 3D array is enough (could make it infinite but messy the way the tree is defined)
            foreach (varSort variable in fieldsSort)
            {
                int i = variable.I;
                Primitive var = (Primitive)fields[i].GetValue(null);

                if (SBArray.IsArray(var))
                {
                    treeView1.Nodes[1].Nodes.Add(variable.Name).Tag = new vars(i, new string[] { });
                    Primitive Indices = SBArray.GetAllIndices(var);
                    for (int j = 1; j <= SBArray.GetItemCount(Indices); j++)
                    {
                        Primitive var1 = var[Indices[j]];
                        if (SBArray.IsArray(var1))
                        {
                            treeView1.Nodes[1].Nodes[treeView1.Nodes[1].Nodes.Count - 1].Nodes.Add(Indices[j]).Tag = new vars(i, new string[]{Indices[j]});
                            Primitive Indices1 = SBArray.GetAllIndices(var1);
                            for (int k = 1; k <= SBArray.GetItemCount(Indices1); k++)
                            {
                                Primitive var2 = var1[Indices1[k]];
                                if (SBArray.IsArray(var2))
                                {
                                    treeView1.Nodes[1].Nodes[treeView1.Nodes[1].Nodes.Count - 1].Nodes[j - 1].Nodes.Add(Indices1[k]).Tag = new vars(i, new string[]{Indices[j], Indices1[k]});
                                    Primitive Indices2 = SBArray.GetAllIndices(var2);
                                    for (int l = 1; l <= SBArray.GetItemCount(Indices2); l++)
                                    {
                                        Primitive var3 = var2[Indices2[l]];
                                        treeView1.Nodes[1].Nodes[treeView1.Nodes[1].Nodes.Count - 1].Nodes[j - 1].Nodes[k - 1].Nodes.Add(Indices2[l] + " : " + var3).Tag = new vars(i, new string[]{Indices[j], Indices1[k], Indices2[l]});
                                    }
                                }
                                else
                                {
                                    treeView1.Nodes[1].Nodes[treeView1.Nodes[1].Nodes.Count - 1].Nodes[j - 1].Nodes.Add(Indices1[k] + " : " + var2).Tag = new vars(i, new string[]{Indices[j], Indices1[k]});
                                }
                            }
                        }
                        else
                        {
                            treeView1.Nodes[1].Nodes[treeView1.Nodes[1].Nodes.Count - 1].Nodes.Add(Indices[j] + " : " + var1).Tag = new vars(i, new string[]{Indices[j]});
                        }
                    }
                }
                else
                {
                    treeView1.Nodes[0].Nodes.Add(variable.Name + " : " + var).Tag = new vars(i, new string[] { });
                }
            }
        }

        private void AddStack(StackTrace stackTrace)
        {
            for (int i = 0; i < stackTrace.FrameCount; i++)
            {
                StackFrame frame = stackTrace.GetFrame(i);
                MethodBase method = frame.GetMethod();
                if (method.DeclaringType.Name == "_SmallBasicProgram") treeView1.Nodes[2].Nodes.Add(method.Name);
            }
        }

        private void FormDebug_FormClosed(object sender, FormClosedEventArgs e)
        {
            onExit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (onBreak)
            {
                onBreak = false;
                onPause();
            }
        }

        private void onExit()
        {
            state = runState.running;
            LDDebug.running = false;
        }

        private void checkedListBoxLabels_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            LDDebug.ignoreBreaks[e.Index] = e.CurrentValue == CheckState.Checked;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (state == runState.paused && null != e.Node.Tag)
            {
                nodeSelected = e.Node;
                textBoxValue.Text = ((vars)nodeSelected.Tag).getValue();
            }
        }

        private void toolStripButtonPause_Click(object sender, EventArgs e)
        {
            LDDebug.stepOut = 0;
            checkedListBoxLabels.ClearSelected();
            label = "User Break";
            onPause();
        }

        private void toolStripButtonRun_Click(object sender, EventArgs e)
        {
            LDDebug.stepOut = 0;
            onResume();
        }

        private void toolStripButtonQuit_Click(object sender, EventArgs e)
        {
            onExit();
            Close();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            onExit();
            Close();
            Program.End();
        }

        private void toolStripButtonIgnoreBP_Click(object sender, EventArgs e)
        {
            LDDebug.stepOut = 0;
            LDDebug.ignoreAllBreaks = ((ToolStripButton)sender).Checked;
            if (LDDebug.ignoreAllBreaks)
            {
                LDDebug.includeAllBreaks = false;
                toolStripButtonAllBP.Checked = false;
            }
        }

        private void toolStripButtonAllBP_Click(object sender, EventArgs e)
        {
            LDDebug.stepOut = 0;
            LDDebug.includeAllBreaks = ((ToolStripButton)sender).Checked;
            if (LDDebug.includeAllBreaks)
            {
                LDDebug.ignoreAllBreaks = false;
                toolStripButtonIgnoreBP.Checked = false;
            }
        }

        private void toolStripButtonStepOut_Click(object sender, EventArgs e)
        {
            LDDebug.stepOut = 1;
            onResume();
        }

        private void buttonChangeValue_Click(object sender, EventArgs e)
        {
            if (state == runState.paused && null != nodeSelected && null != stackTrace)
            {
                ((vars)nodeSelected.Tag).setValue(textBoxValue.Text);
                UpdateProperties();
            }
        }

        private void FormDebug_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                toolStripButtonHelp_Click(toolStripButtonHelp, null);
            }
            else if (e.KeyCode == Keys.F4)
            {
                toolStripButtonPause_Click(toolStripButtonPause, null);
            }
            else if (e.KeyCode == Keys.F5)
            {
                toolStripButtonRun_Click(toolStripButtonRun, null);
            }
            else if (e.KeyCode == Keys.F6)
            {
                toolStripButtonStepOut_Click(toolStripButtonStepOut, null);
            }
            else if (e.KeyCode == Keys.F7)
            {
                toolStripButtonIgnoreBP.Checked = !toolStripButtonIgnoreBP.Checked;
                toolStripButtonIgnoreBP_Click(toolStripButtonIgnoreBP, null);
            }
            else if (e.KeyCode == Keys.F8)
            {
                toolStripButtonAllBP.Checked = !toolStripButtonAllBP.Checked;
                toolStripButtonAllBP_Click(toolStripButtonAllBP, null);
            }
            else if (e.KeyCode == Keys.F9)
            {
                toolStripButtonArray.Checked = !toolStripButtonArray.Checked;
                toolStripButtonArray_Click(toolStripButtonArray, null);
            }
            else if (e.KeyCode == Keys.F10)
            {
                toolStripButtonTransparency.Checked = !toolStripButtonTransparency.Checked;
                toolStripButtonTransparency_Click(toolStripButtonTransparency, null);
            }
            else if (e.KeyCode == Keys.F11)
            {
                toolStripButtonQuit_Click(toolStripButtonQuit, null);
            }
            else if (e.KeyCode == Keys.F12)
            {
                toolStripButtonExit_Click(toolStripButtonExit, null);
            }
        }

        private void FormDebug_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void toolStripButtonTransparency_Click(object sender, EventArgs e)
        {
            this.Opacity = toolStripButtonTransparency.Checked ? 0.6 : 1.0;
        }

        private void toolStripButtonArray_Click(object sender, EventArgs e)
        {
            showArray = toolStripButtonArray.Checked;
            if (state == runState.paused && null != stackTrace) UpdateProperties();
        }

        private void toolStripButtonHelp_Click(object sender, EventArgs e)
        {
            FormDebugHelp help = new FormDebugHelp();
            help.TopMost = true;
            help.ShowDialog(this);
        }

        private void updateBreakpoints()
        {
            conditionName = textBoxConditionName.Text;
            conditionValue = textBoxConditionValue.Text;
            conditionBPOnly = checkBoxBPOnly.Checked && conditionName != "" && conditionValue != "";
            conditionType = comboBoxCondition.SelectedIndex;
        }

        private void UpdateBreakpoints(object sender, EventArgs e)
        {
            updateBreakpoints();
        }
    }

    class varSort : IComparable
    {
        private int i;
        private string name;

        public varSort(int _i, string _name)
        {
            i = _i;
            name = _name;
        }

        public int I { get { return i; } set { i = value; } }
        public string Name { get { return name; } set { name = value; } }

        int IComparable.CompareTo(object obj)
        {
            return name.CompareTo(((varSort)obj).name);
        }
    }

    class vars
    {
        private int i;
        private List<string> indices;

        public vars(int _i, string[] _indices)
        {
            i = _i;
            indices = new List<string>();
            for (int j = 0; j < _indices.Length; j++) indices.Add(_indices[j]);
        }

        public Primitive getValue()
        {
            if (null != FormDebug.stackTrace)
            {
                StackFrame frame = FormDebug.stackTrace.GetFrame(FormDebug.stackTrace.FrameCount - 1);
                MethodBase method = frame.GetMethod();
                Type type = method.DeclaringType;
                FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
                Primitive var = (Primitive)fields[i].GetValue(null);
                if (indices.Count == 0) return var;
                else if (indices.Count == 1) return var[indices[0]];
                else if (indices.Count == 2) return var[indices[0]][indices[1]];
                else if (indices.Count == 3) return var[indices[0]][indices[1]][indices[2]];
            }
            return "";
        }

        public void setValue(Primitive value)
        {
            if (null != FormDebug.stackTrace)
            {
                StackFrame frame = FormDebug.stackTrace.GetFrame(FormDebug.stackTrace.FrameCount - 1);
                MethodBase method = frame.GetMethod();
                Type type = method.DeclaringType;
                FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
                Primitive var = (Primitive)fields[i].GetValue(null);
                if (indices.Count == 0) var = value;
                if (indices.Count == 1) var[indices[0]] = value;
                if (indices.Count == 2)
                {
                    Primitive var1 = var[indices[0]];
                    var1[indices[1]] = value;
                    var[indices[0]] = var1;
                }
                if (indices.Count == 3)
                {
                    Primitive var1 = var[indices[0]];
                    Primitive var2 = var[indices[1]];
                    var2[indices[2]] = value;
                    var1[indices[1]] = var2;
                    var[indices[0]] = var1;
                }
                fields[i].SetValue(null, var);
            }
        }
    }
}
