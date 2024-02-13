public class Library
{
    private int Size;
    public List<Book> Books = new List<Book>();
    
    public Library(int Size)
    {
        this.Size = Size;
    }

    public bool AddBook(int ID, string Title)
    {
        if (Books.Count < Size && FindBookByID(ID) == null)
        {
            Books.Add(new Book(ID, Title));
            return true;
        }
        else
        {
            return false;
        }
    }

    public Book FindBookByID(int ID)
    {
        foreach (Book b in Books)
        {
            if (b.ID == ID)
            {
                return b;
            }
        }
        return null;
    }

    public void EditBookTitle(int ID, string newTitle)
    {
        foreach (Book b in Books)
        {
            if (b.ID == ID)
            {
                b.Title = newTitle;
                break;
            }
        }
    }

    public void RemoveBookByTitle(string Title)
    {
        foreach (Book b in Books)
        {
            if (b.Title == Title)
            {
                Books.Remove(b);
                break;
            }
        }
    }
}