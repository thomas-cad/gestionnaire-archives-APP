namespace gestion_archive
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_menu = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnArchives = new System.Windows.Forms.Panel();
            this.button_archives = new System.Windows.Forms.Button();
            this.toolContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_outils = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_addarchive = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_addemplacement = new System.Windows.Forms.Button();
            this.recolementContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_recolement = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_dorecolement = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_exportrecolement = new System.Windows.Forms.Button();
            this.pnExit = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.toolTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.recolementTransistion = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_menu)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnArchives.SuspendLayout();
            this.toolContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.recolementContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logiciel de gestion d\'archives";
            // 
            // button_menu
            // 
            this.button_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_menu.Image = ((System.Drawing.Image)(resources.GetObject("button_menu.Image")));
            this.button_menu.Location = new System.Drawing.Point(12, 6);
            this.button_menu.Margin = new System.Windows.Forms.Padding(2);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(31, 26);
            this.button_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_menu.TabIndex = 1;
            this.button_menu.TabStop = false;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.sidebar.Controls.Add(this.pnArchives);
            this.sidebar.Controls.Add(this.toolContainer);
            this.sidebar.Controls.Add(this.recolementContainer);
            this.sidebar.Controls.Add(this.pnExit);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 41);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(60, 399);
            this.sidebar.TabIndex = 1;
            // 
            // pnArchives
            // 
            this.pnArchives.Controls.Add(this.button_archives);
            this.pnArchives.Location = new System.Drawing.Point(2, 10);
            this.pnArchives.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.pnArchives.Name = "pnArchives";
            this.pnArchives.Size = new System.Drawing.Size(197, 53);
            this.pnArchives.TabIndex = 3;
            // 
            // button_archives
            // 
            this.button_archives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.button_archives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_archives.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_archives.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_archives.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_archives.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_archives.ForeColor = System.Drawing.Color.White;
            this.button_archives.Image = ((System.Drawing.Image)(resources.GetObject("button_archives.Image")));
            this.button_archives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_archives.Location = new System.Drawing.Point(-4, -17);
            this.button_archives.Margin = new System.Windows.Forms.Padding(2);
            this.button_archives.Name = "button_archives";
            this.button_archives.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_archives.Size = new System.Drawing.Size(220, 84);
            this.button_archives.TabIndex = 2;
            this.button_archives.Text = "Archives";
            this.button_archives.UseVisualStyleBackColor = false;
            this.button_archives.Click += new System.EventHandler(this.button_archives_Click);
            // 
            // toolContainer
            // 
            this.toolContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolContainer.Controls.Add(this.panel4);
            this.toolContainer.Controls.Add(this.panel3);
            this.toolContainer.Controls.Add(this.panel5);
            this.toolContainer.Location = new System.Drawing.Point(2, 75);
            this.toolContainer.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.toolContainer.Name = "toolContainer";
            this.toolContainer.Size = new System.Drawing.Size(197, 53);
            this.toolContainer.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_outils);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 53);
            this.panel4.TabIndex = 5;
            // 
            // button_outils
            // 
            this.button_outils.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.button_outils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_outils.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_outils.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_outils.ForeColor = System.Drawing.Color.White;
            this.button_outils.Image = ((System.Drawing.Image)(resources.GetObject("button_outils.Image")));
            this.button_outils.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_outils.Location = new System.Drawing.Point(-4, -17);
            this.button_outils.Margin = new System.Windows.Forms.Padding(2);
            this.button_outils.Name = "button_outils";
            this.button_outils.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_outils.Size = new System.Drawing.Size(220, 84);
            this.button_outils.TabIndex = 2;
            this.button_outils.Text = "Outils";
            this.button_outils.UseVisualStyleBackColor = false;
            this.button_outils.Click += new System.EventHandler(this.button_outils_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_addarchive);
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 53);
            this.panel3.TabIndex = 6;
            // 
            // button_addarchive
            // 
            this.button_addarchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_addarchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addarchive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addarchive.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addarchive.ForeColor = System.Drawing.Color.White;
            this.button_addarchive.Image = ((System.Drawing.Image)(resources.GetObject("button_addarchive.Image")));
            this.button_addarchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addarchive.Location = new System.Drawing.Point(-4, -17);
            this.button_addarchive.Margin = new System.Windows.Forms.Padding(2);
            this.button_addarchive.Name = "button_addarchive";
            this.button_addarchive.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_addarchive.Size = new System.Drawing.Size(220, 84);
            this.button_addarchive.TabIndex = 2;
            this.button_addarchive.Text = "     Ajouter une archive";
            this.button_addarchive.UseVisualStyleBackColor = false;
            this.button_addarchive.Click += new System.EventHandler(this.button_addarchive_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button_addemplacement);
            this.panel5.Location = new System.Drawing.Point(0, 106);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 53);
            this.panel5.TabIndex = 4;
            // 
            // button_addemplacement
            // 
            this.button_addemplacement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_addemplacement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addemplacement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addemplacement.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addemplacement.ForeColor = System.Drawing.Color.White;
            this.button_addemplacement.Image = ((System.Drawing.Image)(resources.GetObject("button_addemplacement.Image")));
            this.button_addemplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addemplacement.Location = new System.Drawing.Point(-4, -17);
            this.button_addemplacement.Margin = new System.Windows.Forms.Padding(2);
            this.button_addemplacement.Name = "button_addemplacement";
            this.button_addemplacement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_addemplacement.Size = new System.Drawing.Size(220, 84);
            this.button_addemplacement.TabIndex = 2;
            this.button_addemplacement.Text = "         Ajouter un             emplacement";
            this.button_addemplacement.UseVisualStyleBackColor = false;
            this.button_addemplacement.Click += new System.EventHandler(this.button_addemplacement_Click);
            // 
            // recolementContainer
            // 
            this.recolementContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.recolementContainer.Controls.Add(this.panel2);
            this.recolementContainer.Controls.Add(this.panel6);
            this.recolementContainer.Controls.Add(this.panel7);
            this.recolementContainer.Location = new System.Drawing.Point(2, 140);
            this.recolementContainer.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.recolementContainer.Name = "recolementContainer";
            this.recolementContainer.Size = new System.Drawing.Size(197, 53);
            this.recolementContainer.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_recolement);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 53);
            this.panel2.TabIndex = 5;
            // 
            // button_recolement
            // 
            this.button_recolement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.button_recolement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_recolement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_recolement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_recolement.ForeColor = System.Drawing.Color.White;
            this.button_recolement.Image = ((System.Drawing.Image)(resources.GetObject("button_recolement.Image")));
            this.button_recolement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_recolement.Location = new System.Drawing.Point(-4, -17);
            this.button_recolement.Margin = new System.Windows.Forms.Padding(2);
            this.button_recolement.Name = "button_recolement";
            this.button_recolement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_recolement.Size = new System.Drawing.Size(220, 84);
            this.button_recolement.TabIndex = 2;
            this.button_recolement.Text = "Recolement";
            this.button_recolement.UseVisualStyleBackColor = false;
            this.button_recolement.Click += new System.EventHandler(this.button_recolement_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button_dorecolement);
            this.panel6.Location = new System.Drawing.Point(0, 53);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 53);
            this.panel6.TabIndex = 6;
            // 
            // button_dorecolement
            // 
            this.button_dorecolement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_dorecolement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dorecolement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_dorecolement.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dorecolement.ForeColor = System.Drawing.Color.White;
            this.button_dorecolement.Image = ((System.Drawing.Image)(resources.GetObject("button_dorecolement.Image")));
            this.button_dorecolement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dorecolement.Location = new System.Drawing.Point(-4, -17);
            this.button_dorecolement.Margin = new System.Windows.Forms.Padding(2);
            this.button_dorecolement.Name = "button_dorecolement";
            this.button_dorecolement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_dorecolement.Size = new System.Drawing.Size(220, 84);
            this.button_dorecolement.TabIndex = 2;
            this.button_dorecolement.Text = "Recolement";
            this.button_dorecolement.UseVisualStyleBackColor = false;
            this.button_dorecolement.Click += new System.EventHandler(this.button_dorecolement_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button_exportrecolement);
            this.panel7.Location = new System.Drawing.Point(0, 106);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 53);
            this.panel7.TabIndex = 4;
            // 
            // button_exportrecolement
            // 
            this.button_exportrecolement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_exportrecolement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exportrecolement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exportrecolement.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exportrecolement.ForeColor = System.Drawing.Color.White;
            this.button_exportrecolement.Image = ((System.Drawing.Image)(resources.GetObject("button_exportrecolement.Image")));
            this.button_exportrecolement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exportrecolement.Location = new System.Drawing.Point(-4, -17);
            this.button_exportrecolement.Margin = new System.Windows.Forms.Padding(2);
            this.button_exportrecolement.Name = "button_exportrecolement";
            this.button_exportrecolement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_exportrecolement.Size = new System.Drawing.Size(220, 84);
            this.button_exportrecolement.TabIndex = 2;
            this.button_exportrecolement.Text = "              Exporter un                recolement";
            this.button_exportrecolement.UseVisualStyleBackColor = false;
            this.button_exportrecolement.Click += new System.EventHandler(this.button_exportrecolement_Click);
            // 
            // pnExit
            // 
            this.pnExit.Controls.Add(this.button_exit);
            this.pnExit.Location = new System.Drawing.Point(2, 205);
            this.pnExit.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.pnExit.Name = "pnExit";
            this.pnExit.Size = new System.Drawing.Size(197, 53);
            this.pnExit.TabIndex = 8;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(124)))), ((int)(((byte)(162)))));
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exit.Location = new System.Drawing.Point(-4, -17);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_exit.Size = new System.Drawing.Size(220, 84);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Quitter";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // toolTransition
            // 
            this.toolTransition.Interval = 10;
            this.toolTransition.Tick += new System.EventHandler(this.toolTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // recolementTransistion
            // 
            this.recolementTransistion.Interval = 10;
            this.recolementTransistion.Tick += new System.EventHandler(this.recolementTransition_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 440);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive Gestion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_menu)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnArchives.ResumeLayout(false);
            this.toolContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.recolementContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox button_menu;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button button_archives;
        private System.Windows.Forms.Panel pnArchives;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_outils;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_addemplacement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_addarchive;
        private System.Windows.Forms.FlowLayoutPanel toolContainer;
        private System.Windows.Forms.Panel pnExit;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Timer toolTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.FlowLayoutPanel recolementContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_recolement;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_dorecolement;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_exportrecolement;
        private System.Windows.Forms.Timer recolementTransistion;
    }
}