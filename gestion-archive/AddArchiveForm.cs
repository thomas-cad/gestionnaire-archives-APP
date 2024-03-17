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

namespace gestion_archive
{
    public partial class AddArchiveForm : Form
    {
        //Définition des reqêtes et connexion pour les menus
        public NpgsqlConnection conn;
        private NpgsqlCommand agent_requete;
        private NpgsqlCommand service_requete;


        //Attributs d'une archive
        private int id_agent;
        private int id_service;
        private string cote;
        private string description;
        private int temps_conservation;
        private float metrage_lineaire;
        private DateTime date_archive;
        private DateTime date_archivage;

        //Constructeur
        public AddArchiveForm(NpgsqlConnection conn_main_form)
        {
            InitializeComponent();
            //Cache les menus au démarrage
            AgentDataGridView.Hide();
            ServiceDataGridView.Hide();

            conn = conn_main_form; //Recupere les informations de la BDD

            //Requete Recherche agent
            agent_requete = new NpgsqlCommand("SELECT nom, prenom, id_agent FROM agent WHERE CAST(id_agent AS TEXT) LIKE @textbox OR nom LIKE @textbox OR prenom LIKE @textbox", conn);

            //Requete Recherche service
            service_requete = new NpgsqlCommand("SELECT nom, id_service FROM service WHERE CAST(id_service AS TEXT) LIKE @textbox OR nom LIKE @textbox", conn);
        }

        private void formOutil1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Supprime les parametres de l'ancienne recherche
             agent_requete.Parameters.Clear();

            //Recupere le parametre de la nouvelle recherche
             agent_requete.Parameters.AddWithValue("@textbox", $"%{AgentTextBox.Text}%");

            //Prepare la requete
             agent_requete.Prepare();

            //Recuperation requete
             NpgsqlDataAdapter da = new NpgsqlDataAdapter(agent_requete); //Craies un data adapter pour recuperer la requete
             DataTable dt = new DataTable(); //Creation d'une data table pour stocker la requete
             da.Fill(dt); //Stocke la requete dans la data table
             AgentDataGridView.DataSource = dt; // Recuperation de la data table dans la data view
        }


        private void bigTextBox1_Enter(object sender, EventArgs e)
        {
            AgentDataGridView.Show(); //Affiche la data view lorsqu'on rentre dans la TextBox de agent
        }


        private void button_submit_Click(object sender, EventArgs e)
        {
            //Recuperation dans des variables des text box
            cote = button_cote.Text;
            description = button_description.Text;
            date_archive = DateArchive.Value;
            date_archivage = DateArchivage.Value;

            try
            {
                //Conversion des types
                metrage_lineaire = float.Parse(bigTextBox5.Text);
                if(bigTextBox6.Text != null)
                {
                    temps_conservation = int.Parse(bigTextBox6.Text);
                }
                id_agent = int.Parse(AgentTextBox.Text);
                id_service = int.Parse(ServiceTextBox.Text);

                // Vérification des valeurs converties
                if (metrage_lineaire != 0 && temps_conservation != 0 && id_agent != 0)
                {
                    //Requete
                    var insert_requete = new NpgsqlCommand("INSERT INTO archive (id_service, id_agent, cote, description, date_archive, date_archivage, temps_conservation, metrage_lineaire) VALUES (@id_service, @id_agent, @cote, @description, @date_archive, @date_archivage, @temps_conservation, @metrage_lineaire)", conn);
                    insert_requete.Parameters.AddWithValue("@id_service", id_service);
                    insert_requete.Parameters.AddWithValue("@id_agent", id_agent);
                    insert_requete.Parameters.AddWithValue("@cote", cote);
                    insert_requete.Parameters.AddWithValue("@description", description);
                    insert_requete.Parameters.AddWithValue("@date_archive", date_archive.Date);
                    insert_requete.Parameters.AddWithValue("@date_archivage", date_archivage.Date);
                    insert_requete.Parameters.AddWithValue("@temps_conservation", temps_conservation);
                    insert_requete.Parameters.AddWithValue("@metrage_lineaire", metrage_lineaire);
                    insert_requete.ExecuteNonQuery();
                    MessageBox.Show("Archive ajoutée avec succès");
                }
                else
                {
                    MessageBox.Show("Attention à remplir tous les champs");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Le metrage lineaire est un float\nLe temps de conservation est en année (integer)\nid_agent : integer");
            }
            catch (Exception ex) {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }

        private void ServiceTextBox_TextChanged(object sender, EventArgs e)
        {
            //CF. L.58 : private void bigTextBox1_TextChanged(object sender, EventArgs e)
            service_requete.Parameters.Clear();

            service_requete.Parameters.AddWithValue("@textbox", $"%{ServiceTextBox.Text}%");

            service_requete.Prepare();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(service_requete);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ServiceDataGridView.DataSource = dt;
        }

        private void ServiceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceTextBox.Text = ServiceDataGridView[1, e.RowIndex].Value.ToString();  //Assigne à la TextBox l'id de l'agent selectionne
            ServiceDataGridView.Hide(); 
        }

        private void ServiceTextBox_Enter(object sender, EventArgs e)
        {
            ServiceDataGridView.Show(); //Montre la data view lorsqu'on rentre dans le champ Service
        }

        private void AgentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AgentTextBox.Text = AgentDataGridView[2, e.RowIndex].Value.ToString(); //Assigne à la TextBox l'id de l'agent selectionne
            AgentDataGridView.Hide(); //cache la data view
        }
    }
}
