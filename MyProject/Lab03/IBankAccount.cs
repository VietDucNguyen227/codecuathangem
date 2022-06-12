using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    interface IBankAccount
    {
        void Debit(double amount);
        void Credit(double amount);
    }

    public class BankAccount : IBankAccount
    {
        public void Credit(double amount)
        {
            Console.WriteLine($"${amount}");
            Console.WriteLine("Amount: {0}", amount);
        }

        public void Debit(double amount)
        {
            Console.WriteLine($"${amount}");

        }
    }
}
