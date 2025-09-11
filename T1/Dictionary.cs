using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string> { { 1,"Mango"}, { 2, "Banana"}, { 3, "Grapes"} };
            Console.WriteLine("\nDictionary:");
            foreach (var item in d)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }
            
            d.Add(5, "Orange");
            Console.WriteLine("\nAdd:");
            foreach (var item in d)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }

            d[1] = "New Mango";
            Console.WriteLine("\nUpdated:");
            foreach (var item in d)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }
            
            d.Remove(5);
            Console.WriteLine("\nAfter Removing 5:");
            foreach (var item in d)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }

            if (d.ContainsKey(5))
            {
                Console.WriteLine(d[5]);
            }
            else
            {
                Console.WriteLine("No key at 4");
            }

            String x = d.TryGetValue(2, out String str) ? str : "";
            Console.WriteLine("\nTryGetValue (2): "+x);

            // store name and roll
            // add 3 entries
            // remove 1 entry by key
            // check if key exists or not
            // display all key,value pair using foreach
        }
    }
}
