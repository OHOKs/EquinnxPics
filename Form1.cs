using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace EquinxPictures
{
    public partial class loginPanel : Form
    {
        public loginPanel()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlClonnection = new MySqlConnection("server=localhost;user=root;database=equinxpicturesusers;password=");
            MySqlCommand sqlCommand = new MySqlCommand();
            try
            {
                sqlClonnection.Open();
                sqlCommand.Connection = sqlClonnection;
                sqlCommand.CommandText = "SELECT * FROM users where username='" + userBox.Text + "' AND password='" + passwordBox.Text + "'";
                if (sqlCommand.ExecuteReader().Read())
                {
                    sqlClonnection.Close();
                    this.Hide();
                    eqMain eqMain = new eqMain();
                    eqMain.Show();
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
            }
            catch
            {
                MessageBox.Show("The server is currently offline!");
            }
        }

        private void form1Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
