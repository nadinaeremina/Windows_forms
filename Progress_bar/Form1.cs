using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateColor();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 50;
            progressBar1.Step = 1;
            for (int i = 0; i <= 50; i++)
            {
                progressBar1.PerformStep(); // метод отрисовки
                label_pr_bar.Text = "Value = " + progressBar1.Value.ToString();
                Update(); // нужен для всех методов, где есть перерисовка
                Thread.Sleep(70);
            }
        }

        void UpdateColor()
        {
            Color c = Color.FromArgb(trackBar_red.Value, trackBar_green.Value, trackBar_blue.Value);
            // 'FromArgb' - метод, кот. устанавливает цвет через 'rgb'
            BackColor = c;
        }

        private void trackBar_red_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBar_green_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBar_blue_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
    }
}
