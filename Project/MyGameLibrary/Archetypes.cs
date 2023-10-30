using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Windows.Forms;
using Fall2020_CSC403_Project;

namespace Fall2020_CSC403_Project.code
{
    public interface Archetype
    {
        int baseMaxHealth { get; }
        int baseDefense { get; }
        int baseDamage { get; }
        int baseSpeed { get; }
        int archetypeDamage { get; }
        PictureBox image { get; }
    }

    public class ArchetypeHandler
    {
        private Archetype archetype;

        public ArchetypeHandler(Archetype archetype)
        {
            this.archetype = archetype;
        }
    }

    public class Tank : Archetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int archetypeDamage { get; }
        public PictureBox image { get; }

        public Tank()
        {
            baseMaxHealth = 100;
            baseDefense = 10;
            baseDamage = 5;
            baseSpeed = 0;
            archetypeDamage = 5;
            //image = new PictureBox
            //{
            //    Size = new Size(50, 50),
            //    Location = new Point(0, 0),
            //    SizeMode = PictureBoxSizeMode.StretchImage,
            //};
        }
    }

    public class Rogue : Archetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int archetypeDamage { get; }
        public PictureBox image { get; }

        public Rogue()
        {
            baseMaxHealth = 20;
            baseDefense = 2;
            baseDamage = 10;
            baseSpeed = 5;
            archetypeDamage = 10;
        }
    }

    public class Swordsman : Archetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int archetypeDamage { get; }
        public PictureBox image { get; }

        public Swordsman()
        {
            baseMaxHealth = 50;
            baseDefense = 5;
            baseDamage = 8;
            baseSpeed = 2;
            archetypeDamage = 8;
        }
    }

    public class Minion : Archetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int archetypeDamage { get; }
        public PictureBox image { get; }
        public Minion()
        {
            baseMaxHealth = 20;
            baseDefense = 0;
            baseDamage = 5;
            baseSpeed = 2;
            archetypeDamage = 0;
        }
    }
    
}