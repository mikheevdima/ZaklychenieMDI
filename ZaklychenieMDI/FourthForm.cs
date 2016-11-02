using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaklychenieMDI
{
    public partial class FourthForm : Form
    {
        public FourthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((PriznakicomboBox.Text != "") && (PomehicomboBox.Text != "") && (StepencomboBox.Text != "") &&
                (AnalizcomboBox.Text != ""))
            {
                Analys.Priznaki = PriznakicomboBox.Text;
                Analys.Pomehi = PomehicomboBox.Text;
                Analys.Analiz = AnalizcomboBox.Text;
                Analys.Stepen = StepencomboBox.Text;
                MainForm.Current.Color4 = Color.LawnGreen;
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void PriznakicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.Current.Color4 = Color.Red;
        }

        private void PomehicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.Current.Color4 = Color.Red;
        }

        private void StepencomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.Current.Color4 = Color.Red;
        }

        private void AnalizcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.Current.Color4 = Color.Red;
        }

        private void PrimechanietextBox_TextChanged(object sender, EventArgs e)
        {
            MainForm.Current.Color4 = Color.Red;
        }
    }
}
