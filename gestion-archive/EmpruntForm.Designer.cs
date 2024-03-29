namespace gestion_archive
{
    partial class EmpruntForm
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
            ReaLTaiizor.Controls.BigLabel bigLabel1;
            ReaLTaiizor.Controls.BigLabel IdArchiveTitleLabel;
            ReaLTaiizor.Controls.BigLabel bigLabel2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.RaisonTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AgentComboBox = new System.Windows.Forms.ComboBox();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.emprunterButton = new System.Windows.Forms.Button();
            this.CoteTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            IdArchiveTitleLabel = new ReaLTaiizor.Controls.BigLabel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            bigLabel1.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bigLabel1.ForeColor = System.Drawing.Color.White;
            bigLabel1.Location = new System.Drawing.Point(324, 29);
            bigLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new System.Drawing.Size(598, 71);
            bigLabel1.TabIndex = 54;
            bigLabel1.Text = "Emprunter une archive";
            // 
            // IdArchiveTitleLabel
            // 
            IdArchiveTitleLabel.AutoSize = true;
            IdArchiveTitleLabel.BackColor = System.Drawing.Color.Transparent;
            IdArchiveTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IdArchiveTitleLabel.ForeColor = System.Drawing.Color.White;
            IdArchiveTitleLabel.Location = new System.Drawing.Point(92, 178);
            IdArchiveTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            IdArchiveTitleLabel.Name = "IdArchiveTitleLabel";
            IdArchiveTitleLabel.Size = new System.Drawing.Size(172, 45);
            IdArchiveTitleLabel.TabIndex = 80;
            IdArchiveTitleLabel.Text = "Id Archive";
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = System.Drawing.Color.Transparent;
            bigLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bigLabel2.ForeColor = System.Drawing.Color.White;
            bigLabel2.Location = new System.Drawing.Point(456, 358);
            bigLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new System.Drawing.Size(322, 45);
            bigLabel2.TabIndex = 86;
            bigLabel2.Text = "Raison de l\'emprunt";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.RaisonTextBox);
            this.panel1.Controls.Add(bigLabel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(bigLabel1);
            this.panel1.Controls.Add(this.AgentComboBox);
            this.panel1.Controls.Add(this.bigLabel3);
            this.panel1.Controls.Add(this.emprunterButton);
            this.panel1.Controls.Add(this.CoteTextBox);
            this.panel1.Controls.Add(IdArchiveTitleLabel);
            this.panel1.Location = new System.Drawing.Point(72, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 713);
            this.panel1.TabIndex = 53;
            // 
            // RaisonTextBox
            // 
            this.RaisonTextBox.Location = new System.Drawing.Point(84, 432);
            this.RaisonTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.RaisonTextBox.Name = "RaisonTextBox";
            this.RaisonTextBox.Size = new System.Drawing.Size(1040, 31);
            this.RaisonTextBox.TabIndex = 87;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(58, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 10);
            this.panel2.TabIndex = 85;
            // 
            // AgentComboBox
            // 
            this.AgentComboBox.FormattingEnabled = true;
            this.AgentComboBox.Location = new System.Drawing.Point(772, 226);
            this.AgentComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.AgentComboBox.Name = "AgentComboBox";
            this.AgentComboBox.Size = new System.Drawing.Size(354, 33);
            this.AgentComboBox.TabIndex = 84;
            this.AgentComboBox.SelectedIndexChanged += new System.EventHandler(this.AgentComboBox_SelectedIndexChanged);
            this.AgentComboBox.TextChanged += new System.EventHandler(this.AgentComboBox_TextChanged);
            this.AgentComboBox.Click += new System.EventHandler(this.AgentComboBox_Click);
            this.AgentComboBox.Leave += new System.EventHandler(this.AgentComboBox_Leave);
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.White;
            this.bigLabel3.Location = new System.Drawing.Point(776, 176);
            this.bigLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(111, 45);
            this.bigLabel3.TabIndex = 83;
            this.bigLabel3.Text = "Agent";
            // 
            // emprunterButton
            // 
            this.emprunterButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emprunterButton.Location = new System.Drawing.Point(501, 584);
            this.emprunterButton.Margin = new System.Windows.Forms.Padding(4);
            this.emprunterButton.Name = "emprunterButton";
            this.emprunterButton.Size = new System.Drawing.Size(244, 75);
            this.emprunterButton.TabIndex = 82;
            this.emprunterButton.Text = "Emprunter";
            this.emprunterButton.UseVisualStyleBackColor = true;
            this.emprunterButton.Click += new System.EventHandler(this.emprunterButton_Click);
            // 
            // CoteTextBox
            // 
            this.CoteTextBox.Location = new System.Drawing.Point(86, 230);
            this.CoteTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CoteTextBox.Name = "CoteTextBox";
            this.CoteTextBox.Size = new System.Drawing.Size(396, 31);
            this.CoteTextBox.TabIndex = 81;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(58, 312);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 10);
            this.panel3.TabIndex = 86;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(58, 532);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1140, 10);
            this.panel4.TabIndex = 86;
            // 
            // EmpruntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 916);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmpruntForm";
            this.Text = "EmpruntForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button emprunterButton;
        private System.Windows.Forms.TextBox CoteTextBox;
        private System.Windows.Forms.ComboBox AgentComboBox;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox RaisonTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}