public class Magazine : Publication
{
    private string Issue { get; set; }
    public override string PublishedOn => IsPublished ? $"Issue: {Issue}; published on {base.PublishedOn}" : "not published yet";
    
    public Magazine(string title, string publisher, string pubType, List<string> audience) : base(title, publisher, "Magazine", audience)
    {
    }
}