using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Overloading
    {
        public void add(string name)
        {
            Console.WriteLine("Good Morning " + name);
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
