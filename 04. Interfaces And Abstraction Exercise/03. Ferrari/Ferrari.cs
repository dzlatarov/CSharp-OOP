
using System.Text;

namespace Ferrari
{
    public class Ferrari : IFerarri
    {
        public Ferrari(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }

        public string Model { get; private set; }

        public string Driver { get; private set; }

        public string GazPedal()
        {
            return "Gas!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        private string Print()
        {
            return $"{this.Model}/{this.UseBrakes()}/{this.GazPedal()}/{this.Driver}";
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.Print());

            return stringBuilder.ToString();
        }
    }
}
