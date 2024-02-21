using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        private string destination;
        string dateNow;
        int price = 2500; // фикс. цена на билет
        private int adults;
        private int children;
        private int sum;
        int countPass = 0; // кол-во мест

        private List<Passazhir> list = new List<Passazhir>(); // список пассажиров
        private List<Ticket> list2 = new List<Ticket>(); // список билет

        public Form3(string destination, int adults, int children)
        {
            InitializeComponent();
            Ticket ticket = new Ticket();
            this.destination = destination;
            this.adults = adults;
            this.children = children;
            int sum = adults + children; // подсчет сколько куплено мест
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Введите данные пассажира.");
            }
            else
            {
                Form4 form4 = new Form4(list, list2, sum); // переход на четвертую форму
                form4.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem != null)
                {
                    int selectedIndex = listBox1.SelectedIndex;

                    // поле для редактирования 
                    textBox1.Text = listBox1.SelectedItem.ToString();
                    textBox1.Visible = true;
                    textBox1.Focus();

                    // обработчик события завершения редактирования 
                    textBox1.TextChanged += (s, args) =>
                    {
                        listBox1.Items[selectedIndex] = textBox1.Text; // обновление значений
                    };

                    // обработчик события потери фокуса (завершение редактирования)
                    textBox1.LostFocus += (s, args) =>
                    {
                        textBox1.Visible = false; // скрытие бокса после редактирования
                    };
                }
                else
                {
                    MessageBox.Show("Выберите элемент для редактирования."); // предупреждение если редактируется ничего
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dateNow = Convert.ToString(DateTime.Now); // сегодняшняя дата
                Passazhir pass = new Passazhir(textBox1.Text, textBox2.Text, dateTimePicker1.Value, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                list.Add(pass); // добавление класса в список

                // блок получения данных
                string Fio = pass.fio = Convert.ToString(textBox1.Text);
                string Name = pass.name = textBox2.Text;
                DateTime date = pass.datarozhdeniya = dateTimePicker1.Value;
                int seriya = pass.seriya = Convert.ToInt32(textBox3.Text);
                int nomer = pass.nomer = Convert.ToInt32(textBox4.Text);

                DateTime datN = DateTime.Parse("2021-10-05"); // дети до 2-х лет
                DateTime datS = DateTime.Parse("2011-10-05"); // дети до 12-ти лет

                // блок расчета стоимости билета исходя из возраста
                if (date > datN) { price = 0; } // бесплатно до 2-х лет
                else if (date < datS) { price = price / 2; } // полцены до 12-ти лет
                else { price = 2500; } // полная цена

                sum = adults + children;
                Ticket();
                // вывод на форму данных о пассажире
                listBox1.Items.Add($"Фамилия: {list[countPass].Fio()} Имя: {list[countPass].Name()} Дата рождения: {list[countPass].data()} Данные паспорта: Серия: {list[countPass].ser()} Номер: {list[countPass].nom()}");

                if (listBox1.Items.Count == sum)
                {
                    button1.Enabled = false; // блокировка кнопки после достижения кол-ва выбранных пассажиров
                    button3.Enabled = true; // разблокировка после ввода всех пассажиров
                }
                if (listBox1.Items.Count > sum)
                {
                    button3.Enabled = false; // блокировка кнопки до момента как будут введены все человеки
                }
                // очистка боксов после добавления пассажиров
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
            catch
            {
                MessageBox.Show("Данные введены неправильно!");
            }
        }

        private void Ticket()
        {
            // передача данных на четвертую форму
            Ticket ticket = new Ticket(textBox1.Text + textBox2.Text, "Пермь", destination, price, dateNow);
            list2.Add(ticket);
        }
    }
}
