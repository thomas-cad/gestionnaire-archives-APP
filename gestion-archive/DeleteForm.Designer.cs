namespace gestion_archive
{
    partial class DeleteForm
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
            ReaLTaiizor.Controls.BigLabel ArchivesEnCoursTitleLabel;
            this.DeleteDataView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NbDeleteLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AgentComboBox = new System.Windows.Forms.ComboBox();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.NbrArchiveInfoLabel = new System.Windows.Forms.Label();
            this.IdArchiveTextBox = new System.Windows.Forms.TextBox();
            this.AnnulerButton = new System.Windows.Forms.Button();
            this.TerminerButton = new System.Windows.Forms.Button();
            this.AjouterButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ArchiveTitleLabel = new ReaLTaiizor.Controls.BigLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            IdArchiveTitleLabel = new ReaLTaiizor.Controls.BigLabel();
            ArchivesEnCoursTitleLabel = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = System.Drawing.Color.Transparent;
            bigLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            bigLabel1.ForeColor = System.Drawing.Color.White;
            bigLabel1.Location = new System.Drawing.Point(176, 25);
            bigLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new System.Drawing.Size(421, 54);
            bigLabel1.TabIndex = 51;
            bigLabel1.Text = "Archives à supprimer";
            // 
            // IdArchiveTitleLabel
            // 
            IdArchiveTitleLabel.AutoSize = true;
            IdArchiveTitleLabel.BackColor = System.Drawing.Color.Transparent;
            IdArchiveTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IdArchiveTitleLabel.ForeColor = System.Drawing.Color.White;
            IdArchiveTitleLabel.Location = new System.Drawing.Point(6, 100);
            IdArchiveTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            IdArchiveTitleLabel.Name = "IdArchiveTitleLabel";
            IdArchiveTitleLabel.Size = new System.Drawing.Size(172, 45);
            IdArchiveTitleLabel.TabIndex = 75;
            IdArchiveTitleLabel.Text = "Id Archive";
            // 
            // ArchivesEnCoursTitleLabel
            // 
            ArchivesEnCoursTitleLabel.AutoSize = true;
            ArchivesEnCoursTitleLabel.BackColor = System.Drawing.Color.Transparent;
            ArchivesEnCoursTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ArchivesEnCoursTitleLabel.ForeColor = System.Drawing.Color.White;
            ArchivesEnCoursTitleLabel.Location = new System.Drawing.Point(6, 356);
            ArchivesEnCoursTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            ArchivesEnCoursTitleLabel.Name = "ArchivesEnCoursTitleLabel";
            ArchivesEnCoursTitleLabel.Size = new System.Drawing.Size(392, 40);
            ArchivesEnCoursTitleLabel.TabIndex = 80;
            ArchivesEnCoursTitleLabel.Text = "Nombre archives en cours :";
            // 
            // DeleteDataView
            // 
            this.DeleteDataView.AllowUserToAddRows = false;
            this.DeleteDataView.AllowUserToDeleteRows = false;
            this.DeleteDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DeleteDataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.DeleteDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteDataView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteDataView.Location = new System.Drawing.Point(26, 25);
            this.DeleteDataView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeleteDataView.Name = "DeleteDataView";
            this.DeleteDataView.ReadOnly = true;
            this.DeleteDataView.RowHeadersWidth = 82;
            this.DeleteDataView.Size = new System.Drawing.Size(722, 794);
            this.DeleteDataView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.DeleteDataView);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 838);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.NbDeleteLabel);
            this.panel2.Controls.Add(bigLabel1);
            this.panel2.Location = new System.Drawing.Point(822, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 121);
            this.panel2.TabIndex = 4;
            // 
            // NbDeleteLabel
            // 
            this.NbDeleteLabel.AutoSize = true;
            this.NbDeleteLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbDeleteLabel.ForeColor = System.Drawing.Color.White;
            this.NbDeleteLabel.Location = new System.Drawing.Point(114, 25);
            this.NbDeleteLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NbDeleteLabel.Name = "NbDeleteLabel";
            this.NbDeleteLabel.Size = new System.Drawing.Size(49, 54);
            this.NbDeleteLabel.TabIndex = 73;
            this.NbDeleteLabel.Text = "X";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panel3.Controls.Add(this.AgentComboBox);
            this.panel3.Controls.Add(this.bigLabel3);
            this.panel3.Controls.Add(this.NbrArchiveInfoLabel);
            this.panel3.Controls.Add(ArchivesEnCoursTitleLabel);
            this.panel3.Controls.Add(this.IdArchiveTextBox);
            this.panel3.Controls.Add(this.AnnulerButton);
            this.panel3.Controls.Add(this.TerminerButton);
            this.panel3.Controls.Add(this.AjouterButton);
            this.panel3.Controls.Add(IdArchiveTitleLabel);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.ArchiveTitleLabel);
            this.panel3.Location = new System.Drawing.Point(822, 160);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 702);
            this.panel3.TabIndex = 5;
            // 
            // AgentComboBox
            // 
            this.AgentComboBox.FormattingEnabled = true;
            this.AgentComboBox.Location = new System.Drawing.Point(16, 485);
            this.AgentComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgentComboBox.Name = "AgentComboBox";
            this.AgentComboBox.Size = new System.Drawing.Size(354, 33);
            this.AgentComboBox.TabIndex = 83;
            this.AgentComboBox.SelectedIndexChanged += new System.EventHandler(this.AgentComboBox_SelectedIndexChanged);
            this.AgentComboBox.TextChanged += new System.EventHandler(this.AgentComboBox_TextChanged);
            this.AgentComboBox.Click += new System.EventHandler(this.AgentComboBox_Click);
            this.AgentComboBox.Leave += new System.EventHandler(this.AgentComboBox_Leave);
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.White;
            this.bigLabel3.Location = new System.Drawing.Point(6, 419);
            this.bigLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(111, 45);
            this.bigLabel3.TabIndex = 82;
            this.bigLabel3.Text = "Agent";
            // 
            // NbrArchiveInfoLabel
            // 
            this.NbrArchiveInfoLabel.AutoSize = true;
            this.NbrArchiveInfoLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbrArchiveInfoLabel.ForeColor = System.Drawing.Color.White;
            this.NbrArchiveInfoLabel.Location = new System.Drawing.Point(416, 356);
            this.NbrArchiveInfoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NbrArchiveInfoLabel.Name = "NbrArchiveInfoLabel";
            this.NbrArchiveInfoLabel.Size = new System.Drawing.Size(36, 41);
            this.NbrArchiveInfoLabel.TabIndex = 81;
            this.NbrArchiveInfoLabel.Text = "X";
            // 
            // IdArchiveTextBox
            // 
            this.IdArchiveTextBox.Location = new System.Drawing.Point(12, 150);
            this.IdArchiveTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.IdArchiveTextBox.Name = "IdArchiveTextBox";
            this.IdArchiveTextBox.Size = new System.Drawing.Size(396, 31);
            this.IdArchiveTextBox.TabIndex = 79;
            this.IdArchiveTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdArchiveTextBox_KeyDown);
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerButton.Location = new System.Drawing.Point(424, 233);
            this.AnnulerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(244, 75);
            this.AnnulerButton.TabIndex = 78;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.UseVisualStyleBackColor = true;
            this.AnnulerButton.Click += new System.EventHandler(this.AnnulerButton_Click);
            // 
            // TerminerButton
            // 
            this.TerminerButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminerButton.Location = new System.Drawing.Point(272, 587);
            this.TerminerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TerminerButton.Name = "TerminerButton";
            this.TerminerButton.Size = new System.Drawing.Size(244, 75);
            this.TerminerButton.TabIndex = 77;
            this.TerminerButton.Text = "Terminer";
            this.TerminerButton.UseVisualStyleBackColor = true;
            this.TerminerButton.Click += new System.EventHandler(this.TerminerButton_Click);
            // 
            // AjouterButton
            // 
            this.AjouterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterButton.Location = new System.Drawing.Point(424, 150);
            this.AjouterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AjouterButton.Name = "AjouterButton";
            this.AjouterButton.Size = new System.Drawing.Size(244, 75);
            this.AjouterButton.TabIndex = 76;
            this.AjouterButton.Text = "Ajouter";
            this.AjouterButton.UseVisualStyleBackColor = true;
            this.AjouterButton.Click += new System.EventHandler(this.AjouterButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(12, 79);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 8);
            this.panel4.TabIndex = 73;
            // 
            // ArchiveTitleLabel
            // 
            this.ArchiveTitleLabel.AutoSize = true;
            this.ArchiveTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.ArchiveTitleLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchiveTitleLabel.ForeColor = System.Drawing.Color.White;
            this.ArchiveTitleLabel.Location = new System.Drawing.Point(4, 10);
            this.ArchiveTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ArchiveTitleLabel.Name = "ArchiveTitleLabel";
            this.ArchiveTitleLabel.Size = new System.Drawing.Size(206, 50);
            this.ArchiveTitleLabel.TabIndex = 74;
            this.ArchiveTitleLabel.Text = "Supprimer";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 879);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DeleteForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DeleteDataView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label NbDeleteLabel;
        private System.Windows.Forms.TextBox IdArchiveTextBox;
        private System.Windows.Forms.Button AnnulerButton;
        private System.Windows.Forms.Button TerminerButton;
        private System.Windows.Forms.Button AjouterButton;
        private System.Windows.Forms.Panel panel4;
        private ReaLTaiizor.Controls.BigLabel ArchiveTitleLabel;
        private System.Windows.Forms.Label NbrArchiveInfoLabel;
        private System.Windows.Forms.ComboBox AgentComboBox;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
    }
}