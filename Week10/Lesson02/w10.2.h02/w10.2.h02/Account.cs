public class Account : IEquatable<Account>, IComparable<Account>
{
    public int AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; set; }

    public bool Equals(Account other)
    {
        if (other == null) return false;
        return AccountNumber == other.AccountNumber &&
               AccountHolderName == other.AccountHolderName &&
               Balance == other.Balance;
    }

    public override bool Equals(object obj)
    {
        if (obj == null) return base.Equals(obj);
        if (!(obj is Account)) return false;
        return Equals((Account)obj);
    }

    public override int GetHashCode()
    {
        return AccountNumber.GetHashCode() ^ AccountHolderName.GetHashCode() ^ Balance.GetHashCode();
    }

    public static bool operator ==(Account account1, Account account2)
    {
        if (ReferenceEquals(account1, account2)) return true;
        if ((object)account1 == null || (object)account2 == null) return false;
        return account1.Equals(account2);
    }

    public static bool operator !=(Account account1, Account account2)
    {
        return !(account1 == account2);
    }

    public int CompareTo(Account other)
    {
        if (other == null) return 1;
        return AccountNumber.CompareTo(other.AccountNumber);
    }
}