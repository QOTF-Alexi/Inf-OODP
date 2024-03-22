public class DocumentCollection
{
    private List<Document> _documents = new();

    public void AddDocument(Document document)
    {
        _documents.Add(document);
    }

    public void RemoveDocument(Document document)
    {
        _documents.Remove(document);
    }

    public void DisplayDocuments()
    {
        foreach (Document doc in _documents)
        {
            Console.WriteLine($"{doc.ID}: {doc.Title}");
        }
    }

    public Document FindDocument(string title)
    {
        foreach (Document doc in _documents)
        {
            if (doc.Title == title) return doc;
        }

        return null;
    }
}