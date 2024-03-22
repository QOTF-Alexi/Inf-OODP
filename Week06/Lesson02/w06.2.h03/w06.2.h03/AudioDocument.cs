public class AudioDocument : Document
{
    public int Duration { get; set; }

    public AudioDocument(string title, int duration) : base(title)
    {
        Duration = duration;
    }

    public override void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}