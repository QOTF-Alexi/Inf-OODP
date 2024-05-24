using System.Globalization;

public class Plant : IComparable<Plant>
{
    public string Name;
    public string Category;
    private int _stock;
    public int Stock
    {
        get { return _stock; }
    }
    public DateOnly LastSold;
    
    public Plant(string name, string category, int stock, string lastSold)
    {
        Name = name;
        Category = category;
        _stock = stock;
        LastSold = DateOnly.ParseExact(lastSold, "dd-MM-yyyy", CultureInfo.InvariantCulture).AddDays(-1);
    }

    public int Sell(int amount)
    {
        if (Stock - amount < 0)
        {
            int currStock = Stock;
            _stock = 0;
            LastSold = DateOnly.FromDateTime(DateTime.Now);
            return currStock;
        }
        else
        {
            _stock -= amount;
            LastSold = DateOnly.FromDateTime(DateTime.Now);
            return amount;
        }
    }

    public int CompareTo(Plant other)
    {
        return other == null ? 1 : Stock.CompareTo(other.Stock);
    }
}