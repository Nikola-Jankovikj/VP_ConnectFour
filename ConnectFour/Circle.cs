using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class Circle
    {
        public static int Radius { get; set; } = 20;

        public Point Center { get; set; }
        public Color Color { get; set; }

        public Circle(Point location)
        {
            Center = location;
            this.Color = Color.White;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
        }

    }
}
