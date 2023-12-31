﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class Circle
    {
        public Point Center { get; set; }
        public static int Radius { get; set; } = 35;
        public Color Color { get; set; }

        public Circle(Point center)
        {
            this.Color = Color.White;
            Center = center;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X -  Radius, Center.Y - Radius, 2*Radius, 2*Radius);
            brush.Dispose();
            Pen pen = new Pen(Color.RoyalBlue);
            pen.Width = 2;
            g.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            pen.Dispose();
        }

    }
}
