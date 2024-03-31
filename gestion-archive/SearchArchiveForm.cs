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
    public partial class SearchArchiveForm : Form
    {
        public SearchArchiveForm()
        {
            InitializeComponent();
        }

        private void formArchives_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; 
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void RechercherButton_Click(object sender, EventArgs e)
        {

        }
    }
}
