namespace gestion_archive
{
    partial class HistoriqueEmpruntForm
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
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.ArchiveDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.IdArchiveTextBox = new System.Windows.Forms.TextBox();
            this.titre_label = new ReaLTaiizor.Controls.BigLabel();
            this.RechercherButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.bigLabel2);
            this.panel1.Controls.Add(this.ArchiveDataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.IdArchiveTextBox);
            this.panel1.Controls.Add(this.titre_label);
            this.panel1.Controls.Add(this.RechercherButton);
            this.panel1.EdgeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(242, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1638, 869);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 4;
            this.panel1.Text = "panel1";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.White;
            this.bigLabel2.Location = new System.Drawing.Point(44, 398);
            this.bigLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(231, 51);
            this.bigLabel2.TabIndex = 49;
            this.bigLabel2.Text = "Historique :";
            // 
            // ArchiveDataGridView
            // 
            this.ArchiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArchiveDataGridView.Location = new System.Drawing.Point(36, 452);
            this.ArchiveDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.ArchiveDataGridView.Name = "ArchiveDataGridView";
            this.ArchiveDataGridView.RowHeadersWidth = 82;
            this.ArchiveDataGridView.Size = new System.Drawing.Size(1562, 379);
            this.ArchiveDataGridView.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(36, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1562, 19);
            this.panel2.TabIndex = 48;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(505, 201);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(204, 51);
            this.bigLabel1.TabIndex = 47;
            this.bigLabel1.Text = "Id Archive";
            // 
            // IdArchiveTextBox
            // 
            this.IdArchiveTextBox.Location = new System.Drawing.Point(515, 257);
            this.IdArchiveTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.IdArchiveTextBox.Name = "IdArchiveTextBox";
            this.IdArchiveTextBox.Size = new System.Drawing.Size(610, 31);
            this.IdArchiveTextBox.TabIndex = 46;
            this.IdArchiveTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdArchiveTextBox_KeyDown);
            // 
            // titre_label
            // 
            this.titre_label.AutoSize = true;
            this.titre_label.BackColor = System.Drawing.Color.Transparent;
            this.titre_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_label.ForeColor = System.Drawing.Color.White;
            this.titre_label.Location = new System.Drawing.Point(438, 26);
            this.titre_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titre_label.Name = "titre_label";
            this.titre_label.Size = new System.Drawing.Size(782, 86);
            this.titre_label.TabIndex = 0;
            this.titre_label.Text = "Historique des emprunts";
            // 
            // RechercherButton
            // 
            this.RechercherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.RechercherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RechercherButton.FlatAppearance.BorderSize = 0;
            this.RechercherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RechercherButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechercherButton.ForeColor = System.Drawing.Color.White;
            this.RechercherButton.Location = new System.Drawing.Point(659, 323);
            this.RechercherButton.Margin = new System.Windows.Forms.Padding(4);
            this.RechercherButton.Name = "RechercherButton";
            this.RechercherButton.Size = new System.Drawing.Size(320, 79);
            this.RechercherButton.TabIndex = 45;
            this.RechercherButton.Text = "Rechercher";
            this.RechercherButton.UseVisualStyleBackColor = false;
            this.RechercherButton.Click += new System.EventHandler(this.RechercherButton_Click);
            // 
            // HistoriqueEmpruntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2035, 987);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HistoriqueEmpruntForm";
            this.Text = "HistoriqueEmpruntForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.TextBox IdArchiveTextBox;
        private ReaLTaiizor.Controls.BigLabel titre_label;
        private System.Windows.Forms.Button RechercherButton;
        private System.Windows.Forms.DataGridView ArchiveDataGridView;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
    }
}