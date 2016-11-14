﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            //Bitmap bm = new Bitmap(pictureBox1.Image);
            //MemoryStream ms = new MemoryStream();
            //bm.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            //ZaklychenieMDI.Layout.Pic = ms.ToArray();
            Rectangle r = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            Bitmap b = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(r.Location, new Point(0, 0), r.Size);
            MemoryStream ms = new MemoryStream();
            b.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            ZaklychenieMDI.Layout.Pic = ms.ToArray();
            MainForm.Current.Color5 = Color.LawnGreen;
        }

        private void FifthForm_Load(object sender, EventArgs e)
        {
            if (ZaklychenieMDI.Layout.Pic != null)
            {
                MemoryStream ms = new MemoryStream(ZaklychenieMDI.Layout.Pic);
                pictureBox1.Image = Image.FromStream(ms);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {

                case "Камера + дом":
                    pictureBox1.Image = Properties.Resources.камера_дом;
                    break;

                case "Дом + камера":
                    pictureBox1.Image = Properties.Resources.дом_камера;
                    break;

                case "Камера + камера":
                    pictureBox1.Image = Properties.Resources.камера_камера;
                    break;

                case "Дом + дом":
                    pictureBox1.Image = Properties.Resources.дом_дом;
                    break;

                case "Камера + камера + дом":
                    pictureBox1.Image = Properties.Resources.камера_камера_дом;
                    break;

                case "Камера + дом + камера":
                    pictureBox1.Image = Properties.Resources.камера_дом_камера;
                    break;

                case "Дом + камера + камера":
                    pictureBox1.Image = Properties.Resources.дом_камера_камера;
                    break;

                case "Узел + узел":
                    pictureBox1.Image = Properties.Resources.узел_узел;
                    break;

                case "Нет":
                    pictureBox1.Image = Properties.Resources.нет;
                    break;

                case "Камера + дорога":
                    pictureBox1.Image = Properties.Resources.камера_дорога;
                    break;

                case "Дом + дорога":
                    pictureBox1.Image = Properties.Resources.дом_дорога;
                    break;

                case "Камера + дорога + камера":
                    pictureBox1.Image = Properties.Resources.камера_дорога_камера;
                    break;

                case "Дом + дорога + камера":
                    pictureBox1.Image = Properties.Resources.дом_дорога_камера;
                    break;

                default:
                    pictureBox1.Image = Properties.Resources.нет;
                    break;
            }
        }
    }
}
