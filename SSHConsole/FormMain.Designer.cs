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
using System.Windows.Forms;
namespace SSHConsole
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
            this.tabControlConsole = new System.Windows.Forms.TabControl();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewSession = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainerMain.ContentPanel.SuspendLayout();
            this.toolStripContainerMain.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainerMain
            // 
            // 
            // toolStripContainerMain.ContentPanel
            // 
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.tabControlConsole);
            this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(626, 388);
            this.toolStripContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainerMain.Name = "toolStripContainerMain";
            this.toolStripContainerMain.Size = new System.Drawing.Size(626, 413);
            this.toolStripContainerMain.TabIndex = 1;
            // 
            // toolStripContainerMain.TopToolStripPanel
            // 
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripMain);
            // 
            // tabControlConsole
            // 
            this.tabControlConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlConsole.Location = new System.Drawing.Point(0, 0);
            this.tabControlConsole.Name = "tabControlConsole";
            this.tabControlConsole.SelectedIndex = 0;
            this.tabControlConsole.Size = new System.Drawing.Size(626, 388);
            this.tabControlConsole.TabIndex = 0;
            this.tabControlConsole.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControlConsole_ControlAdded);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewSession});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(626, 25);
            this.toolStripMain.Stretch = true;
            this.toolStripMain.TabIndex = 0;
            // 
            // toolStripButtonNewSession
            // 
            this.toolStripButtonNewSession.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewSession.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewSession.Image")));
            this.toolStripButtonNewSession.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewSession.Name = "toolStripButtonNewSession";
            this.toolStripButtonNewSession.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewSession.Text = "New Session";
            this.toolStripButtonNewSession.Click += new System.EventHandler(this.toolStripButtonNewSession_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 413);
            this.Controls.Add(this.toolStripContainerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSHConsole";
            this.toolStripContainerMain.ContentPanel.ResumeLayout(false);
            this.toolStripContainerMain.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerMain.TopToolStripPanel.PerformLayout();
            this.toolStripContainerMain.ResumeLayout(false);
            this.toolStripContainerMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.TabControl tabControlConsole;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewSession;

        public void AddTabPage(TabPage tp)
        {
            this.tabControlConsole.TabPages.Add(tp);
        }
    }
}

