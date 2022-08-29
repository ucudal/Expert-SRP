using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Estanteria estanteria1 = new Estanteria("A", "7");
            Estanteria estanteria2 = new Estanteria("B", "3");
            estanteria1.AddBook(book1);
            estanteria2.AddBook(book2);

        }
    }
}