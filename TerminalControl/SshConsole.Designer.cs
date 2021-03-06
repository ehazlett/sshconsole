﻿namespace SSHConsole
{
    partial class SshConsole
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.terminalEmulatorMain = new TerminalControl.TerminalEmulator();
            this.SuspendLayout();
            // 
            // terminalEmulatorMain
            // 
            this.terminalEmulatorMain.BackColor = System.Drawing.Color.Black;
            this.terminalEmulatorMain.Columns = 73;
            this.terminalEmulatorMain.ConnectionType = TerminalControl.TerminalEmulator.ConnectionTypes.SSH2;
            this.terminalEmulatorMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminalEmulatorMain.Font = new System.Drawing.Font("Courier New", 8F);
            this.terminalEmulatorMain.ForeColor = System.Drawing.Color.White;
            this.terminalEmulatorMain.Hostname = null;
            this.terminalEmulatorMain.Location = new System.Drawing.Point(0, 0);
            this.terminalEmulatorMain.Name = "terminalEmulatorMain";
            this.terminalEmulatorMain.Password = null;
            this.terminalEmulatorMain.Rows = 22;
            this.terminalEmulatorMain.Size = new System.Drawing.Size(522, 296);
            this.terminalEmulatorMain.TabIndex = 0;
            this.terminalEmulatorMain.Username = null;
            // 
            // SshConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.terminalEmulatorMain);
            this.Name = "SshConsole";
            this.Size = new System.Drawing.Size(522, 296);
            this.Load += new System.EventHandler(this.SshConsole_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TerminalControl.TerminalEmulator terminalEmulatorMain;


    }
}
