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
    public partial class ListArchive : Form
    {
        NpgsqlConnection conn;
        public ListArchive(NpgsqlConnection conn_main, int id_emplacement)
        {
            InitializeComponent();
            conn = conn_main;

            SetEmplacement(id_emplacement);
            SetTableArchive(id_emplacement);
        }

        private void Emplacement_Click(object sender, EventArgs e)
        {

        }

        private void SetEmplacement (int id_emplacement)
        {
            try
            {
                var requete_emplacement = new NpgsqlCommand("SELECT lieu, epi, etagere, tablette FROM emplacement WHERE id_emplacement = @id_emplacement", conn);
                requete_emplacement.Parameters.AddWithValue("@id_emplacement", id_emplacement);
                NpgsqlDataReader reader_emplacment = requete_emplacement.ExecuteReader();

                var requete_lieu = new NpgsqlCommand("SELECT nom, adresse FROM lieu WHERE id_lieu = @id_lieu", conn);
                requete_lieu.Parameters.AddWithValue("@id_lieu", reader_emplacment.GetInt32(0));
                NpgsqlDataReader reader_lieu = requete_lieu.ExecuteReader();

                IdEmplacementInfoLabel.Text = id_emplacement.ToString();
                EpiInfoLabel.Text = reader_emplacment.GetString(1);
                EtagereInfoLabel.Text = reader_emplacment.GetString(2);
                TabletteInfoLabel.Text = reader_emplacment.GetString(3);
                LieuInfoLabel.Text = reader_lieu.GetString(0);
                IdLieuInfoLabel.Text = reader_emplacment.GetString(0);
                AdresseInfoLabel.Text= reader_lieu.GetString(1);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lecture de l'emplacement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetTableArchive (int id_emplacement)
        {
            var requete_table_archive = new NpgsqlCommand(@"
                    SELECT 
                    cote, 
                    id_archive, 
                    description

                    FROM archive

                    WHERE 
	                    id_emplacement = @id_emplacement
                ", 
            conn);
            requete_table_archive.Parameters.AddWithValue("@id_emplacement", id_emplacement);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(requete_table_archive); //Craies un data adapter pour recuperer la requete
            DataTable dt_table_archive = new DataTable();
            da.Fill(dt_table_archive); //Stocke la requete dans la data table

            //Vide data table grid view
            ArchiveDataGridView.DataSource = null;
            ArchiveDataGridView.Rows.Clear();

            //Remplie data table grid view
            ArchiveDataGridView.DataSource = dt_table_archive;
        }
    }
}
