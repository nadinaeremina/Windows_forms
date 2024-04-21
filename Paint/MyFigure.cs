using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class MyFigure
    {
        public Point point;
        public int width;
        public int height;
        public Color color = Color.White;
        public bool fill;
        public int thick;
        public string typeF;
        public MyFigure(Point _point, int _width, int _height, Color _color, bool _fill, int _thick, string _typeF)
        {
            point = _point;
            width = _width;
            height = _height;
            color = _color;
            fill = _fill;
            thick = _thick;
            typeF = _typeF;
        }
    }
}
