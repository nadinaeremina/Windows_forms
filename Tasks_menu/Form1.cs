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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void task_1_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.Show(); 
        }

        private void task_2_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
        }

        private void task_3_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3();
            task3.Show();
        }

        private void task_4_Click(object sender, EventArgs e)
        {
            Task4 task4 = new Task4();
            task4.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
