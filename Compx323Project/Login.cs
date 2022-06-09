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
    public partial class LoginForm : Form
    {
        // global variable storing the logged in users username
        public string username = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            try
            {
                bool success = App.DataService.AttemptLogin(username, password);

                if (success) //if password same login else error
                {
                    App.ActiveUserName = username;

                    Hide();

                    var menuForm = new MenuForm();
                    menuForm.Show();
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
