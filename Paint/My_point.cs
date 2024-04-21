using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class My_point
    {
        public Point point;
        public Color color = Color.White;
        public int thick;
        public My_point(Point _point, Color _color, int _thick)
        {
            point = _point;
            color = _color;
            thick = _thick;
        }
    }
}
