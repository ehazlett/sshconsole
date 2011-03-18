/*
Copyright 2011 Evan Hazlett

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSHConsole
{
    public partial class FormConnect : Form
    {
        private FormMain frmParent;

        public FormConnect(FormMain frmParent)
        {
            InitializeComponent();
            this.frmParent = frmParent;
        }
 
        private void enableControls()
        {
            this.buttonConnect.Enabled = true;
        }
        private void disableControls()
        {
            this.buttonConnect.Enabled = false;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            disableControls();
            bool errors = false;
            // check values
            if (this.textBoxHost.Text == "")
            {
                errors = true;
                this.textBoxHost.Text = "[You must enter a hostname]";
            }
            if (this.textBoxUsername.Text == "")
            {
                errors = true;
                this.textBoxUsername.Text = "[You must enter a username]";
            }
            if (!errors)
            {
                String host = this.textBoxHost.Text.Split('.')[0];
                TabPage tp = new TabPage(host);
                SshConsole sc = new SshConsole(this.textBoxHost.Text, this.textBoxUsername.Text, this.textBoxPassword.Text);

                bool res = sc.connect();
                if (res)
                {
                    sc.Dock = DockStyle.Fill;
                    tp.Controls.Add(sc);
                    this.frmParent.AddTabPage(tp);
                    this.Close();
                }
                else
                {
                    this.labelStatus.Text = "* Login failed...";
                    enableControls();
                }
            }
            else
            {
                enableControls();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                this.buttonConnect.PerformClick();
            }
        }


    }
}
