using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L4Function
    {
        public static void Lesson4()
        {
            Console.Write("English Grade: ");
            float eng = Convert.ToSingle(Console.ReadLine());

            Console.Write("Math Grade: ");
            float math = Convert.ToSingle(Console.ReadLine());

            Console.Write("Science Grade: ");
            float sci = Convert.ToSingle(Console.ReadLine());

            Console.Write("Computer Grade: ");
            float comp = Convert.ToSingle(Console.ReadLine());

            float average = (eng + math + sci + comp) / 4;

            Console.WriteLine();

            Console.WriteLine("Hello! Your average is: " + average);
        }
    }
}
