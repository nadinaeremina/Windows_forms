﻿using System;
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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void launch_Click(object sender, EventArgs e)
        {
            Ancetacs anceta = new Ancetacs();
            anceta.ShowDialog();
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

        private void exit_to_menu_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void task_4_Click(object sender, EventArgs e)
        {
            Task4 task3 = new Task4();
            task3.ShowDialog();
        }
    }
}
