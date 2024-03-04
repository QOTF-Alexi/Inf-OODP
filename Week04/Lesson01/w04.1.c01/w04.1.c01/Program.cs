class Program
{
    public static void Main(string[] args)
    {
        string filePath = @"MyTextFile.txt";
        var fileContents = File.ReadAllText(filePath);
        Console.WriteLine(fileContents);
    }
}