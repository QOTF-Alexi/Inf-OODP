public class TextFile : File, IPrintable
{
    public string Contents { get; set; }

    public TextFile(string fileName, string contents) : base($"{fileName}.txt")
    {
        Contents = contents;
    }

    public void Print()
    {
        Console.WriteLine(Contents);
    }
}