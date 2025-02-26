using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    class Square
    {
        private int _point_x;
        private int _point_y;
        private int _side;

        public Square(int point_x, int point_y, int side)
        {
            _point_x = point_x;
            _point_y = point_y;
            _side = side;
        }

        public int Perimeter()
        {
            return _side * 4;
        }

        public int Area()
        {
            return _side * _side;
        }

        public void Print()
        {
            Console.WriteLine($"X: {_point_x}\nY: {_point_y}\nСторона: {_side}\nПериметр: {Perimeter()}\nПлощадь: {Area()}");
        }
    }
}
