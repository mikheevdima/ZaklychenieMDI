namespace ZaklychenieMDI
{
    partial class SixthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.IspolnitelcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdcomboBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ResultscomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DoljnostcomboBox = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.L1label = new System.Windows.Forms.Label();
            this.LtextBox = new System.Windows.Forms.TextBox();
            this.L2label = new System.Windows.Forms.Label();
            this.Tk1comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tk2comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 171);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 21);
            this.label18.TabIndex = 75;
            this.label18.Text = "Выберите дату";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 29);
            this.dateTimePicker1.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 72;
            this.label4.Text = "Должность";
            // 
            // IspolnitelcomboBox
            // 
            this.IspolnitelcomboBox.FormattingEnabled = true;
            this.IspolnitelcomboBox.Items.AddRange(new object[] {
            "М.М. Клыгин",
            "И.С. Чуйко",
            "Е.В. Дробыш",
            "А.В. Виноградов",
            "П.И. Шикин",
            "С.В. Архипов"});
            this.IspolnitelcomboBox.Location = new System.Drawing.Point(35, 139);
            this.IspolnitelcomboBox.Name = "IspolnitelcomboBox";
            this.IspolnitelcomboBox.Size = new System.Drawing.Size(321, 29);
            this.IspolnitelcomboBox.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = "Испольнитель";
            // 
            // IdcomboBox
            // 
            this.IdcomboBox.Location = new System.Drawing.Point(35, 56);
            this.IdcomboBox.Name = "IdcomboBox";
            this.IdcomboBox.Size = new System.Drawing.Size(321, 29);
            this.IdcomboBox.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Номер заключения";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(34, 460);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 40);
            this.button2.TabIndex = 104;
            this.button2.Text = "Подтвердить введенные данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(34, 510);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(369, 40);
            this.button3.TabIndex = 106;
            this.button3.Text = "Сохранить данные и создать отчет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ResultscomboBox
            // 
            this.ResultscomboBox.FormattingEnabled = true;
            this.ResultscomboBox.Items.AddRange(new object[] {
            "Дефект обнаружен на подающем",
            "Дефект обнаружен на обратном",
            "Дефект обнаружен. Тип трубопровода не определен.",
            "Требуется мониторинг",
            "Необходим доступ",
            "Контрольный шурф",
            "Признаков дефекта нет"});
            this.ResultscomboBox.Location = new System.Drawing.Point(34, 301);
            this.ResultscomboBox.Name = "ResultscomboBox";
            this.ResultscomboBox.Size = new System.Drawing.Size(321, 29);
            this.ResultscomboBox.TabIndex = 108;
            this.ResultscomboBox.SelectedIndexChanged += new System.EventHandler(this.ResultscomboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 21);
            this.label5.TabIndex = 107;
            this.label5.Text = "Результаты диагностики";
            // 
            // DoljnostcomboBox
            // 
            this.DoljnostcomboBox.FormattingEnabled = true;
            this.DoljnostcomboBox.Items.AddRange(new object[] {
            "Инженер",
            "Инженер 2 категории",
            "Инженер 1 категории",
            "Ведущий инженер-технолог",
            "Начальник сектора",
            "Заместитель начальника службы диагностики",
            "Начальник службы диагностики"});
            this.DoljnostcomboBox.Location = new System.Drawing.Point(35, 247);
            this.DoljnostcomboBox.Name = "DoljnostcomboBox";
            this.DoljnostcomboBox.Size = new System.Drawing.Size(321, 29);
            this.DoljnostcomboBox.TabIndex = 109;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(464, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 91);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 25);
            this.radioButton1.TabIndex = 112;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Подающий";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(157, 91);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 25);
            this.radioButton2.TabIndex = 113;
            this.radioButton2.Text = "Обратный";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(571, 29);
            this.textBox1.TabIndex = 114;
            // 
            // L1label
            // 
            this.L1label.AutoSize = true;
            this.L1label.Location = new System.Drawing.Point(8, 31);
            this.L1label.Name = "L1label";
            this.L1label.Size = new System.Drawing.Size(129, 21);
            this.L1label.TabIndex = 115;
            this.L1label.Text = "На расстоянии";
            // 
            // LtextBox
            // 
            this.LtextBox.Location = new System.Drawing.Point(143, 28);
            this.LtextBox.Name = "LtextBox";
            this.LtextBox.Size = new System.Drawing.Size(59, 29);
            this.LtextBox.TabIndex = 116;
            // 
            // L2label
            // 
            this.L2label.AutoSize = true;
            this.L2label.Location = new System.Drawing.Point(208, 31);
            this.L2label.Name = "L2label";
            this.L2label.Size = new System.Drawing.Size(28, 21);
            this.L2label.TabIndex = 117;
            this.L2label.Text = "от";
            // 
            // Tk1comboBox
            // 
            this.Tk1comboBox.FormattingEnabled = true;
            this.Tk1comboBox.Location = new System.Drawing.Point(242, 28);
            this.Tk1comboBox.Name = "Tk1comboBox";
            this.Tk1comboBox.Size = new System.Drawing.Size(138, 29);
            this.Tk1comboBox.TabIndex = 118;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tk2comboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LtextBox);
            this.groupBox1.Controls.Add(this.Tk1comboBox);
            this.groupBox1.Controls.Add(this.L1label);
            this.groupBox1.Controls.Add(this.L2label);
            this.groupBox1.Location = new System.Drawing.Point(34, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 116);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // Tk2comboBox
            // 
            this.Tk2comboBox.FormattingEnabled = true;
            this.Tk2comboBox.Location = new System.Drawing.Point(104, 72);
            this.Tk2comboBox.Name = "Tk2comboBox";
            this.Tk2comboBox.Size = new System.Drawing.Size(138, 29);
            this.Tk2comboBox.TabIndex = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 119;
            this.label7.Text = "в сторону";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 30);
            this.button1.TabIndex = 120;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 121;
            this.label3.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 122;
            this.label6.Text = "label6";
            // 
            // SixthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DoljnostcomboBox);
            this.Controls.Add(this.ResultscomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IspolnitelcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdcomboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SixthForm";
            this.Text = "Заключение";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SixthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox IspolnitelcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ResultscomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DoljnostcomboBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label L1label;
        private System.Windows.Forms.TextBox LtextBox;
        private System.Windows.Forms.Label L2label;
        private System.Windows.Forms.ComboBox Tk1comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Tk2comboBox;
        private System.Windows.Forms.Label label7;
    }
}