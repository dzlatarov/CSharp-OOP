
namespace P02_CarsSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        private const string offset = "  ";
        private const string DefaultColorValue = "n/a";
        private const int DefaultWightValue = -1;

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight) : this(model, engine, weight, DefaultColorValue)
        {
        }

        public Car(string model, Engine engine, string color) : this(model, engine, DefaultWightValue, color)
        {
        }

        public Car(string model, Engine engine) : this(model, engine, DefaultWightValue, DefaultColorValue)
        {
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.Append(this.Engine.ToString());
            sb.AppendLine(this.Weight == -1 ? $"{offset}Weight: n/a" : $"{offset}Weight: {this.Weight}");
            sb.Append(this.Color == "n/a" ? $"{offset}Color: n/a" : $"{offset}Color: {this.Color}");

            return sb.ToString();
        }
    }
}
