using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Student
    {
        private int[] Age = new int[3];
        public int this[int index]
        {
            set
            {
                if (index < Age.Length)
                {
                    if (value > 0)
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
            std[0] = 21;
            std[1] = 19;
            std[2] = 23;
            Console.WriteLine(std[0]);
            Console.WriteLine(std[1]);
            Console.WriteLine(std[2]);

        }
    }
}
