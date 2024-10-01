using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Animal
    {
        public string Name;
        public string Eat;
        public string Noise;
        public abstract void PrintMsg();
    }

    class Cat : Animal
    {
        public override void PrintMsg()
        {
            Console.WriteLine("This animal is : " + Name);
            Console.WriteLine(Name + " eats: "+ Eat);
            Console.WriteLine(Name + " noise is: " + Noise);
        }
    }

    class Dog : Animal
    {
        public override void PrintMsg()
        {
            Console.WriteLine("This animal is : " + Name);
            Console.WriteLine(Name + " eats: " + Eat);
            Console.WriteLine(Name + " noise is: " + Noise);
        }
    }

    class Lion : Animal
    {
        public override void PrintMsg()
        {
            Console.WriteLine("This animal is : " + Name);
            Console.WriteLine(Name + " eats: " + Eat);
            Console.WriteLine(Name + " noise is: " + Noise);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Cat";
            cat.Eat = "Rats";
            cat.Noise = "Meow";
            cat.PrintMsg();

            Dog dog = new Dog();
            dog.Name = "Dog";
            dog.Eat = "Chicken";
            dog.Noise = "Barking Bow";
            dog.PrintMsg();
            Lion lion = new Lion();
            lion.Name = "Lion";
            lion.Eat = "Meat";
            lion.Noise = "Roar";
            lion.PrintMsg();
        }
    }
}
