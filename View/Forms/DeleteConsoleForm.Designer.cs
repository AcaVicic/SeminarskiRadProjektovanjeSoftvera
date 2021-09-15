namespace View.Forms
{
    partial class DeleteConsoleForm
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
            this.cbConsoleType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteConsole = new System.Windows.Forms.Button();
            this.dgvConsoles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsoles)).BeginInit();
            this.SuspendLayout();
            // 
            // cbConsoleType
            // 
            this.cbConsoleType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbConsoleType.FormattingEnabled = true;
            this.cbConsoleType.Location = new System.Drawing.Point(14, 88);
            this.cbConsoleType.Name = "cbConsoleType";
            this.cbConsoleType.Size = new System.Drawing.Size(121, 21);
            this.cbConsoleType.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(141, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteConsole
            // 
            this.btnDeleteConsole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteConsole.Location = new System.Drawing.Point(419, 344);
            this.btnDeleteConsole.Name = "btnDeleteConsole";
            this.btnDeleteConsole.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteConsole.TabIndex = 20;
            this.btnDeleteConsole.Text = "Delete Console";
            this.btnDeleteConsole.UseVisualStyleBackColor = true;
            this.btnDeleteConsole.Click += new System.EventHandler(this.btnDeleteConsole_Click);
            // 
            // dgvConsoles
            // 
            this.dgvConsoles.AllowUserToAddRows = false;
            this.dgvConsoles.AllowUserToDeleteRows = false;
            this.dgvConsoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvConsoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsoles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvConsoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsoles.Location = new System.Drawing.Point(14, 115);
            this.dgvConsoles.Name = "dgvConsoles";
            this.dgvConsoles.ReadOnly = true;
            this.dgvConsoles.Size = new System.Drawing.Size(500, 223);
            this.dgvConsoles.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Delete Console";
            // 
            // DeleteConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(528, 388);
            this.Controls.Add(this.cbConsoleType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteConsole);
            this.Controls.Add(this.dgvConsoles);
            this.Controls.Add(this.label1);
            this.Name = "DeleteConsoleForm";
            this.Text = "DeleteConsoleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbConsoleType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteConsole;
        private System.Windows.Forms.DataGridView dgvConsoles;
        private System.Windows.Forms.Label label1;
    }
}