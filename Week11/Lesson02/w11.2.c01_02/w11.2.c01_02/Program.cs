public class Program
{
    public static void Main()
    {
        Console.WriteLine("How many departments are there? ");
        var depts = Convert.ToInt32(Console.ReadLine());
        var inputSalesData = new int[depts][];
        for (var i = 0; i < depts; i++)
        {
            Console.Write("Enter sales number: ");
            inputSalesData[i] = new[]{int.Parse(Console.ReadLine())};
        }

        SalesHelper.PrintSalesData(inputSalesData);
        
        /*int[][] salesData = new int[][]
        {
            new int[] { 1000, 1500, 1700, 2000 },
            new int[] { 1200, 1700, 1600, 1700, 2000 },
            new int[] { 1300, 2000, 1500 },
        };
        SalesHelper.PrintSalesData(salesData);*/
    }
}