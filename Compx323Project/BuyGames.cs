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
                MessageBox.Show("Please select a game from the list first");
            }
        }

        private void DisplayOrder()
        {
            listBoxOrder.Items.Clear();
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
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=ar233;Password=ora201830;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();

                string query = "select title, id from product";
                OracleCommand cmd = new OracleCommand(query, conn);
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

            //ListBox listBoxGames = new ListBox();

            foreach(string game in games)
            {
                listBoxGames.Items.Add(game);
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

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if(orderProducts.Count == 0)
            {
                MessageBox.Show("Order cannot contain 0 products.");
                return;
            }

            var checkoutForm = new Checkout(username, orderProductsIds);
            checkoutForm.Show();
        }
    }
}
