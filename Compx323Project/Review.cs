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
    public partial class Review : Form
    {
        public string username;
        public string game;
        public int gameId;

        public Review(string un, string g, int gid)
        {
            InitializeComponent();
            username = un;
            game = g;
            gameId = gid;
            textBoxGame.Text = game;
        }

        private void submitReviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                string title = titleTextBox.Text;
                string description = descriptionTextBox.Text;
                int rating = reviewComboBox.SelectedIndex;

                if(title == "" || description == "" || rating == -1)
                {
                    MessageBox.Show("Review must contain a title, description, and a rating.");
                }
                else
                {
                    rating = int.Parse(reviewComboBox.SelectedItem.ToString());

                    string oradb = "Data Source= oracle.cms.waikato.ac.nz:1521/teaching;User Id=user;Password=hr;";
                    OracleConnection conn = new OracleConnection(oradb);  // C#
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    // need to retrieve the users username as well as the product they are reviewing
                    cmd.CommandText = "insert into review(title, description, rating, product_id, username) values ('" +
                        title + "', '" +
                        description + "', " +
                        rating + ", " +
                        gameId + ", '" +
                        username + "');";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();

                    MessageBox.Show("Review submitted.");
                    this.Hide();
                    var ownedGamesForm = new OwnedGames(username);
                    ownedGamesForm.Show();
                    this.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.ToString());
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ownedGamesForm = new OwnedGames(username);
            ownedGamesForm.Show();
            this.Close();
        }
    }
}
