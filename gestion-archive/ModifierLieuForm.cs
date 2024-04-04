using iText.Barcodes.Dmcode;
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
    public partial class ModifierLieuForm : Form
    {
        NpgsqlConnection conn;
        int id_lieu = -1; //on testera à chaque fois si la valeur n'est pas -1
        EditLieuForm editLieuForm;
        public ModifierLieuForm(NpgsqlConnection conn_main)
        {
            InitializeComponent();
            this.conn = conn_main;
            SetLieux();
        }

        private void LieuComboBox_TextChanged(object sender, EventArgs e)
        {
            SetIdLieu(LieuComboBox.Text);
        }

        private void LieuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIdLieu(LieuComboBox.SelectedItem.ToString());
        }

        private void LieuComboBox_Leave(object sender, EventArgs e)
        {
            if (LieuComboBox.DroppedDown == true)
            {
                LieuComboBox.DroppedDown = false;
            }
        }

        private void LieuComboBox_Enter(object sender, EventArgs e)
        {
            if (LieuComboBox.DroppedDown == false)
            {
                LieuComboBox.DroppedDown = true;
            }
        }

        private void SetIdLieu(string lieuId)
        {
            try
            {
                string[] split = lieuId.Split(new string[] { " : " }, StringSplitOptions.None); //Recupere la fin de l'item contenant l'id
                int id_check = int.Parse(split[1]);
                NpgsqlCommand check_id = new NpgsqlCommand("SELECT COUNT(*) FROM lieu WHERE id_lieu = @id_check", conn);
                check_id.Parameters.AddWithValue("@id_check", id_check);

                if ((long)check_id.ExecuteScalar() == 1)
                {
                    id_lieu = id_check; //Affecte l'id du lieu
                }
                else
                {
                    id_lieu = -1; //Desafecte l'id du lieu
                }
            }
            catch
            {
                id_lieu = -1; //Desafecte l'id du lieu
            }
        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            if(id_lieu != -1)
            {
                // Afficher une boîte de dialogue demandant confirmation
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce lieu ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Vérifier la réponse de l'utilisateur
                if (result == DialogResult.Yes)
                {
                    var delete_query = new NpgsqlCommand("DELETE FROM lieu WHERE id_lieu = @id_lieu", conn);
                    delete_query.Parameters.AddWithValue("@id_lieu", id_lieu);
                    delete_query.ExecuteNonQuery();
                    MessageBox.Show("Les emplacements ont été supprimés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Maj des lieux
                    LieuComboBox.Items.Clear();
                    SetLieux();
                }
                else
                {
                    MessageBox.Show("Les emplacements n'ont pas été supprimés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Le lieu est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetLieux()
        {
            //Vide les anciens lieux
            LieuComboBox.Items.Clear ();

            //Requete Recherche lieux
            NpgsqlCommand lieux_query = new NpgsqlCommand("SELECT nom, id_lieu FROM lieu", conn);

            //Prepare la requete
            lieux_query.Prepare();

            //Recuperation requete
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(lieux_query); //Craies un data adapter pour recuperer la requete
            DataTable dt = new DataTable(); //Creation d'une data table pour stocker la requete
            da.Fill(dt); //Stocke la requete dans la data table

            foreach (DataRow row in dt.Rows)
            {
                LieuComboBox.Items.Add(row[0].ToString() + " : " + row[1].ToString());
            }
        }

        private void AjouterEpisButton_Click(object sender, EventArgs e)
        {
            if (id_lieu != -1)
            {
                AddEpiPopUp addEpiPopUp = new AddEpiPopUp(conn, id_lieu);
                addEpiPopUp.ShowDialog(); //Affiche en boite de dialogue, donc bloque le controle
            }
            else
            {
                MessageBox.Show("Le lieu est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifierButton_Click(object sender, EventArgs e)
        {
            if (id_lieu != -1)
            {
                if (editLieuForm == null)
                {
                    editLieuForm = new EditLieuForm(conn,id_lieu,this);
                    editLieuForm.FormClosed += EditLieuForm_FormClosed; ; ;
                    editLieuForm.MdiParent = this.MdiParent;
                    editLieuForm.Dock = DockStyle.Fill;
                    editLieuForm.Show();
                }
                else
                {
                    editLieuForm.Activate();
                }
            }
            else
            {
                MessageBox.Show("Le lieu est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditLieuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            editLieuForm = null; 
        }

        private void ModifierLieuForm_Load(object sender, EventArgs e)
        {
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
    }
}
