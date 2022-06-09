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
            listBoxReviews.Items.Add("Rating".PadRight(9) + "Review");
            int r1 = 0;
            int r2 = 0;
            int r3 = 0;
            int r4 = 0;
            int r5 = 0;

            //use sql select statement to get all games
            try
            {
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=ar233;Password=ora201830;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();

                string query = "select r.id, r.title, r.rating, p.title from review r inner join product p on r.product_id = p.id where r.product_id = " + gameId;
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                
                //add them all to the text box
                while (dr.Read())
                {
                    reviewIds.Add(int.Parse(dr.GetString(0)));
                    int rating = int.Parse(dr.GetString(2));
                    string title = dr.GetString(1);
                    string game = dr.GetString(3);
                    textBoxGame.Text = game;
                    listBoxReviews.Items.Add(rating.ToString().PadRight(9) + title);

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
            if (listBoxReviews.SelectedItem == null || listBoxReviews.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a review.");
                return;
            }

            int reviewId = reviewIds[listBoxReviews.SelectedIndex - 1];
            var viewReviewForm = new ViewReview(reviewId);
            viewReviewForm.Show();
        }
    }
}
