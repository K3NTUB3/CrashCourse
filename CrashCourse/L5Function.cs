using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L5Function
    {
        public static void Lesson5()
        {
            bool toloop = true;
            string holder = "";
            float average;
            do
            {
                Console.Write("English Grade: ");
                float eng = Convert.ToSingle(Console.ReadLine());

                Console.Write("Math Grade: ");
                float math = Convert.ToSingle(Console.ReadLine());

                Console.Write("Science Grade: ");
                float sci = Convert.ToSingle(Console.ReadLine());

                Console.Write("Computer Grade: ");
                float comp = Convert.ToSingle(Console.ReadLine());

                average = (eng + math + sci + comp) / 4;

                if (average > 100)
                {
                    holder = "Invalid Grade";
                }
                else if (average >= 98)
                {
                    holder = "With Highest Honors";
                }
                else if (average >= 95)
                {
                    holder = "With High Honors";
                }
                else if (average >= 90)
                {
                    holder = "With Honors";
                }
                else if (average >= 75)
                {
                    holder = "Passed";
                }
                else
                {
                    holder = "Failed";
                }

                Console.WriteLine();

                Console.WriteLine("Hello! Your average is: " + average + ", " + holder);

            } while (toloop);
        }
    }
}
