﻿namespace View.Forms
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleTestingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addConsoleTestingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.consoleToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.consoleTestingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWorkerToolStripMenuItem,
            this.deleteWorkerToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.clientsToolStripMenuItem.Text = "Worker";
            // 
            // addWorkerToolStripMenuItem
            // 
            this.addWorkerToolStripMenuItem.Name = "addWorkerToolStripMenuItem";
            this.addWorkerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addWorkerToolStripMenuItem.Text = "Add Worker";
            this.addWorkerToolStripMenuItem.Click += new System.EventHandler(this.addWorkerToolStripMenuItem_Click);
            // 
            // deleteWorkerToolStripMenuItem
            // 
            this.deleteWorkerToolStripMenuItem.Name = "deleteWorkerToolStripMenuItem";
            this.deleteWorkerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteWorkerToolStripMenuItem.Text = "Delete Worker";
            this.deleteWorkerToolStripMenuItem.Click += new System.EventHandler(this.deleteWorkerToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.findClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addClientToolStripMenuItem.Text = "Add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // findClientToolStripMenuItem
            // 
            this.findClientToolStripMenuItem.Name = "findClientToolStripMenuItem";
            this.findClientToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.findClientToolStripMenuItem.Text = "Find Client";
            this.findClientToolStripMenuItem.Click += new System.EventHandler(this.findClientToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConsoleToolStripMenuItem,
            this.updateConsoleToolStripMenuItem,
            this.deleteConsoleToolStripMenuItem});
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.consoleToolStripMenuItem.Text = "Console";
            // 
            // addConsoleToolStripMenuItem
            // 
            this.addConsoleToolStripMenuItem.Name = "addConsoleToolStripMenuItem";
            this.addConsoleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addConsoleToolStripMenuItem.Text = "Add Console";
            this.addConsoleToolStripMenuItem.Click += new System.EventHandler(this.addConsoleToolStripMenuItem_Click);
            // 
            // updateConsoleToolStripMenuItem
            // 
            this.updateConsoleToolStripMenuItem.Name = "updateConsoleToolStripMenuItem";
            this.updateConsoleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.updateConsoleToolStripMenuItem.Text = "Update Console";
            this.updateConsoleToolStripMenuItem.Click += new System.EventHandler(this.updateConsoleToolStripMenuItem_Click);
            // 
            // deleteConsoleToolStripMenuItem
            // 
            this.deleteConsoleToolStripMenuItem.Name = "deleteConsoleToolStripMenuItem";
            this.deleteConsoleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteConsoleToolStripMenuItem.Text = "Delete Console";
            this.deleteConsoleToolStripMenuItem.Click += new System.EventHandler(this.deleteConsoleToolStripMenuItem_Click);
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAppointmentToolStripMenuItem});
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // addAppointmentToolStripMenuItem
            // 
            this.addAppointmentToolStripMenuItem.Name = "addAppointmentToolStripMenuItem";
            this.addAppointmentToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addAppointmentToolStripMenuItem.Text = "Add Appointment";
            this.addAppointmentToolStripMenuItem.Click += new System.EventHandler(this.addAppointmentToolStripMenuItem_Click);
            // 
            // consoleTestingToolStripMenuItem
            // 
            this.consoleTestingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConsoleTestingToolStripMenuItem});
            this.consoleTestingToolStripMenuItem.Name = "consoleTestingToolStripMenuItem";
            this.consoleTestingToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.consoleTestingToolStripMenuItem.Text = "Console Testing";
            // 
            // addConsoleTestingToolStripMenuItem
            // 
            this.addConsoleTestingToolStripMenuItem.Name = "addConsoleTestingToolStripMenuItem";
            this.addConsoleTestingToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addConsoleTestingToolStripMenuItem.Text = "Add Console Testing";
            this.addConsoleTestingToolStripMenuItem.Click += new System.EventHandler(this.addConsoleTestingToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(579, 353);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleTestingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addConsoleTestingToolStripMenuItem;
    }
}