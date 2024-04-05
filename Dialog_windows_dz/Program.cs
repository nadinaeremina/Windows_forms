using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog_windows_dz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            DialogResult res1 = MessageBox.Show("Текст сообщения", "Заголовок сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult res2 = MessageBox.Show("Текст сообщения", "Заголовок сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            DialogResult res3 = MessageBox.Show("Текст сообщения", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            DialogResult res4 = MessageBox.Show("Сообщение о программиста!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            DialogResult res5 = MessageBox.Show("Сообщение о программиста!", "Это заглавие", MessageBoxButtons.OK, MessageBoxIcon.None);
            DialogResult res6 = MessageBox.Show("Сообщение о программиста!", "Выбор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);

            if (res6 == DialogResult.Yes) { MessageBox.Show("Вы выбрали ДА"); }
            else if (res6 == DialogResult.No) { MessageBox.Show("Вы выбрали НЕТ"); }
            else if (res6 == DialogResult.Cancel) { MessageBox.Show("Вы выбрали ОТМЕНА "); }

        }
    }
}
