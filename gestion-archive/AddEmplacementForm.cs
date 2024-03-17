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
using System.Windows.Forms.Design;

namespace gestion_archive
{
    public partial class AddEmplacementForm : Form
    {
        private NpgsqlConnection conn;
        public AddEmplacementForm(NpgsqlConnection conn_main_form)
        {
            InitializeComponent();
            conn = conn_main_form; //Recupere les informations de la BDD
        }

        private void AddLieuButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Definition des attributs
                string nom_lieu = LieuTextBox.Text;
                string adresse = AdresseTextBox.Text;
                int nbr_epi = int.Parse(NbrEpiTextBox.Text);
                int nbr_etagere = int.Parse(NbrEtagereTextBox.Text);
                int nbr_tablette = int.Parse(NbrTabletteTextBox.Text);

                //Création du lieu
                var new_lieu_requete = new NpgsqlCommand("INSERT INTO lieu (nom, adresse) VALUES (@nom, @adresse)", conn);
                new_lieu_requete.Parameters.AddWithValue("@nom", nom_lieu);
                new_lieu_requete.Parameters.AddWithValue("@adresse", adresse);
                new_lieu_requete.ExecuteNonQuery();

                //Récupération de l'id du lieu
                var id_lieu_requete = new NpgsqlCommand("SELECT id_lieu FROM lieu WHERE nom = @nom_lieu", conn);
                id_lieu_requete.Parameters.AddWithValue("@nom_lieu", nom_lieu);
                int id_lieu = Convert.ToInt32(id_lieu_requete.ExecuteScalar());

                //Création des emplacements
                var new_emplacement_requete = new NpgsqlCommand("INSERT INTO emplacement (id_lieu, trave, etagere, tablette) VALUES (@id_lieu, @epi, @etagere, @tablette)", conn);
                new_emplacement_requete.Parameters.AddWithValue("@id_lieu", id_lieu);
                for (int i = 1; i <= nbr_epi; i++) //Incrémentation des epis
                {
                    new_emplacement_requete.Parameters.AddWithValue("@epi", i); //Incrémentation des etageres
                    for (int j = 1; j <= nbr_etagere; j++)
                    {
                        new_emplacement_requete.Parameters.AddWithValue("@etagere", j); //Incrémentation des tablettes
                        for (int k = 1; k <= nbr_tablette; k++)
                        {
                            //Reecriture des variables
                            new_emplacement_requete.Parameters.AddWithValue("@id_lieu", id_lieu);
                            new_emplacement_requete.Parameters.AddWithValue("@epi", i);
                            new_emplacement_requete.Parameters.AddWithValue("@etagere", j);
                            new_emplacement_requete.Parameters.AddWithValue("@tablette", k);

                            //Execution de la requete
                            new_emplacement_requete.ExecuteNonQuery();

                            //Supression des anciennes variables
                            new_emplacement_requete.Parameters.Clear(); 
                        }
                    }
                }

                MessageBox.Show("Emplacements créés avec succès");
            }
            catch(FormatException)
            {
                MessageBox.Show("Les nombres doivent êtres des integers");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            
        }
    }
}
