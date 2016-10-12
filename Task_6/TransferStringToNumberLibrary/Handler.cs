using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TransferStringToNumberLibrary
{
    public class Handler
    {
        Operation operation = new Operation(); 

        public int Launch(string text)
        {
            const string NUMBER = @"\d+";
            Regex regex = new Regex(NUMBER);

            if (text.Equals("") | text == null )
            {
                throw new StringException("Empty string!");
            } if (!regex.IsMatch(text))
            {
                throw new StringException("Wrong string, write a number!");
            } else
            {
                 return operation.TransferStringToNumber(text);
            }
            
        }
    }
}
