public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public int CompareTo(Book? other)
    {
        int result = 0;
        if (other == null) return 1;
        result = Year.CompareTo(other.Year);
        if (result == 0) result = Author.CompareTo(other.Author);
        if (result == 0) result = Title.CompareTo(other.Title);
        return result;
    }
}