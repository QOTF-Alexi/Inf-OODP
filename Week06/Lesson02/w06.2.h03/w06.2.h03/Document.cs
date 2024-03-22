public abstract class Document
{
    private static int _previousID = 0;
    public int ID { get; set; }
    public string Title { get; set; }

    public Document(string title)
    {
        Title = title;
        ID = _previousID + 1;
        _previousID = ID;
    }

    public virtual void Accept(IDocumentVisitor visitor)
    {
    }
}