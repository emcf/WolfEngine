using System;
using System.IO;
using System.Drawing;
using System.Linq;

namespace WolfEngine
{
    class Map
    {
        public Wall[] Walls;
        public int[] OrderedWallIDs;

        public Map()
        {
            
        }

        public void SortWallsbyDepth()
        {
            OrderedWallIDs = Enumerable.Range(0, Walls.Length).ToArray();
            BubbleSort(Walls);
        }

        // I know bubblesorting is slow, but it is the simplist way to show how a depth-buffer works.
        private void BubbleSort(Wall[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                // j is the wall index
                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    if (inputArray[j].Barycenter.y < inputArray[j + 1].Barycenter.y)
                    {
                        // Swap Walls
                        Wall tempWall = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = tempWall;

                        // Swap Wall Order
                        int tempInt = OrderedWallIDs[j];
                        OrderedWallIDs[j] = OrderedWallIDs[j + 1];
                        OrderedWallIDs[j + 1] = tempInt;
                    }
                }
            }
        }

        public void SetMap(string fileName)
        {
            string[] MapText = File.ReadAllLines(fileName);
            Walls = new Wall[MapText.Length];
            for (int i = 0; i < MapText.Length; i++)
            {
                string[] WallInfo = MapText[i].Split('-');

                Vector2f Point1 = StringToVector2f(WallInfo[0]);
                Vector2f Point3 = StringToVector2f(WallInfo[1]);
                Bitmap Texture = (Bitmap)Bitmap.FromFile(WallInfo[2]);

                Walls[i] = new Wall(Point1, Point3, Texture);
            }
        }

        public Vector2f StringToVector2f(string input)
        {
            // Remove brackets and split at comma
            input = input.Replace("(", "").Replace(")", "");
            string[] xy = input.Split(',');
            
            // This line is really awkward
            float x = (float)Convert.ToDouble(xy[0]);
            float y = (float)Convert.ToDouble(xy[1]);

            return new Vector2f(x, y);
        }
    }
}
