using System;
using System.Drawing;

namespace WolfEngine
{
    class Wall
    {
        public Vector2f Point1;
        public Vector2f Point2;
        public Vector2f Point3;
        public Vector2f Point4;
        public Vector2f Barycenter;
        public Bitmap WallTexture;

        public Wall(Vector2f point1, Vector2f point3, Bitmap WallTexture)
        {
            this.Point1 = point1;
            this.Point3 = point3;

            //  I worked this out on my notepad, points 1, 2, 3, and 4 are ordered clockwise.
            //  1 ----------------- 2
            //  |                   |
            //  4 ----------------- 3

            this.Point2 = new Vector2f(point1.y, point3.x);
            this.Point4 = new Vector2f(Point1.x, Point3.y);
            this.Barycenter = new Vector2f((point1.x + point3.x) / 2, (point1.y + point3.y) / 2);
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

            filter.VertexLeftTop = Point1.ToPoint();
            filter.VertexTopRight = Point2.ToPoint();
            filter.VertexBottomLeft = Point4.ToPoint();
            filter.VertexRightBottom = Point3.ToPoint();

            return filter.Bitmap;
        }
    }
}
