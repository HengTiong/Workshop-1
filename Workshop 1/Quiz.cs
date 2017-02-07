using System;

namespace Workshop_1
{
    class Quiz
    {
        public static void Main()
        {
            Console.Write("Please enter the length in cm: ");
            double length = double.Parse(Console.ReadLine());
            double result = (length / 2.54);
            Console.WriteLine("{0:0.000}", result);
        }
    }
}
