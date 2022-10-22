using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class frmRandomBattleDamageInput : Form
    {

        public frmRandomBattleDamageInput()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                int MinValue = Convert.ToInt16(txtMinumumDamage.Text);
                int MaxValue = Convert.ToInt16(txtMaximumDamage.Text);
                Properties.Settings.Default.MinRandomBattleDamage = MinValue;
                Properties.Settings.Default.MaxRandomBattleDamage = MaxValue;
                this.Close();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmRandomBattleDamageInput_Load(object sender, EventArgs e)
        {
            txtMaximumDamage.Text = Properties.Settings.Default.MaxRandomBattleDamage.ToString();
            txtMinumumDamage.Text = Properties.Settings.Default.MinRandomBattleDamage.ToString();
        }
    }
}
