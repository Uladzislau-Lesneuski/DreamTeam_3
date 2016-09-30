using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_3part
{
    class FileCreator
    {
        public string FolderName { get; set; }

        public string FolderPath { get; set; }

        public string FilePath { get; set; }

        public FileCreator(string folderPath, string folderName, string filePath)
        {
            FolderName = folderName;
            FolderPath = folderPath;
            FilePath = filePath;
        }
        
    }
}
