using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_3part
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path where folder can be created");
            string folderPath = Console.ReadLine();
            Console.WriteLine("Enter folder Name");
            string folderName = Console.ReadLine();
            Console.WriteLine("Enter path for file which will be copied");
            string filePath = Console.ReadLine();

            FileCreator creator = new FileCreator(folderPath, folderName, filePath);
            HandleManager handler = new HandleManager();
            handler.Launch(creator);

        }
    }
}
