
namespace P02_CarsSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine
    {
        private const string offset = "  ";
        private const int DefaultDisplacementValue = -1;
        private const string DefaultEfficiencyValue = "n/a";

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement) : this(model, power, displacement, DefaultEfficiencyValue)
        {
        }

        public Engine(string model, int power, string efficiency) : this(model, power, DefaultDisplacementValue, efficiency)
        {
        }

        public Engine(string model, int power) : this(model, power, DefaultDisplacementValue, DefaultEfficiencyValue)
        {
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{offset}{this.Model}:");
            sb.AppendLine($"{offset}{offset}Power: {this.Power}");
            sb.AppendLine(this.Displacement == -1 ? $"{offset}{offset}Displacement: n/a" : $"{offset}{offset}Displacement: {this.Displacement}");
            sb.AppendLine(this.Efficiency == "n/a" ? $"{offset}{offset}Efficiency: n/a" : $"{offset}{offset}Efficiency: {this.Efficiency}");

            return sb.ToString();
        }
    }
}
