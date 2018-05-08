using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace PacmanLibrary
{
    public class GhostPack
    {
        List<Ghost> ghost;

        public GhostPack()
        {

        }

        public bool CheckCollideGhosts(Vector2 position)
        {
            throw new NotImplementedException();
        }

        public void ResetGhosts()
        {
            throw new NotImplementedException();
        }

        public void ScareGhosts()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Add(Ghost ghost)
        {
            this.ghost.Add(ghost);
        }

        public int Size()
        {
            return this.ghost.Count;
        }
    }
}