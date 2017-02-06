using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_1
{
    class PartA
    {
        static void Main(string[] args)
        {
            //C# workshop a Qns. 1

            Console.WriteLine("Heng Tiong");
            Console.WriteLine("E0167134@u.nus.edu");

            //C# workshop a Qns. 2

            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Good morning " + name);

            //C# workshop a Qns. 3

            Console.Write("\nPlease input an integer ");
            double numInt;
            if (double.TryParse(Console.ReadLine(), out numInt))
            {
                Console.WriteLine(Math.Pow(numInt, 2));
            }
            else
                Console.WriteLine("invalid input");
            //            double result = Math.Pow((numInt), 2);
            //            Console.WriteLine("Your result is " + result);

            //C# workshop a Qns. 4

            Console.Write("\nPlease input a double precision number ");
            double numDouble = double.Parse(Console.ReadLine());
            Console.WriteLine("Your result is " + Math.Sqrt(numDouble));

            //C# workshop a Qns. 5
            Console.Write("\nPlease input a double precision number ");
            double numDouble2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Your result is " + Math.Round(numDouble2, 2));
        }
    }
}
