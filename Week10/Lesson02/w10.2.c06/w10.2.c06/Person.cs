public class Person : IEquatable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual bool Equals(Person? other)
    {
        if (other is null) return false;
        return Name == other.Name && Age == other.Age;
    }
    
    public override bool Equals(object? other)
    {
        if (other is null || other.GetType() != typeof(Person) && other.GetType() != typeof(Student)) return false;
        return Equals((Person)other);
    }

    public override string ToString()
    {
        return $"{Name} ({Age})";
    }

    public static bool operator ==(Person obj1, object obj)
    {
        if (obj is null || obj1 is null) return false;
        return obj1.Equals(obj);
    }
    
    public static bool operator !=(Person obj1, object obj)
    {
        if (obj is null || obj1 is null) return false;
        return !obj1.Equals(obj);
    }
}