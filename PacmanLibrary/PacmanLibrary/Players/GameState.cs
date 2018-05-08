using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanLibrary
{
    public class GameState
    {
        public static GameState Parse(string filecontent)
        {
            throw new NotImplementedException();
        }

        public Pacman Pacman { get; }
        public GhostPack GhostPack { get; }
        public Maze Maze { get; }
        public Pen Pen { get; }
        public ScoreAndLives Score { get; }
    }
}
