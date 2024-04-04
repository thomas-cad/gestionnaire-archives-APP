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
using System.Windows.Forms.Design;
using data_base;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using ReaLTaiizor.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestion_archive
{
    public partial class EmpruntForm : Form
    {
        private NpgsqlConnection conn;

        private int id_archive;
        private int id_agent;
        private string raison; 
        public EmpruntForm (NpgsqlConnection conn_main_form)
        {
            InitializeComponent();

            conn = conn_main_form; //Recupere les informations de la BDD

            MajAgent();
            ResetValues();
        }

        //Verifie l'id saisie dans la TextBox
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

        //Ferme le menu deroulant si ouvert && verifie si la valeur saisie est valide
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

        //Ouvre le menu déroulant lorsqu'on clique sur la ComboBox si elle n'est pas ouverte
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


        //MAJ menu déroulant Agent
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

        private void ResetValues()
        {
            //Vide les TextBox
            id_agent = -1;
            AgentComboBox.Text = string.Empty;
            CoteTextBox.Text = string.Empty;
            RaisonTextBox.Text = string.Empty;
        }
        private bool Checking()
        {
            bool check_id_archive = false;
            bool check_agent = false;
            bool check_raison = false;
            bool check = false;

            //Chcck l'id archive
            if (CoteTextBox.Text == string.Empty)
            {
                MessageBox.Show("Id Archive invalide", "Id_Archive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                try
                {
                    id_archive = int.Parse(CoteTextBox.Text);
                }
                catch {MessageBox.Show("Id Archive invalide", "Id_Archive", MessageBoxButtons.OK, MessageBoxIcon.Error);}

                var check_idarchive = new NpgsqlCommand("SELECT COUNT(*) FROM archive WHERE id_archive = @id_archive",conn);
                check_idarchive.Parameters.AddWithValue("@id_archive", id_archive);

                if ((long)check_idarchive.ExecuteScalar() == 1)
                {
                    check_id_archive = true;
                }
                else
                {
                    check_id_archive = false;
                    MessageBox.Show("L'id de l'archive n'existe pas", "Id Archive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Check la raison
            if (RaisonTextBox.Text == string.Empty)
            {
                MessageBox.Show("Raison Invalide", "Raison", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                raison = RaisonTextBox.Text;
                check_raison = true;
            }

            //Check Agent
            if (id_agent == -1)
            {
                MessageBox.Show("Agent invalide", "Agent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                check_agent = true;
            }

            // Check si l'archive a deja été empruntée
            var checkemprunt = new NpgsqlCommand("SELECT COUNT(*) FROM emprunt WHERE date_retour IS NULL AND id_archive = @id_archive", conn);
            checkemprunt.Parameters.AddWithValue("@id_archive", id_archive);

            if ((long)checkemprunt.ExecuteScalar() > 0)
            {
                try
                {
                    var set_retour = new NpgsqlCommand("UPDATE emprunt SET date_retour = CURRENT_DATE WHERE id_archive = @id_archive AND date_retour IS NULL",conn); //definie le retour
                    set_retour.Parameters.AddWithValue("@id_archive", id_archive);
                    set_retour.ExecuteNonQuery(); // Definie la date retour
                    MessageBox.Show("L'archive a été retournée", "Archive", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    ResetValues();
                    MessageBox.Show(ex.Message);
                }
            }

            try
            {
                var check_destruction = new NpgsqlCommand("SELECT COUNT(*) FROM destruction WHERE id_archive = @id_archive", conn);
                check_destruction.Parameters.AddWithValue("@id_archive", id_archive);

                if ((long)check_destruction.ExecuteScalar() == 0)
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

            return check_id_archive && check_agent && check_raison && check;
        }   

        private void RechercherButton_Click(object sender, EventArgs e)
        {
            if (Checking()) // Check les valeurs des champs
            {
                try
                {
                    var insert_requete = new NpgsqlCommand("INSERT INTO emprunt (id_agent, date_emprunt, id_archive, raison) VALUES (@id_agent, @date_emprunt, @id_archive, @raison)", conn);
                    insert_requete.Parameters.AddWithValue("@id_agent", id_agent);
                    insert_requete.Parameters.AddWithValue("@id_archive", id_archive);
                    insert_requete.Parameters.AddWithValue("@raison", raison);
                    insert_requete.Parameters.AddWithValue("@date_emprunt", DateTime.Now);
                    insert_requete.ExecuteNonQuery();

                    var change_emp = new NpgsqlCommand("UPDATE archive SET id_emplacement = 20646 WHERE id_archive = @id_archive", conn);
                    change_emp.Parameters.AddWithValue("@id_archive", id_archive);
                    change_emp.ExecuteNonQuery();

                    ResetValues(); //Reset les valeurs des champs
                    MessageBox.Show("Archive emprunté avec succès le " + DateTime.Now, "Archive", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur", "Erreur : " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetValues();
                }
            }
        }

        private void RaisonTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Empêche la saisie de la touche "Entrée"
                RechercherButton.PerformClick();
            }
        }

        private void EmpruntForm_Load(object sender, EventArgs e)
        {
            CentrerPanneau(); 
        }

        private void CentrerPanneau()
        {
            // Calculer les coordonnées x et y pour centrer le panneau
            int x = (this.ClientSize.Width - panel1.Size.Width) / 2;
            int y = (this.ClientSize.Height - panel1.Size.Height) / 2;

            // Positionner le panneau au centre
            panel1.Location = new System.Drawing.Point(x, y);
        }
    }
}
