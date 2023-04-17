using System;
using System.Text;

namespace Library
{
    public class Doctor
    {

        public String Especialidad {get; set;}
        public String Nombre {get; set;}
        public String Apellido {get; set;}
        public Doctor(String nombre, String apellido, String especialidad)
        {
            try
            {
                this.Nombre=nombre;
                this.Especialidad=especialidad;
                this.Apellido=apellido;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No debe dejar ningun campo vacio, reintentelo");
            }
        }

        public String InformacionDelDoctor()
        {
            StringBuilder Info = new StringBuilder($"{this.Nombre} {this.Apellido}\nEspecialidad: {this.Especialidad}");
            return Info.ToString();
        }
    }
}