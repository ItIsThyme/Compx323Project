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
    public partial class CreateReviewForm : Form
    {
        Product productBeingReviewed;

        public CreateReviewForm(Product product)
        {
            InitializeComponent();
            
            productBeingReviewed = product;
            textBoxGame.Text = product.Title;
        }

        private void submitReviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                string title = titleTextBox.Text;
                string description = descriptionTextBox.Text;
                int ratingIndex = reviewComboBox.SelectedIndex;

                if(title == "" || description == "" || ratingIndex == -1)
                {
                    MessageBox.Show("Review must contain a title, description, and a rating.");
                }
                else
                {
                    int rating = reviewComboBox.SelectedIndex + 1;

                    var review = new Review()
                    {
                        Title = title,
                        Description = description,
                        Rating = rating,
                    };

                    App.DataService.InsertReview(review, productBeingReviewed);

                    MessageBox.Show("Review submitted.");
                    Hide();
                    var ownedGamesForm = new OwnedGames();
                    ownedGamesForm.Show();
                    Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.ToString());
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            var ownedGamesForm = new OwnedGames();
            ownedGamesForm.Show();
            this.Close();
        }
    }
}
