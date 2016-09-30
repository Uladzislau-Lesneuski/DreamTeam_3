using ConsoleApplication2_3part.Utils;
using EquationSolving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2_3part
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleReader reader = new ConsoleReader();
            HandleManager manager = new HandleManager();
            manager.Launch(reader.Validate());

            Console.ReadLine();
        }
    }
}
