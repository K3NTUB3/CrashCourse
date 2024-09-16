using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class ccFunction
    {
        public static void lesson1()
        {
            Console.WriteLine("World, Hello!");
        }

        public static void lesson2()
        {
            string name = "Kenneth Macalinao";
            int age = 24;
            float gpa = 2.25f;
            char gender = 'M';

            Console.WriteLine("Hi! My name is " + name);
            Console.WriteLine("I am " + age + " years old");
            Console.WriteLine("My sex is " + gender);
            Console.WriteLine("My GPA is " + gpa);
        }

        public static void lesson3()
        {
            Console.Write("Name      : ");
            string name = Console.ReadLine();

            Console.Write("Location  : ");
            string location = Console.ReadLine();

            Console.Write("College   : ");
            string education = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Hello! My name is " + name + "\nI am from " + location + "\nI am currently studying in " + education);
        }

        public static void lesson4()
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

        public static void lesson5()
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

        public static void lesson6()
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

        public static void lesson7()
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

        public static void lesson8()
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

        public static void lesson9()
        {
            Console.WriteLine("SIMPLE CALCULATOR");

            int total = 0;
            bool con = true;
            bool firstNumber = true;
            string operand;

            while (con)
            {
                if (firstNumber)
                {
                    Console.Write("Enter the first number: ");
                    total = Convert.ToInt32(Console.ReadLine());
                    firstNumber = false;
                }

                Console.Write("Enter an Operand (+, -, *, /, = to get result): ");
                operand = Console.ReadLine();

                if (operand == "=")
                {
                    con = false;
                    Console.WriteLine("Total: " + total);
                }
                else
                {
                    Console.Write("Enter the next number: ");
                    int nextNum = Convert.ToInt32(Console.ReadLine());
                    total = PerformOperation(total, nextNum, operand);
                }
            }
        }

        public static int PerformOperation(int total, int number, string operand)
        {
            switch (operand)
            {
                case "+":
                    return Add(total, number);
                case "-":
                    return Subtract(total, number);
                case "*":
                    return Multiply(total, number);
                case "/":
                    if (number == 0)
                    {
                        Console.WriteLine("Cannot divide by zero. Ignoring operation.");
                        return total;
                    }
                    return Divide(total, number);
                default:
                    Console.WriteLine("Invalid operand. Operation ignored.");
                    return total;
            }
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
