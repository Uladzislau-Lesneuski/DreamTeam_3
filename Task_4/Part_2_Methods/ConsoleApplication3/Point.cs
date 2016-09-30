using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public override string ToString()
        {
            return $"{X}; {Y}";
        }

        public override bool Equals(object obj) 
        {
            return true; //самая простое и бесполезное переопределение
        }
    }
}
