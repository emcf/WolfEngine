﻿using System;
using System.Windows.Forms;

namespace WolfEngine
{
    class Input
    {
        // public Vector2f MousePos;

        public bool isShooting(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isMovingLeft(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isMovingRight(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isMovingBackwards(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isMovingForwards(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isLookingRight(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isLookingLeft(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}