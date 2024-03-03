public class Race
{
    public readonly string Name;
    public List<Driver> Outcome = new();

    public Race(string name)
    {
        Name = name;
    }
}