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
            this.ServiceTextBox = new ReaLTaiizor.Controls.BigTextBox();
            this.ServiceDataGridView = new System.Windows.Forms.DataGridView();
            this.ServiceLabel = new ReaLTaiizor.Controls.BigLabel();
            this.DateArchivage = new System.Windows.Forms.DateTimePicker();
            this.DateArchive = new System.Windows.Forms.DateTimePicker();
            this.AgentDataGridView = new System.Windows.Forms.DataGridView();
            this.AgentTextBox = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.bigTextBox6 = new ReaLTaiizor.Controls.BigTextBox();
            this.button_tempsconservation = new ReaLTaiizor.Controls.BigLabel();
            this.bigTextBox5 = new ReaLTaiizor.Controls.BigTextBox();
            this.button_metragelineaire = new ReaLTaiizor.Controls.BigLabel();
            this.button_datearchivage = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.button_description = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.button_submit = new ReaLTaiizor.Controls.AirButton();
            this.button_cote = new ReaLTaiizor.Controls.BigTextBox();
            this.titre_label = new ReaLTaiizor.Controls.BigLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.BackColor = System.Drawing.Color.Transparent;
            this.main_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.main_label.Location = new System.Drawing.Point(332, 18);
            this.main_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(403, 54);
            this.main_label.TabIndex = 4;
            this.main_label.Text = "Ajouter une archive ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.ServiceTextBox);
            this.panel1.Controls.Add(this.ServiceDataGridView);
            this.panel1.Controls.Add(this.ServiceLabel);
            this.panel1.Controls.Add(this.DateArchivage);
            this.panel1.Controls.Add(this.DateArchive);
            this.panel1.Controls.Add(this.AgentDataGridView);
            this.panel1.Controls.Add(this.AgentTextBox);
            this.panel1.Controls.Add(this.bigLabel3);
            this.panel1.Controls.Add(this.bigTextBox6);
            this.panel1.Controls.Add(this.button_tempsconservation);
            this.panel1.Controls.Add(this.bigTextBox5);
            this.panel1.Controls.Add(this.button_metragelineaire);
            this.panel1.Controls.Add(this.button_datearchivage);
            this.panel1.Controls.Add(this.bigLabel2);
            this.panel1.Controls.Add(this.button_description);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.button_submit);
            this.panel1.Controls.Add(this.button_cote);
            this.panel1.Controls.Add(this.titre_label);
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(93, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Size = new System.Drawing.Size(896, 438);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 5;
            this.panel1.Text = "panel1";
            // 
            // ServiceTextBox
            // 
            this.ServiceTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ServiceTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.ServiceTextBox.Image = null;
            this.ServiceTextBox.Location = new System.Drawing.Point(37, 176);
            this.ServiceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceTextBox.MaxLength = 32767;
            this.ServiceTextBox.Multiline = false;
            this.ServiceTextBox.Name = "ServiceTextBox";
            this.ServiceTextBox.ReadOnly = false;
            this.ServiceTextBox.Size = new System.Drawing.Size(237, 48);
            this.ServiceTextBox.TabIndex = 22;
            this.ServiceTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ServiceTextBox.UseSystemPasswordChar = false;
            this.ServiceTextBox.TextChanged += new System.EventHandler(this.ServiceTextBox_TextChanged);
            this.ServiceTextBox.Enter += new System.EventHandler(this.ServiceTextBox_Enter);
            // 
            // ServiceDataGridView
            // 
            this.ServiceDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceDataGridView.Location = new System.Drawing.Point(37, 221);
            this.ServiceDataGridView.Name = "ServiceDataGridView";
            this.ServiceDataGridView.RowHeadersWidth = 51;
            this.ServiceDataGridView.RowTemplate.Height = 24;
            this.ServiceDataGridView.Size = new System.Drawing.Size(551, 105);
            this.ServiceDataGridView.TabIndex = 21;
            this.ServiceDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceDataGridView_CellContentClick);
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.ServiceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLabel.ForeColor = System.Drawing.Color.White;
            this.ServiceLabel.Location = new System.Drawing.Point(32, 143);
            this.ServiceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(81, 28);
            this.ServiceLabel.TabIndex = 20;
            this.ServiceLabel.Text = "Service";
            // 
            // DateArchivage
            // 
            this.DateArchivage.Location = new System.Drawing.Point(334, 176);
            this.DateArchivage.MaxDate = new System.DateTime(2024, 3, 17, 0, 0, 0, 0);
            this.DateArchivage.Name = "DateArchivage";
            this.DateArchivage.Size = new System.Drawing.Size(250, 22);
            this.DateArchivage.TabIndex = 19;
            this.DateArchivage.Value = new System.DateTime(2024, 3, 17, 0, 0, 0, 0);
            // 
            // DateArchive
            // 
            this.DateArchive.Location = new System.Drawing.Point(334, 68);
            this.DateArchive.MaxDate = new System.DateTime(2024, 3, 17, 0, 0, 0, 0);
            this.DateArchive.Name = "DateArchive";
            this.DateArchive.Size = new System.Drawing.Size(250, 22);
            this.DateArchive.TabIndex = 18;
            this.DateArchive.Value = new System.DateTime(2024, 3, 17, 0, 0, 0, 0);
            // 
            // AgentDataGridView
            // 
            this.AgentDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgentDataGridView.Location = new System.Drawing.Point(335, 324);
            this.AgentDataGridView.Name = "AgentDataGridView";
            this.AgentDataGridView.RowHeadersWidth = 51;
            this.AgentDataGridView.RowTemplate.Height = 24;
            this.AgentDataGridView.Size = new System.Drawing.Size(551, 105);
            this.AgentDataGridView.TabIndex = 17;
            this.AgentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgentDataGridView_CellContentClick);
            // 
            // AgentTextBox
            // 
            this.AgentTextBox.BackColor = System.Drawing.Color.Transparent;
            this.AgentTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.AgentTextBox.Image = null;
            this.AgentTextBox.Location = new System.Drawing.Point(335, 278);
            this.AgentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AgentTextBox.MaxLength = 32767;
            this.AgentTextBox.Multiline = false;
            this.AgentTextBox.Name = "AgentTextBox";
            this.AgentTextBox.ReadOnly = false;
            this.AgentTextBox.Size = new System.Drawing.Size(237, 48);
            this.AgentTextBox.TabIndex = 16;
            this.AgentTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.AgentTextBox.UseSystemPasswordChar = false;
            this.AgentTextBox.TextChanged += new System.EventHandler(this.bigTextBox1_TextChanged);
            this.AgentTextBox.Enter += new System.EventHandler(this.bigTextBox1_Enter);
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.White;
            this.bigLabel3.Location = new System.Drawing.Point(329, 245);
            this.bigLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(69, 28);
            this.bigLabel3.TabIndex = 15;
            this.bigLabel3.Text = "Agent";
            // 
            // bigTextBox6
            // 
            this.bigTextBox6.BackColor = System.Drawing.Color.Transparent;
            this.bigTextBox6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigTextBox6.ForeColor = System.Drawing.Color.DimGray;
            this.bigTextBox6.Image = null;
            this.bigTextBox6.Location = new System.Drawing.Point(37, 278);
            this.bigTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.bigTextBox6.MaxLength = 32767;
            this.bigTextBox6.Multiline = false;
            this.bigTextBox6.Name = "bigTextBox6";
            this.bigTextBox6.ReadOnly = false;
            this.bigTextBox6.Size = new System.Drawing.Size(237, 48);
            this.bigTextBox6.TabIndex = 14;
            this.bigTextBox6.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bigTextBox6.UseSystemPasswordChar = false;
            // 
            // button_tempsconservation
            // 
            this.button_tempsconservation.AutoSize = true;
            this.button_tempsconservation.BackColor = System.Drawing.Color.Transparent;
            this.button_tempsconservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tempsconservation.ForeColor = System.Drawing.Color.White;
            this.button_tempsconservation.Location = new System.Drawing.Point(32, 245);
            this.button_tempsconservation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button_tempsconservation.Name = "button_tempsconservation";
            this.button_tempsconservation.Size = new System.Drawing.Size(230, 28);
            this.button_tempsconservation.TabIndex = 13;
            this.button_tempsconservation.Text = "Temps de conservation";
            // 
            // bigTextBox5
            // 
            this.bigTextBox5.BackColor = System.Drawing.Color.Transparent;
            this.bigTextBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigTextBox5.ForeColor = System.Drawing.Color.DimGray;
            this.bigTextBox5.Image = null;
            this.bigTextBox5.Location = new System.Drawing.Point(629, 176);
            this.bigTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.bigTextBox5.MaxLength = 32767;
            this.bigTextBox5.Multiline = false;
            this.bigTextBox5.Name = "bigTextBox5";
            this.bigTextBox5.ReadOnly = false;
            this.bigTextBox5.Size = new System.Drawing.Size(237, 48);
            this.bigTextBox5.TabIndex = 12;
            this.bigTextBox5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bigTextBox5.UseSystemPasswordChar = false;
            // 
            // button_metragelineaire
            // 
            this.button_metragelineaire.AutoSize = true;
            this.button_metragelineaire.BackColor = System.Drawing.Color.Transparent;
            this.button_metragelineaire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_metragelineaire.ForeColor = System.Drawing.Color.White;
            this.button_metragelineaire.Location = new System.Drawing.Point(624, 143);
            this.button_metragelineaire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button_metragelineaire.Name = "button_metragelineaire";
            this.button_metragelineaire.Size = new System.Drawing.Size(169, 28);
            this.button_metragelineaire.TabIndex = 11;
            this.button_metragelineaire.Text = "Metrage linéaire";
            // 
            // button_datearchivage
            // 
            this.button_datearchivage.AutoSize = true;
            this.button_datearchivage.BackColor = System.Drawing.Color.Transparent;
            this.button_datearchivage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_datearchivage.ForeColor = System.Drawing.Color.White;
            this.button_datearchivage.Location = new System.Drawing.Point(329, 143);
            this.button_datearchivage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button_datearchivage.Name = "button_datearchivage";
            this.button_datearchivage.Size = new System.Drawing.Size(155, 28);
            this.button_datearchivage.TabIndex = 9;
            this.button_datearchivage.Text = "Date archivage";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.White;
            this.bigLabel2.Location = new System.Drawing.Point(329, 34);
            this.bigLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(138, 28);
            this.bigLabel2.TabIndex = 5;
            this.bigLabel2.Text = "Date archive ";
            // 
            // button_description
            // 
            this.button_description.BackColor = System.Drawing.Color.Transparent;
            this.button_description.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_description.ForeColor = System.Drawing.Color.DimGray;
            this.button_description.Image = null;
            this.button_description.Location = new System.Drawing.Point(629, 68);
            this.button_description.Margin = new System.Windows.Forms.Padding(4);
            this.button_description.MaxLength = 32767;
            this.button_description.Multiline = false;
            this.button_description.Name = "button_description";
            this.button_description.ReadOnly = false;
            this.button_description.Size = new System.Drawing.Size(237, 48);
            this.button_description.TabIndex = 4;
            this.button_description.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_description.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(624, 35);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(121, 28);
            this.bigLabel1.TabIndex = 3;
            this.bigLabel1.Text = "Description";
            // 
            // button_submit
            // 
            this.button_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_submit.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.button_submit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.Image = null;
            this.button_submit.Location = new System.Drawing.Point(241, 364);
            this.button_submit.Margin = new System.Windows.Forms.Padding(4);
            this.button_submit.Name = "button_submit";
            this.button_submit.NoRounding = false;
            this.button_submit.Size = new System.Drawing.Size(421, 48);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Submit";
            this.button_submit.Transparent = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_cote
            // 
            this.button_cote.BackColor = System.Drawing.Color.Transparent;
            this.button_cote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cote.ForeColor = System.Drawing.Color.DimGray;
            this.button_cote.Image = null;
            this.button_cote.Location = new System.Drawing.Point(37, 68);
            this.button_cote.Margin = new System.Windows.Forms.Padding(4);
            this.button_cote.MaxLength = 32767;
            this.button_cote.Multiline = false;
            this.button_cote.Name = "button_cote";
            this.button_cote.ReadOnly = false;
            this.button_cote.Size = new System.Drawing.Size(237, 48);
            this.button_cote.TabIndex = 1;
            this.button_cote.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_cote.UseSystemPasswordChar = false;
            // 
            // titre_label
            // 
            this.titre_label.AutoSize = true;
            this.titre_label.BackColor = System.Drawing.Color.Transparent;
            this.titre_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_label.ForeColor = System.Drawing.Color.White;
            this.titre_label.Location = new System.Drawing.Point(32, 34);
            this.titre_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titre_label.Name = "titre_label";
            this.titre_label.Size = new System.Drawing.Size(55, 28);
            this.titre_label.TabIndex = 0;
            this.titre_label.Text = "Cote";
            // 
            // AddArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddArchiveForm";
            this.Text = "formOutil1";
            this.Load += new System.EventHandler(this.formOutil1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel main_label;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox6;
        private ReaLTaiizor.Controls.BigLabel button_tempsconservation;
        private ReaLTaiizor.Controls.BigLabel button_datearchivage;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigTextBox button_description;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.AirButton button_submit;
        private ReaLTaiizor.Controls.BigTextBox button_cote;
        private ReaLTaiizor.Controls.BigLabel titre_label;
        private ReaLTaiizor.Controls.BigTextBox AgentTextBox;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private System.Windows.Forms.DataGridView AgentDataGridView;
        private System.Windows.Forms.DateTimePicker DateArchive;
        private System.Windows.Forms.DateTimePicker DateArchivage;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox5;
        private ReaLTaiizor.Controls.BigLabel button_metragelineaire;
        private ReaLTaiizor.Controls.BigTextBox ServiceTextBox;
        private System.Windows.Forms.DataGridView ServiceDataGridView;
        private ReaLTaiizor.Controls.BigLabel ServiceLabel;
    }
}