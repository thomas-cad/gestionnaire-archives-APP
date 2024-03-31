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

                var command = new NpgsqlCommand("SELECT insert_emplacements(@epi, @etagere, @tablette, @lieu)", conn); //Creation des emplacements par le serveur PostgreSQL avec une seule requete
                /*
                 * Script de la fonction insert_emplacements
                 * 
                 * CREATE OR REPLACE FUNCTION public.insert_emplacements(
                        nbr_epi INTEGER,
                        nbr_etagere INTEGER,
                        nbr_tablette INTEGER,
                        lieu INTEGER
                    )
                    RETURNS void AS
                    $$
                    BEGIN
                        FOR i IN 1..nbr_epi LOOP
                            FOR j IN 1..nbr_etagere LOOP
                                FOR l IN 1..nbr_tablette LOOP
                                    INSERT INTO emplacement (id_lieu, epi, etagere, tablette) VALUES (lieu, i, j, l);
                                END LOOP;
                            END LOOP;
                        END LOOP;
                    END;
                    $$ LANGUAGE plpgsql;
                */

                command.Parameters.AddWithValue("@epi", nbr_epi);
                command.Parameters.AddWithValue("@etagere", nbr_etagere);
                command.Parameters.AddWithValue("@tablette", nbr_tablette);
                command.Parameters.AddWithValue("@lieu", id_lieu);

                command.ExecuteNonQuery();

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

        private void AddEmplacementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
