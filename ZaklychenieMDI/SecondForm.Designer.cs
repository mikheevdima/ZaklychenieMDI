namespace ZaklychenieMDI
{
    partial class SecondForm
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
            this.TipProkladkicomboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PoktiriecomboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TipIzolyaciicomboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LtextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DtextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TipProkladkicomboBox
            // 
            this.TipProkladkicomboBox.FormattingEnabled = true;
            this.TipProkladkicomboBox.Items.AddRange(new object[] {
            "Бесканальные",
            "Канальные",
            "В футляре",
            "Наземные",
            "Канал/бесканал"});
            this.TipProkladkicomboBox.Location = new System.Drawing.Point(51, 255);
            this.TipProkladkicomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TipProkladkicomboBox.Name = "TipProkladkicomboBox";
            this.TipProkladkicomboBox.Size = new System.Drawing.Size(1075, 29);
            this.TipProkladkicomboBox.TabIndex = 61;
            this.TipProkladkicomboBox.SelectedIndexChanged += new System.EventHandler(this.TipProkladkicomboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 217);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 21);
            this.label15.TabIndex = 60;
            this.label15.Text = "Тип прокладки";
            // 
            // PoktiriecomboBox
            // 
            this.PoktiriecomboBox.FormattingEnabled = true;
            this.PoktiriecomboBox.Location = new System.Drawing.Point(596, 168);
            this.PoktiriecomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PoktiriecomboBox.Name = "PoktiriecomboBox";
            this.PoktiriecomboBox.Size = new System.Drawing.Size(533, 29);
            this.PoktiriecomboBox.TabIndex = 59;
            this.PoktiriecomboBox.SelectedIndexChanged += new System.EventHandler(this.PoktiriecomboBox_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(589, 130);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 21);
            this.label14.TabIndex = 58;
            this.label14.Text = "Покрытие трассы";
            // 
            // TipIzolyaciicomboBox
            // 
            this.TipIzolyaciicomboBox.FormattingEnabled = true;
            this.TipIzolyaciicomboBox.Location = new System.Drawing.Point(51, 168);
            this.TipIzolyaciicomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TipIzolyaciicomboBox.Name = "TipIzolyaciicomboBox";
            this.TipIzolyaciicomboBox.Size = new System.Drawing.Size(533, 29);
            this.TipIzolyaciicomboBox.TabIndex = 57;
            this.TipIzolyaciicomboBox.SelectedIndexChanged += new System.EventHandler(this.TipIzolyaciicomboBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 130);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 21);
            this.label13.TabIndex = 56;
            this.label13.Text = "Тип изоляции";
            // 
            // LtextBox
            // 
            this.LtextBox.Location = new System.Drawing.Point(596, 84);
            this.LtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LtextBox.Name = "LtextBox";
            this.LtextBox.Size = new System.Drawing.Size(533, 29);
            this.LtextBox.TabIndex = 55;
            this.LtextBox.TextChanged += new System.EventHandler(this.LtextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(589, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 21);
            this.label12.TabIndex = 54;
            this.label12.Text = "Длина участка";
            // 
            // DtextBox
            // 
            this.DtextBox.Location = new System.Drawing.Point(51, 84);
            this.DtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtextBox.Name = "DtextBox";
            this.DtextBox.Size = new System.Drawing.Size(533, 29);
            this.DtextBox.TabIndex = 53;
            this.DtextBox.TextChanged += new System.EventHandler(this.DtextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 21);
            this.label11.TabIndex = 52;
            this.label11.Text = "Диаметр трубопровода";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 42);
            this.button1.TabIndex = 101;
            this.button1.Text = "Подтвердить введенные данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TipProkladkicomboBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PoktiriecomboBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TipIzolyaciicomboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LtextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DtextBox);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SecondForm";
            this.Text = "Параметры трубопровода";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SecondForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TipProkladkicomboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox PoktiriecomboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox TipIzolyaciicomboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox LtextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DtextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}