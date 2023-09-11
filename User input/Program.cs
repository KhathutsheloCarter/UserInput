using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name ");
            String name = Console.ReadLine();
            Console.WriteLine("Hi " + name);

            Console.Write("Enter your Age");
            int age = convert.ToInt32(Console.ReadLine());

            Console.Write("you have " + age + "years");

           
            Console.ReadLine();
        }
    }
}
