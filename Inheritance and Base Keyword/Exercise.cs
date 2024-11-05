
using System;

namespace Coding.Exercise
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound(); // calling base class' MakeSound method
            Console.WriteLine("Dog barks");
        }
    }

    public class Exercise
    {
        public static void Main(string[] args)
        {
            Dog rocky = new Dog();
            rocky.MakeSound();
        }
    }
}

