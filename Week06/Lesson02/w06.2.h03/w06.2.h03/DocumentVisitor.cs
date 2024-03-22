public class DocumentVisitor : IDocumentVisitor
{
    public void Visit(TextDocument textDoc)
    {
        Console.WriteLine($"Text document: {textDoc.Title}\nBody: {textDoc.Body}");
    }

    public void Visit(ImageDocument imageDoc)
    {
        Console.WriteLine($"Image document: {imageDoc.Title}\nFile path: {imageDoc.FilePath}");
    }

    public void Visit(AudioDocument audioDoc)
    {
        Console.WriteLine($"Audio document: {audioDoc.Title}\nDuration: {audioDoc.Duration} seconds");
    }
}