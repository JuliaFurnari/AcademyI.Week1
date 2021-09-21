using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEx
{
    class Book
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public double Price { get; set; }
        public string Genre { get; set; }

        public Book(int id, string titolo, string autore, double price, string genre)
        {
            Id = id;
            Titolo = titolo;
            Autore = autore;
            Price = price;
            Genre = genre;
        }
    }
}
