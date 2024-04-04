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
    public partial class InfoEmplacement : Form
    {
        NpgsqlConnection conn;
        int emplacement;
        Form previsous_form;
        public InfoEmplacement(NpgsqlConnection conn_main, int id_emplacement, Form call_form)
        {
            InitializeComponent();
            conn = conn_main;
            SetEmplacement(id_emplacement);
            emplacement = id_emplacement;
            previsous_form = call_form;
        }

        private void SetEmplacement(int id_emplacement)
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
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lecture de l'emplacement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RechercherButton_Click(object sender, EventArgs e)
        {
            // Afficher une boîte de dialogue demandant confirmation
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette archive ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifier la réponse de l'utilisateur
            if (result == DialogResult.Yes)
            {
                var delete_query = new NpgsqlCommand("DELETE FROM emplacement WHERE id_emplacement = @id_emplacement", conn);
                delete_query.Parameters.AddWithValue("@id_emplacement", emplacement);
                delete_query.ExecuteNonQuery();
                MessageBox.Show("L'emplacement a été supprimé", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("L'emplacement n'a pas été supprimé", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            previsous_form.Show();
            this.Close();
        }

        private void InfoEmplacement_Load(object sender, EventArgs e)
        {
            CentrerPanneau(); 
        }

        private void CentrerPanneau()
        {
            // Calculer les coordonnées x et y pour centrer le panneau
            int x = (this.ClientSize.Width - panel3.Size.Width) / 2;
            int y = (this.ClientSize.Height - panel3.Size.Height) / 2;

            // Positionner le panneau au centre
            panel1.Location = new System.Drawing.Point(x, y);
        }
    }
}
