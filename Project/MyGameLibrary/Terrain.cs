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

        public void GenerateTerrain(int height, int width, int seed, double amplification = 0)
        {
            Random random = new Random(seed);
            double[][] tiles = new double[height][];
            for (int i = 0; i < height; i++)
            {
                tiles[i] = new double[width];
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double noise = random.NextDouble();
                    tiles[y][x] = noise + amplification;

                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < height; y++) {
                    for (int x = 0; x < width; x++)
                    {
                        double sum = tiles[y][x];
                        int count = 1;

                        for (int dy = -1; dy <= 1; dy++)
                        {
                            for (int dx = -1; dx <= 1; dx++)
                            {
                                int adjacent_x = x + dx;
                                int adjacent_y = y + dy;

                                if (adjacent_x >= 0 && adjacent_x < width && adjacent_y >= 0 && adjacent_y < height && (dx != 0 || dy != 0))
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

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (tiles[y][x] < 0.4)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_water_grassy, new Point(x * 50, y * 50)), Tile.EffectType.SuperSlowness));
                    }
                    else if (tiles[y][x] < 0.45)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_water_clear, new Point(x * 50, y * 50)), Tile.EffectType.SuperSlowness));
                    }
                    else if (tiles[y][x] < 0.47)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_sand, new Point(x * 50, y * 50)), Tile.EffectType.Slowness));
                    }
                    else if (tiles[y][x] < 0.5)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_dirt_path, new Point(x * 50, y * 50))));
                    }
                    else if (tiles[y][x] < 0.55)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_grass_light, new Point(x * 50, y * 50))));
                    }
                    else if (tiles[y][x] < 0.65)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_grass_dark, new Point(x * 50, y * 50))));
                    }
                    else if (tiles[y][x] < 0.7)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_cobblestone_mossy, new Point(x * 50, y * 50))));
                    }
                    else if (tiles[y][x] < 0.72)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_cobblestone, new Point(x * 50, y * 50))));
                    }
                    else if (tiles[y][x] < 75)
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_stonebrick, new Point(x * 50, y * 50)), Tile.EffectType.Speed));
                    }
                    else
                    {
                        this.AddTile(new Tile(MakePictureBox(Resources.tile_bricks, new Point(x * 50, y * 50)), Tile.EffectType.Speed));
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
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
        }
    }

}
