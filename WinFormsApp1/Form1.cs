using System;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // добавляем пункт назначения, 4 штука
            comboBox1.Items.Add("Москва");
            comboBox1.Items.Add("Адлер");
            comboBox1.Items.Add("Томск");
            comboBox1.Items.Add("Астрахань");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedDestination = comboBox1.SelectedItem.ToString();
                Form2 form2 = new Form2(SelectedDestination); // передача выбора пассажиров
                form2.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Выберите пункт назначения!"); // предупреждение если отправка формы пустая
            }
        }
    }
}