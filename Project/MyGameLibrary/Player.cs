using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code {
  public class Player : Character
    {
        public NPC[] Party;

        public Player(string name, PictureBox pic, Archetype archetype) : base(name, pic, archetype)
        {
            Party = new NPC[3];
        }

        public bool isPartyFull()
        {
            for (int i = 0; i < this.Party.Length; i++)
            {
                if (this.Party[i] == null)
                { return false; }
            }
            return true;
        }

        public bool isPartyEmpty()
        {
            for (int i = 0; i < this.Party.Length; i++)
            {
                if (this.Party[i] != null)
                { return false; }
            }
            return true;
        }

        public void addPartyMember(NPC newMember)
        {
            for (int i = 0; i < Party.Length; i++)
            {
                if (Party[i] == null)
                {
                    Party[i] = newMember;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
