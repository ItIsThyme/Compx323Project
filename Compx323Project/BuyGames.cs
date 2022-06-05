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
    public partial class BuyGames : Form
    {
        public string username;

        public List<string> orderProducts = new List<string>();
        public List<int> orderProductsIds = new List<int>();

        public List<string> games = new List<string>();
        public List<int> gameIds = new List<int>();
        
        public BuyGames(string un)
        {
            InitializeComponent();
            username = un;
            DisplayGames();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuForm = new Menu(username);
            menuForm.Show();
            this.Close();
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            if (listBoxGames.SelectedItem != null)
            {
                string game = games[listBoxGames.SelectedIndex];
                int gameId = gameIds[listBoxGames.SelectedIndex];

                orderProducts.Add(game);
                orderProductsIds.Add(gameId);

                DisplayOrder();
            }
            else
            {
                MessageBox.Show("Please select a game list first");
            }
        }

        private void DisplayOrder()
        {
            foreach(string game in orderProducts)
            {
                listBoxOrder.Items.Add(game);
            }
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
                cmd.CommandText = "select title from product";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                //add them all to the text box
                while (dr.Read())
                {
                    games.Add(dr.GetString(0));
                    gameIds.Add(int.Parse(dr.GetString(1)));
                }
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error");
                return;
            }

            foreach(string game in games)
            {
                games.Add(game);
            }
        }

        private void buttonDeleteFromOrder_Click(object sender, EventArgs e)
        {
            if(listBoxOrder.SelectedItem == null)
            {
                MessageBox.Show("Please select a game from your cart to delete.");
                return;
            }

            orderProducts.RemoveAt(listBoxOrder.SelectedIndex);
            orderProductsIds.RemoveAt(listBoxOrder.SelectedIndex);
            DisplayOrder();
        }

        private void buttonGameInfo_Click(object sender, EventArgs e)
        {
            if(listBoxGames.SelectedItem == null)
            {
                MessageBox.Show("Please select a game.");
                return;
            }

            int gameId = gameIds[listBoxGames.SelectedIndex];
            var gameInfoForm = new GameInformation(gameId);
            gameInfoForm.Show();
        }

        private void buttonGameReview_Click(object sender, EventArgs e)
        {
            if (listBoxGames.SelectedItem == null)
            {
                MessageBox.Show("Please select a game.");
                return;
            }

            int gameId = gameIds[listBoxGames.SelectedIndex];
            var gameReviewForm = new GameReviews(gameId);
            gameReviewForm.Show();
        }
    }
}
