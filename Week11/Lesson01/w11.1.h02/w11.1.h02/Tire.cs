public class Tire
{
    public string Brand { get; }
    private int _durability = 5;
    public int Durability { get => _durability; private set
        {
            if (value <= 0) _durability = 0;
            else _durability = value;
        } }

    public Tire(string brand)
    {
        Brand = brand;
    }

    public void Use()
    {
        Durability -= 1;
    }
}