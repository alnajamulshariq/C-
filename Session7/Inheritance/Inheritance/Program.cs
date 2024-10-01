using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.Name = "Shariq";
            p.Age = 55;
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            p.msg();

            //The Following Child Class Has Name, Age And Method Inherit From Parent Class

            Child c = new Child();
            c.Name = "Hamza";
            c.Age = 22;
            Console.WriteLine(c.Name);
            Console.WriteLine(c.Age);
            c.msg();
            c.msgChild();

            //Multi Level Inheritance Class dog inherits properties of Class Animal & Mammals

            Dog d = new Dog();
            d.eat();
            d.features();
            d.noise();
        }
    }
}
