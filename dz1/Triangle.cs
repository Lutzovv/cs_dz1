using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    class Triangle
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public Triangle (double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double Perimeter()
        {
            return _side1 + _side2 + _side3;
        }

        public void Print()
        {
            Console.WriteLine($"Сторона 1: {_side1}\nСторона 2: {_side2}\nСторона 3: {_side3}\nПериметр: {Perimeter()}");
        }
    }
}
