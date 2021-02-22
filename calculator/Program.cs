using System;

namespace calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // Call Options() method
            //Options();
            Console.WriteLine(GetDay(2));
            Console.WriteLine(dir);

            // Exit
            Console.ReadLine();

        }
        static void Options()
        {
            Console.Write("Addition: 1;"+ Environment.NewLine+"Subtraction: 2"+Environment.NewLine+"Moltiplication: 3"+Environment.NewLine+"Division: 4"+Environment.NewLine+"Insert Number -> ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            // Addition
            if (input1 == 1)
            {
                Console.Write("Enter first number: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(a+b);
            }
            // Subtraction
            if (input1 == 2)
            {
                Console.Write("Enter first number: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(a-b);
            }
            // Moltiplication
            if (input1 == 3)
            {
                Console.Write("Enter first number: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(a*b);
            }
            // Division
            if (input1 == 4)
            {
                Console.Write("Enter first number: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(a/b);
            }
        }
        
        static string GetDay(int DayNum) 
        {
            string DayName;

            switch(DayNum)
            {
                default:
                    DayName = "Invalid day number!";
                    break;
                case 1:
                    DayName = "Monday";
                    break;
                case 2:
                    DayName = "Tuesday";
                    break;
                case 3:
                    DayName = "Wednesday";
                    break;
                case 4:
                    DayName = "Thursday";
                    break;
                case 5:
                    DayName = "Friday";
                    break;
                case 6:
                    DayName = "Saturday";
                    break;
                case 7:
                    DayName = "Sunday";
                    break;
            }

            return DayName;
        }
    }
}
