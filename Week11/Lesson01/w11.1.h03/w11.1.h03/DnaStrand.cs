public static class DnaStrand
{
    public static string ComplementaryStrand(string dnaStrand)
    {
        var reverseStrand = dnaStrand.Reverse();
        string inverseStrand = "";
        foreach (char c in reverseStrand)
        {
            switch (c)
            {
                case 'A':
                    inverseStrand += 'T';
                    break;
                case 'T':
                    inverseStrand += 'A';
                    break;
                case 'C':
                    inverseStrand+= 'G';
                    break;
                case 'G':
                    inverseStrand += 'C';
                    break;
            }
        }
        return inverseStrand;
    }

    public static bool IsValidDnaStrand(string dnaStrand)
    {
        if (string.IsNullOrEmpty(dnaStrand)) return false;
        string validDNA = "ACGT";
        return  dnaStrand.All(letter => validDNA.Contains(letter));
        //return !dnaStrand.Contains('A') || !dnaStrand.Contains('T') || !dnaStrand.Contains('C') || !dnaStrand.Contains('G');
    }

    public static string Transcribe(string dnaStrand)
    {
        string transcribedStrand = "";
        foreach (char c in dnaStrand)
        {
            if (c == 'T') transcribedStrand += 'U';
            else transcribedStrand+= c;
        }
        return transcribedStrand;
    }

    public static int HammingDistance(string dnaStrand1, string dnaStrand2)
    {
        if (dnaStrand1.Length != dnaStrand2.Length) return -1;
        int hammingDistance = 0;
        for (int i = 0; i < dnaStrand1.Length; i++)
        {
            if (dnaStrand1[i] != dnaStrand2[i]) hammingDistance += 1;
        }
        return hammingDistance;
    }
}