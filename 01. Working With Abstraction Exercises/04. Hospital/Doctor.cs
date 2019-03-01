﻿
namespace P04_Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Doctor
    {
        public Doctor(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patients = new List<Patient>();
        }

        public string FirstName { get;  private set; }
        public string LastName { get; private set; }
        public List<Patient> Patients { get; private set; }

        public void AddPatient(Patient patient)
        {
            this.Patients.Add(patient);
        }

        public string GetPatients()
        {
            return string.Join(Environment.NewLine, Patients.Select(p => p.Name).OrderBy(p => p));
        }
    }
}
