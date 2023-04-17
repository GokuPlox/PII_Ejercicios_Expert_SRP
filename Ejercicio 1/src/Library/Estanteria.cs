using System;
using System.Collections.Generic;
namespace SRP

{
    public class Estanteria 
    {
        public List<Book> Estante = new List<Book>();
        public Estanteria()
        {

            
        }

        public void AddBook(Book libro)
        {
            this.Estante.Add(libro);
            Console.WriteLine($"Se agrego el libro {libro}");
        }
        public void RemoveBook(Book libro)
        {
            this.Estante.Remove(libro);
            Console.WriteLine($"Se removio el libro {libro}");
        }
        public List<Book> getEstante()
        {
            return this.Estante;
        }
    
    }
}