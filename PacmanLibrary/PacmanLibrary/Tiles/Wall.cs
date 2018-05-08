using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace PacmanLibrary
{
    public class Wall : Tile
    {
        public Wall(int x, int y) : base(x, y)
        {
        }

        public override ICollidable Member
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

        public override bool CanEnter()
        {
            return false;
        }

        public override void Collide()
        {
        }

        public override bool IsEmpty()
        {
            return true;
        }

    }
}
