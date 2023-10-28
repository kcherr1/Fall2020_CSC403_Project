﻿using System;
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
    public partial class FrmCharacterSelect : Form
    {
        public FrmLevel theGame = null;
        public FrmCharacterSelect()
        {
            InitializeComponent();
        }

        private void selectMr_Click(object sender, EventArgs e)
        {
            theGame = FrmLevel.GetInstance(0);
            theGame.character = "mr";
            theGame.Show();
            this.Hide();
        }

        private void selectMs_Click(object sender, EventArgs e)
        {
            theGame = FrmLevel.GetInstance(0);
            theGame.character = "mrs";
            theGame.Show();
            this.Hide();
        }

        private void selectBaby_Click(object sender, EventArgs e)
        {
            theGame = FrmLevel.GetInstance(0);
            theGame.character = "baby";
            theGame.Show();
            this.Hide();
        }

        private void FrmCharacterSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
