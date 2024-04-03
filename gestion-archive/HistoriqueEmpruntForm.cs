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
    public partial class HistoriqueEmpruntForm : Form
    {

        private NpgsqlConnection conn;
        public HistoriqueEmpruntForm(NpgsqlConnection conn_main)
        {
            InitializeComponent();
            conn = conn_main;
        }

        int id_archive; 

        private bool Checking()
        {
            bool check_id_archive = false;

            // Verifie si le user a bien entré une valeur dans la textbox et affecte cette valeur a la variable
            if (IdArchiveTextBox.Text == string.Empty)
            {
                MessageBox.Show("Id invalide", "ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    id_archive = int.Parse(IdArchiveTextBox.Text); // Convertis la chaine de caractère en entier  
                }
                catch 
                {
                    MessageBox.Show("Id invalide", "ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var check_emprunt = new NpgsqlCommand("SELECT COUNT(*) FROM archive WHERE id_archive = @id_archive", conn);
                check_emprunt.Parameters.AddWithValue("@id_archive", id_archive);
                if ((long)check_emprunt.ExecuteScalar() > 0)
                {
                    check_id_archive = true;
                }
                else
                {
                    MessageBox.Show("Archive inexistante", "Archive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return check_id_archive;
        }

        private void SetTableArchive(int id_archive)
        {
            var requete_table_archive = new NpgsqlCommand(@"
                    SELECT 
                    id_emprunt,
                    id_agent,
                    date_emprunt,
                    date_retour,
                    raison
                    FROM emprunt
                    WHERE 
	                id_archive = @id_archive
                    ",
            conn);
            requete_table_archive.Parameters.AddWithValue("@id_archive", id_archive);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(requete_table_archive); //Craies un data adapter pour recuperer la requete
            DataTable dt_table_archive = new DataTable();
            da.Fill(dt_table_archive); //Stocke la requete dans la data table

            //Vide data table grid view
            ArchiveDataGridView.DataSource = null;
            ArchiveDataGridView.Rows.Clear();

            //Remplie data table grid view
            ArchiveDataGridView.DataSource = dt_table_archive;
        }


        private void RechercherButton_Click(object sender, EventArgs e)
        {
            if (Checking())
            {
                SetTableArchive(id_archive);
            }
        }

        private void IdArchiveTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Empêche la saisie de la touche "Entrée"
                RechercherButton.PerformClick();
            }
        }
    }
}
