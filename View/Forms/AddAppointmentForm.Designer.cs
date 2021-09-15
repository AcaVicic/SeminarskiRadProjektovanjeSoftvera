namespace View.Forms
{
    partial class AddAppointmentForm
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
            this.cbConsole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbConsole
            // 
            this.cbConsole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbConsole.FormattingEnabled = true;
            this.cbConsole.Location = new System.Drawing.Point(112, 59);
            this.cbConsole.Name = "cbConsole";
            this.cbConsole.Size = new System.Drawing.Size(146, 21);
            this.cbConsole.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Add Appointment";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Console:";
            // 
            // cbClient
            // 
            this.cbClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(112, 86);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(146, 21);
            this.cbClient.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Client:";
            // 
            // txtDays
            // 
            this.txtDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDays.Location = new System.Drawing.Point(112, 113);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(146, 20);
            this.txtDays.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Days:";
            // 
            // cbWorker
            // 
            this.cbWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(112, 139);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(146, 21);
            this.cbWorker.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Worker:";
            // 
            // btnSaveAppointment
            // 
            this.btnSaveAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveAppointment.Location = new System.Drawing.Point(127, 166);
            this.btnSaveAppointment.Name = "btnSaveAppointment";
            this.btnSaveAppointment.Size = new System.Drawing.Size(107, 23);
            this.btnSaveAppointment.TabIndex = 32;
            this.btnSaveAppointment.Text = "Save Appointment";
            this.btnSaveAppointment.UseVisualStyleBackColor = true;
            this.btnSaveAppointment.Click += new System.EventHandler(this.btnSaveAppointment_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(322, 236);
            this.Controls.Add(this.btnSaveAppointment);
            this.Controls.Add(this.cbWorker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbConsole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "AddAppointmentForm";
            this.Text = "AddAppointmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbConsole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveAppointment;
    }
}