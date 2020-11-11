using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public partial class Backpack : Form
    {
        private Player player;
        public Backpack()
        {
            InitializeComponent();
            player = Game.player;
        }

        private void Backpack_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e) { }

        private void label14_Click(object sender, EventArgs e) { }

        private void label15_Click(object sender, EventArgs e) { }

        private void label16_Click(object sender, EventArgs e) { }

        private void label17_Click(object sender, EventArgs e) { }

        private void label18_Click(object sender, EventArgs e) { }

        private void label19_Click(object sender, EventArgs e) { }

        private void label20_Click(object sender, EventArgs e) { }

        private void label21_Click(object sender, EventArgs e) { }

        private void label22_Click(object sender, EventArgs e) { }

        public void UpdateBackpack()
        {
            //update the HP potions
            label14.Text = player.GetVal("Small HP potion").ToString();
            label15.Text = player.GetVal("Medium HP potion").ToString();
            label16.Text = player.GetVal("Large HP potion").ToString();

            //update armor
            label17.Text = player.GetVal("Bronze Armor").ToString();
            label18.Text = player.GetVal("Iron Armor").ToString();
            label19.Text = player.GetVal("Diamond Armor").ToString();


            //update weapons
            label20.Text = player.GetVal("Bronze Sword").ToString();
            label21.Text = player.GetVal("Iron Sword").ToString();
            label22.Text = player.GetVal("Diamond Sword").ToString();

            label26.Text = "Health = " + player.Health.ToString() + "/20";
        }

        private void Backpack_KeyDown(object sender, KeyEventArgs e)
        {

            //Checks to see what the player has pressed
            //If user presses 'Enter' the window closes. 
            //If 1-9, the player tries to use the appropriate item
            //Else, ignore the user
            switch (e.KeyCode)
            {
                case Keys.D1:
                    player.AddHealth("Small HP potion");
                    break;
                case Keys.D2:
                    player.AddHealth("Medium HP potion");
                    break;
                case Keys.D3:
                    player.AddHealth("Large HP potion");
                    break;
                case Keys.D4:
                    player.ReduceDamageTaken("Bronze Armor");
                    label6.Text = "4) Bronze Armor (equipped)";
                    label7.Text = "5) Iron Armor";
                    label8.Text = "6) Diamond Armor";
                    break;
                case Keys.D5:
                    player.ReduceDamageTaken("Iron Armor");
                    label6.Text = "4) Bronze Armor";
                    label7.Text = "5) Iron Armor (equipped)";
                    label8.Text = "6) Diamond Armor";
                    break;
                case Keys.D6:
                    player.ReduceDamageTaken("Diamond Armor");
                    label6.Text = "4) Bronze Armor";
                    label7.Text = "5) Iron Armor";
                    label8.Text = "6) Diamond Armor (equipped)";
                    break;
                case Keys.D7:
                    player.AddDamage("Bronze Sword");
                    label10.Text = "7) Bronze Sword (equipped)";
                    label11.Text = "8) Iron Sword";
                    label12.Text = "9) Diamond Sword";
                    break;
                case Keys.D8:
                    player.AddDamage("Iron Sword");
                    label10.Text = "7) Bronze Sword";
                    label11.Text = "8) Iron Sword (equipped)";
                    label12.Text = "9) Diamond Sword";
                    break;
                case Keys.D9:
                    player.AddDamage("Diamond Sword");
                    label10.Text = "7) Bronze Sword";
                    label11.Text = "8) Iron Sword";
                    label12.Text = "9) Diamond Sword (equipped)";
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }

            UpdateBackpack();
        }

        private void label23_Click(object sender, EventArgs e) { }

    }
}
