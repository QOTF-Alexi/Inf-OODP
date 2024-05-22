public class Program
{
    public static void Main(string[] args)
    {
        List<Customer> customers = new()
        {
            new Customer { Name = "Alice", City = "New York" },
            new Customer { Name = "Bob", City = "London" },
            new Customer { Name = "Charlie", City = "New York" },
            new Customer { Name = "Dave", City = "Paris" }
        };

        var isNewYork =
            from customer in customers
            where customer.City is "New York"
            select customer.Name;
        foreach (var person in isNewYork)
        {
            Console.WriteLine(person);
        }
    }
}