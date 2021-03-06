﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ZaklychenieMDI.ChildForms;



namespace ZaklychenieMDI
{
    public partial class FirstForm : Form
    {
        /*static string GetConnectionStringByName(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
        */

        public FirstForm()
        {
            InitializeComponent();
        }

        private void LoadListLine(string tabl)
        {
            string seti = VvodycomboBox.Text;
            SqlConnection conn = new SqlConnection(Program.Connection.GetConnectionStringByName("Conn"));
            string sql = string.Format("Select Distinct linefrom From {0} where seti = '{1}'", tabl, seti);
            SqlDataAdapter cmd = new SqlDataAdapter(sql, conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                cmd.Fill(ds);
                conn.Close();
                LinecomboBox.DataSource = ds.Tables[0];
                LinecomboBox.DisplayMember = "linefrom";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка участка от!" + ex.Message);
            }
        }

        private void LoadListUzelTo(string tabl)
        {
            string text = VvodycomboBox.Text;
            SqlConnection selectConnection = new SqlConnection(Program.Connection.GetConnectionStringByName("Conn"));
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("Select Distinct uzelto From {0} where seti = '{1}'", (object)tabl, (object)text), selectConnection);
            try
            {
                selectConnection.Open();
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                selectConnection.Close();
                LineTocomboBox.DataSource = (object)dataSet.Tables[0];
                LineTocomboBox.DisplayMember = "uzelto";
            }
            catch
            {
                MessageBox.Show("Ошибка участка от!");
            }
        }

        private void LoadListUzelFrom(string tabl)
        {
            string text = VvodycomboBox.Text;
            SqlConnection selectConnection = new SqlConnection(Program.Connection.GetConnectionStringByName("Conn"));
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("Select Distinct uzelfrom From {0} where seti = '{1}'", (object)tabl, (object)text), selectConnection);
            try
            {
                selectConnection.Open();
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                selectConnection.Close();
                LineFromcomboBox.DataSource = (object)dataSet.Tables[0];
                LineFromcomboBox.DisplayMember = "uzelfrom";
            }
            catch
            {
                MessageBox.Show("Ошибка участка от!");
            }
        }

        private void LoadListSeti(string tabl)
        {
            SqlConnection conn = new SqlConnection(Program.Connection.GetConnectionStringByName("Conn"));
            string sql = string.Format("Select Distinct Seti From {0} Order By Seti", tabl);
            SqlDataAdapter cmd = new SqlDataAdapter(sql, conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                cmd.Fill(ds);
                conn.Close();
                VvodycomboBox.DataSource = ds.Tables[0];
                VvodycomboBox.DisplayMember = "Seti";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка Сетей! + ", ex.Message);
            }
        }

        private string IfArea()
        {
            string str = "";
            if (TypecomboBox.Text == "Абон вводы")
            {
                if (AreacomboBox.Text == "1 район")
                    str = "Info1r";
                if (AreacomboBox.Text == "2 район")
                    str = "Info2r";
                if (AreacomboBox.Text == "3 район")
                    str = "Info3r";
                if (AreacomboBox.Text == "4 район")
                    str = "Info4r";
                if (AreacomboBox.Text == "5 район")
                    str = "Info5r";
                if (AreacomboBox.Text == "6 район")
                    str = "Info6r";
            }
            else
            {
                if (AreacomboBox.Text == "1 район")
                    str = "InfoRsTM1r";
                if (AreacomboBox.Text == "2 район")
                    str = "InfoRsTM2r";
                if (AreacomboBox.Text == "3 район")
                    str = "InfoRsTM3r";
                if (AreacomboBox.Text == "4 район")
                    str = "InfoRsTM4r";
                if (AreacomboBox.Text == "5 район")
                    str = "InfoRsTM5r";
                if (AreacomboBox.Text == "6 район")
                    str = "InfoRsTM6r";
            }
            return str;
        }

        private void TypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypecomboBox.Text == "Абон вводы")
            {
                LinecomboBox.Enabled = true;
            }
            else
            {
                LinecomboBox.Enabled = false;
            }
            AreacomboBox.Text = "";
            VvodycomboBox.Text = "";
            LinecomboBox.Text = "";
            LineFromcomboBox.Text = "";
            LineTocomboBox.Text = "";
        }

        private void AreacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arealabel.Text = IfArea();
            LoadListSeti(IfArea());
        }

        private void VvodycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.Current.Color1 = Color.Red;
            //MainForm.Current.Color2 = Color.Red;
            if (TypecomboBox.Text == "Абон вводы")
            {
                LoadListLine(IfArea());
            }
            LoadListUzelFrom(IfArea());
            LoadListUzelTo(IfArea());
            TrumpetParameters.D = null;
            TrumpetParameters.L = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VvodycomboBox.Text != "" && LineFromcomboBox.Text != "" && LineTocomboBox.Text != "" && Arealabel.Text != "")
            {
                MainForm.Current.Color1 = Color.LawnGreen;
                SetParameters.Seti = VvodycomboBox.Text;
                SetParameters.TkFrom = LineFromcomboBox.Text;
                SetParameters.TkTo = LineTocomboBox.Text;
                SetParameters.Area = Arealabel.Text;
                SetParameters.AreaOfficial = AreacomboBox.Text;
                SetParameters.Line = LinecomboBox.Text;
                if (maskedTextBox1.Text == "N  ,     °")
                {
                    SetParameters.Shirota = "";
                }
                else
                {
                    SetParameters.Shirota = maskedTextBox1.Text;
                }
                if (maskedTextBox1.Text == "E  ,     °")
                {
                    SetParameters.Dolgota = "";
                }
                else
                {
                    SetParameters.Dolgota = maskedTextBox2.Text;
                }
                SecondForm f2 = new SecondForm();
                f2.MdiParent = this.ParentForm; //this refers to f1's parent, the MainForm
                f2.Show();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

            //CloseChildForms();

        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            if ((SetParameters.Seti != null) && (SetParameters.Area != null))
            {
                VvodycomboBox.Text = SetParameters.Seti;
                LineFromcomboBox.Text = SetParameters.TkFrom;
                LineTocomboBox.Text = SetParameters.TkTo;
                Arealabel.Text = SetParameters.Area;
                maskedTextBox1.Text = SetParameters.Shirota;
                maskedTextBox2.Text = SetParameters.Dolgota;
            }
        }

        public void CloseChildForms()
        {
            Form[] form = MdiChildren;
            foreach (Form f in form)
            {
                f.Close();
            }
        }
    }
}
