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
    public partial class OwnedGames : Form
    {
        public string username;

        public List<string> gameNames = new List<string>();
        public List<int> gameIds = new List<int>();

        public OwnedGames(string un)
        {
            InitializeComponent();
            username = un;
            DisplayGames();
        }

        public void DisplayGames()
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
                cmd.CommandText = "select distinct p.id, p,title from product p inner join order o on p.id = o.pid where" +
                    " o.username = '" + username + "'";

                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                //add them all to the text box
                while (dr.Read())
                {
                    gameNames.Add(dr.GetString(0));
                    gameIds.Add(int.Parse(dr.GetString(1)));
                }
                conn.Dispose();

                for(int i = 0; i < gameNames.Count; i++)
                {
                    listBoxGames.Items.Add(gameNames);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error");
                return;
            }
        }

        private void buttonReview_Click(object sender, EventArgs e)
        {
            //get the game selected in the listbox
            string selectedGame = listBoxGames.SelectedItem.ToString();
            //if no game is selected then use a popup to request an input
            if (selectedGame == null)
            {
                MessageBox.Show("Please select the item in the listbox you want to review");
                return;
            }

            int gameId = gameIds[listBoxGames.SelectedIndex];

            //else open a new form to allow the user to add a review to the game
            this.Hide();
            var reviewForm = new Review(username, selectedGame, gameId);
            reviewForm.ShowDialog();
            this.Close();
        }

        private void buttonViewInformation_Click(object sender, EventArgs e)
        {
            //if no game is selected then use a popup to request an input
            if (listBoxGames.SelectedItem == null)
            {
                MessageBox.Show("Please select the item in the listbox you want to review");
                return;
            }

            int gameId = gameIds[listBoxGames.SelectedIndex];
            var gameInfoForm = new GameInformation(gameId);
            gameInfoForm.Show();
        }
    }
}
