namespace gestion_archive
{
    partial class formArchives
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
            this.button_submit = new ReaLTaiizor.Controls.AirButton();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.main_label = new ReaLTaiizor.Controls.BigLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titre_label
            // 
            this.titre_label.AutoSize = true;
            this.titre_label.BackColor = System.Drawing.Color.Transparent;
            this.titre_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_label.ForeColor = System.Drawing.Color.White;
            this.titre_label.Location = new System.Drawing.Point(62, 38);
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
            this.textbox_search.Location = new System.Drawing.Point(73, 97);
            this.textbox_search.MaxLength = 32767;
            this.textbox_search.Multiline = false;
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.ReadOnly = false;
            this.textbox_search.Size = new System.Drawing.Size(340, 42);
            this.textbox_search.TabIndex = 1;
            this.textbox_search.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_search.UseSystemPasswordChar = false;
            // 
            // button_submit
            // 
            this.button_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_submit.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.button_submit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.Image = null;
            this.button_submit.Location = new System.Drawing.Point(172, 159);
            this.button_submit.Name = "button_submit";
            this.button_submit.NoRounding = false;
            this.button_submit.Size = new System.Drawing.Size(128, 32);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Submit";
            this.button_submit.Transparent = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.button_submit);
            this.panel1.Controls.Add(this.textbox_search);
            this.panel1.Controls.Add(this.titre_label);
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(160, 108);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(476, 225);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 3;
            this.panel1.Text = "panel1";
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.BackColor = System.Drawing.Color.Transparent;
            this.main_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.main_label.Location = new System.Drawing.Point(322, 47);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(147, 45);
            this.main_label.TabIndex = 3;
            this.main_label.Text = "Archives";
            // 
            // formArchives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formArchives";
            this.Text = "formArchives";
            this.Load += new System.EventHandler(this.formArchives_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel titre_label;
        private ReaLTaiizor.Controls.BigTextBox textbox_search;
        private ReaLTaiizor.Controls.AirButton button_submit;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.BigLabel main_label;
    }
}