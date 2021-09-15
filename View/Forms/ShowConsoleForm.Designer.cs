namespace View.Forms
{
    partial class ShowConsoleForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConsoleType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbAvailable = new System.Windows.Forms.CheckBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnUpdateConsole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Show Console";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ConsoleType:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Available:";
            // 
            // lblConsoleType
            // 
            this.lblConsoleType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsoleType.AutoSize = true;
            this.lblConsoleType.Location = new System.Drawing.Point(154, 87);
            this.lblConsoleType.Name = "lblConsoleType";
            this.lblConsoleType.Size = new System.Drawing.Size(0, 13);
            this.lblConsoleType.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Price:";
            // 
            // ckbAvailable
            // 
            this.ckbAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbAvailable.AutoSize = true;
            this.ckbAvailable.Location = new System.Drawing.Point(135, 116);
            this.ckbAvailable.Name = "ckbAvailable";
            this.ckbAvailable.Size = new System.Drawing.Size(15, 14);
            this.ckbAvailable.TabIndex = 18;
            this.ckbAvailable.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Location = new System.Drawing.Point(116, 140);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 19;
            // 
            // btnUpdateConsole
            // 
            this.btnUpdateConsole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateConsole.Location = new System.Drawing.Point(116, 167);
            this.btnUpdateConsole.Name = "btnUpdateConsole";
            this.btnUpdateConsole.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateConsole.TabIndex = 20;
            this.btnUpdateConsole.Text = "Update Console";
            this.btnUpdateConsole.UseVisualStyleBackColor = true;
            this.btnUpdateConsole.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(289, 231);
            this.Controls.Add(this.btnUpdateConsole);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.ckbAvailable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblConsoleType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "ShowConsoleForm";
            this.Text = "ShowConsoleForm";
            this.Load += new System.EventHandler(this.ShowConsoleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConsoleType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbAvailable;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnUpdateConsole;
    }
}