using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace SectionA2020CS13Framework
{
    class TileGrid
    {
        List<List<Tile>> tiles = new List<List<Tile>>();
        public int Height { get => tiles.Count; }
        public int Width { get => tiles[0].Count; }

        public TileGrid(int formHeight, int formWidth, string filePath)
        {
            string[] images;
            try
            {
                images = File.ReadAllLines(filePath);
            }
            catch (FileNotFoundException ex){
                images = new string[]{ "xxx",
                                       "xxx",
                                       "xxx"};
                Console.WriteLine(ex.Message);
            }
                
            for (int i = 0; i < images.Length; i++)
            {
                List<Tile> row = new List<Tile>();
                for (int j = 0; j < images[0].Length; j++)
                    row.Add(new Tile(j, i, $"./{images[i][j]}.jpg"));
                tiles.Add(row);
            }
        }

        public void fillScreem(Form gameForm)
        {
            Game game = Game.Instance();
            ObjectFactory factory = ObjectFactory.Instance();
            foreach(List<Tile> row in tiles)
            {
                foreach(Tile tile in row)
                {
                    if (tile.ImagePath != "./x.jpg")
                    {
                        PictureBox tilePb = new PictureBox();
                        tilePb.Image = new Bitmap(tile.ImagePath);
                        int sizeX = gameForm.Width / this.Width;
                        int sizeY = gameForm.Height / this.Height;
                        tilePb.Size = new Size(sizeX, sizeY);
                        tilePb.Location = new Point(tile.X * sizeX, tile.Y * sizeY);
                        tilePb.SizeMode = PictureBoxSizeMode.StretchImage;
                        gameForm.Controls.Add(tilePb);
                        game.addGameObject(factory.createObject(tilePb, MovementType.nonMoving, ObjectType.nonMovingObject));
                    }
                }
            }
        }
        
        public List<NeighborTile> getNeighbors(Tile tile)
        {
            List<NeighborTile> neighbors = new List<NeighborTile>();
            for (int i = 0; i < 4; i++)
            {
                NeighborTile nextTile = getNextTile(tile, (Action)i);
                if (nextTile != null) neighbors.Add(nextTile);
            }
            return neighbors;
        }
        public NeighborTile getNextTile(int x, int y, Action action)
        {
            if (action == Action.north)
                return new NeighborTile(getTile(x, y - 1), action);
            else if (action == Action.south)
                return new NeighborTile(getTile(x, y + 1), action);
            else if (action == Action.east)
                return new NeighborTile(getTile(x + 1, y), action);
            else if (action == Action.west)
                return new NeighborTile(getTile(x - 1, y), action);
            else return new NeighborTile(null, action);
        }
        public NeighborTile getNextTile(Tile tile, Action action) => (tile != null) ? getNextTile(tile.X, tile.Y, action) : null;
        public Tile getTile(int x, int y)
            => (x <= Width && y <= Height && x >= 0 && y >= 0) ? tiles[y][x] : null;
        public void resetMap() => tiles.Clear();

        public double getEuclideanDistance(int x1, int x2, int y1, int y2)
        {
            int x = Math.Abs(x1 - x2);
            int y = Math.Abs(y1 - y2);
            return Math.Sqrt((x * x) + (y * y));
        }
        public double getEuclideanDistance(Point p1, Point p2)
            => getEuclideanDistance(p1.X, p2.X, p1.Y, p2.Y);
        public double getEuclideanDistance(Tile c1, Tile c2)
            => getEuclideanDistance(c1.GridPosition, c2.GridPosition);
        public double getManhattanDistance(int x1, int x2, int y1, int y2)
        {
            int x = Math.Abs(x1 - x2);
            int y = Math.Abs(y1 - y2);
            return x + y;
        }
        public double getManhattanDistance(Point p1, Point p2)
            => getEuclideanDistance(p1.X, p2.X, p1.Y, p2.Y);
        public double getManhattanDistance(Tile c1, Tile c2)
            => getEuclideanDistance(c1.GridPosition, c2.GridPosition);
    }

    public class Tile
    {
        private int x, y;
        private string imagePath;
        
        public Point GridPosition { get => new Point(X, Y); }
        public int X { get => x; }
        public int Y { get => y; }
        public string ImagePath { get => imagePath; }

        public Tile(int x, int y, string imagePath)
        {
            this.x = x;
            this.y = y;
            this.imagePath = imagePath;
        }
        public Tile(Point position, string image) : this(position.X, position.Y, image) { }

    }
    public class NeighborTile
    {
        Tile tile;
        Action action;
        public NeighborTile(Tile tile, Action action)
        {
            this.tile = tile;
            this.action = action;
        }

        public Action Action { get => action; }
        public Tile Tile { get => tile; }
    }
    public enum Action
    {
        north,
        south,
        east,
        west,
    }
}
