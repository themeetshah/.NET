using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            // Palindrome
            string x = Console.ReadLine();
            string y = "";
            for (int i = x.Length-1; i >= 0; i--)
            {
                y += x[i];
            }
            Console.WriteLine(y);
            Console.WriteLine(x==y);
        }
    }
}
