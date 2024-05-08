static class RecSearch
{
    public static int BinarySearch(int[] arr, int value)
    {
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    // Overload BinarySearch here
    private static int BinarySearch(int[] arr, int value, int first, int last)
    {
        if (first > last)
            return -1; // Number not found

        int middle = (first + last) / 2;

        if (arr[middle] == value) return middle; // Found the value at this index
        return arr[middle] > value
            ? BinarySearch(arr, value, first, middle - 1)
            : BinarySearch(arr, value, middle + 1, last);
    }
}