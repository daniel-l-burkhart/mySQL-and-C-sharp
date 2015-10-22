using System;
using System.Windows.Forms;

namespace CS3230_Homework_4
{
    internal static class Driver
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CS3230Homework4());
        }
    }
}