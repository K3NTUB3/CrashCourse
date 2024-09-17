using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L8Function
    {
        public static void Lesson8()
        {
            string[] email = { "index0@helloworld",
     "index1@helloworld", "index2@helloworld" };

            string[] username = {"dexIN_0","dexIN_1",
     "dexIN_2" };

            string[] password = {"index0Password",
     "index2Password", "index3Password"};

            bool islooping = true;
            do
            {
                try
                {
                    Console.Write("Index    : ");
                    int arr = Convert.ToInt32(Console.ReadLine());
                    if (arr == -1)
                    {
                        islooping = false;
                    }
                    else if (arr >= 3 || arr < 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("The allowed number is 0 - 2");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Email    : " + email[arr]);
                        Console.WriteLine("Username : " + username[arr]);
                        Console.WriteLine("Password : " + password[arr]);
                        Console.WriteLine();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    Console.WriteLine();
                }
            } while (islooping);

            Console.WriteLine("Loop terminated.");
        }

    }
}


