using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class Scene
    {
        public static int DistanceBetweenCircles { get; set; } = 5;
        public int Rows { get; set; }
        public int Cols { get; set; }
        public bool WithBot { get; set; }
        public Circle[,] Circles { get; set; }
        public bool IsPlayerOne { get; set; }


        public Scene(int rows, int cols, bool withBot)
        {
            Rows = rows;
            Cols = cols;
            WithBot = withBot;
            this.Circles = new Circle[this.Rows, this.Cols];
            this.IsPlayerOne = true;
        }

        public bool AddCircle(Point location)
        {
            return true;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Blue);
            g.FillRectangle(b, 0, 0, Cols * 50, Rows * 50);
            b.Dispose();
        }
        
        public bool DidPlayerWin()
        {
            return true;
        }

        public bool IsTableFull()
        {
            return true;
        }

    }
}
