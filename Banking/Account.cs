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
            if (amount <= 0)
            {
                Console.WriteLine("Can't deposit $0; please, input a value greater than 0.");
            }
            else
            {
                Balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (Balance > 0 && Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Unable to withdraw: not enough balance.");
            }
        }

        public bool Login(int accNumber, string password)
        {
            if (accNumber == AccNumber && password == Password)
            {
                Console.WriteLine("");
                Console.WriteLine("Login successful");
                return true;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Failed login");
                return false;
            }
        }

        public int AccNumber { get; }
        public Holder Holder { get; }
        private string Password { get; }
        public double Balance { get; set; }

    }
}
