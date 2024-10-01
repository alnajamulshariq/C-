using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public string Designation;
        public double GrossSalary;
        public double TaxDeduction = 0.1;
        public double NetSalary;

        private void CalculateSalary()
        {
            if(GrossSalary >= 40000)
            {
                NetSalary = GrossSalary - (GrossSalary * TaxDeduction);
                Console.WriteLine("Your Salary Is : " + NetSalary);
            }
            else
            {
                Console.WriteLine("Your Salary is : " + GrossSalary);
            }

        }

        public Employee(int EmpID, string EmpName, string EmpDesignation, double EmpGrossSalary)
        {
            Id = EmpID;
            Name = EmpName;
            Designation = EmpDesignation;
            GrossSalary = EmpGrossSalary;
            Console.WriteLine(EmpID);
            Console.WriteLine(EmpName);
            Console.WriteLine(EmpDesignation);
            CalculateSalary();
        }
    }
}
