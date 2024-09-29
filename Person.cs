using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndDogs
{
    internal class Person
    {
        public string Name { get; protected set; }
        public List<Animal> Animals { get; protected set; } = new List<Animal> { };

        public Person(string name)
        {
            Name = name;
        }
        public string ShowAnimals(List<Animal> animals)
        {
            string allAnimal = "";
            foreach (Animal animal in animals)
            {
                allAnimal += $"\n{animal}";
            }
           return allAnimal;
        }
        public override string ToString()
        {
            return $"{Name},{ShowAnimals(Animals)}";
        }
    }
}

