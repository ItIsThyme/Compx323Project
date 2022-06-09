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
    public partial class ChooseDatabaseTypeForm : Form
    {
        public ChooseDatabaseTypeForm()
        {
            InitializeComponent();
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            string address = textBoxAddress.Text;

            if (radioButtonMongo.Checked)
                App.StartDatabase(DatabaseType.MongoDb, address);
            else
                App.StartDatabase(DatabaseType.Oracle, address);

            var loginForm = new LoginForm();

            loginForm.Show();

            Hide();
        }
    }
}
