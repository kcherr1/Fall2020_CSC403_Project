using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class ControlsPage : Form
    {
        public ControlsPage()
        {
            InitializeComponent();
        }

        private void btnCloseControls_Click(object sender, EventArgs e)
        {
            MainSettingsPage mainSettingsPage = new MainSettingsPage();
            mainSettingsPage.Show();
            this.Hide();
        }
    }
}
