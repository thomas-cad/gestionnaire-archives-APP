namespace gestion_archive
{
    partial class SearchArchiveForm
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
            this.titre_label = new ReaLTaiizor.Controls.BigLabel();
            this.textbox_search = new ReaLTaiizor.Controls.BigTextBox();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.RechercherButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titre_label
            // 
            this.titre_label.AutoSize = true;
            this.titre_label.BackColor = System.Drawing.Color.Transparent;
            this.titre_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.titre_label.Location = new System.Drawing.Point(79, 21);
            this.titre_label.Name = "titre_label";
            this.titre_label.Size = new System.Drawing.Size(365, 45);
            this.titre_label.TabIndex = 0;
            this.titre_label.Text = "Rechercher une archive";
            // 
            // textbox_search
            // 
            this.textbox_search.BackColor = System.Drawing.Color.Transparent;
            this.textbox_search.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_search.ForeColor = System.Drawing.Color.DimGray;
            this.textbox_search.Image = null;
            this.textbox_search.Location = new System.Drawing.Point(73, 32);
            this.textbox_search.MaxLength = 32767;
            this.textbox_search.Multiline = false;
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.ReadOnly = false;
            this.textbox_search.Size = new System.Drawing.Size(340, 43);
            this.textbox_search.TabIndex = 1;
            this.textbox_search.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_search.UseSystemPasswordChar = false;
            this.textbox_search.TextChanged += new System.EventHandler(this.textbox_search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.RechercherButton);
            this.panel1.Controls.Add(this.textbox_search);
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(14, 88);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(476, 144);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 3;
            this.panel1.Text = "panel1";
            // 
            // RechercherButton
            // 
            this.RechercherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.RechercherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RechercherButton.FlatAppearance.BorderSize = 0;
            this.RechercherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RechercherButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechercherButton.ForeColor = System.Drawing.Color.White;
            this.RechercherButton.Location = new System.Drawing.Point(152, 96);
            this.RechercherButton.Margin = new System.Windows.Forms.Padding(2);
            this.RechercherButton.Name = "RechercherButton";
            this.RechercherButton.Size = new System.Drawing.Size(160, 41);
            this.RechercherButton.TabIndex = 45;
            this.RechercherButton.Text = "Rechercher";
            this.RechercherButton.UseVisualStyleBackColor = false;
            this.RechercherButton.Click += new System.EventHandler(this.RechercherButton_Click);
            // 
            // formArchives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(523, 255);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titre_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formArchives";
            this.Text = "formArchives";
            this.Load += new System.EventHandler(this.formArchives_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel titre_label;
        private ReaLTaiizor.Controls.BigTextBox textbox_search;
        private ReaLTaiizor.Controls.Panel panel1;
        private System.Windows.Forms.Button RechercherButton;
    }
}