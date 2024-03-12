public class Clothes : Product
{
    public string Size;
    public string Material;

    public Clothes(string name, double price, int stock, string size, string material) : base(name, price, stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
        Size = size;
        Material = material;
    }

    public override void Sell(int units)
    {
        base.Sell(units);
        Console.WriteLine(WashingInstructions());
    }

    private string WashingInstructions()
    {
        switch (Material)
        {
            case "Cotton":
                return "Gentle";
            case "Wool":
                return "Hand";
            case "Linen":
                return "Washing machine";
            default:
                return "Unknown";
        }
    }

    public override string ToString()
    {
        string toReturn = base.ToString();
        toReturn += $"; size: {Size}; material: {Material}";
        return toReturn;
    }
}