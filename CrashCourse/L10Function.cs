using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L10Function
    {
        public static void Lesson10()
        {
            string name, school, course;
            int age;

            Console.WriteLine("\nLet's Store your Details!\n\n");
            Console.Write("Enter Name    : ");
            name = Console.ReadLine();

            Console.Write("Enter Age     : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter School  : ");
            school = Console.ReadLine();

            Console.Write("Enter Course  : ");
            course = Console.ReadLine();

            Product product = new Product(name, age, school, course);
        }

    }
    class Product
    {
        public string name, school, course;
        public int age;

        public Product(string name, int age, string school, string course)
        {
            this.name = name;
            this.age = age;
            this.school = school;
            this.course = course;

            Console.WriteLine("\n\nPerson Details Created!\n");
            Console.WriteLine("Name    : " + name);
            Console.WriteLine("Age     : " + age);
            Console.WriteLine("School  : " + school);
            Console.WriteLine("Course  : " + course);

        }
    }
}
