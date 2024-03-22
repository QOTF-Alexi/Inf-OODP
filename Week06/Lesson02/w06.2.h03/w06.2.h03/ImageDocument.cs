public class ImageDocument : Document
{
    public string FilePath { get; set; }
    
    public ImageDocument(string title, string filePath) : base(title)
    {
        FilePath = filePath;
    }
    
    public override void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}