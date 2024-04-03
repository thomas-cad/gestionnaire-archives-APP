namespace gestion_archive
{
    partial class AddEpiPopUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.ValiderButton = new System.Windows.Forms.Button();
            this.AnnulerButton = new System.Windows.Forms.Button();
            this.NbrEpiTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectionner le nombre d\'épi à ajouter";
            // 
            // ValiderButton
            // 
            this.ValiderButton.Location = new System.Drawing.Point(212, 92);
            this.ValiderButton.Name = "ValiderButton";
            this.ValiderButton.Size = new System.Drawing.Size(86, 23);
            this.ValiderButton.TabIndex = 1;
            this.ValiderButton.Text = "Valider";
            this.ValiderButton.UseVisualStyleBackColor = true;
            this.ValiderButton.Click += new System.EventHandler(this.ValiderButton_Click);
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.Location = new System.Drawing.Point(98, 92);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(86, 23);
            this.AnnulerButton.TabIndex = 2;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.UseVisualStyleBackColor = true;
            this.AnnulerButton.Click += new System.EventHandler(this.AnnulerButton_Click);
            // 
            // NbrEpiTextBox
            // 
            this.NbrEpiTextBox.Location = new System.Drawing.Point(145, 51);
            this.NbrEpiTextBox.Name = "NbrEpiTextBox";
            this.NbrEpiTextBox.Size = new System.Drawing.Size(100, 20);
            this.NbrEpiTextBox.TabIndex = 3;
            // 
            // AddEpiPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 127);
            this.Controls.Add(this.NbrEpiTextBox);
            this.Controls.Add(this.AnnulerButton);
            this.Controls.Add(this.ValiderButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEpiPopUp";
            this.Text = "Ajouter des épis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ValiderButton;
        private System.Windows.Forms.Button AnnulerButton;
        private System.Windows.Forms.TextBox NbrEpiTextBox;
    }
}