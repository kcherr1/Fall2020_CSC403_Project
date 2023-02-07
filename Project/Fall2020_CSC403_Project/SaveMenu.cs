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
        private bool SaveButton1_Clicked = false;
        private bool SaveButton2_Clicked = false;
        private bool SaveButton3_Clicked = false;

        public SaveMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // If A Textbox is clicked then the Save will work
        // The Save button will print the save in the text box
        private void New_Save_btn_Click(object sender, EventArgs e)
        {
            if (SaveButton1_Clicked)
            {
                frmLevel = new FrmLevel();
                this.Hide();
                frmLevel.Show();
            }
            else if (SaveButton2_Clicked)
            {
                frmLevel = new FrmLevel();
                this.Hide();
                frmLevel.Show();
            }
            else if (SaveButton3_Clicked)
            {
                frmLevel = new FrmLevel();
                this.Hide();
                frmLevel.Show();
            }
            else
            {

            }
        }

        // If A Textbox is clicked then the Save will work
        // The Load button will go to the saved game
        private void Load_Save_btn_Click(object sender, EventArgs e)
        {
            if (SaveButton1_Clicked)
            {
                if (SaveSystem.IsSaveFileValid("Save0.txt"))
                {
                    frmLevel = new FrmLevel("Save0.txt");
                    this.Hide();
                    frmLevel.Show();
                }
            }
            else if (SaveButton2_Clicked)
            {
                if (SaveSystem.IsSaveFileValid("Save1.txt"))
                {
                    frmLevel = new FrmLevel("Save1.txt");
                    this.Hide();
                    frmLevel.Show();
                }
            }
            else if (SaveButton3_Clicked)
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

        private void SaveMenu_table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveSlotButton1_Click(object sender, EventArgs e)
        {
            SaveButton1_Clicked = true;
            SaveButton2_Clicked = false;
            SaveButton3_Clicked = false;
        }

        private void SaveSlotButton2_Click(object sender, EventArgs e)
        {
            SaveButton1_Clicked = false;
            SaveButton2_Clicked = true;
            SaveButton3_Clicked = false;
        }

        private void SaveSlotButton3_Click(object sender, EventArgs e)
        {
            SaveButton1_Clicked = false;
            SaveButton2_Clicked = false;
            SaveButton3_Clicked = true;
        }
    }
}
