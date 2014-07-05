using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TimeManeger_v0._001
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            f_Main Main_form = new f_Main();
            Application.Run(Main_form);
        }
    }
}
