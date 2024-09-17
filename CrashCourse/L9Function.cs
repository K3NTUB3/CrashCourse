using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L9Function
    {
        public static void Lesson9()
        {
            Console.WriteLine("SIMPLE CALCULATOR");

            int total = 0;
            bool con = true;
            bool firstNumber = true;
            string operand;

            while (con)
            {
                if (firstNumber)
                {
                    Console.Write("Enter the first number: ");
                    total = Convert.ToInt32(Console.ReadLine());
                    firstNumber = false;
                }

                Console.Write("Enter an Operand (+, -, *, /, = to get result): ");
                operand = Console.ReadLine();

                if (operand == "=")
                {
                    con = false;
                    Console.WriteLine("Total: " + total);
                }
                else
                {
                    Console.Write("Enter the next number: ");
                    int nextNum = Convert.ToInt32(Console.ReadLine());
                    total = PerformOperation(total, nextNum, operand);
                }
            }
        }

        static int PerformOperation(int total, int number, string operand)
        {
            switch (operand)
            {
                case "+":
                    return Add(total, number);
                case "-":
                    return Subtract(total, number);
                case "*":
                    return Multiply(total, number);
                case "/":
                    if (number == 0)
                    {
                        Console.WriteLine("Cannot divide by zero. Ignoring operation.");
                        return total;
                    }
                    return Divide(total, number);
                default:
                    Console.WriteLine("Invalid operand. Operation ignored.");
                    return total;
            }
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
