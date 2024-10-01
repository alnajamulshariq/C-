using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        //Abstract Classes
        abstract class Animals
        {
            public string Name;
            public string Noise;
            public string Eat;
            public abstract void printMsg();
        }

        class Cats : Animals
        {
            public override void printMsg()
            {
                Console.WriteLine("This Animal is: " + Name);
                Console.WriteLine("This Animal noise is " + Noise);
                Console.WriteLine("This Animal eating" + Eat);
            }
        }

        class Dogs : Animals
        {
            public override void printMsg()
            {
                Console.WriteLine("This Animal is: " + Name);
                Console.WriteLine("This Animal noise is " + Noise);
                Console.WriteLine("This Animal eating" + Eat);
            }
        }

        class Lions : Animals
        {
            public override void printMsg()
            {
                Console.WriteLine("This Animal is: " + Name);
                Console.WriteLine("This Animal noise is " + Noise);
                Console.WriteLine("This Animal eating" + Eat);
            }
        }

        //Creating Car Class
        class CarBrand
        {
            public int Id;
            public string Owner;
            public string Name;
            public string Model;
            public string Color;
            public double Price;

            public void CarOwner(string Owner, string Name)
            {
                Console.WriteLine("Hello " + Owner + " this is your new " + Name);
            }
        }

        //Abstraction
        class Employee
        {
            public int Id;
            public string Name;
            public string Designation;
            public double GrossSalary;
            public double TaxDeduction = 0.1;
            public double NetSalary;

            private void CalculateSalary()
            {
                if (GrossSalary >= 40000)
                {
                    NetSalary = GrossSalary - (GrossSalary * TaxDeduction);
                    Console.WriteLine("Your Net Salary is: " + NetSalary);
                }
                else
                {
                    Console.WriteLine("Your Net Salary is: " + GrossSalary);
                }
            }
            public Employee(int EmpID, string EmpName, string EmpDes, double EmpGrossSalary)
            {
                Id = EmpID;
                Name = EmpName;
                Designation = EmpDes;
                GrossSalary = EmpGrossSalary;
                Console.WriteLine(EmpID);
                Console.WriteLine(EmpName);
                Console.WriteLine(EmpDes);
                Console.WriteLine(EmpGrossSalary);
                CalculateSalary();
            }

        
        }
        
        static void Main(string[] args)
        {
            // Single Dimensional Array
            int[] num = new int[3] { 1, 2, 3 };
            Console.WriteLine(num[0]);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            string[] names = new string[3] { "Shariq", "Abdullah", "Hamza" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Multi Dimensional Array
            int[,] numb = new int[3, 4]
            {
                {1,2,3,11},
                {4,5,6,13},
                {7,8, 9,15}
            };
            for(int i = 0; i < numb.GetLength(0); i++)
            {
                for(int j = 0; j < numb.GetLength(1); j++)
                {
                    Console.Write(numb[i,j] + " ");
                }
                Console.WriteLine();
            }

            //Jagged Array
            string[][] comp = new string[3][];
                comp [0] = new string [] { "AirBus", "Boeing" };
                comp [1] = new string [] { "BMW", "Nissan", "Toyota" };
                comp [2] = new string [] { "Nokia", "Huawei", "Oppo", "Sony" };
            for(int i = 0; i < comp.GetLength(0); i++)
            {
                for(int j = 0; j < comp[i].GetLength(0); j++)
                {
                    Console.Write(comp[i][j] + " ");
                }
                Console.WriteLine();
            }

            //Class & Methods
            CarBrand cb = new CarBrand();
            cb.Id = 1;
            cb.Owner = "Shariq Najam";
            cb.Name = "Toyota";
            cb.Model = "Revo";
            cb.Color = "Black";
            cb.Price = 11000000;
            Console.WriteLine(cb.Id);
            Console.WriteLine(cb.Owner);
            Console.WriteLine(cb.Name);
            Console.WriteLine(cb.Model);
            Console.WriteLine(cb.Color);
            Console.WriteLine(cb.Price);
            cb.CarOwner(cb.Owner,cb.Model);

            //Single Inheritance
            Parent p = new Parent();
            p.name = "Farhat Hussain";
            p.age = 35;
            Console.WriteLine(p.name);
            Console.WriteLine(p.age);
            p.ParMsg();

            Child c = new Child();
            c.name = "Shariq Najam";
            c.age = 26;
            Console.WriteLine(c.name);
            Console.WriteLine(c.age);
            c.ParMsg();
            c.ChMsg();

            //Multi Level Inheritance
            Dog d = new Dog();
            d.AnimMsg();
            d.MamMsg();
            d.DogMsg();

            //Polymorphism Overloading Method
            PolyMOL ol = new PolyMOL();
            ol.add("Shariq");
            ol.add(2,2);
            ol.add(2,"2");
            ol.add("3",2);
            ol.add("5","3");
            ol.add(1,2,3);

            //Polymorphism Overriding Method
            PORParent or = new PORChild();
            or.msg();
            
            //Abstraction
            Employee emp = new Employee(1,"Shariq Najam","Secretary",90000);

            //Abstract Classes
            Cats cats = new Cats();
            cats.Name = "Cat";
            cats.Noise = "Meow";
            cats.Eat = "Rats";
            cats.printMsg();

            Dogs dogs = new Dogs();
            dogs.Name = "Dog";
            dogs.Noise = "Bow";
            dogs.Eat = "Pedigree";
            dogs.printMsg();

            Lions l = new Lions();
            l.Name = "Lion";
            l.Noise = "Roars";
            l.Eat = "Meat";
            l.printMsg();

        }
    }
}
