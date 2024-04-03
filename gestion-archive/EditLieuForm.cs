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
    public partial class EditLieuForm : Form
    {
        NpgsqlConnection conn;
        int id_lieu;
        ModifierLieuForm previous_form;

        public EditLieuForm(NpgsqlConnection conn_main, int id, ModifierLieuForm previous_form)
        {
            InitializeComponent();
            conn = conn_main;
            id_lieu = id;
            SetLieu();
            this.previous_form = previous_form;
        }

        private void SetLieu()
        {
            try
            {
                //Requete lieu
                var requete_lieu = new NpgsqlCommand("SELECT nom, adresse FROM lieu WHERE id_lieu = @lieu", conn);
                requete_lieu.Parameters.AddWithValue("@lieu", id_lieu);

                //Execution du reader du lieu
                NpgsqlDataReader reader_lieu = requete_lieu.ExecuteReader();
                reader_lieu.Read();

                LieuTextBox.Text = reader_lieu.GetString(0);
                AdresseTextBox.Text = reader_lieu.GetString(1);

                reader_lieu.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur recherche informations lieu : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool Check()
        {
            bool check_nom = false;
            bool check_adresse = false;

            //Check nom
            if (LieuTextBox.Text != string.Empty) //Nom non null
            {
                //Check que le nom est unique
                var nomUnique_quiery = new NpgsqlCommand("SELECT COUNT(*) FROM lieu WHERE id_lieu != @lieu AND nom = @nom", conn);

                nomUnique_quiery.Parameters.AddWithValue("@lieu", id_lieu);
                nomUnique_quiery.Parameters.AddWithValue("@nom", LieuTextBox.Text);

                if ((long)nomUnique_quiery.ExecuteScalar() == 0)
                {
                    check_nom = true;
                }
                else
                {
                    MessageBox.Show("Ce lieu existe déja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Le nom du lieu est nul", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Check adresse
            if (AdresseTextBox.Text != string.Empty) //Adresse non null
            {
                check_adresse = true;
            }
            else
            {
                MessageBox.Show("L'adresse du lieu est nul", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return check_nom && check_adresse;
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if(Check())
            {
                try
                {
                    //On modifie la table avec les nouvelles informations
                    var update_query = new NpgsqlCommand("UPDATE lieu SET nom = @nom, adresse = @adresse WHERE id_lieu = @lieu", conn);
                    update_query.Parameters.AddWithValue("@nom", LieuTextBox.Text.ToString());
                    update_query.Parameters.AddWithValue("@adresse", AdresseTextBox.Text.ToString());
                    update_query.Parameters.AddWithValue("@lieu", id_lieu);

                    update_query.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    previous_form.SetLieux(); //Maj de la liste des lieux sur le form modifier lieu
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Impossible de modifier les informations : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            previous_form.Show();
            this.Close();
        }
    }
}