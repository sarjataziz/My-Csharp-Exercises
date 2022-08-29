namespace Account_2
{
    class Account
    {
        private int _accountNumber;
        private string _accountHolderName;
        private float _balance;

       /* public Account(int accountNumber, string accountHolderName, float balance)
        {
            this._accountNumber = accountNumber;
            this._accountHolderName = accountHolderName;
            this._balance = balance;
        } */

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public string AccountHolderName
        {
            get { return _accountHolderName; }
            set { _accountHolderName = value; }
        }
        
        public float Balance
        {
            get { return _balance; }
            set { _balance = value; }   
        }
 
        public void ShowDetails()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("------------------------------------------------");
            System.Console.WriteLine("Your Account Info: ");
            System.Console.WriteLine("------------------------------------------------");
            System.Console.WriteLine();
            System.Console.WriteLine($"Account Number     : {_accountNumber}");
            System.Console.WriteLine($"Account Holder Name: {_accountHolderName}");
            System.Console.WriteLine($"Account Balance    : {_balance}");
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
                System.Console.WriteLine("Currtent Balance is : " + _balance);
            }
        }
    }
}
