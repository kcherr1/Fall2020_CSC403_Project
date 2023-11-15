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
    public partial class FrmSettings : Form
    {
        private Form previousForm;


        public FrmSettings(Form previous)
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.setup();

            previousForm = previous;
        }
        private void setup()
        {
            this.BackColor = Color.DimGray;

            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;

            // Add Buttons For Return and Exit
            Button ReturnButton = new Button();
            Button ExitButton = new Button();

            ReturnButton.Location = new Point((width / 3), (height / 8));
            ExitButton.Location = new Point((width / 3), (2 * height / 8));

            ReturnButton.Size = new Size(width / 3, height / 10);
            ExitButton.Size = new Size(width / 3, height / 10);

            ReturnButton.Text = ("Return");
            ExitButton.Text = ("Quit Game");

            ReturnButton.Font = new Font("NSimSun", ReturnButton.Size.Height / 2);
            ExitButton.Font = new Font("NSimSun", ExitButton.Size.Height / 2);

            ReturnButton.Parent = this;
            ExitButton.Parent = this;

            ReturnButton.Click += ReturnButton_Click;
            ExitButton.Click += ExitButton_Click;



        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }
    }
}
