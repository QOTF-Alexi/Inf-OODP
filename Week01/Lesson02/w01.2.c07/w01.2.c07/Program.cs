public class Program
{
    public static void Main()
    {
        Random randomGenerator = new Random();
        for (int i = 0; i <= 10; i++)
        {
            int dieRoll = randomGenerator.Next(1, 7);
            Console.WriteLine(dieRoll);
        }
    }
}