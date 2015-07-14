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

using System;
using System.Reflection;
using System.Windows.Forms;

namespace GL.WebAppBurner
{
    public partial class InputForm : Form
    {     
        public InputForm(string askText, string defaultValue)
        {
            InitializeComponent();
            DefaultValue = defaultValue;
            ask.Text = askText;
            value.Text = defaultValue;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Text = String.Format(Text, version.Major, version.Minor);
        }

        public string DefaultValue { get; private set; }

        public string Value { get; private set; }

        private void okButton_Click(object sender, EventArgs e)
        {
            Value = value.Text;
            okButton.Enabled = false;
            Close();
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (okButton.Enabled) { Value = DefaultValue; }
        }
    }
}
