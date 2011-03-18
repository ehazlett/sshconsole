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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SSHConsole
{
    public partial class SshConsole : UserControl
    {
        String host;
        String username;
        String password;
        Socket s;
        bool connected = false;
        int currentIndex = 0;
        String currentCommand = "";

        public SshConsole(String host, String username, String password)
        {
            InitializeComponent();
            this.host = host;
            this.username = username;
            this.password = password;
        }

        private void SshConsole_Load(object sender, EventArgs e)
        {
            
        }

        public bool connect()
        {
            try
            {
                this.terminalEmulatorMain.Hostname = this.host;
                this.terminalEmulatorMain.Username = this.username;
                this.terminalEmulatorMain.Password = this.password;
                this.terminalEmulatorMain.Connect();
                this.connected = true;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }

}
