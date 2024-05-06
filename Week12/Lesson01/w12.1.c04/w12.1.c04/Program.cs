﻿public class Program
{
    private static Random? rand;

    public static void Main(string[] args)
    {
        int seed = Convert.ToInt32(args[1]);
        rand = new(seed);

        for (int i = 0; i < 5; i++)
        {
            int[] ints = GenerateRandomArray();
            Console.WriteLine(RecSumArray(ints));
        }
    }

    private static int[] GenerateRandomArray()
    {
        int length = rand.Next(0, 11); // Generate a random length between 1 and 10
        var arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = rand.Next(100); // Generate a random integer between 0 and 99
        }
        return arr;
    }

    //Method RecSumArray goes here
    public static int RecSumArray(int[] nums)
    {
        return RecSumArray(nums, nums.Length - 1);
    }
    
    public static int RecSumArray(int[] nums, int index)
    {
        return nums[index] + RecSumArray(nums, index - 1);
    }
}