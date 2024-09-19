using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L17Function
    {
        public static void Lesson17()
        {
            Command command = new Command();
            EventListener listener = new EventListener();

            command.StartCommand += listener.OnStartCommand;

            Console.WriteLine("\n\nSimple Use of Events and Delegates\n");

            while (true)
            {
                Console.Write("Enter a command (or type 'exit' to stop): ");
                string input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                
                command.ProcessInput(input);
            }
        }
    }
    class Command
    {
        public delegate void CommandHandler();

        public event CommandHandler StartCommand;

        public void ProcessInput(string input)
        {
            if (input.Equals("start", StringComparison.OrdinalIgnoreCase))
            {
                StartCommand?.Invoke();
            }
            else
            {
                Console.WriteLine($"Command '{input}' not recognized.");
            }
        }
    }
    class EventListener
    {
        
        public void OnStartCommand()
        {
            Console.WriteLine("Start command received! Commencing Operation... ");
        }
    }
}
