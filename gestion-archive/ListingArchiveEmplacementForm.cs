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
    public partial class ListingArchiveEmplacementForm : Form
    {
        NpgsqlConnection conn;
        Form previsous_form;
        public ListingArchiveEmplacementForm(NpgsqlConnection conn_main, int id_emplacement, Form call_form)
        {
            InitializeComponent();
            conn = conn_main;

            SetEmplacement(id_emplacement);
            SetTableArchive(id_emplacement);
            previsous_form = call_form;
        }

        private void Emplacement_Click(object sender, EventArgs e)
        {

        }

        private void SetEmplacement (int id_emplacement)
        {
            try
            {
                //Requete emplacement
                var requete_emplacement = new NpgsqlCommand("SELECT id_lieu, epi, etagere, tablette FROM emplacement WHERE id_emplacement = @id_emplacement", conn);
                requete_emplacement.Parameters.AddWithValue("@id_emplacement", id_emplacement);

                //Requete lieu
                var requete_lieu = new NpgsqlCommand("SELECT nom, adresse FROM lieu WHERE id_lieu = @id_lieu", conn);



                //Execution du reader de l'emplacment
                NpgsqlDataReader reader_emplacement = requete_emplacement.ExecuteReader();
                reader_emplacement.Read();

                IdEmplacementInfoLabel.Text = id_emplacement.ToString();
                EpiInfoLabel.Text = reader_emplacement.GetInt32(1).ToString();
                EtagereInfoLabel.Text = reader_emplacement.GetInt32(2).ToString();
                TabletteInfoLabel.Text = reader_emplacement.GetInt32(3).ToString();
                IdLieuInfoLabel.Text = reader_emplacement.GetInt32(0).ToString(); // Convert the integer to a string

                requete_lieu.Parameters.AddWithValue("@id_lieu", reader_emplacement.GetInt32(0));

                reader_emplacement.Close(); //Ferme le reader

                //Execution du reader du lieu
                NpgsqlDataReader reader_lieu = requete_lieu.ExecuteReader();
                reader_lieu.Read();

                LieuInfoLabel.Text = reader_lieu.GetString(0);
                AdresseInfoLabel.Text = reader_lieu.GetString(1);

                reader_lieu.Close(); //Ferme le reader
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lecture de l'emplacement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetTableArchive (int id_emplacement)
        {
            try
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

                requete_table_archive.Prepare();

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(requete_table_archive); //Craies un data adapter pour recuperer la requete
                DataTable dt_table_archive = new DataTable();
                da.Fill(dt_table_archive); //Stocke la requete dans la data table

                //Remplie data table grid view
                ArchiveDataGridView.DataSource = dt_table_archive;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lecture des archives : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ArchiveDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //verifie qu'on ne clique pas sur l'entete
            {
                // Récupére la valeur de la seconde colonne de la ligne cliquée
                try
                {
                    int selectedValue = Convert.ToInt32(ArchiveDataGridView.Rows[e.RowIndex].Cells[1].Value);

                    InfoArchivesForm infoForm = new InfoArchivesForm(conn, selectedValue, this);

                    // Affiche InfoArchivesForm
                    infoForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Impossible d'ouvrir l'archive" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            previsous_form.Show();
            this.Close();
        }
    }
}
