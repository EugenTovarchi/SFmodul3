using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFmodul3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string name = "Jane";
            byte age = 27;
            bool pet = true;
            double footSize = 37.5;

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"My age is {age}");
            Console.WriteLine($"Do I have a pet? {pet}");
            Console.WriteLine($"My shoe size is {footSize}");

            Console.ReadLine();

        }
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }

    }

}