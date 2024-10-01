using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //Multi Level Inheritance
    internal class Mammal : Animal
    {
        public void MamMsg()
        {
            Console.WriteLine("Every mammal gives birth");
        }
    }
}
