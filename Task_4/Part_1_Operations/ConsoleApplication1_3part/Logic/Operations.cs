using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1_3part
{
    class Operations
    {
        public string FileReading(string filePath)
        {
            string sourceText = "";
            FileStream sourceFile = new FileStream(filePath, FileMode.Open);
            StreamReader reader = new StreamReader(sourceFile);

            for (int i = 0; i < 20; i++)
            {
                sourceText = sourceText + reader.ReadLine() + "\n";
            }
            reader.Close();
            return sourceText;
        }

        public void FileWriting(string sourceText, string filePath)
        {
            FileStream file = new FileStream(filePath +  "/newFile.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.Write(sourceText);
            writer.Close();
        }

        public void FolderCreating(string folderPath, string folderName)
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath + "/" + folderName);
            if (!dir.Exists)
            {
                dir.Create();
            }
            else Console.WriteLine("Folder already exist");
        }

        public string ReadString()
        {
            string str = Console.ReadLine();
            return str;
        }



    }
}
