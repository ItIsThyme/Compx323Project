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
    public partial class ViewReview : Form
    {
        public int reviewId;

        public ViewReview(int rid)
        {
            InitializeComponent();
            reviewId = rid;
            DisplayReview();
        }

        private void DisplayReview()
        {
            //use sql select statement to get all games
            try
            {
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=ar233;Password=ora201830;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();

                string query = "select r.title, r.description, r.rating, r.username, p.title from " +
                    "review r inner join product p on r.product_id = p.id where r.id = " + reviewId;
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                dr.Read();
                
                textBoxGame.Text = dr.GetString(4);
                textBoxTitle.Text = dr.GetString(0);
                textBoxDescription.Text = dr.GetString(1);
                textBoxRating.Text = dr.GetString(2);
                textBoxUsername.Text = dr.GetString(3);

                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error");
                return;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
