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
            this.panel1 = new System.Windows.Forms.Panel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            bigLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bigLabel3.ForeColor = System.Drawing.Color.White;
            bigLabel3.Location = new System.Drawing.Point(78, 295);
            bigLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new System.Drawing.Size(138, 45);
            bigLabel3.TabIndex = 116;
            bigLabel3.Text = "Adresse";
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            bigLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bigLabel2.ForeColor = System.Drawing.Color.White;
            bigLabel2.Location = new System.Drawing.Point(80, 162);
            bigLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new System.Drawing.Size(81, 45);
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
            this.ReturnButton.Location = new System.Drawing.Point(14, 8);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(282, 87);
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
            this.bigLabel8.Location = new System.Drawing.Point(324, 8);
            this.bigLabel8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel8.Name = "bigLabel8";
            this.bigLabel8.Size = new System.Drawing.Size(441, 86);
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
            this.DeleteDataView.Location = new System.Drawing.Point(64, 147);
            this.DeleteDataView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeleteDataView.Name = "DeleteDataView";
            this.DeleteDataView.ReadOnly = true;
            this.DeleteDataView.RowHeadersWidth = 51;
            this.DeleteDataView.Size = new System.Drawing.Size(922, 410);
            this.DeleteDataView.TabIndex = 111;
            // 
            // AdresseTextBox
            // 
            this.AdresseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.AdresseTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresseTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.AdresseTextBox.Image = null;
            this.AdresseTextBox.Location = new System.Drawing.Point(88, 345);
            this.AdresseTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AdresseTextBox.MaxLength = 32767;
            this.AdresseTextBox.Multiline = false;
            this.AdresseTextBox.Name = "AdresseTextBox";
            this.AdresseTextBox.ReadOnly = false;
            this.AdresseTextBox.Size = new System.Drawing.Size(814, 63);
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
            this.LieuTextBox.Location = new System.Drawing.Point(90, 212);
            this.LieuTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LieuTextBox.MaxLength = 32767;
            this.LieuTextBox.Multiline = false;
            this.LieuTextBox.Name = "LieuTextBox";
            this.LieuTextBox.ReadOnly = false;
            this.LieuTextBox.Size = new System.Drawing.Size(812, 63);
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
            this.Modifier.Location = new System.Drawing.Point(362, 458);
            this.Modifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(320, 79);
            this.Modifier.TabIndex = 118;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.Modifier);
            this.panel1.Controls.Add(this.AdresseTextBox);
            this.panel1.Controls.Add(bigLabel3);
            this.panel1.Controls.Add(this.LieuTextBox);
            this.panel1.Controls.Add(bigLabel2);
            this.panel1.Controls.Add(this.ReturnButton);
            this.panel1.Controls.Add(this.bigLabel8);
            this.panel1.Controls.Add(this.DeleteDataView);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 580);
            this.panel1.TabIndex = 119;
            // 
            // EditLieuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 608);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EditLieuForm";
            this.Text = "EditLieu";
            this.Load += new System.EventHandler(this.EditLieuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
        private System.Windows.Forms.DataGridView DeleteDataView;
        private ReaLTaiizor.Controls.BigTextBox AdresseTextBox;
        private ReaLTaiizor.Controls.BigTextBox LieuTextBox;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Panel panel1;
    }
}