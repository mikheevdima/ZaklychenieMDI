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
using static ZaklychenieMDI.Conclusion;
using static ZaklychenieMDI.Analys;
using static ZaklychenieMDI.Equipment;
using static ZaklychenieMDI.Layout;
using static ZaklychenieMDI.SetParameters;
using static ZaklychenieMDI.TrumpetParameters;

namespace ZaklychenieMDI
{
    public partial class SixthForm : Form
    {
        public SixthForm()
        {
            InitializeComponent();
        }

        private void GetId()
        {
            SqlConnection conn = new SqlConnection(Program.Connection.GetConnectionStringByName("Conn3"));
            string sql = string.Format("select max(ID) from Parameters");
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IdcomboBox.Text = ((IDataRecord)reader)[0].ToString();
                }
                reader.Close();
                conn.Close();
                IdcomboBox.Text = (Convert.ToInt32(IdcomboBox.Text) + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в ID!" + ex.Message);
            }
        }

        private void Save()
        {
            SqlConnection conn = new SqlConnection(Program.Connection.GetConnectionStringByName("Conn3"));
            string sql = string.Format("Insert Into Parameters(ID, seti, tkfrom, tkto, shirota, dolgota, d, l, izolyacia, pokritie, prokladka, " +
                                       "allequipment, priznaki, pomehi, stepen, analiz, primechanie, pic, goal, ispolnitel, boss, date, results) " +
                                       "Values(@ID, @seti, @tkfrom, @tkto, @shirota, @dolgota, @d, @l, @izolyacia, @pokritie, @prokladka, " +
                                       "@allequipment, @priznaki, @pomehi, @stepen, @analiz, @primechanie, @pic, @goal, @ispolnitel, @boss, @date, @results)");
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@ID", Conclusion.Id);
                cmd.Parameters.AddWithValue("@seti", SetParameters.Seti);
                cmd.Parameters.AddWithValue("@tkfrom", SetParameters.TkFrom);
                cmd.Parameters.AddWithValue("@tkto", SetParameters.TkTo);
                cmd.Parameters.AddWithValue("@shirota", SetParameters.Shirota);
                cmd.Parameters.AddWithValue("@dolgota", SetParameters.Dolgota);
                cmd.Parameters.AddWithValue("@d", TrumpetParameters.D);
                cmd.Parameters.AddWithValue("@l", TrumpetParameters.L);
                cmd.Parameters.AddWithValue("@izolyacia", TrumpetParameters.Izolyacia);
                cmd.Parameters.AddWithValue("@pokritie", TrumpetParameters.Pokrytie);
                cmd.Parameters.AddWithValue("@prokladka", TrumpetParameters.Prokladka);
                cmd.Parameters.AddWithValue("@allequipment", Equipment.AllEquipment);
                cmd.Parameters.AddWithValue("@priznaki", Analys.Priznaki);
                cmd.Parameters.AddWithValue("@pomehi", Analys.Pomehi);
                cmd.Parameters.AddWithValue("@stepen", Analys.Stepen);
                cmd.Parameters.AddWithValue("@analiz", Analys.Analiz);
                cmd.Parameters.AddWithValue("@primechanie", Analys.Primechanie);
                cmd.Parameters.AddWithValue("@pic", ZaklychenieMDI.Layout.Pic);
                cmd.Parameters.AddWithValue("@goal", Conclusion.Goal);
                cmd.Parameters.AddWithValue("@ispolnitel", Conclusion.Ispolnitel);
                cmd.Parameters.AddWithValue("@boss", Conclusion.Boss);
                cmd.Parameters.AddWithValue("@date", Conclusion.Date);
                cmd.Parameters.AddWithValue("@results", Conclusion.Results);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Сохранение выполнено!");
                    conn.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ошибка сохранения! " + exception.Message);
                    throw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BosstextBox.Text != "" && GoalcomboBox.Text != "" && ResultscomboBox.Text != "" && IspolnitelcomboBox.Text != "")
            {
                Conclusion.Boss = BosstextBox.Text;
                Goal = GoalcomboBox.Text;
                Results = ResultscomboBox.Text;
                Ispolnitel = IspolnitelcomboBox.Text;
                Date = dateTimePicker1.Text;
                Id = Convert.ToInt32(IdcomboBox.Text);
                ResultsId = ResultscomboBox.SelectedIndex;
                IspolnitelId = IspolnitelcomboBox.SelectedIndex;
                MainForm.Current.Color6 = Color.LawnGreen;
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

        }

        private void SixthForm_Load(object sender, EventArgs e)
        {
            GetId();
            if (Results != null)
            {
                BosstextBox.Text = Boss;
                GoalcomboBox.Text = Goal;
                dateTimePicker1.Text = Date;
                ResultscomboBox.SelectedIndex = ResultsId;
                IspolnitelcomboBox.SelectedIndex = IspolnitelId;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
