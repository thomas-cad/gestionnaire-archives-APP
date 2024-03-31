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

        private int id_archive;
        public RendreForm(NpgsqlConnection conn_main_form)
        {
            InitializeComponent();

            conn = conn_main_form; //Recupere les informations de la BDD

            ResetValues(); //Reset les valeurs des champs
        }
        private void ResetValues()
        {
            IdArchiveTextBox.Text = string.Empty; // Vide la textbox de id archive
        }

        
        private bool Checking()
        {
            bool empruntExists = false;
            bool check_id_archive = false;

            // Verifie si le user a bien entré une valeur dans la textbox et affecte cette valeur a la variable
            if (IdArchiveTextBox.Text == string.Empty)
            {
                MessageBox.Show("Cote invalide", "Cote", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                id_archive = int.Parse(IdArchiveTextBox.Text); // Convertis la chaine de caractère en entier
                check_id_archive = true;
            }

            // Verifie si l'archive existe et n'est pas empruntée 
            var check_emprunt = new NpgsqlCommand("SELECT COUNT(*) FROM emprunt WHERE id_archive = @id_archive AND date_retour IS NULL", conn);
            check_emprunt.Parameters.AddWithValue("@id_archive", id_archive);
            if ((long)check_emprunt.ExecuteScalar() > 0)
            {
                empruntExists = true;
            }
            else
            {
                MessageBox.Show("Archive inexistante ou deja retournée", "Archive", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      

            return check_id_archive && empruntExists;
        }

        private void boutton_rendre_Click(object sender, EventArgs e)
        {
            if (Checking())
            {
                try
                {
                    var insert_requete = new NpgsqlCommand("UPDATE emprunt SET date_retour = CURRENT_DATE WHERE id_archive = @id_archive", conn);
                    insert_requete.Parameters.AddWithValue("@id_archive", id_archive);
                    insert_requete.ExecuteNonQuery(); // Set la date retour dans la base pour l'archive corrspondante

                    var change_emp = new NpgsqlCommand("UPDATE archive SET id_emplacement = NULL WHERE id_archive = @id_archive",conn);
                    change_emp.Parameters.AddWithValue("@id_archive", id_archive);
                    change_emp.ExecuteNonQuery();// Set l'emplacement de l'archive a NULL

                    ResetValues(); //Reset les valeurs des champs
                    MessageBox.Show("Archive rendue avec succès le " + DateTime.Now, "Archive", MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Un problème est survenu " + ex.Message); 
                }
            }
        }
    }
}
