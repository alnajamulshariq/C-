using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersTask
{
    class Student
    {
        private string[] Age = new string[3];
        public string this[int index]
        {
            set
            {
                if (index < Age.Length)
                {
                    if (value == null)
                    {
                        Age[index] = null;
                    }
                    else if (int.Parse(value) > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Age cannot be negative");
                    }
                }
                else
                {
                    Console.WriteLine("Index number exceeded");
                }
            }
            get
            {
                return Age[index];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std[0] = null;
            std[1] = "19";
            std[2] = null;
            Console.WriteLine(std[0]);
            Console.WriteLine(std[1]);
            Console.WriteLine(std[2]);

        }
    }
}

