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
    public partial class StatsMenu : ChildForm
    {
        public Player player;
        public StatsMenu()
        {
            InitializeComponent();
            player = Game.player;
        }

        public void AlterAttack(int amount)
        {
            player.strength += amount;
        }
        public void AlterEvasion()
        {

        }
        public void AlterDefense()
        {

        }
    }
}
