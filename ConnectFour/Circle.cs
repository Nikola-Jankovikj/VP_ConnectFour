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
        public Color Color { get; set; }

        public Circle()
        {
            this.Color = Color.White;
        }

        public void Draw(Graphics g)
        {

        }

    }
}
