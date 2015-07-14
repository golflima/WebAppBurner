/***
 *  Copyright (C) 2015, Jérémy WALTHER (jeremy.walther@golflima.net)
 *
 *  This file is part of WebAppBurner (GL.WebAppBurner).
 *  GL.WebAppBurner, Benchmarking tool for web applications.
 * 
 *  WebAppBurner is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  WebAppBurner is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace GL.WebAppBurner
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.ram = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.warningButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.requestCount = new System.Windows.Forms.Label();
            this.activeRunners = new System.Windows.Forms.Label();
            this.estimatedRemainingTime = new System.Windows.Forms.Label();
            this.requestProgressBar = new System.Windows.Forms.ProgressBar();
            this.requestGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeout = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workers = new System.Windows.Forms.NumericUpDown();
            this.iterations = new System.Windows.Forms.NumericUpDown();
            this.requestGrid = new System.Windows.Forms.DataGridView();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.requestSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.requestOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pauseButton = new System.Windows.Forms.Button();
            this.ramTimer = new System.Windows.Forms.Timer(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultValidationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataExtractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataSeparatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scriptBeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scriptAfterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testRequestInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.requestGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testRequestInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultGroupBox.Controls.Add(this.ram);
            this.resultGroupBox.Controls.Add(this.pictureBox7);
            this.resultGroupBox.Controls.Add(this.warningButton);
            this.resultGroupBox.Controls.Add(this.label5);
            this.resultGroupBox.Controls.Add(this.pictureBox3);
            this.resultGroupBox.Controls.Add(this.pictureBox2);
            this.resultGroupBox.Controls.Add(this.pictureBox1);
            this.resultGroupBox.Controls.Add(this.label4);
            this.resultGroupBox.Controls.Add(this.label3);
            this.resultGroupBox.Controls.Add(this.requestCount);
            this.resultGroupBox.Controls.Add(this.activeRunners);
            this.resultGroupBox.Controls.Add(this.estimatedRemainingTime);
            this.resultGroupBox.Controls.Add(this.requestProgressBar);
            this.resultGroupBox.Location = new System.Drawing.Point(12, 275);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(860, 126);
            this.resultGroupBox.TabIndex = 0;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Web benchmark progress";
            // 
            // ram
            // 
            this.ram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ram.AutoSize = true;
            this.ram.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ram.Location = new System.Drawing.Point(731, 102);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(19, 13);
            this.ram.TabIndex = 12;
            this.ram.Text = "--";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = global::GL.WebAppBurner.Properties.Resources.ic_memory_black_18dp;
            this.pictureBox7.Location = new System.Drawing.Point(707, 99);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(18, 18);
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // warningButton
            // 
            this.warningButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.warningButton.Image = global::GL.WebAppBurner.Properties.Resources.ic_warning_black_18dp;
            this.warningButton.Location = new System.Drawing.Point(830, 97);
            this.warningButton.Name = "warningButton";
            this.warningButton.Size = new System.Drawing.Size(24, 23);
            this.warningButton.TabIndex = 10;
            this.warningButton.UseVisualStyleBackColor = true;
            this.warningButton.Click += new System.EventHandler(this.warningButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Executed requests :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GL.WebAppBurner.Properties.Resources.ic_import_export_black_18dp;
            this.pictureBox3.Location = new System.Drawing.Point(9, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GL.WebAppBurner.Properties.Resources.ic_group_black_18dp;
            this.pictureBox2.Location = new System.Drawing.Point(9, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GL.WebAppBurner.Properties.Resources.ic_schedule_black_18dp;
            this.pictureBox1.Location = new System.Drawing.Point(9, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(33, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Active workers :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(33, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estimated remaining time :";
            // 
            // requestCount
            // 
            this.requestCount.AutoSize = true;
            this.requestCount.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.requestCount.Location = new System.Drawing.Point(168, 102);
            this.requestCount.Name = "requestCount";
            this.requestCount.Size = new System.Drawing.Size(19, 13);
            this.requestCount.TabIndex = 3;
            this.requestCount.Text = "--";
            // 
            // activeRunners
            // 
            this.activeRunners.AutoSize = true;
            this.activeRunners.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.activeRunners.Location = new System.Drawing.Point(168, 78);
            this.activeRunners.Name = "activeRunners";
            this.activeRunners.Size = new System.Drawing.Size(19, 13);
            this.activeRunners.TabIndex = 2;
            this.activeRunners.Text = "--";
            // 
            // estimatedRemainingTime
            // 
            this.estimatedRemainingTime.AutoSize = true;
            this.estimatedRemainingTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedRemainingTime.Location = new System.Drawing.Point(168, 54);
            this.estimatedRemainingTime.Name = "estimatedRemainingTime";
            this.estimatedRemainingTime.Size = new System.Drawing.Size(19, 13);
            this.estimatedRemainingTime.TabIndex = 1;
            this.estimatedRemainingTime.Text = "--";
            // 
            // requestProgressBar
            // 
            this.requestProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestProgressBar.Location = new System.Drawing.Point(9, 20);
            this.requestProgressBar.Name = "requestProgressBar";
            this.requestProgressBar.Size = new System.Drawing.Size(842, 23);
            this.requestProgressBar.TabIndex = 0;
            // 
            // requestGroupBox
            // 
            this.requestGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestGroupBox.Controls.Add(this.panel1);
            this.requestGroupBox.Controls.Add(this.timeout);
            this.requestGroupBox.Controls.Add(this.label6);
            this.requestGroupBox.Controls.Add(this.pictureBox6);
            this.requestGroupBox.Controls.Add(this.pictureBox5);
            this.requestGroupBox.Controls.Add(this.pictureBox4);
            this.requestGroupBox.Controls.Add(this.label2);
            this.requestGroupBox.Controls.Add(this.label1);
            this.requestGroupBox.Controls.Add(this.workers);
            this.requestGroupBox.Controls.Add(this.iterations);
            this.requestGroupBox.Controls.Add(this.requestGrid);
            this.requestGroupBox.Location = new System.Drawing.Point(12, 12);
            this.requestGroupBox.Name = "requestGroupBox";
            this.requestGroupBox.Size = new System.Drawing.Size(860, 257);
            this.requestGroupBox.TabIndex = 0;
            this.requestGroupBox.TabStop = false;
            this.requestGroupBox.Text = "Web requests to execute";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(208, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 45);
            this.panel1.TabIndex = 12;
            // 
            // timeout
            // 
            this.timeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.timeout.Location = new System.Drawing.Point(363, 208);
            this.timeout.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.timeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeout.Name = "timeout";
            this.timeout.Size = new System.Drawing.Size(56, 20);
            this.timeout.TabIndex = 11;
            this.timeout.ThousandsSeparator = true;
            this.timeout.Value = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Requests timeout (ms) :";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.Image = global::GL.WebAppBurner.Properties.Resources.ic_access_alarm_black_18dp;
            this.pictureBox6.Location = new System.Drawing.Point(216, 207);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(18, 18);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.Image = global::GL.WebAppBurner.Properties.Resources.ic_person_black_18dp;
            this.pictureBox5.Location = new System.Drawing.Point(9, 231);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 18);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.Image = global::GL.WebAppBurner.Properties.Resources.ic_loop_black_18dp;
            this.pictureBox4.Location = new System.Drawing.Point(9, 207);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 18);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(33, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of workers :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(33, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of iterations :";
            // 
            // workers
            // 
            this.workers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.workers.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.workers.Location = new System.Drawing.Point(146, 232);
            this.workers.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.workers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.workers.Name = "workers";
            this.workers.Size = new System.Drawing.Size(56, 20);
            this.workers.TabIndex = 2;
            this.workers.ThousandsSeparator = true;
            this.workers.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // iterations
            // 
            this.iterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iterations.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.iterations.Location = new System.Drawing.Point(146, 208);
            this.iterations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.iterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(56, 20);
            this.iterations.TabIndex = 1;
            this.iterations.ThousandsSeparator = true;
            this.iterations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // requestGrid
            // 
            this.requestGrid.AllowUserToOrderColumns = true;
            this.requestGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestGrid.AutoGenerateColumns = false;
            this.requestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.postDataDataGridViewTextBoxColumn,
            this.resultValidationDataGridViewTextBoxColumn,
            this.resultDataExtractDataGridViewTextBoxColumn,
            this.resultDataSeparatorDataGridViewTextBoxColumn,
            this.scriptBeforeDataGridViewTextBoxColumn,
            this.scriptAfterDataGridViewTextBoxColumn});
            this.requestGrid.DataSource = this.testRequestInfoBindingSource;
            this.requestGrid.Location = new System.Drawing.Point(7, 20);
            this.requestGrid.Name = "requestGrid";
            this.requestGrid.Size = new System.Drawing.Size(844, 179);
            this.requestGrid.TabIndex = 0;
            this.requestGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestGrid_CellEndEdit);
            this.requestGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestGrid_CellValidated);
            this.requestGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.requestGrid_CellValidating);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startButton.Location = new System.Drawing.Point(12, 407);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopButton.Enabled = false;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopButton.Location = new System.Drawing.Point(174, 407);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Image = global::GL.WebAppBurner.Properties.Resources.ic_file_download_black_18dp;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(796, 406);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Image = global::GL.WebAppBurner.Properties.Resources.ic_file_upload_black_18dp;
            this.loadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadButton.Location = new System.Drawing.Point(715, 406);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // requestSaveFileDialog
            // 
            this.requestSaveFileDialog.DefaultExt = "glwab";
            this.requestSaveFileDialog.Filter = "WebAppBurner files|*.glwab";
            this.requestSaveFileDialog.Title = "Save requests";
            // 
            // requestOpenFileDialog
            // 
            this.requestOpenFileDialog.DefaultExt = "glwab";
            this.requestOpenFileDialog.Filter = "WebAppBurner files|*.glwab";
            this.requestOpenFileDialog.Title = "Load requests";
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pauseButton.Enabled = false;
            this.pauseButton.Image = global::GL.WebAppBurner.Properties.Resources.ic_pause_black_18dp;
            this.pauseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pauseButton.Location = new System.Drawing.Point(93, 407);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // ramTimer
            // 
            this.ramTimer.Enabled = true;
            this.ramTimer.Interval = 500;
            this.ramTimer.Tick += new System.EventHandler(this.ramTimer_Tick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ToolTipText = "Name of the step";
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ToolTipText = "Url of the web application to execute";
            // 
            // postDataDataGridViewTextBoxColumn
            // 
            this.postDataDataGridViewTextBoxColumn.DataPropertyName = "PostData";
            this.postDataDataGridViewTextBoxColumn.HeaderText = "PostData";
            this.postDataDataGridViewTextBoxColumn.Name = "postDataDataGridViewTextBoxColumn";
            this.postDataDataGridViewTextBoxColumn.ToolTipText = "Raw POST data to send to the web application";
            // 
            // resultValidationDataGridViewTextBoxColumn
            // 
            this.resultValidationDataGridViewTextBoxColumn.DataPropertyName = "ResultValidation";
            this.resultValidationDataGridViewTextBoxColumn.HeaderText = "ResultValidation";
            this.resultValidationDataGridViewTextBoxColumn.Name = "resultValidationDataGridViewTextBoxColumn";
            this.resultValidationDataGridViewTextBoxColumn.ToolTipText = "Regular expression used to check if the web application response is correct or no" +
    "t";
            // 
            // resultDataExtractDataGridViewTextBoxColumn
            // 
            this.resultDataExtractDataGridViewTextBoxColumn.DataPropertyName = "ResultDataExtract";
            this.resultDataExtractDataGridViewTextBoxColumn.HeaderText = "ResultDataExtract";
            this.resultDataExtractDataGridViewTextBoxColumn.Name = "resultDataExtractDataGridViewTextBoxColumn";
            this.resultDataExtractDataGridViewTextBoxColumn.ToolTipText = "Regular expression used to extract data of the web application response";
            // 
            // resultDataSeparatorDataGridViewTextBoxColumn
            // 
            this.resultDataSeparatorDataGridViewTextBoxColumn.DataPropertyName = "ResultDataSeparator";
            this.resultDataSeparatorDataGridViewTextBoxColumn.HeaderText = "ResultDataSeparator";
            this.resultDataSeparatorDataGridViewTextBoxColumn.Name = "resultDataSeparatorDataGridViewTextBoxColumn";
            this.resultDataSeparatorDataGridViewTextBoxColumn.ToolTipText = "Used to separate multiple results in the web application response data extraction" +
    "";
            // 
            // scriptBeforeDataGridViewTextBoxColumn
            // 
            this.scriptBeforeDataGridViewTextBoxColumn.DataPropertyName = "ScriptBefore";
            this.scriptBeforeDataGridViewTextBoxColumn.HeaderText = "ScriptBefore";
            this.scriptBeforeDataGridViewTextBoxColumn.Name = "scriptBeforeDataGridViewTextBoxColumn";
            this.scriptBeforeDataGridViewTextBoxColumn.ToolTipText = "Commands to execute before calling the web application. See \"GL.MetaN.ReflectionC" +
    "onsole\" for help.";
            // 
            // scriptAfterDataGridViewTextBoxColumn
            // 
            this.scriptAfterDataGridViewTextBoxColumn.DataPropertyName = "ScriptAfter";
            this.scriptAfterDataGridViewTextBoxColumn.HeaderText = "ScriptAfter";
            this.scriptAfterDataGridViewTextBoxColumn.Name = "scriptAfterDataGridViewTextBoxColumn";
            this.scriptAfterDataGridViewTextBoxColumn.ToolTipText = "Commands to execute after calling the web application. See \"GL.MetaN.ReflectionCo" +
    "nsole\" for help.";
            // 
            // testRequestInfoBindingSource
            // 
            this.testRequestInfoBindingSource.DataSource = typeof(GL.WebAppBurner.Core.TestRequestInfo);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 442);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.requestGroupBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "WebAppBurner - V{0}.{1}";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.requestGroupBox.ResumeLayout(false);
            this.requestGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testRequestInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.GroupBox requestGroupBox;
        private System.Windows.Forms.DataGridView requestGrid;
        private System.Windows.Forms.ProgressBar requestProgressBar;
        private System.Windows.Forms.NumericUpDown workers;
        private System.Windows.Forms.NumericUpDown iterations;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label estimatedRemainingTime;
        private System.Windows.Forms.Label activeRunners;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label requestCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.SaveFileDialog requestSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog requestOpenFileDialog;
        private System.Windows.Forms.Button warningButton;
        private System.Windows.Forms.BindingSource testRequestInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultValidationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataExtractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataSeparatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scriptBeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scriptAfterDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.NumericUpDown timeout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer ramTimer;
        private System.Windows.Forms.Label ram;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

