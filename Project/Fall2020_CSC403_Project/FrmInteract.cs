using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmInteract : Form
    {
        public static FrmInteract instance = null;
        private NPC npc;
        private Player player;
        public FrmInteract()
        {
            InitializeComponent();
            player = Game.player;
        }

        public static FrmInteract GetInstance(NPC npc)
        {
            if (instance == null)
            {
                instance = new FrmInteract();
                instance.npc = npc;
                //instance.Setup();
            }
            return instance;
        }

        // Leave interaction button
        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmLevel.NPCPictureDict[npc].BackgroundImage = null;
            FrmLevel.NPCPictureDict[npc].SendToBack();
            Hide();
        }

        // Collect child button
        private void btnInteract1_Click(object sender, EventArgs e)
        {
            lblInteract.Text = "Come child, the Kool-Aid Demon shall pay for his crimes.";
            Application.DoEvents();
            lblInteract.Text = "Mr.Peanut has reunited with his son and has thus gained some HP.";
            // Alters hp kinda of like health wisps in mmorpgs - could use to implement a wisp like powerup?
            //player.AlterHealth(35);
            player.MaxHealth += 100;
            Thread.Sleep(2000);
        }

        // Banish child button
        private void btnInteract2_Click(object sender, EventArgs e)
        {
            lblInteract.Text = "You dishonor your father, BEGONE!";
            npc.IsBanished = true;
            // Sound works, however that isn't the sound file i want to use
            // Sound files not showing in data folder even though they've been added
            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();
        }
    }
}
