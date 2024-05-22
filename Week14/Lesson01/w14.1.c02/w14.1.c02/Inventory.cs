public class Inventory
{
    private Dictionary<string, Product> _products = new();
    
    //Adds a new product to the inventory with the given name, price, and quantity.
    public void AddProduct(string name, double price, int quantity)
    {
        _products.Add(name, new Product(name, price, quantity));
    }

    //Overload the method and set the quantity to 0
    public void AddProduct(string name, double price)
    {
        _products.Add(name, new Product(name, price, 0));
    }

    //Removes a product from the inventory with the given name.
    public void RemoveProduct(string name)
    {
        if (_products.ContainsKey(name))  
        {
            _products.Remove(name);
        }
        else Console.WriteLine("Product not found");
    }

    //Returns the Product object for the product with the given name.
    public Product GetProduct(string name)
    {
        if (_products.ContainsKey(name))
        {
            return _products[name];
        }
        else Console.WriteLine("Contact not found");

        return null;
    }

    //Returns a summary of the current inventory levels, including the total number of the Quantity of all products and the total value of the inventory.
    //ex:
    // Total products: 45
    // Total value: $14.50
    public string GetInventorySummary()
    {
        double totalValue = 0;
        int totalProducts = 0;
        foreach (var product in _products)
        {
            totalProducts += product.Value.Quantity;
            totalValue += product.Value.Quantity * product.Value.Price;
        }

        return $"Total products: {totalProducts}\nTotal value: ${totalValue}";
    }

}