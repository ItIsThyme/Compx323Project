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
    public partial class GameReviews : Form
    {
        Product productBeingReviewed;

        public GameReviews(Product product)
        {
            InitializeComponent();

            productBeingReviewed = product;
            DisplayReviews();
        }

        public void DisplayReviews()
        {
            textBoxGame.Text = productBeingReviewed.Title;

            try
            {
                var productReviews = App.DataService.GetReviewsForProduct(productBeingReviewed);

                foreach (var productReview in productReviews)
                    listBoxReviews.Items.Add(productReview);

                textBox1.Text = productReviews.Count(x => x.Rating is 1).ToString();
                textBox2.Text = productReviews.Count(x => x.Rating is 2).ToString();
                textBox3.Text = productReviews.Count(x => x.Rating is 3).ToString();
                textBox4.Text = productReviews.Count(x => x.Rating is 4).ToString();
                textBox5.Text = productReviews.Count(x => x.Rating is 5).ToString();
            }
            catch
            {
                MessageBox.Show("Database connection error");
                return;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOpenReview_Click(object sender, EventArgs e)
        {
            if (listBoxReviews.SelectedItem == null)
            {
                MessageBox.Show("Please select a review.");
                return;
            }

            var selectedReview = listBoxReviews.SelectedItem as Review;
            var gameReviewForm = new ReviewDetailsForm(selectedReview, productBeingReviewed.Title);
            gameReviewForm.Show();
        }
    }
}
