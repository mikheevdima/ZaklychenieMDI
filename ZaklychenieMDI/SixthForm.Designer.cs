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
            this.GoalcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 140);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 21);
            this.label18.TabIndex = 75;
            this.label18.Text = "Выберите дату";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 29);
            this.dateTimePicker1.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 72;
            this.label4.Text = "Должность";
            // 
            // GoalcomboBox
            // 
            this.GoalcomboBox.FormattingEnabled = true;
            this.GoalcomboBox.Location = new System.Drawing.Point(362, 56);
            this.GoalcomboBox.Name = "GoalcomboBox";
            this.GoalcomboBox.Size = new System.Drawing.Size(321, 29);
            this.GoalcomboBox.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 70;
            this.label3.Text = "delete";
            // 
            // IspolnitelcomboBox
            // 
            this.IspolnitelcomboBox.FormattingEnabled = true;
            this.IspolnitelcomboBox.Items.AddRange(new object[] {
            "Е.Н Цыцеров",
            "М.М. Клыгин",
            "В.В. Антипов",
            "И.С. Чуйко",
            "Е.В. Дробыш",
            "А.В. Виноградов",
            "П.И. Шикин",
            "С.В. Архипов"});
            this.IspolnitelcomboBox.Location = new System.Drawing.Point(35, 108);
            this.IspolnitelcomboBox.Name = "IspolnitelcomboBox";
            this.IspolnitelcomboBox.Size = new System.Drawing.Size(321, 29);
            this.IspolnitelcomboBox.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 88);
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
            this.button2.Location = new System.Drawing.Point(35, 199);
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
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(414, 199);
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
            "Дефект обнаружен",
            "Требуется мониторинг",
            "Необходим доступ",
            "Контрольный шурф",
            "Признаков дефекта нет"});
            this.ResultscomboBox.Location = new System.Drawing.Point(361, 162);
            this.ResultscomboBox.Name = "ResultscomboBox";
            this.ResultscomboBox.Size = new System.Drawing.Size(321, 29);
            this.ResultscomboBox.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 142);
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
            this.DoljnostcomboBox.Location = new System.Drawing.Point(362, 108);
            this.DoljnostcomboBox.Name = "DoljnostcomboBox";
            this.DoljnostcomboBox.Size = new System.Drawing.Size(321, 29);
            this.DoljnostcomboBox.TabIndex = 109;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(198, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 329);
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(984, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 42);
            this.button1.TabIndex = 111;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SixthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DoljnostcomboBox);
            this.Controls.Add(this.ResultscomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GoalcomboBox);
            this.Controls.Add(this.label3);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox GoalcomboBox;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Button button1;
    }
}