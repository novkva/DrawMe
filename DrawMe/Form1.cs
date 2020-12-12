using DrawMe.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawMe
    //fsrhhrt
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Pen pen;
        Point prev;
        Graphics graphics;
        bool MD;
        Bitmap tmpbmp;
        bool shi;
        IFigure crntFigure;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            tmpbmp = (Bitmap)bitmap.Clone();
            graphics = Graphics.FromImage(bitmap);
            pen = new Pen(Color.Black, 1);
            prev = new Point(0, 0);
            MD = false;
            shi = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            crntFigure = new RightTraingle();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MD)
            {
                tmpbmp.Dispose();
                tmpbmp = (Bitmap)bitmap.Clone();
                graphics = Graphics.FromImage(tmpbmp);
                //graphics.Clear(Color.FromArgb(192, 192, 255));
                //graphics.DrawPolygon(pen, crntFigure.GetPoints(new Point[] { prev, e.Location }));
                crntFigure.Draw(graphics, pen, crntFigure.GetPoints(new Point[] { prev, e.Location }));

                //graphics.DrawLine(pen, prev, e.Location);
                pictureBox1.Image = tmpbmp;
                //prev = e.Location;

            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = e.Location;
            MD = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            bitmap = (Bitmap)tmpbmp.Clone();
            MD = false;
        }

    }
}
