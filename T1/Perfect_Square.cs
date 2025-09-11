using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Square
{
    internal class Perfect_Square
    {
        static void Main(string[] args)
        {
            // check whether a number is perfect square or not
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double y = Math.Sqrt(x);
            Console.WriteLine(y%1==0 ? "Is a sqr num" : "Not a sqr num");
        }
    }
}
