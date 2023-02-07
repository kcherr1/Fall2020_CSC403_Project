using Fall2020_CSC403_Project.code;
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
    public partial class FrmCharacter : Form
    {
        private FrmLevel frmlvl;

        private string _character = string.Empty;

        public string character
                {
                    get
                    {
                        return _character;
                    }
                    set
                    {
                        if (_character != value)
                            _character = value;
                    }
                }


        public FrmCharacter()
        {
            InitializeComponent();
        }

        private void orginial_peanut_Click(object sender, EventArgs e)
        {
            frmlvl = new FrmLevel();
            this.Close();
            frmlvl.Show();
        }

        private void Honey_peanut_Click(object sender, EventArgs e)
        {
            frmlvl = new FrmLevel();
            character = "b";
            this.Close();
            frmlvl.Show();
        }

        private void Crunchy_peanut_Click(object sender, EventArgs e)
        {
            frmlvl = new FrmLevel();
            character = "c";
            this.Close();
            frmlvl.Show();
        }

        private void Salty_peanut_Click(object sender, EventArgs e)
        {
            frmlvl = new FrmLevel();
            character = "d";
            this.Close();
            frmlvl.Show();
        }

        public static implicit operator FrmCharacter(string v)
        {
            throw new NotImplementedException();
        }

    }
}
