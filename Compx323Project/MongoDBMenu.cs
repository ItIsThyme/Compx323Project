using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compx323Project
{
    public partial class MongoDBMenu : Form
    {
        public String username;
        public MongoDBMenu()
        {
            InitializeComponent();
        }

        private void getGames_Click(object sender, EventArgs e)
        {
            gameListBox.Items.Clear();
            try
            {                
                //mongo expression to get all games here
            }
            catch (Exception x)
            {
                MessageBox.Show("Database connection error");
                return;
            }
        }

        private void userGamesButton_Click(object sender, EventArgs e)
        {
            gameListBox.Items.Clear();
            //loads users games into the list box
            try
            {
                /* use mongo expression to get all games with username
                 * 
                //add them all to the text box
                while (dr.Read())
                {
                    //'0' is id from select statement and '1' is title
                    gameListBox.Items.Add(dr.GetString(0));
                }
                */
            }
            catch (Exception x)
            {
                MessageBox.Show("Database connection error");
                return;
            }
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            String password = passwordTextBox.Text;
            //do mongo expression here, search for username and if found then check password match - this code should work but dr doesn't exist so leaving it as a placeholder
            /* if (dr.Read())  //must be a user if the select worked
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
            }*/
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
            // will have to pass this to review somehow -> gameListBox.SelectedItem.ToString();
            // as well as username (global variable from login)
            if (username.Equals(""))
            {
                MessageBox.Show("Please log in to place a review");
                return;
            }
            /* Do new mongo review form here
            this.Hide();
            Review reviewForm = new Review();
            reviewForm.ShowDialog();
            this.Show();
            */
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

        private void oracleButton_Click(object sender, EventArgs e)
        {
            //this should just be a dialogue so we can just close it to return
            this.Close();
        }
    }
}
