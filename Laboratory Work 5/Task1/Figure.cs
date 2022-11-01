using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Task1
{
    abstract class Figure
    {
        protected int xCenter;
        protected int yCenter;
        protected int radius;

        public abstract void DrawBlack();

        public abstract void HideDrawingBackground();

        public void MoveRight()
        {
            for (int i = 30; i < 250; i++)
            {
                DrawBlack();
                Thread.Sleep(10);
                HideDrawingBackground();
                xCenter++;
            }
        }
    }
}
