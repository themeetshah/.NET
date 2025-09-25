using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Polymorphism
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            dog.speak();
            dog.run();
            dog.eat();
            cat.speak();
            cat.run();
            cat.eat();
        }
    }

    abstract class Animal
    {
        public abstract void speak();
        public abstract void run();
        public void eat()
        {
            Console.WriteLine("Food");
        }
    }
    class Dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("bark");
        }

        public override void run()
        {
            Console.WriteLine("Fast");
        }
    }
    class Cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("meow");
        }

        public override void run()
        {
            Console.WriteLine("Faster than dog");
        }
    }
}
