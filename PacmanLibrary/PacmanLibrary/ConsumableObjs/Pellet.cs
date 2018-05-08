using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace PacmanLibrary
{
    public class Pellet : ICollidable
    {
        int points=10;
        public event Action<ICollidable> Collision;
        public int Points
        {
            get
            {
                return this.points;
            }
        }

        public void Collide()
        {
           if(Collision != null)
            {
                Collision(this);
            }
        }
    }
}
