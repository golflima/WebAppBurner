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

using GL.WebAppBurner.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GL.WebAppBurner
{
    public partial class MainForm : Form
    {
        #region Fields

        private List<TestRequestInfo> requests;
        private Stopwatch stopwatch;
        private bool pauseRequested;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            this.stopwatch = new Stopwatch();
        }

        #endregion

        #region Methods

        private void MainForm_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Text = String.Format(Text, version.Major, version.Minor);
            Requests = new List<TestRequestInfo>();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (Requests != null && Requests.Count > 0)
            {
                if (requestProgressBar.Value == 0 && Runner == null)
                {
                    Runner = new TestRunner(this.Requests, (int)iterations.Value, (int)workers.Value);
                    TestWorker.RequestsTimeout = (int)timeout.Value;
                    requestProgressBar.Maximum = Runner.MaxRequests;
                    Runner.Start();
                }
                else
                {
                    Runner.Restart();
                }
                requestGroupBox.Enabled = false;
                startButton.Enabled = false;
                stopButton.Enabled = true;
                pauseButton.Enabled = true;
                loadButton.Enabled = false;
                stopButton.Select();
                this.stopwatch.Start();
                refreshTimer.Start();
                TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Normal);
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if(Runner != null)
            {
                estimatedRemainingTime.Text = "instant: " + Runner.EstimatedRemainingTime + " / average: "
                    + TimeSpan.FromTicks((long)((double)this.stopwatch.ElapsedTicks * (double)Runner.MaxRequests / (double)Runner.RequestCount) - this.stopwatch.ElapsedTicks)
                    + " / elapsed:" + this.stopwatch.Elapsed;
                activeRunners.Text = Runner.WaitingWorkerCount + " / " + Runner.RunningWorkerCount;
                requestCount.Text = Runner.RequestCount + " / " + Runner.MaxRequests;
                requestProgressBar.Value = Runner.RequestCount;
                TaskbarProgress.SetValue(this.Handle, Runner.RequestCount, Runner.MaxRequests);

                if (!Runner.IsRunning && !startButton.Enabled)
                {
                    refreshTimer.Stop();
                    startButton.Enabled = true;
                    stopButton.Enabled = false;
                    if (pauseRequested)
                    {
                        TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Paused);
                        pauseRequested = false;
                    }
                    else
                    {
                        requestProgressBar.Value = 0;
                        TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.NoProgress);
                        estimatedRemainingTime.Text = activeRunners.Text = requestCount.Text = "--";
                        pauseButton.Enabled = false;
                        requestGroupBox.Enabled = true;
                        loadButton.Enabled = true;
                        ResultForm resultForm = new ResultForm(Runner.TestResults);
                        resultForm.Show();
                        Runner = null;
                        this.stopwatch.Reset();
                    }
                }
            }
            else
            {
                refreshTimer.Stop();
            }
        }

        #endregion

        #region Properties

        private List<TestRequestInfo> Requests
        {
            get { return this.requests; }
            set { this.requests = value; BindingSource source = new BindingSource(); source.DataSource = value; this.requestGrid.DataSource = source; DisplaySaveButton(); }
        }

        private TestRunner Runner { get; set; }

        #endregion

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (Runner != null) { Runner.Stop(); }
            TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Error);
            stopButton.Enabled = false;
            pauseButton.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Runner != null) { Runner.Stop(); }
        }

        private void DisplaySaveButton() { saveButton.Enabled = Requests == null ? false : Requests.Count > 0; }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Requests != null && requestSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<TestRequestInfo>));
                serializer.Serialize(requestSaveFileDialog.OpenFile(), Requests);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (requestOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<TestRequestInfo>));
                object deserialized = serializer.Deserialize(requestOpenFileDialog.OpenFile());
                Requests = (List<TestRequestInfo>)deserialized;
            }
        }

        private void warningButton_Click(object sender, EventArgs e)
        {
            new WarningForm().ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // if (Runner != null && Runner.RunningWorkerCount > 0) { Runner.Kill(); }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings["LastRun"] == null)
                {
                    new WarningForm().ShowDialog();
                    config.AppSettings.Settings.Add("LastRun", "");
                }
                config.AppSettings.Settings["LastRun"].Value = DateTime.Now.ToString();
                config.Save(ConfigurationSaveMode.Modified);
            }
            catch(ConfigurationErrorsException)
            {
                new WarningForm().ShowDialog();
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (Runner != null) { Runner.Stop(); }
            TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Error);
            pauseButton.Enabled = false;
            pauseRequested = true;
        }

        private void requestGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string value = e.FormattedValue == null ? null : e.FormattedValue.ToString();
            if (String.IsNullOrEmpty(value)) { return; }
            switch (requestGrid.Columns[e.ColumnIndex].HeaderText)
            {
                case "Name": break;
                case "Url":
                    Uri Uri_Test;
                    if (!(Uri.TryCreate(value, UriKind.Absolute, out Uri_Test) && (Uri_Test.Scheme == Uri.UriSchemeHttp || Uri_Test.Scheme == Uri.UriSchemeHttps)))
                    {
                        requestGrid.Rows[e.RowIndex].ErrorText = "Url is not valid (it musts start with either http:// or https://).";
                        e.Cancel = true;
                    }
                    break;
                case "ResultValidation":
                case "ResultDataExtract":
                    try { new Regex(value).Match("WebAppBurner !"); }
                    catch (Exception) 
                    { 
                        requestGrid.Rows[e.RowIndex].ErrorText = requestGrid.Columns[e.ColumnIndex].HeaderText + " doesn't contain a valid regular expression pattern.";
                        e.Cancel = true; 
                    }
                    break;
            }
        }

        private void requestGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            requestGrid.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void requestGrid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DisplaySaveButton();
        }

        private void ramTimer_Tick(object sender, EventArgs e)
        {
            using(Process process = Process.GetCurrentProcess())
            {
                process.Refresh();
                string[] sizeSuffixes = { "B", "KB", "MB", "GB" };
                int i = 0;
                decimal decimalRam = (decimal)process.PrivateMemorySize64;
                while (Math.Round(decimalRam / 1024) >= 1){decimalRam /= 1024;  i++; }
                ram.Text = string.Format("{0:n1} {1}", decimalRam, sizeSuffixes[i]);
            }
        }
    }
}
