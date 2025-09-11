using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Lists
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"Ok", "Apple", "Orange", "Banana"};
            Console.WriteLine("\nList: "+String.Join(", ",list));
            list.Add("New Mango");
            list.Add("Hello");
            Console.WriteLine("Add: "+String.Join(", ",list));

            list.Insert(0, "Hi");
            Console.WriteLine("Insert (0, Hi): "+String.Join(", ",list));

            list.Remove("Banana");
            Console.WriteLine("Remove (Banana): "+String.Join(", ",list));

            list.RemoveAt(3);
            Console.WriteLine("RemoveAt (3): "+String.Join(", ",list));

            list.Sort();
            Console.WriteLine("Ascending Sort: "+String.Join(", ",list));

            list.Sort((a,b)=>b.CompareTo(a));
            Console.WriteLine("Descending Sort: "+String.Join(", ",list));

            // lambda fxn
            list.RemoveAll(n=>n.Length>5);
            Console.WriteLine("RemoveAll (length>5): "+String.Join(", ",list));

            Console.WriteLine("FindAll (StartsWith H): " + String.Join(", ", list.FindAll(n => n.StartsWith("H"))));

            Console.WriteLine("IndexOf Kiwi: "+list.IndexOf("Kiwi"));

            // construct a list. convert to arr. add elements to arr. convert arr to list. show element at index 1.
        }
    }
}
