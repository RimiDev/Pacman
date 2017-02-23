using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace PacmanLibrary
{
    public abstract class Tile
    {
        Vector2 position;

        public Tile(int x, int y)
        {
            position.X = x;
            position.Y = y;
        }

        public Vector2 Position()
        {
            return this.position;
        }

        public abstract ICollidable Member();

        public abstract bool CanEnter();

        public abstract void Collide();

        public abstract bool IsEmpty();

        public float GetDistance(Vector2 goal)
        {
            return Vector2.Distance(position, goal);
        }
    }
}
