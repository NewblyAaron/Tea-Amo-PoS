using System;
using System.Windows.Forms;

namespace TeaAmoWFA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using LoginForm login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                login.Dispose();
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}