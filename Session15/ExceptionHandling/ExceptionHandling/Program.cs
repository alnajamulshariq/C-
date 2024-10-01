using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Divide By Zero Exception
            Console.WriteLine("Enter Your First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            int num2 = int.Parse(Console.ReadLine());
            try
            {
                int resullt = num1 / num2;
                Console.WriteLine(resullt);
            }
            catch(DivideByZeroException e)
            {
            Console.WriteLine(e.Message); 
            }

            Console.WriteLine("Good Morning");
            Console.WriteLine("Hello");
            Console.WriteLine("Hey");

            //Out Of Range Exception

            try
            {
                string[] colors = new string[3];
                colors[0] = "red";
                colors[1] = "blue";
                colors[2] = "green";
                colors[4] = "purple";

                foreach (string color in colors)
                {
                    Console.WriteLine(color);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            //Null Exception

            try
            {
                string name = null;
                Console.WriteLine(name.Length);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            //Format Exception

            try
            {
                Console.WriteLine("Please Enter A Number");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
