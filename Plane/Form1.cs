using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane
{
    public partial class Form1 : Form
    {
        Bitmap sky, plane;
        Graphics g;
        int dx;
        Rectangle rct;
        Random rnd;

        Boolean demo = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.DrawImage(sky, new Point(0, 0));
            if (rct.X < ClientRectangle.Width) rct.X += dx;
            else
            {
                rct.X = -40;
                rct.Y = 20 + rnd.Next(ClientSize.Height - 40 - plane.Height);
            }
            g.DrawImage(plane, rct.X, rct.Y);
            if (!demo) Invalidate(rct);
            else
            {
                Rectangle reg = new Rectangle(20, 20, sky.Width - 40, sky.Height - 40);
                g.DrawRectangle(Pens.Black, reg.X, reg.Y, reg.Width - 1, reg.Height);
                Invalidate(reg);
            }
        }

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            try
            {
                sky = new Bitmap("sky.bmp");
                plane = new Bitmap("plane.bmp");
                BackgroundImage = new Bitmap("sky.bmp");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            plane.MakeTransparent();
            ClientSize = new System.Drawing.Size(new Point(BackgroundImage.Width, BackgroundImage.Height));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            // g=Graphics.FromImage(sky); //
            g = Graphics.FromImage(BackgroundImage);
            rct.X = -40;
            rct.Y = 20 + rnd.Next(20);
            rct.Width = plane.Width;
            rct.Height = plane.Height;
            dx = 2;
            timer1.Interval = 20;
            timer1.Enabled = true;
        }
    }
}
