using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Animals.Mammals;

namespace WildFarm.Models.Animals.Felines
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get;  set; }        
    }
}
