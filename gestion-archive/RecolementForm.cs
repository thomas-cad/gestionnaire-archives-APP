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
    public partial class RecolementForm : Form
    {
        private NpgsqlConnection conn;
        private int id_emplacement;
        public RecolementForm(NpgsqlConnection conn_main_form)
        {
            InitializeComponent();
            conn = conn_main_form;
        }

        /*
         * R : Récupère l'id, verifie son existance
         * E : void
         * E/S : void
         * S : void
         */
        private void IdEmplacement()
        {
            /*
            try
            {
                id_emplacement = int.Parse(IdEmplacementTextBox.Text);

                var requete_emplacement = new NpgsqlCommand("SELECT * FROM emplacement WHERE id_emplacement = @id_emplacement", conn);
                requete_emplacement.Parameters.AddWithValue("@id_emplacement", id_emplacement);

            }
            */
        }

        private void IdEmplacementTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Enter) 
            { 
                this.IdEmplacement(); //Appelle méthode IdEmplacement L.23 si la touche entrée est pressée
            }
        }
    }
}
