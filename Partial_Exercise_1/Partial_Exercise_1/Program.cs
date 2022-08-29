using System;

namespace Partial_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            account.Diposit();
            account.Withdraw();

            Console.ReadKey();
        }
    }
}
