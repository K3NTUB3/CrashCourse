using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L3Function
    {
        public static void Lesson3()
        {
            Console.Write("Name      : ");
            string name = Console.ReadLine();

            Console.Write("Location  : ");
            string location = Console.ReadLine();

            Console.Write("College   : ");
            string education = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Hello! My name is " + name + "\nI am from " + location + "\nI am currently studying in " + education);
        }
    }
}
