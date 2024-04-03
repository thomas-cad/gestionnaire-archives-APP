using data_base;
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
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestion_archive
{
    public partial class MainForm : Form
    {
        SearchArchiveForm archives; 
        SearchEmplacementForm emplacement;
        AddArchiveForm addArchive;
        AddEmplacementForm addEmplacement;
        RecolementForm recolement;
        DeleteForm deleteForm;
        EmpruntForm emprunter;
        RendreForm rendre;

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

                if (toolContainer.Height >= 212)
                {
                    toolTransition.Stop();
                    toolExpand = true;
                }
            }
            else //Diminuer la taille
            {
                toolContainer.Height -= 10;
                if (toolContainer.Height <= 53)
                {
                    toolTransition.Stop();
                    toolExpand = false;
                }
            }
        }

        bool recolementExpand = false;

        private void button_recolement_Click(object sender, EventArgs e)
        {
            recolementTransistion.Start();
        }
        private void recolementTransition_Tick(object sender, EventArgs e)
        {
            //Gestion du menu deroulant du recolement

            if (recolementExpand == false) //Augmenter la taille
            {
                recolementContainer.Height += 10;

                if (recolementContainer.Height >= 160)
                {
                    recolementTransistion.Stop();
                    recolementExpand = true;
                }
            }
            else //Diminuer la taille
            {
                recolementContainer.Height -= 10;
                if (recolementContainer.Height <= 53)
                {
                    recolementTransistion.Stop(); 
                    recolementExpand = false;
                }
            }
        }
        bool empruntExpand; 
        private void empruntTransition_Tick(object sender, EventArgs e)
        {
            //Gestion du menu deroulant de emprunt

            if (empruntExpand == false) //Augmenter la taille
            {
                empruntContainer.Height += 10;

                if (empruntContainer.Height >= 160)
                {
                    empruntTransition.Stop();
                    empruntExpand = true;
                }
            }
            else //Diminuer la taille
            {
                empruntContainer.Height -= 10;
                if (empruntContainer.Height <= 53)
                {
                    empruntTransition.Stop();
                    empruntExpand = false;
                }
            }
        }

        private void button_emprunt_Click(object sender, EventArgs e)
        {
            empruntTransition.Start();
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
                archives = new SearchArchiveForm(conn);
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

        private void button_emplacement_Click(object sender, EventArgs e)
        {
            // Afficher le form de Emplecement
            if (emplacement == null)
            {
                emplacement = new SearchEmplacementForm();
                emplacement.FormClosed += Emplacement_FormClosed; ;
                emplacement.MdiParent = this;
                emplacement.Dock = DockStyle.Fill;
                emplacement.Show();
            }
            else
            {
                emplacement.Activate();
            }
        }

        private void Emplacement_FormClosed(object sender, FormClosedEventArgs e)
        {
            emplacement.Activate(); 
        }

        private void button_addarchive_Click(object sender, EventArgs e)
        {
            // Afficher le form de Archives
            if (addArchive == null)
            {
                addArchive = new AddArchiveForm(conn);
                addArchive.FormClosed += Outil1_FormClosed; 
                addArchive.MdiParent = this;
                addArchive.Dock = DockStyle.Fill;
                addArchive.Show();
            }
            else
            {
                addArchive.Activate();
            }
        }

        private void Outil1_FormClosed(object sender, FormClosedEventArgs e)
        {
            addArchive.Activate(); 
        }

        private void button_addemplacement_Click(object sender, EventArgs e)
        {
            // Afficher le form de addEmplacement
            if (addEmplacement == null)
            {
                addEmplacement = new AddEmplacementForm(conn);
                addEmplacement.FormClosed += AddEmplacement_FormClosed; ;
                addEmplacement.MdiParent = this;
                addEmplacement.Dock = DockStyle.Fill;
                addEmplacement.Show();
            }
            else
            {
                addEmplacement.Activate();
            }
        }

        private void AddEmplacement_FormClosed(object sender, FormClosedEventArgs e)
        {
            addEmplacement.Activate(); 
        }

        private void button_deletearchive_Click(object sender, EventArgs e)
        {
            // Afficher le form de addEmplacement
            if (deleteForm == null)
            {
                deleteForm = new DeleteForm(conn);
                deleteForm.FormClosed += DeleteRecolement_FormClosed;
                deleteForm.MdiParent = this;
                deleteForm.Dock = DockStyle.Fill;
                deleteForm.Show();
            }
            else
            {
                deleteForm.Activate();
            }
        }

        private void DeleteRecolement_FormClosed(object sender, FormClosedEventArgs e)
        {
            deleteForm.Activate();  
        }

        private void button_dorecolement_Click(object sender, EventArgs e)
        {
            // Afficher le form du recolement
            if (recolement == null)
            {
                recolement = new RecolementForm(conn);
                recolement.FormClosed += Recolement_FormClosed; 
                recolement.MdiParent = this;
                recolement.Dock = DockStyle.Fill;
                recolement.Show();
            }
            else
            {
                recolement.Activate();
            }
        }

        private void Recolement_FormClosed(object sender, FormClosedEventArgs e)
        {
            recolement.Activate();
        }

        private void button_emprunterarchive_Click(object sender, EventArgs e)
        {
            // Afficher le form du recolement
            if (emprunter == null)
            {
                emprunter = new EmpruntForm(conn);
                emprunter.FormClosed += Emprunter_FormClosed;
                emprunter.MdiParent = this;
                emprunter.Dock = DockStyle.Fill;
                emprunter.Show();
            }
            else
            {
                emprunter.Activate();
            }
        }

        private void Emprunter_FormClosed(object sender, FormClosedEventArgs e)
        {
            emprunter.Activate();
        }

        private void button_rendrearchive_Click(object sender, EventArgs e)
        {
            // Afficher le form du recolement
            if (rendre == null)
            {
                rendre = new RendreForm(conn);
                rendre.FormClosed += Rendre_FormClosed; ;
                rendre.MdiParent = this;
                rendre.Dock = DockStyle.Fill;
                rendre.Show();
            }
            else
            {
                rendre.Activate();
            }
        }

        private void Rendre_FormClosed(object sender, FormClosedEventArgs e)
        {
            rendre.Activate(); 
        }


        //BOUTON TELECHARGEMENT DU RECOLEMENT
        private void button_exportrecolement_Click(object sender, EventArgs e)
        {
            // Crée une instance de ExportRecolement.
            ExportRecolement exportRecolment = new ExportRecolement();

            // Appelle la méthode Download
            exportRecolment.Download(conn);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Afficher le form de Archives
            if (archives == null)
            {
                archives = new SearchArchiveForm(conn);
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
    }
}