using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class Program
    {
        public static void Main()
        {
            var list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            Employee employee = new Employee("Ivan");
            Manager manager = new Manager("Gosho", list);

            var listOfEmployees = new List<Employee>();

            listOfEmployees.Add(employee);
            listOfEmployees.Add(manager);

            foreach (var item in listOfEmployees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
