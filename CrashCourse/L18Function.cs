using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L18Function
    {
        public static async void Lesson18()
        {
            Console.WriteLine("\n\nSimple Asynchronous Task\n");
            Console.WriteLine("Starting house construction...");
            await Task.Delay(3000);
            Task foundationTask = LayFoundationAsync();
            await Task.Delay(5000);
            Task wallsTask = BuildWallsAsync();
            await Task.Delay(5000);
            Task roofTask = AddRoofAsync();
            await Task.Delay(5000);

            await Task.WhenAll(foundationTask, wallsTask, roofTask);

            Console.WriteLine("House construction completed!\nPress any key to continue... ");
        }
        static async Task LayFoundationAsync()
        {
            Console.WriteLine("Laying foundation...");
            await Task.Delay(5000);
            Console.WriteLine("Foundation completed!");
        }

        
        static async Task BuildWallsAsync()
        {
            Console.WriteLine("Building walls...");
            await Task.Delay(5000);
            Console.WriteLine("Walls completed!");
        }

        
        static async Task AddRoofAsync()
        {
            Console.WriteLine("Adding roof...");
            await Task.Delay(5000); 
            Console.WriteLine("Roof completed!");
        }
    }
}
