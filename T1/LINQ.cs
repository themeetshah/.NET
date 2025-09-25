using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{

    // create a class named person with the fields : id, name, job, salary
    // create a list of person objs with 4 diff entries
    // with above list, write LINQ (Language Integrate Query)

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }
    internal class LINQ
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>() { 
                new Person { Id=1, Name="P1", Job="Frontend Dev", Salary=5000.01}, 
                new Person { Id=5, Name="P5", Job="Frontend Dev", Salary=5000.01}, 
                new Person { Id=2, Name="P2", Job="Backend Dev", Salary=5000.01 },
                new Person { Id=3, Name="P3", Job="Full Stack Dev", Salary=6000.01},
                new Person { Id=4, Name="P4", Job="AI/ML Engineer", Salary=15000.99},
            };

            var Q = list.Where(n => n.Salary > 5500);
            foreach (var item in Q)
            {
                Console.WriteLine($"Person: {item.Name}, Salary: {item.Salary}, Job Title: {item.Job}");
            }

            Console.WriteLine($"\nAverage Salary > 5500: {list.Where(n => n.Salary > 5500).Average(n=>n.Salary)}\n");

            var q = list.Where(n => n.Job.Contains("Dev"));
            foreach (var item in q)
            {
                Console.WriteLine($"Name: {item.Name}, Job: {item.Job}");
            }

            Console.WriteLine($"\nMax Salary: {list.Max(n=>n.Salary)}");
            Console.WriteLine($"Min Salary: {list.Min(n=>n.Salary)}\n");

            var r = list.OrderBy(n=> n.Salary).ThenBy(n=>n.Name);
            foreach (var item in r)
            {
                Console.WriteLine($"Salary:{item.Salary}, Name:{item.Name}");
            }

            var s = list.OrderByDescending(n=> n.Name).ThenBy(n=>n.Salary).ElementAt(0);
            Console.WriteLine($"\nSalary:{s.Salary}, Name:{s.Name}");
        }
    }
}
