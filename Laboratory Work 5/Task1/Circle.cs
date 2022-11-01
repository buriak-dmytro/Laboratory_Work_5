using System;
using System.Windows.Forms;
using System.Drawing;

namespace Task1
{
    class Circle : Figure
    {
        private Graphics graphics;
        private Point point;
        private Size size;
        private Rectangle rectangle;

        public Circle(int xCenter, int yCenter, int radius, PictureBox pictureBox)
        {
            this.yCenter = yCenter;
            this.radius = radius;
            this.xCenter = xCenter;
            graphics = pictureBox.CreateGraphics();

            InitializeNewPosition();
        }

        private void InitializeNewPosition()
        {
            point = new Point(xCenter - radius, yCenter - radius);
            size = new Size(2 * radius, 2 * radius);
            rectangle = new Rectangle(point, size);
        }

        public override void DrawBlack()
        {
            InitializeNewPosition();
            graphics.DrawEllipse(Pens.Black, rectangle);
        }

        public override void HideDrawingBackground()
        {
            graphics.Clear(Color.White);
        }
    }
}
