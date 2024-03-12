public class Electronics : Product
{
    public string Brand;
    public string Model;
    private static int _minimumStock;

    public Electronics(string name, double price, int stock, string brand, string model, int minimumStock = 10) : base(name, price, stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
        Brand = brand;
        Model = model;
        _minimumStock = minimumStock;
    }

    public override void Sell(int units)
    {
        base.Sell(units);
        Restock();
    }

    private void Restock()
    {
        if (Stock < _minimumStock)
        {
            Stock = _minimumStock;
        }
    }

    public override string ToString()
    {
        return $"Name: {Name} ({Brand} {Model}); price: {Price}; stock: {Stock}";
    }
}
