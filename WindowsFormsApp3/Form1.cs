using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] colors = { "розовый", "белый", "голубой" }; // наполнить 'ListBox' можно здесь, а можно с пом.формы (Items)
            lb_color.Items.AddRange(colors); // 'Add' ( 1 эл-т), 'AddRange' (список эл-ов), 'Insert'(в конкретное место)
            // delete - Remove(value), RemoveAt(index)
            cb_1.DropDownStyle = ComboBoxStyle.Simple; // 'ComboBoxStyle' - enum (перечисляемые типы)
        }

        private void lb_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = lb_color.SelectedItem.ToString(); // работаем с выбранным Item
            string str = lb_color.SelectedItem.ToString();
            MessageBox.Show(str);
        }

        private void cb_sh_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_sh.Checked==true)
                MessageBox.Show($"Флажок {cb_sh.Text} отмечен");
        }
    }
}
