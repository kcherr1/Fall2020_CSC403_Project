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
    public partial class SaveMenu : Form
    {
        private FrmLevel frmLevel;
        private bool SaveTextbox1_Clicked = false;
        private bool SaveTextbox2_Clicked = false;
        private bool SaveTextbox3_Clicked = false;

        public SaveMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // When Clicked the the box color changes
        private void SaveTextbox1_MouseClick(object sender, MouseEventArgs e)
        {
            SaveTextbox1_Clicked = true;
            SaveTextbox2_Clicked = false;
            SaveTextbox3_Clicked = false;
        }

        private void SaveTextbox2_MouseClick(object sender, MouseEventArgs e)
        {
            SaveTextbox1_Clicked = false;
            SaveTextbox2_Clicked = true;
            SaveTextbox3_Clicked = false;
        }

        private void SaveTextbox3_MouseClick(object sender, MouseEventArgs e)
        {
            SaveTextbox1_Clicked = false;
            SaveTextbox2_Clicked = false;
            SaveTextbox3_Clicked = true;
        }
        // Text Changes when Save btn is clicked
        private void SaveTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveTextbox3_TextChanged(object sender, EventArgs e)
        {

        }

        // If A Textbox is clicked then the Save will work
        // The Save button will print the save in the text box
        private void New_Save_btn_Click(object sender, EventArgs e)
        {
            if (SaveTextbox1_Clicked)
            {

            }
            else if (SaveTextbox2_Clicked)
            {

            }
            else if (SaveTextbox3_Clicked)
            {

            }
            else
            {

            }
        }

        // If A Textbox is clicked then the Save will work
        // The Load button will go to the saved game
        private void Load_Save_btn_Click(object sender, EventArgs e)
        {
            if (SaveTextbox1_Clicked)
            {
                if (SaveSystem.IsSaveFileValid("Save0.txt"))
                {
                    frmLevel = new FrmLevel("Save0.txt");
                    this.Hide();
                    frmLevel.Show();
                }
            }
            else if (SaveTextbox2_Clicked)
            {
                if (SaveSystem.IsSaveFileValid("Save1.txt"))
                {
                    frmLevel = new FrmLevel("Save1.txt");
                    this.Hide();
                    frmLevel.Show();
                }
            }
            else if (SaveTextbox3_Clicked)
            {
                if (SaveSystem.IsSaveFileValid("Save2.txt"))
                {
                    frmLevel = new FrmLevel("Save2.txt");
                    this.Hide();
                    frmLevel.Show();
                }
            }
            else
            {

            }
        }

        private void Leave_SaveMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
