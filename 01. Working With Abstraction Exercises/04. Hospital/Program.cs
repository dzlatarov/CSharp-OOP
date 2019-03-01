using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            var departments = new List<Department>();
            var doctors = new List<Doctor>();

            string command;

            while ((command = Console.ReadLine()) != "Output")
            {
                var commandArguments = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                var departamentName = commandArguments[0];
                var doctorFirstName = commandArguments[1];
                var doctorLastName = commandArguments[2];
                var patientName = commandArguments[3];
                
                if (!departments.Any(x => x.Name == departamentName))
                {
                    departments.Add(new Department(departamentName));
                }

                var department = departments.Single(d => d.Name == departamentName);
                var patient = new Patient(patientName);

                department.AddPatientToRoom(patient);

                if(!doctors.Any(d => d.FirstName == doctorFirstName && d.LastName == doctorLastName))
                {
                    doctors.Add(new Doctor(doctorFirstName, doctorLastName));
                }

                var doctor = doctors.Single(d => d.FirstName == doctorFirstName && d.LastName == doctorLastName);

                doctor.AddPatient(patient);
            }

            while ((command = Console.ReadLine()) != "End")
            {
                var commandArgument = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                if (commandArgument.Length == 1)
                {
                    var departmentName = commandArgument[0];

                    Console.WriteLine(departments.Single(d => d.Name == departmentName).GetAllPatients());
                }
                else if (commandArgument.Length == 2)
                {
                    if(commandArgument[1].All(Char.IsDigit))
                    {
                        var departmentName = commandArgument[0];
                        var roomNumber = int.Parse(commandArgument[1]);

                        Console.WriteLine(departments.Single(d => d.Name == departmentName).GetPatientsByRoom(roomNumber));
                    }
                    else
                    {
                        var doctorFirstName = commandArgument[0];
                        var doctorSecondName = commandArgument[1];

                        Console.WriteLine(doctors.Single(d => d.FirstName == doctorFirstName && d.LastName == doctorSecondName).GetPatients());
                    }
                }                            
            }
        }
    }
}
