namespace gestion_archive
{
    partial class InfosArchivesForm
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
            this.main_label = new ReaLTaiizor.Controls.BigLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textbox_recherche = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.button_rechercher = new ReaLTaiizor.Controls.AirButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.BackColor = System.Drawing.Color.Transparent;
            this.main_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.ForeColor = System.Drawing.Color.White;
            this.main_label.Location = new System.Drawing.Point(80, 43);
            this.main_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(1235, 86);
            this.main_label.TabIndex = 5;
            this.main_label.Text = "Chercher les informations d\'une archive";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.button_rechercher);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.textbox_recherche);
            this.panel1.Location = new System.Drawing.Point(137, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 415);
            this.panel1.TabIndex = 6;
            // 
            // textbox_recherche
            // 
            this.textbox_recherche.BackColor = System.Drawing.Color.Transparent;
            this.textbox_recherche.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textbox_recherche.ForeColor = System.Drawing.Color.DimGray;
            this.textbox_recherche.Image = null;
            this.textbox_recherche.Location = new System.Drawing.Point(243, 165);
            this.textbox_recherche.MaxLength = 32767;
            this.textbox_recherche.Multiline = false;
            this.textbox_recherche.Name = "textbox_recherche";
            this.textbox_recherche.ReadOnly = false;
            this.textbox_recherche.Size = new System.Drawing.Size(654, 59);
            this.textbox_recherche.TabIndex = 0;
            this.textbox_recherche.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_recherche.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(234, 96);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(313, 50);
            this.bigLabel1.TabIndex = 7;
            this.bigLabel1.Text = "Cote de l\'archive";
            // 
            // button_rechercher
            // 
            this.button_rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_rechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rechercher.Customization = "Hh4e/x4eHv8eHh7/Hh4e/x4eHv8eHh7/Hh4e//////8UFBT/Hh4e/w==";
            this.button_rechercher.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rechercher.Image = null;
            this.button_rechercher.Location = new System.Drawing.Point(321, 264);
            this.button_rechercher.Margin = new System.Windows.Forms.Padding(6);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.NoRounding = false;
            this.button_rechercher.Size = new System.Drawing.Size(501, 62);
            this.button_rechercher.TabIndex = 8;
            this.button_rechercher.Text = "Rechercher";
            this.button_rechercher.Transparent = false;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.main_label);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1348, 671);
            this.panel2.TabIndex = 7;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // InfosArchivesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1397, 716);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfosArchivesForm";
            this.Text = "InfosArchivesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel main_label;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.BigTextBox textbox_recherche;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.AirButton button_rechercher;
        private System.Windows.Forms.Panel panel2;
    }
}