using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Coord_mouse(MouseEventArgs e) // координаты нашей мыши
        {
            return $" координаты мыши X= {e.X} Y= {e.Y}";
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            string mes = "";
            if (e.Button == MouseButtons.Left) mes = "Вы нажали левую клавишу мыши"; // 'MouseButtons' - перечисляемый тип у 'Buttons'
            else if (e.Button == MouseButtons.Right) mes = "Вы нажали правую клавишу мыши";
            mes += "\n" + Coord_mouse(e);
            MessageBox.Show(mes, "Click mouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = Coord_mouse(e);
        }
    }
}
