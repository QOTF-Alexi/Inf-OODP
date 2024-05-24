static class StandardLINQQueries
{
    public static void PrintAllGorillaSeqs(DNADatabase database)
    {
        // Print all sequences of the gorilla.
        var gorillaSeqs = from sequence in database.Data where sequence.Organism == "Gorilla gorilla" select sequence;
        foreach (var sequence in gorillaSeqs)
        {
            Console.WriteLine(sequence.Sequence);
        }
    }

    public static void PrintAllFruit(DNADatabase database)
    {
        var fruits = from sequence in database.Data orderby sequence.Organism
            where sequence.ID.StartsWith("SeqMaPu") || sequence.ID.StartsWith("SeqMuPa") ||
                  sequence.ID.StartsWith("SeqCiRe")
            select sequence;
        var distinct = fruits.DistinctBy( i => i.Organism );
        foreach (var sequence in distinct)
        {
            Console.WriteLine(sequence.Organism);
        }
    }

    public static void PrintSeqCountPerOrganism(DNADatabase database)
    {
        Console.WriteLine("Sequence count for each organism:");
        string organismType = "";
        List<List<DNA>> countedOrganisms = new();
        foreach (var organism in database.Data)
        {
            if (organismType != organism.Organism)
            {
                var organisms = (from sequence in database.Data
                    where organism.Organism == sequence.Organism
                    select sequence).ToList();
                organismType = organism.Organism;
                countedOrganisms.Add(organisms);
            }
        }
        
        foreach (var count in countedOrganisms.OrderByDescending(i => i.Count))
        {
            Console.WriteLine($" - {count[0].Organism}: {count.Count}");
        }
    }

    public static void PrintTop3OrganismsWithSimilarSeq(DNADatabase database, string querySequence)
    {
        Console.WriteLine($"Top 3 organisms with the most similar DNA strands for '{querySequence}':");
        foreach (var organism in database.FindTopOrganisms(querySequence, 3))
        {
            Console.WriteLine($" - {organism.Key.Organism}: {String.Format("{0:0.000}", organism.Value*100.000)}%");
        }
        
    }
}