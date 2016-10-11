
using SerializationApplication.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleManager handler = new HandleManager();
            handler.Lunch();

            Console.ReadLine();

        }
    }
}
