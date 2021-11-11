using CRUDRentACar.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDRentACar
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormStatus());
            Application.Run(new LoginForm());
            //Application.Run(new Register());
            //Application.Run(new LoginUserRole());
            //Application.Run(new Menu());
        }
    }
    
}
