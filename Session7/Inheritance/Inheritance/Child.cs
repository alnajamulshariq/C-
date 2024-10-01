using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Child : Parent
    {
        public void msgChild()
        {
            Console.WriteLine("This message is from child class");
        }
    }
}
