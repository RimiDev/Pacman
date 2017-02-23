namespace PacmanLibrary
{
    public interface ICollidable
    {
        //event Collision;

        int Points { get; }

        void Collide();
    }
}