using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Resources;

namespace SerializationApplication.Logic
{
    class ParseXml
    {
        //ResXResourceSet resxSet = new ResXResourceSet(@".\Resource1.resx");
        //var XmlFilePath = resxSet.GetString("BooksFile");

        // должно было читаться из ресурсного файла, но visual studio не находит соответствующей библиотеки
        XDocument xDocument = XDocument.Load(@".\Books.xml");

        public Dictionary<string, List<string>> ReadXml()
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            var booksList = xDocument.Elements().First().Elements();

            foreach (var book in booksList)
            {
                List<string> list = new List<string>();
                string id = book.FirstAttribute.ToString();
                var bookTags = book.Elements();

                foreach (var item in bookTags)
                {
                    list.Add(item.Value);
                }

                dictionary.Add(id, list);
            }

            return dictionary;
        }
    }
}
