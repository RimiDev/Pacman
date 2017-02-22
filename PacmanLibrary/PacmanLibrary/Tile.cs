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
        int x;
        int y;

        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2 Position()
        {
            return new Vector2(x, y);
        }

        public ICollidable Member()
        {
            return null;
        }

        public bool CanEnter()
        {
            return false;
        }

        public void Collide()
        {

        }

        public bool IsEmpty()
        {
            return false;
        }

        public float GetDistance(Vector2 goal)
        {
            return 0f;
        }
    }
}
