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
    public partial class Form4 : Form
    {
        private int count = 0; // подсчет стоимости билетов 
        public Form4(List<Passazhir> list, List<Ticket> list2, int sum) // взятие данных с прошлой формы
        {
            InitializeComponent();
            for (int i = 0; i < sum; i++)
            {
                listBox1.Items.Add($"Данные пассажира: ");
                // вывод данных пассажира
                string NewLine = ($"Фамилия: {list[i].Fio()} Имя: {list[i].Name()} Дата рождения: {list[i].data()}  Паспорт: Серия: {list[i].ser()} Номер: {list[i].nom()} ");
                listBox1.Items.Add(NewLine);
                listBox1.Items.Add($"Билет пассажира: ");
                // вывод билета пассажира
                listBox1.Items.Add($"ФИО: {list2[i].pas()}  Пункт вылета: {list2[i].Wherefrom()}  Пункт назначения: {list2[i].whereto()}  Цена: {list2[i].Price()}₽  Дата покупки: {list2[i].Date()} ");
                listBox1.Items.Add("");

                count = list2[i].Price() + count; // подсчет стоимости
            }
            label1.Text = $"Итого {count}₽"; // итоговая цена 
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
