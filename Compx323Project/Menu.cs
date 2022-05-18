using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Compx323Project
{
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
        }


        private void getGames_Click(object sender, EventArgs e)
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
                cmd.CommandText = "select title from product";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                //add them all to the text box
                while (dr.Read())
                {
                    //'0' is id from select statement and '1' is title
                    gameListBox.Items.Add(dr.GetString(0));
                }
                conn.Dispose();
            }catch (Exception x)
            {
                MessageBox.Show("Database connection error");
                return;
            }
        }

        private void addReview_Click(object sender, EventArgs e)
        {
            //get the game selected in the listbox
            object selected = gameListBox.SelectedItem;
            //if no game is selected then use a popup to request an input
            if (selected == null)
            {
                MessageBox.Show("Please select the item in the listbox you want to review");
                return;
            }
            //else open a new form to allow the user to add a review to the game
            this.Hide();
            // will have to pass this to review somehow -> gameListBox.SelectedItem.ToString();
            Review reviewForm = new Review();
            reviewForm.ShowDialog();
            this.Show();
        }
    }
}
