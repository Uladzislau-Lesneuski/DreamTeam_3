using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TransferStringToNumberLibrary
{
    class Operation
    {
        public int TransferStringToNumber(string text)
        {
            const string NUMBER = @"\d+";
            Regex regex = new Regex(NUMBER);

            string number = regex.Match(text).ToString();
            int integer = Convert.ToInt32(number);
            return integer;
        }

    }
}
