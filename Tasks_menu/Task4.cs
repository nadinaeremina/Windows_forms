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
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void task_1_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.ShowDialog();
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

        private void launch_Click(object sender, EventArgs e)
        {
            Tovars tovars = new Tovars();
            tovars.ShowDialog();
        }

        private void exit_to_menu_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
