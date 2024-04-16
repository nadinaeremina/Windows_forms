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
        // var 0
        public Child()
        {
            InitializeComponent();
        }

        // подходит всем вариантам
        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        //var1 // передача данных от родителя к дочерней // через кон-р дочерней формы
        //public Child(string str1)
        //{
        //    InitializeComponent();
        //    textBox1.Text = str1;
        //}

        //var2 // через доп.ф-цию и св-во дочерней формы
        //public string My_text
        //{
        //    set
        //    {
        //        textBox1.Text = value;
        //    }
        //}

        //var3 // через перегрузку ф-ции 'ShowDialog'       
        public DialogResult ShowDialog(string s)
        {
            textBox1.Text = s;
            return ShowDialog();
        }
    }
}
