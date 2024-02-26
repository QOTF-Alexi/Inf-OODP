class Person
{
    public readonly string Name; // I disagree but this is what they expect...
    public int Age;

    public Person(string name)
    {
        Name = name;
        Age = 0;
    }

    public void GrowOlder() => Age++;
}