using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using SerializationApplication.Entity;

namespace SerializationApplication.Logic
{
    public static class Serialization
    {
        
        //ResXResourceSet resxSet = new ResXResourceSet(@".\Resource1.resx");
        //var ResultFilePath = resxSet.GetString("ResultFile");

        public static void Serialize()
        {
            FileStream file = new FileStream(@"./Serialized.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
      
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Catalog));
            Catalog catalog = new Catalog();

            ParseXml parser = new ParseXml();
            var Books = parser.ReadXml();

            List<Book> listOfBooks = new List<Book>();
            foreach (var bookItem in Books)
            {
                listOfBooks.Add(new Book(bookItem));
            }
            catalog.Books = listOfBooks;

            serializer.WriteObject(file, catalog);
            file.Close();
           
        }

        public static void Deserialize()
        {
            FileStream file = new FileStream(@"./Serialized.txt", FileMode.Open);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Catalog));
            var catalog = (Catalog)serializer.ReadObject(file);
            
            Console.WriteLine( "Количество книг содержащихся в xml файле: " + catalog.Books.Count);
        }

    }
  
}
