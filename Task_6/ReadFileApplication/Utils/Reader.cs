using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileApplication.Utils
{
    class Reader
    {
        public List<string> ReadFile(string filePath)
        { 
            FileStream sourceFile = new FileStream(filePath, FileMode.Open);
            StreamReader reader = new StreamReader(sourceFile);
            List<string> strings = new List<string>();

            while (!reader.EndOfStream)
            {
                strings.Add(reader.ReadLine());
            }
            //sourceText = reader.ReadToEnd();

            reader.Close();
            return strings;
        }
    }
}
