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
    class Ghost
    {

        private Pacman pacman;
        private Vector2 Target;
        private Pen pen;
        private Maze maze;
        private Direction direction;
        private int colour;
        private IGhostState currentState;
        private static Timer scared;


        public Ghost(GameState g, int x, int y, Vector2 target, IGhostState start, int color)
        {



        }






    }
}
