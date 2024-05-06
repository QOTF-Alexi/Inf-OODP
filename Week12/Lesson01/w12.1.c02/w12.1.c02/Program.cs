public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        var num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Factorial(num));
    }

    public static int Factorial(int n)
    {
        if (n <= 0)
        {
            return -1;
        }

        return n * Factorial(n - 1);
    }
}