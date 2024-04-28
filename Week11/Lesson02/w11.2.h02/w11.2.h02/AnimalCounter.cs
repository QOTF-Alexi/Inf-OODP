public static class AnimalCounter
{
    public static (int, int) CountOccurrences(Animal[][] animals, Animal toFind)
    {
        int count = 0;
        int ageCount = 0;

        for (int i = 0; i < animals.Length; i++)
        {
            for (int j = 0; j < animals[i].Length; j++)
            {
                if (animals[i][j].Species == toFind.Species) count += 1;
                if (animals[i][j].Species == toFind.Species && animals[i][j].Age == toFind.Age) ageCount += 1;
            }
        }
        return (count, ageCount);
    }
}