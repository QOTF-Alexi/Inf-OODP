static class HOF
{
    public static T[] Filter<T>(T[] array, Func<T, bool> predicate)
    {
        return FilterRecursive(array, predicate, 0);
    }

    private static T[] FilterRecursive<T>(T[] array, Func<T, bool> predicate, int index)
    {
        if (index >= array.Length)
        {
            return new T[0];
        }

        T currentElement = array[index];
        T[] filteredArr = FilterRecursive(array, predicate, index + 1);
        
        if (predicate(currentElement))
        {
            T[] newArray = new T[filteredArr.Length + 1];
            for (int i = 0; i < filteredArr.Length; i++)
            {
                newArray[i + 1] = filteredArr[i];
            }
            newArray[0] = currentElement;
            return newArray;
        }
        return filteredArr;
    }
}