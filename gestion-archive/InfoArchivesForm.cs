﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using data_base;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using ReaLTaiizor.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestion_archive
{
    public partial class InfoArchivesForm : Form
    {
        private NpgsqlConnection conn;
        int id_archive; 

        SearchArchiveForm archives;
        public InfoArchivesForm(NpgsqlConnection conn_main_form, int id_archive_partage)
        {
            InitializeComponent();

            conn = conn_main_form; //Recupere les informations de la BDD
            id_archive = id_archive_partage; // Recupère l'id_archive du form precedent
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            // Afficher le form de Archives
            if (archives == null)
            {
                archives = new SearchArchiveForm(conn);
                archives.FormClosed += Archives_FormClosed; ; ;
                archives.MdiParent = this.MdiParent;
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
            archives.Activate(); 
        }
        private void ResetValues()
        {
            labelid_archive.Text = string.Empty;
            labelcote.Text = string.Empty;
            labelid_emplacement.Text = string.Empty;
            labelid_service.Text = string.Empty;
            labelid_agent.Text = string.Empty;
            labelmetragelineaire.Text = string.Empty;
            labeldate_archivage.Text = string.Empty;
            labeldate_archive.Text = string.Empty;
            labeltemps_conservation.Text = string.Empty;
            label_description.Text = string.Empty;
            labelemprunt.Text = string.Empty;
            labeldetruit.Text = string.Empty; 
        }

        // Gerer l'affichage des archives
        private void InfoArchivesForm_Load(object sender, EventArgs e)
        {
            ResetValues();

            //Definie le label de archive avec sa valeur
            labelid_archive.Text = id_archive.ToString();

            //Cherche la cote associée a l'archive
            var cmd_cote = new NpgsqlCommand("SELECT cote FROM archive WHERE id_archive = @id_archive", conn);
            cmd_cote.Parameters.AddWithValue("@id_archive", id_archive);
            object resultcote = cmd_cote.ExecuteScalar();
            if (resultcote != DBNull.Value) //Verifie que la valeure n'est pas nulle
            {
                // Assurez-vous de convertir la valeur en string avant de l'assigner au label
                labelcote.Text = resultcote.ToString();
            }
            else
            {
                // Gérer le cas où aucune valeur n'est retournée
                labelcote.Text = "Aucune cote trouvée";
            }

            //Cherche l'emplcement associé a l'archive
            var cmd_emplacement = new NpgsqlCommand("SELECT id_emplacement FROM archive WHERE id_archive = @id_archive", conn);
            cmd_emplacement.Parameters.AddWithValue("@id_archive", id_archive);
            object resultemp = cmd_emplacement.ExecuteScalar();
            if (resultemp != DBNull.Value) //Verifie que la valeure n'est pas nulle
            {
                // Assurez-vous de convertir la valeur en string avant de l'assigner au label
                labelid_emplacement.Text = resultemp.ToString();
            }
            else
            {
                // Gérer le cas où aucune valeur n'est retournée
                labelid_emplacement.Text = "Aucun emplacement trouvé";
            }

            //Cherche le service associé a l'archive
            var cmd_service = new NpgsqlCommand("SELECT id_service FROM archive WHERE id_archive = @id_archive", conn);
            cmd_service.Parameters.AddWithValue("@id_archive", id_archive);
            object resultserv = cmd_service.ExecuteScalar();
            if (resultserv != DBNull.Value) //Verifie que la valeure n'est pas nulle
            {
                // Assurez-vous de convertir la valeur en string avant de l'assigner au label
                labelid_service.Text = resultserv.ToString();
            }
            else
            {
                // Gérer le cas où aucune valeur n'est retournée
                labelid_service.Text = "Aucun service trouvé";
            }

            //Cherche l'agent associé a l'archive
            var cmd_agent = new NpgsqlCommand("SELECT id_agent FROM archive WHERE id_archive = @id_archive", conn);
            cmd_agent.Parameters.AddWithValue("@id_archive", id_archive);
            object resultag = cmd_agent.ExecuteScalar();
            if (resultag != DBNull.Value) //Verifie que la valeure n'est pas nulle
            {
                // On converti la valeur en string avant de l'assigner au label
                labelid_agent.Text = resultag.ToString();
            }
            else
            {
                // Gérer le cas où aucune valeur n'est retournée
                labelid_agent.Text = "Aucun agent trouvé";
            }

            //Cherche le metrage lineaire associé a l'archive
            var cmd_metrage = new NpgsqlCommand("SELECT metrage_lineaire FROM archive WHERE id_archive = @id_archive", conn);
            cmd_metrage.Parameters.AddWithValue("@id_archive", id_archive);
            object resultmet = cmd_metrage.ExecuteScalar();
            if (resultmet != DBNull.Value) //Verifie que la valeure n'est pas nulle
            {
                // On converti la valeur en string avant de l'assigner au label
                labelmetragelineaire.Text = resultmet.ToString();
            }
            else
            {
                // Gérer le cas où aucune valeur n'est retournée
                labelmetragelineaire.Text = "Aucun metrage lineaire trouvé";
            }

            //Cherche la date de l'archive associé a l'archive
            var cmd_datea = new NpgsqlCommand("SELECT date_archive FROM archive WHERE id_archive = @id_archive", conn);
            cmd_datea.Parameters.AddWithValue("@id_archive", id_archive);
            object resultdate = cmd_datea.ExecuteScalar();
            if (resultdate != DBNull.Value) //Verifie que la valeure n'est pas nulle
            {
                // Convertir la valeur en DateTime
                DateTime dateArchivage = Convert.ToDateTime(resultdate);

                //Obtenir uniquement la partie date
                labeldate_archive.Text = dateArchivage.ToShortDateString();
            }
            else
            {
                // Gérer le cas où aucune valeur n'est retournée
                labeldate_archive.Text = "Aucune date trouvée";
            }

            //Cherche la date de l'archivage associé a l'archive
            var cmd_dateb = new NpgsqlCommand("SELECT date_archivage FROM archive WHERE id_archive = @id_archive", conn);
            cmd_dateb.Parameters.AddWithValue("@id_archive", id_archive);
            object resultdatea = cmd_dateb.ExecuteScalar();
            if (resultdatea != DBNull.Value) //Verifie que la valeure n'est pas nulle
            {
                // Convertir la valeur en DateTime
                DateTime dateArchivage = Convert.ToDateTime(resultdatea);

                //Obtenir uniquement la partie date
                labeldate_archivage.Text = dateArchivage.ToShortDateString();
            }
            else
            {
                // Gérer le cas où aucune valeur n'est retournée
                labeldate_archivage.Text = "Aucune date trouvée";
            }

            //Cherche le metrage lineaire associé a l'archive
            var cmd_temps = new NpgsqlCommand("SELECT temps_conservation FROM archive WHERE id_archive = @id_archive", conn);
            cmd_temps.Parameters.AddWithValue("@id_archive", id_archive);
            object resultemps = cmd_temps.ExecuteScalar();
            if (resultemps != DBNull.Value) //Verifie que la valeure n'est pas nulle
            {
                // On converti la valeur en string avant de l'assigner au label
                labeltemps_conservation.Text = resultemps.ToString();
            }
            else
            {
                // Gérer le cas où aucune valeur n'est retournée
                labeltemps_conservation.Text = "Aucun temps de conservation trouvé";
            }

            //Cherche le metrage lineaire associé a l'archive
            var cmd_des = new NpgsqlCommand("SELECT description FROM archive WHERE id_archive = @id_archive", conn);
            cmd_des.Parameters.AddWithValue("@id_archive", id_archive);
            object resultdes = cmd_des.ExecuteScalar();
            if (resultdate != DBNull.Value) //Verifie que la valeure n'est pas nulle
            {
                // On converti la valeur en string avant de l'assigner au label
                label_description.Text = resultdes.ToString();
            }
            else
            {
                // Gérer le cas où aucune valeur n'est retournée
                label_description.Text = "Aucune description trouvée";
            }

            // Verifie si l'archive existe et n'est pas empruntée 
            var check_emprunt = new NpgsqlCommand("SELECT COUNT(*) FROM emprunt WHERE id_archive = @id_archive AND date_retour IS NULL", conn);
            check_emprunt.Parameters.AddWithValue("@id_archive", id_archive);
            if ((long)check_emprunt.ExecuteScalar() > 0)
            {
                labelemprunt.Text = "Oui"; 
            }
            else
            {
                labelemprunt.Text = "Non";
            }
            
           
            var check_destruction = new NpgsqlCommand("SELECT COUNT(*) FROM destruction WHERE id_archive = @id_archive", conn);
            check_destruction.Parameters.AddWithValue("@id_archive", id_archive);
            if ((long)check_destruction.ExecuteScalar() == 0)
            {
                labeldetruit.Text = "Non"; 
            }
            else
            {
                labeldetruit.Text = "Oui";
            }   
        }
        //Gerer la suppression d'une archive
        private void button_supprimer_Click(object sender, EventArgs e)
        {
            // Afficher une boîte de dialogue demandant confirmation
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette archive ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifier la réponse de l'utilisateur
            if (result == DialogResult.Yes)
            {
                var detruire = new NpgsqlCommand("DELETE FROM archive WHERE id_archive = @id_archive", conn);
                detruire.Parameters.AddWithValue("@id_archive", id_archive);
                detruire.ExecuteNonQuery();
                MessageBox.Show("L'archive n°" + id_archive + " a été supprimée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Afficher le form de Archives
                if (archives == null)
                {
                    archives = new SearchArchiveForm(conn);
                    archives.FormClosed += Archives_FormClosed; ; ;
                    archives.MdiParent = this.MdiParent;
                    archives.Dock = DockStyle.Fill;
                    archives.Show();
                }
                else
                {
                    archives.Activate();
                }
            }
        }

        private void labelcote_Click(object sender, EventArgs e)
        {
            // Ouvrir une boîte de dialogue pour saisir une nouvelle valeur
            string nouvelleValeur = Microsoft.VisualBasic.Interaction.InputBox("Entrez la nouvelle valeur :", "Nouvelle valeur", "");

            // Vérifier si une valeur a été saisie
            if (!string.IsNullOrEmpty(nouvelleValeur))
            {
                //Cherche la cote associée a l'archive
                var change = new NpgsqlCommand("UPDATE archive SET cote = @nouvelleValeur WHERE id_archive = @id_archive;", conn);
                change.Parameters.AddWithValue("@id_archive", id_archive);
                change.Parameters.AddWithValue("@nouvelleValeur", nouvelleValeur);
                change.ExecuteNonQuery();
                labelcote.Text = nouvelleValeur;
            }
        }

        private void labelid_emplacement_Click(object sender, EventArgs e)
        {
            // Ouvrir une boîte de dialogue pour saisir une nouvelle valeur
            string nouvelleValeur = Microsoft.VisualBasic.Interaction.InputBox("Entrez la nouvelle valeur :", "Nouvelle valeur", "");

            // Vérifier si une valeur a été saisie
            if (!string.IsNullOrEmpty(nouvelleValeur))
            {
                //Cherche la cote associée a l'archive
                var change = new NpgsqlCommand("UPDATE archive SET id_emplacement = @nouvelleValeur WHERE id_archive = @id_archive;", conn);
                change.Parameters.AddWithValue("@id_archive", id_archive);
                int valeur = int.Parse(nouvelleValeur);
                change.Parameters.AddWithValue("@nouvelleValeur", valeur);
                change.ExecuteNonQuery();
                labelid_emplacement.Text = nouvelleValeur;
            }
        }

        private void labelid_service_Click(object sender, EventArgs e)
        {
            // Ouvrir une boîte de dialogue pour saisir une nouvelle valeur
            string nouvelleValeur = Microsoft.VisualBasic.Interaction.InputBox("Entrez la nouvelle valeur :", "Nouvelle valeur", "");

            // Vérifier si une valeur a été saisie
            if (!string.IsNullOrEmpty(nouvelleValeur))
            {
                //Cherche la cote associée a l'archive
                var change = new NpgsqlCommand("UPDATE archive SET id_service = @nouvelleValeur WHERE id_archive = @id_archive;", conn);
                change.Parameters.AddWithValue("@id_archive", id_archive);
                int valeur = int.Parse(nouvelleValeur);
                change.Parameters.AddWithValue("@nouvelleValeur", valeur);
                change.ExecuteNonQuery();
                labelid_service.Text = nouvelleValeur;
            }
        }

        private void labelid_agent_Click(object sender, EventArgs e)
        {
            // Ouvrir une boîte de dialogue pour saisir une nouvelle valeur
            string nouvelleValeur = Microsoft.VisualBasic.Interaction.InputBox("Entrez la nouvelle valeur :", "Nouvelle valeur", "");

            // Vérifier si une valeur a été saisie
            if (!string.IsNullOrEmpty(nouvelleValeur))
            {
                //Cherche la cote associée a l'archive
                var change = new NpgsqlCommand("UPDATE archive SET id_agent = @nouvelleValeur WHERE id_archive = @id_archive;", conn);
                change.Parameters.AddWithValue("@id_archive", id_archive);
                int valeur = int.Parse(nouvelleValeur);
                change.Parameters.AddWithValue("@nouvelleValeur", valeur);
                change.ExecuteNonQuery();
                labelid_agent.Text = nouvelleValeur;
            }
        }

        private void labelmetragelineaire_Click(object sender, EventArgs e)
        {
            // Ouvrir une boîte de dialogue pour saisir une nouvelle valeur
            string nouvelleValeur = Microsoft.VisualBasic.Interaction.InputBox("Entrez la nouvelle valeur :", "Nouvelle valeur", "");

            // Vérifier si une valeur a été saisie
            if (!string.IsNullOrEmpty(nouvelleValeur))
            {
                //Cherche la cote associée a l'archive
                var change = new NpgsqlCommand("UPDATE archive SET metrage_lineaire = @nouvelleValeur WHERE id_archive = @id_archive;", conn);
                change.Parameters.AddWithValue("@id_archive", id_archive);
                float valeur = float.Parse(nouvelleValeur);
                change.Parameters.AddWithValue("@nouvelleValeur", valeur);
                change.ExecuteNonQuery();
                labelmetragelineaire.Text = nouvelleValeur;
            }
        }

        public class SelectionDateDialog : Form
        {
            private DateTimePicker dateTimePicker;
            private System.Windows.Forms.Button buttonOK;
            private System.Windows.Forms.Button buttonCancel;

            // Propriété pour stocker la date sélectionnée
            public DateTime SelectedDate { get; private set; }

            public SelectionDateDialog()
            {
                InitializeComponent();
                FormBorderStyle = FormBorderStyle.FixedSingle;
            }

            private void InitializeComponent()
            {
                // Créer un DateTimePicker pour sélectionner la date
                dateTimePicker = new DateTimePicker();
                dateTimePicker.Format = DateTimePickerFormat.Short; // Vous pouvez choisir le format de date approprié
                dateTimePicker.Location = new Point(10, 10); // Positionnez le DateTimePicker sur le formulaire

                // Créer un bouton "OK" pour confirmer la sélection
                buttonOK = new System.Windows.Forms.Button();
                buttonOK.Text = "OK";
                buttonOK.DialogResult = DialogResult.OK; // Définir le résultat du bouton sur OK
                buttonOK.Location = new Point(10, 40); // Positionnez le bouton "OK" sur le formulaire
                buttonOK.Click += buttonOK_Click; // Ajoutez un gestionnaire d'événements Click pour le bouton "OK"

                // Créer un bouton "Annuler" pour annuler la sélection
                buttonCancel = new System.Windows.Forms.Button();
                buttonCancel.Text = "Annuler";
                buttonCancel.DialogResult = DialogResult.Cancel; // Définir le résultat du bouton sur Annuler
                buttonCancel.Location = new Point(100, 40); // Positionnez le bouton "Annuler" sur le formulaire
                buttonCancel.Click += buttonCancel_Click; // Ajoutez un gestionnaire d'événements Click pour le bouton "Annuler"

                // Ajoutez les contrôles au formulaire
                Controls.Add(dateTimePicker);
                Controls.Add(buttonOK);
                Controls.Add(buttonCancel);

                // Définissez la taille du formulaire en fonction des contrôles ajoutés
                ClientSize = new Size(200, 100); // Ajustez la taille en conséquence

            }

            private void buttonOK_Click(object sender, EventArgs e)
            {
                SelectedDate = dateTimePicker.Value;
                DialogResult = DialogResult.OK;
                Close();
            }

            private void buttonCancel_Click(object sender, EventArgs e)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void labeldate_archive_Click(object sender, EventArgs e)
        {
            // Créez une instance de la boîte de dialogue personnalisée
            using (SelectionDateDialog dialog = new SelectionDateDialog())
            {
                // Afficher la boîte de dialogue modalement
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Utiliser la date sélectionnée stockée dans la boîte de dialogue
                    DateTime selectedDate = dialog.SelectedDate;

                    //Cherche la cote associée a l'archive
                    var change = new NpgsqlCommand("UPDATE archive SET date_archive = @nouvelleValeur WHERE id_archive = @id_archive;", conn);
                    change.Parameters.AddWithValue("@id_archive", id_archive);
                    change.Parameters.AddWithValue("@nouvelleValeur", selectedDate);
                    change.ExecuteNonQuery();
                    labeldate_archive.Text = selectedDate.ToShortDateString();
                }
            }    
        }

        private void labeldate_archivage_Click(object sender, EventArgs e)
        {
            // Créez une instance de la boîte de dialogue personnalisée
            using (SelectionDateDialog dialog = new SelectionDateDialog())
            {
                // Afficher la boîte de dialogue modalement
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Utiliser la date sélectionnée stockée dans la boîte de dialogue
                    DateTime selectedDate = dialog.SelectedDate;

                    //Cherche la cote associée a l'archive
                    var change = new NpgsqlCommand("UPDATE archive SET date_archivage = @nouvelleValeur WHERE id_archive = @id_archive;", conn);
                    change.Parameters.AddWithValue("@id_archive", id_archive);
                    change.Parameters.AddWithValue("@nouvelleValeur", selectedDate);
                    change.ExecuteNonQuery();
                    labeldate_archivage.Text = selectedDate.ToShortDateString();
                }
            }
        }

        private void labeltemps_conservation_Click(object sender, EventArgs e)
        {
            // Ouvrir une boîte de dialogue pour saisir une nouvelle valeur
            string nouvelleValeur = Microsoft.VisualBasic.Interaction.InputBox("Entrez la nouvelle valeur :", "Nouvelle valeur", "");

            // Vérifier si une valeur a été saisie
            if (!string.IsNullOrEmpty(nouvelleValeur))
            {
                //Cherche la cote associée a l'archive
                var change = new NpgsqlCommand("UPDATE archive SET temps_conservation = @nouvelleValeur WHERE id_archive = @id_archive;", conn);
                change.Parameters.AddWithValue("@id_archive", id_archive);
                int valeur = int.Parse(nouvelleValeur);
                change.Parameters.AddWithValue("@nouvelleValeur", valeur);
                change.ExecuteNonQuery();
                labeltemps_conservation.Text = nouvelleValeur;
            }
        }

        private void label_description_Click(object sender, EventArgs e)
        {
            // Ouvrir une boîte de dialogue pour saisir une nouvelle valeur
            string nouvelleValeur = Microsoft.VisualBasic.Interaction.InputBox("Entrez la nouvelle valeur :", "Nouvelle valeur", "");

            // Vérifier si une valeur a été saisie
            if (!string.IsNullOrEmpty(nouvelleValeur))
            {
                //Cherche la cote associée a l'archive
                var change = new NpgsqlCommand("UPDATE archive SET description = @nouvelleValeur WHERE id_archive = @id_archive;", conn);
                change.Parameters.AddWithValue("@id_archive", id_archive);
                change.Parameters.AddWithValue("@nouvelleValeur", nouvelleValeur);
                change.ExecuteNonQuery();
                labeltemps_conservation.Text = nouvelleValeur;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
