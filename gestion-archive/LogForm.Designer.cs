namespace gestion_archive
{
    partial class LogForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.Panel_User = new System.Windows.Forms.Panel();
            this.Panel_Password = new System.Windows.Forms.Panel();
            this.Button_LogIn = new System.Windows.Forms.Button();
            this.Label_Exit = new System.Windows.Forms.Label();
            this.TextBox_User = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Icon_Password = new System.Windows.Forms.PictureBox();
            this.Icon_User = new System.Windows.Forms.PictureBox();
            this.Image_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_User
            // 
            this.Panel_User.Location = new System.Drawing.Point(25, 271);
            this.Panel_User.Name = "Panel_User";
            this.Panel_User.Size = new System.Drawing.Size(300, 2);
            this.Panel_User.TabIndex = 3;
            // 
            // Panel_Password
            // 
            this.Panel_Password.Location = new System.Drawing.Point(25, 341);
            this.Panel_Password.Name = "Panel_Password";
            this.Panel_Password.Size = new System.Drawing.Size(300, 2);
            this.Panel_Password.TabIndex = 5;
            // 
            // Button_LogIn
            // 
            this.Button_LogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.Button_LogIn.FlatAppearance.BorderSize = 0;
            this.Button_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_LogIn.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_LogIn.Location = new System.Drawing.Point(25, 374);
            this.Button_LogIn.Name = "Button_LogIn";
            this.Button_LogIn.Size = new System.Drawing.Size(300, 45);
            this.Button_LogIn.TabIndex = 6;
            this.Button_LogIn.Text = "LOG IN";
            this.Button_LogIn.UseVisualStyleBackColor = false;
            this.Button_LogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_Exit
            // 
            this.Label_Exit.AutoSize = true;
            this.Label_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.Label_Exit.Location = new System.Drawing.Point(152, 433);
            this.Label_Exit.Name = "Label_Exit";
            this.Label_Exit.Size = new System.Drawing.Size(48, 25);
            this.Label_Exit.TabIndex = 7;
            this.Label_Exit.Text = "Exit";
            this.Label_Exit.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TextBox_User
            // 
            this.TextBox_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_User.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.TextBox_User.Location = new System.Drawing.Point(77, 222);
            this.TextBox_User.Multiline = true;
            this.TextBox_User.Name = "TextBox_User";
            this.TextBox_User.Size = new System.Drawing.Size(235, 43);
            this.TextBox_User.TabIndex = 8;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Password.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.TextBox_Password.Location = new System.Drawing.Point(77, 292);
            this.TextBox_Password.Multiline = true;
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.Size = new System.Drawing.Size(235, 43);
            this.TextBox_Password.TabIndex = 9;
            // 
            // Icon_Password
            // 
            this.Icon_Password.Image = global::gestion_archive.Properties.Resources.Icon_User;
            this.Icon_Password.Location = new System.Drawing.Point(25, 292);
            this.Icon_Password.Name = "Icon_Password";
            this.Icon_Password.Size = new System.Drawing.Size(45, 43);
            this.Icon_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Password.TabIndex = 4;
            this.Icon_Password.TabStop = false;
            // 
            // Icon_User
            // 
            this.Icon_User.Image = global::gestion_archive.Properties.Resources.Icon_Password;
            this.Icon_User.Location = new System.Drawing.Point(25, 222);
            this.Icon_User.Name = "Icon_User";
            this.Icon_User.Size = new System.Drawing.Size(45, 43);
            this.Icon_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_User.TabIndex = 2;
            this.Icon_User.TabStop = false;
            // 
            // Image_Logo
            // 
            this.Image_Logo.Image = global::gestion_archive.Properties.Resources.Logo_App;
            this.Image_Logo.Location = new System.Drawing.Point(105, 64);
            this.Image_Logo.Name = "Image_Logo";
            this.Image_Logo.Size = new System.Drawing.Size(140, 119);
            this.Image_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_Logo.TabIndex = 0;
            this.Image_Logo.TabStop = false;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(349, 483);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_User);
            this.Controls.Add(this.Label_Exit);
            this.Controls.Add(this.Button_LogIn);
            this.Controls.Add(this.Panel_Password);
            this.Controls.Add(this.Icon_Password);
            this.Controls.Add(this.Panel_User);
            this.Controls.Add(this.Icon_User);
            this.Controls.Add(this.Image_Logo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(112)))), ((int)(((byte)(27)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image_Logo;
        private System.Windows.Forms.PictureBox Icon_User;
        private System.Windows.Forms.Panel Panel_User;
        private System.Windows.Forms.Panel Panel_Password;
        private System.Windows.Forms.PictureBox Icon_Password;
        private System.Windows.Forms.Button Button_LogIn;
        private System.Windows.Forms.Label Label_Exit;
        private System.Windows.Forms.TextBox TextBox_User;
        private System.Windows.Forms.TextBox TextBox_Password;
    }
}

