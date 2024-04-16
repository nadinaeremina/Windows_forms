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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        public Add(string text1, string text2, string text3)
        {
            InitializeComponent();
            textBox_name.Text = text1;
            textBox_producer.Text = text2;
            textBox_price.Value = Convert.ToDecimal(text3);
        }

        public string Producer
        {
            get
            {
                return textBox_producer.Text;
            }
        }
        public string Name
        {
            get
            {
                return textBox_name.Text + '/';
            }
        }
        public string Price
        {
            get
            {
                return textBox_price.Text;
            }
        }

        private void button_cancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_ok_Click_1(object sender, EventArgs e)
        {
            if (textBox_name.Text.Length > 0 && textBox_producer.Text.Length > 0 && textBox_price.Value != 0)
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Сначала заполните все поля!");
        }
    }
}
