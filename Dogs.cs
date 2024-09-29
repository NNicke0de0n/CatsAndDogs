using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndDogs
{
    internal class Dogs : Animal
    {
        public string Breed { get; protected set; }
        public Dogs(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
    }
}
