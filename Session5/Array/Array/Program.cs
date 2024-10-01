using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SINGLE DIMENSIONAL ARRAY
            int[] nums = new int[3] { 1, 2, 3 };

            //Print Numbers By Indexing
            Console.WriteLine(nums[0]); //output 1
            Console.WriteLine(nums[1]); //output 2
            Console.WriteLine(nums[2]); //output 3

            //Print All Numbers Through Foreach Loop
            foreach (int numbers in nums)
            {
                Console.WriteLine(numbers);
            }

            string[] CarBrands = new string[5] { "Suzuki", "Toyota", "Nissan", "Haval", "Changan" };
            //Print String By Indexing
            Console.WriteLine(CarBrands[0]);
            Console.WriteLine(CarBrands[1]);    

            //Print All Strings Through Foreach Loop
            foreach(string brands in CarBrands)
            {
                Console.WriteLine(brands);
            }

            //MULTI DIMENSIONAL ARRAY OR RECTANGULAR ARRAY

            int[,] Numbers = new int[3, 4]
            {
                {1,3,5,7 },
                {2,4,6,8},
                {9,10,11,12}
            };

            //Print By Indexing
            Console.WriteLine(Numbers[1,2]);

            //Print All Numbers By For Loop
            for (int i = 0; i < Numbers.GetLength(0); i++)
            {
                for (int j = 0; j < Numbers.GetLength(1); j++)
                {
                    Console.Write(Numbers[i,j] + " ");
                }
                Console.WriteLine();
            }

            string[,] Companies = new string[3,3]
            {
                {"Toyota","Suzuki","Nissan" },
                {"IBM","HP","DELL" },
                {"Microsoft","Lenovo","Logitech" }
            };

            //Print String By Indexing
            Console.WriteLine(Companies[0,2]);

            //Print All String By For Loop
            for(int i = 0;i < Companies.GetLength(0); i++)
            {
                for (int j = 0; j < Companies.GetLength(1); j++)
                {
                    Console.Write(Companies[i, j] + " ");
                }
                Console.WriteLine();
            }

            //JAGGED ARRAY
            string[][] companies = new string[3][];
            {
                companies[0] = new string[] { "Boeing", "AirBus" };
                companies[1] = new string[] { "Rools Royce", "BMW","Ferrari" };
                companies[2] = new string[] { "Mitsubishi", "General", "Gree", "LG" };
            };
            for(int i = 0; i < companies.GetLength(0); i++)
            {
                for(int j = 0;j < companies[i].GetLength(0); j++)
                {
                    Console.Write(companies[i][j] + " ");
                }
                    Console.WriteLine();
            }

            // some practice following here

            //Console.WriteLine("Please Enter Your Age");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("You Can Drive");
            //}
            //else
            //{
            //    Console.WriteLine("You Can Not Drive");
            //}

            //Console.WriteLine("Please Enter Your Marks");
            //int per = int.Parse(Console.ReadLine());
            //if(per >=80 && per <= 100)
            //{
            //    Console.WriteLine("A+");
            //}
            //else if (per >= 70)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (per >= 60)
            //{
            //    Console.WriteLine("B");
            //}
            //else if(per >= 50)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (per <= 33)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Number");
            //}

            //Console.WriteLine("Please Enter User Name");
            //string user = Console.ReadLine();
            //Console.WriteLine("Please Enter Your Password");
            //string pass = Console.ReadLine();
            //if (user != "" && pass != "")
            //{
            //    if (user == "Shariq" && pass == "shariq123")
            //    {
            //        Console.WriteLine("Login Successfully");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Login Failed");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //start:
            //    Console.WriteLine("Please Enter A Number Of A Day");
            //    int day = int.Parse(Console.ReadLine());
            //    switch (day)
            //    {
            //        case 1:
            //            Console.WriteLine("Monday");
            //            break;
            //        case 2:
            //            Console.WriteLine("Tuesday");
            //            break;
            //        case 3:
            //            Console.WriteLine("Wednesday");
            //            break;
            //        case 4:
            //            Console.WriteLine("Thursday");
            //            break;
            //        case 5:
            //            Console.WriteLine("Friday");
            //            break;
            //        case 6:
            //            Console.WriteLine("Saturday");
            //            break;
            //        case 7:
            //            Console.WriteLine("Sunday");
            //            break;
            //        default:
            //            Console.WriteLine("Please Enter A Number Between 1 to 7");
            //            goto start;
            //    }

            //for(int i=1; i<=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 1; i<=10; i++)
            //{
            //    if(i%2== 0)
            //    {
            //        Console.WriteLine("Even Number");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Odd Number");
            //    }
            //    Console.WriteLine(i);
            //}

            //int NumB =  1;
            //while (NumB <= 10)
            //{
            //    Console.WriteLine(NumB);
            //    NumB++;
            //}

            //int NumB = 1;
            //do
            //{
            //    Console.WriteLine(NumB);
            //    NumB++;
            //}
            //while (NumB<=10);

            //for(int i = 0; i <= 5; i++)
            //{
            //    for(int j = 0; j<=i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 5; i >= 1; i--)
            //{
            //    for(int j =0; j<i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] Nums = new int[3] { 1, 2, 3 };
            //foreach (int i in Nums)
            //{
            //    Console.WriteLine(i);
            //}

            //string[] names = new string[3] { "shariq", "hamza", "bilal" };
            //foreach(string name in names)
            //{

            //Console.WriteLine(name); 
            //}

            //int[,] Nums = new int[3, 4]
            //{
            //    {0,1,2,3 },
            //    {4,5,6,7 },
            //    {8,9,10,11}
            //};
            //for(int i = 0; i < Nums.GetLength(0); i++)
            //{
            //    for(int j = 0; j < Nums.GetLength(1); j++)
            //    {
            //        Console.Write(Nums[i,j]+ " ");
            //    }
            //    Console.WriteLine();
            //}

            //string[,] std = new string[3, 3]
            //{
            //    {"shariq","hamza","bilal" },
            //    {"abdullah","ali","saqib" },
            //    {"nasir","wakeel","shoaib" }
            //};
            //for(int i = 0; i < std.GetLength(0); i++)
            //{
            //    for(int j = 0; j < std.GetLength(1); j++)
            //    {
            //        Console.Write(std[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //string[][] comp = new string[3][];
            //comp[0] = new string[] { "AirBus" };
            //comp[1] = new string[] { "Boeing", "Rolls Royce" };
            //comp[2] = new string[] { "Sukhoi", "Grumann", "Lockheed" };
            //for(int i = 0; i < comp.GetLength(0); i++)
            //{
            //    for(int j = 0; j < comp[i].GetLength(0); j++)
            //    {
            //        Console.Write(comp[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Today Practice

            //int[] num = new int[3] { 1, 2, 3 };
            //foreach(int i in num)
            //{
            //    Console.WriteLine(i);
            //}

            //int[,] num = new int[3, 3]
            //{
            //    {0,1,2},
            //    {3,4,5},
            //    {6,7,8}
            //};
            //for (int i = 0; i < num.GetLength(0); i++) 
            //{
            //    for(int j = 0; j < num.GetLength(1); j++)
            //    {
            //        Console.Write(num[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //string[][] std = new string[3][];
            //std[0] = new string[] { "Scharique" };
            //std[1] = new string[] { "Abdullah", "Noman" };
            //std[2] = new string[] { "Bilal", "Hamza", "Sawati" };
            //for (int i = 0; i < std.GetLength(0); i++) 
            //{
            //    for(int j = 0; j < std[i].GetLength(0); j++)
            //    {
            //        Console.Write(std[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}



        }
    }
}
