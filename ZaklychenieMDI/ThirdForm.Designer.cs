namespace ZaklychenieMDI
{
    partial class ThirdForm
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
            this.EquipmentBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EquipmentBox
            // 
            this.EquipmentBox.Location = new System.Drawing.Point(12, 143);
            this.EquipmentBox.Margin = new System.Windows.Forms.Padding(5);
            this.EquipmentBox.Name = "EquipmentBox";
            this.EquipmentBox.Size = new System.Drawing.Size(1077, 29);
            this.EquipmentBox.TabIndex = 69;
            this.EquipmentBox.TextChanged += new System.EventHandler(this.EquipmentBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 104);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 21);
            this.label16.TabIndex = 68;
            this.label16.Text = "Введите через запятую";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(14, 62);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(110, 25);
            this.checkBox6.TabIndex = 66;
            this.checkBox6.Text = "Пирометр";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(452, 62);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(124, 25);
            this.checkBox5.TabIndex = 65;
            this.checkBox5.Text = "Кульвиметр";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(245, 62);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(118, 25);
            this.checkBox4.TabIndex = 64;
            this.checkBox4.Text = "Дальномер";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(452, 14);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(125, 25);
            this.checkBox3.TabIndex = 63;
            this.checkBox3.Text = "Коррелятор";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(245, 14);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 25);
            this.checkBox2.TabIndex = 62;
            this.checkBox2.Text = "Тепловизор";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 14);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 25);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.Text = "Течеискатель";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 42);
            this.button1.TabIndex = 102;
            this.button1.Text = "Подтвердить введенные данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EquipmentBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ThirdForm";
            this.Text = "Используемое оборудование";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ThirdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EquipmentBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}