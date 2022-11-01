using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Task1
{
    public partial class mainForm : Form
    {
        private void buttonRunAnimationCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(30, 50, 20, pictureBoxAnimationRepresentation);
            circle.MoveRight();
        }

        private void buttonRunAnimationSquare_Click(object sender, EventArgs e)
        {
            Square square = new Square(30, 50, 20, pictureBoxAnimationRepresentation);
            square.MoveRight();
        }

        private void buttonRunAnimationRhomb_Click(object sender, EventArgs e)
        {
            Rhomb rhomb = new Rhomb(30, 50, 20, pictureBoxAnimationRepresentation);
            rhomb.MoveRight();
        }

        public mainForm()
        {
            InitializeComponent();
        }
    }
}
