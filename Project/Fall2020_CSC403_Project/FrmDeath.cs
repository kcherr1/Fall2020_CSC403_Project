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
    public partial class FrmDeath : Form
    {
        public FrmDeath()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLevel Play = new FrmLevel();
            Play.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
