using DrawMe.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Figures
{
    public abstract class AbstractFigure
    {
        public Color Color { get; set; }
        public int Width { get; set; }
        public List<Point> Points { get; set; }
        public IDrawing drawing;
        public ISolves solves;
        public void Draw(Graphics graphics, Pen pen, Point[] points)
        {
            drawing.DrawFigure();
        }

        public static void MouseMoving()
        {

        }
        public static void MouseDown()
        {

        }
        public static void MouseUp()
        {

        }
    }
}
