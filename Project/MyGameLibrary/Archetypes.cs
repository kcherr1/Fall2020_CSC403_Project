using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Windows.Forms;
using Fall2020_CSC403_Project;
using MyGameLibrary.Properties;

namespace Fall2020_CSC403_Project.code
{
    public interface Archetype
    {
        int baseMaxHealth { get; }
        int baseDefense { get; }
        int baseDamage { get; }
        int baseSpeed { get; }
        int hitMod { get; }
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
<<<<<<< HEAD
        public int hitMod { get; }
=======
        public int archetypeDamage { get; }
        public int archetypeHit { get; }
>>>>>>> d405ad4ec96b6115bc3bd25e674b2dc174d5b78b
        public PictureBox image { get; }

        public Tank(Point location, Size size)
        {
            baseMaxHealth = 100;
            baseDefense = 10;
            baseDamage = 2;
            baseSpeed = 0;
<<<<<<< HEAD
            hitMod = 2;
            image = new PictureBox
            {
                Location = location,
                Image = Resources.Tank,
                Size = size,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
=======
            archetypeDamage = 5;
            archetypeHit = 4;
            //image = new PictureBox
            //{
            //    Size = new Size(50, 50),
            //    Location = new Point(0, 0),
            //    SizeMode = PictureBoxSizeMode.StretchImage,
            //};
>>>>>>> d405ad4ec96b6115bc3bd25e674b2dc174d5b78b
        }
    }

    public class Rogue : Archetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
<<<<<<< HEAD
        public int hitMod { get; }
=======
        public int archetypeDamage { get; }
        public int archetypeHit { get; }
>>>>>>> d405ad4ec96b6115bc3bd25e674b2dc174d5b78b
        public PictureBox image { get; }

        public Rogue(Point location, Size size)
        {
            baseMaxHealth = 20;
            baseDefense = 10;
            baseDamage = 10;
            baseSpeed = 5;
<<<<<<< HEAD
            hitMod = 5;
            image = new PictureBox
            {
                Location = location,
                Image = Resources.rogue,
                Size = size,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
=======
            archetypeDamage = 10;
            archetypeHit = 4;
>>>>>>> d405ad4ec96b6115bc3bd25e674b2dc174d5b78b
        }
    }

    public class Swordsman : Archetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
<<<<<<< HEAD
        public int hitMod { get; }
=======
        public int archetypeDamage { get; }
        public int archetypeHit { get; }
>>>>>>> d405ad4ec96b6115bc3bd25e674b2dc174d5b78b
        public PictureBox image { get; }

        public Swordsman(Point location, Size size)
        {
            baseMaxHealth = 50;
            baseDefense = 10;
            baseDamage = 8;
            baseSpeed = 2;
<<<<<<< HEAD
            hitMod = 3;
            image = new PictureBox
            {
                Location = location,
                Image = Resources.Swordsman,
                Size = size,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
=======
            archetypeDamage = 8;
            archetypeHit = 4;
>>>>>>> d405ad4ec96b6115bc3bd25e674b2dc174d5b78b
        }
    }

    public class Minion : Archetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
<<<<<<< HEAD
        public int hitMod { get; }
=======
        public int archetypeDamage { get; }
        public int archetypeHit { get; }
>>>>>>> d405ad4ec96b6115bc3bd25e674b2dc174d5b78b
        public PictureBox image { get; }

        public Minion(Point location, Size size)
        {
            baseMaxHealth = 20;
            baseDefense = 10;
            baseDamage = 5;
            baseSpeed = 2;
<<<<<<< HEAD
            hitMod = 0;
            image = new PictureBox
            {
                Location = location,
                Image = Resources.minion,
                Size = size,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
=======
            archetypeDamage = 0;
            archetypeHit = 0;
>>>>>>> d405ad4ec96b6115bc3bd25e674b2dc174d5b78b
        }
    }

    public class Boss : Archetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; }
        public PictureBox image { get; }

        public Boss(Point location, Size size)
        {
            baseMaxHealth = 100;
            baseDefense = 18;
            baseDamage = 10;
            hitMod = 10;
            image = new PictureBox
            {
                Location = location,
                Image = Resources.minion,
                Size = size,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
        }

    }
    
}