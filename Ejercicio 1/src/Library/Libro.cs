using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public Sector LibrarySector { get ; set; }
        public Estanteria LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public void ShelveBook(Sector sector, Estanteria shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}
