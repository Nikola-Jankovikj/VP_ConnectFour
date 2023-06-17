﻿using System;
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
        public int LastCircleRow { get; set; } = -1;
        public int LastCircleCol { get; set; } = -1;



        public Scene(int rows, int cols, bool withBot)
        {
            Rows = rows;
            Cols = cols;
            WithBot = withBot;
            this.Circles = new Circle[this.Rows, this.Cols];

            int center_x;
            int center_y;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    center_x = j * (2 * Circle.Radius + 2 * DistanceBetweenCircles) + Circle.Radius + DistanceBetweenCircles;
                    center_y = i * (2 * Circle.Radius + 2 * DistanceBetweenCircles) + Circle.Radius + DistanceBetweenCircles;
                    Circles[i, j] = new Circle(new Point(center_x, center_y));
                }
            }
            this.IsPlayerOne = true;
        }

        public bool AddCircle(Point location)
        {
            int col = location.X / (2 * Circle.Radius + 2 * DistanceBetweenCircles);

            if (Circles[0,col].Color != Color.White)
            {
                return false;
            }

            int row = 0;

            while (row+1 < Rows && Circles[row+1,col].Color == Color.White)
            {
                row++;
            }

            Circles[row,col].Color = IsPlayerOne ? Color.Red : Color.Yellow;
            LastCircleRow = row;
            LastCircleCol = col;

            IsPlayerOne = !IsPlayerOne;

            return true;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Blue);
            g.FillRectangle(b, 0, 0, Cols * (2 * Circle.Radius + 2 * DistanceBetweenCircles), Rows * (2 * Circle.Radius + 2 * DistanceBetweenCircles));
            b.Dispose();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Circles[i,j].Draw(g);
                }
            }
        }
        
        public bool DidPlayerWin()
        {
            if (LastCircleRow == -1)
            {
                return false;
            }

            int connected = 0;
            Color currentColor = Circles[LastCircleRow, LastCircleCol].Color;

            // vertical
            for (int n = 0; n < Rows; n++)
            {
                if (Circles[n, LastCircleCol].Color == currentColor)
                {
                    connected++;
                }
                else
                {
                    connected = 0;
                }

                if (connected == 4)
                {
                    IsPlayerOne = currentColor == Color.Red;
                    return true;
                }
            }

            // horizontal
            connected = 0;

            for (int n = 0; n < Cols; n++)
            {
                if (Circles[LastCircleRow, n].Color == currentColor)
                {
                    connected++;
                }
                else
                {
                    connected = 0;
                }

                if (connected == 4)
                {
                    IsPlayerOne = currentColor == Color.Red;
                    return true;
                }
            }

            // first diagonal
            connected = 0;
            int i;
            int j;

            if (LastCircleRow < LastCircleCol)
            {
                i = 0;
                j = LastCircleCol - LastCircleRow;
            }
            else
            {
                i = LastCircleRow - LastCircleCol;
                j = 0;
            }

            while (i < Rows && j < Cols)
            {
                if (Circles[i, j].Color == currentColor)
                {
                    connected++;
                }
                else
                {
                    connected = 0;
                }

                if (connected == 4)
                {
                    IsPlayerOne = currentColor == Color.Red;
                    return true;
                }

                i++;
                j++;
            }

            // second diagonal
            connected = 0;

            if (LastCircleRow < Cols - LastCircleCol - 1)
            {
                i = 0;
                j = LastCircleCol + LastCircleRow;
            }
            else
            {
                i = LastCircleRow - Cols + LastCircleCol + 1;
                j = Cols - 1;
            }

            while (i < Rows && j > 0)
            {
                if (Circles[i, j].Color == currentColor)
                {
                    connected++;
                }
                else
                {
                    connected = 0;
                }

                if (connected == 4)
                {
                    IsPlayerOne = currentColor == Color.Red;
                    return true;
                }

                i++;
                j--;
            }

            return false;
        }

        public bool IsTableFull()
        {

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (Circles[i,j].Color == Color.White)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void turnTimeEnded()
        {
            IsPlayerOne = !IsPlayerOne;
        }

    }
}
