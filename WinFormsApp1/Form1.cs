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
            // ��������� ����� ����������, 4 �����
            comboBox1.Items.Add("������");
            comboBox1.Items.Add("�����");
            comboBox1.Items.Add("�����");
            comboBox1.Items.Add("���������");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedDestination = comboBox1.SelectedItem.ToString();
                Form2 form2 = new Form2(SelectedDestination); // �������� ������ ����������
                form2.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("�������� ����� ����������!"); // �������������� ���� �������� ����� ������
            }
        }
    }
}