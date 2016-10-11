using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileApplication
{
    class FileException: Exception
    {
        public FileException(string text) : base(text)
        {
        }

        public FileException(string text, Exception innerEx) : base(text, innerEx)
        {
        }

        public FileException(Exception innerEx) : base(innerEx.ToString())
        {
        }

    }
}
