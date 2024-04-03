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
    public partial class InfoArchivesDetailForm : Form
    {
        InfosArchivesForm infosarchives; 
        public InfoArchivesDetailForm()
        {
            InitializeComponent();
        }

        private void button_retour_Click(object sender, EventArgs e)
        {
            // Afficher le form de InfoArchives
            if (infosarchives == null)
            {
                infosarchives = new InfosArchivesForm();
                infosarchives.FormClosed += Infosarchives_FormClosed;
                infosarchives.MdiParent = this.MdiParent;
                infosarchives.Dock = DockStyle.Fill;
                infosarchives.Show();
            }
            else
            {
                infosarchives.Activate();
            }
        }

        private void Infosarchives_FormClosed(object sender, FormClosedEventArgs e)
        {
            infosarchives = null;
        }

        private void main_label_Click(object sender, EventArgs e)
        {

        }
    }
}
