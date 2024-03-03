using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Q1
{
    class Accounts
    {
        private int accountNo;
        private string customerName;
        private string accountType;
        public char transactionType;
        public double amount;
        public double balance;

        public Accounts(int accountNo, string customerName, string accountType, char transactionType, double amount)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;
            this.balance = 0; 
        }

        public void Credit(double amount)
        {
            balance += amount; 
        }

        public void Debit(double amount)
        {
            if (balance >= amount)
            {
                balance = balance - amount; 

            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public void ShowData()
        {
            Console.WriteLine($"Account No: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Transaction Type: {transactionType}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Balance: {balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accounts account = new Accounts(123456, "John Doe", "Savings", 'D', 1500);
            account.ShowData();
            Console.WriteLine();

            
            if (account.transactionType == 'D')
            {
                account.Credit(account.amount);
            }

            
            account.ShowData();
            Console.WriteLine();
            Console.Read();

           
            account = new Accounts(123456, "John Doe", "Savings", 'W', 500);
            if (account.transactionType == 'W')
            {
                account.Debit(account.amount);
            }

           
            account.ShowData();
        }
    }

}