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
            this.button_outil2 = new System.Windows.Forms.Button();
            this.pnExit = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.toolTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_menu)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnArchives.SuspendLayout();
            this.toolContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logiciel de gestion d\'archives";
            // 
            // button_menu
            // 
            this.button_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_menu.Image = ((System.Drawing.Image)(resources.GetObject("button_menu.Image")));
            this.button_menu.Location = new System.Drawing.Point(16, 8);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(41, 32);
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
            this.sidebar.Controls.Add(this.pnExit);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 51);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(80, 533);
            this.sidebar.TabIndex = 1;
            // 
            // pnArchives
            // 
            this.pnArchives.Controls.Add(this.button_archives);
            this.pnArchives.Location = new System.Drawing.Point(3, 12);
            this.pnArchives.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.pnArchives.Name = "pnArchives";
            this.pnArchives.Size = new System.Drawing.Size(263, 65);
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
            this.button_archives.Location = new System.Drawing.Point(-5, -21);
            this.button_archives.Name = "button_archives";
            this.button_archives.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button_archives.Size = new System.Drawing.Size(293, 104);
            this.button_archives.TabIndex = 2;
            this.button_archives.Text = "Archives";
            this.button_archives.UseVisualStyleBackColor = false;
            this.button_archives.Click += new System.EventHandler(this.button_archives_Click);
            // 
            // toolContainer
            // 
            this.toolContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolContainer.Controls.Add(this.panel4);
            this.toolContainer.Controls.Add(this.panel3);
            this.toolContainer.Controls.Add(this.panel5);
            this.toolContainer.Location = new System.Drawing.Point(3, 92);
            this.toolContainer.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.toolContainer.Name = "toolContainer";
            this.toolContainer.Size = new System.Drawing.Size(263, 65);
            this.toolContainer.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_outils);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 65);
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
            this.button_outils.Location = new System.Drawing.Point(-5, -21);
            this.button_outils.Name = "button_outils";
            this.button_outils.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button_outils.Size = new System.Drawing.Size(293, 104);
            this.button_outils.TabIndex = 2;
            this.button_outils.Text = "Outils";
            this.button_outils.UseVisualStyleBackColor = false;
            this.button_outils.Click += new System.EventHandler(this.button_outils_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_addarchive);
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 65);
            this.panel3.TabIndex = 6;
            // 
            // button_addarchive
            // 
            this.button_addarchive.BackColor = System.Drawing.Color.DimGray;
            this.button_addarchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addarchive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addarchive.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addarchive.ForeColor = System.Drawing.Color.White;
            this.button_addarchive.Image = ((System.Drawing.Image)(resources.GetObject("button_addarchive.Image")));
            this.button_addarchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addarchive.Location = new System.Drawing.Point(-5, -21);
            this.button_addarchive.Name = "button_addarchive";
            this.button_addarchive.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button_addarchive.Size = new System.Drawing.Size(293, 104);
            this.button_addarchive.TabIndex = 2;
            this.button_addarchive.Text = "     Ajouter une archive";
            this.button_addarchive.UseVisualStyleBackColor = false;
            this.button_addarchive.Click += new System.EventHandler(this.button_addarchive_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button_outil2);
            this.panel5.Location = new System.Drawing.Point(0, 130);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(263, 65);
            this.panel5.TabIndex = 4;
            // 
            // button_outil2
            // 
            this.button_outil2.BackColor = System.Drawing.Color.DimGray;
            this.button_outil2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_outil2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_outil2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_outil2.ForeColor = System.Drawing.Color.White;
            this.button_outil2.Image = ((System.Drawing.Image)(resources.GetObject("button_outil2.Image")));
            this.button_outil2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_outil2.Location = new System.Drawing.Point(-5, -21);
            this.button_outil2.Name = "button_outil2";
            this.button_outil2.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button_outil2.Size = new System.Drawing.Size(293, 104);
            this.button_outil2.TabIndex = 2;
            this.button_outil2.Text = "Outil2";
            this.button_outil2.UseVisualStyleBackColor = false;
            // 
            // pnExit
            // 
            this.pnExit.Controls.Add(this.button_exit);
            this.pnExit.Location = new System.Drawing.Point(3, 172);
            this.pnExit.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.pnExit.Name = "pnExit";
            this.pnExit.Size = new System.Drawing.Size(263, 65);
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
            this.button_exit.Location = new System.Drawing.Point(-5, -21);
            this.button_exit.Name = "button_exit";
            this.button_exit.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button_exit.Size = new System.Drawing.Size(293, 104);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "AddEmplacement DEV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Recolement DEV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive Gestion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_menu)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnArchives.ResumeLayout(false);
            this.toolContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.Button button_outil2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_addarchive;
        private System.Windows.Forms.FlowLayoutPanel toolContainer;
        private System.Windows.Forms.Panel pnExit;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Timer toolTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}