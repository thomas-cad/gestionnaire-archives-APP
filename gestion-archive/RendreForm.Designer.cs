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
            this.RendreButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IdArchiveTextBox = new System.Windows.Forms.TextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            IdArchiveTitleLabel = new ReaLTaiizor.Controls.BigLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            bigLabel1.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bigLabel1.ForeColor = System.Drawing.Color.White;
            bigLabel1.Location = new System.Drawing.Point(204, 19);
            bigLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new System.Drawing.Size(510, 71);
            bigLabel1.TabIndex = 52;
            bigLabel1.Text = "Rendre une archive";
            // 
            // IdArchiveTitleLabel
            // 
            IdArchiveTitleLabel.AutoSize = true;
            IdArchiveTitleLabel.BackColor = System.Drawing.Color.Transparent;
            IdArchiveTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IdArchiveTitleLabel.ForeColor = System.Drawing.Color.White;
            IdArchiveTitleLabel.Location = new System.Drawing.Point(220, 152);
            IdArchiveTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            IdArchiveTitleLabel.Name = "IdArchiveTitleLabel";
            IdArchiveTitleLabel.Size = new System.Drawing.Size(172, 45);
            IdArchiveTitleLabel.TabIndex = 80;
            IdArchiveTitleLabel.Text = "Id Archive";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.RendreButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(bigLabel1);
            this.panel1.Controls.Add(this.IdArchiveTextBox);
            this.panel1.Controls.Add(IdArchiveTitleLabel);
            this.panel1.Location = new System.Drawing.Point(66, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 412);
            this.panel1.TabIndex = 0;
            // 
            // RendreButton
            // 
            this.RendreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.RendreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RendreButton.FlatAppearance.BorderSize = 0;
            this.RendreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RendreButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RendreButton.ForeColor = System.Drawing.Color.White;
            this.RendreButton.Location = new System.Drawing.Point(300, 290);
            this.RendreButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RendreButton.Name = "RendreButton";
            this.RendreButton.Size = new System.Drawing.Size(320, 79);
            this.RendreButton.TabIndex = 89;
            this.RendreButton.Text = "Rendre";
            this.RendreButton.UseVisualStyleBackColor = false;
            this.RendreButton.Click += new System.EventHandler(this.RendreButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(36, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 12);
            this.panel2.TabIndex = 86;
            // 
            // IdArchiveTextBox
            // 
            this.IdArchiveTextBox.Location = new System.Drawing.Point(216, 208);
            this.IdArchiveTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.IdArchiveTextBox.Name = "IdArchiveTextBox";
            this.IdArchiveTextBox.Size = new System.Drawing.Size(498, 31);
            this.IdArchiveTextBox.TabIndex = 81;
            this.IdArchiveTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdArchiveTextBox_KeyDown);
            // 
            // RendreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 531);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RendreForm";
            this.Text = "RendreForm";
            this.Load += new System.EventHandler(this.RendreForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IdArchiveTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RendreButton;
    }
}