using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileApplication.Utils
{
    class Logger
    {
        public void WriteLog(string message)
        {
            FileStream file = new FileStream("D:/logFile.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);

            writer.Write(message);
            writer.Close();
        }

    }
}
