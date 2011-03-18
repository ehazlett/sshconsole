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

        public String connect()
        {
            try
            {
                this.terminalEmulatorMain.Hostname = this.host;
                this.terminalEmulatorMain.Username = this.username;
                this.terminalEmulatorMain.Password = this.password;
                this.terminalEmulatorMain.Connect();
                this.connected = true;
                return "";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

    }

}
