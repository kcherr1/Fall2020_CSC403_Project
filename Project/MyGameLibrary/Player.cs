using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {
        public Image img;
        public String character;
    public Player(Vector2 initPos, Collider collider, String selection) : base(initPos, collider) {
            if(selection == "mr")
            {
                character = "mr";
                strength = 2.1f;
                Health = 15;
                MaxHealth = 15;
                img = Image.FromFile(@"..\..\data\player.png");
            }
            else if(selection == "mrs")
            {
                character = "mrs";
                GO_INC = 4;
                strength = 1.5f;
                img = Image.FromFile(@"..\..\data\Mrs.png");
            }
            else
            {
                character = "baby";
                GO_INC = 2;
                img = Image.FromFile(@"..\..\data\baby.png");
            }
    }
  }
}
