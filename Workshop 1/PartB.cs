using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_1
{
    class PartB
    {
        static void Main(string[] args)
        {
            //C# Workshop 1B Qns. 1

            Console.Write("Please input a double precision number ");
            double numDouble = double.Parse(Console.ReadLine());
            Console.WriteLine("The answer is " + Math.Sqrt(numDouble));

            //C# Workshop 1B Qns. 2

            Console.Write("\nPlease input a double precision number ");
            double numDouble2 = double.Parse(Console.ReadLine());
            numDouble2 = Math.Sqrt(numDouble2);
            //Console.WriteLine("The answer is " + Math.Round(numDouble2, 3));
            Console.WriteLine("The answer is {0:0.00}", numDouble2);

            //C# Workshop 1B Qns. 3

            Console.Write("\nPlease input your salary ");
            double salary = double.Parse(Console.ReadLine());
            salary = salary + (salary * 0.1) + (salary * 0.03);
            Console.WriteLine("Your total income is " + salary.ToString("C"));

            //C# Workshop 1B Qns. 4

            Console.Write("\nPlease input temperature in Celcius ");
            double temperatureC = double.Parse(Console.ReadLine());
            double temperatureF = temperatureC * 1.8 + 32;
            Console.WriteLine("The temperature is " + temperatureF + " in Farenheit");

            //C# Workshop 1B Qns. 5

            Console.Write("\nPlease input the X value ");
            double xValue = double.Parse(Console.ReadLine());
            double yValue = (5 * xValue * xValue - 4 * xValue + 3);
            Console.WriteLine("The value of y is " + yValue);

            //C# Workshop 1B Qns. 6

            Console.Write("\nPlease input X1, X2, Y1, and Y2, all separated by a \" \" (X1 X2 Y1 Y2): ");
            String xyValue = Console.ReadLine();
            String xValue1String = xyValue.Split(' ')[0];
            String xValue2String = xyValue.Split(' ')[1];
            String yValue1String = xyValue.Split(' ')[2];
            String yValue2String = xyValue.Split(' ')[3];
            double xValue1 = double.Parse(xValue1String);
            double xValue2 = double.Parse(xValue2String);
            double yValue1 = double.Parse(yValue1String);
            double yValue2 = double.Parse(yValue2String);

            double resultXY = Math.Sqrt(Math.Pow((xValue2 - xValue1), 2) +
                (Math.Pow((yValue2 - yValue1), 2)));
            Console.WriteLine("The distance between the two point is " + resultXY);

            //C# Workshop Qns. 7
            double minFixedCharge = 2.40;
            Console.Write("\nWhat is the distance travelled? ");
            double distanceTravelled = double.Parse(Console.ReadLine());
            Console.WriteLine("Total fare for taxi ride is " + (minFixedCharge + distanceTravelled * 0.40));

            //C# Workshop Qns. 8
            Console.Write("\nWhat is the distance travelled? ");
            distanceTravelled = double.Parse(Console.ReadLine());
            double resultFare = Math.Round((minFixedCharge + distanceTravelled * 0.40), 1);
            Console.WriteLine("Total fare for taxi ride is {0:0.00}", resultFare);

            //C# Workshop Qns. 9
            Console.Write("\nWhat is the distance travelled? ");
            distanceTravelled = double.Parse(Console.ReadLine());
            resultFare = Math.Ceiling((minFixedCharge + distanceTravelled * 0.40) * 10) / 10;
            Console.WriteLine("Total fare for taxi ride is {0:0.0}", resultFare);

            //C# Workshop Qns. 10
            Console.Write("\nInput the lengths of the 3 sides, separated by \" \", (a b c) ");
            String triangleABC = Console.ReadLine();
            double sideA = double.Parse(triangleABC.Split(' ')[0]);
            double sideB = double.Parse(triangleABC.Split(' ')[1]);
            double sideC = double.Parse(triangleABC.Split(' ')[2]);
            double totalS = (sideA + sideB + sideC) / 2;
            double area;
            if (((totalS - sideA) <= 0) || ((totalS - sideB) <= 0) || ((totalS - sideC) <= 0))
            {
                Console.WriteLine("Invalid parameters");
            }
            else
            {
                area = Math.Sqrt(totalS * (totalS - sideA) * (totalS - sideB) * (totalS - sideC));
                Console.WriteLine("The area of the triangle is " + area);
            }
        }
    }
}
