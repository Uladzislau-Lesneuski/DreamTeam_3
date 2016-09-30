using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication2_3part.Utils
{
    public class Reader
    {
        public List<string> ReadFile(string filePath)
        {
            List<string> matrix = new List<string>();
            const string MATRIX = @"\[[0-9\,\;\n\s]+\]";

            Regex regex = new Regex(MATRIX);

            string sourceText = "";
            FileStream sourceFile = new FileStream(filePath, FileMode.Open);
            StreamReader reader = new StreamReader(sourceFile);
            
            sourceText = reader.ReadToEnd();
            string matr = regex.Match(sourceText).ToString();
            matrix.Add(matr);
            sourceText = sourceText.Replace(matr, "1");
            matr = regex.Match(sourceText).ToString();
            matrix.Add(matr);

            reader.Close();
            return matrix;
         }
    }
}
