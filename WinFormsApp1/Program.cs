namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}