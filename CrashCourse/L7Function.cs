using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L7Function
    {
        public static void Lesson7()
        {
            string[] username = { "kenmac", "kentube", "kentucky" };
            string[] password = { "macken", "tubeken", "tuckyken" };
            bool isFound = false;

            Console.WriteLine("USER FINDER \n");

            Console.Write("Enter your username : ");
            string uname = Console.ReadLine();
            Console.Write("Enter your password : ");
            string pass = Console.ReadLine();

            for (int i = 0; i < username.Length; i++)
            {
                if (uname.Equals(username[i]) && pass.Equals(password[i]))
                {
                    isFound = true;
                    Console.WriteLine("Hello, " + username[i] + "!");
                    break;
                }

            }
            if (!isFound)
            {
                Console.WriteLine("Account not found.");
            }
        }
    }
}
