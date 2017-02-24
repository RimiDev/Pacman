using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace PacmanLibrary
{
    public delegate void WonHandler();

    public class Maze
    {
        Tile[,] maze;

        /// <summary>
        /// PacmanWon event contain the methods that can be invoked if the pacman won.
        /// </summary>
        public event WonHandler PacmanWon;

        public Maze()
        {
            for(int i=0; i<maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    maze[i, j] = new Path(i, j, null);
                }
            }
        }

        public void SetTiles(Tile[,] maze)
        {
            for (int i = 0; i < maze.Length; i++)
            {
                for (int j = 0; j < maze.Length; j++)
                {
                    this.maze[i, j] = maze[i, j];
                }
            }
        }

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
            int left = (int)(position.X - 1);
            int right = (int)(position.X + 1);
            int up = (int)(position.Y - 1);
            int down = (int)(position.Y + 1);
            //Tile currentTile = new Path((int)position.X, (int)position.Y, null);

            switch (dir)
            {
                case Direction.Down:
                    if(maze[left, (int)position.Y].CanEnter())
                    {
                        availableTile.Add(maze[left, (int)position.Y]);
                    }
                    if(maze[right, (int)position.Y].CanEnter())
                    {
                        availableTile.Add(maze[right, (int)position.Y]);
                    }
                    if(maze[(int)position.X, down].CanEnter())
                    {
                        availableTile.Add(maze[(int)position.X, down]);
                    }
                    break;
                case Direction.Up:
                    if (maze[left, (int)position.Y].CanEnter())
                    {
                        availableTile.Add(maze[left, (int)position.Y]);
                    }
                    if (maze[right, (int)position.Y].CanEnter())
                    {
                        availableTile.Add(maze[right, (int)position.Y]);
                    }
                    if (maze[(int)position.X, up].CanEnter())
                    {
                        availableTile.Add(maze[(int)position.X, up]);
                    }
                    break;
                case Direction.Left:
                    if (maze[(int)position.X, up].CanEnter())
                    {
                        availableTile.Add(maze[(int)position.X, up]);
                    }
                    if (maze[left, (int)position.Y].CanEnter())
                    {
                        availableTile.Add(maze[left, (int)position.Y]);
                    }
                    if (maze[(int)position.X, down].CanEnter())
                    {
                        availableTile.Add(maze[(int)position.X, down]);
                    }
                    break;
                case Direction.Right:
                    if (maze[(int)position.X, up].CanEnter())
                    {
                        availableTile.Add(maze[(int)position.X, up]);
                    }
                    if (maze[right, (int)position.Y].CanEnter())
                    {
                        availableTile.Add(maze[right, (int)position.Y]);
                    }
                    if (maze[(int)position.X, down].CanEnter())
                    {
                        availableTile.Add(maze[(int)position.X, down]);
                    }
                    break;
            }
            return availableTile;
        }

       /* Tile FindClosestDistance(Vector2 position)
        {
            Tile tile = new Tile(position.X, position.Y);
            foreach(Tile tile in maze)
            {
                if(tile.GetDistance(position) < closestDistance)
                {
                    closestDistance = tile.GetDistance(position);
                }
            }
            return closestDistance;
        }*/

        /// <summary>
        /// CheckMembersLeft is to check how many tiles left. If there is no tile left,
        /// it will throw the event PacmanWon.
        /// </summary>
        /// <returns> the number of tiles left </returns>
        public void CheckMembersLeft()
        {
            int counter = 0;
            foreach (Tile tile in maze)
            {
                if (!tile.IsEmpty())
                {
                    counter++;
                }
            }

            if (counter == 0) OnPacmanWon();           
        }

        void OnPacmanWon()
        {
            if (PacmanWon != null)
                PacmanWon.Invoke();
        }
    }
}
