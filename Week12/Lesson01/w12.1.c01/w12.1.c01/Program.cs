public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        var num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(RecursiveSum(num));
    }

    public static int RecursiveSum(int n)
    {
        if (n <= 0)
        {
            return 0;
        }

        return n + RecursiveSum(n - 1);
    }
}