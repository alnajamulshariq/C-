using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Methods
{
    //Creating A New Class
    class Student
    {
        public int Id;
        public string Name;
        public int RollNo;

        //Method With Parameter
        public void msg(string name) 
        {
            Console.WriteLine("Hello " + name + " This Message Is From Student Class");
        }
    }
    //Creating A Car Class
    class CarBrand
    {
        public int Id;
        public string Owner;
        public string Name;
        public string Model;
        public string Color;
        public string Price;

        // Method With Parameter
        public void CarOwner(string Owner)
        {
            Console.WriteLine("Hello " + Owner + " This Is Your New Car");
        }
    }
    class Employees
    {
        public int Id;
        public string Name;
        public int Age;
        public void Empmsg(string name)
        {
            Console.WriteLine("Hi "+ name + " you are our employee");
        }
    }
    class Doctors
    {
        public int Id;
        public string Name;
        public string Ward;
        public void DctMsg(string Name, string Ward) 
        {
            Console.WriteLine("Hey Doctor: "+Name+" your duty in the "+Ward+" Ward");
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Id = 1;
            std.Name = "Shariq";
            std.RollNo = 101;
            Console.WriteLine(std.Id);
            Console.WriteLine(std.Name);
            Console.WriteLine(std.RollNo);
            std.msg("Shariq");


            CarBrand cb = new CarBrand();
            cb.Id = 1;
            cb.Owner = "Shariq";
            cb.Name = "Lamborghini";
            cb.Model = "Murcialago";
            cb.Color = "Yellow";
            cb.Price = "$22 Million";
            Console.WriteLine(cb.Id);
            Console.WriteLine(cb.Owner);
            Console.WriteLine(cb.Name);
            Console.WriteLine(cb.Model);
            Console.WriteLine(cb.Color);
            Console.WriteLine(cb.Price);
            cb.CarOwner("Shariq");

            Employees emp = new Employees();
            emp.Id = 1;
            emp.Name = "Bilal";
            emp.Age = 22;
            Console.WriteLine(emp.Id);
            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.Age);
            emp.Empmsg("Bilal");

            Doctors dct = new Doctors();
            dct.Id = 1;
            dct.Name = "Shariq";
            dct.Ward = "Emergency";
            Console.WriteLine(dct.Id);
            Console.WriteLine(dct.Name);
            Console.WriteLine(dct.Ward);
            dct.DctMsg("Shariq", "Emergency");
        }
    }
}
