using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tovars
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex); // удаляем по индексу (выбранный элемент)
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            if (child.ShowDialog() == DialogResult.OK)
                listBox1.Items.Add(child.My_text);
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
