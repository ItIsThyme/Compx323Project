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
    public partial class GameInformation : Form
    {
        public int gameId;
        public GameInformation(int gid)
        {
            InitializeComponent();
            gameId = gid;
            DisplayGameInformation();
        }

        private void DisplayGameInformation()
        {
            try
            {
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=ar233;Password=ora201830;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();

                string query = "select p.title, p.description, p.listing_date, pb.name, p.age_rating from " +
                    "product p inner join publisher pb on p.publisher_id = pb.id where p.id = " + gameId;
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                dr.Read();

                string gameName = dr.GetString(0);
                string gameDescription = dr.GetString(1);
                string releaseDate = dr.GetString(2);
                string publisher = dr.GetString(3);
                string age = dr.GetString(4);

                textBoxName.Text = gameName;
                textBoxDescription.Text = gameDescription;
                textBoxDate.Text = releaseDate;
                textBoxPublisher.Text = publisher;
                textBoxAgeRating.Text = age;

                conn.Dispose();
            }
            catch
            {
                MessageBox.Show("Error displaying game information.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
