using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dict = new Dictionary<string,string>();
            dict.Add("Computer", "A computer is a machine that can be programmed to automatically carry out sequences of arithmetic or logical operations ");
            dict.Add("Programming", "Programming is the process of creating a set of instructions that tell a computer how to perform a task.");
            dict.Add("IT", "Information technology (IT) is a broad field that includes the use of computers and other technologies to manage, store, and exchange information");

            //Console.WriteLine(dict["Computer"]);
            foreach(KeyValuePair<string,string> item in dict)
            {
                Console.WriteLine("Key are: " + item.Key + " Value are: " + item.Value);
            }
        }
    }
}
