﻿using System;

namespace WolfEngine
{
    class Vertex
    {
        public Vector3f Pos3D;
        public Vector2f Pos2D;

        public Vertex(Vector3f pos3d, Vector2f pos2d)
        {
            this.Pos3D = pos3d;
            this.Pos2D = pos2d;
        }
    }
}
