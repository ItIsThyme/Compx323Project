using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compx323Project
{
    public partial class Menu : Form
    {
        public string username; 
        public Menu(string un)
        {
            InitializeComponent();
            username = un;
            textBoxUsername.Text = username;
        }

        /// <summary>
        /// Hides the current Menu Form and opens in Login Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void buttonBuyGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            var buyGamesForm = new BuyGames(username);
            buyGamesForm.Show();
            this.Close();
        }

        private void buttonOwnedGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ownedGamesForm = new OwnedGames(username);
            ownedGamesForm.Show();
            this.Close();
        }
    }
}
