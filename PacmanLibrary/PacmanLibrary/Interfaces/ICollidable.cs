using System;

namespace PacmanLibrary
{
    public interface ICollidable
    {
         event Action<ICollidable> Collision;
        int Points { get; }

        void Collide();
    }
}