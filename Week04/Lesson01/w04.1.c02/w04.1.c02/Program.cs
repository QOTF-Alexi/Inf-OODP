class Program
{
    public static void Main(string[] args)
    {
        string fileName = @"MyTextFile.txt";
        File.AppendAllText(fileName, "\nAdded line.");
    }
}