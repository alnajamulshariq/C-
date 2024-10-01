using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment295
{
    class EmployeeDetails
    {
        public string[] empName = new string[2];
        public string this[int index]
        {
            get {
                   return empName[index];
                }
            set {
            
                   empName[index] = value;
                }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails ed = new EmployeeDetails();
            ed[0] = "Shariq Najam";
            ed[1] = "Muhammad Ali";
            Console.WriteLine("Employee Names: ");
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(ed[i] + "\t");
            }

        }
    }
}
