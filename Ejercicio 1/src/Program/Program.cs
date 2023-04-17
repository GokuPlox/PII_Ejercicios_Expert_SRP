using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Sector A = new Sector();
            Sector B = new Sector();
            Estanteria siete = new Estanteria();
            Estanteria cinco = new Estanteria();

            siete.AddBook(book1);
            cinco.AddBook(book2);
            A.AddEstante(siete);
            B.AddEstante(cinco);

            //Cree las clases de estanteria y sector para no poner cosas innecsarias ni sobrecargar las clases, a demas de hacerlas reutilizables. 



            
            

        }
    }
}