using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using password;
using data_base;
using Npgsql;

namespace gestion_archive
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Empêche la saisie de la touche "Entrée"
                TextBox_Password.Focus();
            }
        }

        private void connection()
        {
            string user = TextBox_User.Text;
            string password = PasswordHasher.HashPassword(TextBox_Password.Text); //Hash du mp

            //Connection BDD
            using (var conn = Data_base.GetDBConnection("user"))
                try
                {
                    conn.Open();

                    var command = new NpgsqlCommand("SELECT COUNT(*) FROM user_company WHERE id = @user AND password = @password", conn);
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@password", password);

                    long count = (long)command.ExecuteScalar(); //Execute SQL

                    if (count == 1)
                    {
                        conn.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Connection refusée");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//Message d'erreur
                    Application.Exit(); //Ferme l'app
                }
        }

        private void TextBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true; // Empêche la saisie de la touche "Entrée"
                connection();
            }
        }
    }
}
