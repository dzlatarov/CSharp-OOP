﻿
using System;
using System.Linq;
using System.Text;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        private string FacultyNumber
        {
            get => this.facultyNumber;
            set
            {                
                if(value.Any(x => !char.IsLetterOrDigit(x) || value.Length < 5 || value.Length > 10))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.ToString());
            stringBuilder.AppendLine($"Faculty number: {this.FacultyNumber}");

            return stringBuilder.ToString();
        }
    }
}
