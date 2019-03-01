
namespace StudentSystemCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StudentSystem
    {
        private Dictionary<string, Student> students;

        public StudentSystem()
        {
            this.students = new Dictionary<string, Student>();
        }

        public void ParseCommand(string commands)
        {
            var studentInfo = commands.Split();
            var command = studentInfo[0];


            switch (command)
            {
                case "Create":
                    AddStudents(studentInfo);
                    break;
                case "Show":
                    ShowStudent(studentInfo);
                    break;                
            }                                
        }

        private void ShowStudent(string[] studentInfo)
        {
            var studentName = studentInfo[1];

            if(this.students.ContainsKey(studentName))
            {
                Student student = this.students[studentName];

                Console.WriteLine(student);
            }
        }

        private void AddStudents(string[] studentInfo)
        {
            var studentName = studentInfo[1];

            if (!this.students.ContainsKey(studentName))
            {
                var studentAge = int.Parse(studentInfo[2]);
                var studentGrade = double.Parse(studentInfo[3]);

                Student student = new Student(studentName, studentAge, studentGrade);
                this.students.Add(studentName, student);
            }
        }
    }
}
