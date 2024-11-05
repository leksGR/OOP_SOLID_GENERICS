using System.Security.Cryptography.X509Certificates;

BankAccount account = new BankAccount(10000);
account.EnterCash(500);
account.Withdraw(2000);
account.CurrentBalance();

public class BankAccount
{
    private int balance;
    public BankAccount( int beginBalance)
    {
        if (beginBalance < 0)
        {
            Console.WriteLine("Начальный баланс не может быть отрицательным");
        }
        else { 
            balance = beginBalance;
            Console.WriteLine($"Текущий баланс: {balance}");
        }
    }
    public void EnterCash(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Сумма пополненич должна быть положительной");
        }
        else {
            balance += amount;
            Console.WriteLine($"Счет пополнен на {amount}. Текущий баланс: {balance}");
        }
    }
    public void Withdraw(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Сумма снятия должна быть положительной");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Со счета снято {amount}. Текущий баланс: {balance}");
        }
    }
    public void CurrentBalance()
        {
            Console.WriteLine($"Текущий баланс: {balance}");
        }
}