using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L16Function
    {
        public static void Lesson16()
        {
            var names = new List<string>();
            bool toList = true;
            bool toDecide = true;

            while (toList)
            {
                Console.Write("\nEnter Name (Type 'Exit' to finish: ");
                string input = Console.ReadLine();

                if (input.Equals("exit",StringComparison.OrdinalIgnoreCase))
                {
                    toList = false;
                }
                else
                {
                    names.Add(input.ToUpper());
                }
            }
            while (toDecide)
            {
                Console.WriteLine("\n\nType 'List' to See all Name | Type 'Search' to Find the name | Type 'Exit' to exit the lesson'\n");
                string decide = Console.ReadLine();

                if (decide.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    toDecide = false;
                }
                if (decide.Equals("search", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nEnter the name you want to find: ");
                    string findname = Console.ReadLine();

                    var namefound = names.IndexOf(findname.ToUpper());
                    if (namefound == -1)
                    {
                        Console.WriteLine("\nThe name you are looking for does not exist in the list.");
                    }
                    else
                    {
                        Console.WriteLine("\nThe name " + findname + " is in the list at index " + namefound);
                    }
                }
                if (decide.Equals("list", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n\nHere is the List of Names \n");
                    foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }
                }
            }

        }
        
    }
}
