using System;
using System.Drawing;

namespace WolfEngine
{
    class Vector2f
    {
        public float x;
        public float y;

        public Vector2f(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "(" + x.ToString() + ", " + y.ToString() + ")";
        }

        public float DotProduct(Vector2f inputVector)
        {
            return x * inputVector.x + y * inputVector.y;
        }

        public PointF ToPoint()
        {
            return new PointF(this.x, this.y);
        }

        public Vector2f Project()
        {
            // Use a constant y value for height to project the XZ point to an XY point on the screen
            if (y == 0)
            {
                return new Vector2f(x, y);
            }
            else
            {
                return new Vector2f(x / y, 10 / y);
            }
        }

        // I KNOW! It's adding an uneven amount! What is Emmett thinking?!
        // It's because of the lopsided 800x600 resolution. To make things look better.
        public Vector2f Add(float amount)
        {
            return new Vector2f(x + amount, y + amount / 2);
        }
    }
}