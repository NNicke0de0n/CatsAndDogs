using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndDogs
{
    internal class Cats : Animal
    {
        private string Breed { get; set; }
        public Cats(string name, int age, string breed) : base(name, age) 
        { 
            Breed = breed;
        }
        public override string ToString()
        {
            return $"{base.ToString()},{Breed}";
        }
    }
}
