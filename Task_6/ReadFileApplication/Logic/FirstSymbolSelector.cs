using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReadFileApplication.Logic
{
    class FirstSymbolSelector
    {
        public void FirstSymbolsPrinting(string source)
        {
            // регулярка на любые символы кроме пробелов, их не считаем за символы.
            const string STRING = @"[^ ]";
            Regex regex = new Regex(STRING);
 
                if (!source.Equals(""))
                {
                    Console.WriteLine(regex.Match(source));
                } 
            
        }

    }
}
