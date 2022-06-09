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
    public partial class Checkout : Form
    {
        Order order;

        public Checkout(Order order)
        {
            InitializeComponent();

            this.order = order;
            DisplayInfo();
        }

        public void DisplayInfo()
        {
            decimal cost = order.Products.Sum(x => x.Price);

            try
            {
                foreach (var product in order.Products)
                    listBoxCart.Items.Add(product);
            }
            catch
            {
                MessageBox.Show("Database connection error");
                return;
            }

            textBoxCost.Text = cost.ToString("c");
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                App.DataService.InsertOrder(order);

                MessageBox.Show($"Successful purchase of {order.Products.Count} items.");

                buttonBack_Click(this, null);
            }

            catch
            {
                MessageBox.Show("An error prevented order completion.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
