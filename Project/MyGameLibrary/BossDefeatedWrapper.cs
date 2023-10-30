using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;

namespace MyGameLibrary
{   
    /*
     * So why does this exist? It seems like none of the Form entry and exit functions have
     * obvious spots to pass and capture information about whether the boss was defeated. So,
     * this wrapper helps create a boolean that can be referenced between the FrmLevel and 
     * FrmBattle (FrmBattle setting the value to true persists when it returns to FrmLevel)
     */
    public class BossDefeatedWrapper
    {
        public bool bossIsDefeated { get; set; }
        public BossDefeatedWrapper(bool bossIsDefated) { this.bossIsDefeated = bossIsDefeated; }
    }
}
