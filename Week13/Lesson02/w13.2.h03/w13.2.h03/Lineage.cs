static class Lineage
{
    public static Organism GenerateLineage(List<string> dnaStrands)
    {
        return GenerateLineage(dnaStrands, 0);
    }

    // Overload GenerateLineage here
    private static Organism GenerateLineage(List<string> dnaStrands, int index)
    {
        return index >= dnaStrands.Count ? null : new Organism(GenerateLineage(dnaStrands, index + 1), dnaStrands[index]);
    }

    public static void IntroduceRandomMutations(Organism organism, Func<string, string> mutator)
    {
        IntroduceRandomMutations(organism, mutator, organism.DNAStrand);
    }

    // Overload IntroduceRandomMutations here
    private static void IntroduceRandomMutations(Organism organism, Func<string, string> mutator, string ancestor)
    {
        if (organism is null) return;
        organism.DNAStrand = mutator(ancestor);
        IntroduceRandomMutations(organism.Offspring, mutator, organism.DNAStrand);
    }
}