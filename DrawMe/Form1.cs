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
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Pen pen;
        Point prev;
        Point prevv;
        Graphics graphics;
        bool MD;
        Bitmap tmpbmp;
        IFigure crntFigure;
        NAngles nAngles; // change
        bool mCl;
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
            prevv = new Point(0, 0);
            MD = false;
            mCl = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MD)
            {
                tmpbmp.Dispose();
                tmpbmp = (Bitmap)bitmap.Clone();
                graphics = Graphics.FromImage(tmpbmp);
                crntFigure.Draw(graphics, pen, crntFigure.GetPoints(new Point[] { prev, e.Location }));
                pictureBox1.Image = tmpbmp;

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            crntFigure.Check = checkBox1.Checked;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            crntFigure = new RightTraingle();
            checkBox1.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            crntFigure = new IsoscelesTraingles();
            checkBox1.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
            nAngles = new NAngles(); // change
            mCl = true;
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (mCl)
            {
                tmpbmp.Dispose();
                tmpbmp = (Bitmap)bitmap.Clone();
                graphics = Graphics.FromImage(tmpbmp);
                pictureBox1.BackColor = Color.Azure;
                nAngles.Draw(graphics, pen, prevv, e.Location);
                prevv = e.Location;
                pictureBox1.Image = tmpbmp;
            }
        }
    }
}
