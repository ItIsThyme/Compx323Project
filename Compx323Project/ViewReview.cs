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
        }

        private void DisplayReview()
        {
            //use sql select statement to get all games
            try
            {
                //Data source is the Uni's. ID/Password should probably be Caleb's since he has done the SQL
                string oradb = "Data Source= oracle.cms.waikato.ac.nz:1521/teaching;User Id=user;Password=hr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select r.title, r.description, r.rating, r.username, p.title from " +
                    "review r inner join product p on r.product_id = p.id where r.id = " + reviewId;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                //add them all to the text box
                while (dr.Read())
                {
                    textBoxGame.Text = dr.GetString(4);
                    textBoxTitle.Text = dr.GetString(0);
                    textBoxDescription.Text = dr.GetString(1);
                    textBoxRating.Text = dr.GetString(2);
                    textBoxUsername.Text = dr.GetString(3);
                }
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
