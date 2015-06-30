using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfEngine
{
    class Player
    {
        public float x;
        public float y;
        public float z;
        public float Angle;
        
        public Player()
        {

        }

        public override string ToString()
        {
            return "(" + x.ToString() + ", " + y.ToString() + ", " + z.ToString() + ") with Angle " + Angle.ToString() + " degrees";
        }
    }
}
