﻿namespace Sandbox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statsTableCurrent = new Sandbox.StatsTableControl();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.speechBox = new System.Windows.Forms.TextBox();
            this.speakButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mapCurrentNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.mumbleTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mapIdLabel = new System.Windows.Forms.Label();
            this.teamColorIdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.joinSquadBox = new System.Windows.Forms.GroupBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.squadMapTextBox = new System.Windows.Forms.TextBox();
            this.squadMapLabel = new System.Windows.Forms.Label();
            this.pinLabel = new System.Windows.Forms.Label();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.squadUpdateButton = new System.Windows.Forms.Button();
            this.squadMessageBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.trackingLabel = new System.Windows.Forms.Label();
            this.trackingLabel2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statsTableTier1 = new Sandbox.StatsTableControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.statsTableTier2 = new Sandbox.StatsTableControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.statsTableTier3 = new Sandbox.StatsTableControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.joinSquadBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // statsTableCurrent
            // 
            this.statsTableCurrent.Location = new System.Drawing.Point(0, 0);
            this.statsTableCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.statsTableCurrent.Name = "statsTableCurrent";
            this.statsTableCurrent.Size = new System.Drawing.Size(503, 367);
            this.statsTableCurrent.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "GW2";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Sandbox";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // speechBox
            // 
            this.speechBox.Location = new System.Drawing.Point(5, 7);
            this.speechBox.Name = "speechBox";
            this.speechBox.Size = new System.Drawing.Size(236, 20);
            this.speechBox.TabIndex = 0;
            // 
            // speakButton
            // 
            this.speakButton.Location = new System.Drawing.Point(247, 6);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(75, 23);
            this.speakButton.TabIndex = 1;
            this.speakButton.Text = "Speak";
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "mode";
            // 
            // mapCurrentNameLabel
            // 
            this.mapCurrentNameLabel.AutoSize = true;
            this.mapCurrentNameLabel.Location = new System.Drawing.Point(36, 6);
            this.mapCurrentNameLabel.Name = "mapCurrentNameLabel";
            this.mapCurrentNameLabel.Size = new System.Drawing.Size(27, 13);
            this.mapCurrentNameLabel.TabIndex = 5;
            this.mapCurrentNameLabel.Text = "map";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Team: ";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(30, 7);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(27, 13);
            this.teamLabel.TabIndex = 9;
            this.teamLabel.Text = "Red";
            // 
            // mumbleTimer
            // 
            this.mumbleTimer.Interval = 1000;
            this.mumbleTimer.Tick += new System.EventHandler(this.mumbleTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Map ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Team Color ID:";
            // 
            // mapIdLabel
            // 
            this.mapIdLabel.AutoSize = true;
            this.mapIdLabel.Location = new System.Drawing.Point(30, 6);
            this.mapIdLabel.Name = "mapIdLabel";
            this.mapIdLabel.Size = new System.Drawing.Size(38, 13);
            this.mapIdLabel.TabIndex = 12;
            this.mapIdLabel.Text = "map id";
            // 
            // teamColorIdLabel
            // 
            this.teamColorIdLabel.AutoSize = true;
            this.teamColorIdLabel.Location = new System.Drawing.Point(32, 6);
            this.teamColorIdLabel.Name = "teamColorIdLabel";
            this.teamColorIdLabel.Size = new System.Drawing.Size(41, 13);
            this.teamColorIdLabel.TabIndex = 13;
            this.teamColorIdLabel.Text = "team id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Current Map";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mode:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer4, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 167);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Location = new System.Drawing.Point(218, 113);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.teamColorIdLabel);
            this.splitContainer5.Size = new System.Drawing.Size(95, 51);
            this.splitContainer5.SplitterDistance = 25;
            this.splitContainer5.TabIndex = 12;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(110, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mapCurrentNameLabel);
            this.splitContainer1.Size = new System.Drawing.Size(102, 49);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(93, 49);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 9;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(3, 113);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.teamLabel);
            this.splitContainer3.Size = new System.Drawing.Size(93, 51);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 10;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Location = new System.Drawing.Point(218, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.mapIdLabel);
            this.splitContainer4.Size = new System.Drawing.Size(95, 49);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.TabIndex = 11;
            // 
            // joinSquadBox
            // 
            this.joinSquadBox.Controls.Add(this.splitContainer6);
            this.joinSquadBox.Location = new System.Drawing.Point(5, 209);
            this.joinSquadBox.Name = "joinSquadBox";
            this.joinSquadBox.Size = new System.Drawing.Size(321, 115);
            this.joinSquadBox.TabIndex = 18;
            this.joinSquadBox.TabStop = false;
            this.joinSquadBox.Text = "Squad Announcement";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 16);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.squadMessageBox);
            this.splitContainer6.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainer6.Size = new System.Drawing.Size(315, 96);
            this.splitContainer6.SplitterDistance = 29;
            this.splitContainer6.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.squadMapTextBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.squadMapLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pinLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pinTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.squadUpdateButton, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 29);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // squadMapTextBox
            // 
            this.squadMapTextBox.Location = new System.Drawing.Point(175, 3);
            this.squadMapTextBox.Name = "squadMapTextBox";
            this.squadMapTextBox.Size = new System.Drawing.Size(67, 20);
            this.squadMapTextBox.TabIndex = 3;
            // 
            // squadMapLabel
            // 
            this.squadMapLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.squadMapLabel.AutoSize = true;
            this.squadMapLabel.Location = new System.Drawing.Point(128, 0);
            this.squadMapLabel.Name = "squadMapLabel";
            this.squadMapLabel.Size = new System.Drawing.Size(41, 29);
            this.squadMapLabel.TabIndex = 2;
            this.squadMapLabel.Text = "Map:";
            this.squadMapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pinLabel
            // 
            this.pinLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pinLabel.AutoSize = true;
            this.pinLabel.Location = new System.Drawing.Point(3, 0);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(41, 29);
            this.pinLabel.TabIndex = 0;
            this.pinLabel.Text = "Pin:";
            this.pinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pinTextBox
            // 
            this.pinTextBox.Location = new System.Drawing.Point(50, 3);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(67, 20);
            this.pinTextBox.TabIndex = 1;
            // 
            // squadUpdateButton
            // 
            this.squadUpdateButton.Location = new System.Drawing.Point(253, 3);
            this.squadUpdateButton.Name = "squadUpdateButton";
            this.squadUpdateButton.Size = new System.Drawing.Size(54, 19);
            this.squadUpdateButton.TabIndex = 4;
            this.squadUpdateButton.Text = "Update";
            this.squadUpdateButton.UseVisualStyleBackColor = true;
            this.squadUpdateButton.Click += new System.EventHandler(this.squadUpdateButton_Click);
            // 
            // squadMessageBox
            // 
            this.squadMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squadMessageBox.Location = new System.Drawing.Point(4, 4);
            this.squadMessageBox.Multiline = true;
            this.squadMessageBox.Name = "squadMessageBox";
            this.squadMessageBox.Size = new System.Drawing.Size(307, 55);
            this.squadMessageBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(189, 328);
            this.button1.Margin = new System.Windows.Forms.Padding(15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 389);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.speechBox);
            this.tabPage1.Controls.Add(this.joinSquadBox);
            this.tabPage1.Controls.Add(this.speakButton);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(503, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1-1",
            "1-2",
            "1-3"});
            this.comboBox1.Location = new System.Drawing.Point(369, 272);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(503, 363);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tracking";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.trackingLabel);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.trackingLabel2);
            this.splitContainer7.Size = new System.Drawing.Size(497, 357);
            this.splitContainer7.SplitterDistance = 284;
            this.splitContainer7.TabIndex = 2;
            // 
            // trackingLabel
            // 
            this.trackingLabel.AutoSize = true;
            this.trackingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackingLabel.Location = new System.Drawing.Point(0, 0);
            this.trackingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.trackingLabel.Name = "trackingLabel";
            this.trackingLabel.Size = new System.Drawing.Size(35, 13);
            this.trackingLabel.TabIndex = 1;
            this.trackingLabel.Text = "label7";
            // 
            // trackingLabel2
            // 
            this.trackingLabel2.AutoSize = true;
            this.trackingLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackingLabel2.Location = new System.Drawing.Point(0, 0);
            this.trackingLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.trackingLabel2.Name = "trackingLabel2";
            this.trackingLabel2.Size = new System.Drawing.Size(35, 13);
            this.trackingLabel2.TabIndex = 2;
            this.trackingLabel2.Text = "label7";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.statsTableCurrent);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(503, 363);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Stats";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statsTableTier1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(503, 363);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Tier 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statsTableTier1
            // 
            this.statsTableTier1.Location = new System.Drawing.Point(0, 0);
            this.statsTableTier1.Margin = new System.Windows.Forms.Padding(0);
            this.statsTableTier1.Name = "statsTableTier1";
            this.statsTableTier1.Size = new System.Drawing.Size(503, 367);
            this.statsTableTier1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.statsTableTier2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(503, 363);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Tier 2";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // statsTableTier2
            // 
            this.statsTableTier2.Location = new System.Drawing.Point(0, 0);
            this.statsTableTier2.Margin = new System.Windows.Forms.Padding(0);
            this.statsTableTier2.Name = "statsTableTier2";
            this.statsTableTier2.Size = new System.Drawing.Size(503, 367);
            this.statsTableTier2.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.statsTableTier3);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(503, 363);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Tier 3";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // statsTableTier3
            // 
            this.statsTableTier3.Location = new System.Drawing.Point(0, 0);
            this.statsTableTier3.Margin = new System.Windows.Forms.Padding(0);
            this.statsTableTier3.Name = "statsTableTier3";
            this.statsTableTier3.Size = new System.Drawing.Size(503, 367);
            this.statsTableTier3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 389);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.joinSquadBox.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox speechBox;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mapCurrentNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Timer mumbleTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mapIdLabel;
        private System.Windows.Forms.Label teamColorIdLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox joinSquadBox;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox squadMapTextBox;
        private System.Windows.Forms.Label squadMapLabel;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.TextBox squadMessageBox;
        private System.Windows.Forms.Button squadUpdateButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label trackingLabel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Label trackingLabel2;
        private System.Windows.Forms.TabPage tabPage2;
        private StatsTableControl statsTableTier1;
        private System.Windows.Forms.TabPage tabPage5;
        private StatsTableControl statsTableTier2;
        private System.Windows.Forms.TabPage tabPage6;
        private StatsTableControl statsTableTier3;
        private StatsTableControl statsTableCurrent;
    }
}

