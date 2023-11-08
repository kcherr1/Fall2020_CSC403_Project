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
        public List<Tile> Tiles { get; set; }

        public static Size TileSize = new Size(Screen.PrimaryScreen.Bounds.Width / 35, Screen.PrimaryScreen.Bounds.Width / 35);
        public static int GridWidth = Screen.PrimaryScreen.Bounds.Width / TileSize.Width + 1;
        public static int GridHeight = GridWidth;


        public Terrain(int Seed, Biome Biome, double SeedAmplification)
        {
            this.Tiles = new List<Tile>();
            GenerateTerrain(Seed, Biome, SeedAmplification);
        }


        public Terrain()
        {
            this.Tiles = new List<Tile>();
        }



        public void AddTile(Tile tile)
        {
            this.Tiles.Add(tile);
        }

        private static Image water_grass = Resources.tile_water_grassy;
        private static Image water_clear = Resources.tile_water_clear;
        private static Image sand = Resources.tile_sand;
        private static Image dirt_path = Resources.tile_dirt_path;
        private static Image grass_light = Resources.tile_grass_light;
        private static Image grass_dark = Resources.tile_grass_dark;
        private static Image cobble_moss = Resources.tile_cobblestone_mossy;
        private static Image cobblestone = Resources.tile_cobblestone;
        private static Image stone_bricks = Resources.tile_stonebrick;
        private static Image stony = Resources.tile_stony;
        private static Image stony2 = Resources.tile_stony2;

        private static Image[] beach = new Image[] { water_grass, water_clear, water_clear, sand, sand, grass_light };
        private static Tile.EffectType[] beach_eff = new Tile.EffectType[] { Tile.EffectType.SuperSlowness, Tile.EffectType.SuperSlowness, Tile.EffectType.SuperSlowness, Tile.EffectType.Slowness, Tile.EffectType.Slowness, Tile.EffectType.None };

        private static Image[] grassland = new Image[] { dirt_path, grass_dark, grass_dark, grass_light, grass_light, grass_light };
        private static Tile.EffectType[] grassland_eff = new Tile.EffectType[] { Tile.EffectType.None, Tile.EffectType.None, Tile.EffectType.None, Tile.EffectType.None, Tile.EffectType.None, Tile.EffectType.None };

        private static Image[] village = new Image[] { grass_dark, grass_light, dirt_path, cobblestone, stone_bricks, cobble_moss};
        private static Tile.EffectType[] village_eff = new Tile.EffectType[] { Tile.EffectType.None, Tile.EffectType.None, Tile.EffectType.None, Tile.EffectType.Speed, Tile.EffectType.Speed, Tile.EffectType.Speed };

        private static Image[] mountain = new Image[] { grass_dark, stony, stony2, stony, dirt_path, grass_light };
        private static Tile.EffectType[] mountain_eff = new Tile.EffectType[] { Tile.EffectType.None, Tile.EffectType.Slowness, Tile.EffectType.Slowness, Tile.EffectType.None, Tile.EffectType.None, Tile.EffectType.None };


        public enum Biome
        {
            Beach,
            Grassland,
            Village,
            Mountain
        }

        public void GenerateTerrain(int seed, Biome Biome, double amplification = 0)
        {
            Image[] images;
            Tile.EffectType[] effects;
            switch(Biome)
            {
                case Biome.Beach:
                    images = beach;
                    effects = beach_eff;
                    break;
                case Biome.Grassland:
                    images = grassland;
                    effects = grassland_eff;
                    break;
                case Biome.Village:
                    images = village;
                    effects = village_eff;
                    break;
                case Biome.Mountain:
                    images = mountain;
                    effects = mountain_eff;
                    break;

                default:
                    images = grassland;
                    effects = grassland_eff;
                    break;
            }

            Random random = new Random(seed);
            double[][] tiles = new double[GridHeight][];
            for (int i = 0; i < GridHeight; i++)
            {
                tiles[i] = new double[GridWidth];
            }

            for (int y = 0; y < GridHeight; y++)
            {
                for (int x = 0; x < GridWidth; x++)
                {
                    double noise = random.NextDouble();
                    tiles[y][x] = noise + amplification;

                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < GridHeight; y++) {
                    for (int x = 0; x < GridWidth; x++)
                    {
                        double sum = tiles[y][x];
                        int count = 1;

                        for (int dy = -1; dy <= 1; dy++)
                        {
                            for (int dx = -1; dx <= 1; dx++)
                            {
                                int adjacent_x = x + dx;
                                int adjacent_y = y + dy;

                                if (adjacent_x >= 0 && adjacent_x < GridWidth && adjacent_y >= 0 && adjacent_y < GridHeight && (dx != 0 || dy != 0))
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

            for (int y = 0; y < GridHeight; y++)
            {
                for (int x = 0; x < GridWidth; x++)
                {
                    if (tiles[y][x] < 0.45)
                    {
                        this.AddTile(new Tile(images[0], new Point(x * TileSize.Width, y * TileSize.Width), effects[0]));
                    }
                    else if (tiles[y][x] < 0.58)
                    {
                        this.AddTile(new Tile(images[1], new Point(x * TileSize.Width, y * TileSize.Width), effects[1]));
                    }
                    else if (tiles[y][x] < 0.61)
                    {
                        this.AddTile(new Tile(images[2], new Point(x * TileSize.Width, y * TileSize.Width), effects[2]));
                    }
                    else if (tiles[y][x] < 0.65)
                    {
                        this.AddTile(new Tile(images[3], new Point(x * TileSize.Width, y * TileSize.Width), effects[3]));
                    }
                    else if (tiles[y][x] < 0.7)
                    {
                        this.AddTile(new Tile(images[4], new Point(x * TileSize.Width, y * TileSize.Width), effects[4]));
                    }
                    else 
                    {
                        this.AddTile(new Tile(images[5], new Point(x * TileSize.Width, y * TileSize.Width), effects[5]));
                    }

                }
            }
        }


    }

}
