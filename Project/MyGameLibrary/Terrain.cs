using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;
using MyGameLibrary.Properties;
using MyGameLibrary;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class Terrain
    {
        public List<Item> Items { get; set; }
        public List<Wall> Walls { get; set; }
        public List<Tile> Tiles { get; set; }

        public int GridWidth { get; set; }
        public int GridHeight { get; set; }

        public Size TileSize { get; set; }


        public Terrain (int GridWidth, int GridHeight, Size TileSize)
        {
            this.Items = new List<Item>();
            this.Walls = new List<Wall>();
            this.Tiles = new List<Tile>();
            this.GridWidth = GridWidth;
            this.GridHeight = GridHeight;
            this.TileSize = TileSize;
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

        public void GenerateTerrain(int seed, double amplification = 0)
        {

            Random random = new Random(seed);
            double[][] tiles = new double[this.GridHeight][];
            for (int i = 0; i < this.GridHeight; i++)
            {
                tiles[i] = new double[this.GridWidth];
            }

            for (int y = 0; y < this.GridHeight; y++)
            {
                for (int x = 0; x < this.GridWidth; x++)
                {
                    double noise = random.NextDouble();
                    tiles[y][x] = noise + amplification;

                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < this.GridHeight; y++) {
                    for (int x = 0; x < this.GridWidth; x++)
                    {
                        double sum = tiles[y][x];
                        int count = 1;

                        for (int dy = -1; dy <= 1; dy++)
                        {
                            for (int dx = -1; dx <= 1; dx++)
                            {
                                int adjacent_x = x + dx;
                                int adjacent_y = y + dy;

                                if (adjacent_x >= 0 && adjacent_x < this.GridWidth && adjacent_y >= 0 && adjacent_y < this.GridHeight && (dx != 0 || dy != 0))
                                {
                                    sum += tiles[adjacent_y][adjacent_x];
                                    count++;
                                }
                            }
                        }

                        tiles[y][x] = sum / count;

                    }
                }
            }

            for (int y = 0; y < this.GridHeight; y++)
            {
                for (int x = 0; x < this.GridWidth; x++)
                {
                    if (tiles[y][x] < 0.4)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_water_grassy, new Point(x * this.TileSize.Width, y * this.TileSize.Width)), Tile.EffectType.SuperSlowness));
                    }
                    else if (tiles[y][x] < 0.45)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_water_clear, new Point(x * this.TileSize.Width, y * this.TileSize.Width)), Tile.EffectType.SuperSlowness));
                    }
                    else if (tiles[y][x] < 0.47)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_sand, new Point(x * this.TileSize.Width, y * this.TileSize.Width)), Tile.EffectType.Slowness));
                    }
                    else if (tiles[y][x] < 0.5)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_dirt_path, new Point(x * this.TileSize.Width, y * this.TileSize.Width))));
                    }
                    else if (tiles[y][x] < 0.55)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_grass_light, new Point(x * this.TileSize.Width, y * this.TileSize.Width))));
                    }
                    else if (tiles[y][x] < 0.65)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_grass_dark, new Point(x * this.TileSize.Width, y * this.TileSize.Width))));
                    }
                    else if (tiles[y][x] < 0.7)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_cobblestone_mossy, new Point(x * this.TileSize.Width, y * this.TileSize.Width))));
                    }
                    else if (tiles[y][x] < 0.72)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_cobblestone, new Point(x * this.TileSize.Width, y * this.TileSize.Width))));
                    }
                    else if (tiles[y][x] < 75)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_stonebrick, new Point(x * this.TileSize.Width, y * this.TileSize.Width)), Tile.EffectType.Speed));
                    }
                    else
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_bricks, new Point(x * this.TileSize.Width, y * this.TileSize.Width)), Tile.EffectType.Speed));
                    }
                }
            }
        }

        private PictureBox MakePictureBox(Bitmap pic, Point location)
        {
            return new PictureBox
            {
                Location = location,
                Image = pic,
                Size = this.TileSize,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
        }
    }

}
