using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Andy", 10000.5M);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(360, DateTime.Now, "Xbox");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            //try
            //{
            //    account.MakeWithdrawal(7000000, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}
