using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_archive
{
    public partial class AddEpiPopUp : Form
    {
        int id_lieu;
        int epi;
        NpgsqlConnection conn;
        public AddEpiPopUp(NpgsqlConnection conn_main, int id)
        {
            InitializeComponent();
            id_lieu = id;
            conn = conn_main;
        }

        private bool checkEpi()
        {
            bool check = false;
            //Check que epi non null et un entier
            if (NbrEpiTextBox.Text != string.Empty)
            {
                if (int.TryParse(NbrEpiTextBox.Text, out epi)) //test la conversion et affecte à epi si réussie
                {
                    check = true;
                }
                else
                {
                    MessageBox.Show("Epi saisi invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Epi saisi invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return check;
        }


        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValiderButton_Click(object sender, EventArgs e)
        {
            if (checkEpi())
            {
                try
                {
                    var insert_query = new NpgsqlCommand("SELECT add_epis (@lieu, @epi)", conn);
                    insert_query.Parameters.AddWithValue("@lieu", id_lieu);
                    insert_query.Parameters.AddWithValue("@epi", epi);
                    insert_query.ExecuteNonQuery();

                    MessageBox.Show("Emplacements ajoutés avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Erreur lors de l'insertion " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
