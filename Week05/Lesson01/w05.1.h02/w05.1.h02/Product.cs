public class Product
{
    public string Name;
    public double Price;
    public int Stock;

    public Product(string name, double price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public virtual void Sell(int units)
    {
        if (Stock >= units)
        {
            Stock -= units;
            Console.WriteLine($"{units} units of {Name} has been sold");
        }
        else
        {
            Console.WriteLine(Name + " is out of stock");
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}; price: {Price}; stock: {Stock}";
    }
}