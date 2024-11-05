using System;

namespace Coding.Exercise
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
    public class Exercise
    {
        public static void Main(string[] args)
        {
            Animal ani = new Animal();
            ani.MakeSound();
            Dog rocky = new Dog();
            rocky.MakeSound();
            Cat thunder = new Cat();
            thunder.MakeSound();
        }
    }
}
