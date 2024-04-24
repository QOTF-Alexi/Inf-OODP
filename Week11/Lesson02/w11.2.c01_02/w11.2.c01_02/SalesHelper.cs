public static class SalesHelper
{
    public static void PrintSalesData(int[][] data)
    {
        int tableCount = 0;
        foreach (var table in data)
        {
            Console.WriteLine($"\nSales data for department {++tableCount}:");
            foreach (var entry in table)
            {
                Console.WriteLine(" - " + entry);
            }
        }
    }
}