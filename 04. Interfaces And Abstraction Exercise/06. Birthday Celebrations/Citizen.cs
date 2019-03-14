
namespace BorderControl
{
    using BorderControl.Interfaces;

    public class Citizen : IBirthdate
    {
        private string name;
        private int age;
        private string id;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.Birthdate = birthdate;
        }       
        
        public string Birthdate { get; private set; }
    }
}
