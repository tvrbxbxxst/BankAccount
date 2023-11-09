public class BankAccount
{
    private int accountNumber;
    private string accountOwner;
    private float balance;
    public void OpenAccount(int number, string owner, float initialBalance)
    {
        accountNumber = number;
        accountOwner = owner;
        balance = initialBalance;
    }

    public void Deposit(float amount)
    {
        balance += amount;
    }

    public void Withdrawal(float amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }

            else
            {
                Console.WriteLine("Недостаточно средств на счете");
            }
    }

    public void Transfer(int targetAccountNumber, float amount)
    {
        if (amount <= balance)
        {

            Console.WriteLine("Перевод {0} рублей со счета {1} на счет {2}", amount, accountNumber, targetAccountNumber);
            balance -= amount;
        

        }
        else
        {
            Console.WriteLine("Недостаточно средств на счете");
        }
    }

    public void ShowAccountInfo()
    {
        Console.WriteLine("Счет №: {0}", accountNumber);
        Console.WriteLine("Имя держателя счёта: {0}", accountOwner);
        Console.WriteLine("Баланс: {0} рублей", balance);
    }
}
//🤔🤔🤔🤔🤔🤔🤔