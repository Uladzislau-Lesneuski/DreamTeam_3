using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using SerializationApplication.Logic;

namespace SerializationApplication.Entity
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string Isbn { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string Title { get; set; }
        
        public enum Genres {Computer, Fantasy, Horror, Romance, ScienceFiction}
        [DataMember]
        public string Genre { get; set; }
        [DataMember]
        public string Publisher { get; set; }
        [DataMember]
        public DateTimeOffset PublishDate { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public DateTimeOffset RegistrationDate { get; set; }

        public Book() { }

        public Book(KeyValuePair<string, List<string>> book)
        {
            if (book.Value.Count == 8)
            {
                this.ID = book.Key;
                this.Isbn = book.Value[0];
                this.Author = book.Value[1];
                this.Title = book.Value[2];
                this.Genre = book.Value[3]; // должна быть реализация проверки на принадлежность жанра к перечислению
                this.Publisher = book.Value[4];
                this.PublishDate = Convert.ToDateTime(book.Value[5]);
                this.Description = book.Value[6];
                this.RegistrationDate = Convert.ToDateTime(book.Value[7]);
            } else
            {
                this.ID = book.Key;
                this.Author = book.Value[0];
                this.Title = book.Value[1];
                this.Genre = book.Value[2];  // должна быть реализация проверки на принадлежность жанра к перечислению
                this.Publisher = book.Value[3];
                this.PublishDate = Convert.ToDateTime(book.Value[4]);
                this.Description = book.Value[5];
                this.RegistrationDate = Convert.ToDateTime(book.Value[6]);
            }
        } 
        
              
    }
}
