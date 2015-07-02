using System;
using System.Linq;

namespace WolfEngine
{
    class Player
    {
        public Vector2f Position;
        public float Angle;
        
        public Player(Vector2f position, float angle)
        {
            this.Position = position;
            this.Angle = angle;
        }

        public override string ToString()
        {
            return Position.ToString() + " with Angle " + Angle.ToString() + " degrees";
        }
    }
}
