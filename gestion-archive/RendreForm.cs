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

            ResetValues();
        }
        private void ResetValues()
        {
            IdArchiveTextBox.Text = string.Empty;
        }

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
                id_archive = int.Parse(IdArchiveTextBox.Text);
                check_id_archive = true;
            }

            var check_emprunt = new NpgsqlCommand("SELECT COUNT(*) FROM emprunt WHERE id_archive = @id_archive AND date_retour IS NULL", conn);
            check_emprunt.Parameters.AddWithValue("@id_archive", id_archive);
            if ((long)check_emprunt.ExecuteScalar() > 0)
            {
                empruntExists = true;
            }
            else
            {
                MessageBox.Show("Archive inexistante ou deja emprunté", "Archive", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    insert_requete.ExecuteNonQuery();

                    var change_emp = new NpgsqlCommand("UPDATE archive SET id_emplacement = NULL WHERE id_archive = @id_archive",conn);
                    change_emp.Parameters.AddWithValue("@id_archive", id_archive);
                    change_emp.ExecuteNonQuery();

                    ResetValues(); //Reset les valeurs des champs
                    MessageBox.Show("Archive rendu avec succès le " + DateTime.Now);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Un problème est survenu " + ex.Message); 
                }
            }
        }
    }
}
