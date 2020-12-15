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
        Bitmap _mainBM;
        Bitmap _tmpBM;
        Graphics _graphics;

        AbstractFigure _crntFigure;
        Color _crntColor;
        int _crntWidth;

        Pen pen;
        Point prev;
        bool _MD;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBM = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBM);
            _tmpBM = (Bitmap)_mainBM.Clone();
            _crntColor = Color.Black;
            _crntWidth = 1;

            _crntFigure = new BrushFigure(); // на старте задаем кисть
            _crntFigure.Width = _crntWidth;
            _crntFigure.Color = _crntColor;

            pen = new Pen(_crntColor, _crntWidth); // хз это наверно вообще не нужно
            prev = new Point(0, 0);
            _MD = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_MD)
            {
                //tmpBm.Dispose();
                //tmpBm = (Bitmap)mainBm.Clone();


                AbstractFigure.MouseMoving(_crntFigure, //graphics, prev, 
                    e.Location, //tmpBm,  
                    _mainBM);
                pictureBox1.Image = _crntFigure.ShowBit();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _MD = true;
            AbstractFigure.MouseDown(_crntFigure, e.Location);
            _crntFigure.drawing.crntBit = (Bitmap)_mainBM.Clone();
            //prev = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _MD = false;
            _mainBM = (Bitmap)_crntFigure.ShowBit().Clone();
            //AbstractFigure.MouseUp(_crntFigure, e.Location);
        }

        private void rightTraingle_Click(object sender, EventArgs e)
        {
            _crntFigure = new RightTraingle();
            _crntFigure.Color = _crntColor;
            _crntFigure.Width = _crntWidth;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void purple_Click(object sender, EventArgs e)
        {
            _crntColor = Color.Purple;
            _crntFigure.Color = _crntColor;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void isoscelesTraingle_Click(object sender, EventArgs e)
        {
            _crntFigure = new IsoscelesTraingleFigure();
            _crntFigure.Color = _crntColor;
            _crntFigure.Width = _crntWidth;
        }
    }
}
