using System;

namespace Ternary_Operators
{
    internal class Ternary_Operators
    {
        static void Main(string[] args)
        {
            // Temp Comparator with null safety
            float? t1 = null;
            float? t2 = null;
            t1 = float.TryParse(Console.ReadLine(), out float t11) ? t11 : (float?)null;
            t2 = float.TryParse(Console.ReadLine(), out float t22) ? t22 : (float?)null;
            if (t1.HasValue && t2.HasValue)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine(t1 > t2 ? t1 : t2);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter valid Temp");
            }
        }
    }
}
