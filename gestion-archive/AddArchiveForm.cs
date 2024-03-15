using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using data_base;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace gestion_archive
{
    public partial class AddArchiveForm : Form
    {
        public AddArchiveForm()
        {
            InitializeComponent();
        }

        private void formOutil1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void bigLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {
            using (var conn = Data_base.GetDBConnection("systeme_archive"))
                try
                {
                    conn.Open();
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//Show error message
                }
        }
    }
}
