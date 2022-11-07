using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class Account
    {

        public Account(Holder holder, int accNumber)
        {
            Holder = holder;
            AccNumber = accNumber;
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance > 0 && Balance >= amount)
            {
                Balance -= amount;
            } else
            {
                Console.WriteLine("Unable to withdraw: not enough balance.");
            }
        }

        public int AccNumber { get; set; }
        public Holder Holder { get; set; }

        public double Balance { get; set; }

    }
}
