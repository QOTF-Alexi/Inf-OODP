public class HOF
{
    public static List<T> Filter<T>(List<T> inputList, Func<T, bool> filterPredicate)
    {
        return inputList.Where(filterPredicate).ToList();
    }
}