using System;

namespace Calculators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What math operation would you like to perform? (+,-,*,/");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter a number for X");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter a number for Y");
            string num2 = Console.ReadLine();
            float num3 = Convert.ToInt32(num1);
            float num4 = Convert.ToInt32(num2);
            switch (operation)
            {
                case "+":
                    Addition(num3, num4);
                    break;

                case "-":
                    Subtraction(num3, num4);
                    break;

                case "*":
                    Multiplication(num3, num4);
                    break;

                case "/":
                    Division(num3, num4);
                    break;
                
                default:
                    break;
            }
        }

        static void Addition(float num3, float num4)
        {
            Console.WriteLine(num3 + num4);
        }

        static void Subtraction(float num3, float num4)
        {
            Console.WriteLine(num3 - num4);
        }

        static void Multiplication(float num3, float num4)
        {
            Console.WriteLine(num3 * num4);
        }

        static void Division(float num3, float num4)
        {
            Console.WriteLine(num3 / num4);
        }
    }
}
