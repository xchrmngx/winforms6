namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения
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