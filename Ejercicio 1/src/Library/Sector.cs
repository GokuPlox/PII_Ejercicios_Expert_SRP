using System;
using System.Collections.Generic;
namespace SRP
{
    public class Sector 
    {
        public List<Estanteria> Sectores = new List<Estanteria>();
        public Sector()
        {
        }
        public void AddEstante(Estanteria estante)
        {
            this.Sectores.Add(estante);
            Console.WriteLine($"Se agrego el libro {estante}");
        }
        public void RemoveEstante(Estanteria estante)
        {
            this.Sectores.Remove(estante);
            Console.WriteLine($"Se removio el libro {estante}");
        }
        public List<Estanteria> getSector()
        {
            return this.Sectores;
        }

    }
}