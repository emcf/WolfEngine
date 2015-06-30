using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace WolfEngine
{
    class Map
    {
        public Wall[] Walls;

        public Map()
        {
            
        }

        public void SetMap(string fileName)
        {
            string[] MapText = File.ReadAllLines(fileName);
            Walls = new Wall[MapText.Length];
            for (int i = 0; i < MapText.Length; i++)
            {
                string[] WallInfo = MapText[i].Split('-');

                Vector3f Point1 = StringToVector3f(WallInfo[0]);
                Vector3f Point3 = StringToVector3f(WallInfo[1]);
                Bitmap Texture = (Bitmap)Bitmap.FromFile(WallInfo[2]);

                Walls[i] = new Wall(Point1, Point3, Texture);
            }
        }

        public Vector3f StringToVector3f(string input)
        {
            // Remove brackets and split at comma
            input = input.Replace("(", "").Replace(")", "");
            string[] xy = input.Split(',');
            
            // This line is really awkward
            float x = (float)Convert.ToDouble(xy[0]);
            float y = (float)Convert.ToDouble(xy[1]);
            float z = (float)Convert.ToDouble(xy[2]);

            return new Vector3f(x, y, z);
        }
    }
}
