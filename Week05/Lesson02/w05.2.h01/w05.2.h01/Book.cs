public class Book : Publication
{
    public string ISBN { get; set; }
    public string Currency { get; set; }
    public double Price { get; set; }
    public string Author { get; set; }

    public Book(string isbn, string title, string publisher, string pubType, List<string> audience) : base(title, publisher, "Book", audience)
    {
        ISBN = isbn;
    }

    public void SetPrice(double price, string currency)
    {
        if (price > 0)
        {
            Currency = currency;
            Price = price;
        }
    }

    public bool IsSuitableForChild()
    {
        return Audience.Contains("Children");
    }

    public override string ToString()
    {
        return $"{Author}, ISBN: {ISBN}, {Title}, {Pages} pages, {PublishedOn}, {Currency} {Price}";
    }
}