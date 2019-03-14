
namespace BorderControl
{
    using BorderControl.Interfaces;

    public class Pet : IBirthdate
    {
        private string name;

        public Pet(string name, string birthdate)
        {
            this.name = name;
            
            this.Birthdate = birthdate;
        }
       
        public string Birthdate { get; private set; }
    }
}
