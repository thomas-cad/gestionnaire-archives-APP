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
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace gestion_archive
{
    public partial class AddArchiveForm : Form
    {
        public NpgsqlConnection conn;
        private NpgsqlCommand agent_requete;
        private NpgsqlCommand service_requete;

        private int id_agent;
        private int id_service;
        private string cote;
        private string description;
        private int temps_conservation;
        private float metrage_lineaire;
        private DateTime date_archive;
        private DateTime date_archivage;
        public AddArchiveForm(NpgsqlConnection conn_main_form)
        {
            InitializeComponent();
            AgentDataGridView.Hide();
            ServiceDataGridView.Hide();

            conn = conn_main_form; //Recupere les informations de la BDD

            agent_requete = new NpgsqlCommand("SELECT nom, prenom, id_agent FROM agent WHERE CAST(id_agent AS TEXT) LIKE @textbox OR nom LIKE @textbox OR prenom LIKE @textbox", conn);
            //Requete pour trouver l'agent, limite à 5

            service_requete = new NpgsqlCommand("SELECT nom, id_service FROM service WHERE CAST(id_service AS TEXT) LIKE @textbox OR nom LIKE @textbox", conn);
        }

        private void formOutil1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void bigLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {
            agent_requete.Parameters.Clear();

            if (AgentTextBox.Text.Length > 2)
            {
                agent_requete.Parameters.AddWithValue("@textbox", $"%{AgentTextBox.Text}%");

                agent_requete.Prepare();

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(agent_requete);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AgentDataGridView.DataSource = dt; // Put result into the dataview
            }

            

        }

        private void AddArchiveForm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Result_agent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hello");
            AgentTextBox.Text = AgentDataGridView[2, e.RowIndex].Value.ToString();
            AgentDataGridView.Hide();
        }

        private void Result_agent_Click(object sender, EventArgs e)
        {
            
        }

        private void bigTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void bigTextBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void bigTextBox1_Enter(object sender, EventArgs e)
        {
            AgentDataGridView.Show();
        }

        private void Result_agent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bigTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            cote = button_cote.Text;
            description = button_description.Text;
            date_archive = DateArchive.Value;
            date_archivage = DateArchivage.Value;

            try
            {
                metrage_lineaire = float.Parse(bigTextBox5.Text);
                temps_conservation = int.Parse(bigTextBox6.Text);
                id_agent = int.Parse(AgentTextBox.Text);
                id_service = int.Parse(ServiceTextBox.Text);

                // Vérification des valeurs converties
                if (metrage_lineaire != 0 && temps_conservation != 0 && id_agent != 0)
                {
                    var insert_requete = new NpgsqlCommand("INSERT INTO archive (id_service, id_agent, cote, description, date_archive, date_archivage, temps_conservation, metrage_lineaire) VALUES (@id_service, @id_agent, @cote, @description, @date_archive, @date_archivage, @temps_conservation, @metrage_lineaire)", conn);
                    insert_requete.Parameters.AddWithValue("@id_service", id_service);
                    insert_requete.Parameters.AddWithValue("@id_agent", id_agent);
                    insert_requete.Parameters.AddWithValue("@cote", cote);
                    insert_requete.Parameters.AddWithValue("@description", description); // correction ici
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

        private void bigLabel4_Click(object sender, EventArgs e)
        {

        }

        private void ServiceTextBox_TextChanged(object sender, EventArgs e)
        {
            service_requete.Parameters.Clear();

            if (ServiceTextBox.Text.Length > 2)
            {
                service_requete.Parameters.AddWithValue("@textbox", $"%{ServiceTextBox.Text}%");

                service_requete.Prepare();

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(service_requete);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ServiceDataGridView.DataSource = dt; // Put result into the dataview
            }
        }

        private void ServiceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceTextBox.Text = ServiceDataGridView[1, e.RowIndex].Value.ToString();
            ServiceDataGridView.Hide();
        }

        private void ServiceTextBox_Enter(object sender, EventArgs e)
        {
            ServiceDataGridView.Show();
        }
    }
}
