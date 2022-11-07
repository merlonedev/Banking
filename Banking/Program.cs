// See https://aka.ms/new-console-template for more information

using Banking;

Console.WriteLine("Welcome to Cesharp Virtual Banking!");

Console.WriteLine("Could you tell us your first name? ");
string holderFirstName = Console.ReadLine()!;

Console.WriteLine("And your last name? ");
string holderLastName = Console.ReadLine()!;

Console.WriteLine("And lastly, your id: ");
int holderId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("_______________________________________");

Holder holder = new(holderId, holderFirstName, holderLastName);

Random random = new();
int accNumber = random.Next(1000000, 9999999);

Account account = new(holder, accNumber);

string newTransaction = "y";

Console.WriteLine($"Welcome to Cesharp Virtual Banking, {holder.FirstName} {holder.LastName}.");
Console.WriteLine($"Your account number is {account.AccNumber}.");

while (newTransaction.ToLower() == "y")
{
    Console.WriteLine("_______________________________________");
    Console.WriteLine("Would you like to perform a new transaction? y/n");
    newTransaction = Console.ReadLine()!.ToLower();

    switch (newTransaction)
    {
        case "y":
            Console.WriteLine("What transaction would you like to perform?\r\n1) Deposit\r\n2) Withdrawal\r\n3) Balance");
            int transaction = Convert.ToInt16(Console.ReadLine());
            double amount;
            switch (transaction)
            {
                case 1:
                    Console.WriteLine("What amount would you like to deposit? ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    account.Deposit(amount);
                    break;
                case 2:
                    Console.WriteLine("What amount would you like to withdraw? ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    account.Withdraw(amount);
                    break;
                case 3:
                    Console.WriteLine($"Your current balance is {account.Balance}");
                    break;
            }
            break;
        case "n":
            Console.WriteLine("Ok bye");
            Console.ReadKey();
            break;
    }
}
