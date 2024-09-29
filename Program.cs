using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndDogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cats cat = new Cats("Mona",10,"British");
            Dogs dog = new Dogs("Ben",10,"Chihua-hua");
            dog.Owned();
            cat.Owned();
            Console.WriteLine(dog);
            Console.WriteLine(cat);
            Console.ReadKey();
        }
    }
}
