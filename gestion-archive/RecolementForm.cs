using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_archive
{
    public partial class RecolementForm : Form
    {
        private NpgsqlConnection conn;
        private int id_emplacement;
        private DataTable dt_id_archive = new DataTable();
        private int nbr_archive = 0;
        private bool validate = false; //Autorise le recolement
        
        public RecolementForm(NpgsqlConnection conn_main_form)
        {
            InitializeComponent();
            conn = conn_main_form;
            NbrArchiveInfoLabel.Text = nbr_archive.ToString(); //Affichage de 0 archives actives
            DataColumn dataColumn = new DataColumn("id", typeof(int)); //Cration colonne DataTable
            dt_id_archive.Columns.Add(dataColumn); //Ajout de la colonne
            SuccesPanel.Hide();
            IdEmplacementTextBox.Focus();//Focus dans l'id archive
        }

        /*
         * R : Récupère l'id, verifie son existance
         * E : void
         * E/S : void
         * S : void
         */
        private void IdEmplacement()
        {
            
            try
            {
                //Recupere l'id de l'emplacement
                id_emplacement = int.Parse(IdEmplacementTextBox.Text);

                //Recupere les infos de l'emplacement
                var requete_emplacement = new NpgsqlCommand("SELECT lieu.nom, emplacement.epi, emplacement.etagere, emplacement.tablette FROM emplacement INNER JOIN lieu ON emplacement.id_lieu=lieu.id_lieu WHERE id_emplacement = @id_emplacement;", conn);
                requete_emplacement.Parameters.AddWithValue("@id_emplacement", id_emplacement);

                requete_emplacement.Prepare();

                NpgsqlDataAdapter da_emplacement = new NpgsqlDataAdapter(requete_emplacement); //Craies un data adapter pour recuperer la requete
                DataTable dt_emplacement = new DataTable(); //Creation d'une data table pour stocker la requete
                da_emplacement.Fill(dt_emplacement); //Stocke la requete dans la data table

                if(dt_emplacement.Rows.Count > 0) //Verifie si l'emplacement existe
                {
                    //Affiche les infos de l'emplacement
                    LieuInfoLabel.Text = dt_emplacement.Rows[0][0].ToString();
                    EpiInfoLabel.Text = dt_emplacement.Rows[0][1].ToString();
                    EtagereInfoLabel.Text = dt_emplacement.Rows[0][2].ToString();
                    TabletteInfoLabel.Text = dt_emplacement.Rows[0][3].ToString();

                    //Se place dans l'ajout d'archives
                    IdArchiveTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Emplacement Inconnu", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IdEmplacementTextBox.Focus();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche de l'emplacement : " + ex.Message);
            }
            
        }

        private void NewIdArchive()
        {
            SuccesPanel.Hide();
            try
            {
                DataRow[] existe = dt_id_archive.Select("id = " + int.Parse(IdArchiveTextBox.Text)); //Recherche l'id dans la DataTable

                if(existe.Length == 0) //Verifie que l'id n'a pas déja été saisi
                {
                    var requete_arch_existe = new NpgsqlCommand("SELECT COUNT(*) FROM archive WHERE id_archive = @id_archive", conn);
                    requete_arch_existe.Parameters.AddWithValue("@id_archive", int.Parse(IdArchiveTextBox.Text));

                    if (1 == (long)requete_arch_existe.ExecuteScalar())
                    {
                        try
                        {
                            DataRow newRow = dt_id_archive.NewRow(); //Crée une nouvelle ligne
                            newRow["id"] = int.Parse(IdArchiveTextBox.Text); // Affecte la valeur à la nouvelle ligne
                            dt_id_archive.Rows.Add(newRow); //Ajoute la ligne à la DataTable

                            nbr_archive++; //incrémente le nombre d'archives ajoutées
                            NbrArchiveInfoLabel.Text = nbr_archive.ToString(); //Affiche le nombre d'achives ajoutées

                            IdArchiveTextBox.Text = ""; //Vide la textbox

                            IdArchiveTextBox.Focus(); //remet le focus sur la textbox
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Archive Inconnue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    IdArchiveTextBox.Text = ""; //Vide la textbox
                    IdArchiveTextBox.Focus(); //remet le focus sur la textbox
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vous devez rentrer l'id de l'archive", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ValiderEmplacementButton_Click(object sender, EventArgs e)
        {
            this.IdEmplacement(); //Appelle méthode IdEmplacement L.23
        }

        private void AjouterButton_Click(object sender, EventArgs e)
        {
            NewIdArchive();
        }

        private void SetEmplacement ()
        {
            if (validate == true) //Execution ssi validation autorisée
            {
                try
                {
                    //Supression de l'emplacement des archives précédemment à cet emplacement
                    var delete_emplacement = new NpgsqlCommand("UPDATE archive SET id_emplacement = NULL WHERE id_emplacement = @id_emplacement", conn);
                    delete_emplacement.Parameters.AddWithValue("@id_emplacement", id_emplacement);
                    delete_emplacement.ExecuteNonQuery();

                    //Ajout des nouveaux emplacements
                    var new_emplacement = new NpgsqlCommand("UPDATE archive SET id_emplacement = @id_emplacement WHERE id_archive = @id_archive", conn);

                    foreach (DataRow row in dt_id_archive.Rows)//Parcours les lignes de la datatable
                    {
                        try
                        {
                            Check_Emprunt(int.Parse(row["id"].ToString())); // Vérifie l'emprunt

                            new_emplacement.Parameters.Clear();
                            new_emplacement.Parameters.AddWithValue("@id_emplacement", id_emplacement);
                            new_emplacement.Parameters.AddWithValue("@id_archive", row["id"]);

                            new_emplacement.ExecuteNonQuery(); 
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de l'ajout de l'archive" + row["id"] + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //Clear les variables
                            dt_id_archive.Rows.Clear();
                            nbr_archive = 0;
                            NbrArchiveInfoLabel.Text = nbr_archive.ToString();
                            IdEmplacementTextBox.Text = "";
                            IdArchiveTextBox.Text = "";
                            id_emplacement = -1; 

                            SuccesPanel.Hide();
                        }
                    }

                    //Clear les variables
                    dt_id_archive.Rows.Clear();
                    nbr_archive = 0;
                    NbrArchiveInfoLabel.Text = nbr_archive.ToString();
                    IdEmplacementTextBox.Text = "";
                    IdArchiveTextBox.Text = "";
                    id_emplacement = -1;

                    //Affiche succès opération
                    SuccesPanel.Show();

                    //Retourne à l'emplacement
                    IdEmplacementTextBox.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression des anciens emplacements : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Clear les variables
                    dt_id_archive.Rows.Clear();
                    nbr_archive = 0;
                    NbrArchiveInfoLabel.Text = nbr_archive.ToString();
                    IdEmplacementTextBox.Text = "";
                    IdArchiveTextBox.Text = "";
                    id_emplacement = -1;

                    SuccesPanel.Hide();
                }
            }
            else
            {
                MessageBox.Show("Veuillez rentrer un emplacement valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdEmplacementTextBox.Focus(); //Retourne à la saisie de l'emplacement

                //Clear les variables
                dt_id_archive.Rows.Clear();
                nbr_archive = 0;
                NbrArchiveInfoLabel.Text = nbr_archive.ToString();
                IdEmplacementTextBox.Text = "";
                IdArchiveTextBox.Text = "";
                id_emplacement = -1;

                SuccesPanel.Hide();
            }
        }

        private void TerminerButton_Click(object sender, EventArgs e)
        {
            this.SetEmplacement();
        }

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("L'ensemble des archives sélectionnées ont été supprimées de la selection");
            //Clear les variables
            dt_id_archive.Rows.Clear();
            nbr_archive = 0;
            NbrArchiveInfoLabel.Text = nbr_archive.ToString();
            IdArchiveTextBox.Text = "";
        }

        private void IdEmplacementTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true; // Empêche la saisie de la touche "Entrée"
                this.IdEmplacement();
            }
        }

        private void IdArchiveTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true; // Empêche la saisie de la touche "Entrée"

                if (IdArchiveTextBox.Text == "123456789") //Code de fin de tablette ==> Validation
                {
                    this.SetEmplacement();
                }
                else //SI non on continue
                {
                    this.NewIdArchive();
                }
            }
        }

        private void IdArchiveTextBox_Enter(object sender, EventArgs e)
        {
            try
            {
                var check_emplacement = new NpgsqlCommand("SELECT COUNT (*) FROM emplacement WHERE id_emplacement = @id_emplacement", conn);
                check_emplacement.Parameters.AddWithValue("@id_emplacement", id_emplacement);

                if ((long)check_emplacement.ExecuteScalar() != 1) //Verifie que l'emplacement existe
                {
                    MessageBox.Show("Veuillez rentrer un emplacement valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IdEmplacementTextBox.Focus(); //Retourne à la saisie de l'emplacement
                    validate = false;
                }
                else
                {
                    validate = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Check_Emprunt (int id_archive)
        {
            try
            {
                var check_request = new NpgsqlCommand("SELECT COUNT (*) FROM emprunt WHERE id_archive = @id_archive AND date_retour IS NULL", conn); //Verifie si l'archive est empruntee
                check_request.Parameters.AddWithValue("@id_archive", id_archive);

                if ((long)check_request.ExecuteScalar() == 1)
                {
                    var set_retour = new NpgsqlCommand("UPDATE emprunt SET date_retour = CURRENT_DATE WHERE id_archive = @id_archive AND date_retour IS NULL", conn); //definie le retour
                    set_retour.Parameters.AddWithValue("@id_archive", id_archive);
                    set_retour.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bool Check_destruction (int id_archive)
        {
            bool check = false;

            try
            {
                var check_destruction = new NpgsqlCommand("SELECT COUNT(*) FROM destruction WHERE id_archive = @id_archive", conn);
                check_destruction.Parameters.AddWithValue("@id_archive", id_archive);

                if ((long) check_destruction.ExecuteScalar() == 0)
                {
                    check = true;
                }
                else
                {
                    MessageBox.Show("Archive Detruite", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
