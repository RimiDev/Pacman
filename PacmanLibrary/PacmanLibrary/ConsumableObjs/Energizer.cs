using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace PacmanLibrary
{
    public class Energizer : ICollidable
    {
        int points = 100;
        GhostPace ghosts;
        public event Action<ICollidable> Collision;

        public Energizer(GhostPace ghosts)
        {
            this.ghosts = ghosts;
        }

        public int Points
        {
            get
            {
                return this.points;
            }
        }

        public void Collide()
        {
            
        }
    }
}
