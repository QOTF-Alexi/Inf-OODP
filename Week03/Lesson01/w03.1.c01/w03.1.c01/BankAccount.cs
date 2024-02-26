class BankAccount
{
    public static double InterestRatePercentage;
    public double Balance;

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void ApplyInterest()
    {
        double InterestRate = InterestRatePercentage / 100 + 1;
        Balance *= InterestRate;
    }
}