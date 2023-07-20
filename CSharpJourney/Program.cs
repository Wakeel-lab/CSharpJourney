class CSharpJourney
{
    static void Main(string[] args)
    {
        Account account1 = new Account("Jane Green", 50.00m);
        Account account2 = new Account("John Blue", -7.53m);


        Console.WriteLine($"{account1.Name}'s balance is: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance is: {account2.Balance:C}");

        Console.Write("\nEnter deposit amount for account1: ");
        decimal amountDeposit = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"Adding {amountDeposit:C} to account1 balance\n");
        account1.Deposit(amountDeposit);

        Console.WriteLine(
        $"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine(
        $"{account2.Name}'s balance: {account2.Balance:C}");

        Console.Write("\nEnter deposit amount for account2: ");
        amountDeposit = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"Adding {amountDeposit:C} to account2 balance\n");
        account2.Deposit(amountDeposit);

        Console.Write("\nFill in your withdrawal here: ");
        decimal withdrawalAmount = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"Deducting {withdrawalAmount:C} from account1 balance\n");
        account1.Withdraw(withdrawalAmount);

        Console.Write("\nFill in your withdrawal here: ");
        withdrawalAmount = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"Deducting {withdrawalAmount:C} from account2 balance\n");
        account2.Withdraw(withdrawalAmount);

        Console.WriteLine(
        $"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine(
        $"{account2.Name}'s balance: {account2.Balance:C}");
    }
}

class Account
{
    public Account(string accountName, decimal initialBalance)
    {
        Name = accountName;
        Balance = initialBalance;
    }
    public string Name { get; set; }

    private decimal balance;

    public decimal Balance
    {
        get
        {
            return balance;
        }

        private set
        {
            if (value > 0.0m)
            {
                balance = value;
            }
        }
    }

    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.00m)
        {
            Balance = Balance + depositAmount;
        }
    }

    public void Withdraw(decimal withdrawalAmount)
    {
        if (withdrawalAmount > Balance)
        {
            Console.WriteLine("Withdrawal amount exceeded account balance!");
        }
        else
        {
            Balance = Balance - withdrawalAmount;
        }
    }
}