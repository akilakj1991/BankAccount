using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Akila Jayawardena", 1000000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            //Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "friend paid me back");
            //Console.WriteLine(account.Balance);
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            //Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Pay Day");
            //Console.WriteLine(account.Balance);
            account.MakeWithdrawal(5, DateTime.Today, "Coffee");
            //Console.WriteLine(account.Balance);
            account.MakeWithdrawal(100, DateTime.Today, "Supermarket");
            //Console.WriteLine(account.Balance);
            account.MakeWithdrawal(50, DateTime.Today, "Fuel");
            //Console.WriteLine(account.Balance);
            account.MakeWithdrawal(50, DateTime.Today, "Phone Bill");
            //Console.WriteLine(account.Balance);
            account.MakeWithdrawal(500, DateTime.Today, "New Computer");
            //Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            // Test that the initial balances must be positive:
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                //Console.WriteLine("Exception caught creating account with negative balance");
                //Console.WriteLine(e.ToString());
            }

            // Test for a negative balance
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                //Console.WriteLine("Exception caught trying to overdraw");
                //Console.WriteLine(e.ToString());
            }
        }
    }
}
