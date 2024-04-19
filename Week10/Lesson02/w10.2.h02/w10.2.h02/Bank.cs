using System.Collections;

public class Bank : IEnumerable<Account>
{
    private List<Account> _accounts = new List<Account>();

    public void Add(Account account)
    {
        _accounts.Add(account);
    }

    public IEnumerator<Account> GetEnumerator()
    {
        return _accounts.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void SortByAccountNumber()
    {
        _accounts.Sort();
    }

    public bool ContainsAccount(Account account)
    {
        return _accounts.Contains(account);
    }
}