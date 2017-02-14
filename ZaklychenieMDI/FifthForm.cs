using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ZaklychenieMDI.Layout;
using static ZaklychenieMDI.SetParameters;

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
            /*
            Rectangle r = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            Bitmap b = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(r.Location, new Point(0, 0), r.Size);
            MemoryStream ms = new MemoryStream();
            b.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            ZaklychenieMDI.Layout.Pic = ms.ToArray();
            ZaklychenieMDI.Layout.Picture = pictureBox1.Image;
            MainForm.Current.Color5 = Color.LawnGreen;
            */
            SixthForm f2 = new SixthForm();
            f2.MdiParent = this.ParentForm; //this refers to f1's parent, the MainForm
            f2.Show();
        }

        private void FifthForm_Load(object sender, EventArgs e)
        {
            string final = (Seti + Line + TkFrom + TkTo).Replace("-", "_").Replace("/", "").Replace("\"", "").Replace(" ","_");
            textBox1.Text = final;
            /*
            if (ZaklychenieMDI.Layout.Pic != null)
            {
                MemoryStream ms = new MemoryStream(ZaklychenieMDI.Layout.Pic);
                pictureBox1.Image = Image.FromStream(ms);
            }
*/            
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

        private void SaveImage()
        {
            Image file = pictureBox1.Image;
            file.Save(ZaklychenieMDI.Layout.Path, ImageFormat.Jpeg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ZaklychenieMDI.Layout.Path = "C:/ZakluchenieFolder/" + textBox1.Text + ".jpeg";
                SaveImage();
                Process.Start("mspaint.exe", "\"C:\\ZakluchenieFolder\\" + textBox1.Text + ".jpeg\"");
                MainForm.Current.Color5 = Color.LawnGreen;
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения изображения! Проверьте название!" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            ;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
