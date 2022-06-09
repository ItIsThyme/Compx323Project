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
    public partial class BuyGames : Form
    {
        Order order;
        
        public BuyGames()
        {
            InitializeComponent();

            order = new Order
            {
                Products = new List<Product>()
            };

            DisplayGames();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();

            var menuForm = new MenuForm();
            menuForm.Show();

            Close();
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            if (listBoxGames.SelectedItem != null)
            {
                order.Products.Add(listBoxGames.SelectedItem as Product);

                DisplayOrder();
            }
            else
            {
                MessageBox.Show("Please select a game list first");
            }
        }

        private void DisplayOrder()
        {
            listBoxOrder.Items.Clear();

            foreach (var product in order.Products)
                listBoxOrder.Items.Add(product);
        }

        public void DisplayGames()
        {
            var products = App.DataService.GetProducts();

            listBoxGames.Items.Clear();

            foreach (var product in products)
                listBoxGames.Items.Add(product);
        }

        private void buttonDeleteFromOrder_Click(object sender, EventArgs e)
        {
            if (!VerifySelection(listBoxOrder, "Please select a game from your cart to delete."))
                return;

            order.Products.Remove(listBoxOrder.SelectedItem as Product);

            DisplayOrder();
        }

        private void buttonGameInfo_Click(object sender, EventArgs e)
        {
            if (!VerifySelection(listBoxGames))
                return;

            var selectedProduct = listBoxGames.SelectedItem as Product;
            var gameInfoForm = new GameDetailsForm(selectedProduct);
            gameInfoForm.Show();
        }

        private void buttonGameReview_Click(object sender, EventArgs e)
        {
            if (!VerifySelection(listBoxGames))
                return;

            var selectedProduct = listBoxGames.SelectedItem as Product;
            var gameReviewForm = new GameReviews(selectedProduct);
            gameReviewForm.Show();
        }

        bool VerifySelection(ListBox listBox, string errorMessage = "Please select a game.")
        {
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show(errorMessage);
                return false;
            }

            return true;
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (order.Products.Count is 0)
            {
                MessageBox.Show("You have not added any items to your cart.");
                return;
            }

            new Checkout(order).ShowDialog();
        }
    }
}
