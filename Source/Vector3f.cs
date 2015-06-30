using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfEngine
{
    class Vector3f
    {
        public float x;
        public float y;
        public float z;

        public Vector3f(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return "(" + x.ToString() + ", " + y.ToString() + ", " + z.ToString() + ")";
        }

        public Vector2f Project()
        {
            // System.Windows.Forms.MessageBox.Show(x.ToString() + ", " + y.ToString() + ", " + z.ToString());
            if (z == 0)
            {
                return new Vector2f(x, y);
            }
            else
            {
                return new Vector2f(x / z, y / z);
            }
        }
    }
}