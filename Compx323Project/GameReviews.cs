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
    public partial class GameReviews : Form
    {
        public int gameId;

        public List<int> reviewIds = new List<int>();

        public GameReviews(int gid)
        {
            InitializeComponent();
            gameId = gid;
            DisplayReviews();
        }

        public void DisplayReviews()
        {
            int r1 = 0;
            int r2 = 0;
            int r3 = 0;
            int r4 = 0;
            int r5 = 0;

            //use sql select statement to get all games
            try
            {
                //Data source is the Uni's. ID/Password should probably be Caleb's since he has done the SQL
                string oradb = "Data Source= oracle.cms.waikato.ac.nz:1521/teaching;User Id=user;Password=hr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select id, title, rating from review where product_id = " + gameId;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                //add them all to the text box
                while (dr.Read())
                {
                    reviewIds.Add(int.Parse(dr.GetString(0)));
                    int rating = int.Parse(dr.GetString(2));
                    string title = dr.GetString(1);
                    listBoxReviews.Items.Add(rating.ToString().PadRight(4) + title);

                    if(rating == 1)
                    {
                        r1++;
                    }
                    else if(rating == 2)
                    {
                        r2++;
                    }
                    else if(rating == 3)
                    {
                        r3++;
                    }
                    else if(rating == 4)
                    {
                        r4++;
                    }
                    else if(rating == 5)
                    {
                        r5++;
                    }
                }
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error");
                return;
            }

            textBox1.Text = r1.ToString();
            textBox2.Text = r2.ToString();
            textBox3.Text = r3.ToString();
            textBox4.Text = r4.ToString();
            textBox5.Text = r5.ToString();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpenReview_Click(object sender, EventArgs e)
        {
            if (listBoxReviews.SelectedItem == null)
            {
                MessageBox.Show("Please select a review.");
                return;
            }

            int gameId = reviewIds[listBoxReviews.SelectedIndex];
            var gameReviewForm = new GameReviews(gameId);
            gameReviewForm.Show();
        }
    }
}
