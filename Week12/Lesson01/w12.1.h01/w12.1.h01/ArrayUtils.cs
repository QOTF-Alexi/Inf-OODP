static class ArrayUtils
{
    public static int FindMinimum(int[] arr)
    {
        return RecMinimum(arr, arr.Length - 1);
    }

    // RecMinimum goes here
    private static int RecMinimum(int[] arr, int index)
    {
        return RecMinimum(arr, index, int.MaxValue);
    }

    private static int RecMinimum(int[] arr, int currentIndex, int currentMin)
    {
        // Base case: If the current index is out of bounds, return the current minimum
        if (currentIndex < 0)
            return currentMin;

        // Update the current minimum if needed
        currentMin = Math.Min(currentMin, arr[currentIndex]);

        // Recursive case: Move to the next index
        return RecMinimum(arr, currentIndex - 1, currentMin);
    }
}