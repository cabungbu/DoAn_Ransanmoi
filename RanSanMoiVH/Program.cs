using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RanSanMoi
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
            //Application.Run(new FormMuc());
            Application.Run(new Sign());
            //Application.Run(new Table_NguoiChoi());
        }
    }
}
