using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        public String Nombre {get; set;}
        public String Apellido {get; set;}
        public int Edad {get; set;}
        public int Numero {get; set;}
        public Paciente(String nombre, String apellido, int edad, int numero)
        {
            try 
            {
            this.Nombre= nombre;
            this.Apellido=apellido;
            this.Edad=edad;
            this.Numero=numero;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No debe dejar ningun campo vacio, reintentelo");
            }
        }

        public string InformacionDelPaciente()
           {
            StringBuilder Info = new StringBuilder($"Nombre: {this.Nombre} {this.Apellido}\nEdad: {this.Edad}\nContacto: {this.Numero}");
            return Info.ToString();
           }


    }
}