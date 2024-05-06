public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int CompareTo(Person? other)
    {
        if (other == null || other.Age == this.Age) return 0;
        if (other.Age < this.Age) return 1;
        if (other.Age > this.Age) return -1;
        return 0;
    }

    public override string ToString()
    {
        return $"{Name}, {Age} years old";
    }
}