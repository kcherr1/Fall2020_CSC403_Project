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
        public List<Structure> Structures { get; set; }
        

        public bool Visited { get; set; }

        public String AreaName { get; set; }


        public Dictionary<Direction, TravelSign> TravelSigns { get; set; }

        public Dictionary<Direction, int> AdjacentAreas { get; set; }

        public Terrain Terrain;

        public Area(String AreaName, Terrain Terrain)
        {
            this.AreaName = AreaName;
            this.Terrain = Terrain;
            this.Visited = false;
        }

        public Area(String AreaName)
        {
            this.Terrain = new Terrain();
            this.Enemies = new List<Enemy>();
            this.npcs = new List<NPC>();
            this.Items = new List<Item>();
            this.Structures = new List<Structure>();
            this.AdjacentAreas = new Dictionary<Direction, int>();
            this.TravelSigns = new Dictionary<Direction, TravelSign>();
            this.AreaName = AreaName;
            this.Visited = false;
        }

        public Area(String AreaName, int Seed, Terrain.Biome Biome, double SeedAmp = 0)
        {
            this.Terrain = new Terrain(Seed, Biome, SeedAmp);
            this.Enemies = new List<Enemy>();
            this.npcs = new List<NPC>();
            this.Items = new List<Item>();
            this.Structures = new List<Structure>();
            this.AdjacentAreas = new Dictionary<Direction, int>();
            this.TravelSigns = new Dictionary<Direction, TravelSign>();
            this.AreaName = AreaName;
            this.Visited = false;
        }

        public void AddStructure(Structure structure)
        {
            this.Structures.Add(structure);

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

        public void SetTravelSign(Direction direction, TravelSign sign)
        {
            this.TravelSigns[direction] = sign;
        }

        public void MakeBossRoom()
        {
            Image cave = Resources.tile_cave;
            Image cave_path = Resources.tile_cave_path;
            for (int col = 0; col < Terrain.GridWidth; col++)
            {
                for (int row = 0; row < Terrain.GridHeight; row++)
                {
                    Console.WriteLine(col + ", " + row + ": " + Terrain.GridWidth + ", " + Terrain.GridHeight);
                    if (row < 12 || row >= Terrain.GridWidth - 12)
                    {
                        this.Terrain.AddTile(new Tile(cave, new Point(col * Terrain.TileSize.Width, row * Terrain.TileSize.Width), Tile.EffectType.None));
                    }
                    else
                    {
                        this.Terrain.AddTile(new Tile(cave_path, new Point(col * Terrain.TileSize.Width, row * Terrain.TileSize.Width), Tile.EffectType.None));
                    }
                }
            }
        }

    }

    public enum Direction
    {
        None,
        Left,
        Right,
        Up,
        Down,
    }
}
