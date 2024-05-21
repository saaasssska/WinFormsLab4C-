using System.Windows.Forms;

namespace WinFormsLab4C_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button5 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button6 = new Button();
            button7 = new Button();
            comboBox1 = new ComboBox();
            label8 = new Label();
            textBox3 = new TextBox();
            button8 = new Button();
            comboBox2 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(881, 860);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 34);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(789, 826);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.Location = new Point(882, 99);
            button1.Name = "button1";
            button1.Size = new Size(261, 45);
            button1.TabIndex = 2;
            button1.Text = "Получить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += task1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.Location = new Point(881, 191);
            button2.Name = "button2";
            button2.Size = new Size(261, 45);
            button2.TabIndex = 3;
            button2.Text = "Получить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += task2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.Location = new Point(879, 445);
            button3.Name = "button3";
            button3.Size = new Size(261, 45);
            button3.TabIndex = 4;
            button3.Text = "Получить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += task3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(41, 34);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 6;
            label1.Text = "Вывод таблицы";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.Location = new Point(881, 811);
            button5.Name = "button5";
            button5.Size = new Size(261, 43);
            button5.TabIndex = 7;
            button5.Text = "Район по индексу";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(881, 68);
            label2.Name = "label2";
            label2.Size = new Size(620, 28);
            label2.TabIndex = 8;
            label2.Text = "Данные о школах заданного района, открытых ранее 1980 года";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(882, 160);
            label3.Name = "label3";
            label3.Size = new Size(529, 28);
            label3.TabIndex = 9;
            label3.Text = "Cведения о школах, номера которых заданы списком";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(879, 386);
            label4.Name = "label4";
            label4.Size = new Size(591, 28);
            label4.TabIndex = 10;
            label4.Text = "Результаты определения количества школ и среднего числа";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(882, 414);
            label5.Name = "label5";
            label5.Size = new Size(488, 28);
            label5.TabIndex = 11;
            label5.Text = "учеников на одного учителя для каждого района";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(880, 502);
            label6.Name = "label6";
            label6.Size = new Size(595, 28);
            label6.TabIndex = 12;
            label6.Text = "Замена номера телефона для произвольно заданной школы";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1164, 530);
            label7.Name = "label7";
            label7.Size = new Size(227, 28);
            label7.TabIndex = 14;
            label7.Text = "Наименование школы";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button6.Location = new Point(881, 672);
            button6.Name = "button6";
            button6.Size = new Size(261, 45);
            button6.TabIndex = 15;
            button6.Text = "districtTable";
            button6.UseVisualStyleBackColor = false;
            button6.Click += district;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button7.Location = new Point(881, 723);
            button7.Name = "button7";
            button7.Size = new Size(261, 45);
            button7.TabIndex = 16;
            button7.Text = "schoolTable";
            button7.UseVisualStyleBackColor = false;
            button7.Click += school;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1164, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(259, 36);
            comboBox1.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(880, 532);
            label8.Name = "label8";
            label8.Size = new Size(242, 28);
            label8.TabIndex = 20;
            label8.Text = "Новый номер телефона";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(880, 563);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(259, 34);
            textBox3.TabIndex = 19;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaption;
            button8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button8.Location = new Point(879, 603);
            button8.Name = "button8";
            button8.Size = new Size(261, 45);
            button8.TabIndex = 18;
            button8.Text = "Получить";
            button8.UseVisualStyleBackColor = false;
            button8.Click += task4;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1164, 561);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(259, 36);
            comboBox2.TabIndex = 21;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(1175, 191);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(246, 159);
            checkedListBox1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1532, 919);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(button8);
            Controls.Add(comboBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button6;
        private Button button7;
        private ComboBox comboBox1;
        private Label label8;
        private TextBox textBox3;
        private Button button8;
        private ComboBox comboBox2;
        private CheckedListBox checkedListBox1;
    }
}
