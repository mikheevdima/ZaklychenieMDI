using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaklychenieMDI
{
    public partial class FifthForm : Form
    {
        List<TwoPoint> twoPoint = new List<TwoPoint>();
        private bool IsClicked = false;

        private int X = 0;
        private int Y = 0;

        private int X1 = 0;
        private int Y1 = 0;
        
        public FifthForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsClicked = true;
            X = e.X;
            Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                X1 = e.X;
                Y1 = e.Y;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
            twoPoint.Add(new TwoPoint(new Point(X, Y), new Point(X1, Y1)));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(pen, new Point(X, Y),new Point(X1, Y1));
            foreach (var p in twoPoint)
            {
                e.Graphics.DrawLine(pen, p.X, p.Y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZaklychenieMDI.Layout.Pic = pictureBox1.Image;
            MainForm.Current.Color5 = Color.LawnGreen;
        }

        private void FifthForm_Load(object sender, EventArgs e)
        {
            if (ZaklychenieMDI.Layout.Pic != null)
            {
                pictureBox1.Image = ZaklychenieMDI.Layout.Pic;
            }
            
        }
    }
}
