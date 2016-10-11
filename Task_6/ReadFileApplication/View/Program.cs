using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileHandleManager handler = new FileHandleManager();

                Console.WriteLine("Write full path for txt format file");
                string path = Console.ReadLine();

                handler.Launch(path);
            }
            catch (FileException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Wrong path to your file!");
            }

        }
    }
}
