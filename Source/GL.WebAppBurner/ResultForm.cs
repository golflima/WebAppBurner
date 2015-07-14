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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GL.WebAppBurner
{
    public partial class ResultForm : Form
    {
        private readonly IEnumerable<TestRequestResult> testResults;

        public ResultForm(IEnumerable<TestRequestResult> testResults)
        {
            if (testResults == null) { throw new ArgumentNullException("testResults"); }
            this.testResults = testResults;
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            BindingSource source = new BindingSource();
            source.DataSource = this.testResults;
            resultGrid.DataSource = source;
            long sum = this.testResults.ToList().Sum(r => (long)r.Duration.TotalMilliseconds);
            long count = this.testResults.Count();
            Text = String.Format(Text, version.Major, version.Minor, count, sum, sum / count,
                100 * this.testResults.Count(r => r.Status == System.Net.WebExceptionStatus.Success) / count,
                100 * this.testResults.Count(r => r.Valid != false) / count);
        }

        private void saveResultButton_Click(object sender, EventArgs e)
        {
            if (resultSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch(resultSaveFileDialog.FilterIndex)
                { 
                    case 1:
                        XmlSerializer serializer = new XmlSerializer(typeof(List<TestRequestResult>));
                        serializer.Serialize(resultSaveFileDialog.OpenFile(), this.testResults.ToList());
                        break;
                    case 2:
                    case 3:
                    case 4:
                        using (TextWriter csvWriter = new StreamWriter(resultSaveFileDialog.OpenFile()))
                        {
                            string separator = resultSaveFileDialog.FilterIndex == 2 ? "," : ";";
                            if (resultSaveFileDialog.FilterIndex == 4)
                            {
                                InputForm input = new InputForm("Please enter the string separator you want\nto use in your file to separate values :", "\t");
                                input.ShowDialog();
                                separator = input.Value;
                            }
                            csvWriter.WriteLine("Start{0}WorkerId{0}Iteration{0}Name{0}Url{0}PostData{0}Duration{0}Milliseconds{0}Status{0}Error{0}Length{0}Validation{0}Valid{0}DataExtract{0}DataSeparator{0}DataExtracted{0}ScriptBefore{0}ScriptBeforeResult{0}ScriptAfter{0}ScriptAfterResult",
                                    separator);
                            foreach (TestRequestResult result in this.testResults)
                            {
                                csvWriter.WriteLine("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{0}{12}{0}{13}{0}{14}{0}{15}{0}{16}{0}{17}{0}{18}{0}{19}{0}{20}",
                                    separator,
                                    result.Start + result.Start.ToString(".fff"), result.WorkerId, result.Iteration, result.Name, result.Url, result.PostData, result.Duration, result.Milliseconds, 
                                    result.Status, result.Error, result.Length, result.Validation, result.Valid, result.DataExtract, result.DataSeparator, result.DataExtracted,
                                    result.ScriptBefore, result.ScriptBeforeResult, result.ScriptAfter, result.ScriptAfterResult);
                            }
                        }
                        break;
                }
            }
        }
    }
}
