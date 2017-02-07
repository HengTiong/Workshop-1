using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_1
{
    class PartC
    {
        public static void Main ()
        {
            ////C# Workshop 1C Qns. 1
            //Console.Write("Please input your name, followed by your Gender (M/F) after a space ");
            //string nameGender = Console.ReadLine();
            //string gender = nameGender.Split(' ')[1].ToUpper();
            //string name = nameGender.Split(' ')[0].ToUpper();
            //if (gender == "M")
            //{
            //    Console.WriteLine("Good morning Mr " + name);
            //}
            //else if (gender == "F")
            //{
            //    Console.WriteLine("Good morning Ms " + name);
            //}
            //else
            //    Console.WriteLine("Invalid input");

            ////C# Workshop 1C Qns. 2
            //Console.Write("\nPlease input your name, followed by your Gender (M/F) after a space, followed by your age after a space ");
            //string nameGenderAge = Console.ReadLine();
            //gender = nameGender.Split(' ')[1].ToUpper();
            //name = nameGender.Split(' ')[0].ToUpper();
            //int age = Int32.Parse(nameGenderAge.Split(' ')[2]);
            //if (gender == "M")
            //{
            //    if (age >= 40)
            //        Console.WriteLine("Good morning Uncle " + name);
            //    else
            //        Console.WriteLine("Good morning Mr " + name);
            //}
            //else if (gender == "F")
            //{
            //    if (age >= 40)
            //        Console.WriteLine("Good morning Auntie " + name);
            //    else
            //        Console.WriteLine("Good morning Ms " + name);
            //}
            //else
            //    Console.WriteLine("Invalid input");

            ////C# Workshop 1C Qns. 3
            //Console.Write("\nPlease input your grades ");
            //int marks = Int32.Parse(Console.ReadLine());
            //char grade;
            //if (marks < 0)
            //    grade = 'U';
            //else if (marks >= 0 && marks <= 40)
            //    grade = 'F';
            //else if (marks > 40 && marks < 60)
            //    grade = 'C';
            //else if (marks >= 60 && marks < 80)
            //    grade = 'B';
            //else if (marks >= 80 && marks < 100)
            //    grade = 'A';
            //else grade = 'U';

            //if (grade == 'U')
            //    Console.WriteLine("Invalid marks input");
            //else
            //    Console.WriteLine("You scored " + marks + " which is a " + grade);

            ////C# Workshop 1C Qns. 4
            //Console.Write("\nPlease input total distance travelled ");
            //double distanceTravalled = double.Parse(Console.ReadLine());
            //distanceTravalled = Math.Ceiling(distanceTravalled * 10) /  10;
            //double fixedCharge = 2.4;
            //double totalFare;
            //if (distanceTravalled > 9)
            //    totalFare = fixedCharge + (8.5 * 0.4) + ((distanceTravalled - 9) * 0.5);
            //else if (distanceTravalled > 5)
            //    totalFare = fixedCharge + (distanceTravalled * 0.4);
            //else
            //    totalFare = fixedCharge;
            //Console.WriteLine("The total fare for the taxi is " + totalFare);

            ////C# Workshop 1C Qns. 5
            //Console.Write("\nPlease input a three digit number to determine if it is an Armstrong Number ");
            //string armstrongInput = Console.ReadLine();
            //double armstrong1 = Char.GetNumericValue(armstrongInput[0]);
            //double armstrong2 = Char.GetNumericValue(armstrongInput[1]);
            //double armstrong3 = Char.GetNumericValue(armstrongInput[2]);
            //double armstrongResult = double.Parse(armstrongInput);
            //if ((armstrong1 * 100 + armstrong2 * 10 + armstrong3) == armstrongResult)
            //    Console.WriteLine("The result is True");
            //else
            //    Console.WriteLine("The result is False");

            //C# Workshop 1C Qns. 6
            string productCode;
            double tvOrder = 0;
            double mp3Order = 0;
            double dvdOrder = 0;
            int i = 0;
            double discountPercent = 0;
            double discountPrice;

            while (i <3)
            {
                Console.Write("Please input product code: ");
                productCode = Console.ReadLine();
                switch (productCode.ToUpper())
                {
                    case "TV":
                        Console.Write("What is the order quantity? ");
                        tvOrder = double.Parse(Console.ReadLine());
                        i++;
                        break;
                    case "DVD":
                        Console.Write("What is the order quantity? ");
                        dvdOrder = double.Parse(Console.ReadLine());
                        i++;
                        break;
                    case "MP3":
                        Console.Write("What is the order quantity? ");
                        mp3Order = double.Parse(Console.ReadLine());
                        i++;
                        break;
                    default:
                        Console.WriteLine("Invalid product code");
                        break;
                }
            }
            double beforeDiscount = (tvOrder * 900) + (dvdOrder * 500) + (mp3Order * 700);
            Console.WriteLine(beforeDiscount);
            if (beforeDiscount > 10000)
                discountPercent = (1 - 0.15);
            else if ((beforeDiscount > 5000) && (beforeDiscount <= 10000))
                discountPercent = (1 - 0.10);
            else
                discountPercent = 1;

            discountPrice = (tvOrder * 900 * discountPercent) + (dvdOrder * 500 * discountPercent) + (mp3Order * 700);
            Console.WriteLine("The final price is: " + discountPrice);
        }
    }
}
