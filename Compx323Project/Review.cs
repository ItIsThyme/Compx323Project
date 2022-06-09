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

                    string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=ar233;Password=ora201830;";
                    OracleConnection conn = new OracleConnection(oradb);  // C#
                    conn.Open();

                    string query = "insert into review(title, description, rating, product_id, username) values ('" +
                        title + "', '" +
                        description + "', " +
                        rating + ", " +
                        gameId + ", '" +
                        username + "')";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    int x = cmd.ExecuteNonQuery();
                    
                    if(x != 0)
                    {
                        MessageBox.Show("Review submitted.");
                        this.Hide();
                        var ownedGamesForm = new OwnedGames(username);
                        ownedGamesForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Review was not able to be submitted");
                    }
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
