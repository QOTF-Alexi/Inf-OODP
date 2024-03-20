public class Program
{
    public static void Main(string[] args)
    {
        List<Bill> bills = new()
        {
            new ElectricityBill(50, "John Smith"),
            new ElectricityBill(75, "Jane Doe"),
            new GasBill(100, "Bob Johnson", false),
            new GasBill(125, "John Doe", true)
        };

        var totalcost = 0.0;
        foreach (Bill bill in bills)
        {
            Console.WriteLine(bill.GetDescription());
            totalcost += bill.Amount;
        }

        Console.WriteLine("Total amount: " + totalcost);
    }
}