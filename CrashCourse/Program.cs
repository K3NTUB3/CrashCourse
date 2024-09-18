using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool toLoop = true;
            Console.WriteLine("[1]Hello World \n[2]Variables and DataTypes\n[3]Basic Input/Output\n" +
                "[4]Operators and Expression\n[5]Conditional Statement\n[6]Switch Statement\n" +
                "[7]Loops\n[8]Arrays\n[9]Functions\n" +
                "[10]Object-Oriented Programming\n[11]Inheritance\n[12]Encapsulation\n" +
                "[13]Polymorphism\n[14]Abstraction\n[15]Exception Handling\n" +
                "[16]Collections\n[17]Delegates and Events\n[18]Asynchronous Programming\n" +
                "[19]Working with Strings\n[20]Final Output\n[-1]Exit");

            while (toLoop)
            {
                Console.Write("\nPick a Lesson: ");
                int pick = Convert.ToInt32(Console.ReadLine());
                if (pick == -1)
                {
                    toLoop = false;
                    Console.WriteLine("That is all! Thank you!");
                }
                if (pick > 20)
                {
                    Console.WriteLine("The Introduction to C# Language only has 20 lessons.");
                }

                if (pick == 1)
                {
                    L1Function.Lesson1();
                }
                else if (pick == 2)
                {
                    L2Function.Lesson2();
                }
                else if (pick == 3)
                {
                    L3Function.Lesson3();
                }
                else if (pick == 4)
                {
                    L4Function.Lesson4();
                }
                else if (pick == 5)
                {
                    L5Function.Lesson5();
                }
                else if (pick == 6)
                {
                    L6Function.Lesson6();
                }
                else if (pick == 7)
                {
                    L7Function.Lesson7();
                }
                else if (pick == 8)
                {
                    L8Function.Lesson8();
                }
                else if (pick == 9)
                {
                    L9Function.Lesson9();
                }
                else if (pick == 10)
                {
                    L10Function.Lesson10();
                }
                else if (pick == 11)
                {
                    L11Function.Lesson11();
                }
                else if (pick == 12)
                {
                    L12Function.Lesson12();
                }
                else if (pick == 13)
                {
                    L13Function.Lesson13();
                }
                else if (pick == 14)
                {
                    L14Function.Lesson14();
                }
                else
                {
                    Console.WriteLine("Other lessons are to Follow :)");
                }
                
            }

        }

    }
}
