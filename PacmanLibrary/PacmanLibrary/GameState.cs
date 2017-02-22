using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanLibrary
{
    public class GameState
    {
        public GameState Parse(string filecontent)
        {
            return null;
        }

        public Pacman Pacman { get; }
        public GhostPace GhostPack { get; }
        public Maze Maze { get; }
        public Pen Pen { get; }
        public ScoreAndLives Score { get; }
    }
}
