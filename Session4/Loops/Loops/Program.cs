using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FOR LOOP

            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i);
            }

            //GETTING EVEN AND ODD NUMBERS FROM FOR-LOOP

            
            for (int j = 1; j <=10; j++)
            {
                if(j % 2 == 0)
                {
                    Console.WriteLine("Even Number: " + j);
                }
                else
                {
                    Console.WriteLine("Odd  Number: " + j);
                }
            }


            //WHILE LOOP

            int num = 1;
            while (num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }

            //DO WHILE LOOP

            int num2 = 1;
            do
            {
                Console.WriteLine(num2);
                num2++;
            }
            while (num2 <= 10);

            //DO WHILE LOOP IN FALSE CONDITION

            int num3 = 10;
            do
            {
                Console.WriteLine(num3);
                num3++;
            }
            while (num3 <= 1);

            //PRINT FOLLOWING PATTERN THROUGH FOR LOOP
            //*
            //**
            //***
            //****
            //*****

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            //PRINT FOLLOWING PATTERN THROUGH FOR LOOP
            //*****
            //****
            //***
            //**
            //*

            for (int i = 10; i >=1; i--)
            {
                for(int j = 0; j < i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            //PRINT FOLLOWING PATTERN THROUGH FOR LOOP
            //     *
            //    ***  
            //   *****
            //  *******

            for(int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2*i-1); k++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int i = 1; i <= 5; i++)
            {
                // Print leading spaces
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                // Move to the next line
                Console.WriteLine();
            }
        }
    }
}
