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
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.textBoxIdArchive = new System.Windows.Forms.TextBox();
            this.RechercherButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.textBoxCote = new System.Windows.Forms.TextBox();
            this.button_recherchercote = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titre_label
            // 
            this.titre_label.AutoSize = true;
            this.titre_label.BackColor = System.Drawing.Color.Transparent;
            this.titre_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_label.ForeColor = System.Drawing.Color.White;
            this.titre_label.Location = new System.Drawing.Point(132, 17);
            this.titre_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titre_label.Name = "titre_label";
            this.titre_label.Size = new System.Drawing.Size(737, 86);
            this.titre_label.TabIndex = 0;
            this.titre_label.Text = "Rechercher une archive";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bigLabel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxCote);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.button_recherchercote);
            this.panel1.Controls.Add(this.textBoxIdArchive);
            this.panel1.Controls.Add(this.titre_label);
            this.panel1.Controls.Add(this.RechercherButton);
            this.panel1.EdgeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(156, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1000, 423);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 3;
            this.panel1.Text = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(38, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 19);
            this.panel2.TabIndex = 48;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(188, 167);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(204, 51);
            this.bigLabel1.TabIndex = 47;
            this.bigLabel1.Text = "Id Archive";
            // 
            // textBoxIdArchive
            // 
            this.textBoxIdArchive.Location = new System.Drawing.Point(198, 223);
            this.textBoxIdArchive.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxIdArchive.Name = "textBoxIdArchive";
            this.textBoxIdArchive.Size = new System.Drawing.Size(610, 31);
            this.textBoxIdArchive.TabIndex = 46;
            // 
            // RechercherButton
            // 
            this.RechercherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.RechercherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RechercherButton.FlatAppearance.BorderSize = 0;
            this.RechercherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RechercherButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechercherButton.ForeColor = System.Drawing.Color.White;
            this.RechercherButton.Location = new System.Drawing.Point(342, 288);
            this.RechercherButton.Margin = new System.Windows.Forms.Padding(4);
            this.RechercherButton.Name = "RechercherButton";
            this.RechercherButton.Size = new System.Drawing.Size(320, 79);
            this.RechercherButton.TabIndex = 45;
            this.RechercherButton.Text = "Rechercher";
            this.RechercherButton.UseVisualStyleBackColor = false;
            this.RechercherButton.Click += new System.EventHandler(this.RechercherButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(38, 421);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 19);
            this.panel3.TabIndex = 52;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.White;
            this.bigLabel2.Location = new System.Drawing.Point(188, 465);
            this.bigLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(105, 51);
            this.bigLabel2.TabIndex = 51;
            this.bigLabel2.Text = "Cote";
            // 
            // textBoxCote
            // 
            this.textBoxCote.Location = new System.Drawing.Point(198, 521);
            this.textBoxCote.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCote.Name = "textBoxCote";
            this.textBoxCote.Size = new System.Drawing.Size(610, 31);
            this.textBoxCote.TabIndex = 50;
            // 
            // button_recherchercote
            // 
            this.button_recherchercote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.button_recherchercote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_recherchercote.FlatAppearance.BorderSize = 0;
            this.button_recherchercote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_recherchercote.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_recherchercote.ForeColor = System.Drawing.Color.White;
            this.button_recherchercote.Location = new System.Drawing.Point(342, 586);
            this.button_recherchercote.Margin = new System.Windows.Forms.Padding(4);
            this.button_recherchercote.Name = "button_recherchercote";
            this.button_recherchercote.Size = new System.Drawing.Size(320, 79);
            this.button_recherchercote.TabIndex = 49;
            this.button_recherchercote.Text = "Rechercher";
            this.button_recherchercote.UseVisualStyleBackColor = false;
            this.button_recherchercote.Click += new System.EventHandler(this.button_recherchercote_Click);
            // 
            // SearchArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1310, 633);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SearchArchiveForm";
            this.Text = "formArchives";
            this.Load += new System.EventHandler(this.formArchives_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel titre_label;
        private ReaLTaiizor.Controls.Panel panel1;
        private System.Windows.Forms.Button RechercherButton;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.TextBox textBoxIdArchive;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private System.Windows.Forms.TextBox textBoxCote;
        private System.Windows.Forms.Button button_recherchercote;
    }
}