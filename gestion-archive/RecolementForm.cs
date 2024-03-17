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
        public RecolementForm(NpgsqlConnection conn_main_form)
        {
            InitializeComponent();
            conn = conn_main_form;
        }
    }
}
