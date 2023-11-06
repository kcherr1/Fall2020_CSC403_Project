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
    public partial class NextLevel : Form
    {
        public NextLevel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create Level2 and show it
            Level2 frm = new Level2();
            frm.Show();
            // Whenever FrmLevel is closed, execute onFormClosed method
            frm.FormClosed += frm.OnFormClosed;
            // music.Stop();
            Hide();
        }
    }
}
