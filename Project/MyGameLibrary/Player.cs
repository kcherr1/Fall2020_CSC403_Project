using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {
        public Image img;
        public Image imgDed;
        public String character;
        public int charges = 3;
        public int[] BiteTurns = { 0, 0, 0 };
    public Player(Vector2 initPos, Collider collider, String selection) : base(initPos, collider) {
            if(selection == "mr")
            {
                character = "mr";
                img = Image.FromFile(@"..\..\data\player.png");
                imgDed = Image.FromFile(@"..\..\data\playerDed.png");
                charges = 2;
            }
            else if(selection == "mrs")
            {
                character = "mrs";
                characterSpeed = 4;
                Health = 15;
                MaxHealth = 15;
                img = Image.FromFile(@"..\..\data\Mrs.png");
                imgDed = Image.FromFile(@"..\..\data\mrsDed.png");
            }
            else
            {
                character = "baby";
                img = Image.FromFile(@"..\..\data\baby.png");
                imgDed = Image.FromFile(@"..\..\data\babyDed.png");
            }
    }
  }
}
