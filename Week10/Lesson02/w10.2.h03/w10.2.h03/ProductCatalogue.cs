using System.Collections;
public class ProductCatalogue : IEnumerable<Product>
{
    private readonly List<Product> _products = new List<Product>();

    // Add method
    public void Add(Product product)
    {
        _products.Add(product);
    }

    // GetEnumerator method
    public IEnumerator<Product> GetEnumerator()
    {
        return _products.GetEnumerator();
    }

    // Explicit implementation of IEnumerable.GetEnumerator
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    // SortProducts method
    public void SortProducts()
    {
        _products.Sort();
    }
}