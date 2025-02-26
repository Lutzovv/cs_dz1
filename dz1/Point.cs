using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class Point
    {
        private double x;
        private double y;
        private double z;

        public Point()
        {
            x = 0; y = 0; z = 0;
        }

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void MoveBy(double dx, double dy, double dz)
        {
            x = dx;
            y = dy;
            z = dz;
        }

        public void Print()
        {
            Console.WriteLine($"X: {x}\nY: {y}\nZ: {z}\n");
        }
    }
}
