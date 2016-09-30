using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Counter
    {
        public static uint Count { get; private set; }

        public Counter()
        {
            Count++;
        }
    }
}
