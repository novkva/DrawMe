using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Figures
{
    public class RightTraingle : IFigure
    {
        public bool Check { get; set; }
        public void Draw(Graphics graphics, Pen pen, Point[] points)
        {
            graphics.DrawPolygon(pen, points);
        }

        public Point[] GetPoints(Point[] points)
        {
            return GetPointsCheck(points, Check);
        }

        private Point[] GetPointsCheck(Point[] points, bool check)
        {
            if (check)
            {
            return MathSolve.SolveUpRightTriangle(points[0], points[1]);
            }
            else
            {
                return MathSolve.SolveDownRightTriangle(points[0], points[1]);
            }
        }
    }
}
