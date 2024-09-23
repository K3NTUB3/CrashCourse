using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L20Function
    {
        public static void Lesson20()
        {
            TaskManager taskManager = new TaskManager();
            TaskNotifier notifier = new TaskNotifier();

            taskManager.OnTaskCompleted += async (message) => await notifier.NotifyCompletion(message);

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n[1] ADD TASK  |  [2] DO TASK  |  [3] COMPLETED TASKS  |  [4] EXIT");
                Console.Write("\nCHOOSE: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("\nEnter task: ");
                        string task = Console.ReadLine();
                        taskManager.AddTask(task);
                        break;

                    case "2":
                        taskManager.DisplayTasks();
                        break;

                    case "3":
                        taskManager.DisplayCompletedTasks();
                        break;

                    case "4":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

            Console.WriteLine("\nGoodbye!");
        }
    }
    }
    public class TaskManager
    {
    private List<string> tasks = new List<string>();
    private List<string> completedtasks = new List<string>();

    public delegate void TaskCompletedHandler(string message);
        public event TaskCompletedHandler OnTaskCompleted;

        public void AddTask(string task)
        {
            tasks.Add(task);
            Console.WriteLine("\nTask " + task + " is addedd successfully!\n");
        }

        public void CompleteTask(int index)
        {
            try
            {
            index += -1;
  
                if (index < 0 || index >= tasks.Count)
                {
                    throw new IndexOutOfRangeException("\nTask index out of range. Press any key to continue... \n");
                }

                string completedTask = (string)tasks[index];
                completedtasks.Add(completedTask);
                tasks.RemoveAt(index);
                OnTaskCompleted?.Invoke("Task " + completedTask + " is completed! Press any key to continue... ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void DisplayTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("\nNO TASKS AVAILABLE");
            }
            else
            { 
                Console.WriteLine("\nCurrent Tasks:");
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tasks[i]}");
                    }
                Console.Write("\nEnter the index of the task to complete: ");
                if (int.TryParse(Console.ReadLine(), out int index))
                {
                    if (index <= 0)
                    {
                        Console.WriteLine("\nTask Completion Canceled\n");
                    }
                    else
                    {
                        CompleteTask(index);
                        Console.ReadKey();
                    }    
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a number.");
                }
            }
            
        }
        public void DisplayCompletedTasks()
        {
            if (!completedtasks.Any())
            {
                Console.WriteLine("\nYou didnt finish any tasks yet.\n");
            }
            else
            {
                Console.WriteLine("\nCompleted Tasks: \n");
                for (int i = 0; i < completedtasks.Count; i++)
                {
                Console.WriteLine((i + 1) + ". " + completedtasks[i]);
                Console.WriteLine("Press any key to continue... ");
                Console.ReadKey();
            }
        }
        }
    }
    public class TaskNotifier
    {
        public async Task NotifyCompletion(string message)
        {
            Console.WriteLine("Doing the task... \n");
            await Task.Delay(3000);
            Console.WriteLine("Finishing up... \n");
            await Task.Delay(2000);
            Console.WriteLine("Almost there... \n");
            await Task.Delay(1000);
            Console.WriteLine(message);
        }
    }
