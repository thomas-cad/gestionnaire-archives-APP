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
        HistoriqueEmpruntForm historiqueEmprunt;
        ModifierLieuForm modifierLieu;

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

                if (toolContainer.Height >= 265)
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

                if (empruntContainer.Height >= 210)
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
            // Gestion du menu déroulant principal 

            if (sidebarExpand == false) // Si la barre latérale est rétractée
            {
                sidebar.Width -= 10; // Réduire la largeur de la barre latérale
                if (sidebar.Width <= 60) // Si la largeur est réduite à 60 pixels
                {
                    sidebarExpand = true; // Mettre à jour l'état de la barre latérale (étendue)
                    sidebarTransition.Stop(); // Arrêter le timer de transition
                }
            }
            else // Si la barre latérale est étendue
            {
                sidebar.Width += 10; // Augmenter la largeur de la barre latérale
                if (sidebar.Width >= 190) // Si la largeur atteint 190 pixels
                {
                    sidebarExpand = false; // Mettre à jour l'état de la barre latérale (rétractée)
                    sidebarTransition.Stop(); // Arrêter le timer de transition
                }
            }
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start(); // Démarrer le timer de transition lorsqu'un bouton de menu est cliqué
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_archives_Click(object sender, EventArgs e)
        {

            // Vérifie si la variable 'archives' est nulle, ce qui indique que le formulaire des archives n'a pas encore été créé.
            if (archives == null)
            {

                // Créer une nouvelle instance de SearchArchiveForm en lui passant la connexion en tant que paramètre.
                archives = new SearchArchiveForm(conn);

                // Associer un gestionnaire d'événements à l'événement FormClosed du formulaire des archives.
                archives.FormClosed += Archives_FormClosed;

                // Définir le formulaire des archives comme parent MDI (Interface utilisateur multi-document) du formulaire principal.
                archives.MdiParent = this;

                // Remplir toute la zone du formulaire parent.
                archives.Dock = DockStyle.Fill;

                // Afficher le formulaire des archives.
                archives.Show();
            }
            else
            {
                // Si la variable 'archives' n'est pas nulle, cela signifie que le formulaire des archives a déjà été créé.
                // Activer simplement le formulaire des archives pour le mettre au premier plan.
                archives.Activate();
            }
        }

        // Méthode appelée lorsque le formulaire des archives est fermé.
        private void Archives_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Définir la variable 'archives' sur null, indiquant que le formulaire des archives a été fermé.
            archives = null;
        }


        private void button_emplacement_Click(object sender, EventArgs e)
        {
            // Afficher le form de Emplecement
            if (emplacement == null)
            {
                emplacement = new SearchEmplacementForm(conn);
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
            emplacement = null;  
        }

        private void button_addarchive_Click(object sender, EventArgs e)
        {
            // Afficher le form de AddArchives
            if (addArchive == null)
            {
                addArchive = new AddArchiveForm(conn);
                addArchive.FormClosed += AddArchive_FormClosed; ; 
                addArchive.MdiParent = this;
                addArchive.Dock = DockStyle.Fill;
                addArchive.Show();
            }
            else
            {
                addArchive.Activate();
            }
        }

        private void AddArchive_FormClosed(object sender, FormClosedEventArgs e)
        {
            addArchive = null; 
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
            addEmplacement = null; 
        }

        private void button_deletearchive_Click(object sender, EventArgs e)
        {
            // Afficher le form de deleteemplacement
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
            deleteForm = null; 
        }

        private void button_modifierlieu_Click(object sender, EventArgs e)
        {
            // Afficher le form pour modifier un lieu
            if (modifierLieu == null)
            {
                modifierLieu = new ModifierLieuForm(conn);
                modifierLieu.FormClosed += ModifierLieu_FormClosed; ;
                modifierLieu.MdiParent = this;
                modifierLieu.Dock = DockStyle.Fill;
                modifierLieu.Show();
            }
            else
            {
                modifierLieu.Activate();
            }
        }

        private void ModifierLieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            modifierLieu = null;   
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
            recolement = null; 
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
            emprunter = null;
        }

        private void button_rendrearchive_Click(object sender, EventArgs e)
        {
            // Afficher le form pour rendre une archive
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
            rendre = null;
        }

        private void button_historiqueemprunt_Click(object sender, EventArgs e)
        {
            // Afficher le form pour emprunter une archive
            if (historiqueEmprunt == null)
            {
                historiqueEmprunt = new HistoriqueEmpruntForm(conn);
                historiqueEmprunt.FormClosed += HistoriqueEmprunt_FormClosed; ;
                historiqueEmprunt.MdiParent = this;
                historiqueEmprunt.Dock = DockStyle.Fill;
                historiqueEmprunt.Show();
            }
            else
            {
                historiqueEmprunt.Activate();
            }
        }

        private void HistoriqueEmprunt_FormClosed(object sender, FormClosedEventArgs e)
        {
            historiqueEmprunt = null;   
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