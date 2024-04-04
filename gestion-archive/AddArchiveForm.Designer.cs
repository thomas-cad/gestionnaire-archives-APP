namespace gestion_archive
{
    partial class AddArchiveForm
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
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.AjouterButton = new System.Windows.Forms.Button();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.AgentComboBox = new System.Windows.Forms.ComboBox();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ServiceLabel = new ReaLTaiizor.Controls.BigLabel();
            this.DateArchivage = new System.Windows.Forms.DateTimePicker();
            this.DateArchive = new System.Windows.Forms.DateTimePicker();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.TimeConservTextBox = new ReaLTaiizor.Controls.BigTextBox();
            this.button_tempsconservation = new ReaLTaiizor.Controls.BigLabel();
            this.MlTextBox = new ReaLTaiizor.Controls.BigTextBox();
            this.button_metragelineaire = new ReaLTaiizor.Controls.BigLabel();
            this.button_datearchivage = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.DescriptionTextBox = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.CoteTextBox = new ReaLTaiizor.Controls.BigTextBox();
            this.titre_label = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.BackColor = System.Drawing.Color.Transparent;
            this.main_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.main_label.Location = new System.Drawing.Point(606, 1);
            this.main_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(646, 86);
            this.main_label.TabIndex = 4;
            this.main_label.Text = "Ajouter une archive ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.AjouterButton);
            this.panel1.Controls.Add(this.ServiceComboBox);
            this.panel1.Controls.Add(this.AgentComboBox);
            this.panel1.Controls.Add(this.bigLabel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ServiceLabel);
            this.panel1.Controls.Add(this.DateArchivage);
            this.panel1.Controls.Add(this.DateArchive);
            this.panel1.Controls.Add(this.bigLabel3);
            this.panel1.Controls.Add(this.TimeConservTextBox);
            this.panel1.Controls.Add(this.button_tempsconservation);
            this.panel1.Controls.Add(this.MlTextBox);
            this.panel1.Controls.Add(this.button_metragelineaire);
            this.panel1.Controls.Add(this.button_datearchivage);
            this.panel1.Controls.Add(this.bigLabel2);
            this.panel1.Controls.Add(this.DescriptionTextBox);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.CoteTextBox);
            this.panel1.Controls.Add(this.titre_label);
            this.panel1.Controls.Add(this.bigLabel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.EdgeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(6, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Size = new System.Drawing.Size(1768, 884);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 5;
            this.panel1.Text = "panel1";
            // 
            // AjouterButton
            // 
            this.AjouterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.AjouterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AjouterButton.FlatAppearance.BorderSize = 0;
            this.AjouterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterButton.ForeColor = System.Drawing.Color.White;
            this.AjouterButton.Location = new System.Drawing.Point(672, 784);
            this.AjouterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AjouterButton.Name = "AjouterButton";
            this.AjouterButton.Size = new System.Drawing.Size(400, 86);
            this.AjouterButton.TabIndex = 78;
            this.AjouterButton.Text = "Ajouter";
            this.AjouterButton.UseVisualStyleBackColor = false;
            this.AjouterButton.Click += new System.EventHandler(this.TerminerButton_Click);
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(502, 411);
            this.ServiceComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(354, 33);
            this.ServiceComboBox.TabIndex = 28;
            this.ServiceComboBox.SelectedIndexChanged += new System.EventHandler(this.ServiceComboBox_SelectedIndexChanged);
            this.ServiceComboBox.TextChanged += new System.EventHandler(this.ServiceComboBox_TextChanged);
            this.ServiceComboBox.Click += new System.EventHandler(this.ServiceComboBox_Click);
            this.ServiceComboBox.Leave += new System.EventHandler(this.ServiceComboBox_Leave);
            // 
            // AgentComboBox
            // 
            this.AgentComboBox.FormattingEnabled = true;
            this.AgentComboBox.Location = new System.Drawing.Point(56, 411);
            this.AgentComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AgentComboBox.Name = "AgentComboBox";
            this.AgentComboBox.Size = new System.Drawing.Size(354, 33);
            this.AgentComboBox.TabIndex = 27;
            this.AgentComboBox.SelectedIndexChanged += new System.EventHandler(this.AgentComboBox_SelectedIndexChanged);
            this.AgentComboBox.TextChanged += new System.EventHandler(this.AgentComboBox_TextChanged);
            this.AgentComboBox.Click += new System.EventHandler(this.AgentComboBox_Click);
            this.AgentComboBox.Leave += new System.EventHandler(this.AgentComboBox_Leave);
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel4.ForeColor = System.Drawing.Color.White;
            this.bigLabel4.Location = new System.Drawing.Point(48, 269);
            this.bigLabel4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(442, 50);
            this.bigLabel4.TabIndex = 24;
            this.bigLabel4.Text = "Informations Versement";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(56, 317);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1648, 8);
            this.panel2.TabIndex = 23;
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.ServiceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLabel.ForeColor = System.Drawing.Color.White;
            this.ServiceLabel.Location = new System.Drawing.Point(494, 347);
            this.ServiceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(127, 45);
            this.ServiceLabel.TabIndex = 20;
            this.ServiceLabel.Text = "Service";
            // 
            // DateArchivage
            // 
            this.DateArchivage.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateArchivage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateArchivage.Location = new System.Drawing.Point(922, 664);
            this.DateArchivage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DateArchivage.MaxDate = new System.DateTime(2024, 3, 17, 0, 0, 0, 0);
            this.DateArchivage.Name = "DateArchivage";
            this.DateArchivage.Size = new System.Drawing.Size(464, 44);
            this.DateArchivage.TabIndex = 19;
            this.DateArchivage.Value = new System.DateTime(2024, 3, 17, 0, 0, 0, 0);
            // 
            // DateArchive
            // 
            this.DateArchive.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateArchive.Location = new System.Drawing.Point(922, 398);
            this.DateArchive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DateArchive.MaxDate = new System.DateTime(2024, 3, 22, 0, 0, 0, 0);
            this.DateArchive.Name = "DateArchive";
            this.DateArchive.Size = new System.Drawing.Size(464, 44);
            this.DateArchive.TabIndex = 18;
            this.DateArchive.Value = new System.DateTime(2024, 3, 17, 0, 0, 0, 0);
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.White;
            this.bigLabel3.Location = new System.Drawing.Point(46, 347);
            this.bigLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(111, 45);
            this.bigLabel3.TabIndex = 15;
            this.bigLabel3.Text = "Agent";
            // 
            // TimeConservTextBox
            // 
            this.TimeConservTextBox.BackColor = System.Drawing.Color.Transparent;
            this.TimeConservTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeConservTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.TimeConservTextBox.Image = null;
            this.TimeConservTextBox.Location = new System.Drawing.Point(502, 664);
            this.TimeConservTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TimeConservTextBox.MaxLength = 32767;
            this.TimeConservTextBox.Multiline = false;
            this.TimeConservTextBox.Name = "TimeConservTextBox";
            this.TimeConservTextBox.ReadOnly = false;
            this.TimeConservTextBox.Size = new System.Drawing.Size(356, 63);
            this.TimeConservTextBox.TabIndex = 14;
            this.TimeConservTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TimeConservTextBox.UseSystemPasswordChar = false;
            // 
            // button_tempsconservation
            // 
            this.button_tempsconservation.AutoSize = true;
            this.button_tempsconservation.BackColor = System.Drawing.Color.Transparent;
            this.button_tempsconservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tempsconservation.ForeColor = System.Drawing.Color.White;
            this.button_tempsconservation.Location = new System.Drawing.Point(496, 611);
            this.button_tempsconservation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_tempsconservation.Name = "button_tempsconservation";
            this.button_tempsconservation.Size = new System.Drawing.Size(364, 45);
            this.button_tempsconservation.TabIndex = 13;
            this.button_tempsconservation.Text = "Temps de conservation";
            // 
            // MlTextBox
            // 
            this.MlTextBox.BackColor = System.Drawing.Color.Transparent;
            this.MlTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MlTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.MlTextBox.Image = null;
            this.MlTextBox.Location = new System.Drawing.Point(56, 664);
            this.MlTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MlTextBox.MaxLength = 32767;
            this.MlTextBox.Multiline = false;
            this.MlTextBox.Name = "MlTextBox";
            this.MlTextBox.ReadOnly = false;
            this.MlTextBox.Size = new System.Drawing.Size(356, 63);
            this.MlTextBox.TabIndex = 12;
            this.MlTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.MlTextBox.UseSystemPasswordChar = false;
            // 
            // button_metragelineaire
            // 
            this.button_metragelineaire.AutoSize = true;
            this.button_metragelineaire.BackColor = System.Drawing.Color.Transparent;
            this.button_metragelineaire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_metragelineaire.ForeColor = System.Drawing.Color.White;
            this.button_metragelineaire.Location = new System.Drawing.Point(50, 611);
            this.button_metragelineaire.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_metragelineaire.Name = "button_metragelineaire";
            this.button_metragelineaire.Size = new System.Drawing.Size(266, 45);
            this.button_metragelineaire.TabIndex = 11;
            this.button_metragelineaire.Text = "Metrage linéaire";
            // 
            // button_datearchivage
            // 
            this.button_datearchivage.AutoSize = true;
            this.button_datearchivage.BackColor = System.Drawing.Color.Transparent;
            this.button_datearchivage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_datearchivage.ForeColor = System.Drawing.Color.White;
            this.button_datearchivage.Location = new System.Drawing.Point(916, 347);
            this.button_datearchivage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_datearchivage.Name = "button_datearchivage";
            this.button_datearchivage.Size = new System.Drawing.Size(90, 45);
            this.button_datearchivage.TabIndex = 9;
            this.button_datearchivage.Text = "Date";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.White;
            this.bigLabel2.Location = new System.Drawing.Point(916, 611);
            this.bigLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(243, 45);
            this.bigLabel2.TabIndex = 5;
            this.bigLabel2.Text = "Date archivage";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.DescriptionTextBox.Image = null;
            this.DescriptionTextBox.Location = new System.Drawing.Point(502, 97);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DescriptionTextBox.MaxLength = 32767;
            this.DescriptionTextBox.Multiline = false;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = false;
            this.DescriptionTextBox.Size = new System.Drawing.Size(904, 63);
            this.DescriptionTextBox.TabIndex = 4;
            this.DescriptionTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.DescriptionTextBox.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(496, 44);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(192, 45);
            this.bigLabel1.TabIndex = 3;
            this.bigLabel1.Text = "Description";
            // 
            // CoteTextBox
            // 
            this.CoteTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CoteTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoteTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.CoteTextBox.Image = null;
            this.CoteTextBox.Location = new System.Drawing.Point(56, 97);
            this.CoteTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CoteTextBox.MaxLength = 32767;
            this.CoteTextBox.Multiline = false;
            this.CoteTextBox.Name = "CoteTextBox";
            this.CoteTextBox.ReadOnly = false;
            this.CoteTextBox.Size = new System.Drawing.Size(356, 63);
            this.CoteTextBox.TabIndex = 1;
            this.CoteTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.CoteTextBox.UseSystemPasswordChar = false;
            // 
            // titre_label
            // 
            this.titre_label.AutoSize = true;
            this.titre_label.BackColor = System.Drawing.Color.Transparent;
            this.titre_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_label.ForeColor = System.Drawing.Color.White;
            this.titre_label.Location = new System.Drawing.Point(50, 42);
            this.titre_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titre_label.Name = "titre_label";
            this.titre_label.Size = new System.Drawing.Size(89, 45);
            this.titre_label.TabIndex = 0;
            this.titre_label.Text = "Cote";
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel5.ForeColor = System.Drawing.Color.White;
            this.bigLabel5.Location = new System.Drawing.Point(48, 528);
            this.bigLabel5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(432, 50);
            this.bigLabel5.TabIndex = 26;
            this.bigLabel5.Text = "Informations Archivage";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(56, 577);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1648, 8);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.main_label);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(14, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1786, 1014);
            this.panel4.TabIndex = 6;
            // 
            // AddArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1806, 1069);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddArchiveForm";
            this.Text = "formOutil1";
            this.Load += new System.EventHandler(this.formOutil1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel main_label;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.BigTextBox TimeConservTextBox;
        private ReaLTaiizor.Controls.BigLabel button_tempsconservation;
        private ReaLTaiizor.Controls.BigLabel button_datearchivage;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigTextBox DescriptionTextBox;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigTextBox CoteTextBox;
        private ReaLTaiizor.Controls.BigLabel titre_label;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private System.Windows.Forms.DateTimePicker DateArchive;
        private System.Windows.Forms.DateTimePicker DateArchivage;
        private ReaLTaiizor.Controls.BigTextBox MlTextBox;
        private ReaLTaiizor.Controls.BigLabel button_metragelineaire;
        private ReaLTaiizor.Controls.BigLabel ServiceLabel;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.ComboBox AgentComboBox;
        private System.Windows.Forms.Button AjouterButton;
        private System.Windows.Forms.Panel panel4;
    }
}