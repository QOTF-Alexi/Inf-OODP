public class Product
{
    public string Name;
    public double Price;
    public int Quantity;

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"{Name}, Price: ${Price}, Quantity: {Quantity}";
    }
}