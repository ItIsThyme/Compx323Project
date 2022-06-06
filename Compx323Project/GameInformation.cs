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
                //Data source is the Uni's. ID/Password should probably be Caleb's since he has done the SQL
                string oradb = "Data Source= oracle.cms.waikato.ac.nz:1521/teaching;User Id=user;Password=hr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select p.title, p.description, p.listing_date, pb.name from " +
                    "product p inner join publisher pb on p.publisher_id = pb.id where p.id = " + gameId;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                //add them all to the text box
                while (dr.Read())
                {
                    string gameName = dr.GetString(0);
                    string gameDescription = dr.GetString(1);
                    string releaseDate = dr.GetString(2);
                    string publisher = dr.GetString(3);
                }
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
