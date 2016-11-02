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
            this.BosstextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GoalcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IspolnitelcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ZakluchenietextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(359, 139);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 21);
            this.label18.TabIndex = 75;
            this.label18.Text = "Выберите дату";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 29);
            this.dateTimePicker1.TabIndex = 74;
            // 
            // BosstextBox
            // 
            this.BosstextBox.Location = new System.Drawing.Point(362, 110);
            this.BosstextBox.Name = "BosstextBox";
            this.BosstextBox.Size = new System.Drawing.Size(321, 29);
            this.BosstextBox.TabIndex = 73;
            this.BosstextBox.Text = "Д.Е. Чуйко";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 72;
            this.label4.Text = "Начальник СД";
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
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 70;
            this.label3.Text = "Цель обследования";
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
            // ZakluchenietextBox
            // 
            this.ZakluchenietextBox.Location = new System.Drawing.Point(35, 56);
            this.ZakluchenietextBox.Name = "ZakluchenietextBox";
            this.ZakluchenietextBox.Size = new System.Drawing.Size(321, 29);
            this.ZakluchenietextBox.TabIndex = 67;
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
            // SixthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1843, 1195);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BosstextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GoalcomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IspolnitelcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ZakluchenietextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SixthForm";
            this.Text = "Заключение";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox BosstextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox GoalcomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IspolnitelcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ZakluchenietextBox;
        private System.Windows.Forms.Label label1;
    }
}