using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    class Circle
    {
        private int _point_x;
        private int _point_y;
        private double _radius;
        private const double PI = 3.14;

        public Circle(int point_x, int point_y, double radius)
        {
            _point_x = point_x;
            _point_y = point_y;
            _radius = radius;
        }

        public double Length()
        {
            return 2 * PI * _radius;
        }

        public double Area()
        {
            return (_radius * _radius) * PI;
        }

        public void Print()
        {
            Console.WriteLine($"X: {_point_x}\nY: {_point_y}\nРадиус: {_radius}\nДлинна: {Length()}\nПлощадь: {Area()}");
        }
    }
}
