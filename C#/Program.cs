using System;

namespace Calculators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What math operation would you like to perform? (+,-,*,/,%)");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter a number for X");
            float num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number for Y");
            float num2 = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case "+":
                    Console.WriteLine(num3 + num4);
                    break;
                case "-":
                    Console.WriteLine(num3 - num4);
                    break;
                case "*":
                    Console.WriteLine(num3 * num4);
                    break;
                case "/":
                    Console.WriteLine(num3 / num4);
                    break;
                case "%":
                    Console.WriteLine(num3 % num4);
                default:
                    Console.WriteLine("Unrecognized Operation {}", operation);
                    break;
            }
        }
    }
}
