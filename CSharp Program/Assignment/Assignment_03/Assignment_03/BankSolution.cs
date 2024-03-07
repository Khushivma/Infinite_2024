using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    class BankSolution
    {
        public float balance;

        public BankSolution(int amount)
        {
            balance = amount;
        }


        public void deposit(int amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Write a valid amount ");
            }
            else
            {
                balance += amount;
                Console.WriteLine("amount deposit successfully");
            }

        }

        public void withdrawl(int amount)
        {
            if (amount > balance)
            {
                throw new InsufficentAmountException("Insufficient balance for withdrawal.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("amount withdrawal successfully");

            }
        }

    }

    class InsufficentAmountException : Exception
    {
        public InsufficentAmountException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
    class Solution
    {
        public static void Main()
        {
            BankSolution bs = new BankSolution(300);
            bs.deposit(9000);
            bs.withdrawl(4000);
            Console.ReadKey();

        }
    }
}