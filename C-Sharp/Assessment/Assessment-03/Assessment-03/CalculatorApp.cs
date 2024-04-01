
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_03
{
    delegate double CalculatorDelegate(double x, double y);
    class CalculatorApp
    {
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;

        static void Main(string[] args)
        {

            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter 1 for addition, 2 for subtraction, or 3 for multiplication: ");
            int choice = int.Parse(Console.ReadLine());

            CalculatorDelegate operation;


            switch (choice)
            {
                case 1:
                    operation = Add;
                    break;
                case 2:
                    operation = Subtract;
                    break;
                case 3:
                    operation = Multiply;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting program.");
                    return;
            }


            double result = operation(num1, num2);


            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
}
