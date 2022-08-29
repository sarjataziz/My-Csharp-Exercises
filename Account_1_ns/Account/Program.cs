class Account
{
    private int _accountNumber;
    private string _accountHolderName;
    private float _balance;

    public Account(int accountNumber, string accountHolderName, float balance)
    {
        this._accountNumber = accountNumber;
        this._accountHolderName = accountHolderName;
        this._balance = balance;
    }

    public void SetAccountNumber(int accountNumber)
    {
        _accountNumber = accountNumber;
    }
    public int GetAccountNumber()
    {
        return _accountNumber;
    }
    public void SetAccountHolderName(string accountHolderName)
    {
        _accountHolderName = accountHolderName;
    }
    public string GetAccountHolderName()
    {
        return _accountHolderName;
    }
    public void SetBalance(float balance)
    {
        _balance = balance;
    }
    public float GetBalance()
    {
        return _balance;
    }

    public void ShowDetails()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("------------------------------------------------");
        System.Console.WriteLine("Your Account Info: ");
        System.Console.WriteLine("------------------------------------------------");
        System.Console.WriteLine();
        System.Console.WriteLine("Account Number     : " + _accountNumber);
        System.Console.WriteLine("Account Holder Name: " + _accountHolderName);
        System.Console.WriteLine("Account Balance    : " + _balance);
        System.Console.WriteLine();
    }

    public void DepositMoney(float amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    public void WithdrawMoney(float amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance -= amount;
        }
        else
        {
            System.Console.WriteLine("You Can't Withdraw Money...");
            System.Console.WriteLine("Currtent Balance is : " + GetBalance());
        }
    }
}

class Program
{
    public static void Main()
    {
        Account account = new Account(18924, "Monkey D. Luffy", 10000.00f);

        account.DepositMoney(2000.00f);
        account.WithdrawMoney(500000.00f);

        account.ShowDetails();

        System.Console.ReadKey();

    }
}