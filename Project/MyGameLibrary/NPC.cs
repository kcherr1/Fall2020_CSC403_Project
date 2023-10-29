using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
namespace Fall2020_CSC403_Project.code
{
    public class NPC : Character
    {
        public NPC(Position initPos, Collider collider, Archetype archetype) : base(initPos, collider, archetype)
        {
=======
namespace Fall2020_CSC403_Project.code {
  public class NPC : Character {
    public NPC(string Name, PictureBox Pic, PlayerArchetype archetype) : base(Name, Pic, archetype) {
>>>>>>> 5722addd37d37069511f017a653933271f10762f

        }
    }
}
