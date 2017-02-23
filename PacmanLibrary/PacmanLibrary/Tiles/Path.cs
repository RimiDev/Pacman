using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace PacmanLibrary
{
    public class Path : Tile
    {
        ICollidable member;

        public Path(int x, int y, ICollidable member) : base(x, y)
        {
            this.member = member;
        }

        public override bool CanEnter()
        {
            return true;
        }

        public override void Collide()
        {
            if (!IsEmpty())
            {
                member.Collide();
            }
        }

        public override bool IsEmpty()
        {
            return (member == null) ? true : false;
        }

        public override ICollidable Member
        {
            get { return this.member; }
            set { this.member = value; }
        }
    }
}
