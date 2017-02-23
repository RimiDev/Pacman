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
        int points;
        GhostPace ghosts;

        public Energizer(GhostPace ghosts)
        {
            this.ghosts = ghosts;
        }

        public int Points
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
    }
}
