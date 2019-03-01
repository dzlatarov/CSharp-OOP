namespace StudentSystemCatalog
{
    using System;
    using System.Collections.Generic;
    
    public class Student
    {
        private string name;
        private int age;
        private double grade;

        public Student(string name, int age, double grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public override string ToString()
        {
            string gradeComment = GetGradeComment();
            return $"{this.name} is {this.age} years old. {gradeComment}";
        }

        private string GetGradeComment()
        {
            if(this.grade >= 5)
            {
                return "Excellent student.";
            }
            else if(this.grade < 5.00 && this.grade >= 3.50)
            {
                return "Average student.";
            }
            else
            {
                return "Very nice person.";
            }
        }
    }
}