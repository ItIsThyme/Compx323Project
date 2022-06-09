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
    public partial class Checkout : Form
    {
        public List<int> ids;
        public string username;

        public Checkout(string un, List<int> gid)
        {
            InitializeComponent();
            username = un;
            ids = gid;
            DisplayInfo();
        }

        public void DisplayInfo()
        {
            double cost = 0;

            try
            {
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=ar233;Password=ora201830;";
                OracleConnection conn = new OracleConnection(oradb); 
                conn.Open();               

                foreach (int gameId in ids)
                {
                    string query = "select title, price from product where id = " + gameId;
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();

                    dr.Read();

                    listBoxCart.Items.Add(dr.GetString(0));
                    double price = double.Parse(dr.GetString(1));
                    cost += price;
                }
                conn.Dispose();
            }
            catch (Exception ex)
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
                var dt = System.DateTime.Now;

                string timestamp = "'" + dt.Day.ToString("D2") + "-" + dt.Month.ToString("D2") + "-" + dt.Year + " " + dt.Hour.ToString("D2") + ":" + dt.Minute.ToString("D2") + ":" + dt.Second.ToString("D2") + "'";
                int rowsInserted = 0;

                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=ar233;Password=ora201830;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();

                string query = "insert into orders values (" + timestamp + ",'" + username + "')";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.CommandType = CommandType.Text;

                rowsInserted += cmd.ExecuteNonQuery();

                foreach (int id in ids)
                {
                    query = "insert into order_products values (" + timestamp + ",'" + username + "'," + id + ")";
                    cmd = new OracleCommand(query, conn);
                    cmd.CommandType = CommandType.Text;
                    rowsInserted += cmd.ExecuteNonQuery();
                }

                if(rowsInserted == 0)
                {
                    MessageBox.Show("Error processing order.");
                }
                else
                {
                    MessageBox.Show("Order Successful.");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error processing order.");
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
