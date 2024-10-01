using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace myApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //data types and variables
            int a = 25;
            float b = 2.5f;
            double c = 125.25;
            char d = 's';
            bool f = true;
            string myName = "Shariq Najam";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(myName);

            // for loop in nested array
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };

            for(int i = 0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }

            //if else statement
            int num = 5;
            if(num %2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            string username = "shariq";
            string password = "shariq123";
            if (username.Equals("shariq") && password.Equals("shariq123"))
            {
                Console.WriteLine("Login Successfully");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }

            //if else ladder
            int num1 = 56, num2 = 75, num3 = 34;
            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Num1 is greatest");
            }
            else if(num2 > num3)
            {
                Console.WriteLine("Num2 is greatest ");
            }
            else
            {
                Console.WriteLine("Num3 is greatest");
            }

            // multiple if

            int numb = 12;
            if (numb %3 == 0)
            {
                Console.WriteLine("Divisible by 3");
            }
            if (numb % 5 == 0)
            {
                Console.WriteLine("Divisible by 5");
            }
            if (numb % 9 == 0)
            {
                Console.WriteLine("Divisible by 9");
            }

            // switch case

            char ch = 'A';

            switch(ch)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("Vowels");
                    break;
                default:
                    Console.WriteLine("Consonent");
                    break;
            }



        }
    }
}
