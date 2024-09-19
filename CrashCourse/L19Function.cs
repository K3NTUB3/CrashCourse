using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L19Function
    {
        public static async void Lesson19()
        {
            int count = 0;
            Console.WriteLine("Enter a String value: ");
            string input = Console.ReadLine();
            Console.WriteLine("\nProcessing... ");
            await Task.Delay(5000);
            Console.WriteLine("\nSending details in a bit... ");
            await Task.Delay(5000);
            Console.WriteLine("\nGot it... ");
            await Task.Delay(5000);
            Console.WriteLine("\nYour input was: "+input);
            await Task.Delay(3000);
            Console.WriteLine("\nAll in all it has: " + input.Length + " characters (including the space if it does have one)");
            await Task.Delay(3000);
            Console.WriteLine("\nIf you put .ToLower() in it the output will become: " + input.ToLower());
            await Task.Delay(3000);
            Console.WriteLine("\nIf you put .ToUpper() in it the output will become: " + input.ToUpper());
            await Task.Delay(3000);
            Console.WriteLine("Each characters are also represented by numbers. Like this... ");
            foreach (char letter in input)
            {
                count++;
                await Task.Delay(3000);
                Console.WriteLine(count +" : " + letter);
                await Task.Delay(2000);
            }
            Console.WriteLine("Press any key to continue... ");

        }
        
    }
}
