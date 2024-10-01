using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ARITHMETIC OPERATORS

            int a = 10;
            int b = 20;
            int add = a + b;
            Console.WriteLine("Addition: " + add);
            int sub = a - b;
            Console.WriteLine("Substraction: " + sub);
            int mult = a * b;
            Console.WriteLine("Multiplication: " + mult);
            int div = a / b;
            Console.WriteLine("Division: " + div);
            int mod = a % b;
            Console.WriteLine("Modulus: " + mod);


            //RELATIONAL OPERATORS

            int c = 9;
            int d = 10;
            Console.WriteLine(c == d);
            Console.WriteLine(c != d);
            Console.WriteLine(c > d);
            Console.WriteLine(c < d);
            Console.WriteLine(c >= d);
            Console.WriteLine(c <= d);

            //LOGICAL OPERATORS

            string username = "Shariq";
            string password = "shariq123";
            Console.WriteLine(username == "Shariq" && password == "shariq123");
            Console.WriteLine(username == "shariq" || username == "sha123");
            Console.WriteLine(!(username == "Admin"));

            //INCREMENT / DECREMENT OPERATOR
            int e = 4;
            Console.WriteLine(++e); //5
            Console.WriteLine(e); //5

            Console.WriteLine(e++); //4
            Console.WriteLine(e); //5

            Console.WriteLine(--e); //3
            Console.WriteLine(e); //3

            Console.WriteLine(e--); //4
            Console.WriteLine(e);

            //ASSIGNMENT OPERATORS

            int f = 3;
            Console.WriteLine(f += 3);
            Console.WriteLine(f -= 3);
            Console.WriteLine(f *= 3);
            Console.WriteLine(f /= 9);

        }
    }
}
