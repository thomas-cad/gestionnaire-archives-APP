﻿using data_base;
using ExportRecolment;
using iText.IO.Image;
using iText.Kernel.Exceptions;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestion_archive
{
    public partial class MainForm : Form
    {
        private formArchives archives; 
        AddArchiveForm outil1;

        public NpgsqlConnection conn;


        public MainForm()
        {
            InitializeComponent();
            //Creation d'un form de log
            LogForm logForm = new LogForm();
            logForm.ShowDialog();
            //Connexion à la BDD
            conn = Data_base.GetDBConnection("systeme_archive");
            try
            {
                conn.Open();            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//Show error message
                this.Close(); //Ferme l'application si la connection echoue
            }
        }

        bool toolExpand = false; 


        private void button_outils_Click(object sender, EventArgs e)
        {
            toolTransition.Start();
        }

        private void toolTransition_Tick(object sender, EventArgs e)
        {
            //Gestion du menu deroulant des outils

            if (toolExpand == false) //Augmenter la taille
            {
                toolContainer.Height += 10;

                if (toolContainer.Height >= 160)
                {
                    toolTransition.Stop();
                    toolExpand = true;
                }
            }
            else //Diminuer la taille
            {
                toolContainer.Height -= 10;
                if (toolContainer.Height <= 60)
                {
                    toolTransition.Stop();
                    toolExpand = false;
                }
            }
        }

        bool sidebarExpand = true; 
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            //Gestion du menu deroulant principal 

            if (sidebarExpand == false) //Diminuer la taille
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 60)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
            else //Augmenter la taille
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 190)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }

            }
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_archives_Click(object sender, EventArgs e)
        {
            // Afficher le form de Archives
            if (archives == null)
            {
                archives = new formArchives();
                archives.FormClosed += Archives_FormClosed; 
                archives.MdiParent = this;
                archives.Dock = DockStyle.Fill;
                archives.Show();
            }
            else
            {
                archives.Activate();
            }
        }

        private void Archives_FormClosed(object sender, FormClosedEventArgs e)
        {
            archives = null;
        }

        private void button_addarchive_Click(object sender, EventArgs e)
        {
            // Afficher le form de Archives
            if (outil1 == null)
            {
                outil1 = new AddArchiveForm(conn);
                outil1.FormClosed += Outil1_FormClosed; ;
                outil1.MdiParent = this;
                outil1.Dock = DockStyle.Fill;
                outil1.Show();
            }
            else
            {
                outil1.Activate();
            }
        }

        private void Outil1_FormClosed(object sender, FormClosedEventArgs e)
        {
            outil1.Activate(); 
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmplacementForm addEmplacementForm = new AddEmplacementForm(conn);
            addEmplacementForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecolementForm recolementForm = new RecolementForm(conn);
            recolementForm.Show();
        }

        //BOUTON TELECHARGEMENT DU RECOLEMENT
        private void button3_Click(object sender, EventArgs e)
        {
            // Crée une instance de ExportRecolement.
            ExportRecolement exportRecolment = new ExportRecolement();

            // Appelle la méthode Download
            exportRecolment.Download(conn);
        }
    }
}