using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        /*
        Las propiedades LibrarySector & LibraryShelve no deberian estar en la clase Book sino que deberian pertenecer a una clase llamada biblioteca.
        */
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
        /*
        El metodo ShelveBook no deberia estar en la clase Book sino que deberia pertenecer a una clase llamada biblioteca.
        */
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}
