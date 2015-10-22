using System;
using System.Windows.Forms;
using CS3230_Homework_4.View;

namespace CS3230_Homework_4.Controller
{
    internal static class Driver
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        // ReSharper disable once InconsistentNaming
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Cs3230Homework4());
        }
    }
}