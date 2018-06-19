namespace VideoSortAssistant
{
    partial class AssistantForm
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
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SingleFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MoveToDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.OpenDirButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.FullPathBox = new System.Windows.Forms.TextBox();
            this.MoveCurrentTo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ShuffleButton = new System.Windows.Forms.Button();
            this.SnapSizeSortButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddPathRecButton = new System.Windows.Forms.Button();
            this.AppendButton = new System.Windows.Forms.Button();
            this.AlphabeticalSortButton = new System.Windows.Forms.Button();
            this.FileList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.FixBindingsButton = new System.Windows.Forms.Button();
            this.PlaceholderBrowse = new System.Windows.Forms.Button();
            this.OponWithBrowse = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.PlaceholderBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.OpenWithArgs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.OpenWithBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MaskBox = new System.Windows.Forms.TextBox();
            this.ReopenKeyBox = new System.Windows.Forms.CheckBox();
            this.NextKeyBox = new System.Windows.Forms.CheckBox();
            this.PreviousKeyBox = new System.Windows.Forms.CheckBox();
            this.UndoKeyBox = new System.Windows.Forms.CheckBox();
            this.DelKeyBox = new System.Windows.Forms.CheckBox();
            this.MoveKeyBox6 = new System.Windows.Forms.CheckBox();
            this.MoveKeyBox5 = new System.Windows.Forms.CheckBox();
            this.MoveKeyBox4 = new System.Windows.Forms.CheckBox();
            this.MoveKeyBox3 = new System.Windows.Forms.CheckBox();
            this.MoveKeyBox2 = new System.Windows.Forms.CheckBox();
            this.MoveKeyBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MoveBox6 = new System.Windows.Forms.TextBox();
            this.MoveButton6 = new System.Windows.Forms.Button();
            this.MoveBox5 = new System.Windows.Forms.TextBox();
            this.MoveButton5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MoveBox4 = new System.Windows.Forms.TextBox();
            this.MoveButton4 = new System.Windows.Forms.Button();
            this.MoveBox3 = new System.Windows.Forms.TextBox();
            this.MoveButton3 = new System.Windows.Forms.Button();
            this.MoveBox2 = new System.Windows.Forms.TextBox();
            this.MoveButton2 = new System.Windows.Forms.Button();
            this.MoveBox = new System.Windows.Forms.TextBox();
            this.MoveButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Log = new System.Windows.Forms.TextBox();
            this.SaveSettingsTimer = new System.Windows.Forms.Timer(this.components);
            this.SortByQualityButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileDialog
            // 
            this.FileDialog.Multiselect = true;
            this.FileDialog.Title = "Select multiple files";
            // 
            // SingleFileDialog
            // 
            this.SingleFileDialog.Title = "Select single file";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.OpenDirButton);
            this.splitContainer2.Panel1.Controls.Add(this.OpenButton);
            this.splitContainer2.Panel1.Controls.Add(this.SizeBox);
            this.splitContainer2.Panel1.Controls.Add(this.FullPathBox);
            this.splitContainer2.Panel1.Controls.Add(this.MoveCurrentTo);
            this.splitContainer2.Panel1MinSize = 35;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(883, 837);
            this.splitContainer2.SplitterDistance = 35;
            this.splitContainer2.TabIndex = 51;
            // 
            // OpenDirButton
            // 
            this.OpenDirButton.Enabled = false;
            this.OpenDirButton.Location = new System.Drawing.Point(695, 10);
            this.OpenDirButton.Name = "OpenDirButton";
            this.OpenDirButton.Size = new System.Drawing.Size(110, 23);
            this.OpenDirButton.TabIndex = 32;
            this.OpenDirButton.Text = "Open directory";
            this.OpenDirButton.UseVisualStyleBackColor = true;
            this.OpenDirButton.Click += new System.EventHandler(this.OpenDirButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Enabled = false;
            this.OpenButton.Location = new System.Drawing.Point(619, 10);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(70, 23);
            this.OpenButton.TabIndex = 31;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SizeBox
            // 
            this.SizeBox.Location = new System.Drawing.Point(474, 12);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.ReadOnly = true;
            this.SizeBox.Size = new System.Drawing.Size(63, 20);
            this.SizeBox.TabIndex = 30;
            // 
            // FullPathBox
            // 
            this.FullPathBox.Location = new System.Drawing.Point(12, 12);
            this.FullPathBox.Name = "FullPathBox";
            this.FullPathBox.ReadOnly = true;
            this.FullPathBox.Size = new System.Drawing.Size(456, 20);
            this.FullPathBox.TabIndex = 29;
            // 
            // MoveCurrentTo
            // 
            this.MoveCurrentTo.Enabled = false;
            this.MoveCurrentTo.Location = new System.Drawing.Point(543, 10);
            this.MoveCurrentTo.Name = "MoveCurrentTo";
            this.MoveCurrentTo.Size = new System.Drawing.Size(70, 23);
            this.MoveCurrentTo.TabIndex = 28;
            this.MoveCurrentTo.Text = "Move to...";
            this.MoveCurrentTo.UseVisualStyleBackColor = true;
            this.MoveCurrentTo.Click += new System.EventHandler(this.MoveCurrentTo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 798);
            this.tabControl1.TabIndex = 51;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 772);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SortByQualityButton);
            this.splitContainer1.Panel1.Controls.Add(this.ShuffleButton);
            this.splitContainer1.Panel1.Controls.Add(this.SnapSizeSortButton);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.ResetButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddPathRecButton);
            this.splitContainer1.Panel1.Controls.Add(this.AppendButton);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.AlphabeticalSortButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FileList);
            this.splitContainer1.Size = new System.Drawing.Size(869, 766);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 37;
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShuffleButton.Location = new System.Drawing.Point(563, 0);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(43, 23);
            this.ShuffleButton.TabIndex = 43;
            this.ShuffleButton.Text = "shuffle";
            this.ShuffleButton.UseVisualStyleBackColor = true;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // SnapSizeSortButton
            // 
            this.SnapSizeSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SnapSizeSortButton.Location = new System.Drawing.Point(425, -1);
            this.SnapSizeSortButton.Name = "SnapSizeSortButton";
            this.SnapSizeSortButton.Size = new System.Drawing.Size(36, 23);
            this.SnapSizeSortButton.TabIndex = 39;
            this.SnapSizeSortButton.Text = "size";
            this.SnapSizeSortButton.UseVisualStyleBackColor = true;
            this.SnapSizeSortButton.Click += new System.EventHandler(this.SnapSortButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "Sort:";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(11, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(77, 23);
            this.ResetButton.TabIndex = 37;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // AddPathRecButton
            // 
            this.AddPathRecButton.Location = new System.Drawing.Point(204, 3);
            this.AddPathRecButton.Name = "AddPathRecButton";
            this.AddPathRecButton.Size = new System.Drawing.Size(141, 23);
            this.AddPathRecButton.TabIndex = 41;
            this.AddPathRecButton.Text = "Add path recursively...";
            this.AddPathRecButton.UseVisualStyleBackColor = true;
            this.AddPathRecButton.Click += new System.EventHandler(this.AddPathRecButton_Click);
            // 
            // AppendButton
            // 
            this.AppendButton.Location = new System.Drawing.Point(94, 3);
            this.AppendButton.Name = "AppendButton";
            this.AppendButton.Size = new System.Drawing.Size(104, 23);
            this.AppendButton.TabIndex = 38;
            this.AppendButton.Text = "Add files...";
            this.AppendButton.UseVisualStyleBackColor = true;
            this.AppendButton.Click += new System.EventHandler(this.AppendButton_Click);
            // 
            // AlphabeticalSortButton
            // 
            this.AlphabeticalSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlphabeticalSortButton.Location = new System.Drawing.Point(521, -3);
            this.AlphabeticalSortButton.Name = "AlphabeticalSortButton";
            this.AlphabeticalSortButton.Size = new System.Drawing.Size(35, 23);
            this.AlphabeticalSortButton.TabIndex = 40;
            this.AlphabeticalSortButton.Text = "path";
            this.AlphabeticalSortButton.UseVisualStyleBackColor = true;
            this.AlphabeticalSortButton.Click += new System.EventHandler(this.AlphabeticalSortButton_Click);
            // 
            // FileList
            // 
            this.FileList.AllowDrop = true;
            this.FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileList.FormattingEnabled = true;
            this.FileList.Location = new System.Drawing.Point(0, 0);
            this.FileList.Name = "FileList";
            this.FileList.ScrollAlwaysVisible = true;
            this.FileList.Size = new System.Drawing.Size(869, 737);
            this.FileList.TabIndex = 32;
            this.FileList.SelectedIndexChanged += new System.EventHandler(this.FileList_SelectedIndexChanged);
            this.FileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileList_DragDrop);
            this.FileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileList_DragEnter);
            this.FileList.DoubleClick += new System.EventHandler(this.FileList_DoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.FixBindingsButton);
            this.tabPage3.Controls.Add(this.PlaceholderBrowse);
            this.tabPage3.Controls.Add(this.OponWithBrowse);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.PlaceholderBox);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.OpenWithArgs);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.OpenWithBox);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.MaskBox);
            this.tabPage3.Controls.Add(this.ReopenKeyBox);
            this.tabPage3.Controls.Add(this.NextKeyBox);
            this.tabPage3.Controls.Add(this.PreviousKeyBox);
            this.tabPage3.Controls.Add(this.UndoKeyBox);
            this.tabPage3.Controls.Add(this.DelKeyBox);
            this.tabPage3.Controls.Add(this.MoveKeyBox6);
            this.tabPage3.Controls.Add(this.MoveKeyBox5);
            this.tabPage3.Controls.Add(this.MoveKeyBox4);
            this.tabPage3.Controls.Add(this.MoveKeyBox3);
            this.tabPage3.Controls.Add(this.MoveKeyBox2);
            this.tabPage3.Controls.Add(this.MoveKeyBox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.MoveBox6);
            this.tabPage3.Controls.Add(this.MoveButton6);
            this.tabPage3.Controls.Add(this.MoveBox5);
            this.tabPage3.Controls.Add(this.MoveButton5);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.MoveBox4);
            this.tabPage3.Controls.Add(this.MoveButton4);
            this.tabPage3.Controls.Add(this.MoveBox3);
            this.tabPage3.Controls.Add(this.MoveButton3);
            this.tabPage3.Controls.Add(this.MoveBox2);
            this.tabPage3.Controls.Add(this.MoveButton2);
            this.tabPage3.Controls.Add(this.MoveBox);
            this.tabPage3.Controls.Add(this.MoveButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(875, 772);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Setup";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 15);
            this.label13.TabIndex = 109;
            this.label13.Text = "Bindings don\'t work?";
            // 
            // FixBindingsButton
            // 
            this.FixBindingsButton.Location = new System.Drawing.Point(139, 343);
            this.FixBindingsButton.Name = "FixBindingsButton";
            this.FixBindingsButton.Size = new System.Drawing.Size(75, 23);
            this.FixBindingsButton.TabIndex = 108;
            this.FixBindingsButton.Text = "Fix";
            this.FixBindingsButton.UseVisualStyleBackColor = true;
            this.FixBindingsButton.Click += new System.EventHandler(this.FixBindingsButton_Click);
            // 
            // PlaceholderBrowse
            // 
            this.PlaceholderBrowse.Location = new System.Drawing.Point(581, 514);
            this.PlaceholderBrowse.Name = "PlaceholderBrowse";
            this.PlaceholderBrowse.Size = new System.Drawing.Size(35, 23);
            this.PlaceholderBrowse.TabIndex = 107;
            this.PlaceholderBrowse.Text = "...";
            this.PlaceholderBrowse.UseVisualStyleBackColor = true;
            this.PlaceholderBrowse.Click += new System.EventHandler(this.PlaceholderBrowse_Click);
            // 
            // OponWithBrowse
            // 
            this.OponWithBrowse.Location = new System.Drawing.Point(581, 430);
            this.OponWithBrowse.Name = "OponWithBrowse";
            this.OponWithBrowse.Size = new System.Drawing.Size(35, 23);
            this.OponWithBrowse.TabIndex = 106;
            this.OponWithBrowse.Text = "...";
            this.OponWithBrowse.UseVisualStyleBackColor = true;
            this.OponWithBrowse.Click += new System.EventHandler(this.OponWithBrowse_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 519);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 15);
            this.label12.TabIndex = 105;
            this.label12.Text = "Placeholder file:";
            // 
            // PlaceholderBox
            // 
            this.PlaceholderBox.Location = new System.Drawing.Point(162, 516);
            this.PlaceholderBox.Name = "PlaceholderBox";
            this.PlaceholderBox.Size = new System.Drawing.Size(413, 20);
            this.PlaceholderBox.TabIndex = 104;
            this.PlaceholderBox.TextChanged += new System.EventHandler(this.PlaceholderBox_TextChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(19, 460);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 31);
            this.label11.TabIndex = 103;
            this.label11.Text = "App arguments (%1 means path):";
            // 
            // OpenWithArgs
            // 
            this.OpenWithArgs.Location = new System.Drawing.Point(162, 471);
            this.OpenWithArgs.Name = "OpenWithArgs";
            this.OpenWithArgs.Size = new System.Drawing.Size(454, 20);
            this.OpenWithArgs.TabIndex = 102;
            this.OpenWithArgs.TextChanged += new System.EventHandler(this.OpenWithArgs_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 101;
            this.label9.Text = "Force open with:";
            // 
            // OpenWithBox
            // 
            this.OpenWithBox.Location = new System.Drawing.Point(162, 433);
            this.OpenWithBox.Name = "OpenWithBox";
            this.OpenWithBox.Size = new System.Drawing.Size(413, 20);
            this.OpenWithBox.TabIndex = 100;
            this.OpenWithBox.TextChanged += new System.EventHandler(this.OpenWithBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 99;
            this.label7.Text = "Search mask:";
            // 
            // MaskBox
            // 
            this.MaskBox.Location = new System.Drawing.Point(162, 396);
            this.MaskBox.Name = "MaskBox";
            this.MaskBox.Size = new System.Drawing.Size(454, 20);
            this.MaskBox.TabIndex = 98;
            this.MaskBox.TextChanged += new System.EventHandler(this.MaskBox_TextChanged);
            // 
            // ReopenKeyBox
            // 
            this.ReopenKeyBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ReopenKeyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReopenKeyBox.Location = new System.Drawing.Point(17, 310);
            this.ReopenKeyBox.Name = "ReopenKeyBox";
            this.ReopenKeyBox.Size = new System.Drawing.Size(136, 25);
            this.ReopenKeyBox.TabIndex = 97;
            this.ReopenKeyBox.Text = "Ctrl+Shift+Space";
            this.ReopenKeyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReopenKeyBox.UseVisualStyleBackColor = true;
            this.ReopenKeyBox.CheckedChanged += new System.EventHandler(this.MoveKeyBox_CheckedChanged);
            // 
            // NextKeyBox
            // 
            this.NextKeyBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.NextKeyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NextKeyBox.Location = new System.Drawing.Point(17, 281);
            this.NextKeyBox.Name = "NextKeyBox";
            this.NextKeyBox.Size = new System.Drawing.Size(136, 25);
            this.NextKeyBox.TabIndex = 96;
            this.NextKeyBox.Text = "Ctrl+Shift+Right";
            this.NextKeyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NextKeyBox.UseVisualStyleBackColor = true;
            this.NextKeyBox.CheckedChanged += new System.EventHandler(this.MoveKeyBox_CheckedChanged);
            // 
            // PreviousKeyBox
            // 
            this.PreviousKeyBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.PreviousKeyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PreviousKeyBox.Location = new System.Drawing.Point(17, 254);
            this.PreviousKeyBox.Name = "PreviousKeyBox";
            this.PreviousKeyBox.Size = new System.Drawing.Size(136, 25);
            this.PreviousKeyBox.TabIndex = 95;
            this.PreviousKeyBox.Text = "Ctrl+Shift+Left";
            this.PreviousKeyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PreviousKeyBox.UseVisualStyleBackColor = true;
            this.PreviousKeyBox.CheckedChanged += new System.EventHandler(this.MoveKeyBox_CheckedChanged);
            // 
            // UndoKeyBox
            // 
            this.UndoKeyBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.UndoKeyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UndoKeyBox.Location = new System.Drawing.Point(17, 227);
            this.UndoKeyBox.Name = "UndoKeyBox";
            this.UndoKeyBox.Size = new System.Drawing.Size(136, 25);
            this.UndoKeyBox.TabIndex = 94;
            this.UndoKeyBox.Text = "Ctrl+Shift+Z";
            this.UndoKeyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UndoKeyBox.UseVisualStyleBackColor = true;
            this.UndoKeyBox.CheckedChanged += new System.EventHandler(this.MoveKeyBox_CheckedChanged);
            // 
            // DelKeyBox
            // 
            this.DelKeyBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.DelKeyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelKeyBox.Location = new System.Drawing.Point(17, 200);
            this.DelKeyBox.Name = "DelKeyBox";
            this.DelKeyBox.Size = new System.Drawing.Size(136, 25);
            this.DelKeyBox.TabIndex = 93;
            this.DelKeyBox.Text = "Ctrl+Shift+Del";
            this.DelKeyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelKeyBox.UseVisualStyleBackColor = true;
            this.DelKeyBox.CheckedChanged += new System.EventHandler(this.MoveKeyBox_CheckedChanged);
            // 
            // MoveKeyBox6
            // 
            this.MoveKeyBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.MoveKeyBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveKeyBox6.Location = new System.Drawing.Point(17, 163);
            this.MoveKeyBox6.Name = "MoveKeyBox6";
            this.MoveKeyBox6.Size = new System.Drawing.Size(136, 25);
            this.MoveKeyBox6.TabIndex = 92;
            this.MoveKeyBox6.Text = "Ctrl+Shift+6";
            this.MoveKeyBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveKeyBox6.UseVisualStyleBackColor = true;
            this.MoveKeyBox6.CheckedChanged += new System.EventHandler(this.MoveKeyBox_CheckedChanged);
            // 
            // MoveKeyBox5
            // 
            this.MoveKeyBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.MoveKeyBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveKeyBox5.Location = new System.Drawing.Point(17, 137);
            this.MoveKeyBox5.Name = "MoveKeyBox5";
            this.MoveKeyBox5.Size = new System.Drawing.Size(136, 25);
            this.MoveKeyBox5.TabIndex = 91;
            this.MoveKeyBox5.Text = "Ctrl+Shift+5";
            this.MoveKeyBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveKeyBox5.UseVisualStyleBackColor = true;
            this.MoveKeyBox5.CheckedChanged += new System.EventHandler(this.MoveKeyBox_CheckedChanged);
            // 
            // MoveKeyBox4
            // 
            this.MoveKeyBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.MoveKeyBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveKeyBox4.Location = new System.Drawing.Point(17, 111);
            this.MoveKeyBox4.Name = "MoveKeyBox4";
            this.MoveKeyBox4.Size = new System.Drawing.Size(136, 25);
            this.MoveKeyBox4.TabIndex = 90;
            this.MoveKeyBox4.Text = "Ctrl+Shift+4";
            this.MoveKeyBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveKeyBox4.UseVisualStyleBackColor = true;
            this.MoveKeyBox4.CheckedChanged += new System.EventHandler(this.MoveKeyBox_CheckedChanged);
            // 
            // MoveKeyBox3
            // 
            this.MoveKeyBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.MoveKeyBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveKeyBox3.Location = new System.Drawing.Point(17, 85);
            this.MoveKeyBox3.Name = "MoveKeyBox3";
            this.MoveKeyBox3.Size = new System.Drawing.Size(136, 25);
            this.MoveKeyBox3.TabIndex = 89;
            this.MoveKeyBox3.Text = "Ctrl+Shift+3";
            this.MoveKeyBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveKeyBox3.UseVisualStyleBackColor = true;
            this.MoveKeyBox3.CheckedChanged += new System.EventHandler(this.MoveKeyBox_CheckedChanged);
            // 
            // MoveKeyBox2
            // 
            this.MoveKeyBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.MoveKeyBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveKeyBox2.Location = new System.Drawing.Point(17, 60);
            this.MoveKeyBox2.Name = "MoveKeyBox2";
            this.MoveKeyBox2.Size = new System.Drawing.Size(136, 25);
            this.MoveKeyBox2.TabIndex = 88;
            this.MoveKeyBox2.Text = "Ctrl+Shift+2";
            this.MoveKeyBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveKeyBox2.UseVisualStyleBackColor = true;
            this.MoveKeyBox2.CheckedChanged += new System.EventHandler(this.MoveKeyBox_CheckedChanged);
            // 
            // MoveKeyBox
            // 
            this.MoveKeyBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.MoveKeyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveKeyBox.Location = new System.Drawing.Point(17, 34);
            this.MoveKeyBox.Name = "MoveKeyBox";
            this.MoveKeyBox.Size = new System.Drawing.Size(136, 25);
            this.MoveKeyBox.TabIndex = 87;
            this.MoveKeyBox.Text = "Ctrl+Shift+1";
            this.MoveKeyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveKeyBox.UseVisualStyleBackColor = true;
            this.MoveKeyBox.CheckedChanged += new System.EventHandler(this.MoveKeyBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 86;
            this.label5.Text = "Mapping";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 83;
            this.label4.Text = "Reopen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 81;
            this.label2.Text = "Next";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 79;
            this.label3.Text = "Previous";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 76;
            this.label1.Text = "Undo move or delete";
            // 
            // MoveBox6
            // 
            this.MoveBox6.Location = new System.Drawing.Point(162, 168);
            this.MoveBox6.Name = "MoveBox6";
            this.MoveBox6.Size = new System.Drawing.Size(413, 20);
            this.MoveBox6.TabIndex = 73;
            this.MoveBox6.TextChanged += new System.EventHandler(this.MoveBox_TextChanged);
            // 
            // MoveButton6
            // 
            this.MoveButton6.Location = new System.Drawing.Point(581, 165);
            this.MoveButton6.Name = "MoveButton6";
            this.MoveButton6.Size = new System.Drawing.Size(35, 23);
            this.MoveButton6.TabIndex = 72;
            this.MoveButton6.Text = "...";
            this.MoveButton6.UseVisualStyleBackColor = true;
            this.MoveButton6.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // MoveBox5
            // 
            this.MoveBox5.Location = new System.Drawing.Point(162, 142);
            this.MoveBox5.Name = "MoveBox5";
            this.MoveBox5.Size = new System.Drawing.Size(413, 20);
            this.MoveBox5.TabIndex = 70;
            this.MoveBox5.TextChanged += new System.EventHandler(this.MoveBox_TextChanged);
            // 
            // MoveButton5
            // 
            this.MoveButton5.Location = new System.Drawing.Point(581, 139);
            this.MoveButton5.Name = "MoveButton5";
            this.MoveButton5.Size = new System.Drawing.Size(35, 23);
            this.MoveButton5.TabIndex = 69;
            this.MoveButton5.Text = "...";
            this.MoveButton5.UseVisualStyleBackColor = true;
            this.MoveButton5.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 65;
            this.label10.Text = "Directory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 62;
            this.label6.Text = "Delete";
            // 
            // MoveBox4
            // 
            this.MoveBox4.Location = new System.Drawing.Point(162, 116);
            this.MoveBox4.Name = "MoveBox4";
            this.MoveBox4.Size = new System.Drawing.Size(413, 20);
            this.MoveBox4.TabIndex = 61;
            this.MoveBox4.TextChanged += new System.EventHandler(this.MoveBox_TextChanged);
            // 
            // MoveButton4
            // 
            this.MoveButton4.Location = new System.Drawing.Point(581, 113);
            this.MoveButton4.Name = "MoveButton4";
            this.MoveButton4.Size = new System.Drawing.Size(35, 23);
            this.MoveButton4.TabIndex = 60;
            this.MoveButton4.Text = "...";
            this.MoveButton4.UseVisualStyleBackColor = true;
            this.MoveButton4.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // MoveBox3
            // 
            this.MoveBox3.Location = new System.Drawing.Point(162, 91);
            this.MoveBox3.Name = "MoveBox3";
            this.MoveBox3.Size = new System.Drawing.Size(413, 20);
            this.MoveBox3.TabIndex = 59;
            this.MoveBox3.TextChanged += new System.EventHandler(this.MoveBox_TextChanged);
            // 
            // MoveButton3
            // 
            this.MoveButton3.Location = new System.Drawing.Point(581, 88);
            this.MoveButton3.Name = "MoveButton3";
            this.MoveButton3.Size = new System.Drawing.Size(35, 23);
            this.MoveButton3.TabIndex = 58;
            this.MoveButton3.Text = "...";
            this.MoveButton3.UseVisualStyleBackColor = true;
            this.MoveButton3.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // MoveBox2
            // 
            this.MoveBox2.Location = new System.Drawing.Point(162, 65);
            this.MoveBox2.Name = "MoveBox2";
            this.MoveBox2.Size = new System.Drawing.Size(413, 20);
            this.MoveBox2.TabIndex = 57;
            this.MoveBox2.TextChanged += new System.EventHandler(this.MoveBox_TextChanged);
            // 
            // MoveButton2
            // 
            this.MoveButton2.Location = new System.Drawing.Point(581, 62);
            this.MoveButton2.Name = "MoveButton2";
            this.MoveButton2.Size = new System.Drawing.Size(35, 23);
            this.MoveButton2.TabIndex = 56;
            this.MoveButton2.Text = "...";
            this.MoveButton2.UseVisualStyleBackColor = true;
            this.MoveButton2.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // MoveBox
            // 
            this.MoveBox.Location = new System.Drawing.Point(162, 39);
            this.MoveBox.Name = "MoveBox";
            this.MoveBox.Size = new System.Drawing.Size(413, 20);
            this.MoveBox.TabIndex = 55;
            this.MoveBox.TextChanged += new System.EventHandler(this.MoveBox_TextChanged);
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(581, 36);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(35, 23);
            this.MoveButton.TabIndex = 54;
            this.MoveButton.Text = "...";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Log);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(875, 772);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.Location = new System.Drawing.Point(3, 3);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(869, 766);
            this.Log.TabIndex = 22;
            // 
            // SaveSettingsTimer
            // 
            this.SaveSettingsTimer.Tick += new System.EventHandler(this.SaveSettingsTimer_Tick);
            // 
            // SortByQualityButton
            // 
            this.SortByQualityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortByQualityButton.Location = new System.Drawing.Point(460, 0);
            this.SortByQualityButton.Name = "SortByQualityButton";
            this.SortByQualityButton.Size = new System.Drawing.Size(66, 23);
            this.SortByQualityButton.TabIndex = 44;
            this.SortByQualityButton.Text = "size->quality";
            this.SortByQualityButton.UseVisualStyleBackColor = true;
            this.SortByQualityButton.Click += new System.EventHandler(this.SortByQualityButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(526, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "path";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AlphabeticalSortButton_Click);
            // 
            // AssistantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 837);
            this.Controls.Add(this.splitContainer2);
            this.KeyPreview = true;
            this.Name = "AssistantForm";
            this.Text = "Sort Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssistantForm_FormClosing);
            this.Load += new System.EventHandler(this.AssistantForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AssistantForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AssistantForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AssistantForm_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.AssistantForm_PreviewKeyDown);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.OpenFileDialog SingleFileDialog;
        private System.Windows.Forms.SaveFileDialog MoveToDialog;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox SizeBox;
        private System.Windows.Forms.TextBox FullPathBox;
        private System.Windows.Forms.Button MoveCurrentTo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button SnapSizeSortButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button AddPathRecButton;
        private System.Windows.Forms.Button AppendButton;
        private System.Windows.Forms.Button AlphabeticalSortButton;
        private System.Windows.Forms.ListBox FileList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox ReopenKeyBox;
        private System.Windows.Forms.CheckBox NextKeyBox;
        private System.Windows.Forms.CheckBox PreviousKeyBox;
        private System.Windows.Forms.CheckBox UndoKeyBox;
        private System.Windows.Forms.CheckBox DelKeyBox;
        private System.Windows.Forms.CheckBox MoveKeyBox6;
        private System.Windows.Forms.CheckBox MoveKeyBox5;
        private System.Windows.Forms.CheckBox MoveKeyBox4;
        private System.Windows.Forms.CheckBox MoveKeyBox3;
        private System.Windows.Forms.CheckBox MoveKeyBox2;
        private System.Windows.Forms.CheckBox MoveKeyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MoveBox6;
        private System.Windows.Forms.Button MoveButton6;
        private System.Windows.Forms.TextBox MoveBox5;
        private System.Windows.Forms.Button MoveButton5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MoveBox4;
        private System.Windows.Forms.Button MoveButton4;
        private System.Windows.Forms.TextBox MoveBox3;
        private System.Windows.Forms.Button MoveButton3;
        private System.Windows.Forms.TextBox MoveBox2;
        private System.Windows.Forms.Button MoveButton2;
        private System.Windows.Forms.TextBox MoveBox;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Timer SaveSettingsTimer;
        private System.Windows.Forms.Button OpenDirButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button ShuffleButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MaskBox;
        private System.Windows.Forms.Button OponWithBrowse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PlaceholderBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox OpenWithArgs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OpenWithBox;
        private System.Windows.Forms.Button PlaceholderBrowse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button FixBindingsButton;
        private System.Windows.Forms.Button SortByQualityButton;
        private System.Windows.Forms.Button button2;
    }
}

