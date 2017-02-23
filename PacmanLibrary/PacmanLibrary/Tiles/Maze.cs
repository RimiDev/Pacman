using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace PacmanLibrary
{
    public class Maze
    {
        Tile[,] maze;
        public delegate void WonHandler();

        public Maze()
        {
            /*for(int i=0; i<maze.Length; i++)
            {
                for (int j = 0; j < maze.length; j++)
                {
                    maze[i, j] = new Tile();
                }
            }*/
        }

        public void SetTiles(Tile[,] maze)
        {
            /*for (int i = 0; i < maze.Length; i++)
            {
                for (int j = 0; j < maze.Length; j++)
                {
                    this.maze[i, j] = maze[i, j];
                }
            }*/
        }

        public event WonHandler PacmanWon;

        public Tile this[int x, int y]
        {
            get
            {
                return maze[x, y];
            }
            set
            {
                maze[x, y] = value;
            }
        }

        public int Size
        {
            get
            {
                return this.maze.Length;
            }
            set
            {
                this.maze = new Tile[value, value];
            }
        }

        /// <summary>
        /// GetAvailableNeighbours takes in the current Tile position as well as the current Direction,
        /// and returns a list of available Tiles(i.e., not Walls) besides the one that goes backwards.
        /// </summary>
        /// <param name="position"> Current Tile position</param>
        /// <param name="dir"> Current Direction </param>
        /// <returns> A list of available Tiles </returns>
        public List<Tile> GetAvailableNeighbours(Vector2 position, Direction dir)
        {
            List<Tile> availableTile = new List<Tile>();

            /*switch (dir)
            {
                case Direction.Down:
                    break;
                case Direction.Up:
                    break;
                case Direction.Left:
                    break;
                case Direction.Right:
                    break;
            }*/
            return availableTile;
        }

       /* float FindClosestDistance(Vector2 position)
        {
            float closestDistance = maze[0, 0].GetDistance(position);
            foreach(Tile tile in maze)
            {
                if(tile.GetDistance(position) < closestDistance)
                {
                    closestDistance = tile.GetDistance(position);
                }
            }
            return closestDistance;
        }*/

        public int CheckMembersLeft()
        {
            //Still need to throw event PacmanWon if all tiles are empty
            int counter = 0;
            foreach (Tile tile in maze)
            {
                if (!tile.IsEmpty())
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
