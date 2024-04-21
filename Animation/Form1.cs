using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using static System.Drawing.Region; // для работы с регионами
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Brushes
        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;

        //    Rectangle r1 = new Rectangle(30, 30, 300, 50);
        //    Rectangle r2 = new Rectangle(30, 100, 300, 50);
        //    Rectangle r3 = new Rectangle(30, 170, 300, 50);

        //    // 1 // градиентная заливка 
        //    LinearGradientBrush lgb = new LinearGradientBrush(r1, Color.Yellow, Color.Green, 0.0f);
        //    g.FillRectangle(lgb, r1); // закрашиваем так, как настроили и закрашиваем то, что указали

        //    // 2 // графическая штриховка (с графич. узором)
        //    HatchBrush hb = new HatchBrush(HatchStyle.Cross, Color.Yellow); // стиль и цвет
        //    g.FillRectangle(hb, r2);

        //    // 3 // заливка геометрич. формы изображением
        //    TextureBrush tb = new TextureBrush(new Bitmap("sky2.jpg"));
        //    g.FillRectangle(tb, r3);
        //}

        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;

        //    Rectangle r1 = new Rectangle(30, 20, 200, 200);
        //    Rectangle r2 = new Rectangle(100, 100, 200, 200);

        //    // сначала не заполняем, только обводка
        //    g.DrawRectangle(Pens.Black, r1);
        //    g.DrawRectangle(Pens.Black, r2);

        //    // 'region' - класс графики - обьект, описывающий внутренную сущность замкнутых форм
        //    Region reg1 = new Region(r1);
        //    Region reg2 = new Region(r2);

        //    // reg1.Intersect(reg2); // пересечение
        //    // reg1.Union(reg2); // обьединение
        //    reg2.Exclude(reg1); // оставляем от нашего региона то, что не входит в пересечение

        //    g.FillRegion(Brushes.Blue, reg2); // закрашиваем регион
        //}

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pn = new Pen(Brushes.Red, 5);
            pn.DashStyle = DashStyle.Dot;
            g.DrawEllipse(pn, 100, 100, 200, 80);
        }
    }
}
