public class BankAccount
{
    private double _balance;
    protected int YearsPassed = 0;
    protected double InterestRate;

    public BankAccount(double balance, double interestRate)
    {
        _balance = balance;
        InterestRate = interestRate;
    }

    public double ReadBalance()
    {
        return _balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    public virtual double Withdraw(double amount)
    {
        if (amount > 0 && SufficientBalance(amount))
        {
            _balance -= amount;
            return amount;
        }
        return 0;
    }

    public virtual void NextYear()
    {
        ApplyInterest();
    }

    protected void ApplyInterest()
    {
        _balance *= InterestRate + 1;
    }

    private bool SufficientBalance(double amount)
    {
        return _balance >= amount;
    }
}