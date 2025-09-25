using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set
{
    class Person
    {
        private int _age = 15;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 15)
                {
                    _age = value;
                } else
                {
                    Console.WriteLine("Age can't be below 15");
                }
            }
        }
    }
    internal class Get_Set
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 8;
            Console.WriteLine(p.Age);
            p.Age = 20;
            Console.WriteLine(p.Age);
        }
    }
}
