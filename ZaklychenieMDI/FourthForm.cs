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
            Analys.Priznaki = PriznakicomboBox.Text;
            Analys.Pomehi = PomehicomboBox.Text;
            Analys.Analiz = AnalizcomboBox.Text;
            Analys.Stepen = StepencomboBox.Text;
        }
    }
}
