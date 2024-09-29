using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndDogs
{
    internal class Dogs : Animal
    {
        public Size Size { get; protected set; }
        public Dogs(string name, int age, Size size) : base(name, age)
        {
            Size = size;
        }
        public override string ToString()
        {
            return $"{base.ToString()},{Size} ";
        }
    }
}
