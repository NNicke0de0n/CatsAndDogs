using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CatsAndDogs
{
    internal class Animal
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        private bool IsOwned;
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsOwned = false;
        }
        public void Owned()
        {
            IsOwned = true;
        }
        public override string ToString()
        {
            string status = IsOwned ? "Хозяин есть" : "Хозяина нет";
            return $"{Name} {Age} ({status})";
        }
    }
}
