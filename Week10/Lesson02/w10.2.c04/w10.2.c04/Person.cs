public class Person : IEquatable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual bool Equals(Person? other)
    {
        if (other == null) return false;
        return Name == other.Name && Age == other.Age;
    }
    
    public override bool Equals(object? other)
    {
        if (other == null || other.GetType() != typeof(Person) && other.GetType() != typeof(Student)) return false;
        return Equals((Person)other);
    }

    public override string ToString()
    {
        return $"{Name} ({Age})";
    }
}