
using System;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        private decimal WeekSalary
        {
            get => this.weekSalary;
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        private decimal WorkHoursPerDay
        {
            get => this.workHoursPerDay;
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        private decimal GetSalaryPerHour()
        {
            return this.WeekSalary / (5 * this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.ToString());
            stringBuilder.AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}")
                .Append($"Salary per hour: {this.GetSalaryPerHour():f2}");

            return stringBuilder.ToString();
        }
    }
}
