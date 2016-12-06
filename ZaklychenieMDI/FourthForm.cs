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
                Analys.PriznakiId = PriznakicomboBox.SelectedIndex;
                Analys.PomehiId = PomehicomboBox.SelectedIndex;
                Analys.AnalizId = AnalizcomboBox.SelectedIndex;
                Analys.StepenId = StepencomboBox.SelectedIndex;
                Analys.Primechanie = PrimechanietextBox.Text;
                MainForm.Current.Color4 = Color.LawnGreen;

                FifthForm f5 = new FifthForm();
                f5.MdiParent = this.ParentForm; //this refers to f1's parent, the MainForm
                f5.Show();
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

        private void FourthForm_Load(object sender, EventArgs e)
        {
            if (Analys.Priznaki != null)
            {
                PriznakicomboBox.SelectedIndex = Analys.PriznakiId;
                PomehicomboBox.SelectedIndex = Analys.PomehiId;
                AnalizcomboBox.SelectedIndex = Analys.AnalizId;
                StepencomboBox.SelectedIndex = Analys.StepenId;
                PrimechanietextBox.Text = Analys.Primechanie;
            }
        }
    }
}
