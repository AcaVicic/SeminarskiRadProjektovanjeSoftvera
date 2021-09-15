namespace View.Forms
{
    partial class AddConsoleTesting
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
            this.btnSaveConsoleTesting = new System.Windows.Forms.Button();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateOfTesting = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbConsole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveConsoleTesting
            // 
            this.btnSaveConsoleTesting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveConsoleTesting.Location = new System.Drawing.Point(117, 152);
            this.btnSaveConsoleTesting.Name = "btnSaveConsoleTesting";
            this.btnSaveConsoleTesting.Size = new System.Drawing.Size(131, 23);
            this.btnSaveConsoleTesting.TabIndex = 42;
            this.btnSaveConsoleTesting.Text = "Save Console Testing";
            this.btnSaveConsoleTesting.UseVisualStyleBackColor = true;
            this.btnSaveConsoleTesting.Click += new System.EventHandler(this.btnSaveConsoleTesting_Click);
            // 
            // cbWorker
            // 
            this.cbWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(117, 99);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(146, 21);
            this.cbWorker.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Worker:";
            // 
            // txtDateOfTesting
            // 
            this.txtDateOfTesting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateOfTesting.Location = new System.Drawing.Point(117, 126);
            this.txtDateOfTesting.Name = "txtDateOfTesting";
            this.txtDateOfTesting.Size = new System.Drawing.Size(146, 20);
            this.txtDateOfTesting.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Date of testing:";
            // 
            // cbConsole
            // 
            this.cbConsole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbConsole.FormattingEnabled = true;
            this.cbConsole.Location = new System.Drawing.Point(117, 72);
            this.cbConsole.Name = "cbConsole";
            this.cbConsole.Size = new System.Drawing.Size(146, 21);
            this.cbConsole.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Add Console Testing";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Console:";
            // 
            // AddConsoleTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(301, 201);
            this.Controls.Add(this.btnSaveConsoleTesting);
            this.Controls.Add(this.cbWorker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDateOfTesting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbConsole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "AddConsoleTesting";
            this.Text = "AddConsoleTesting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveConsoleTesting;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDateOfTesting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbConsole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}