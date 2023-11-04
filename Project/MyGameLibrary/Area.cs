using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;
using MyGameLibrary.Properties;

namespace MyGameLibrary
{
    public class Area
    {

        public List<Enemy> Enemies { get; set; }
        public List<NPC> npcs { get; set; }
        public List<Item> Items { get; set; }
        public List<Wall> Walls { get; set; }

        public Dictionary<Direction, int> AdjacentAreas { get; set; }

        public Terrain Terrain;


        public Area(int Seed, double SeedAmp)
        {
            Terrain = new Terrain(Seed, SeedAmp);
            Enemies = new List<Enemy>();
            npcs = new List<NPC>();
            Items = new List<Item>();
            Walls = new List<Wall>();
            AdjacentAreas = new Dictionary<Direction, int>();
        }
        public void AddWall(Wall wall)
        {
            this.Walls.Add(wall);

        }

        public void AddItem(Item item)
        {
            this.Items.Add(item);
        }

        public void AddEnemy(Enemy enemy)
        {
            this.Enemies.Add(enemy);
        }

        public void AddNPC(NPC npc)
        {
            this.npcs.Add(npc);
        }

        public void SetAdjacentArea(Direction direction, int area)
        {
            this.AdjacentAreas[direction] = area;
        }

    }

    public enum Direction
    {
        Left,
        Right,
        Up,
        Down,
    }
}
