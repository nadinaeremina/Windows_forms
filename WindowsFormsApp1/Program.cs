using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            // это можно закомментировать, тк мы будем работать с диалоговыми окнами (окна сообщений), а не с формой

            // 'MessageBox' - возвращает 'DialogResult'
            // 1) текст сообщения 2) текст заголовка 3) 'MessageBoxButtons' - текст кнопочки (Продолжить, прервать, Ок и тд) 4) 'MessageBoxIcon' - иконка

            // 1
            //DialogResult res = MessageBox.Show("Произошла ошибка загрузки", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

            //if (res == DialogResult.Abort) { MessageBox.Show("Вы нажали кнопку ПРЕРВАТЬ"); }
            //else if (res == DialogResult.Retry) { MessageBox.Show("Вы нажали кнопку ПОВТОРИТЬ"); }
            //else if (res == DialogResult.Ignore) { MessageBox.Show("Вы нажали кнопку ПРОПУСТИТЬ "); }

            //2 
            DialogResult res_1;
            do
            {
                res_1 = Show_mes_my();
            } while (res_1 != DialogResult.Abort);
        }

        static DialogResult Show_mes_my()
        {
            string _text = "Окно с текстовым сообщением";
            MessageBox.Show(_text);
            _text = "Окно с двумя кнопками OK and CANCEL";
            string _caption = "Окна";
            DialogResult res = MessageBox.Show(_text, _caption, MessageBoxButtons.OKCancel);
            string bt = res.ToString();

            res = MessageBox.Show($"Вы нажали кнопку {bt}. Повторить?", bt, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
            return res;
        }
    }
}
