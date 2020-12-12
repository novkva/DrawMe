using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Figures
{
    public static class MathSolve
    {
        public static Point[] SolveUpIsoscelesTriangle(Point start, Point end)
        {
            Point three;
            int x = start.X + (end.X - start.X);
            three = new Point(x, end.Y);
            return new Point[] { start, end, three };
        }

        public static Point[] SolveUpRightTriangle(Point start, Point end)
        {
            Point three;

            three = new Point(start.X, end.Y);

            return new Point[] { start, end, three };
        }

        public static Point[] SolveHorizontalIsoscelesTriangle(Point start, Point end)
        {
            Point three;
            int y = start.Y - (end.Y - start.Y);
            three = new Point(end.X, y);
            return new Point[] { start, end, three };
        }
        public static Point[] SolveDownRightTriangle(Point start, Point end)
        {
            Point three;
            three = new Point(end.X, start.Y);

            return new Point[] { start, end, three };
        }
    }
}
