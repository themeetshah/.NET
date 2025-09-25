using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    public delegate void Notify(string str);
    // Notify: Delegate type

    public delegate int MathOperation(int x, int y);

    internal class Delegates_Events
    {
        public static void Processing(string s)
        {
            Console.WriteLine($"{s} is under process.");
        }
        public static void Packing(string s)
        {
            Console.WriteLine($"[Packing]: {s}");
        }
        public static void Configuring(int s)
        {
            Console.WriteLine($"[Configuring]: {s}");
        }
        public static void Dispatching(string s)
        {
            Console.WriteLine($"[Dispatching]: {s}");
        }
        static void Main(string[] args)
        {
            Notify NT = Processing;
            // NT: Delegate variable
            NT += Packing;
            NT += Dispatching;
            // anonymous method
            NT += (string s) => { Console.WriteLine($"[Shipping]: {s}"); };

            // NT += Configuring;
            // It won't take this as signature for delegate is not same.
            // Signature: Same return type, same input parameters

            NT("Laptop");


            MathOperation Add = (x, y) => x + y;
            Add += (x, y) => x - y;
            MathOperation Multiply = (x, y) => x * y;

            Console.WriteLine($"Add 85 and 185: "+Add(85,185));
            Console.WriteLine($"Multiply 25 and 25: "+Multiply(25,25));


            Action greet = () => Console.WriteLine("Hello Students");
            Action<int, int> Adding = (x, y) => Console.WriteLine(x + y);
            greet();
            Adding(25, 25);
            
            // x, y, return type
            Func <int, int, int> Multiplying = (x, y) => x * y;
            Console.WriteLine(Multiplying(25,10));

            Predicate <int> isEven = (x) => x % 2 == 0;
            Console.WriteLine(isEven(20));

            // Delegate : Return Type : Parameter : Use Case
            // Action : Void : 0 or more : Logging, Painting
            // Function : Any type : 0 or more : Calculation
            // Predicate : bool : exactly 1 : Check or filter
        }
    }
}
