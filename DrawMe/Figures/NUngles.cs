using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Figures
{
    public class NAngles
    {
        public int Ungles { get; set; }
        public Point StartPoint { get; set; }
        bool Check { get; set; }
        int _crntUngle = 0;
        //Point[] GetPoints(Point[] points)
        //{

        //}
        public void Draw(Graphics graphics, Pen pen, Point prevP, Point nowP)
        {
            if (_crntUngle == 0)
            {
                StartPoint = new Point(nowP.X, nowP.Y);
                graphics.DrawRectangle(pen, StartPoint.X, StartPoint.Y, 0.5f, 0.5f);
                _crntUngle++;
                return;
            }
            if (_crntUngle < Ungles)
            {
                graphics.DrawPolygon(pen, new Point[2] { prevP, nowP });
                _crntUngle++;
                if (_crntUngle == Ungles )
                {
                graphics.DrawPolygon(pen, new Point[2] { nowP, StartPoint});
                }
            }
        }
    }
}
