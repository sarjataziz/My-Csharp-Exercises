using Account_2;

class Program 
{
    public static void Main()
    {
        Account account = new Account();

        account.AccountHolderName = "Monkey D. Luffy";
        account.AccountNumber = 12123;
        account.Balance = 20000.00f;

        account.DepositMoney(2500.00f);
        account.WithdrawMoney(50.00f);

        account.ShowDetails();

        System.Console.ReadKey();

    }
}