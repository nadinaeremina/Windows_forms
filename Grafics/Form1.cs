using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafics
{
    /* 
     * 
     GDI+ (Graphics Device Interface) - библиотека Net.Framework, часть операц. сис-мы Windows (исп-ие драйверов)

     using System.Drawing

     Структуры:
     1) Color - задавать цвет 
     2) Size - высота и ширина
     3) Point - точка X,Y (если это линия - с какой точки начинается)
     4) Rectangle - прямоугольник (внутри есть св-ва: Point (X,Y), Size 
     Точка Point у Rectangle - это верхний левый угол
     Элипс - вписывается в прямоугольник (Точка Point у элипса - это верхний левый угол прямоугольника, в кот. он вписан)
     
     using System.Drawing.Drawing2D

     - расширенные возм-ти функциональные для векторной и растровой графики
     1) Brash - закрвшивание пространства м/у линиями, кот. мы нарисуем 
     (Color + различные текстуры: TextureBrush, HatchBrush, LinearGradientBrush)
     2) SolidBrash - заполняет фигуру сплошным цветом
     3) Pen - основание линии (перо) - не закрашивание
     
     using System.Drawing.Imaging

     Image (абстрактный класс), у него есть производные классы:
     1) Bitmap (растровые изображения)
     2) Metafile (векторные изображения) - послед-ть двоичных записей
     позволяет масштабировать рисунок, не теряя разрешения, а также размывать, сглаживать и т.д.
     Metafile можно преобразовывать в растровые изображения, но часть данных будет теряться
     3) Font
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //// 1) DrawPoints
        //// для этого нужна кол-ция точек (X, Y)
        //List<Point> points = new List<Point>();
        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    // Graphics' - поверхность рисования GDI+
        //    Graphics g = e.Graphics; // об-т, который яв-ся источником нашего события - этот обьект мы будем прорисовывать
        //    foreach (Point p in points)
        //        g.FillEllipse(Brushes.Blue, p.X, p.Y, 20f, 20f); // цвет, коорд-ты начала, ширина и высота (float)
        //    // 'Draw' - прорисовываем только периметр
        //    // 'Fill' - рисуем об-т с его заполн-ем
        //}

        //// 1
        //private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        //{
        //    points.Add(new Point(e.X, e.Y));
        //    Invalidate(); // перерисовать нашу повер-ть формы
        //}

        //// 2) DrawEllipse
        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    int x = 25, y = 35, h = 60, w = 60;
        //    Pen pn = new Pen(Brushes.Red, 5); // создаем перо (цвет, толщина линии)
        //    Point pt = new Point(10, 10); // создаем точку (X, Y)
        //    Size sz = new Size(160, 160); // создаем 'Size' ширина и высота
        //    // для окружности нужно создать прямоугольник
        //    Rectangle r1 = new Rectangle(pt, sz); // 1 вариант создания прямоугольника
        //    Rectangle r2 = new Rectangle(x, y, w, h); // 2 вариант создания прямоугольника
        //    g.FillEllipse(Brushes.Blue, r1); // закрашенный круг
        //    g.DrawEllipse(pn, r2); // не закрашенный круг
        //}

        //// 3) Rectangle
        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    int x = 25, y = 35, h = 60, w = 60;
        //    Pen pn = new Pen(Brushes.Red, 5); // создаем перо
        //    Point pt = new Point(10, 10); // создаем точку
        //    Size sz = new Size(160, 160); // ширина и высота
        //    // для окружности нужно создать прямоугольник
        //    Rectangle r1 = new Rectangle(pt, sz); // 1 вариант создания прямоугольника
        //    Rectangle r2 = new Rectangle(x, y, w, h); // 2 вариант создания прямоугольника
        //    g.FillRectangle(Brushes.Blue, r1);
        //    g.DrawRectangle(pn, r2);
        //}

        // 4)
        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    //// вариант 1
        //    //Graphics g = e.Graphics;
        //    //g.TranslateTransform(20, 30); // сдвигает коррдинаты начальные (0,0) в другие
        //    //Point A = new Point(0, 0); // начальная точка (20,30)
        //    //Point B = new Point(100, 100); // конечная (120, 130)
        //    //g.DrawLine(new Pen(Brushes.Brown, 3), A, B); // рисуем линию (перо, координаты начала и конца)

        //    // вариант 2
        //    Graphics g = e.Graphics;
        //    Point A = new Point(0, 0); // начальная точка (20,30)
        //    Point B = new Point(100, 100); // конечная (120, 130)
        //    g.SmoothingMode = SmoothingMode.HighQuality; // сглаживание линий
        //    Pen pen = new Pen(Brushes.Brown, 3);
        //    // св-ва 'Pen'
        //    pen.StartCap = LineCap.SquareAnchor; // каким будет начало линии
        //    pen.EndCap = LineCap.ArrowAnchor; // каким будет конец линии
        //    pen.DashStyle = DashStyle.Dash; // в каком стиле будет пунктирная линия
        //    pen.DashCap = DashCap.Round; // как заканчивается каждая пунктирная линия
        //    g.DrawLine(pen, A, B);
        //    pen.Dispose(); // очищаем память от об-ов, если много об-ов на одной плоскости
        //    g.Dispose(); // очищаем память от об-ов, если много об-ов на одной плоскости
        //}

        //// 5) draw_all
        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Point[] points =
        //    {
        //                       new Point(5, 10),
        //                       new Point(23, 130),
        //                       new Point(130, 57)
        //    };
        //    GraphicsPath path = new GraphicsPath(); // 'Path' - графич. путь

        //    // замкнутое пр-во
        //    path.StartFigure();
        //    path.AddEllipse(170, 170, 100, 50); // добавить к пути такую фигуру
        //    g.FillPath(Brushes.Aqua, path); // закрасили фигуру 

        //    // все три фигуры соединились благодаря 'Path'
        //    path.StartFigure(); // путь всегда начинается со Start
        //    path.AddCurve(points, 0.5F); // построить кривую линию по точкам
        //    path.AddArc(100, 50, 100, 100, 0, 120); // добавляем дугу элипса
        //    path.AddLine(50, 150, 50, 220); // добавляем линию
        //    path.CloseFigure(); // путь всегда заканчивается Close

        //    // дуга
        //    path.StartFigure();
        //    path.AddArc(180, 30, 60, 60, 0, -170); // дуга

        //    g.DrawPath(new Pen(Color.Blue, 3), path); // цвет и толщина обводки пути для всего полотна
        //    g.Dispose();
        //}

        //// 6)
        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    g.SmoothingMode = SmoothingMode.HighQuality; // сглаживание

        //    g.DrawLine(new Pen(Color.Red, 2), 0, 0, 100, 100); // линия
        //    g.DrawRectangle(new Pen(Color.Green, 2), new Rectangle(100, 100, 60, 60)); // квадрат
        //    g.DrawPie(new Pen(Color.Indigo, 3), 150, 10, 150, 150, 90, 180); // полукруг
        //    g.DrawString("Hello GDI + !", new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, 0, 240); // рисуем строку

        //    // кракозябра
        //    PointF[] pArray =
        //    {
        //         // в какой послед-ти покажем точки - в такой они и соединятся
        //         new PointF(10.0F, 50.0F),
        //         new PointF(200.0F, 200.0F),
        //         new PointF(90.0F, 20.0F),
        //         new PointF(140.0F, 50.0F),
        //         new PointF(40.0F, 150.0F)
        //    };
        //    g.DrawPolygon(new Pen(Color.GreenYellow, 2), pArray); // можно так, а можно с пом. 'Polygon' (четкие прямые линии)

        //    g.DrawEllipse(new Pen(Color.Green, 4), 200, 230, 30, 30); // кружок

        //    g.Dispose();
        //}
    }
}
