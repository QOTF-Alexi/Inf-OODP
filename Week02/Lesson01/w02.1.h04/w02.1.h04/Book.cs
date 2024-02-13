public class Book
{
    public int ID;
    public string Title;
    public Book(int ID, string Title)
    {
        this.ID = ID;
        this.Title = Title;
    }

    public string Info()
    {
        //stuff
        return $"ID: {ID}, Title: {Title}";
    }
}