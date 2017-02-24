using Microsoft.Xna.Framework;
using PacmanLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PacmanLibrary
{
    public class Ghost : ICollidable, IMovable
    {

        private Pacman pacman;
        private Vector2 Target;
        private Pen pen;
        private Maze maze;
        private Direction direction;
        private int colour;
        private IGhostState currentState;
        private static Timer scared;


        public event Action<ICollidable> Collision;

        public Ghost(GameState g, int x, int y, Vector2 target, IGhostState start, int color)
        {



        }

        public int Points
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Direction Direction
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Vector2 Position
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Collide()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
