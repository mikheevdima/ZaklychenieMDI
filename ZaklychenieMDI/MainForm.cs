using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaklychenieMDI
{
    public partial class MainForm : Form
    {

        private void Color()
        {
            toolStripMenuItem1.BackColor = System.Drawing.Color.Red;
            toolStripMenuItem2.BackColor = System.Drawing.Color.Red;
            toolStripMenuItem3.BackColor = System.Drawing.Color.Red;
            toolStripMenuItem4.BackColor = System.Drawing.Color.Red;
            toolStripMenuItem5.BackColor = System.Drawing.Color.Red;
            toolStripMenuItem6.BackColor = System.Drawing.Color.Red;
        }

        public static MainForm Current;

        public Color Color1
        {
            get { return toolStripMenuItem1.BackColor; }
            set { toolStripMenuItem1.BackColor = value; }
        }

        public Color Color2
        {
            get { return toolStripMenuItem2.BackColor; }
            set { toolStripMenuItem2.BackColor = value; }
        }

        public Color Color3
        {
            get { return toolStripMenuItem3.BackColor; }
            set { toolStripMenuItem3.BackColor = value; }
        }

        public Color Color4
        {
            get { return toolStripMenuItem4.BackColor; }
            set { toolStripMenuItem4.BackColor = value; }
        }

        public Color Color5
        {
            get { return toolStripMenuItem5.BackColor; }
            set { toolStripMenuItem5.BackColor = value; }
        }

        public Color Color6
        {
            get { return toolStripMenuItem6.BackColor; }
            set { toolStripMenuItem6.BackColor = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            Current = this;
        }

        private void CloseChildForms()
        {
            Form[] form = MdiChildren;
            foreach (Form f in form)
            {
                f.Close();
            }
        }

        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FirstForm")
                {
                    return;
                }
            }
            CloseChildForms();
            FirstForm fr1 = new FirstForm();
            fr1.MdiParent = this;
            fr1.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "SecondForm")
                {
                    return;
                }
            }
            CloseChildForms();
            SecondForm fr2 = new SecondForm();
            fr2.MdiParent = this;
            fr2.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "ThirdForm")
                {
                    return;
                }
            }
            CloseChildForms();
            ThirdForm fr3 = new ThirdForm();
            fr3.MdiParent = this;
            fr3.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Color();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FourthForm")
                {
                    return;
                }
            }
            CloseChildForms();
            FourthForm fr4 = new FourthForm();
            fr4.MdiParent = this;
            fr4.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FifthForm")
                {
                    return;
                }
            }
            CloseChildForms();
            FifthForm fr5 = new FifthForm();
            fr5.MdiParent = this;
            fr5.Show();
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "SixthForm")
                {
                    return;
                }
            }
            CloseChildForms();
            SixthForm fr6 = new SixthForm();
            fr6.MdiParent = this;
            fr6.Show();
        }
    }
}
