public class Program
{
    public static void Main()
    {
        Random knownNumberGenerator = new Random(1);
        for (int i = 0; i <= 10; i++)
        {
            int dieRoll = knownNumberGenerator.Next(1, 7);
            Console.WriteLine(dieRoll);
        }
    }
}