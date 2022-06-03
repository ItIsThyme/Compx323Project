using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Compx323Project
{
    public partial class MenuScreen : Form
    {
        public String username;
        public MenuScreen()
        {
            InitializeComponent();
        }


        private void getGames_Click(object sender, EventArgs e)
        {
            //use sql select statement to get all games
            try
            {
                //Data source is the Uni's. ID/Password should probably be Caleb's since he has done the SQL
                string oradb = "Data Source= oracle.cms.waikato.ac.nz:1521/teaching;User Id=user;Password=hr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select title from product";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                //add them all to the text box
                while (dr.Read())
                {
                    //'0' is id from select statement and '1' is title
                    gameListBox.Items.Add(dr.GetString(0));
                }
                conn.Dispose();
            }catch (Exception x)
            {
                MessageBox.Show("Database connection error");
                return;
            }
        }

        private void addReview_Click(object sender, EventArgs e)
        {
            //get the game selected in the listbox
            object selected = gameListBox.SelectedItem;
            //if no game is selected then use a popup to request an input
            if (selected == null)
            {
                MessageBox.Show("Please select the item in the listbox you want to review");
                return;
            }
            //else open a new form to allow the user to add a review to the game
            this.Hide();
            // will have to pass this to review somehow -> gameListBox.SelectedItem.ToString();
            // as well as username (global variable from login)
            if (username.Equals(""))
            {
                MessageBox.Show("Please log in to place a review");
                return;
            }
            Review reviewForm = new Review();
            reviewForm.ShowDialog();
            this.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            String password = passwordTextBox.Text;
            string oradb = "Data Source= oracle.cms.waikato.ac.nz:1521/teaching;User Id=user;Password=hr;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select username, password from user where username like " + username;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())  //must be a user if the select worked
            {
                if (dr.GetString(1).Equals(password)) //if password same login else error
                {
                    usernameTextBox.Enabled = false;
                    usernameTextBox.Hide();
                    passwordTextBox.Enabled = false;
                    passwordTextBox.Hide();
                    usernameLabel.Hide();
                    passwordLabel.Hide();
                    loginButton.Enabled = false;
                    loginButton.Hide();
                    errorLabel.Text = "";

                    loggedinLabel.Text = "Logged in as: " + username;
                    logoutButton.Show();
                    logoutButton.Enabled = true;
                }
                else
                {
                    errorLabel.Text = "Incorrect username or password";
                }
            }
            else
            {
                errorLabel.Text = "No user found with username: " + username;
            }

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //resets username, shows login info again and disables all logout information
            username = "";
            usernameTextBox.Enabled = true;
            usernameTextBox.Show();
            passwordTextBox.Enabled = false;
            passwordTextBox.Show();
            usernameLabel.Show();
            passwordLabel.Show();
            loginButton.Enabled = false;
            loginButton.Show();

            loggedinLabel.Text = "";
            logoutButton.Hide();
            logoutButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (gameListBox.SelectedItem != null)
            {
                orderListBox.Items.Add(gameListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item from the games list first");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (orderListBox.SelectedItem != null)
            {
                gameListBox.Items.Add(orderListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item from the order list first");
            }
        }

        private void orderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (username.Equals(""))
            {
                MessageBox.Show("Please log in before placing an order");
                return;
            }
            //place order here
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
