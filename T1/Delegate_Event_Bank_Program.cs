using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event_Bank_Program
{

    // create a console application that demonstrates use of delecates and events showing bank account notification system
    // delegate variable: bank handler
    // take bank as class, within that fields are account number and balance
    // define withdraw method in that
    // when balance is less than 1000, event must be triggered
    // when triggered, display on console "Alert, (account number) has low balance Rs.(balance)"

    // Customer class
    // define warning method
    public delegate void BankHandler();
    class Bank
    {
        public event BankHandler LowBalance;
        public static double balance = 10000;
        public static uint account_number = 1234567890;

        public void withdraw ()
        {
            Console.Write("Enter amount to withdraw: ");
            double amt = double.Parse(Console.ReadLine());
            if (balance<1000)
            {
                LowBalance?.Invoke();
            } else
            {
                if (amt < balance)
                {
                    balance -= amt;
                    Console.WriteLine($"Transaction Successful. Remaining Balance is {balance}");
                } else
                {
                    Console.WriteLine($"Transaction Failed. Insufficient Balance: {balance}. Withdraw Amoun: {amt}");
                }
            }
        }
    }

    class Customer
    {
        public void Warning()
        {
            Console.WriteLine($"Alert, {Bank.account_number} has low balance Rs.{Bank.balance}");
        }
    }

    internal class Delegate_Event_Bank_Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Customer customer = new Customer();
            bank.LowBalance += customer.Warning;

            while (true)
            {
                bank.withdraw();
            }
        }
    }
}
