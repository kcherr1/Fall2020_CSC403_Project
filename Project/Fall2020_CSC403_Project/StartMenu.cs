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
    public partial class StartMenu : Form
    {
        private FrmLevel frmLevel;

        //Bools that check if button is clicked
        private bool button_Options_Clicked = false;
        private bool button_Back1_Clicked = false;
        private bool button_Difficulty_Clicked = false;

        //Bools that check if the mouse is hovering
        private bool button_NewGame_Hover = false;
        private bool button_Saves_Hover = false;
        private bool button_Exit_Hover = false;
        private bool button_Options_Hover = false;
        private bool button_Back1_Hover = false;
        private bool button_Difficulty_Hover = false;

        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {}

        private void new_game_btn_Click(object sender, System.EventArgs e)
        {
            frmLevel = new FrmLevel();
            this.Hide();
            frmLevel.Show();
            new_game_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.new_game_btn;
        }

        private void new_game_btn_MouseHover(object sender, EventArgs e)
        {
                new_game_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.new_game_hover;
        }

        private void new_game_btn_MouseLeave(object sender, EventArgs e)
        {
            new_game_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.new_game_btn;
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            Load_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Load_btn;
        }

        private void Options_btn_Click(object sender, EventArgs e)
        {
            button_Options_Clicked = true;
            if (button_Options_Clicked = true)
            {
                Options_panel.Visible = true;
                Difficulty_btn.Visible = true;
                Back_btn1.Visible = true;
                Sound_btn.Visible = true;
            }
            Options_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Options_btn;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Exit_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Exit_btn;
            Application.Exit();
        }

        private void Load_btn_MouseHover(object sender, EventArgs e)
        {
            Load_btn.Image = global::Fall2020_CSC403_Project.Properties.Resources.Load_hover;
        }

        private void Options_btn_MouseHover(object sender, EventArgs e)
        {
            Options_btn.Image = global::Fall2020_CSC403_Project.Properties.Resources.Options_hover;
        }

        private void Exit_btn_MouseHover(object sender, EventArgs e)
        {
            Exit_btn.Image = global::Fall2020_CSC403_Project.Properties.Resources.Exit_hover;
        }
        //
        // Opitions panel
        //
        private void Difficulty_btn_Click(object sender, EventArgs e)
        {
            button_Difficulty_Clicked = true;
            if (button_Difficulty_Clicked = true) 
            {
                new DifficultyMenu().Show();
                button_Difficulty_Clicked = false;
            }
        }

        private void Back_btn1_Click(object sender, EventArgs e)
        {
            button_Back1_Clicked = true;
            if (button_Back1_Clicked = true)
            {
                button_Difficulty_Clicked = false;
                Options_panel.Visible = false;
                Difficulty_btn.Visible = false;
                Back_btn1.Visible = false;
                Sound_btn.Visible = false;
            }
        }

        private void Sound_btn_Click(object sender, EventArgs e)
        {

        }

        private void Difficulty_btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void Sound_btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void Back_btn1_MouseHover(object sender, EventArgs e)
        {

        }

        
    }
}
