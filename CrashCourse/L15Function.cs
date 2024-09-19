using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L15Function
    {
        public static void Lesson15()
        {
            bool isloop = true;

            Console.WriteLine("\n\nSimple Division With Error Handling!\n");

            while (isloop)
            {
                try
                {

                    Console.Write("\nEnter a Numerator (OR type 'EXIT' to Exit) : ");
                    string input = Console.ReadLine();
                    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Exiting the program.");
                        break;
                    }
                    if (int.TryParse(input, out int number))
                    {
                        int numerator = number;

                        Console.Write("Enter a Denominator                       : ");
                        int denominator = int.Parse(Console.ReadLine());

                        Division div = new Division(numerator, denominator);
                        div.PerformDiv();
                    } 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ivalid. Input should be 'Integer'. ");
                }
            }

        }
    }
    class Division
    {
        private int numerator, denominator;

        public Division(int numerator, int denominator)
        {
            try
            {
                this.numerator = numerator;

                if (denominator ==0)
                {
                    throw new DivideByZeroException("Can't Divide a number by zero. Please enter a value greater than zero");
                }
                this.denominator = denominator;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("\nError: " + ex.Message);
            }
           
        }
        public void PerformDiv()
        {
            try
            {
                int result = numerator / denominator;
                Console.WriteLine("Quotient: " + result);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + "\n");
            }
        }
    }
}
