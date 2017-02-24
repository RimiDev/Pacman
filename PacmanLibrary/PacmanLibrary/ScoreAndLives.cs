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

        public ScoreAndLives(GameState gameState)
        {
            gameState.Maze.PacmanWon += wonPacman;
            //gameState.GhostPack
        }

        void wonPacman()
        {

        }

        void deadPacman()
        {

        }

        void incrementScore(ICollidable collidableObj)
        {
            this.Score += collidableObj.Points;
        }

    }
}
