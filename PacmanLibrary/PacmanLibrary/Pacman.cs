using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanLibrary
{
    public class Pacman
    {
        GameState controller;
        Maze maze;

        public Pacman(GameState controller)
        {
            this.controller = controller;
        }

        /*public void Move(Direction dir)
        {

        }*/

        public bool CheckCollisions()
        {
            return false;
        }
    }
}
