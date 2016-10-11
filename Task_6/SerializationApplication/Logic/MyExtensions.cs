using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SerializationApplication.Entity.Book;

namespace SerializationApplication.Logic
{
    public static class MyExtensions
    {
        public static bool ConsistOne(this String genre)
        {
            bool flag = false;
            for (int i = 0; i < 5; i++)
            {
                if (genre.Equals(Genres.Computer)) { flag = true; }
                else if (genre.Equals(Genres.Fantasy)) { flag = true; }
                else if (genre.Equals(Genres.Horror)) { flag = true; }
                else if (genre.Equals(Genres.Romance)) { flag = true; }
                else if (genre.Equals(Genres.ScienceFiction)) { flag = true; }
                else flag = false;
            }
            return flag;
        }
    }
}
