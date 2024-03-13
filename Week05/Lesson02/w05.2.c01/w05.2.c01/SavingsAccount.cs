public class SavingsAccount : BankAccount
{
    private bool _locked = true;
    
    public SavingsAccount(double balance, double interest) : base(balance, interest)
    {
    }

    public override double Withdraw(double amount)
    {
        if (_locked)
        {
            return 0;
        }
        return base.Withdraw(amount);
    }

    public override void NextYear()
    {
        YearsPassed += 1;
        if (YearsPassed < 5)
        {
            ApplyInterest();
        }
        else
        {
            _locked = false;
        }
    }
}