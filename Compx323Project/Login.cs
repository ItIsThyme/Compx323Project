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
            try
            {
                string oradb = "Data Source= oracle.cms.waikato.ac.nz:1521/teaching;User Id=user;Password=hr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select username, password from user where username like '" + username + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())  //must be a user if the select worked
                {
                    if (dr.GetString(1).Equals(password)) //if password same login else error
                    {
                        this.Hide();
                        var menuForm = new Menu(username);
                        menuForm.Show();
                        this.Close();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: \n" + ex.ToString());
            }

        }
    }
}
