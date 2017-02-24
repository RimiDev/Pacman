using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace PacmanLibrary
{
    public delegate void GameOverHandler();
    public class ScoreAndLives
    {
        public event GameOverHandler GameOver;
        public int Lives { get; set; }
        public int Score { get; set; }

        public ScoreAndLives(GameState)
        {

        }



    }
}
