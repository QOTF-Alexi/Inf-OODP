public interface IDocumentVisitor
{
    void Visit(TextDocument textDoc);

    void Visit(ImageDocument imageDoc);

    void Visit(AudioDocument audioDoc);
}