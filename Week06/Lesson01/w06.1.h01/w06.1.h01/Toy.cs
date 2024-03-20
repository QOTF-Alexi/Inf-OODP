class Toy : IAgeSuitability
{
    public string Name { get; }
    public int MinAge { get; set; }
    public int MaxAge { get; set; }
    
    public string AgeSuitability
    {
        get => $"{MinAge}-{MaxAge}";
    }

    public Toy(string name, int minAge, int maxAge)
    {
        Name = name;
        MinAge = (minAge < maxAge) ? minAge : maxAge;
        MaxAge = (maxAge > minAge) ? maxAge : minAge;
    }
    
    public Toy(string name, int minAge)
    {
        Name = name;
        MinAge = minAge;
    }

    public override string ToString()
    {
        return $"{Name} (ages {AgeSuitability})";
    }
}