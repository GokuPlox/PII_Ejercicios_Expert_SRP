using System;
using System.Text;

namespace Library
{
    public class Consulta
    {

        public int Id = 0;
        public int ID {get; set;}
        public String InfoPaciente {get; set;}
        public String Lugar {get; set;}
        public String Doctor {get; set;}
        public DateTime Fecha {get; set;}
        public Consulta(Paciente paciente, DateTime fecha, String lugar, Doctor doctor)
        {
            try 
            {
                this.InfoPaciente=paciente.InformacionDelPaciente();
                this.Lugar=lugar;
                this.Fecha=fecha;
                this.Doctor=doctor.InformacionDelDoctor();
                this.ID=Id;
                Id++;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No debe dejar ningun campo vacio, reintentelo");
            }
        }

        public String InfoDeConsulta()
        {
            StringBuilder Info = new StringBuilder($"{this.InfoPaciente}\nLugar: {this.Lugar}\nFecha: {this.Fecha}\nDoctor: {this.Doctor}\nID de la consulta: {this.ID}");
            return Info.ToString();
        }

    }
}