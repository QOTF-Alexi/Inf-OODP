public class Product : IEquatable<Product>, IComparable<Product>
{
    // Properties
    public string Name { get; }
    public int Price { get; }
    public int Quantity { get; }

    // Constructor
    public Product(string name, int price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    // Equals method
    public bool Equals(Product other)
    {
        if (other == null)
            return false;

        return Name == other.Name;
    }

    // Overload equality operators
    public static bool operator ==(Product p1, Product p2)
    {
        if (ReferenceEquals(p1, p2))
            return true;

        if (p1 is null || p2 is null)
            return false;

        return p1.Equals(p2);
    }

    public static bool operator !=(Product p1, Product p2)
    {
        return !(p1 == p2);
    }

    // CompareTo method
    public int CompareTo(Product other)
    {
        if (other == null)
            throw new ArgumentNullException(nameof(other));

        // First compare by Price, then by Name
        int priceComparison = Price.CompareTo(other.Price);
        if (priceComparison != 0)
            return priceComparison;

        return string.Compare(Name, other.Name, StringComparison.Ordinal);
    }

    // ToString method
    public override string ToString()
    {
        return $"{Name} ({Price} x {Quantity})";
    }
}