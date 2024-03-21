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
        private NpgsqlConnection conn;
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
            InitializeComponent();;

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
                id_agent = int.Parse(AgentComboBox.Text);
                id_service = int.Parse(ServiceComboBox.Text);

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

        private void AgentComboBox_TextChanged(object sender, EventArgs e)
        {
            //Supprime les parametres de l'ancienne recherche
            agent_requete.Parameters.Clear();

            //Recupere le parametre de la nouvelle recherche
            agent_requete.Parameters.AddWithValue("@textbox", $"%{AgentComboBox.Text}%");

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

            dt.Clear();

            AgentComboBox.Items.Clear();
        }

        private void ServiceComboBox_TextChanged(object sender, EventArgs e)
        {
            service_requete.Parameters.Clear();

            service_requete.Parameters.AddWithValue("@textbox", $"%{ServiceComboBox.Text}%");

            service_requete.Prepare();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(service_requete);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ServiceComboBox.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ServiceComboBox.Items.Add(row[0].ToString() + " : " + row[1].ToString());
            }

            dt.Clear();

            
        }
    }
}
