using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Employee<T>
    {
        T emp;
        public Employee(T emp)
        {
            this.emp = emp;
        }
        public T getname()
        {
            return this.emp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<int> empAge = new Employee<int>(22);
            Employee<string> empName = new Employee<string>("Shariq Najam");
            Console.WriteLine(empAge.getname());
            Console.WriteLine(empName.getname());

            List<int> list = new List<int>();
            list.Add(4);
            Console.WriteLine(list.Capacity);
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            Console.WriteLine(list.Capacity);
        }
    }
}
