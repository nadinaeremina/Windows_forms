using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle
{
    public partial class forma : Form
    {
        public forma()
        {
            InitializeComponent();
        }

        private string Coord_mouse(MouseEventArgs e, int x = 0, int y = 0) // координаты нашей мыши
        {
            return $" координаты мыши X= {e.X + x} Y= {e.Y + y}";
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = Coord_mouse(e);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = Coord_mouse(e, label1.Location.X, label1.Location.Y);
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Control.ModifierKeys == Keys.Control)
                    Hide();
                else
                {
                    if (e.X < label1.Location.X || e.Y < label1.Location.Y || e.X > label1.Location.X + label1.Width || e.Y > label1.Location.Y + label1.Height)
                        MessageBox.Show("Вы находитесь снаружи прямоугольника");
                    else if ((e.Y > label1.Location.Y && e.Y < label1.Location.Y + label1.Height) && (e.X == label1.Location.X || e.X == label1.Location.X + label1.Width))
                        MessageBox.Show("Вы находитесь на границе прямоугольника");
                    else if ((e.X > label1.Location.X && e.X < label1.Location.X + label1.Width) && (e.Y == label1.Location.Y || e.Y == label1.Location.Y + label1.Height))
                        MessageBox.Show("Вы находитесь на границе прямоугольника");
                    else if ((e.X > label1.Location.X && e.X < label1.Location.X + label1.Width) && (e.Y > label1.Location.Y && e.Y < label1.Location.Y + label1.Height))
                        MessageBox.Show("Вы находитесь внутри прямоугольника");
                }
                
            }
            else if (e.Button == MouseButtons.Right)
                MessageBox.Show($"Высота: {panel1.Height} Ширина: {panel1.Width}");
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Control.ModifierKeys == Keys.Control)
                    Hide();
                else
                {
                    if (e.X < label1.Location.X || e.Y < label1.Location.Y || e.X > label1.Location.X + label1.Width || e.Y > label1.Location.Y + label1.Height)
                        MessageBox.Show("Вы находитесь снаружи прямоугодьника");
                    else if ((e.Y > label1.Location.Y && e.Y < label1.Location.Y + label1.Height) && (e.X == label1.Location.X || e.X == label1.Location.X + label1.Width))
                        MessageBox.Show("Вы находитесь на границе прямоугодьника");
                    else if ((e.X > label1.Location.X && e.X < label1.Location.X + label1.Width) && (e.Y == label1.Location.Y || e.Y == label1.Location.Y + label1.Height))
                        MessageBox.Show("Вы находитесь на границе прямоугодьника");
                    else if ((e.X > label1.Location.X && e.X < label1.Location.X + label1.Width) && (e.Y > label1.Location.Y && e.Y < label1.Location.Y + label1.Height))
                        MessageBox.Show("Вы находитесь внутри прямоугодьника");
                }
            }
            else if (e.Button == MouseButtons.Right)
                MessageBox.Show($"Высота: {panel1.Height} Ширина: {panel1.Width}");
        }
    }
}

