using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace gestion_archive
{
    public partial class DeleteForm : Form
    {
        private NpgsqlConnection conn;
        private DataTable dt_delete = new DataTable();
        private DataTable dt_id_archive = new DataTable();
        private int nbr_archive = 0;
        private int id_agent = -1;
        public DeleteForm(NpgsqlConnection conn_main)
        {
            InitializeComponent();
            conn = conn_main;

            Update_delete_table();
            MajAgent();

            NbrArchiveInfoLabel.Text = nbr_archive.ToString(); //Affichage de 0 archives actives

            DataColumn dataColumn = new DataColumn("id", typeof(int)); //Cration colonne DataTable
            dt_id_archive.Columns.Add(dataColumn); //Ajout de la colonne

            IdArchiveTextBox.Focus();//Focus dans l'id archive
        }
        
        private void Update_delete_table()
        {
            try
            {
                var requete_delete_archive = new NpgsqlCommand(@"
                    SELECT 
                    archive.cote, 
                    archive.id_archive, 
                    emplacement.id_emplacement, 
                    lieu.nom AS lieu,
                    emplacement.epi, 
                    emplacement.etagere, 
                    emplacement.tablette

                    FROM archive

                    LEFT JOIN emplacement ON archive.id_emplacement = emplacement.id_emplacement --Jointure externe gauche
                    LEFT JOIN lieu ON emplacement.id_lieu = lieu.id_lieu --Jointure externe gauche

                    WHERE 
	                    archive.date_archivage + archive.temps_conservation * INTERVAL '1 year' <= CURRENT_DATE
                        AND
                        archive.id_archive NOT IN (SELECT id_archive FROM destruction);
                ", conn);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(requete_delete_archive); //Craies un data adapter pour recuperer la requete
                da.Fill(dt_delete); //Stocke la requete dans la data table
                
                //Vide data table grid view
                DeleteDataView.DataSource = null;
                DeleteDataView.Rows.Clear();

                //Remplie data table grid view
                DeleteDataView.DataSource = dt_delete;

                NbDeleteLabel.Text = dt_delete.Rows.Count.ToString(); //MAJ nb Rows DELETE
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur maj DB : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void NewIdArchive()
        {
            try
            {
                DataRow[] existe = dt_id_archive.Select("id = " + int.Parse(IdArchiveTextBox.Text)); //Recherche l'id dans la DataTable

                if (existe.Length == 0) //Verifie que l'id n'a pas déja été saisi
                {
                    var requete_arch_existe = new NpgsqlCommand("SELECT COUNT(*) FROM archive WHERE id_archive = @id_archive", conn);
                    requete_arch_existe.Parameters.AddWithValue("@id_archive", int.Parse(IdArchiveTextBox.Text));

                    if (1 == (long)requete_arch_existe.ExecuteScalar())
                    {
                        var requete_arch_supp = new NpgsqlCommand("SELECT COUNT(*) FROM destruction WHERE id_archive = @id_archive", conn);
                        requete_arch_supp.Parameters.AddWithValue("@id_archive", int.Parse(IdArchiveTextBox.Text));

                        if (0 == (long)requete_arch_supp.ExecuteScalar()) //Archive non supprimée
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
                            MessageBox.Show("Archive deja supprimée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Archive Inconnue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        IdArchiveTextBox.Text = ""; //Vide la textbox
                        IdArchiveTextBox.Focus(); //remet le focus sur la textbox
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

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("L'ensemble des archives sélectionnées ont été supprimées de la selection");
            //Clear les variables
            dt_id_archive.Rows.Clear();
            nbr_archive = 0;
            NbrArchiveInfoLabel.Text = nbr_archive.ToString();
            IdArchiveTextBox.Text = "";
        }



        private void AjouterButton_Click(object sender, EventArgs e)
        {
            this.NewIdArchive();
        }

        private void MajAgent()
        {
            //Requete Recherche agent
            NpgsqlCommand agent_requete = new NpgsqlCommand("SELECT nom, prenom, id_agent FROM agent", conn);

            //Prepare la requete
            agent_requete.Prepare();

            //Recuperation requete
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(agent_requete); //Craies un data adapter pour recuperer la requete
            DataTable dt = new DataTable(); //Creation d'une data table pour stocker la requete
            da.Fill(dt); //Stocke la requete dans la data table

            foreach (DataRow row in dt.Rows)
            {
                AgentComboBox.Items.Add(row[1].ToString() + " " + row[0].ToString() + " : " + row[2].ToString());
            }
        }

        private void TerminerButton_Click(object sender, EventArgs e)
        {
            if (id_agent != -1) //Verifie si l'id est correcte
            {
                try
                {
                    var new_destruction = new NpgsqlCommand(@"
                        UPDATE archive SET id_emplacement = NULL WHERE id_archive = @id_archive;
                        INSERT INTO destruction (id_archive, id_agent, date) VALUES (@id_archive, @id_agent, CURRENT_DATE)", conn);

                    foreach (DataRow row in dt_id_archive.Rows)
                    {
                        new_destruction.Parameters.Clear();
                        new_destruction.Parameters.AddWithValue("@id_agent", id_agent);
                        new_destruction.Parameters.AddWithValue("@id_archive", row["id"]);

                        new_destruction.ExecuteNonQuery();
                    }

                    MessageBox.Show("Destrction réussie");
                    Update_delete_table();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Agent inconnu", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AgentComboBox_Leave(object sender, EventArgs e)
        {
            if (id_agent == -1)
            {
                MessageBox.Show("L'agent saisi est invalide", "Invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AgentComboBox.Focus();
            }
            else
            {
                if (AgentComboBox.DroppedDown == true)
                {
                    AgentComboBox.DroppedDown = false;
                }
            }
        }

        private void AgentComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] split = AgentComboBox.Text.Split(new string[] { " : " }, StringSplitOptions.None); //Recupere la fin de l'item contenant l'id
                int id_check = int.Parse(split[1]);
                NpgsqlCommand check_id = new NpgsqlCommand("SELECT COUNT(*) FROM agent WHERE id_agent = @id_check", conn);
                check_id.Parameters.AddWithValue("@id_check", id_check);

                if ((long)check_id.ExecuteScalar() == 1)
                {
                    id_agent = id_check; //Desafecte l'id de l'agent
                }
                else
                {
                    id_agent = -1; //Desafecte l'id de l'agent
                }
            }
            catch
            {
                id_agent = -1; //Desafecte l'id de l'agent
            }
        }

        private void AgentComboBox_Click(object sender, EventArgs e)
        {
            if (AgentComboBox.DroppedDown == false)
            {
                AgentComboBox.DroppedDown = true;
            }
        }

        private void AgentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] split = AgentComboBox.SelectedItem.ToString().Split(new string[] { " : " }, StringSplitOptions.None); //Recupere la fin de l'item contenant l'id
                int id_check = int.Parse(split[1]);
                NpgsqlCommand check_id = new NpgsqlCommand("SELECT COUNT(*) FROM agent WHERE id_agent = @id_check", conn);
                check_id.Parameters.AddWithValue("@id_check", id_check);

                if ((long)check_id.ExecuteScalar() == 1)
                {
                    id_agent = id_check; //Desafecte l'id de l'agent
                }
                else
                {
                    id_agent = -1; //Desafecte l'id de l'agent
                }
            }
            catch
            {
                id_agent = -1; //Desafecte l'id de l'agent
            }
        }

        private void IdArchiveTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true; // Empêche la saisie de la touche "Entrée"

                this.NewIdArchive();
            }
        }

        private void DeleteDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            CentrerPanneau(); 
        }

        private void CentrerPanneau()
        {
            // Calculer les coordonnées x et y pour centrer le panneau
            int x = (this.ClientSize.Width - panel5.Size.Width) / 2;
            int y = (this.ClientSize.Height - panel5.Size.Height) / 2;

            // Positionner le panneau au centre
            panel5.Location = new System.Drawing.Point(x, y);
        }
    }
}