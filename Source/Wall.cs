using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WolfEngine
{
    class Wall
    {
        public Vector3f Point1;
        public Vector3f Point2;
        public Vector3f Point3;
        public Vector3f Point4;
        public Bitmap WallTexture;

        public Wall(Vector3f point1, Vector3f point3, Bitmap WallTexture)
        {
            this.Point1 = point1;
            this.Point3 = point3;

            //  I worked this out on my notepad, points 1, 2, 3, and 4 are ordered clockwise.
            //  1 ----------------- 2
            //  |                   |
            //  4 ----------------- 3

            this.Point2 = new Vector3f(point1.y, point3.x, point3.z);
            this.Point4 = new Vector3f(Point1.x, Point3.y, point1.z);
            this.WallTexture = WallTexture;
        }

        public Bitmap TransformedTexture()
        {
            YLScsDrawing.Imaging.Filters.FreeTransform filter = new YLScsDrawing.Imaging.Filters.FreeTransform();

            filter.Bitmap = WallTexture;

            // assign four corners of the new perspective shape
            //  1 ----------------- 2
            //  |                   |
            //  4 ----------------- 3

            filter.VertexLeftTop = Point1.Project().ToPoint();
            filter.VertexTopRight = Point2.Project().ToPoint();
            filter.VertexBottomLeft = Point4.Project().ToPoint();
            filter.VertexRightBottom = Point3.Project().ToPoint();

            return filter.Bitmap;
        }
    }
}
