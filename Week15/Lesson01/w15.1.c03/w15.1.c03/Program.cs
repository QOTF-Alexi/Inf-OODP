public class Program
{
    static char FindMostFrequentCharacter(string input)
    {
        var charFrequency = input
            .GroupBy(c => c)
            .OrderByDescending(group => group.Count())
            .First();

        return charFrequency.Key;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        Console.WriteLine(FindMostFrequentCharacter(input));
    }
}