using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Figures
{
    public class NAngles : IFigure
    {
        public int Ungles { get; set; }
        public Point StartPoint { get; set; }
        public bool Check { get; set; }
        int _crntUngle = 0;
        public Point[] GetPoints(Point[] points)
        {
            return points;
        }
        public void Draw(Graphics graphics, Pen pen, Point[] points)
        {

            Point prevP = points[0];
            Point nowP = points[1];
            if (_crntUngle == 0)
            {
                StartPoint = new Point(nowP.X, nowP.Y);
                graphics.DrawRectangle(pen, StartPoint.X, StartPoint.Y, 0.5f, 0.5f);
                _crntUngle++;
                return;
            }
            if (_crntUngle < Ungles)
                //if (true)
            {
                graphics.DrawPolygon(pen, new Point[2] { prevP, nowP });
                _crntUngle++;
            }
            if (_crntUngle == Ungles)
            {
                graphics.DrawPolygon(pen, new Point[2] { nowP, StartPoint });
            }
        }
    }
}
