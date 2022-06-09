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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            textBoxUsername.Text = App.ActiveUserName;
        }

        /// <summary>
        /// Hides the current Menu Form and opens in Login Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void buttonBuyGames_Click(object sender, EventArgs e)
        {
            Hide();
            var buyGamesForm = new BuyGames();
            buyGamesForm.Show();
            this.Close();
        }

        private void buttonOwnedGames_Click(object sender, EventArgs e)
        {
            Hide();
            var ownedGamesForm = new OwnedGames();
            ownedGamesForm.Show();
            this.Close();
        }
    }
}
