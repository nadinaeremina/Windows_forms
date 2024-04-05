using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 'Application' - главный класс управления нашим проектом
            // в нем описаны все методы и св-ва для запуска проета
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles(); 
            Application.Run(new Form1());
        }
    }
}
