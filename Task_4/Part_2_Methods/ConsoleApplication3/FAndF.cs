using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class FAndF 
    {
        public List<ulong> Fibonacci { get; private set; } = new List<ulong>();
        public List<ulong> Factorial { get; private set; } = new List<ulong>();
        public uint N { get; private set; }

        public FAndF(uint n)
        {
            N = n;
        }

        public List<ulong> Fib()
        {
            Fibonacci.Add(0);
            Fibonacci.Add(1);
            for (int i = 2; i <= N; i++)
            {
                Fibonacci.Add(Fibonacci[i - 2] + Fibonacci[i - 1]);
            }
            return Fibonacci;
        }
        public void Print (List<ulong> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public List<ulong> Fact()
        {
            Factorial.Add(1);
            Factorial.Add(2);
            for (int i = 1; i < N; i++)
            {
                Factorial.Add(Factorial[0] * Factorial[i]);
            }

            return Factorial;
        }

    }
}
