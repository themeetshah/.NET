using System;

namespace OOPS
{
    internal class OOPS
    {
        static void Main(string[] args)
        {
            Car C1 = new Car();
            Car C2 = new Car();

            Car.number = 9340;
            C1.name = "Tigor";
            C1.Display();

            Temp t = new Temp();
            t.CallSecret();
            //t.SecretMethod();

            Parent parent = new Parent();
            Child child = new Child();

            child.callProtected();
            //parent.ProtectedMethod();

            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();
            Console.Write("Reference and Implementation both Animal: ");
            animal.speak();

            Console.Write("Reference and Implementation both Dog: ");
            dog.speak();

            Console.Write("Reference and Implementation both Cat: ");
            cat.speak();

            Animal e = new Dog();
            Animal f = new Cat();
            Console.Write("Reference Animal and Implementation Dog: ");
            e.speak();
            Console.Write("Reference Animal and Implementation Cat: ");
            f.speak();

            Dog b = new BullDog();
            Console.Write("Reference Dog and Implementation BullDog: ");
            b.speak();

            Cat c = new Kitty();
            Console.Write("Reference Cat and Implementation Kitty: ");
            c.speak();
        }
    }


    // access modifiers
    // public
    class Car
    {
        public static int number = 2143;
        public string name = "punch";
        public readonly int x = 1234;
        public const int noofwheels = 4;
        public static int noofinst = 0;

        public Car()
        {
            x = 9340;
            noofinst ++;
        }

        //public static void Display()
        //{
        //    Console.WriteLine($"{number}, {obj.name}, {obj.x}, {noofwheels}");
        //    Console.WriteLine($"Number of Instance: {noofinst}");
        //}

        public void Display()
        {
            Console.WriteLine($"{number}, {name}, {x}, {noofwheels}");
            Console.WriteLine($"Number of Instance: {noofinst}");
        }
    }

    // private
    class Temp
    {
        private void SecretMethod()
        {
            Console.WriteLine("It's a secret Method");
        }

        public void CallSecret()
        {
            SecretMethod();
        }
    }

    // protected
    class Parent
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("It's a protected method.");
        }
    }
    class Child : Parent
    {
        public void callProtected()
        {
            ProtectedMethod();
        }
    }


    // method modifiers
    // virtual & override
    class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("Hello");
        }
    }
    class Dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Bark");
        }
    }
    class BullDog : Dog
    {
        public override void speak()
        {
            Console.WriteLine("Bhowwwwww");
        }
    }
    class Cat : Animal
    {
        public sealed override void speak()
        {
            Console.WriteLine("Meow");
        }
    }
    class Kitty : Cat
    {
        // can't override sealed method
        /*
        public override void speak()
        {
            Console.WriteLine("Meowwwwwwww");
        }
        */
    }
}
