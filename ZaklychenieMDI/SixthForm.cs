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
using Type = System.Type;
using Word = Microsoft.Office.Interop.Word;

namespace ZaklychenieMDI
{
    public partial class SixthForm : Form
    {
        private readonly string TemplateFileName = @"C:\Users\Теплосеть\Documents\Blanks\template.docx";

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
            string sql = string.Format("Insert Into Parameters(ID, seti, area, line, tkfrom, tkto, shirota, dolgota, d, l, izolyacia, pokritie, prokladka, " +
                                       "allequipment, priznaki, pomehi, stepen, analiz, primechanie, pic, ispolnitel, doljnost, date, year, month, results, ldef) " +
                                       "Values(@ID, @seti, @area, @line, @tkfrom, @tkto, @shirota, @dolgota, @d, @l, @izolyacia, @pokritie, @prokladka, " +
                                       "@allequipment, @priznaki, @pomehi, @stepen, @analiz, @primechanie, @pic, @ispolnitel, @doljnost, @date, @year, @month, @results, @ldef)");
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@ID", Conclusion.Id);
                cmd.Parameters.AddWithValue("@seti", SetParameters.Seti);
                cmd.Parameters.AddWithValue("@area", SetParameters.AreaOfficial);
                cmd.Parameters.AddWithValue("@line", SetParameters.Line);
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
                cmd.Parameters.AddWithValue("@ispolnitel", Conclusion.Ispolnitel);
                cmd.Parameters.AddWithValue("@doljnost", Conclusion.Doljnost);
                cmd.Parameters.AddWithValue("@date", Conclusion.Date);
                cmd.Parameters.AddWithValue("@year", Conclusion.Date);
                cmd.Parameters.AddWithValue("@month", Conclusion.Date);
                cmd.Parameters.AddWithValue("@results", Conclusion.Results);
                cmd.Parameters.AddWithValue("@ldef", Conclusion.LDef);
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
                if (ZaklychenieMDI.Conclusion.Type == "Подающий")
                {
                    FindAndReplace(wordApp, "{type1}", "V");
                    FindAndReplace(wordApp, "{type2}", "");
                }
                else
                {
                    FindAndReplace(wordApp, "{type2}", "V");
                    FindAndReplace(wordApp, "{type1}", "");
                }

                FindAndReplace(wordApp, "{Id}", Id);
                FindAndReplace(wordApp, "{date}", Date);
                FindAndReplace(wordApp, "{area}", AreaOfficial);
                FindAndReplace(wordApp, "{seti}", Seti);
                FindAndReplace(wordApp, "{line}", ", " + Line);
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
                FindAndReplace(wordApp, "{L}", LDef);
                FindAndReplace(wordApp, "{ispolnitel}", Ispolnitel);
                FindAndReplace(wordApp, "{doljnost'}", Doljnost);
                //SaveImage();
                aDoc.Bookmarks.get_Item("Image").Range.InlineShapes.AddPicture(textBox1.Text);
                //DeleteImage();
                MessageBox.Show("Отчет создан!");
                wordApp.Visible = true;
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

            //List<int> processesaftergen = getRunningProcesses();
            //killProcesses(processesbeforegen, processesaftergen);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DoljnostcomboBox.Text != "" && ResultscomboBox.Text != "" && IspolnitelcomboBox.Text != "")
            {
                button3.Enabled = true;
                if (ResultscomboBox.SelectedIndex == 0 || ResultscomboBox.SelectedIndex == 1)
                {
                    LDef = " на расстоянии " + LtextBox.Text + " м от " + Tk1comboBox.Text + " в сторону " + Tk2comboBox.Text;
                }
                else
                {
                    LDef = "";
                }
                textBox1.Text = ZaklychenieMDI.Layout.Path;
                Rectangle r = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
                Bitmap b = new Bitmap(r.Width, r.Height);
                Graphics g = Graphics.FromImage(b);
                g.CopyFromScreen(r.Location, new Point(0, 0), r.Size);
                MemoryStream ms = new MemoryStream();
                b.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                ZaklychenieMDI.Layout.Pic = ms.ToArray();


                Results = ResultscomboBox.Text;
                Ispolnitel = IspolnitelcomboBox.Text;
                Date = dateTimePicker1.Text;
                Year = dateTimePicker1.Value.Year.ToString();
                Month = dateTimePicker1.Value.Month.ToString();
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
            ZaklychenieMDI.Conclusion.Type = "Подающий";
            if (ZaklychenieMDI.Layout.Pic != null)
            {
                //MemoryStream ms = new MemoryStream(ZaklychenieMDI.Layout.Pic);
                //pictureBox1.Image = Image.FromStream(ms);

            }
            //Bitmap image = new Bitmap(ZaklychenieMDI.Layout.Path);
            pictureBox1.ImageLocation = ZaklychenieMDI.Layout.Path;
            GetId();
            if (Results != null)
            {
                dateTimePicker1.Text = Date;
                ResultscomboBox.SelectedIndex = ResultsId;
                IspolnitelcomboBox.SelectedIndex = IspolnitelId;
                DoljnostcomboBox.SelectedIndex = DoljnostId;
                DoljnostcomboBox.Text = Doljnost;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if ()
            Save();
            string name = Seti + Line + TkFrom + TkTo;
            string final = name.Replace("-", "_").Replace("/", "").Replace("\"", "");
            saveFileDialog1.Filter = "Word Documents(*.docx;*.doc) | *.docx;*.doc";
            saveFileDialog1.FileName = final;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CreateWordDocument(TemplateFileName, saveFileDialog1.FileName);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ZaklychenieMDI.Conclusion.Type = "Подающий";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ZaklychenieMDI.Conclusion.Type = "Обратный";
        }

        private void ResultscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResultscomboBox.SelectedIndex == 0 || ResultscomboBox.SelectedIndex == 1)
            {
                groupBox1.Visible = true;
                List<string> cameras = new List<string>();
                List<string> cameras2 = new List<string>();
                cameras.Add(TkFrom);
                cameras.Add(TkTo);
                cameras2.Add(TkFrom);
                cameras2.Add(TkTo);
                Tk1comboBox.DataSource = cameras;
                Tk2comboBox.DataSource = cameras2;
            }
            else
            {
                groupBox1.Visible = false;
                Tk1comboBox.Items.Clear();
                LDef = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker1.Value.Month.ToString();
            label6.Text = dateTimePicker1.Value.Year.ToString();
        }
    }
}
