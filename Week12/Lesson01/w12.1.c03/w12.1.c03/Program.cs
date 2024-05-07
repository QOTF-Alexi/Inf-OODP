public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        var num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a base");
        var logBase = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(RecursiveLog(num, logBase));
    }

    public static int RecursiveLog(int num, int logBase)
    {
        if (num < logBase) return 0;
        return 1 + RecursiveLog(num / logBase, logBase);
    }
}