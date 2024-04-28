public class Animal : IEquatable<Animal>
{
    public string Species { get; set; }
    public int Age { get; set; }

    public Animal(string species, int age)
    {
        Species = species;
        Age = age;
    }

    public bool Equals(Animal? other)
    {
        if (other is null) return false;
        if (other.Species == this.Species) return true;
        return false;
    }

    public bool Equals(object? other)
    {
        if (this is null || other is null || other.GetType() != this.GetType()) return false;
        return Equals(other as Animal);
    }

    public static bool operator ==(Animal first, object? other)
    {
        return first.Equals(other);
    }

    public static bool operator !=(Animal first, object? other)
    {
        return !first.Equals(other);
    }
}