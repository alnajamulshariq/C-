using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class parent
    {
        public virtual void msg()
        {
            Console.WriteLine("This message is from parent class");
        }
    }
    class child : parent
    {
        public override void msg()
        {
            Console.WriteLine("This message is from child class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parent p = new child();
            p.msg();

            Overloading ov = new Overloading();
            ov.add("Shariq");
            ov.add(2, 2);
            ov.add(2,"5");
            ov.add("5", 6);
            ov.add("hello"," world");
            ov.add(2, 4, 6);

        }
    }
}
