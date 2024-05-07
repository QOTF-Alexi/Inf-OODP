public static class ArrayUtils
{
    public static void ReverseArray<T>(T[] arr)
    {
        RecReverseArray(arr, 0, arr.Length - 1);
    }

    //RecReverseArray goes here
    private static void RecReverseArray<T>(T[] array, int i, int j)
    {
        if (i >= j) return;
        
        (array[i], array[j]) = (array[j], array[i]);
        
        RecReverseArray(array, i + 1, j - 1);
    }


    public static void PrintArray<T>(T[] arr)
    {
        foreach (T elem in arr)
        {
            Console.WriteLine(elem);
        }
    }
}