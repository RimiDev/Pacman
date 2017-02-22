using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanLibrary
{
    public class Path : Tile
    {
        ICollidable member;

        public Path(int x, int y, ICollidable member) : base(x, y)
        {
            this.member = member;
        }
    }
}
