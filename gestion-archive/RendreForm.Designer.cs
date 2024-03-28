namespace gestion_archive
{
    partial class RendreForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdArchiveTextBox = new System.Windows.Forms.TextBox();
            this.TerminerButton = new System.Windows.Forms.Button();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            IdArchiveTitleLabel = new ReaLTaiizor.Controls.BigLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.TerminerButton);
            this.panel1.Controls.Add(this.IdArchiveTextBox);
            this.panel1.Controls.Add(IdArchiveTitleLabel);
            this.panel1.Location = new System.Drawing.Point(313, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 363);
            this.panel1.TabIndex = 0;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            bigLabel1.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bigLabel1.ForeColor = System.Drawing.Color.White;
            bigLabel1.Location = new System.Drawing.Point(519, 188);
            bigLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new System.Drawing.Size(510, 71);
            bigLabel1.TabIndex = 52;
            bigLabel1.Text = "Rendre une archive";
            // 
            // IdArchiveTextBox
            // 
            this.IdArchiveTextBox.Location = new System.Drawing.Point(273, 111);
            this.IdArchiveTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.IdArchiveTextBox.Name = "IdArchiveTextBox";
            this.IdArchiveTextBox.Size = new System.Drawing.Size(396, 31);
            this.IdArchiveTextBox.TabIndex = 81;
            // 
            // IdArchiveTitleLabel
            // 
            IdArchiveTitleLabel.AutoSize = true;
            IdArchiveTitleLabel.BackColor = System.Drawing.Color.Transparent;
            IdArchiveTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IdArchiveTitleLabel.ForeColor = System.Drawing.Color.White;
            IdArchiveTitleLabel.Location = new System.Drawing.Point(267, 61);
            IdArchiveTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            IdArchiveTitleLabel.Name = "IdArchiveTitleLabel";
            IdArchiveTitleLabel.Size = new System.Drawing.Size(172, 45);
            IdArchiveTitleLabel.TabIndex = 80;
            IdArchiveTitleLabel.Text = "Id Archive";
            // 
            // TerminerButton
            // 
            this.TerminerButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminerButton.Location = new System.Drawing.Point(346, 211);
            this.TerminerButton.Margin = new System.Windows.Forms.Padding(4);
            this.TerminerButton.Name = "TerminerButton";
            this.TerminerButton.Size = new System.Drawing.Size(244, 75);
            this.TerminerButton.TabIndex = 82;
            this.TerminerButton.Text = "Terminer";
            this.TerminerButton.UseVisualStyleBackColor = true;
            // 
            // RendreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 923);
            this.Controls.Add(bigLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RendreForm";
            this.Text = "RendreForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IdArchiveTextBox;
        private System.Windows.Forms.Button TerminerButton;
    }
}