using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Continue
{
    internal class Break_Continue
    {
        static void Main(string[] args)
        {
            // i : 0 to 10, print 0 to 4
            int i = 0;
            while(i<10)
            {
                if (i==5)
                {
                    break;
                }
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Continue:");
            i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i%5==0)
                {
                    i++;
                    continue;
                }
            }
        }
    }
}
