using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGameLibrary;

namespace Fall2020_CSC403_Project.code
{
    public class Terrain
    {
        public List<Item> Items { get; set; }
        public List<Wall> Walls { get; set; }
        public List<Tile> Tiles { get; set; }


        public Terrain(Item[] items, Wall[] walls, Tile[] tiles)
        {
            this.Items = items.ToList();
            this.Walls = walls.ToList();
            this.Tiles = tiles.ToList();
        }

        public Terrain ()
        {
            this.Items = new List<Item>();
            this.Walls = new List<Wall>();
            this.Tiles= new List<Tile>();
        }


        public void AddWall(Wall wall)
        {
            this.Walls.Add(wall);

        }

        public void AddItem (Item item)
        {
            this.Items.Add(item);
        }

        public void AddTile(Tile tile)
        {
            this.Tiles.Add(tile);
        }
    }
}
