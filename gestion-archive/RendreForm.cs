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
    public partial class RendreForm : Form
    {
        private NpgsqlConnection conn;

        private string id_archive;
        public RendreForm(NpgsqlConnection conn_main_form)
        {
            InitializeComponent();

            conn = conn_main_form; //Recupere les informations de la BDD

            ResetValues();
        }
        private void ResetValues()
        {
            IdArchiveTextBox.Text = string.Empty;
        }

        // Booléen pour indiquer si la ligne existe dans la table
        bool empruntExists = false;
        private bool Checking()
        {
            bool check_id_archive = false;

            if (IdArchiveTextBox.Text == string.Empty)
            {
                MessageBox.Show("Cote invalide", "Cote", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                id_archive = IdArchiveTextBox.Text;
                check_id_archive = true;
            }

            string sql = "SELECT COUNT(*) FROM emprunt WHERE id_archive = @id_archive";

            // Création de la commande avec la requête SQL et la connexion
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                // Ajout du paramètre id_archive à la commande
                cmd.Parameters.AddWithValue("@id_archive", id_archive);

                // Exécution de la commande et récupération du nombre de lignes correspondantes
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Vérification si une ligne a été trouvée
                if (count > 0)
                {
                    empruntExists = true;
                }
                else
                {
                    MessageBox.Show("Archive inexistante ou deja emprunté", "Archive", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }

            return check_id_archive && empruntExists;
        }

        private void IdArchiveTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Checking())
            {
                var insert_requete = new NpgsqlCommand("UPDATE FROM emprunt SET date_retour = CURRENT_DATE WHER WHERE id_archive = @id_archive)", conn);
                insert_requete.Parameters.AddWithValue("@id_archive", id_archive);
                insert_requete.ExecuteNonQuery();
                ResetValues(); //Reset les valeurs des champs
                MessageBox.Show("Archive rendu avec succès le " + DateTime.Now);
            }
        }
       
    }
}
