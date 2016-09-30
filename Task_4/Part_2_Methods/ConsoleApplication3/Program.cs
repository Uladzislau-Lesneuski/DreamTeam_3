using ConsoleApplication3;
using ConsoleApplication3.Reactangles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            FAndF fandf = new FAndF(6);
            fandf.Fib();
            fandf.Fact();
            //fandf.Print(fandf.Fibonacci);
            Console.WriteLine("----------------------");
            //fandf.Print(fandf.Fact);

            Logic logic = new Logic();
            logic.DoTask();

            Console.ReadLine();


        }
    }
}
