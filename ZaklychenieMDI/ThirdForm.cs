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
    public partial class ThirdForm : Form
    {
        public ThirdForm()
        {
            InitializeComponent();
        }

        private void CheckCheckBox(CheckBox checkBox)
        {
            if (checkBox.Checked == true)
            {
                EquipmentBox.Text = (EquipmentBox.Text + checkBox.Text + ", ").ToLower();
            }
            else
            {
                EquipmentBox.Text = EquipmentBox.Text.Replace(checkBox.Text.ToLower() + ", ", "");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBox(checkBox1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBox(checkBox2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBox(checkBox3);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBox(checkBox6);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBox(checkBox4);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBox(checkBox5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EquipmentBox.Text != "")
            {
                Equipment.AllEquipment = EquipmentBox.Text.Substring(0, EquipmentBox.Text.Length - 2);
                MainForm.Current.Color3 = Color.LawnGreen;

                FourthForm f4 = new FourthForm();
                f4.MdiParent = this.ParentForm; //this refers to f1's parent, the MainForm
                f4.Show();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void ThirdForm_Load(object sender, EventArgs e)
        {
            EquipmentBox.Text = Equipment.AllEquipment;
        }

        private void EquipmentBox_TextChanged(object sender, EventArgs e)
        {
            MainForm.Current.Color3 = Color.Red;
        }
    }
}
