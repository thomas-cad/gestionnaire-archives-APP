namespace gestion_archive
{
    partial class EditLieuForm
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
            ReaLTaiizor.Controls.BigLabel bigLabel3;
            ReaLTaiizor.Controls.BigLabel bigLabel2;
            this.ReturnButton = new System.Windows.Forms.Button();
            this.bigLabel8 = new ReaLTaiizor.Controls.BigLabel();
            this.DeleteDataView = new System.Windows.Forms.DataGridView();
            this.AdresseTextBox = new ReaLTaiizor.Controls.BigTextBox();
            this.LieuTextBox = new ReaLTaiizor.Controls.BigTextBox();
            this.Modifier = new System.Windows.Forms.Button();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            bigLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bigLabel3.ForeColor = System.Drawing.Color.White;
            bigLabel3.Location = new System.Drawing.Point(44, 158);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new System.Drawing.Size(69, 21);
            bigLabel3.TabIndex = 116;
            bigLabel3.Text = "Adresse";
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            bigLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bigLabel2.ForeColor = System.Drawing.Color.White;
            bigLabel2.Location = new System.Drawing.Point(45, 89);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new System.Drawing.Size(42, 21);
            bigLabel2.TabIndex = 114;
            bigLabel2.Text = "Lieu";
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnButton.FlatAppearance.BorderSize = 0;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Location = new System.Drawing.Point(12, 9);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(141, 45);
            this.ReturnButton.TabIndex = 113;
            this.ReturnButton.Text = "<-- Retour";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // bigLabel8
            // 
            this.bigLabel8.AutoSize = true;
            this.bigLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.bigLabel8.Location = new System.Drawing.Point(167, 9);
            this.bigLabel8.Name = "bigLabel8";
            this.bigLabel8.Size = new System.Drawing.Size(221, 45);
            this.bigLabel8.TabIndex = 112;
            this.bigLabel8.Text = "Modifier Lieu";
            // 
            // DeleteDataView
            // 
            this.DeleteDataView.AllowUserToAddRows = false;
            this.DeleteDataView.AllowUserToDeleteRows = false;
            this.DeleteDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DeleteDataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.DeleteDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteDataView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteDataView.Location = new System.Drawing.Point(37, 81);
            this.DeleteDataView.Name = "DeleteDataView";
            this.DeleteDataView.ReadOnly = true;
            this.DeleteDataView.RowHeadersWidth = 51;
            this.DeleteDataView.Size = new System.Drawing.Size(461, 213);
            this.DeleteDataView.TabIndex = 111;
            // 
            // AdresseTextBox
            // 
            this.AdresseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.AdresseTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresseTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.AdresseTextBox.Image = null;
            this.AdresseTextBox.Location = new System.Drawing.Point(49, 184);
            this.AdresseTextBox.MaxLength = 32767;
            this.AdresseTextBox.Multiline = false;
            this.AdresseTextBox.Name = "AdresseTextBox";
            this.AdresseTextBox.ReadOnly = false;
            this.AdresseTextBox.Size = new System.Drawing.Size(407, 43);
            this.AdresseTextBox.TabIndex = 117;
            this.AdresseTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.AdresseTextBox.UseSystemPasswordChar = false;
            // 
            // LieuTextBox
            // 
            this.LieuTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.LieuTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LieuTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.LieuTextBox.Image = null;
            this.LieuTextBox.Location = new System.Drawing.Point(50, 115);
            this.LieuTextBox.MaxLength = 32767;
            this.LieuTextBox.Multiline = false;
            this.LieuTextBox.Name = "LieuTextBox";
            this.LieuTextBox.ReadOnly = false;
            this.LieuTextBox.Size = new System.Drawing.Size(406, 43);
            this.LieuTextBox.TabIndex = 115;
            this.LieuTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.LieuTextBox.UseSystemPasswordChar = false;
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.Modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modifier.FlatAppearance.BorderSize = 0;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.Color.White;
            this.Modifier.Location = new System.Drawing.Point(186, 243);
            this.Modifier.Margin = new System.Windows.Forms.Padding(2);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(160, 41);
            this.Modifier.TabIndex = 118;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // EditLieuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 316);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.AdresseTextBox);
            this.Controls.Add(bigLabel3);
            this.Controls.Add(this.LieuTextBox);
            this.Controls.Add(bigLabel2);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.bigLabel8);
            this.Controls.Add(this.DeleteDataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditLieuForm";
            this.Text = "EditLieu";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
        private System.Windows.Forms.DataGridView DeleteDataView;
        private ReaLTaiizor.Controls.BigTextBox AdresseTextBox;
        private ReaLTaiizor.Controls.BigTextBox LieuTextBox;
        private System.Windows.Forms.Button Modifier;
    }
}