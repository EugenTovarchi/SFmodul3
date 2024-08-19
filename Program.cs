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


            Console.WriteLine($"What is your name is name?");
            var name = Console.ReadLine();
            Console.WriteLine($"What is your age?");
            var age = (byte) int.Parse( Console.ReadLine() );
            
            Console.WriteLine("What is your favorite day?");
            var dayOfWeek = (DayOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine($"My favorite day is: {dayOfWeek}");

            int digit = 5;
            byte convertDigit = (byte)digit;

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