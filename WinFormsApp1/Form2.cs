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
    public partial class Form2 : Form
    {
        private string selectedDestination;
        private string destination;
        public Form2(string selectedDestination)
        {
            InitializeComponent();
            destination = selectedDestination; // пункт назначения из 1 формы

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adults = (int)numericUpDown1.Value; // получение числа
            int children = (int)numericUpDown2.Value; // получение числа

            if(adults == 0 && children >= 1) // проверка на наличие родителя
            {
                MessageBox.Show("Ребенок не может лететь один!"); // предупреждение если выбран только ребенок
            }
            else if (adults == 0 && children == 0)
            {
                MessageBox.Show("Выберите кол-во билетов!"); // предупреждение если летит 0 человеков
            }
            else
            {
                Form3 form3 = new Form3(destination, adults, children); // переход на третью форму
                form3.Show();
                this.Hide();
            }
        }
    }
}
