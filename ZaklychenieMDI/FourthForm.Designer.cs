namespace ZaklychenieMDI
{
    partial class FourthForm
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
            this.PomehicomboBox = new System.Windows.Forms.ComboBox();
            this.StepencomboBox = new System.Windows.Forms.ComboBox();
            this.PriznakicomboBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.AnalizcomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PrimechanietextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PomehicomboBox
            // 
            this.PomehicomboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PomehicomboBox.FormattingEnabled = true;
            this.PomehicomboBox.Items.AddRange(new object[] {
            "Неблагоприятные погодные условия (дождь/ветер/снег)",
            "Отсутствие доступа к объекту контроля",
            "Выход из строя диагностического оборудования",
            "Отсутствие точной информации о расположении объекта контроля",
            "Интенсивное движение транспортных средств в момент контроля",
            "Отсутствуют"});
            this.PomehicomboBox.Location = new System.Drawing.Point(24, 101);
            this.PomehicomboBox.Margin = new System.Windows.Forms.Padding(5);
            this.PomehicomboBox.Name = "PomehicomboBox";
            this.PomehicomboBox.Size = new System.Drawing.Size(902, 29);
            this.PomehicomboBox.TabIndex = 97;
            this.PomehicomboBox.SelectedIndexChanged += new System.EventHandler(this.PomehicomboBox_SelectedIndexChanged);
            // 
            // StepencomboBox
            // 
            this.StepencomboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepencomboBox.FormattingEnabled = true;
            this.StepencomboBox.Items.AddRange(new object[] {
            "Класс <<А>> Критический дефект, требует немедленного устранения",
            "Класс <<В>> Значительный дефект, требующий ремонта при первой возможности",
            "Класс <<С>> Малозначительный дефект, требующий контроля и ремонта в плановый пери" +
                "од"});
            this.StepencomboBox.Location = new System.Drawing.Point(24, 161);
            this.StepencomboBox.Margin = new System.Windows.Forms.Padding(5);
            this.StepencomboBox.Name = "StepencomboBox";
            this.StepencomboBox.Size = new System.Drawing.Size(902, 29);
            this.StepencomboBox.TabIndex = 96;
            this.StepencomboBox.SelectedIndexChanged += new System.EventHandler(this.StepencomboBox_SelectedIndexChanged);
            // 
            // PriznakicomboBox
            // 
            this.PriznakicomboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriznakicomboBox.FormattingEnabled = true;
            this.PriznakicomboBox.Items.AddRange(new object[] {
            "Поступление горячей воды в дренажные колодцы/канализацию/телефонные колодцы и т.д" +
                ".",
            "Провал поверхностного слоя над теплотрассой",
            "Парение ливнёвых колодцев и сопутствующих коммуникаций",
            "Акустический шум на подающем трубопроводе/вибрация",
            "Акустический шум на обратном трубопроводе/вибрация",
            "Температурная аномалия над теплотрассой",
            "Затоплено оборудование под горловину горячей водой",
            "Поступление теплоносителя через простенок",
            "Поступление теплоносителя через сальники запорной арматуры",
            "Поступление теплоносителя по дренажной трубе",
            "Падение давления по манометру на участке теплотрассы",
            "Повышенный расход теплоносителя на участке теплотрассы",
            "Признаки повреждения теплотрассы на момент обследования на данном участке не обна" +
                "ружены"});
            this.PriznakicomboBox.Location = new System.Drawing.Point(24, 41);
            this.PriznakicomboBox.Margin = new System.Windows.Forms.Padding(5);
            this.PriznakicomboBox.Name = "PriznakicomboBox";
            this.PriznakicomboBox.Size = new System.Drawing.Size(902, 29);
            this.PriznakicomboBox.TabIndex = 95;
            this.PriznakicomboBox.SelectedIndexChanged += new System.EventHandler(this.PriznakicomboBox_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(20, 195);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(490, 21);
            this.label20.TabIndex = 92;
            this.label20.Text = "Вероятность обнаружения повреждения в указанном месте";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(20, 135);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(165, 21);
            this.label21.TabIndex = 90;
            this.label21.Text = "Степень опасности";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(20, 15);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(200, 21);
            this.label19.TabIndex = 88;
            this.label19.Text = "Признаки повреждения";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(20, 75);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 21);
            this.label17.TabIndex = 86;
            this.label17.Text = "Помехофакторы";
            // 
            // AnalizcomboBox
            // 
            this.AnalizcomboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalizcomboBox.FormattingEnabled = true;
            this.AnalizcomboBox.Items.AddRange(new object[] {
            "Достоверная (80%-99%)",
            "Позитивная (60%-80%)",
            "Негативная (30%-60%)"});
            this.AnalizcomboBox.Location = new System.Drawing.Point(24, 221);
            this.AnalizcomboBox.Margin = new System.Windows.Forms.Padding(5);
            this.AnalizcomboBox.Name = "AnalizcomboBox";
            this.AnalizcomboBox.Size = new System.Drawing.Size(902, 29);
            this.AnalizcomboBox.TabIndex = 98;
            this.AnalizcomboBox.SelectedIndexChanged += new System.EventHandler(this.AnalizcomboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(27, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 40);
            this.button1.TabIndex = 102;
            this.button1.Text = "Подтвердить введенные данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrimechanietextBox
            // 
            this.PrimechanietextBox.Location = new System.Drawing.Point(27, 279);
            this.PrimechanietextBox.MaxLength = 255;
            this.PrimechanietextBox.Multiline = true;
            this.PrimechanietextBox.Name = "PrimechanietextBox";
            this.PrimechanietextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrimechanietextBox.Size = new System.Drawing.Size(902, 106);
            this.PrimechanietextBox.TabIndex = 104;
            this.PrimechanietextBox.TextChanged += new System.EventHandler(this.PrimechanietextBox_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 255);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 21);
            this.label22.TabIndex = 103;
            this.label22.Text = "Примечание";
            // 
            // FourthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.PrimechanietextBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnalizcomboBox);
            this.Controls.Add(this.PomehicomboBox);
            this.Controls.Add(this.StepencomboBox);
            this.Controls.Add(this.PriznakicomboBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FourthForm";
            this.Text = "Аналитика";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FourthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PomehicomboBox;
        private System.Windows.Forms.ComboBox StepencomboBox;
        private System.Windows.Forms.ComboBox PriznakicomboBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox AnalizcomboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PrimechanietextBox;
        private System.Windows.Forms.Label label22;
    }
}