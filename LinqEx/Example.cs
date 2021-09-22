using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEx
{
    class Example
    {
        List<Book> books = new List<Book>()
        {
            new Book(1, "I Promessi Sposi", "Alessandro Manzoni", 22, "Classico"),
            new Book(2, "La Divina Commedia", "Dante Alighieri", 54.7, "Classico"),
            new Book(3, "1984", "George Orwell", 12.5, "Narrativa"),
            new Book(4, "Guerra e Pace", "Lev Tolstoj", 17.4, "Narrativa"),
            new Book(5, "Iliade", "Omero", 43.9, "Classico")
        };

        // Libro con Id = 3
        public void GetById()
        {
            //var a = from book in books
            //        where book.Id == 3
            //        select book;

            books.Where(b => b.Id == 3);

        }

        public void GroupByGenre()
        {
            var a = from book in books
                    group book by book.Genre;
        }
       
        public void OrderByAuthor()
        {
            var a = from book in books
                    orderby book.Autore
                    select book;
        }

    }
}
