using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        static void Main(string[] args)
        {
            // ATM
            // Withdraw
            // Check Balance
            // Exit
            double balance = int.MaxValue;
        /*
        Console.WriteLine(uint.MinValue);
        Console.WriteLine(uint.MaxValue);
        */
            do
            {
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Check Balance");
                Console.WriteLine("3. Exit");
                Console.Write("Choose your option: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount: ");
                        double amount = double.Parse(Console.ReadLine());
                        if (amount > balance)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        else
                        {
                            balance -= amount;
                            Console.WriteLine("Amount Withdrawn");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Balance: " + balance);
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        // return;
                        goto outer;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            } while (true);

        outer:
            Console.WriteLine("Bye");
        }
    }
}
