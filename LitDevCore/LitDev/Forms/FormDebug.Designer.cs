namespace LitDev
{
    partial class FormDebug
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBoxLabels = new System.Windows.Forms.CheckedListBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStepOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonIgnoreBP = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAllBP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonArray = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTransparency = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonQuit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.buttonChangeValue = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBP = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCondition = new System.Windows.Forms.ComboBox();
            this.checkBoxBPOnly = new System.Windows.Forms.CheckBox();
            this.textBoxConditionValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConditionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(4, 47);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(244, 512);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enable/Disable Breakpoints";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBoxLabels
            // 
            this.checkedListBoxLabels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxLabels.CheckOnClick = true;
            this.checkedListBoxLabels.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxLabels.FormattingEnabled = true;
            this.checkedListBoxLabels.HorizontalScrollbar = true;
            this.checkedListBoxLabels.Location = new System.Drawing.Point(4, 46);
            this.checkedListBoxLabels.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxLabels.Name = "checkedListBoxLabels";
            this.checkedListBoxLabels.Size = new System.Drawing.Size(232, 441);
            this.checkedListBoxLabels.TabIndex = 10;
            this.checkedListBoxLabels.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxLabels_ItemCheck);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValue.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxValue.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue.Location = new System.Drawing.Point(4, 603);
            this.textBoxValue.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(244, 24);
            this.textBoxValue.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Select a variable or array value to change it while paused";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPause,
            this.toolStripButtonRun,
            this.toolStripButtonStepOut,
            this.toolStripSeparator1,
            this.toolStripButtonIgnoreBP,
            this.toolStripButtonAllBP,
            this.toolStripSeparator2,
            this.toolStripButtonArray,
            this.toolStripButtonTransparency,
            this.toolStripSeparator3,
            this.toolStripButtonExit,
            this.toolStripButtonQuit,
            this.toolStripButtonHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(261, 27);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonPause
            // 
            this.toolStripButtonPause.CheckOnClick = true;
            this.toolStripButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPause.Image = global::LitDev.Properties.Resources.pause;
            this.toolStripButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPause.Name = "toolStripButtonPause";
            this.toolStripButtonPause.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonPause.Text = "Pause/Break (F4)";
            this.toolStripButtonPause.Click += new System.EventHandler(this.toolStripButtonPause_Click);
            // 
            // toolStripButtonRun
            // 
            this.toolStripButtonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRun.Image = global::LitDev.Properties.Resources.play;
            this.toolStripButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRun.Name = "toolStripButtonRun";
            this.toolStripButtonRun.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRun.Text = "Run/Continue (F5)";
            this.toolStripButtonRun.Click += new System.EventHandler(this.toolStripButtonRun_Click);
            // 
            // toolStripButtonStepOut
            // 
            this.toolStripButtonStepOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStepOut.Image = global::LitDev.Properties.Resources.stepout;
            this.toolStripButtonStepOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStepOut.Name = "toolStripButtonStepOut";
            this.toolStripButtonStepOut.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonStepOut.Text = "Step Out/Over (F6)";
            this.toolStripButtonStepOut.Click += new System.EventHandler(this.toolStripButtonStepOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonIgnoreBP
            // 
            this.toolStripButtonIgnoreBP.CheckOnClick = true;
            this.toolStripButtonIgnoreBP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIgnoreBP.Image = global::LitDev.Properties.Resources.noBP;
            this.toolStripButtonIgnoreBP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIgnoreBP.Name = "toolStripButtonIgnoreBP";
            this.toolStripButtonIgnoreBP.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonIgnoreBP.Text = "Ignore All Breakpoints (F7)";
            this.toolStripButtonIgnoreBP.Click += new System.EventHandler(this.toolStripButtonIgnoreBP_Click);
            // 
            // toolStripButtonAllBP
            // 
            this.toolStripButtonAllBP.Checked = true;
            this.toolStripButtonAllBP.CheckOnClick = true;
            this.toolStripButtonAllBP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonAllBP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAllBP.Image = global::LitDev.Properties.Resources.allBP;
            this.toolStripButtonAllBP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAllBP.Name = "toolStripButtonAllBP";
            this.toolStripButtonAllBP.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAllBP.Text = "Break at All Breakpoints (F8)";
            this.toolStripButtonAllBP.Click += new System.EventHandler(this.toolStripButtonAllBP_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonArray
            // 
            this.toolStripButtonArray.CheckOnClick = true;
            this.toolStripButtonArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonArray.Image = global::LitDev.Properties.Resources.array;
            this.toolStripButtonArray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonArray.Name = "toolStripButtonArray";
            this.toolStripButtonArray.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonArray.Text = "Show array values (F9)";
            this.toolStripButtonArray.Click += new System.EventHandler(this.toolStripButtonArray_Click);
            // 
            // toolStripButtonTransparency
            // 
            this.toolStripButtonTransparency.CheckOnClick = true;
            this.toolStripButtonTransparency.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTransparency.Image = global::LitDev.Properties.Resources.transparency;
            this.toolStripButtonTransparency.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTransparency.Name = "toolStripButtonTransparency";
            this.toolStripButtonTransparency.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonTransparency.Text = "Transparency (F10)";
            this.toolStripButtonTransparency.Click += new System.EventHandler(this.toolStripButtonTransparency_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::LitDev.Properties.Resources.exit;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonExit.Text = "Exit Program (F11)";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // toolStripButtonQuit
            // 
            this.toolStripButtonQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonQuit.Image = global::LitDev.Properties.Resources.quit;
            this.toolStripButtonQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuit.Name = "toolStripButtonQuit";
            this.toolStripButtonQuit.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonQuit.Text = "Quit Debugging and Continue (F12)";
            this.toolStripButtonQuit.Click += new System.EventHandler(this.toolStripButtonQuit_Click);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHelp.Image = global::LitDev.Properties.Resources.help;
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonHelp.Text = "Help (F1)";
            this.toolStripButtonHelp.Click += new System.EventHandler(this.toolStripButtonHelp_Click);
            // 
            // buttonChangeValue
            // 
            this.buttonChangeValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeValue.Location = new System.Drawing.Point(71, 567);
            this.buttonChangeValue.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangeValue.Name = "buttonChangeValue";
            this.buttonChangeValue.Size = new System.Drawing.Size(119, 28);
            this.buttonChangeValue.TabIndex = 17;
            this.buttonChangeValue.Text = "Change Value";
            this.buttonChangeValue.UseVisualStyleBackColor = true;
            this.buttonChangeValue.Click += new System.EventHandler(this.buttonChangeValue_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelBP});
            this.statusStrip1.Location = new System.Drawing.Point(0, 679);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(532, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(140, 20);
            this.toolStripStatusLabel1.Text = "Current break point:";
            // 
            // toolStripStatusLabelBP
            // 
            this.toolStripStatusLabelBP.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelBP.Name = "toolStripStatusLabelBP";
            this.toolStripStatusLabelBP.Size = new System.Drawing.Size(40, 20);
            this.toolStripStatusLabelBP.Text = "None";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(16, 41);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBoxLabels);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1MinSize = 145;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonChangeValue);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxValue);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2MinSize = 145;
            this.splitContainer1.Size = new System.Drawing.Size(503, 633);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxCondition);
            this.groupBox1.Controls.Add(this.checkBoxBPOnly);
            this.groupBox1.Controls.Add(this.textBoxConditionValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxConditionName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 490);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 137);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conditional Breakpoint";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Condition";
            // 
            // comboBoxCondition
            // 
            this.comboBoxCondition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Items.AddRange(new object[] {
            "=",
            "<",
            ">"});
            this.comboBoxCondition.Location = new System.Drawing.Point(80, 77);
            this.comboBoxCondition.Name = "comboBoxCondition";
            this.comboBoxCondition.Size = new System.Drawing.Size(140, 24);
            this.comboBoxCondition.TabIndex = 16;
            this.comboBoxCondition.SelectedIndexChanged += new System.EventHandler(this.UpdateBreakpoints);
            // 
            // checkBoxBPOnly
            // 
            this.checkBoxBPOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxBPOnly.AutoSize = true;
            this.checkBoxBPOnly.Location = new System.Drawing.Point(6, 110);
            this.checkBoxBPOnly.Name = "checkBoxBPOnly";
            this.checkBoxBPOnly.Size = new System.Drawing.Size(193, 21);
            this.checkBoxBPOnly.TabIndex = 15;
            this.checkBoxBPOnly.Text = "Selected breakpoints only";
            this.checkBoxBPOnly.UseVisualStyleBackColor = true;
            this.checkBoxBPOnly.CheckedChanged += new System.EventHandler(this.UpdateBreakpoints);
            // 
            // textBoxConditionValue
            // 
            this.textBoxConditionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConditionValue.Location = new System.Drawing.Point(80, 49);
            this.textBoxConditionValue.Name = "textBoxConditionValue";
            this.textBoxConditionValue.Size = new System.Drawing.Size(140, 22);
            this.textBoxConditionValue.TabIndex = 12;
            this.textBoxConditionValue.TextChanged += new System.EventHandler(this.UpdateBreakpoints);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Value";
            // 
            // textBoxConditionName
            // 
            this.textBoxConditionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConditionName.Location = new System.Drawing.Point(80, 21);
            this.textBoxConditionName.Name = "textBoxConditionName";
            this.textBoxConditionName.Size = new System.Drawing.Size(141, 22);
            this.textBoxConditionName.TabIndex = 11;
            this.textBoxConditionName.TextChanged += new System.EventHandler(this.UpdateBreakpoints);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Variable";
            // 
            // FormDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 704);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDebug";
            this.Text = "Debug SmallBasic";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDebug_FormClosed);
            this.Load += new System.EventHandler(this.FormDebug_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDebug_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBoxLabels;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPause;
        private System.Windows.Forms.ToolStripButton toolStripButtonRun;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuit;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripButton toolStripButtonIgnoreBP;
        private System.Windows.Forms.ToolStripButton toolStripButtonAllBP;
        private System.Windows.Forms.Button buttonChangeValue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonTransparency;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonArray;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBP;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxConditionValue;
        private System.Windows.Forms.TextBox textBoxConditionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxBPOnly;
        private System.Windows.Forms.ToolStripButton toolStripButtonStepOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCondition;
    }
}