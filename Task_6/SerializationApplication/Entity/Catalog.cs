using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializationApplication.Entity
{
    [DataContract]
    class Catalog
    {
        [DataMember]
        public List<Book> Books { get; set; }

        public Catalog() { }
    }

}
