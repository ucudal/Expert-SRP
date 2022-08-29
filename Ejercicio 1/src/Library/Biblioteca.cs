using System;
using System.Collections.Generic;

namespace SRP{
    public class Estanteria{
        public string LibrarySector { get ; }
        public string LibraryShelve { get ; }

        public List<Book> books { get; }

        public void AddBook(Book mybook){
            this.books.Add(mybook);
        }

        public Estanteria(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}