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
            float grade;

            Console.WriteLine("\nSTUDENT DETAILS\n\n");
            Console.Write("Enter Name    : ");
            name = Console.ReadLine();

            Console.Write("Enter Age     : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter School  : ");
            school = Console.ReadLine();

            Console.Write("Enter Course  : ");
            course = Console.ReadLine();

            Console.Write("Enter Grade   : ");
            grade = Convert.ToSingle(Console.ReadLine());

            Student stud = new Student(name, age, school, course, grade);

            stud.IntroduceSelf();
            Console.WriteLine();
            stud.EvaluateGrade();

        }

    }
    class Student
    {
        public string name, school, course;
        public int age;
        public float grade;

        public Student(string name, int age, string school, string course, float grade)
        {
            this.name = name;
            this.age = age;
            this.school = school;
            this.course = course;
            this.grade = grade;

            Console.WriteLine("\n\nPerson Details Created!\n");
        }
        public void IntroduceSelf()
        {
            Console.WriteLine("Hi! My name is " + name + ". I am " +
                age + " years old. " + "\nI am a student of " + school +
                ", currently taking " + course + " course.");
        }
        public void EvaluateGrade()
        {
            if (grade >= 99)
            {
                Console.WriteLine("WITH HIGHEST HONORS!\n");
            }
            else if (grade >= 95)
            {
                Console.WriteLine("WITH HIGH HONORS!\n");
            }
            else if (grade >= 90)
            {
                Console.WriteLine("WITH HONORS!\n");
            }
            else if (grade >= 75)
            {
                Console.WriteLine("Passed!\n");
            }
            else 
            {
                Console.WriteLine("Failed!\n");
            }

        }
    }
}
