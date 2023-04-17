using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            //Console.WriteLine(appointmentResult);

            Paciente paciente1= new Paciente("Steven","Jhonson", 39, 5555);
            Doctor doctor1 = new Doctor("Armand", "Sipo", "Medicina general");
            Consulta consulta1 = new Consulta(paciente1, DateTime.Now, "Sede principal", doctor1);
            Console.WriteLine(consulta1.InfoDeConsulta());

            //Cree clases para las consultas, el doctor y los pacientes, puse los metodos donde creir que estaban los expertos de esa informacion y con unico responsable de sus propios datos

            //string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            //Console.WriteLine(appointmentResult2);
        }
    }
}
