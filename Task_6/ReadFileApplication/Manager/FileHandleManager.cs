using ReadFileApplication.Logic;
using ReadFileApplication.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileApplication
{
    class FileHandleManager
    {
        Reader reader = new Reader();
        Logger logger = new Logger();
        private static FirstSymbolSelector ACTION = new FirstSymbolSelector();
        public void Launch(string filePath) 
        {
            if (filePath.Equals("") | filePath == null)
            {
                throw new FileException("Enter correct file path");
                logger.WriteLog("Enter correct file path");
            }
            else
            {
                foreach (var item in reader.ReadFile(filePath))
                {
                    if (item.Equals("") | item == null)
                    {
                        //throw new FileException("Empty string"); // не догадался как выбрасывать эксепшн и в то же время продолжать работу приложения.
                        Console.WriteLine("Empty string");
                        logger.WriteLog("Enter correct file path");
                    }
                    else
                    {
                        ACTION.FirstSymbolsPrinting(item);
                    }
                }
                
            }      

        }


    }
}
