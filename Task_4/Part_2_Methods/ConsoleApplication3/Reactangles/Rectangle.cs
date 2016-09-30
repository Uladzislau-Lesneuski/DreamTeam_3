using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Reactangles
{
    public class Rectangle
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double Square { get; private set; }

        public Rectangle(double a, double b)
        {
            if ((a > 0) && (b > 0))
            {
                A = a;
                B = b;
                Square = A * B;
            }
        }
    }
}
