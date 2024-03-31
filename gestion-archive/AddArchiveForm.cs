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
using data_base;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestion_archive
{
    public partial class AddArchiveForm : Form
    {
        //Définition des requêtes et connexion pour les menus
        private NpgsqlConnection conn;


        //Attributs d'une archive
        private int id_agent;
        private int id_service;
        private string cote;
        private string description;
        private int temps_conservation;
        private float ml;
        private DateTime date_archive;
        private DateTime date_archivage;

        //Constructeur
        public AddArchiveForm(NpgsqlConnection conn_main_form)
        {
            InitializeComponent();

            //Initialise Max Date
            DateArchive.MaxDate = DateTime.Now;
            DateArchivage.MaxDate = DateTime.Now;

            conn = conn_main_form; //Recupere les informations de la BDD

            ResetValues();

            MajAgent();
            MajService();
        }

        private void formOutil1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
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

        //Verifie l'id saisie dans la TextBox
        private void ServiceComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] split = ServiceComboBox.Text.Split(new string[] { " : " }, StringSplitOptions.None); //Recupere la fin de l'item contenant l'id
                int id_check = int.Parse(split[1]);
                NpgsqlCommand check_id = new NpgsqlCommand("SELECT COUNT(*) FROM service WHERE id_service = @id_service", conn);
                check_id.Parameters.AddWithValue("@id_service", id_check);

                if ((long)check_id.ExecuteScalar() == 1)
                {
                    id_service = id_check; //Desafecte l'id de l'agent
                }
                else
                {
                    id_service = -1; //Desafecte l'id de l'agent
                }
            }
            catch
            {
                id_service = -1; //Desafecte l'id de l'agent
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

        //Ferme le menu deroulant si ouvert && verifie si la valeur saisie est valide
        private void ServiceComboBox_Leave(object sender, EventArgs e)
        {
            if (ServiceComboBox.DroppedDown == true)
            {
                ServiceComboBox.DroppedDown = false;
            }
        }

        //Ouvre le menu déroulant lorsqu'on clique sur la ComboBox si elle n'est pas ouverte
        private void ServiceComboBox_Click(object sender, EventArgs e)
        {
            if (ServiceComboBox.DroppedDown == false)
            {
                ServiceComboBox.DroppedDown = true;
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
        

        //MAJ menu déroulant Service
        private void MajService()
        {
            //Requete Recherche Service
            NpgsqlCommand service_requete = new NpgsqlCommand("SELECT nom, id_service FROM service", conn);

            //Prepare la requete
            service_requete.Prepare();

            //Recuperation requete
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(service_requete); //Craies un data adapter pour recuperer la requete
            DataTable dt = new DataTable(); //Creation d'une data table pour stocker la requete
            da.Fill(dt); //Stocke la requete dans la data table

            foreach (DataRow row in dt.Rows)
            {
                ServiceComboBox.Items.Add(row[0].ToString() + " : " + row[1].ToString());
            }
        }

        private bool Checking()
        {
            bool check_cote = false;
            bool check_description = false;
            bool check_agent = false;
            bool check_service = false;
            bool check_date = false;
            bool check_delete_time = false;
            bool check_ml = false;
            
            //Verification de la cote
            if (CoteTextBox.Text == string.Empty)
            {
                MessageBox.Show("Cote invalide", "Cote", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cote = CoteTextBox.Text;
                check_cote = true;
            }

            //Verification de la description
            if (DescriptionTextBox.Text == string.Empty)
            {
                MessageBox.Show("Description invalide", "Description", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                description = DescriptionTextBox.Text;
                check_description = true;
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

            //Check Service
            if (id_service == -1)
            {
                MessageBox.Show("Service invalide", "Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                check_service = true;
            }

            //Check Metrage lineaire
            if (MlTextBox.Text == string.Empty) //Check que le metrage lineaire est non null
            {
                MessageBox.Show("Le metrage lineaire ne peut pas être nul", "Metrage Lineaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try //Verifie que le ml soit un float
                {
                    ml = float.Parse(MlTextBox.Text);
                    check_ml = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Le metrage lineaire doit être exprimé en m (type float)", "Metrage Lineaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Metrage Lineaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Check Delete Time
            if (TimeConservTextBox.Text == string.Empty) //Si null => OK
            {
                check_delete_time = true;
            }
            else
            {
                try //Verifie que la duree soit en int
                {
                    temps_conservation = int.Parse(TimeConservTextBox.Text);
                    check_delete_time = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Le temps de conservation doit etre exprime en années (type : int)", "Temps Conservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Temps Conservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Check date
            if (DateTime.Compare(DateArchive.Value, DateArchivage.Value) >= 0) //Date Archive > Date Archivage
            {
                MessageBox.Show("La date de l'archive ne peut pas être supérieure à celle de l'archivage", "Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                check_date = true;
            }

            return check_cote && check_description && check_agent && check_service && check_date && check_ml && check_delete_time;
        }

        //Reset Form Values
        private void ResetValues ()
        {
            id_agent = -1;
            AgentComboBox.Text = string.Empty;

            id_service = -1;
            ServiceComboBox.Text = string.Empty;

            CoteTextBox.Text = string.Empty;

            DescriptionTextBox.Text = string.Empty;

            MlTextBox.Text = string.Empty;  

            DateArchive.Value = (DateTime.Now).Date;

            DateArchivage.Value = (DateTime.Now).Date;
        }

        //Selectionne le service
        private void ServiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] split = (ServiceComboBox.SelectedItem.ToString()).Split(new string[] { " : " }, StringSplitOptions.None); //Recupere la fin de l'item contenant l'id
                int id_check = int.Parse(split[1]);
                NpgsqlCommand check_id = new NpgsqlCommand("SELECT COUNT(*) FROM service WHERE id_service = @id_service", conn);
                check_id.Parameters.AddWithValue("@id_service", id_check);

                if ((long)check_id.ExecuteScalar() == 1)
                {
                    id_service = id_check; //Desafecte l'id de l'agent
                }
                else
                {
                    id_service = -1; //Desafecte l'id de l'agent
                }
            }
            catch
            {
                id_service = -1; //Desafecte l'id de l'agent
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

        private void TerminerButton_Click(object sender, EventArgs e)
        {
            if (Checking()) //Test si la requete peut etre effectuee
            {
                var insert_requete = new NpgsqlCommand("INSERT INTO archive (id_service, id_agent, cote, description, date_archive, date_archivage, temps_conservation, metrage_lineaire) VALUES (@id_service, @id_agent, @cote, @description, @date_archive, @date_archivage, @temps_conservation, @ml)", conn);
                insert_requete.Parameters.AddWithValue("@id_service", id_service);
                insert_requete.Parameters.AddWithValue("@id_agent", id_agent);
                insert_requete.Parameters.AddWithValue("@cote", cote);
                insert_requete.Parameters.AddWithValue("@description", description);
                insert_requete.Parameters.AddWithValue("@date_archive", date_archive.Date);
                insert_requete.Parameters.AddWithValue("@date_archivage", date_archivage.Date);
                insert_requete.Parameters.AddWithValue("@temps_conservation", temps_conservation);
                insert_requete.Parameters.AddWithValue("@ml", ml);
                insert_requete.ExecuteNonQuery();
                ResetValues(); //Reset les valeurs des champs
                MessageBox.Show("Archive ajoutée avec succès");
            }
        }
    }
}