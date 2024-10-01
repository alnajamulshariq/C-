using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //Polymorphism Overloading Method
    internal class PolyMOL
    {
        public void add(string name)
        {
            Console.WriteLine("Hello Good Morning" + name);
        }
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void add(int a, string b)
        {
            Console.WriteLine(a + b);
        }

        public void add(string a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void add(string a, string b)
        {
            Console.WriteLine(a + b);
        }

        public void add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }


    }
}
