using Npgsql;
using Org.BouncyCastle.Asn1;
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
    public partial class SearchEmplacementForm : Form
    {
        NpgsqlConnection conn;

        ListingArchiveEmplacementForm listArchive;
        InfoEmplacement infoEmplacement; 

        int id_emplacement = -1;
        int id_lieu = -1;
        int epi;
        int etagere;
        int tablette;

        public SearchEmplacementForm(NpgsqlConnection conn_main)
        {
            InitializeComponent();
            conn = conn_main;
            SetLieux();
        }
        private void CentrerPanneau()
        {
            // Calculer les coordonnées x et y pour centrer le panneau
            int x = (this.ClientSize.Width - panel1.Size.Width) / 2;
            int y = (this.ClientSize.Height - panel1.Size.Height) / 2;

            // Positionner le panneau au centre
            panel1.Location = new System.Drawing.Point(x, y);
        }
        private int GetIdEmplacement()
        {
            int id = -1;

            if(CheckSearchIdEmplacement()) //Check que les champs sont remplis correctement
            {
                id = SearchIdEmplacement(id_lieu, epi, etagere, tablette); //Recherche l'emplacement
            }

            return id;
        }

        private void SetIdEmplacement()
        {
            int id_TextBox_Check;
            int id_Search_Check;

            if (IdEmplacementTextBox.Text != string.Empty) //Test si le champ id n'est pas null
            {
                try
                {
                    id_TextBox_Check = int.Parse(IdEmplacementTextBox.Text); //test si l'id saisi est un entier

                    if (CheckIdEmplacement(id_TextBox_Check)) //Test si l'id existe
                    {
                        id_emplacement = id_TextBox_Check; //Affecte l'ide
                    }
                    else
                    {
                        id_emplacement = -1; //Desaffecte l'id
                        MessageBox.Show("L'id saisi est incorrecte. Si vous désirez rechercher un emplacement par ses coordonnées, veillez à laisser le champ ID emplacement vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Le format de l'id saisi est incorrecte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    id_emplacement = -1; //Desaffecte l'id
                }
            }
            else
            {
                id_Search_Check = GetIdEmplacement(); //Récupère l'id saisie en recherche

                if (id_Search_Check != -1) //Test si l'id est valable
                {
                    id_emplacement = id_Search_Check; //Affecte l'id
                }
                else
                {
                    MessageBox.Show("L'emplacement recherché n'existe pas ou a été mal saisi", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    id_emplacement = -1; //Desaffecte l'id
                }
            }
        }

        private void RechercherButton_Click(object sender, EventArgs e)
        {
            SetIdEmplacement();
            if (id_emplacement != -1)//verifie que l'id saisie est valide
            {
                if (listArchive == null)
                {
                    listArchive = new ListingArchiveEmplacementForm(conn, id_emplacement, this);
                    listArchive.FormClosed += ListArchive_FormClosed; ;
                    listArchive.MdiParent = this.MdiParent;
                    listArchive.Dock = DockStyle.Fill;
                    listArchive.Show();
                }
                else
                {
                    listArchive.Activate();
                }

            }
        }

        private void ListArchive_FormClosed(object sender, FormClosedEventArgs e)
        {
            listArchive = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetIdEmplacement();
            if (id_emplacement != -1)//verifie que l'id saisie est valide
            {
                if (infoEmplacement == null)
                {
                    infoEmplacement = new InfoEmplacement(conn, id_emplacement, this);
                    infoEmplacement.FormClosed += InfoEmplacement_FormClosed; ; ;
                    infoEmplacement.MdiParent = this.MdiParent;
                    infoEmplacement.Dock = DockStyle.Fill;
                    infoEmplacement.Show();
                }
                else
                {
                    infoEmplacement.Activate();
                }
            }
        }

        private void InfoEmplacement_FormClosed(object sender, FormClosedEventArgs e)
        {
            infoEmplacement = null; 
        }

        private void SetLieux()
        {
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

        private bool CheckIdEmplacement(int id)
        {
            bool check = false;
            try
            {
                var check_query = new NpgsqlCommand("SELECT COUNT(*) FROM emplacement WHERE id_emplacement = @id", conn);
                check_query.Parameters.AddWithValue("@id", id);

                //Check l'existence
                if ((long)check_query.ExecuteScalar() == 1)
                {
                    check = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur recherche de l'id emplacement " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return check;
        }

        private int SearchIdEmplacement (int lieu, int epi, int etagere, int tablette)
        {
            int id = -1; //renvoie -1 si l'emplacement n'existe pas
            try
            {
                var search_query = new NpgsqlCommand("SELECT id_emplacement FROM emplacement WHERE id_lieu = @id_lieu AND epi = @epi AND etagere = @etagere AND tablette = @tablette", conn);
                search_query.Parameters.AddWithValue("@id_lieu", lieu);
                search_query.Parameters.AddWithValue("@epi", epi);
                search_query.Parameters.AddWithValue("@etagere", etagere);
                search_query.Parameters.AddWithValue("@tablette", tablette);

                if(search_query.ExecuteScalar() != null)
                {
                    id = (int)search_query.ExecuteScalar();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur recherche de l'emplacement " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return id;
        }

        private bool CheckSearchIdEmplacement()
        {
            bool check_lieu = false;
            bool check_epi = false;
            bool check_etagere = false;
            bool check_tablette = false;


            //Check que l'id n'est pas -1
            if (id_lieu != -1)
            {
                check_lieu = true;
            }
            else
            {
                MessageBox.Show("Lieu saisi invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Check que epi non null et un entier
            if (EpitextBox.Text != string.Empty)
            {
                if (int.TryParse(EpitextBox.Text, out epi)) //test la conversion et affecte à epi si réussie
                {
                    check_epi = true;
                }
                else
                {
                    MessageBox.Show("Epi saisi invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Epi saisi invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Check que etagere non null et un entier
            if (EtagereTextBox.Text != string.Empty)
            {
                if (int.TryParse(EtagereTextBox.Text, out etagere)) //test la conversion et affecte à epi si réussie
                {
                    check_etagere = true;
                }
                else
                {
                    MessageBox.Show("Etagere saisi invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Etagere saisi invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Check que tabeltte non null et un entier
            if (TabletteTextBox.Text != string.Empty)
            {
                if (int.TryParse(TabletteTextBox.Text, out tablette)) //test la conversion et affecte à epi si réussie
                {
                    check_tablette = true;
                }
                else
                {
                    MessageBox.Show("Tablette saisi invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Tablette saisi invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return check_lieu && check_epi && check_etagere && check_tablette;
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

        private void LieuComboBox_TextChanged(object sender, EventArgs e)
        {
            SetIdLieu(LieuComboBox.Text);
        }

        private void LieuComboBox_SelectedValueChanged(object sender, EventArgs e)
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

        private void SearchEmplacementForm_Load(object sender, EventArgs e)
        {
            CentrerPanneau(); 
        }
    }
}