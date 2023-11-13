using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{
    public class NPC : Character
    {

        public string Dialog;

        public bool CanJoinParty;

        public NPC(string name, PictureBox pic, Archetype archetype) : base(name, pic, archetype)
        {
            this.CanJoinParty = true;
            this.Dialog = "";
        }





    }
}
