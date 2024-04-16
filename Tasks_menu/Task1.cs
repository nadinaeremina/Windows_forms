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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void launch_Click(object sender, EventArgs e)
        {
            Mouse mouse = new Mouse();
            mouse.ShowDialog();
        }

        private void exit_to_menu_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void task_2_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.ShowDialog();
        }

        private void task_3_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3();
            task3.ShowDialog();
        }

        private void task_4_Click(object sender, EventArgs e)
        {
            Task4 task4 = new Task4();
            task4.ShowDialog();
        }
    }
}
