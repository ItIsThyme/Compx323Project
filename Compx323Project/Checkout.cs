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
            int cost = 0;

            try
            {
                //Data source is the Uni's. ID/Password should probably be Caleb's since he has done the SQL
                string oradb = "Data Source= oracle.cms.waikato.ac.nz:1521/teaching;User Id=user;Password=hr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                foreach (int gameId in ids)
                {
                    cmd.CommandText = "select title, price from product where id = " + gameId;
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();

                    listBoxCart.Items.Add(dr.GetString(0));
                    int price = int.Parse(dr.GetString(1));
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
            string oradb = "Data Source= oracle.cms.waikato.ac.nz:1521/teaching;User Id=user;Password=hr;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // need to retrieve the users username as well as the product they are reviewing
            //cmd.CommandText = "insert into order() values ('" +
                
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var buyGamesForm = new BuyGames(username);
            buyGamesForm.Show();
            this.Close();
        }
    }
}
