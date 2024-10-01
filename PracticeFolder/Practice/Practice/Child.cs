using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //Single Inheritance
    internal class Child : Parent
    {
        public string name;
        public int age;
        public void ChMsg()
        {
            Console.WriteLine("This message is from child class");
        }
    }
}
