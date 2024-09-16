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
            Console.WriteLine("[1] \n[2]\n[3]\n" +
                "[4]\n[5]\n[6]\n" +
                "[7]\n[8]\n[9]\n" +
                "[10]\n[11]\n[12]\n" +
                "[13]\n[14]\n[15]\n" +
                "[16]\n[17]\n[18]\n" +
                "[19]\n[20]\n");
            Console.Write("Pick a Lesson: "); 
            int pick = Convert.ToInt32(Console.ReadLine());

            if (pick ==1)
            {
                ccFunction.lesson1();
            }
            else if (pick == 2)
            {
                ccFunction.lesson2();
            }
            else if (pick == 3)
            {
                ccFunction.lesson3();
            }
            else if (pick == 4)
            {
                ccFunction.lesson4();
            }
            else if (pick == 5)
            {
                ccFunction.lesson5();
            }
            else if (pick == 6)
            {
                ccFunction.lesson6();
            }
            else if (pick == 7)
            {
                ccFunction.lesson7();
            }
            else if (pick == 8)
            {
                ccFunction.lesson8();
            }
            else if (pick == 9)
            {
                ccFunction.lesson9();
            }
            if (pick > 20)
            {
                Console.WriteLine("The Introduction to C# Language only has 20 lessons.");
            }
            else { Console.WriteLine("Other Lessons are to Follow :)"); }


        }

    }
}
