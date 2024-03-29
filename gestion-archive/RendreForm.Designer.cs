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
            this.boutton_rendre = new System.Windows.Forms.Button();
            this.IdArchiveTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            IdArchiveTitleLabel = new ReaLTaiizor.Controls.BigLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            bigLabel1.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bigLabel1.ForeColor = System.Drawing.Color.White;
            bigLabel1.Location = new System.Drawing.Point(102, 10);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new System.Drawing.Size(262, 37);
            bigLabel1.TabIndex = 52;
            bigLabel1.Text = "Rendre une archive";
            // 
            // IdArchiveTitleLabel
            // 
            IdArchiveTitleLabel.AutoSize = true;
            IdArchiveTitleLabel.BackColor = System.Drawing.Color.Transparent;
            IdArchiveTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IdArchiveTitleLabel.ForeColor = System.Drawing.Color.White;
            IdArchiveTitleLabel.Location = new System.Drawing.Point(132, 79);
            IdArchiveTitleLabel.Name = "IdArchiveTitleLabel";
            IdArchiveTitleLabel.Size = new System.Drawing.Size(87, 21);
            IdArchiveTitleLabel.TabIndex = 80;
            IdArchiveTitleLabel.Text = "Id Archive";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(bigLabel1);
            this.panel1.Controls.Add(this.boutton_rendre);
            this.panel1.Controls.Add(this.IdArchiveTextBox);
            this.panel1.Controls.Add(IdArchiveTitleLabel);
            this.panel1.Location = new System.Drawing.Point(33, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 214);
            this.panel1.TabIndex = 0;
            // 
            // boutton_rendre
            // 
            this.boutton_rendre.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutton_rendre.Location = new System.Drawing.Point(173, 146);
            this.boutton_rendre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boutton_rendre.Name = "boutton_rendre";
            this.boutton_rendre.Size = new System.Drawing.Size(122, 39);
            this.boutton_rendre.TabIndex = 82;
            this.boutton_rendre.Text = "Rendre";
            this.boutton_rendre.UseVisualStyleBackColor = true;
            // 
            // IdArchiveTextBox
            // 
            this.IdArchiveTextBox.Location = new System.Drawing.Point(134, 105);
            this.IdArchiveTextBox.Name = "IdArchiveTextBox";
            this.IdArchiveTextBox.Size = new System.Drawing.Size(200, 20);
            this.IdArchiveTextBox.TabIndex = 81;
            this.IdArchiveTextBox.TextChanged += new System.EventHandler(this.IdArchiveTextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(18, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 11);
            this.panel2.TabIndex = 86;
            // 
            // RendreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 276);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RendreForm";
            this.Text = "RendreForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IdArchiveTextBox;
        private System.Windows.Forms.Button boutton_rendre;
        private System.Windows.Forms.Panel panel2;
    }
}