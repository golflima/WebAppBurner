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
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.resultSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iterationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.millisecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExtractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSeparatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExtractedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scriptBeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scriptBeforeResultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scriptAfterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scriptAfterResultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testRequestResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testRequestResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // resultGrid
            // 
            this.resultGrid.AllowUserToAddRows = false;
            this.resultGrid.AllowUserToDeleteRows = false;
            this.resultGrid.AllowUserToOrderColumns = true;
            this.resultGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultGrid.AutoGenerateColumns = false;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDataGridViewTextBoxColumn,
            this.workerIdDataGridViewTextBoxColumn,
            this.iterationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.postDataDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.millisecondsDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.errorDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.validationDataGridViewTextBoxColumn,
            this.validDataGridViewTextBoxColumn,
            this.dataExtractDataGridViewTextBoxColumn,
            this.dataSeparatorDataGridViewTextBoxColumn,
            this.dataExtractedDataGridViewTextBoxColumn,
            this.scriptBeforeDataGridViewTextBoxColumn,
            this.scriptBeforeResultDataGridViewTextBoxColumn,
            this.scriptAfterDataGridViewTextBoxColumn,
            this.scriptAfterResultDataGridViewTextBoxColumn});
            this.resultGrid.DataSource = this.testRequestResultBindingSource;
            this.resultGrid.Location = new System.Drawing.Point(13, 13);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            this.resultGrid.ShowEditingIcon = false;
            this.resultGrid.Size = new System.Drawing.Size(659, 388);
            this.resultGrid.TabIndex = 0;
            // 
            // saveResultButton
            // 
            this.saveResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveResultButton.Image = global::GL.WebAppBurner.Properties.Resources.ic_file_download_black_18dp;
            this.saveResultButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveResultButton.Location = new System.Drawing.Point(13, 407);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(659, 23);
            this.saveResultButton.TabIndex = 1;
            this.saveResultButton.Text = "Save";
            this.saveResultButton.UseVisualStyleBackColor = true;
            this.saveResultButton.Click += new System.EventHandler(this.saveResultButton_Click);
            // 
            // resultSaveFileDialog
            // 
            this.resultSaveFileDialog.DefaultExt = "xml";
            this.resultSaveFileDialog.Filter = "XML files|*.xml|CSV files (with \',\')|*.csv|CSV files (with \';\')|*.csv|Custom string separated values files|*.txt";
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "Start";
            this.startDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workerIdDataGridViewTextBoxColumn
            // 
            this.workerIdDataGridViewTextBoxColumn.DataPropertyName = "WorkerId";
            this.workerIdDataGridViewTextBoxColumn.HeaderText = "WorkerId";
            this.workerIdDataGridViewTextBoxColumn.Name = "workerIdDataGridViewTextBoxColumn";
            this.workerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iterationDataGridViewTextBoxColumn
            // 
            this.iterationDataGridViewTextBoxColumn.DataPropertyName = "Iteration";
            this.iterationDataGridViewTextBoxColumn.HeaderText = "Iteration";
            this.iterationDataGridViewTextBoxColumn.Name = "iterationDataGridViewTextBoxColumn";
            this.iterationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postDataDataGridViewTextBoxColumn
            // 
            this.postDataDataGridViewTextBoxColumn.DataPropertyName = "PostData";
            this.postDataDataGridViewTextBoxColumn.HeaderText = "PostData";
            this.postDataDataGridViewTextBoxColumn.Name = "postDataDataGridViewTextBoxColumn";
            this.postDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // millisecondsDataGridViewTextBoxColumn
            // 
            this.millisecondsDataGridViewTextBoxColumn.DataPropertyName = "Milliseconds";
            this.millisecondsDataGridViewTextBoxColumn.HeaderText = "Milliseconds";
            this.millisecondsDataGridViewTextBoxColumn.Name = "millisecondsDataGridViewTextBoxColumn";
            this.millisecondsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorDataGridViewTextBoxColumn
            // 
            this.errorDataGridViewTextBoxColumn.DataPropertyName = "Error";
            this.errorDataGridViewTextBoxColumn.HeaderText = "Error";
            this.errorDataGridViewTextBoxColumn.Name = "errorDataGridViewTextBoxColumn";
            this.errorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // validationDataGridViewTextBoxColumn
            // 
            this.validationDataGridViewTextBoxColumn.DataPropertyName = "Validation";
            this.validationDataGridViewTextBoxColumn.HeaderText = "Validation";
            this.validationDataGridViewTextBoxColumn.Name = "validationDataGridViewTextBoxColumn";
            this.validationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // validDataGridViewTextBoxColumn
            // 
            this.validDataGridViewTextBoxColumn.DataPropertyName = "Valid";
            this.validDataGridViewTextBoxColumn.HeaderText = "Valid";
            this.validDataGridViewTextBoxColumn.Name = "validDataGridViewTextBoxColumn";
            this.validDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataExtractDataGridViewTextBoxColumn
            // 
            this.dataExtractDataGridViewTextBoxColumn.DataPropertyName = "DataExtract";
            this.dataExtractDataGridViewTextBoxColumn.HeaderText = "DataExtract";
            this.dataExtractDataGridViewTextBoxColumn.Name = "dataExtractDataGridViewTextBoxColumn";
            this.dataExtractDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSeparatorDataGridViewTextBoxColumn
            // 
            this.dataSeparatorDataGridViewTextBoxColumn.DataPropertyName = "DataSeparator";
            this.dataSeparatorDataGridViewTextBoxColumn.HeaderText = "DataSeparator";
            this.dataSeparatorDataGridViewTextBoxColumn.Name = "dataSeparatorDataGridViewTextBoxColumn";
            this.dataSeparatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataExtractedDataGridViewTextBoxColumn
            // 
            this.dataExtractedDataGridViewTextBoxColumn.DataPropertyName = "DataExtracted";
            this.dataExtractedDataGridViewTextBoxColumn.HeaderText = "DataExtracted";
            this.dataExtractedDataGridViewTextBoxColumn.Name = "dataExtractedDataGridViewTextBoxColumn";
            this.dataExtractedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scriptBeforeDataGridViewTextBoxColumn
            // 
            this.scriptBeforeDataGridViewTextBoxColumn.DataPropertyName = "ScriptBefore";
            this.scriptBeforeDataGridViewTextBoxColumn.HeaderText = "ScriptBefore";
            this.scriptBeforeDataGridViewTextBoxColumn.Name = "scriptBeforeDataGridViewTextBoxColumn";
            this.scriptBeforeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scriptBeforeResultDataGridViewTextBoxColumn
            // 
            this.scriptBeforeResultDataGridViewTextBoxColumn.DataPropertyName = "ScriptBeforeResult";
            this.scriptBeforeResultDataGridViewTextBoxColumn.HeaderText = "ScriptBeforeResult";
            this.scriptBeforeResultDataGridViewTextBoxColumn.Name = "scriptBeforeResultDataGridViewTextBoxColumn";
            this.scriptBeforeResultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scriptAfterDataGridViewTextBoxColumn
            // 
            this.scriptAfterDataGridViewTextBoxColumn.DataPropertyName = "ScriptAfter";
            this.scriptAfterDataGridViewTextBoxColumn.HeaderText = "ScriptAfter";
            this.scriptAfterDataGridViewTextBoxColumn.Name = "scriptAfterDataGridViewTextBoxColumn";
            this.scriptAfterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scriptAfterResultDataGridViewTextBoxColumn
            // 
            this.scriptAfterResultDataGridViewTextBoxColumn.DataPropertyName = "ScriptAfterResult";
            this.scriptAfterResultDataGridViewTextBoxColumn.HeaderText = "ScriptAfterResult";
            this.scriptAfterResultDataGridViewTextBoxColumn.Name = "scriptAfterResultDataGridViewTextBoxColumn";
            this.scriptAfterResultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testRequestResultBindingSource
            // 
            this.testRequestResultBindingSource.DataSource = typeof(GL.WebAppBurner.Core.TestRequestResult);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 442);
            this.Controls.Add(this.saveResultButton);
            this.Controls.Add(this.resultGrid);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "ResultForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WebAppBurner - V{0}.{1} - {2} results (total: {3} ms, average: {4} ms, success: {" +
    "5}%, valid: {6}%)";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testRequestResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.Button saveResultButton;
        private System.Windows.Forms.SaveFileDialog resultSaveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iterationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn millisecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExtractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSeparatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExtractedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scriptBeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scriptBeforeResultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scriptAfterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scriptAfterResultDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource testRequestResultBindingSource;
    }
}