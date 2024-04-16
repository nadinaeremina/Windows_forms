using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks_menu
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
            button_stop.Enabled = false; // св-ва в коде в приоритете (переопределение)
            timer1.Tick += new EventHandler(Work_timer);
            timer2.Tick += new EventHandler(Show_timer);
            timer2.Interval = 950;
        }

        private void Show_timer(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            numericUpDown1.Value = --count;
        }

        private void Work_timer(object sender, EventArgs e)
        {
            timer1.Stop(); // сначала отключаем предыдущий таймер, вдруг он работал
            button_stop.Enabled = false;
            timer2.Stop();
            MessageBox.Show("Таймер сработал");
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Ошибка выбора времени");
                return; // выйти
            }
            else
            {
                button_stop.Enabled = true;
                timer1.Interval = Convert.ToInt32(numericUpDown1.Value) * 1000;
                timer1.Start();
                timer2.Start();
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            button_stop.Enabled = false;
            MessageBox.Show($"Таймер не успел отработать выбранное время. Осталось: {numericUpDown1.Value} секунд");
        }
    }
}
