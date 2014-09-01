using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrayShutdownMenu
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new TrayForm();
            //Application.ApplicationExit += Application_ApplicationExit;
            Application.Run();
        }

        //static void Application_ApplicationExit(object sender, EventArgs e)
        //{
        //}

        public static TrayForm form;
    }
}
