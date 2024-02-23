class Program
{
    public static void Main()
    {
        List<DNA> Sequences = new List<DNA>
    {
        new DNA("ACGT"),
        new DNA("GCTTAC"),
        new DNA("CGTTAGCTT"),
        new DNA("TACA")
    };

        Console.WriteLine("What is the minimum sequence length?");
        int len = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The filtered list:");
        foreach (DNA s in Sequences)
        {
            if (s.Seq.Length >= len)
            {
                Console.WriteLine(s.Seq);
            }
        }
    }
}

