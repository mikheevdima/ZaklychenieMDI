using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ZaklychenieMDI.Conclusion;
using static ZaklychenieMDI.Analys;
using static ZaklychenieMDI.Equipment;
using static ZaklychenieMDI.Layout;
using static ZaklychenieMDI.SetParameters;
using static ZaklychenieMDI.TrumpetParameters;
using Word = Microsoft.Office.Interop.Word;

namespace ZaklychenieMDI
{
    public partial class SixthForm : Form
    {
        private readonly string TemplateFileName = @"C:\GitHub\ZaklychenieMDI\template.docx";

        public SixthForm()
        {
            InitializeComponent();
        }

        private void SaveImage()
        {
            Image file = pictureBox1.Image;
            file.Save("C:/OpenServer/picturetest123.jpeg", ImageFormat.Jpeg);
        }

        private void DeleteImage()
        {
            try
            {
                System.IO.File.Delete("C:/OpenServer/picturetest123.jpeg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "2");
            }
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
                                       "allequipment, priznaki, pomehi, stepen, analiz, primechanie, pic, goal, ispolnitel, date, results) " +
                                       "Values(@ID, @seti, @tkfrom, @tkto, @shirota, @dolgota, @d, @l, @izolyacia, @pokritie, @prokladka, " +
                                       "@allequipment, @priznaki, @pomehi, @stepen, @analiz, @primechanie, @pic, @goal, @ispolnitel, @date, @results)");
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
                }
            }
        }

        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref findText,
                        ref matchCase, ref matchWholeWord,
                        ref matchWildCards, ref matchSoundLike,
                        ref nmatchAllForms, ref forward,
                        ref wrap, ref format, ref replaceWithText,
                        ref replace, ref matchKashida,
                        ref matchDiactitics, ref matchAlefHamza,
                        ref matchControl);
        }

        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }

        private void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }
            }
        }

        private void CreateWordDocument(object filename, object savaAs)
        {
            List<int> processesbeforegen = getRunningProcesses();
            object missing = Missing.Value;

            Word.Application wordApp = new Word.Application();

            Word.Document aDoc = null;

            object readOnly = false; //default
            object isVisible = false;

            wordApp.Visible = false;
            try
            {
                aDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);

                aDoc.Activate();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            try
            {
                //Find and replace:
                FindAndReplace(wordApp, "{Id}", Id);
                FindAndReplace(wordApp, "{date}", Date);
                FindAndReplace(wordApp, "{seti}", Seti);
                FindAndReplace(wordApp, "{tk}", TkFrom + " - " + TkTo);
                FindAndReplace(wordApp, "{d}", D);
                FindAndReplace(wordApp, "{l}", L);
                FindAndReplace(wordApp, "{prokladka}", Prokladka);
                FindAndReplace(wordApp, "{izolyacia}", Izolyacia);
                FindAndReplace(wordApp, "{pokrytie}", Pokrytie);
                FindAndReplace(wordApp, "{priznaki}", Priznaki);
                FindAndReplace(wordApp, "{pomehi}", Pomehi);
                FindAndReplace(wordApp, "{stepen}", Stepen);
                FindAndReplace(wordApp, "{analiz}", Analiz);
                FindAndReplace(wordApp, "{results}", Results);
                FindAndReplace(wordApp, "{ispolnitel}", Ispolnitel);
                FindAndReplace(wordApp, "{doljnost'}", Doljnost);
                SaveImage();
                aDoc.Bookmarks.get_Item("Image").Range.InlineShapes.AddPicture("C:/OpenServer/picturetest123.jpeg");
                DeleteImage();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка сохранения" + e.Message);
            }
            //Save as: filename
            try
            {
                aDoc.SaveAs2(ref savaAs, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing);
            }
            catch
            {
                MessageBox.Show("Возможно, открыт сохраняемый файл!");
            }

            //Close Document:
            MessageBox.Show("Отчет создан!");
            //List<int> processesaftergen = getRunningProcesses();
            //killProcesses(processesbeforegen, processesaftergen);
            wordApp.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GoalcomboBox.Text != "" && ResultscomboBox.Text != "" && IspolnitelcomboBox.Text != "")
            {
                Goal = GoalcomboBox.Text;
                Results = ResultscomboBox.Text;
                Ispolnitel = IspolnitelcomboBox.Text;
                Date = dateTimePicker1.Text;
                Id = Convert.ToInt32(IdcomboBox.Text);
                ResultsId = ResultscomboBox.SelectedIndex;
                IspolnitelId = IspolnitelcomboBox.SelectedIndex;
                DoljnostId = DoljnostcomboBox.SelectedIndex;
                Doljnost = DoljnostcomboBox.Text;
                MainForm.Current.Color6 = Color.LawnGreen;
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

        }

        private void SixthForm_Load(object sender, EventArgs e)
        {
            if (ZaklychenieMDI.Layout.Pic != null)
            {
                MemoryStream ms = new MemoryStream(ZaklychenieMDI.Layout.Pic);
                pictureBox1.Image = Image.FromStream(ms);
            }
            GetId();
            if (Results != null)
            {
                GoalcomboBox.Text = Goal;
                dateTimePicker1.Text = Date;
                ResultscomboBox.SelectedIndex = ResultsId;
                IspolnitelcomboBox.SelectedIndex = IspolnitelId;
                DoljnostcomboBox.SelectedIndex = DoljnostId;
                DoljnostcomboBox.Text = Doljnost;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Save();
            string name = Seti;
            string final = name.Replace("-", "_").Replace("/", "").Replace("\"", "");
            saveFileDialog1.Filter = "Word Documents(*.docx;*.doc) | *.docx;*.doc";
            saveFileDialog1.FileName = final + " " + TkFrom + TkTo;
            saveFileDialog1.FileName = "Test";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CreateWordDocument(TemplateFileName, saveFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteImage();
        }
    }
}
