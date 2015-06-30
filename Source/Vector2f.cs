using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}