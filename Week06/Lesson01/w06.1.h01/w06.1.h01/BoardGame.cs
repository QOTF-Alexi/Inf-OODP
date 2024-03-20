class BoardGame : Toy
{
    public string Publisher { get; }

    public BoardGame(string name, string publisher, int minAge, int maxAge) : base(name, minAge, maxAge)
    {
        Publisher = publisher;
    }
    
    public override string ToString()
    {
        return $"{Name} by {Publisher} (ages {AgeSuitability})";
    }
}