static class Lineage
{
    public static Organism GenerateLineage(int generations)
    {
        if (generations is 0) return null;
        return new Organism(GenerateLineage(generations - 1));
    }

    public static int CountLineageLength(Organism organism)
    {
        if (organism.Offspring is null)
            return 1;

        // Recursively count the lineage length.
        return 1 + CountLineageLength(organism.Offspring);
    }
}