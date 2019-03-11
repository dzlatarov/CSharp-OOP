
namespace Animal
{
    using System;
    using System.Text;

    public class Animal
    {
        private const string exception = "Invalid input!";
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        private string Name
        {
            get => this.name;
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(exception);
                }

                this.name = value;
            }
        }
        
        private int Age
        {
            get => this.age;
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException(exception);
                }

                this.age = value;
            }
        }

        private string Gender
        {
            get => this.gender;
            set
            {
                if(string.IsNullOrEmpty(value) 
                    || string.IsNullOrWhiteSpace(value) 
                    || value != "Male" && value != "Female")
                {
                    throw new ArgumentException(exception);
                }

                this.gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return null;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(this.GetType().Name)
                .AppendLine($"{this.Name} {this.Age} {this.Gender}")
                .Append($"{this.ProduceSound()}");

            return stringBuilder.ToString();
        }
    }
}
