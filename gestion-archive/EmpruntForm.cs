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
    public partial class EmpruntForm : Form
    {
        private NpgsqlConnection conn;

        private int id_agent;
        public EmpruntForm (NpgsqlConnection conn_main_form)
        {
            InitializeComponent();

            conn = conn_main_form; //Recupere les informations de la BDD

            MajAgent();
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
    }
}
