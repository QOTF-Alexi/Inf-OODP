public static class RewardGenerator
{
    public static Random Rng = new Random(0);

    public static T GetRandomElement<T>(List<T> items)
    {
        return items[Rng.Next(items.Count)];
    }
}
