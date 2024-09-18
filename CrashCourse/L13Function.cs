using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L13Function
    {
       public static void Lesson13()
        {
            Food vegetable = new Vegetable();
            Food meat = new Meat();

            vegetable.Encourage();
            meat.Encourage();

            Console.WriteLine("\nSimple Polymorphism\n\n");
            
        }
    }
    class Food
    {
        virtual public void Encourage()
        {
            Console.WriteLine("Encourage the people what to eat!");
        }
    }
    class Vegetable : Food
    {
        override public void Encourage()
        {
            base.Encourage();
            Console.WriteLine("\nTEAM VEGETABLES! \nEat me more! Eating vegetables boosts your energy and mood, making every day a little brighter and healthier!");
        }
    }
    class Meat : Food
    {
        override public void Encourage()
        {
            base.Encourage();
            Console.WriteLine("\nTEAM MEAT! \nEat me more! Incorporating lean meats into your diet provides essential protein and nutrients that help build strength and support overall health!");
        }
    }
}
