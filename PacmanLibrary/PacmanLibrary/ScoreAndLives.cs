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

            for (int i = 0; i < gameState.Maze.Size; i++)
            {
                for (int j = 0; j < gameState.Maze.Size; j++)
                {
                    gameState.Maze[i, j].Member.Collision += incrementScore;
                }
            }

            for(int i=0; i < gameState.Size; i++)
            {
                gameState[i].PacmanDied += deadPacman;
                gameState[i].Collision += incrementScore;
            }
            
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
