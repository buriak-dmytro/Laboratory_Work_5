using System;
using System.Windows.Forms;
using System.Drawing;

namespace Task1
{
    class Rhomb : Figure
    {
        private Graphics graphics;
        private Point[] points;

        public Rhomb(int xCenter, int yCenter, int radius, PictureBox pictureBox)
        {
            this.yCenter = yCenter;
            this.radius = radius;
            this.xCenter = xCenter;
            graphics = pictureBox.CreateGraphics();

            InitializeNewPosition();
        }

        private void InitializeNewPosition()
        {
            points = new Point[4]
            {
                new Point(xCenter - radius,  yCenter),
                new Point(xCenter,  yCenter + radius),
                new Point(xCenter + radius,  yCenter),
                new Point(xCenter,  yCenter - radius)
            };
        }

        public override void DrawBlack()
        {
            InitializeNewPosition();
            graphics.DrawPolygon(Pens.Black, points);
        }

        public override void HideDrawingBackground()
        {
            graphics.Clear(Color.White);
        }
    }
}
