// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello Shariq Najam");
int a = 20;
int b = 30;
int c = a + b;
Console.WriteLine("the result is " + a + " + " + b + " = " + c);
int d = 30;
int e = 50;
int f = d + e;
Console.WriteLine($"the result is {d} + {e} = {f}");

// if else conditional statement
int num = 10;
if(num % 2 == 0)
{
    Console.WriteLine("Even Number");
}
else
{
    Console.WriteLine("Odd Number");
}

// if else statement ladder to know about greater, medium and smallest number

/*
Console.WriteLine("Please Enter Your First Number");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter Your Second Number");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter Your Third Number");
int z = Convert.ToInt32(Console.ReadLine());

if(x == y && y == z)
{
    Console.WriteLine("All the values are same");
} 
else if(x == y && x < z) 
{
    Console.WriteLine("Third value is the greatest "+z);
    Console.WriteLine("First and second value are same -> x " +x+" -> y "+y);
}
else if (x == y && x > z)
{
    Console.WriteLine("Third value is the smallest " + z);
    Console.WriteLine("First and second value are same -> x " + x + " -> y " + y);
}
else if (z == y && z < x)
{
    Console.WriteLine("First value is the greatest " + x);
    Console.WriteLine("Second and third value are same -> y " + y + " -> z " + z);
}
else if (z == y && z > x)
{
    Console.WriteLine("First value is the samllest " + x);
    Console.WriteLine("Second and third value are same -> y " + y + " -> z " + z);
}
else if (z == x && z < y)
{
    Console.WriteLine("Second value is the greatest " + y);
    Console.WriteLine("First and third value are same -> x " + x + " -> z " + z);
}
else if (z == x && z > y)
{
    Console.WriteLine("Second value is the samllest " + y);
    Console.WriteLine("First and third value are same -> x " + x + " -> z " + z);
}
else if (x >= y && x >= z)
{
    Console.WriteLine("First Number is Greater and the value of First Number is " + x);
    if (y >= z)
    {
        Console.WriteLine("Second Number is Medium and the value of Second Number is " + y);
        Console.WriteLine("Third Number is Smaller and the value of Third Number is " + z);
    }
    else
    {
        Console.WriteLine("Third Number is Medium and the value of Second Number is " + z);
        Console.WriteLine("Second Number is Smaller and the value of Third Number is " + y);
    }
}
else if (y >= x && y >= z)
{
    Console.WriteLine("Second Number is Greater and the value of Second Number is " + y);
    if (x >= z)
    {
        Console.WriteLine("First Number is Medium and the value of First Number is " + x);
        Console.WriteLine("Third Number is Smaller and the value of Third Number is " + z);
    }
    else
    {
        Console.WriteLine("First Number is Medium and the value of First Number is " + z);
        Console.WriteLine("Third Number is Smaller and the value of Third Number is " + x);
    }
}
else if (z >= x && z >= y)
{
    Console.WriteLine("Third Number is Greater and the value of Third Number is " + z);
    if (x >= y)
    {
        Console.WriteLine("First Number is Medium and the value of First Number is " + x);
        Console.WriteLine("Second Number is Smaller and the value of Second Number is " + y);
    }
    else
    {
        Console.WriteLine("Second Number is Medium and the value of First Number is " + y);
        Console.WriteLine("First Number is Smaller and the value of Second Number is " + x);
    }
}
*/


// a number which is divisible by 3,5 and 9

/*
Console.WriteLine("Please Enter A Number");
int numdiv = Convert.ToInt32(Console.ReadLine());
if (numdiv %3 == 0 && numdiv % 5 == 0 && numdiv % 9 == 0)
{
    Console.WriteLine("it is dividable by all 3,5,9");
}
else if(numdiv % 3 == 0 && numdiv % 5 == 0)
{
    Console.WriteLine("it is dividable by 3,5");
}
else if(numdiv %9 == 0 && numdiv % 5 == 0)
{
    Console.WriteLine("it is dividable by 5,9");
}
else if (numdiv % 9 == 0 && numdiv % 3 == 0)
{
    Console.WriteLine("it is dividable by 3,9");
}
else if (numdiv % 3 == 0)
{
    Console.WriteLine("it is dividable by 3");
}
else if (numdiv % 5 == 0)
{
    Console.WriteLine("it is dividable by 5");
}
else if (numdiv % 9 == 0)
{
    Console.WriteLine("it is dividable by 9");
}
else
{
    Console.WriteLine("The given number is not divisible by 3,5,9");
}
*/

//for loop

//for (int i = 1; i <=10; i++)
//{
//    if (i <= 5)
//    {
//        Console.WriteLine(i + " Floor");
//        Thread.Sleep(1000);
//    }
//    else 
//    {   Console.WriteLine(11-i + " Floor");
//        Thread.Sleep(1000);
//    }
//}

// while loop

//int val1 = 1;
//while (val1 <= 10)
//{
//    Console.WriteLine(val1);
//    val1++;
//}

int [,] arr = { { 1, 2, 3 }, { 4, 5, 6} };

for(int i =0; i<2; i++)
{
    for (int j = 0; j <3; j++)
    {
        Console.WriteLine(arr[i,j]);
    }
    Console.WriteLine();
}
