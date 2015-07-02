using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfEngine
{
    public partial class frmMain : Form
    {
        Input input = new Input();
        Map map = new Map();
        Player player = new Player(new Vector2f(0, 0), 0);
        float ix1, iz1, ix2, iz2;
        const int WALL_HEIGHT = 250;

        // Load textures
        Bitmap StoneWall = new Bitmap("Textures//StoneWall.bmp");
        Bitmap MossyStoneWall = new Bitmap("Textures//MossyStoneWall.bmp");
        Bitmap BrickWall = new Bitmap("Textures//BrickWall.bmp");
        Bitmap BlueWall = new Bitmap("Textures//BlueWall.bmp");
        Bitmap WoodFloor = new Bitmap("Textures//WoodFloor.bmp");
        Bitmap Error = new Bitmap("Textures//Error.bmp");
        Bitmap Pistol = new Bitmap("Textures//Pistol.png");
        Bitmap PistolUp = new Bitmap("Textures//PistolUp.png");
        Bitmap PistolShot = new Bitmap("Textures//PistolShot.png");
        Bitmap Guy = new Bitmap("Textures//Guy.bmp");
        Bitmap Floor = new Bitmap("Textures//Floor.png");
        Bitmap Ammo = new Bitmap("Textures//Ammo.png");
        Bitmap Lives = new Bitmap("Textures//Lives.png");
        Bitmap Score = new Bitmap("Textures//Score.png");
        Bitmap Health = new Bitmap("Textures//Health.png");
        Bitmap GunDisplay = new Bitmap("Textures//PistolDisplay.png");
        Bitmap Background = new Bitmap("Textures//Background.png");

        // Load sound
        SoundPlayer BackgroundMusic = new SoundPlayer("Sounds//Theme.wav");
        SoundPlayer PistolSound = new SoundPlayer("Sounds//Pistol.wav");

        public frmMain()
        {
            InitializeComponent();
            map.SetMap("Room.map");

            PistolSound.Load();
            BackgroundMusic.Load();

            // Set textures
            pnlGun.BackgroundImage = Pistol;
            pnlGuy.BackgroundImage = Guy;
            pnlFloorText.BackgroundImage = Floor;
            pnlAmmoText.BackgroundImage = Ammo;
            pnlHPText.BackgroundImage = Health;
            pnlLivesText.BackgroundImage = Lives;
            pnlScoreText.BackgroundImage = Score;
            pnlGunDisplay.BackgroundImage = GunDisplay;

            BackgroundMusic.PlayLooping();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateGame(e);
        }

        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(50, 50, 50));
            Pen pen = new Pen(brush);
            Map TransformedMap = new Map();
            TransformedMap.Walls = new Wall[map.Walls.Length];
            float[] DepthBuffer = new float[map.Walls.Length];

            // Draw floor
            e.Graphics.FillRectangle(brush, 0, pnlDraw.Height / 2 - 25, pnlDraw.Width, pnlDraw.Height);
            
            for (int i = 0; i < map.Walls.Length; i++)
            {
                Wall wall = map.Walls[i];
                Vector2f Point1Translated = new Vector2f(0, 0);
                Vector2f Point3Translated = new Vector2f(0, 0);

                // Translate the verticies around the player
                Point1Translated.x = wall.Point1.x - player.Position.x;
                Point3Translated.x = wall.Point3.x - player.Position.x;
                Point1Translated.y = wall.Point1.y - player.Position.y;
                Point3Translated.y = wall.Point3.y - player.Position.y;

                Wall TranslatedWall = new Wall(Point1Translated, Point3Translated, StoneWall);

                Vector2f Point1Rotated = new Vector2f(0, 0);
                Vector2f Point3Rotated = new Vector2f(0, 0);

                // Rotate the verticies around the player
                Point1Rotated.y = (float)(Point1Translated.x * Math.Cos(player.Angle) + Point1Translated.y * Math.Sin(player.Angle));
                Point3Rotated.y = (float)(Point3Translated.x * Math.Cos(player.Angle) + Point3Translated.y * Math.Sin(player.Angle));
                Point1Rotated.x = (float)(Point1Translated.x * Math.Sin(player.Angle) - Point1Translated.y * Math.Cos(player.Angle));
                Point3Rotated.x = (float)(Point3Translated.x * Math.Sin(player.Angle) - Point3Translated.y * Math.Cos(player.Angle));

                Wall TransformedWall = new Wall(Point1Rotated, Point3Rotated, StoneWall);

                #region Intersect
                // Thanks bisqwit!
                Intersect(TransformedWall.Point1.x, TransformedWall.Point1.x, TransformedWall.Point3.x, TransformedWall.Point3.y, -0.0001f, 0.0001f, -20f, 1f, true);
                Intersect(TransformedWall.Point1.x, TransformedWall.Point1.x, TransformedWall.Point3.x, TransformedWall.Point3.y, 0.0001f, 0.0001f, 20f, 1f, false);

                if (TransformedWall.Point1.y == 0)
                {
                    TransformedWall.Point1.y = 1;
                }
                if (TransformedWall.Point3.y == 0)
                {
                    TransformedWall.Point3.y = 1;
                }
                if (TransformedWall.Point1.y < 0)
                {
                    if (iz1 > 0)
                    {
                        TransformedWall.Point1.x = ix1;
                        TransformedWall.Point1.y = iz1;
                    }
                    else
                    {
                        TransformedWall.Point1.x = ix2;
                        TransformedWall.Point1.y = iz2;
                    }
                }
                if (TransformedWall.Point3.y < 0)
                {
                    if (iz1 > 0)
                    {
                        TransformedWall.Point3.x = ix1;
                        TransformedWall.Point3.y = iz1;
                    }
                    else
                    {
                        TransformedWall.Point3.x = ix2;
                        TransformedWall.Point3.y = iz2;
                    }
                }
                #endregion

                TransformedMap.Walls[i] = TransformedWall;
                DepthBuffer[i] = TransformedWall.Barycenter.y;
            }

            TransformedMap.SortWallsbyDepth();
            SolidBrush TextBrush = new SolidBrush(Color.FromArgb(250, 250, 250));

            for (int i = 0; i < TransformedMap.Walls.Length; i++)
            {
                Wall TransformedWall = TransformedMap.Walls[i];
                float TransformedWallDepth = TransformedWall.Barycenter.y;
                int IndexOfWall = Array.IndexOf(DepthBuffer, TransformedWallDepth);
                Wall wall = map.Walls[IndexOfWall];

                // These are 2D screen coordinates that represent the 3D drawing of the wall in perspective
                // Don't look at these nasty prototypey variables. Pay attention to the vectors below.
                float XLeft = -TransformedWall.Point1.x * 100 / TransformedWall.Point1.y;
                float YTopLeft = -WALL_HEIGHT / TransformedWall.Point1.y;
                float YBottomLeft = WALL_HEIGHT / TransformedWall.Point1.y;
                float XRight = -TransformedWall.Point3.x * 100 / TransformedWall.Point3.y;
                float YTopRight = -WALL_HEIGHT / TransformedWall.Point3.y;
                float YBottomRight = WALL_HEIGHT / TransformedWall.Point3.y;

                Vector2f TopLeft = new Vector2f(XLeft, YTopLeft);
                Vector2f TopRight = new Vector2f(XRight, YTopRight);
                Vector2f BottomLeft = new Vector2f(XLeft, YBottomLeft);
                Vector2f BottomRight = new Vector2f(XRight, YBottomRight);

                bool IsWallNotInScreenBounds = (TopLeft.Add(400).x < 0 && TopLeft.Add(400).x > 800 && BottomRight.Add(400).x < 0 || BottomRight.Add(400).x > 800);

                // Only render the wall if it's in the screen.
                if (!IsWallNotInScreenBounds)
                {
                    YLScsDrawing.Imaging.Filters.FreeTransform filter = new YLScsDrawing.Imaging.Filters.FreeTransform();
                    filter.Bitmap = wall.WallTexture;

                    filter.VertexLeftTop = TopLeft.ToPoint();
                    filter.VertexTopRight = TopRight.ToPoint();
                    filter.VertexBottomLeft = BottomLeft.ToPoint();
                    filter.VertexRightBottom = BottomRight.ToPoint();
                    // Looks way nicer.
                    filter.IsBilinearInterpolation = true;
                    System.Drawing.Bitmap perspectiveImg = filter.Bitmap;

                    // Draw image on the Y axis of the tallest point on the wall
                    // This is because, well, trust me, it makes sense.
                    // http://i.imgur.com/jgp8faz.png this is why.
                    float LeftLineHeight = BottomLeft.y - TopLeft.y;
                    float RightLineHeight = BottomRight.y - TopRight.y;

                    if (RightLineHeight > LeftLineHeight)
                    {
                        Vector2f DrawPoint = new Vector2f(TopLeft.x, TopRight.y);
                        e.Graphics.DrawImage(perspectiveImg, DrawPoint.Add(400).ToPoint());
                    }
                    else
                    {
                        e.Graphics.DrawImage(perspectiveImg, TopLeft.Add(400).ToPoint());
                    }

                    // Lighting calculation
                    float Barycenter = map.Walls[IndexOfWall].Barycenter.y;
                    int LightDensity = (int)Math.Abs((Barycenter * 150 % 255 - 100));
                    if (LightDensity > 255)
                    {
                        LightDensity = 255;
                    }
                    // Draw a semi-transparent polygon on the wall using an ARGB value
                    Brush LightingBrush = new SolidBrush(Color.FromArgb(90, LightDensity, LightDensity, LightDensity));
                    PointF[] PolyPoints = {
                                          TopLeft.Add(400).ToPoint(),
                                          TopRight.Add(400).ToPoint(),
                                          BottomRight.Add(400).ToPoint(),
                                          BottomLeft.Add(400).ToPoint() 
                                          };
                    e.Graphics.FillPolygon(LightingBrush, PolyPoints);

                    // Ceiling
                    e.Graphics.DrawLine(pen, TopLeft.Add(400).ToPoint(), TopRight.Add(400).ToPoint());
                    // Floor
                    e.Graphics.DrawLine(pen, BottomLeft.Add(400).ToPoint(), BottomRight.Add(400).ToPoint());
                    // Connect ceiling and floor
                    e.Graphics.DrawLine(pen, TopLeft.Add(400).ToPoint(),BottomLeft.Add(400).ToPoint());
                    e.Graphics.DrawLine(pen, TopRight.Add(400).ToPoint(), BottomRight.Add(400).ToPoint());
                }
            }

            // Draw player
            // e.Graphics.DrawLine(pen, player.Position.Add(400).ToPoint(), player.Position.Add(400).ToPoint());
            // e.Graphics.FillRectangle(new SolidBrush(Color.Red), 100, 100, 2, 2);
        }

        void Render()
        {
            pnlDraw.Invalidate();
        }

        async void CheckKeys(KeyEventArgs e)
        {
            if (input.isShooting(e))
            {
                await Task.Delay(50);
                pnlGun.BackgroundImage = PistolUp;
                PistolSound.Play();
                await Task.Delay(100);
                pnlGun.BackgroundImage = PistolShot;
                await Task.Delay(75);
                pnlGun.BackgroundImage = PistolUp;
                await Task.Delay(30);
                pnlGun.BackgroundImage = Pistol;
                BackgroundMusic.PlayLooping();
            }
            if (input.isMovingForwards(e))
            {
                player.Position.x = (float)(player.Position.x + Math.Cos(player.Angle));
                player.Position.y = (float)(player.Position.y + Math.Sin(player.Angle));
            }
            if (input.isMovingBackwards(e))
            {
                player.Position.x = (float)(player.Position.x - Math.Cos(player.Angle));
                player.Position.y = (float)(player.Position.y - Math.Sin(player.Angle));
            }
            if (input.isMovingRight(e))
            {
                player.Position.x = (float)(player.Position.x - Math.Sin(player.Angle));
                player.Position.y = (float)(player.Position.y + Math.Cos(player.Angle));
            }
            if (input.isMovingLeft(e))
            {
                player.Position.x = (float)(player.Position.x + Math.Sin(player.Angle));
                player.Position.y = (float)(player.Position.y - Math.Cos(player.Angle));
            }
            if (input.isLookingRight(e))
            {
                player.Angle += 0.05f;
            }
            if (input.isLookingLeft(e))
            {
                player.Angle -= 0.05f;
            }
            // player.Angle = MousePosition.X / 200f;
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
            CheckKeys(e);
            Render();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            this.BackgroundImage = Background;
        }
    }
}
