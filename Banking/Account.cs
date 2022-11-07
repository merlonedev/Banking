using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class Account
    {

        public Account(Holder holder, int accNumber, string password)
        {
            Holder = holder;
            AccNumber = accNumber;
            Balance = 0;
            Password = password;
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

        public int AccNumber { get; }
        public Holder Holder { get; }
        private string Password {get; }
        public double Balance { get; set; }

    }
}
