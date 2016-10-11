using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationApplication.Manager
{
    class SerilializeException : Exception
    {
        public SerilializeException(string text) : base(text)
        {
        }

        public SerilializeException(string text, Exception innerEx) : base(text, innerEx)
        {
        }

        public SerilializeException(Exception innerEx) : base(innerEx.ToString())
        {
        }

    }
}
