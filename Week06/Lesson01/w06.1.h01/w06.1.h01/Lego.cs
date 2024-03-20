class Lego : Toy
{
    public bool IsBuilt { get; private set; } = false;
    
    public string AgeSuitability
    {
        get => $"{MinAge}+";
    }

    public Lego(string name, int minAge) : base(name, minAge) { }

    public void Build() => IsBuilt = true;
    public void Disassemble() => IsBuilt = false;
    
    public override string ToString()
    {
        return !IsBuilt ? $"{Name} (ages {AgeSuitability})" : $"Built {Name} (ages {AgeSuitability})";
    }
}