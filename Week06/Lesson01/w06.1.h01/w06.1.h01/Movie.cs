class Movie : IAgeSuitability
{
    public string Title { get; }
    public int MinAge { get; set; }
    public int MaxAge { get; set; }

    public string AgeSuitability
    {
        get => $"{MinAge}-{MaxAge}";
    }

    public Movie(string title, int minAge, int maxAge)
    {
        Title = title;
        MinAge = (minAge < maxAge) ? minAge : maxAge;
        MaxAge = (maxAge > minAge) ? maxAge : minAge;
    }
    
    public override string ToString()
    {
        return $"Movie {Title} (ages {AgeSuitability})";
    }
}