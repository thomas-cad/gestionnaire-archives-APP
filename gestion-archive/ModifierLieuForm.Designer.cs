namespace gestion_archive
{
    partial class ModifierLieuForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.titre_label = new ReaLTaiizor.Controls.BigLabel();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.SupprimerButton = new System.Windows.Forms.Button();
            this.LieuComboBox = new System.Windows.Forms.ComboBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.AjouterEpisButton = new System.Windows.Forms.Button();
            this.ModifierButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(19, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 4);
            this.panel2.TabIndex = 48;
            // 
            // titre_label
            // 
            this.titre_label.AutoSize = true;
            this.titre_label.BackColor = System.Drawing.Color.Transparent;
            this.titre_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_label.ForeColor = System.Drawing.Color.White;
            this.titre_label.Location = new System.Drawing.Point(144, 16);
            this.titre_label.Name = "titre_label";
            this.titre_label.Size = new System.Drawing.Size(221, 45);
            this.titre_label.TabIndex = 0;
            this.titre_label.Text = "Modifier Lieu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.SupprimerButton);
            this.panel1.Controls.Add(this.LieuComboBox);
            this.panel1.Controls.Add(this.bigLabel2);
            this.panel1.Controls.Add(this.AjouterEpisButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.titre_label);
            this.panel1.Controls.Add(this.ModifierButton);
            this.panel1.EdgeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(504, 302);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 5;
            this.panel1.Text = "panel1";
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.SupprimerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupprimerButton.FlatAppearance.BorderSize = 0;
            this.SupprimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerButton.ForeColor = System.Drawing.Color.White;
            this.SupprimerButton.Location = new System.Drawing.Point(136, 247);
            this.SupprimerButton.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(242, 41);
            this.SupprimerButton.TabIndex = 52;
            this.SupprimerButton.Text = "Supprimer";
            this.SupprimerButton.UseVisualStyleBackColor = false;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // LieuComboBox
            // 
            this.LieuComboBox.FormattingEnabled = true;
            this.LieuComboBox.Location = new System.Drawing.Point(103, 115);
            this.LieuComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.LieuComboBox.Name = "LieuComboBox";
            this.LieuComboBox.Size = new System.Drawing.Size(326, 21);
            this.LieuComboBox.TabIndex = 51;
            this.LieuComboBox.SelectedIndexChanged += new System.EventHandler(this.LieuComboBox_SelectedIndexChanged);
            this.LieuComboBox.TextChanged += new System.EventHandler(this.LieuComboBox_TextChanged);
            this.LieuComboBox.Enter += new System.EventHandler(this.LieuComboBox_Enter);
            this.LieuComboBox.Leave += new System.EventHandler(this.LieuComboBox_Leave);
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.White;
            this.bigLabel2.Location = new System.Drawing.Point(98, 86);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(49, 25);
            this.bigLabel2.TabIndex = 50;
            this.bigLabel2.Text = "Lieu";
            // 
            // AjouterEpisButton
            // 
            this.AjouterEpisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.AjouterEpisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AjouterEpisButton.FlatAppearance.BorderSize = 0;
            this.AjouterEpisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterEpisButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterEpisButton.ForeColor = System.Drawing.Color.White;
            this.AjouterEpisButton.Location = new System.Drawing.Point(136, 202);
            this.AjouterEpisButton.Margin = new System.Windows.Forms.Padding(2);
            this.AjouterEpisButton.Name = "AjouterEpisButton";
            this.AjouterEpisButton.Size = new System.Drawing.Size(242, 41);
            this.AjouterEpisButton.TabIndex = 49;
            this.AjouterEpisButton.Text = "Ajouter des épis";
            this.AjouterEpisButton.UseVisualStyleBackColor = false;
            this.AjouterEpisButton.Click += new System.EventHandler(this.AjouterEpisButton_Click);
            // 
            // ModifierButton
            // 
            this.ModifierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.ModifierButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifierButton.FlatAppearance.BorderSize = 0;
            this.ModifierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierButton.ForeColor = System.Drawing.Color.White;
            this.ModifierButton.Location = new System.Drawing.Point(136, 157);
            this.ModifierButton.Margin = new System.Windows.Forms.Padding(2);
            this.ModifierButton.Name = "ModifierButton";
            this.ModifierButton.Size = new System.Drawing.Size(242, 41);
            this.ModifierButton.TabIndex = 45;
            this.ModifierButton.Text = "Modifier";
            this.ModifierButton.UseVisualStyleBackColor = false;
            this.ModifierButton.Click += new System.EventHandler(this.ModifierButton_Click);
            // 
            // ModifierLieuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 326);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifierLieuForm";
            this.Text = "ModifierLieuForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.BigLabel titre_label;
        private ReaLTaiizor.Controls.Panel panel1;
        private System.Windows.Forms.Button SupprimerButton;
        private System.Windows.Forms.ComboBox LieuComboBox;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private System.Windows.Forms.Button AjouterEpisButton;
        private System.Windows.Forms.Button ModifierButton;
    }
}