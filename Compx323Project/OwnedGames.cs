using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Compx323Project.Models;
using Oracle.ManagedDataAccess.Client;


namespace Compx323Project
{
    public partial class OwnedGames : Form
    {
        List<Product> productsOwned;

        public OwnedGames()
        {
            InitializeComponent();
            DisplayGames();
        }

        public void DisplayGames()
        {
            //use sql select statement to get all games
            try
            {
                productsOwned = App.DataService.GetProductsOwnedByUser();

                foreach (var product in productsOwned)
                    listBoxGames.Items.Add(product);
            }
            catch
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

            var selectedProduct = listBoxGames.SelectedItem as Product;

            var reviewForm = new CreateReviewForm(selectedProduct);
            reviewForm.ShowDialog();
        }

        private void buttonViewInformation_Click(object sender, EventArgs e)
        {
            //if no game is selected then use a popup to request an input
            if (listBoxGames.SelectedItem == null)
            {
                MessageBox.Show("Please select the item in the listbox you want to review");
                return;
            }

            var selectedProduct = listBoxGames.SelectedItem as Product;
            var gameInfoForm = new GameDetailsForm(selectedProduct);
            gameInfoForm.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();

            new MenuForm().Show();

            Close();
        }
    }
}
