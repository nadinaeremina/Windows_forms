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
    public partial class Maze2 : Form
    {
        public Maze2()
        {
            InitializeComponent(); 
            MoveToStart();
        }
        private void MoveToStart()
        {
            Point start_point = panel1.Location; 
            start_point.Offset(66, 538); 
            Cursor.Position = PointToScreen(start_point); 
        }

        private void panel1_MouseEnter_1(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label_finish_MouseEnter_1(object sender, EventArgs e)
        {
            MessageBox.Show("Победа!!!"); 
            Close();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
           MoveToStart();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X < 41) || (e.Y < 509 && e.X < 99) || (e.X > 114 && e.Y > 566 && e.Y < 577))
                MoveToStart();
        }
    }
}
