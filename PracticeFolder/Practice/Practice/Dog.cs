using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //Multi Level Inheritance
    internal class Dog : Mammal
    {
        public void DogMsg()
        {
            Console.WriteLine("Every Dog has a noise Bow Bow");
        }
    }
}
