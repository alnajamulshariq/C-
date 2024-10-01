using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Student
    {
        private string Name;
        private int Age;

        public void SetProperties(string name, int age)
        {
            if(string.IsNullOrEmpty(name) == true)
            {
                Console.WriteLine("Name is required");
            }
            else
            {
                this.Name = name;
            }

            if(age <= 0)
            {
                Console.WriteLine("Age is Required");
            }
            else
            {
                this.Age = age;
            }
        }

        public (string Name, int Age) GetProperties()
        {
            return (this.Name, this.Age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetProperties("Shariq",26);
            Console.WriteLine(student.GetProperties());
        }
    }
}
