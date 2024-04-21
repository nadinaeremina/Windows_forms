using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : Form
    {
        SolidBrush mybrush;
        Graphics my_g;
        Bitmap map = null;

        List<My_point> my_point = new List<My_point>();
        List<My_line> my_line = new List<My_line>();
        List<MyFigure> my_circle = new List<MyFigure>();
        List<MyFigure> my_rectangle = new List<MyFigure>();
        
        ArrayList assorted = new ArrayList();

        int X = 0, Y = 0, X1 = 0, Y1 = 0;
        bool isDrawing;
        bool pencil = false;
        bool line = false;
        bool circle = false;
        bool rectangle = false;
        bool erase = false;
        bool filling = false;
        string circle_str = "circle";
        string rect_str = "rectangle";

        public Paint()
        {
            InitializeComponent();
            map = new Bitmap(panel_draw.Width, panel_draw.Height); // создаем 'Bitmap'
            my_g = Graphics.FromImage(map); // инициализируем наш 'Graphics'
        }

        // изменение цвета
        private void panel_color_DoubleClick(object sender, EventArgs e)
        {
            filling = false;
            if (colorDialog1.ShowDialog() == DialogResult.OK) // когда выбрали цвет
            {
                panel_color.BackColor = colorDialog1.Color;
                mybrush.Color = colorDialog1.Color; // навешиваем на мышку событие
            }
        }

        // при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            mybrush = new SolidBrush(panel_color.BackColor);
            my_g = panel_draw.CreateGraphics(); // определяем область для рисования нашего обьекта графики (panel_draw)
        }

        // нажатие мышки
        private void panel_draw_MouseDown_1(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            erase = false;
            if (line || circle || rectangle)
            {
                X = e.X;
                Y = e.Y;
            }
        }

        // держим мышку
        private void panel_draw_MouseMove_1(object sender, MouseEventArgs e)
        {
            mybrush.Color = panel_color.BackColor;
            if (isDrawing)
            {
                if (pencil)
                {
                    filling = false;
                    my_point.Add(new My_point(new Point(e.X, e.Y), mybrush.Color, trackBar1.Value));
                    assorted.Add(new My_point(new Point(e.X, e.Y), mybrush.Color, trackBar1.Value));
                    my_g.FillEllipse(mybrush, new Rectangle(e.X, e.Y, trackBar1.Value, trackBar1.Value));
                }
                else if (line || circle || rectangle)
                {
                    X1 = e.X;
                    Y1 = e.Y;
                    panel_draw.Invalidate();
                }
            }
        }

        // отпустили
        private void panel_draw_MouseUp_1(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            mybrush.Color = colorDialog1.Color;
            if (line)
            {
                my_line.Add(new My_line(new Point(X, Y), new Point(X1, Y1), mybrush.Color, trackBar1.Value));
                assorted.Add(new My_line(new Point(X, Y), new Point(X1, Y1), mybrush.Color, trackBar1.Value));
            }
            else if (circle)
            {
                if (filling)
                {
                    my_circle.Add(new MyFigure(new Point(X, Y), X1 - X, Y1 - Y, panel_color.BackColor, true, trackBar1.Value, circle_str));
                    assorted.Add(new MyFigure(new Point(X, Y), X1 - X, Y1 - Y, panel_color.BackColor, true, trackBar1.Value, circle_str));
                }
                else
                {
                    mybrush.Color = panel_color.BackColor;
                    my_circle.Add(new MyFigure(new Point(X, Y), X1 - X, Y1 - Y, mybrush.Color, false, trackBar1.Value, circle_str));
                    assorted.Add(new MyFigure(new Point(X, Y), X1 - X, Y1 - Y, mybrush.Color, false, trackBar1.Value, circle_str));
                }
            }
            else if (rectangle)
            {
                if (filling)
                {
                    my_rectangle.Add(new MyFigure(new Point(X, Y), X1 - X, Y1 - Y, panel_color.BackColor, true, trackBar1.Value, rect_str));
                    assorted.Add(new MyFigure(new Point(X, Y), X1 - X, Y1 - Y, panel_color.BackColor, true, trackBar1.Value, rect_str));
                }
                else
                {
                    mybrush.Color = panel_color.BackColor;
                    my_rectangle.Add(new MyFigure(new Point(X, Y), X1 - X, Y1 - Y, mybrush.Color, false, trackBar1.Value, rect_str));
                    assorted.Add(new MyFigure(new Point(X, Y), X1 - X, Y1 - Y, mybrush.Color, false, trackBar1.Value, rect_str));
                }
            }
            filling = false;
        }
        private void panel_draw_Paint_1(object sender, PaintEventArgs e)
        {
            mybrush.Color = panel_color.BackColor;
            Pen pen = new Pen(mybrush, trackBar1.Value);
            foreach (var p in my_point)
            {
                mybrush.Color = p.color;
                e.Graphics.FillEllipse(mybrush, p.point.X, p.point.Y, p.thick, p.thick);
            }
            foreach (var p in my_line)
            {
                pen.Color = p.color;
                pen.Width = p.thick;
                e.Graphics.DrawLine(pen, p.first.X, p.first.Y, p.second.X, p.second.Y);
            }
            foreach (var p in my_circle)
            {
                pen.Width = p.thick;
                pen.Color = p.color;
                mybrush.Color = p.color;
                if (p.fill)
                    e.Graphics.FillEllipse(mybrush, new Rectangle(p.point, new Size(p.width, p.height)));
                else
                    e.Graphics.DrawEllipse(pen, new Rectangle(p.point, new Size(p.width, p.height)));
            }
            foreach (var p in my_rectangle)
            {
                pen.Color = p.color;
                pen.Width = p.thick;
                mybrush.Color = p.color;
                if (p.fill)
                    e.Graphics.FillRectangle(mybrush, new Rectangle(p.point, new Size(p.width, p.height)));
                else
                    e.Graphics.DrawRectangle(pen, new Rectangle(p.point, new Size(p.width, p.height)));
            }
            if ((line || circle || rectangle || pencil) && !erase)
            {
                if (line || circle || rectangle)
                {
                    mybrush.Color = panel_color.BackColor;
                    pen.Color = panel_color.BackColor;
                    pen.Width = trackBar1.Value;
                    if (line)
                    {
                        e.Graphics.DrawLine(pen, new Point(X, Y), new Point(X1, Y1));
                        foreach (var p in my_point)
                        {
                            mybrush.Color = p.color;
                            e.Graphics.FillEllipse(mybrush, p.point.X, p.point.Y, p.thick, p.thick);
                        }
                    }
                    else if (circle)
                    {
                        if (filling)
                            e.Graphics.FillEllipse(mybrush, new Rectangle(new Point(X, Y), new Size(X1 - X, Y1 - Y)));
                        else
                            e.Graphics.DrawEllipse(pen, new Rectangle(new Point(X, Y), new Size(X1 - X, Y1 - Y)));
                    }
                    else if (rectangle)
                    {
                        if (filling)
                            e.Graphics.FillRectangle(mybrush, new Rectangle(new Point(X, Y), new Size(X1 - X, Y1 - Y)));
                        else
                            e.Graphics.DrawRectangle(pen, new Rectangle(new Point(X, Y), new Size(X1 - X, Y1 - Y)));
                    }
                }
            }
        }

        private void button_pencil_Click(object sender, EventArgs e)
        {
            pencil = true;
            line = false;
            circle = false;
            rectangle = false;
        }

        private void button_line_Click(object sender, EventArgs e)
        {
            line = true;
            pencil = false;
            circle = false;
            rectangle = false;
        }

        private void button_circle_Click(object sender, EventArgs e)
        {
            pencil = false;
            line = false;
            circle = true;
            rectangle = false;
        }

        private void button_rectangle_Click(object sender, EventArgs e)
        {
            pencil = false;
            line = false;
            circle = false;
            rectangle = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Rectangle rectBounds = new Rectangle(0, 0, panel_draw.Width, panel_draw.Height); // устанавливаем границы для 'Bitmap'
            panel_draw.DrawToBitmap(map, rectBounds); // перемещаем рисунок
            map.Save("a.bmp", ImageFormat.Bmp); // сохраняем 'Bitmap' на файл
            MessageBox.Show("Изображение успешно сохранено!");
        }
        private void button_eraser_Click(object sender, EventArgs e)
        {
            erase = true;
            if (assorted.Count > 0)
            {
                if (assorted[assorted.Count - 1] is My_point)
                    my_point.RemoveAt(my_point.Count - 1);
                else if (assorted[assorted.Count - 1] is My_line)
                    my_line.RemoveAt(my_line.Count - 1);
                else if (assorted[assorted.Count - 1] is MyFigure)
                {
                    MyFigure my_F = (MyFigure)assorted[assorted.Count - 1];
                    if (my_F.typeF == circle_str)
                        my_circle.RemoveAt(my_circle.Count - 1);
                    else if (my_F.typeF == rect_str)
                        my_rectangle.RemoveAt(my_rectangle.Count - 1);
                }
                assorted.RemoveAt(assorted.Count - 1);
                panel_draw.Invalidate();
            } 
        }

        private void button_filling_Click(object sender, EventArgs e)
        {
            filling = true;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            my_g.Clear(Color.White);
            my_point.Clear();
            my_line.Clear();
            my_circle.Clear();
            my_rectangle.Clear();
            assorted.Clear();
        }
    }
}
