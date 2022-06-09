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
    public partial class GameDetailsForm : Form
    {
        Product product;

        public GameDetailsForm(Product product)
        {
            InitializeComponent();

            this.product = product;
            DisplayGameInformation();
        }

        private void DisplayGameInformation()
        {
            string publisherName = App.DataService.GetPublisherForProduct(product).Name;

            textBoxName.Text = product.Title;
            textBoxDescription.Text = product.Description;
            textBoxReleaseDate.Text = product.ListingDate.ToString();
            textBoxPublisher.Text = publisherName;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
