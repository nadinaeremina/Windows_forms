using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class My_line
    {
        public Point first;
        public Point second;
        public Color color = Color.White;
        public int thick;
        public My_line(Point _x, Point _y, Color _color, int _thick)
        {
            first = _x;
            second = _y;
            color = _color;
            thick = _thick;
        }
    }
}
