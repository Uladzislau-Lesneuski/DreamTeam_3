using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1_3part
{
    class HandleManager
    {
        private static Operations ACTION = new Operations();

        const string SYMBOLS = @"[\<\>\/\\\:\?\*\|]";
        const string QUOTES = "[\"]";
        Regex regex = new Regex(SYMBOLS);
        Regex regexQuotes = new Regex(QUOTES);

        public void Launch(FileCreator fc)
        {
            string text;
            string FilePath = @"D:/";

            try
            {
                if (fc.FilePath.Equals("") | fc.FilePath == null)
                {
                    Console.WriteLine("Enter valid path for file which will be copied");
                } else if (fc.FolderPath.Equals("") | fc.FolderPath == null) {
                    Console.WriteLine("Enter valid path where folder can be created");
                } else if (fc.FolderName.Equals("") | fc.FolderName == null | regex.IsMatch(fc.FolderName) | regexQuotes.IsMatch(fc.FolderName))
                {
                    Console.WriteLine("Enter valid folder name. Symbols < > \" | * ? : \\ /  are forbiden");
                } else
                {
                    ACTION.FolderCreating(fc.FolderPath, fc.FolderName);
                    text = ACTION.FileReading(fc.FilePath);
                    ACTION.FileWriting(text, FilePath + fc.FolderName);
                }
                //FileCreator creator = new FileCreator();
            }
            catch (Exception)
            {
                Console.WriteLine("Smth go wrong!");
            }

        }
    }
}
