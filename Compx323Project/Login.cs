using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Compx323Project
{
    public partial class Login : Form
    {
        // global variable storing the logged in users username
        public string username = "";

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a valid username and password.");
                return;
            }

            try
            {
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=ar233;Password=ora201830;";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();

                string query = "select username, password from accounts where username = '" + username + "'";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                dr.Read();

                if (dr.HasRows)
                {
                    string un = dr.GetString(0);
                    string pass = dr.GetString(1);
                    if (un == username && pass == password) //if password same login else error
                    {
                        conn.Dispose();
                        this.Hide();
                        var menuForm = new Menu(username);
                        menuForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }

                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: \n" + ex.ToString());
            }

        }
    }
}
