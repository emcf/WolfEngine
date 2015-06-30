using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfEngine
{
    public partial class frmMain : Form
    {
        Input input = new Input();
        Map map = new Map();
        Player player = new Player();
        float ix1, iz1, ix2, iz2;

        public frmMain()
        {
            InitializeComponent();
            map.SetMap(@"C:\users\emmet_000\desktop\Room.map");
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateGame(e);
        }

        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush);

            foreach (Wall wall in map.Walls)
            {
                Vector3f Point1Translated = new Vector3f(0, 0, 0);
                Vector3f Point3Translated = new Vector3f(0, 0, 0);
                
                // Translate the verticies around the player
                Point1Translated.x = wall.Point1.x - player.x;
                Point3Translated.x = wall.Point3.x - player.x;
                Point1Translated.y = wall.Point1.y - player.y;
                Point3Translated.y = wall.Point3.y - player.y;
                // z value is constant, don't do anything to it

                Vector3f Point1Rotated = new Vector3f(0, 0, 0);
                Vector3f Point3Rotated = new Vector3f(0, 0, 0);

                /*
                this is an exerpt written in BASIC and is the only 2d first person rotation method I could find
                tz1 = tx1 * COS(angle) + ty1 * SIN(angle)
                tz2 = tx2 * COS(angle) + ty2 * SIN(angle)
                tx1 = tx1 * SIN(angle) - ty1 * COS(angle)
                tx2 = tx2 * SIN(angle) - ty2 * COS(angle)
                */

                // Rotate the verticies around the player
                Point1Rotated.x = (float)(Point1Translated.x * Math.Cos(player.Angle) + Point1Translated.y * Math.Sin(player.Angle));
                Point3Rotated.x = (float)(Point3Translated.x * Math.Cos(player.Angle) + Point3Translated.y * Math.Sin(player.Angle));
                Point1Rotated.y = (float)(Point1Translated.x * Math.Sin(player.Angle) - Point1Translated.y * Math.Cos(player.Angle));
                Point3Rotated.y = (float)(Point3Translated.x * Math.Sin(player.Angle) - Point3Translated.y * Math.Cos(player.Angle));
                // z value is constant, don't do anything to it

                Wall TransformedWall = new Wall(Point1Rotated, Point3Rotated, new Bitmap(@"C:\users\emmet_000\desktop\Room.png"));

                Vector2f Point1Projected = TransformedWall.Point1.Project();
                Vector2f Point2Projected = TransformedWall.Point2.Project();
                Vector2f Point3Projected = TransformedWall.Point3.Project();
                Vector2f Point4Projected = TransformedWall.Point4.Project();

                //MessageBox.Show(Point1Projected.ToString());
                // Why doesn't this work? Finish this soon.

                DrawWall(e, pen, Point1Projected, Point1Projected, Point3Projected, Point4Projected);
            }
        }

        void DrawWall(PaintEventArgs e, Pen pen, Vector2f point1, Vector2f point2, Vector2f point3, Vector2f point4)
        {
            //  I worked this out on my notepad, points 1, 2, 3, and 4 are ordered clockwise.
            //  1 ----------------- 2
            //  |                   |
            //  4 ----------------- 3

            // Draw from 1 to 2
            e.Graphics.DrawLine(pen, point1.x, point1.y, point2.x, point2.y);
            // Draw from 2 to 3
            e.Graphics.DrawLine(pen, point2.x, point2.y, point3.x, point3.y);
            // Draw from 3 to 4
            e.Graphics.DrawLine(pen, point3.x, point3.y, point4.x, point4.y);
            // Draw from 4 to 1
            e.Graphics.DrawLine(pen, point4.x, point4.y, point1.x, point1.y);
        }

        void Render()
        {
            pnlDraw.Invalidate();
            pnlDraw2.Invalidate();
        }

        void CheckKeys(KeyEventArgs e)
        {
            if (input.isMovingForwards(e))
            {
                player.x = (float)(player.x + Math.Cos(player.Angle));
                player.y = (float)(player.y + Math.Sin(player.Angle));
            }
            if (input.isMovingBackwards(e))
            {
                player.x = (float)(player.x - Math.Cos(player.Angle));
                player.y = (float)(player.y - Math.Sin(player.Angle));
            }
            if (input.isMovingRight(e))
            {
                player.x = (float)(player.x + Math.Sin(player.Angle));
                player.y = (float)(player.y - Math.Cos(player.Angle));
            }
            if (input.isMovingLeft(e))
            {
                player.x = (float)(player.x - Math.Sin(player.Angle));
                player.y = (float)(player.y + Math.Cos(player.Angle));
            }
            if (input.isLookingRight(e))
            {
                player.Angle += 0.1f;
            }
            if (input.isLookingLeft(e))
            {
                player.Angle -= 0.1f;
            }
        }

        public float FNCross(float x0, float y0, float x1, float y1)
        {
            // Vector cross product
            return (x0) * (y1) - (x1) * (y0);
        }

        // Intersect: Calculate the point of intersection between two lines.
        void Intersect(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, bool isUsingIX1)
        {
            if (isUsingIX1)
            {
                float x = FNCross(x1, y1, x2, y2);
                float y = FNCross(x3, y3, x4, y4);
                float det = FNCross(x1 - x2, y1 - y2, x3 - x4, y3 - y4);
                ix1 = FNCross(x, x1 - x2, y, x3 - x4) / det;
                iz1 = FNCross(x, y1 - y2, y, y3 - y4) / det;
            }
            else
            {
                float x = FNCross(x1, y1, x2, y2);
                float y = FNCross(x3, y3, x4, y4);
                float det = FNCross(x1 - x2, y1 - y2, x3 - x4, y3 - y4);
                ix2 = FNCross(x, x1 - x2, y, x3 - x4) / det;
                iz2 = FNCross(x, y1 - y2, y, y3 - y4) / det;
            }
        }

        void UpdateGame(KeyEventArgs e)
        {
            // Move according to keys
            CheckKeys(e);

            // TODO: Change the render void to only draw vectors in the player's field of view
            // do this using the vector cross product
            // http://stackoverflow.com/questions/563198/how-do-you-detect-where-two-line-segments-intersect
            Render();
        }

        private void pnlDraw2_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(new SolidBrush(Color.Black));
            e.Graphics.DrawLine(p, player.x, player.y, (float)(Math.Cos(player.Angle) * 5 + player.x), (float)(Math.Sin(player.Angle) * 5 + player.y));
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), player.x, player.y, 2, 2);
        }
    }
}
