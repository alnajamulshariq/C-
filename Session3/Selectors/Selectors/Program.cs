using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IF-ELSE STATEMENT
            int age = 19;
            if (age >= 18)
            {
                Console.WriteLine("You can Drive");
            }
            else
            {
                Console.WriteLine("You are not allowed to drive because you are under age");
            }

            //IF-ELSE GETTING VALUE FROM INPUT

            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            if (username == "Shariq" && password == "Shariq123")
            {
                Console.WriteLine("Login Successfully");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }

            //IF-ELSE-IF STATEMENT GETTING VALUE FROM INPUT
            
            Console.WriteLine("Enter Your Percentage");
            int per = int.Parse(Console.ReadLine());

            if (per >= 80 && per <= 100)
            {
                Console.WriteLine("Your Grade is A-one");
            }
            else if (per >= 70)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if (per >= 33)
            {
                Console.WriteLine("Your Grade is D");
            }
            else if (per < 33)
            {
                Console.WriteLine("You are Fail");
            }
            else
            {
                Console.WriteLine("Invalid Percentage");
            }


            //IF-ELSE-IF STATEMENT GETTING VALUE FROM INPUT EXAMPLE 2

            Console.WriteLine("Enter Your Car Brand");
            string brand = Console.ReadLine();

            if(brand == "Toyota")
            {
                Console.WriteLine("Toyota car price is more than 80 lac");
            }
            else if(brand == "Civic")
            {
                Console.WriteLine("Civiv car price is more than 90 lac");
            }
            else if (brand == "Audi")
            {
                Console.WriteLine("Audi car price is more than 99 lac");
            }
            else
            {
                Console.WriteLine("Invalid Brand");
            }


            //NESTED IF GETTING VALUE FROM INPUT

            Console.WriteLine("Enter Username");
            string user = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string pass = Console.ReadLine();

            if(user != "" && pass != "")
            {
                if(user == "Admin" && pass == "Admin123")
                {
                    Console.WriteLine("login Succssfully");
                }
                else
                {
                    Console.WriteLine("incorrect username or password");
                }
            }
            else
            {
                Console.WriteLine("username and password is required");
            }

        //SWITCH CASE GETTING VALUE FROM INPUT
        start:
            Console.WriteLine("Enter a number of day");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please enter between 1 to 7");
                    goto start;

            }
        }
    }
}
