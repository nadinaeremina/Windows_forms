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
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; // что произойдет, когда нажмем на кнопку 'OK' ('DialogResult' - это св-во)
        }
        
        public string My_text
        {
            get
            {
                return textBox1.Text; // для того, чтобы нам достать текст
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
