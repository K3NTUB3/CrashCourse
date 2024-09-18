using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L11Function
    {
        public static void Lesson11()
        {
            Animal nimal = new Animal("PYTHON","LAND/WATER","MAMMALS");
            nimal.animalInfo();

            Dog dog = new Dog("Golden Retriever", "Land", "DogFood", "Sleeping");
            dog.animalInfo();
        }
    }
    class Animal
    {
        public string name { get; set; }
        public string dwell { get; set; }

        public string food {  get; set; }

        public Animal(string name, string dwell, string food)
        {
            this.name = name;
            this.dwell = dwell;
            this.food = food;
        }
        public void animalInfo()
        {
            Console.WriteLine("\nAnimal Name   : " + name);
            Console.WriteLine("Dwell On      : " + dwell);
            Console.WriteLine("Favorite Food : " + food);
        }
    }
    class Dog : Animal
    {
        public string hobby {  get; set; }

        public Dog(string name, string dwell, string food, string hobby) : base (name, dwell, food)
        {
            this.hobby = hobby;
        }

        public void animalInfo()
        {
            base.animalInfo();
            Console.WriteLine("Hobby: "+hobby);
        }
    }
}
