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
    public partial class ReviewDetailsForm : Form
    {
        Review review;

        public ReviewDetailsForm(Review review, string productName)
        {
            InitializeComponent();
            this.review = review;
            textBoxGame.Text = productName;

            DisplayReview();
        }

        private void DisplayReview()
        {
            textBoxTitle.Text = review.Title;
            textBoxDescription.Text = review.Description;
            textBoxRating.Text = review.Rating.ToString();
            textBoxUsername.Text = review.Reviewer;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
