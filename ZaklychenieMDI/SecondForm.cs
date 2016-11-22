using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ZaklychenieMDI.Program;

namespace ZaklychenieMDI
{
    public partial class SecondForm : Form
    {
        private int i, j, k, l, m;

        public SecondForm()
        {
            InitializeComponent();
        }

        private void GetPokrytie()
        {
            SqlConnection conn = new SqlConnection(Connection.GetConnectionStringByName("Conn2"));
            string sql = string.Format("Select Distinct Pokrytie From Pokrytie Order By Pokrytie");
            SqlDataAdapter cmd = new SqlDataAdapter(sql, conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                cmd.Fill(ds);
                conn.Close();
                PoktiriecomboBox.DataSource = ds.Tables[0];
                PoktiriecomboBox.DisplayMember = "Pokrytie";
            }
            catch
            {
                MessageBox.Show("Ошибка покрытия!");
            }
        }

        private void GetIzolyacia()
        {
            SqlConnection conn = new SqlConnection(Connection.GetConnectionStringByName("Conn2"));
            string sql = string.Format("Select Distinct Izolyacia From Izolyacia Order By Izolyacia");
            SqlDataAdapter cmd = new SqlDataAdapter(sql, conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                cmd.Fill(ds);
                conn.Close();
                TipIzolyaciicomboBox.DataSource = ds.Tables[0];
                TipIzolyaciicomboBox.DisplayMember = "Izolyacia";
            }
            catch
            {
                MessageBox.Show("Ошибка изоляции!");
            }
        }

        private void GetSumLength(string tablname)
        {
            string seti = SetParameters.Seti;
            string uzelfrom = SetParameters.TkFrom;
            string uzelto = SetParameters.TkTo;
            SqlConnection conn = new SqlConnection(Connection.GetConnectionStringByName("Conn"));
            string sql = string.Format("Select Sum(L) From {0} where(Seti = '{1}' and ID between(select top 1 ID from {2} where (uzelFrom = '{3}' and Seti = '{4}')) and (select max(ID) from {5} where (uzelTo = '{6}' and Seti = '{7}')))", tablname, seti, tablname, uzelfrom, seti, tablname, uzelto, seti);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LtextBox.Text = ((IDataRecord)reader)[0].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка от Суммы!");
            }
        }

        private void FindD(string tabl)
        {
            string a = "";
            string seti = SetParameters.Seti;
            string uzelfrom = SetParameters.TkFrom;
            string uzelto = SetParameters.TkTo;
            SqlConnection conn = new SqlConnection(Connection.GetConnectionStringByName("Conn"));
            string sql = string.Format("select Distinct D from {0} where(Seti = '{1}' and ID between(select top 1 ID from {2} where (UzelFrom = '{3}' and Seti = '{4}')) and (select max(ID) from {5} where (UzelTo = '{6}' and Seti = '{7}')))", tabl, seti, tabl, uzelfrom, seti, tabl, uzelto, seti);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DtextBox.Text = ((IDataRecord)reader)[0].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка в диаметре!" + ex.Message);
            }
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            GetPokrytie();
            GetIzolyacia();
            if (SetParameters.Seti != null)
            {
                if ((TrumpetParameters.D != null) && (TrumpetParameters.Prokladka != null))
                {
                    DtextBox.Text = TrumpetParameters.D;
                    LtextBox.Text = TrumpetParameters.L;
                    TipIzolyaciicomboBox.Text = TrumpetParameters.Izolyacia;
                    PoktiriecomboBox.Text = TrumpetParameters.Pokrytie;
                    TipProkladkicomboBox.SelectedIndex = TrumpetParameters.ProkladkaId;
                }
                else
                {
                    FindD(SetParameters.Area);
                    GetSumLength(SetParameters.Area);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((DtextBox.Text != "") && (LtextBox.Text != "") && (PoktiriecomboBox.Text != "") &&
                (TipIzolyaciicomboBox.Text != "") && (TipProkladkicomboBox.Text != ""))
            {
                TrumpetParameters.D = DtextBox.Text;
                TrumpetParameters.L = LtextBox.Text;
                TrumpetParameters.Izolyacia = TipIzolyaciicomboBox.Text.ToLower();
                TrumpetParameters.Pokrytie = PoktiriecomboBox.Text.ToLower();
                TrumpetParameters.Prokladka = TipProkladkicomboBox.Text.ToLower();
                TrumpetParameters.ProkladkaId = TipProkladkicomboBox.SelectedIndex;
                MainForm.Current.Color2 = Color.LawnGreen;
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void ChangeColor(ref int counter)
        {
            if (counter > 1)
            {
                MainForm.Current.Color2 = Color.Red;
            }
            counter++;
        }

        private void DtextBox_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(ref i);
        }

        private void LtextBox_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(ref j);
        }

        private void TipIzolyaciicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeColor(ref k);
        }

        private void PoktiriecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeColor(ref l);
        }

        private void TipProkladkicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeColor(ref m);
        }
    }
}
