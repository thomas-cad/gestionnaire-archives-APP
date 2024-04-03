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
    public partial class InfosArchivesForm : Form
    {
        InfoArchivesDetailForm infoarchivesdetail; 
        public InfosArchivesForm()
        {
            InitializeComponent();
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            // Afficher le form de InfoArchives
            if (infoarchivesdetail == null)
            {
                infoarchivesdetail = new InfoArchivesDetailForm();
                infoarchivesdetail.FormClosed += Infoarchivesdetail_FormClosed; 
                infoarchivesdetail.MdiParent = this.MdiParent;
                infoarchivesdetail.Dock = DockStyle.Fill;
                infoarchivesdetail.Show();
            }
            else
            {
                infoarchivesdetail.Activate();
            }   
        }

        private void Infoarchivesdetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            infoarchivesdetail = null; 
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            panel2.Location = new Point((ClientSize.Width - panel2.Width) / 2, (ClientSize.Height - panel2.Height) / 2); //Centrer les éléments
        }
    }
}
