using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class SearchArchiveForm : Form
    {
        private NpgsqlConnection conn;

        InfoArchivesForm archives;
        private int id_archive;
        string cote; 

        public SearchArchiveForm(NpgsqlConnection conn_main_form)
        {
            InitializeComponent();

            conn = conn_main_form; //Recupere les informations de la BDD
            id_archive = 0; 
        }
        private void formArchives_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CentrerPanneau(); 
        }

        private void CentrerPanneau()
        {
            // Calculer les coordonnées x et y pour centrer le panneau
            int x = (this.ClientSize.Width - panel1.Size.Width) / 2;
            int y = (this.ClientSize.Height - panel1.Size.Height) / 2;

            // Positionner le panneau au centre
            panel1.Location = new System.Drawing.Point(x, y);
        }

        private bool Checkingidarchive()
        {
            bool check_id_archive = false;

            // Verifie si le user a bien entré une valeur dans la textbox et affecte cette valeur a la variable
            if (textBoxIdArchive.Text == string.Empty)
            {
                MessageBox.Show("Id invalide", "ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    id_archive = int.Parse(textBoxIdArchive.Text); // Convertis la chaine de caractère en entier  
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

        private bool Checkingcote()
        {
            bool check_id_archive = false;

            // Verifie si le user a bien entré une valeur dans la textbox et affecte cette valeur a la variable
            if (textBoxCote.Text == string.Empty)
            {
                MessageBox.Show("Cote Invalide", "Cote", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                     cote = textBoxCote.Text; 
                }
                catch
                {
                    MessageBox.Show("Cote invalide", "Cote", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Recupere id archive
                var check_cote = new NpgsqlCommand("SELECT id_archive FROM archive WHERE cote = @cote", conn);
                check_cote.Parameters.AddWithValue("@cote", cote);
                object result = check_cote.ExecuteScalar();
                if (result != null) 
                { 
                    id_archive = (int)result;
                    var check_emprunt = new NpgsqlCommand("SELECT COUNT(*) FROM archive WHERE id_archive = @id_archive", conn);
                    check_emprunt.Parameters.AddWithValue("@id_archive", id_archive);
                    if ((long)check_emprunt.ExecuteScalar() > 0) //Verifie existence
                    {
                        check_id_archive = true;
                    }
                    else
                    {
                        MessageBox.Show("Archive inexistante", "Archive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Cote inexistante", "Cote", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return check_id_archive;
        }

        private void RechercherButton_Click(object sender, EventArgs e)
        {
            id_archive = 0; // Reset l'id archive
            if (Checkingidarchive())
            {
                // Afficher le form de InfoArchive
                if (archives == null)
                {
                    archives = new InfoArchivesForm(conn, id_archive, this);
                    archives.FormClosed += Archives_FormClosed; ;
                    archives.MdiParent = this.MdiParent;
                    archives.Dock = DockStyle.Fill;
                    archives.Show();
                }
                else
                {
                    archives.Activate();
                }
            }
        }

        private void Archives_FormClosed(object sender, FormClosedEventArgs e)
        {
            archives = null; // On met la variable associée a archive a null
        }

        private void button_recherchercote_Click(object sender, EventArgs e)
        {
            id_archive = 0; // Reset l'id archive
            if (Checkingcote())
            {
                archives = null; //On met la variable associée a archive a null
                // Afficher le form de InfoArchive
                if (archives == null)
                {
                    archives = new InfoArchivesForm(conn, id_archive, this);
                    archives.FormClosed += Archives_FormClosed; ;
                    archives.MdiParent = this.MdiParent;
                    archives.Dock = DockStyle.Fill;
                    archives.Show();
                }
                else
                {
                    archives.Activate();
                }
            }
        }
    }
}
