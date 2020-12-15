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
        public void Draw(Point crnt, Bitmap mainBM)
        {
            Points = new List<Point>(solves.DoPoint(new Point[] { drawing.startPoint, crnt }));
            drawing.DrawFigure(Color, Width, Points.ToArray(), mainBM);
        }

        public Bitmap ShowBit()
        {
            return drawing.crntBit;
        }

        public void DoStart(Point startPoint)
        {
            drawing.startPoint = startPoint;
        }

        public static void MouseMoving(AbstractFigure crntFigure, Point crnt, Bitmap mainBM)
        {
            crntFigure.Draw(crnt, mainBM);
        }
        public static void MouseDown(AbstractFigure abstractFigure, Point startPoint)
        {
            abstractFigure.DoStart(startPoint);

        }
        public static void MouseUp()
        {

        }
    }
}
