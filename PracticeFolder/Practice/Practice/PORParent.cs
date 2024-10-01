using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{ 
    //Polymorphism Overriding Method
    internal class PORParent
    {
        public virtual void msg()
        {
            Console.WriteLine("This message is from parent class");
        }
    }
}
