class DNADatabase
{
    public List<DNA> Data { get; }
    public DNADatabase(List<DNA> data) => Data = data;

    // Method FindTopOrganisms
    public Dictionary<DNA, double> FindTopOrganisms(string sequence, int topCount)
    {
        Dictionary<DNA, double> comparisonDict = new();
        foreach (DNA organism in Data)
        {
            comparisonDict.Add(organism, DNA.CalculateSimilarity(organism.Sequence, sequence));
        }

        // Sort the dictionary by value in descending order
        var sortedDict = comparisonDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        // Return a dictionary containing the topCount of DNA objects
        var result = sortedDict.Take(topCount).ToDictionary(x => x.Key, x => x.Value);

        return result;
    }
}