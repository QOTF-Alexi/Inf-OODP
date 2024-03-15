public class Publication
{
    public string Publisher { get; set; }
    public string Title { get; set; }
    public string PublicationType { get; set; }
    private int _pages;
    public int Pages
    {
        get => _pages;
        set
        {
            if (value > 0)
            {
                _pages = value;
            }
        }
    }
    public DateTime PublicationDate { get; set; }
    public virtual string PublishedOn
    {
        get => IsPublished ? PublicationDate.ToString("yyyy-MM-dd") : "not published yet";
    }

    protected List<string> Audience { get; set; }
    protected bool IsPublished
    {
        get => PublicationDate.ToString("yyyy-MM-dd") != "0001-01-01";
    }

    public Publication(string title, string publisher, string pubType, List<string> audience)
    {
        Publisher = publisher;
        Title = title;
        PublicationType = pubType;
        Audience = audience;
    }

    public bool IsSuitableForAudience(string audience)
    {
        return Audience.Contains(audience);
    }

    public override string ToString()
    {
        return $"{Title}, {Pages} pages, {PublishedOn}";
    }
}