namespace gestion_archive
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label_LogIn = new System.Windows.Forms.Label();
            this.Panel_User = new System.Windows.Forms.Panel();
            this.Panel_Password = new System.Windows.Forms.Panel();
            this.Icon_Password = new System.Windows.Forms.PictureBox();
            this.Icon_User = new System.Windows.Forms.PictureBox();
            this.Image_Logo = new System.Windows.Forms.PictureBox();
            this.Button_LogIn = new System.Windows.Forms.Button();
            this.Label_Exit = new System.Windows.Forms.Label();
            this.TextBox_User = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_LogIn
            // 
            this.Label_LogIn.AutoSize = true;
            this.Label_LogIn.BackColor = System.Drawing.SystemColors.Control;
            this.Label_LogIn.Font = new System.Drawing.Font("Bauhaus 93", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.Label_LogIn.Location = new System.Drawing.Point(159, 233);
            this.Label_LogIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_LogIn.Name = "Label_LogIn";
            this.Label_LogIn.Size = new System.Drawing.Size(212, 78);
            this.Label_LogIn.TabIndex = 1;
            this.Label_LogIn.Text = "Log In";
            this.Label_LogIn.Click += new System.EventHandler(this.label1_Click);
            // 
            // Panel_User
            // 
            this.Panel_User.Location = new System.Drawing.Point(38, 423);
            this.Panel_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel_User.Name = "Panel_User";
            this.Panel_User.Size = new System.Drawing.Size(450, 3);
            this.Panel_User.TabIndex = 3;
            // 
            // Panel_Password
            // 
            this.Panel_Password.Location = new System.Drawing.Point(38, 533);
            this.Panel_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel_Password.Name = "Panel_Password";
            this.Panel_Password.Size = new System.Drawing.Size(450, 3);
            this.Panel_Password.TabIndex = 5;
            // 
            // Icon_Password
            // 
            this.Icon_Password.Image = global::gestion_archive.Properties.Resources.Icon_User;
            this.Icon_Password.Location = new System.Drawing.Point(38, 456);
            this.Icon_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Icon_Password.Name = "Icon_Password";
            this.Icon_Password.Size = new System.Drawing.Size(68, 67);
            this.Icon_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Password.TabIndex = 4;
            this.Icon_Password.TabStop = false;
            // 
            // Icon_User
            // 
            this.Icon_User.Image = global::gestion_archive.Properties.Resources.Icon_Password;
            this.Icon_User.Location = new System.Drawing.Point(38, 347);
            this.Icon_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Icon_User.Name = "Icon_User";
            this.Icon_User.Size = new System.Drawing.Size(68, 67);
            this.Icon_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_User.TabIndex = 2;
            this.Icon_User.TabStop = false;
            // 
            // Image_Logo
            // 
            this.Image_Logo.Image = global::gestion_archive.Properties.Resources.Logo_App;
            this.Image_Logo.Location = new System.Drawing.Point(158, 19);
            this.Image_Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Image_Logo.Name = "Image_Logo";
            this.Image_Logo.Size = new System.Drawing.Size(210, 186);
            this.Image_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_Logo.TabIndex = 0;
            this.Image_Logo.TabStop = false;
            // 
            // Button_LogIn
            // 
            this.Button_LogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.Button_LogIn.FlatAppearance.BorderSize = 0;
            this.Button_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_LogIn.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_LogIn.Location = new System.Drawing.Point(38, 584);
            this.Button_LogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_LogIn.Name = "Button_LogIn";
            this.Button_LogIn.Size = new System.Drawing.Size(450, 70);
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
            this.Label_Exit.Location = new System.Drawing.Point(228, 677);
            this.Label_Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Exit.Name = "Label_Exit";
            this.Label_Exit.Size = new System.Drawing.Size(73, 37);
            this.Label_Exit.TabIndex = 7;
            this.Label_Exit.Text = "Exit";
            this.Label_Exit.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TextBox_User
            // 
            this.TextBox_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_User.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.TextBox_User.Location = new System.Drawing.Point(116, 347);
            this.TextBox_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_User.Multiline = true;
            this.TextBox_User.Name = "TextBox_User";
            this.TextBox_User.Size = new System.Drawing.Size(352, 67);
            this.TextBox_User.TabIndex = 8;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Password.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.TextBox_Password.Location = new System.Drawing.Point(116, 456);
            this.TextBox_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_Password.Multiline = true;
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.Size = new System.Drawing.Size(352, 67);
            this.TextBox_Password.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(524, 754);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_User);
            this.Controls.Add(this.Label_Exit);
            this.Controls.Add(this.Button_LogIn);
            this.Controls.Add(this.Panel_Password);
            this.Controls.Add(this.Icon_Password);
            this.Controls.Add(this.Panel_User);
            this.Controls.Add(this.Icon_User);
            this.Controls.Add(this.Label_LogIn);
            this.Controls.Add(this.Image_Logo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(112)))), ((int)(((byte)(27)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
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
        private System.Windows.Forms.Label Label_LogIn;
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

