public class Car : IEquatable<Car>
{
    public string Make { get; }
    public string Model { get; }
    public Tire[] Tires { get; }

    public Car(string make, string model, string tireBrand)
    {
        Make = make;
        Model = model;
        Tires = [new Tire(tireBrand), new Tire(tireBrand), new Tire(tireBrand), new Tire(tireBrand)];
    }

    public bool TryDrive()
    {
        foreach (Tire t in Tires)
        {
            if (t.Durability < 1)
            {
                return false;
            }
        }
        foreach (Tire t in Tires)
        {
            t.Use();
        }
        return true;
    }

    public void ReplaceTire(Tire newTire, int toReplace)
    {
        Tires[toReplace] = newTire;
    }

    public void ReplaceTire(string newTireBrand, int toReplace)
    {
        Tires[toReplace] = new Tire(newTireBrand);
    }

    public string GetTireInfo()
    {
        return $"Tire 1: Brand: {Tires[0].Brand}, Durability: {Tires[0].Durability}\n" +
            $"Tire 2: Brand: {Tires[1].Brand}, Durability: {Tires[1].Durability}\n" +
            $"Tire 3: Brand: {Tires[2].Brand}, Durability: {Tires[2].Durability}\n" +
            $"Tire 4: Brand: {Tires[3].Brand}, Durability: {Tires[3].Durability}\n";

    }

    public bool Equals(Car other)
    {
        if (this is null && other is null) return true;
        if (other is null) return false;
        return Make == other.Make && Model == other.Model;
    }

    public static bool operator ==(Car thisOne, Car other)
    {
        if (thisOne is null && other is null) return true;
        if (other is null) return false;
        return thisOne.Make == other.Make && thisOne.Model == other.Model;
    }

    public static bool operator !=(Car thisOne, Car other)
    {
        if (other is null) return false;
        return thisOne.Make != other.Make || thisOne.Model != other.Model;
    }
}