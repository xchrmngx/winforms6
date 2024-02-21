namespace WinFormsApp1
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Фамилия:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Имя:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 2;
            label3.Text = "Дата рождения:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Паспорт";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 129);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Серия:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 129);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Номер";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 187);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 6;
            label7.Text = "Данные пассажиров:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 162);
            label8.Name = "label8";
            label8.Size = new Size(371, 15);
            label8.TabIndex = 7;
            label8.Text = "У детей младше 14 лет, в графе серия и номер, указывается 0!";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 221);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(557, 109);
            listBox1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(111, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(144, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(83, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(253, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(97, 23);
            textBox4.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(12, 344);
            button1.Name = "button1";
            button1.Size = new Size(123, 43);
            button1.TabIndex = 14;
            button1.Text = "Добавить пассажира";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 348);
            button2.Name = "button2";
            button2.Size = new Size(123, 43);
            button2.TabIndex = 15;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(446, 344);
            button3.Name = "button3";
            button3.Size = new Size(123, 43);
            button3.TabIndex = 16;
            button3.Text = "Далее";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 255, 255);
            ClientSize = new Size(615, 403);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}