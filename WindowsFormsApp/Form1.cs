using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // загрузка нашей формы
            MoveToStart();
        }

        private void MoveToStart()
        {
            Point start_point = panel1.Location; // создаем точку, кот. будет располаг-ся на нашей панели
            start_point.Offset(49, 72); // 'Offset' - сдвигает нашу точку с угла
            Cursor.Position = PointToScreen(start_point); // создаем наш курсор // 'PointScreen' - показать, куда сдвинули нашу точку
        }
        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ура! Первый уровень пройден!"); // 'MessageBox' - статич.класс
            Hide();
            Maze2 f2 = new Maze2(); // создаем новую форму
            //f2.Show(); // покажем нашу новую форму
            f2.ShowDialog();
            Close();
        }

        private void panel1_MouseEnter(object sender, EventArgs e) // возникает при вхождении указателя мыши в пределы эл-та
        {
            MoveToStart();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 141 && (e.Y < 59 || e.Y > 117))
                MoveToStart();
            else if (e.X > 777 && ((e.Y < 558 && e.Y > 478) || e.Y > 616))
                MoveToStart();
        }
    }
}
