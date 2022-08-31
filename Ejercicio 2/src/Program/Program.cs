using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient();
            patient1.createPatient("Steven Jhonson", "986782342", 22);
            Doctor doctor1 = new Doctor();
            doctor1.createDoctor("Armand", "Pediatra");

            Apointment apointment1 = new Apointment();
            Console.WriteLine(apointment1.scheduleAppointment(patient1, doctor1, "5555-555-555", "Wall Street", DateTime.Now));

        }
    }
}
