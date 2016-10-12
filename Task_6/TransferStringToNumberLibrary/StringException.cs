using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferStringToNumberLibrary
{
    public class StringException: Exception
    {
        public StringException(string message) : base(message)
        {

        }

        public StringException(string message, Exception innerEx) : base(message, innerEx)
        {

        }

        public StringException(Exception innerEx) : base(innerEx.ToString())
        {

        }

    }
}
