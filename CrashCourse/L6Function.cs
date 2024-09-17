using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L6Function
    {
        public static void Lesson6()
        {
            bool ismonth = true;
            bool isday = true;
            int month;
            int day;
            int year;
            do
            {
                Console.Write("Month : ");
                month = Convert.ToInt32(Console.ReadLine());
                if (month > 12)
                {
                    Console.WriteLine("Invalid Month!");
                }
                else
                {
                    ismonth = false;
                    continue;
                }
            } while (ismonth);
            do
            {
                Console.Write("Date  : ");
                day = Convert.ToInt32(Console.ReadLine());

                if (day > 31)
                {
                    Console.WriteLine("Invalid Date!");
                }
                else
                {
                    isday = false;
                    continue;
                }
            } while (isday);

            Console.Write("Year  : ");
            year = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("January " + day + ", " + year);
                    break;
                case 2:
                    Console.WriteLine("February " + day + ", " + year);
                    break;
                case 3:
                    Console.WriteLine("March " + day + ", " + year);
                    break;
                case 4:
                    Console.WriteLine("April " + day + ", " + year);
                    break;
                case 5:
                    Console.WriteLine("May " + day + ", " + year);
                    break;
                case 6:
                    Console.WriteLine("June " + day + ", " + year);
                    break;
                case 7:
                    Console.WriteLine("July " + day + ", " + year);
                    break;
                case 8:
                    Console.WriteLine("August " + day + ", " + year);
                    break;
                case 9:
                    Console.WriteLine("September " + day + ", " + year);
                    break;
                case 10:
                    Console.WriteLine("October " + day + ", " + year);
                    break;
                case 11:
                    Console.WriteLine("November " + day + ", " + year);
                    break;
                case 12:
                    Console.WriteLine("December " + day + ", " + year);
                    break;

                default:
                    Console.WriteLine("Invalid Month!");
                    break;
            }

        }
    }
}
