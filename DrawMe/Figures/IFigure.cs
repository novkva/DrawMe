using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Figures
{
    public interface IFigure
    {
        bool Check { get; set; }
        Point[] GetPoints(Point[] points);
        void Draw(Graphics graphics, Pen pen, Point[] points);
    }
}
