namespace gestion_archive
{
    partial class main_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnArchives = new System.Windows.Forms.Panel();
            this.toolContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnExit = new System.Windows.Forms.Panel();
            this.toolTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.button_archives = new System.Windows.Forms.Button();
            this.button_outils = new System.Windows.Forms.Button();
            this.button_outil1 = new System.Windows.Forms.Button();
            this.button_outil2 = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.pnArchives.SuspendLayout();
            this.toolContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 41);
            this.panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(774, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 2;
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
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidebar.Controls.Add(this.pnArchives);
            this.sidebar.Controls.Add(this.toolContainer);
            this.sidebar.Controls.Add(this.pnExit);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 41);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(60, 433);
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
            // toolContainer
            // 
            this.toolContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            // panel3
            // 
            this.panel3.Controls.Add(this.button_outil1);
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 53);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button_outil2);
            this.panel5.Location = new System.Drawing.Point(0, 106);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 53);
            this.panel5.TabIndex = 4;
            // 
            // pnExit
            // 
            this.pnExit.Controls.Add(this.button_exit);
            this.pnExit.Location = new System.Drawing.Point(2, 140);
            this.pnExit.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.pnExit.Name = "pnExit";
            this.pnExit.Size = new System.Drawing.Size(197, 53);
            this.pnExit.TabIndex = 8;
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
            // button_archives
            // 
            this.button_archives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.button_archives.Size = new System.Drawing.Size(220, 85);
            this.button_archives.TabIndex = 2;
            this.button_archives.Text = "Archives";
            this.button_archives.UseVisualStyleBackColor = false;
            this.button_archives.Click += new System.EventHandler(this.button_archives_Click);
            // 
            // button_outils
            // 
            this.button_outils.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.button_outils.Size = new System.Drawing.Size(220, 85);
            this.button_outils.TabIndex = 2;
            this.button_outils.Text = "Outils";
            this.button_outils.UseVisualStyleBackColor = false;
            this.button_outils.Click += new System.EventHandler(this.button_outils_Click);
            // 
            // button_outil1
            // 
            this.button_outil1.BackColor = System.Drawing.Color.DimGray;
            this.button_outil1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_outil1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_outil1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_outil1.ForeColor = System.Drawing.Color.White;
            this.button_outil1.Image = ((System.Drawing.Image)(resources.GetObject("button_outil1.Image")));
            this.button_outil1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_outil1.Location = new System.Drawing.Point(-4, -17);
            this.button_outil1.Margin = new System.Windows.Forms.Padding(2);
            this.button_outil1.Name = "button_outil1";
            this.button_outil1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_outil1.Size = new System.Drawing.Size(220, 85);
            this.button_outil1.TabIndex = 2;
            this.button_outil1.Text = "Outil1";
            this.button_outil1.UseVisualStyleBackColor = false;
            this.button_outil1.Click += new System.EventHandler(this.button_outil1_Click);
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
            this.button_outil2.Location = new System.Drawing.Point(-4, -17);
            this.button_outil2.Margin = new System.Windows.Forms.Padding(2);
            this.button_outil2.Name = "button_outil2";
            this.button_outil2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_outil2.Size = new System.Drawing.Size(220, 85);
            this.button_outil2.TabIndex = 2;
            this.button_outil2.Text = "Outil2";
            this.button_outil2.UseVisualStyleBackColor = false;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.button_exit.Size = new System.Drawing.Size(220, 85);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Quitter";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_menu
            // 
            this.button_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_menu.Image = ((System.Drawing.Image)(resources.GetObject("button_menu.Image")));
            this.button_menu.Location = new System.Drawing.Point(12, 7);
            this.button_menu.Margin = new System.Windows.Forms.Padding(2);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(31, 26);
            this.button_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_menu.TabIndex = 1;
            this.button_menu.TabStop = false;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 474);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.pnArchives.ResumeLayout(false);
            this.toolContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_menu)).EndInit();
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
        private System.Windows.Forms.Button button_outil1;
        private System.Windows.Forms.FlowLayoutPanel toolContainer;
        private System.Windows.Forms.Panel pnExit;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Timer toolTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}