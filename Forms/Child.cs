using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Child : Form
    {
        //public Child()
        //{
        //    InitializeComponent();
        //}

        // передача данных от родителя к дочерней
        // все три действия происходят только при создании формы

        // 1
        //public Child(string str1)
        //{
        //    InitializeComponent();
        //    label1.Text = str1;
        //}

        //private void bt_close_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}

        // 2
        //public string My_text 
        //{ 
        //    set
        //    {
        //        label1.Text = value;
        //    }
        //}
        //public Child()
        //{
        //    InitializeComponent();
        //}

        //private void bt_close_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}

        // 3
        //public Child()
        //{
        //    InitializeComponent();
        //}
        //private void bt_close_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}
        //public DialogResult ShowDialog(string s) // перегружаем метод 'ShowDialog'
        //{
        //    label1.Text = s;
        //    return ShowDialog();
        //}
    }
}
