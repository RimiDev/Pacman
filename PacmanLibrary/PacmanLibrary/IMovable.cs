using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanLibrary
{
    public interface IMovable
    {
        Direction Direction { get; set; }
        Vector2 Position { get; }
        void Move();
    }
}
