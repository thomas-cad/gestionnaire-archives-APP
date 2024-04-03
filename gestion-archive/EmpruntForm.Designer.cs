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
            this.RechercherButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RaisonTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AgentComboBox = new System.Windows.Forms.ComboBox();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.CoteTextBox = new System.Windows.Forms.TextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            IdArchiveTitleLabel = new ReaLTaiizor.Controls.BigLabel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = System.Drawing.Color.Transparent;
            bigLabel1.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bigLabel1.ForeColor = System.Drawing.Color.White;
            bigLabel1.Location = new System.Drawing.Point(162, 15);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new System.Drawing.Size(307, 37);
            bigLabel1.TabIndex = 54;
            bigLabel1.Text = "Emprunter une archive";
            // 
            // IdArchiveTitleLabel
            // 
            IdArchiveTitleLabel.AutoSize = true;
            IdArchiveTitleLabel.BackColor = System.Drawing.Color.Transparent;
            IdArchiveTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IdArchiveTitleLabel.ForeColor = System.Drawing.Color.White;
            IdArchiveTitleLabel.Location = new System.Drawing.Point(46, 93);
            IdArchiveTitleLabel.Name = "IdArchiveTitleLabel";
            IdArchiveTitleLabel.Size = new System.Drawing.Size(87, 21);
            IdArchiveTitleLabel.TabIndex = 80;
            IdArchiveTitleLabel.Text = "Id Archive";
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = System.Drawing.Color.Transparent;
            bigLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bigLabel2.ForeColor = System.Drawing.Color.White;
            bigLabel2.Location = new System.Drawing.Point(205, 183);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new System.Drawing.Size(212, 30);
            bigLabel2.TabIndex = 86;
            bigLabel2.Text = "Raison de l\'emprunt";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.RechercherButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.RaisonTextBox);
            this.panel1.Controls.Add(bigLabel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(bigLabel1);
            this.panel1.Controls.Add(this.AgentComboBox);
            this.panel1.Controls.Add(this.bigLabel3);
            this.panel1.Controls.Add(this.CoteTextBox);
            this.panel1.Controls.Add(IdArchiveTitleLabel);
            this.panel1.Location = new System.Drawing.Point(36, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 371);
            this.panel1.TabIndex = 53;
            // 
            // RechercherButton
            // 
            this.RechercherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.RechercherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RechercherButton.FlatAppearance.BorderSize = 0;
            this.RechercherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RechercherButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechercherButton.ForeColor = System.Drawing.Color.White;
            this.RechercherButton.Location = new System.Drawing.Point(232, 301);
            this.RechercherButton.Margin = new System.Windows.Forms.Padding(2);
            this.RechercherButton.Name = "RechercherButton";
            this.RechercherButton.Size = new System.Drawing.Size(160, 41);
            this.RechercherButton.TabIndex = 88;
            this.RechercherButton.Text = "Emprunter";
            this.RechercherButton.UseVisualStyleBackColor = false;
            this.RechercherButton.Click += new System.EventHandler(this.RechercherButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(29, 277);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(570, 5);
            this.panel4.TabIndex = 86;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(29, 162);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 5);
            this.panel3.TabIndex = 86;
            // 
            // RaisonTextBox
            // 
            this.RaisonTextBox.Location = new System.Drawing.Point(42, 225);
            this.RaisonTextBox.Name = "RaisonTextBox";
            this.RaisonTextBox.Size = new System.Drawing.Size(522, 20);
            this.RaisonTextBox.TabIndex = 87;
            this.RaisonTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaisonTextBox_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(29, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 5);
            this.panel2.TabIndex = 85;
            // 
            // AgentComboBox
            // 
            this.AgentComboBox.FormattingEnabled = true;
            this.AgentComboBox.Location = new System.Drawing.Point(386, 118);
            this.AgentComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.AgentComboBox.Name = "AgentComboBox";
            this.AgentComboBox.Size = new System.Drawing.Size(179, 21);
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
            this.bigLabel3.Location = new System.Drawing.Point(388, 92);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(56, 21);
            this.bigLabel3.TabIndex = 83;
            this.bigLabel3.Text = "Agent";
            // 
            // CoteTextBox
            // 
            this.CoteTextBox.Location = new System.Drawing.Point(43, 120);
            this.CoteTextBox.Name = "CoteTextBox";
            this.CoteTextBox.Size = new System.Drawing.Size(200, 20);
            this.CoteTextBox.TabIndex = 81;
            // 
            // EmpruntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 449);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmpruntForm";
            this.Text = "EmpruntForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CoteTextBox;
        private System.Windows.Forms.ComboBox AgentComboBox;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox RaisonTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RechercherButton;
    }
}