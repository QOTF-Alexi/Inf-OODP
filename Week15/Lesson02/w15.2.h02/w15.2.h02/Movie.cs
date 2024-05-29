public enum Genre
{
    Action,
    Comedy,
    Drama,
    Family,
    Other    
}

public class Movie : IEquatable<Movie>
{
    public string Name { get; }
    public int Year { get; }
    public Genre Genre { get; }

    public Movie(string name, int year, Genre genre = Genre.Other)
    {
        Name = name;
        Year = year;
        Genre = genre;
    }

    public bool Equals(Movie other)
    {
        if (other is null) return false;
        return Name == other.Name && Year == other.Year;
    }
}